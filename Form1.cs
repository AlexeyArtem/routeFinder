using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteFinder
{
    public partial class Form1 : Form
    {
        OpenStreetMapProvider mapProvider;
        int numberOfSetPoints; //Количество заданных точке на маршруте, 0 - не задано ни одной точки, 1 - начальная точка, 2 - конечная точка
        PointLatLng startPoint; //Отправная точка маршрута
        PointLatLng endPoint;   //Конечная точка маршрута
        GMapOverlay mapOverlay; //Слой для отображения маркеров и маршрутов


        public Form1()
        {
            mapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            numberOfSetPoints = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Настройка контрола Gmap
            gMapControl.MapProvider = mapProvider;
            GMaps.Instance.Mode = AccessMode.ServerAndCache; // Установка режима работы карты
            gMapControl.SetPositionByKeywords("Москва"); // Начальное положение карты
            gMapControl.ShowCenter = false; // Скрываем центральный крест
            gMapControl.Bearing = 0;
            gMapControl.CanDragMap = true; //CanDragMap - Если параметр установлен в True, пользователь может перетаскивать карту с помощью правой кнопки мыши.
            gMapControl.DragButton = MouseButtons.Left; //Указываем, что перетаскивание карты осуществляется с использованием левой клавишей мыши. По умолчанию - правая.
            gMapControl.GrayScaleMode = true;
            gMapControl.MarkersEnabled = true; //MarkersEnabled - Если параметр установлен в True, любые маркеры, заданные вручную будет показаны. Если нет, они не появятся.
            gMapControl.MaxZoom = 18; //Указываем значение максимального приближения.
            gMapControl.MinZoom = 2; //Указываем значение минимального приближения.
            gMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; //Устанавливаем центр приближения/удаления для курсора мыши.
            gMapControl.NegativeMode = false; //Отказываемся от негативного режима.
            gMapControl.PolygonsEnabled = true; //Разрешаем полигоны.
            gMapControl.RoutesEnabled = true; //Разрешаем маршруты.
            gMapControl.ShowTileGridLines = false; //Скрываем внешнюю сетку карты с заголовками.
            gMapControl.Zoom = 10; //Указываем, что при загрузке карты будет использоваться 10-ти кратное приближение.

            // Создание слоя для отображения маркеров и маршрутов
            mapOverlay = new GMapOverlay("overlay");
            gMapControl.Overlays.Add(mapOverlay);
            #endregion
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gMapControl.Manager.CancelTileCaching();
            gMapControl.Dispose();
        }

        private void gMapControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                if (numberOfSetPoints <= 2) 
                {
                    PointLatLng point = gMapControl.FromLocalToLatLng(e.X, e.Y);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
                    Placemark? placemark = mapProvider.GetPlacemark(point, out GeoCoderStatusCode statusCode);

                    switch (numberOfSetPoints)
                    {
                        case 0:
                            startPoint = point;
                            SetPointInfo(startPoint, placemark, tbAddressStartPoint, tbLongStartPoint, tbLatStartPoint);
                            break;
                        case 1:
                            endPoint = point;
                            SetPointInfo(endPoint, placemark, tbAddressEndPoint, tbLongEndPoint, tbLatEndPoint);
                            break;
                        case 2:
                            ClearPointsInfo();
                            startPoint = point;
                            SetPointInfo(startPoint, placemark, tbAddressStartPoint, tbLongStartPoint, tbLatStartPoint);
                            break;
                    }

                    numberOfSetPoints++;
                    mapOverlay.Markers.Add(marker);
                }
            }
        }

        private void SetPointInfo(PointLatLng point, Placemark? placemark, TextBox tbAddress, TextBox tbLong, TextBox tbLat) 
        {
            string address = string.Empty;
            if (placemark.HasValue) 
            {
                Placemark place = placemark.Value;
                string[] itemsAddress = new string[] 
                {
                    place.CountryName,
                    place.AdministrativeAreaName,
                    place.SubAdministrativeAreaName,
                    place.LocalityName,
                    place.ThoroughfareName,
                    place.StreetAddress,
                    place.HouseNo,
                    place.PostalCodeNumber
                };
                itemsAddress = itemsAddress.Where(s => !string.IsNullOrEmpty(s)).ToArray();

                address = string.Join(", ", itemsAddress);
            }

            tbAddress.Text = address;
            tbLong.Text = point.Lng.ToString();
            tbLat.Text = point.Lat.ToString();
        }

        private void ClearPointsInfo() 
        {
            startPoint = endPoint = PointLatLng.Empty;
            numberOfSetPoints = 0;
            mapOverlay.Markers.Clear();
            mapOverlay.Routes.Clear();

            tbAddressStartPoint.Text = tbAddressEndPoint.Text = string.Empty;
            tbLongStartPoint.Text = tbLatStartPoint.Text = string.Empty;
            tbLongEndPoint.Text = tbLatEndPoint.Text = string.Empty;
            tbDistance.Text = string.Empty;
        }

        private void btnFindRoute_Click(object sender, EventArgs e)
        {
            if (!startPoint.IsEmpty && !endPoint.IsEmpty)
            {
                bool avoidHighWays = cbAvoidHighways.Checked;
                bool walkingMode = cbWalkingMode.Checked;

                MapRoute mapRoute = mapProvider.GetRoute(startPoint, endPoint, avoidHighWays, walkingMode, (int)gMapControl.Zoom);
                if (mapRoute != null)
                {
                    GMapRoute route = new GMapRoute(mapRoute.Points, mapRoute.Name);
                    route.Stroke = new Pen(Color.Red, 4);

                    mapOverlay.Routes.Add(route);
                    gMapControl.ZoomAndCenterRoute(route);

                    tbDistance.Text = route.Distance.ToString() + " (км)";
                }
                else
                    MessageBox.Show("Не удалось найти маршрут.");
            }
            else
                MessageBox.Show("Не задана начальная и/или конечная точка маршрута.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPointsInfo();
        }
    }
}


namespace RouteFinder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLongStartPoint = new System.Windows.Forms.TextBox();
            this.tbLatStartPoint = new System.Windows.Forms.TextBox();
            this.tbLatEndPoint = new System.Windows.Forms.TextBox();
            this.tbLongEndPoint = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindRoute = new System.Windows.Forms.Button();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWalkingMode = new System.Windows.Forms.CheckBox();
            this.cbAvoidHighways = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAddressEndPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddressStartPoint = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(18, 12);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(1206, 563);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tbLongStartPoint);
            this.groupBox1.Controls.Add(this.tbLatStartPoint);
            this.groupBox1.Controls.Add(this.tbLatEndPoint);
            this.groupBox1.Controls.Add(this.tbLongEndPoint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnFindRoute);
            this.groupBox1.Controls.Add(this.tbDistance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbWalkingMode);
            this.groupBox1.Controls.Add(this.cbAvoidHighways);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbAddressEndPoint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAddressStartPoint);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управления";
            // 
            // tbLongStartPoint
            // 
            this.tbLongStartPoint.Location = new System.Drawing.Point(93, 64);
            this.tbLongStartPoint.Name = "tbLongStartPoint";
            this.tbLongStartPoint.ReadOnly = true;
            this.tbLongStartPoint.Size = new System.Drawing.Size(134, 22);
            this.tbLongStartPoint.TabIndex = 4;
            // 
            // tbLatStartPoint
            // 
            this.tbLatStartPoint.Location = new System.Drawing.Point(266, 64);
            this.tbLatStartPoint.Name = "tbLatStartPoint";
            this.tbLatStartPoint.ReadOnly = true;
            this.tbLatStartPoint.Size = new System.Drawing.Size(134, 22);
            this.tbLatStartPoint.TabIndex = 6;
            // 
            // tbLatEndPoint
            // 
            this.tbLatEndPoint.Location = new System.Drawing.Point(266, 135);
            this.tbLatEndPoint.Name = "tbLatEndPoint";
            this.tbLatEndPoint.ReadOnly = true;
            this.tbLatEndPoint.Size = new System.Drawing.Size(134, 22);
            this.tbLatEndPoint.TabIndex = 12;
            // 
            // tbLongEndPoint
            // 
            this.tbLongEndPoint.Location = new System.Drawing.Point(93, 135);
            this.tbLongEndPoint.Name = "tbLongEndPoint";
            this.tbLongEndPoint.ReadOnly = true;
            this.tbLongEndPoint.Size = new System.Drawing.Size(134, 22);
            this.tbLongEndPoint.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(394, 31);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Сбросить выбранные координаты";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFindRoute
            // 
            this.btnFindRoute.Location = new System.Drawing.Point(6, 254);
            this.btnFindRoute.Name = "btnFindRoute";
            this.btnFindRoute.Size = new System.Drawing.Size(394, 31);
            this.btnFindRoute.TabIndex = 18;
            this.btnFindRoute.Text = "Построить маршрут";
            this.btnFindRoute.UseVisualStyleBackColor = true;
            this.btnFindRoute.Click += new System.EventHandler(this.btnFindRoute_Click);
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(93, 175);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.ReadOnly = true;
            this.tbDistance.Size = new System.Drawing.Size(307, 22);
            this.tbDistance.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дистанция:";
            // 
            // cbWalkingMode
            // 
            this.cbWalkingMode.AutoSize = true;
            this.cbWalkingMode.Location = new System.Drawing.Point(258, 217);
            this.cbWalkingMode.Name = "cbWalkingMode";
            this.cbWalkingMode.Size = new System.Drawing.Size(142, 21);
            this.cbWalkingMode.TabIndex = 15;
            this.cbWalkingMode.Text = "Режим пешехода";
            this.cbWalkingMode.UseVisualStyleBackColor = true;
            // 
            // cbAvoidHighways
            // 
            this.cbAvoidHighways.AutoSize = true;
            this.cbAvoidHighways.Location = new System.Drawing.Point(9, 217);
            this.cbAvoidHighways.Name = "cbAvoidHighways";
            this.cbAvoidHighways.Size = new System.Drawing.Size(231, 21);
            this.cbAvoidHighways.TabIndex = 14;
            this.cbAvoidHighways.Text = "Не учитывать автомагистрали";
            this.cbAvoidHighways.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ш:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Д:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Куда:";
            // 
            // tbAddressEndPoint
            // 
            this.tbAddressEndPoint.Location = new System.Drawing.Point(72, 107);
            this.tbAddressEndPoint.Name = "tbAddressEndPoint";
            this.tbAddressEndPoint.ReadOnly = true;
            this.tbAddressEndPoint.Size = new System.Drawing.Size(328, 22);
            this.tbAddressEndPoint.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ш:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Д:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Откуда:";
            // 
            // tbAddressStartPoint
            // 
            this.tbAddressStartPoint.Location = new System.Drawing.Point(72, 36);
            this.tbAddressStartPoint.Name = "tbAddressStartPoint";
            this.tbAddressStartPoint.ReadOnly = true;
            this.tbAddressStartPoint.Size = new System.Drawing.Size(328, 22);
            this.tbAddressStartPoint.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gMapControl);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Поиск пути по координатам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAddressStartPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLongStartPoint;
        private System.Windows.Forms.Button btnFindRoute;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbWalkingMode;
        private System.Windows.Forms.CheckBox cbAvoidHighways;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLatEndPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLongEndPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAddressEndPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLatStartPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
    }
}


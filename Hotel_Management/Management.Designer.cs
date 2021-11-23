
namespace Hotel_Management
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CheckOutButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClientDetailButton = new Guna.UI2.WinForms.Guna2Button();
            this.ServiesButton = new Guna.UI2.WinForms.Guna2Button();
            this.PicSlide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.SettingButton = new Guna.UI2.WinForms.Guna2Button();
            this.RoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClientButton = new Guna.UI2.WinForms.Guna2Button();
            this.ReservationButton = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_CustomerDetails1 = new Hotel_Management.UC_CustomerDetails();
            this.uC_CheckOut1 = new Hotel_Management.UC_CheckOut();
            this.uC_AddUser1 = new Hotel_Management.UC_AddUser();
            this.uC_AddRoom1 = new Hotel_Management.UC_AddRoom();
            this.uC_DashBoard1 = new Hotel_Management.UC_DashBoard();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSlide)).BeginInit();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.MenuPanel;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.MenuPanel.Controls.Add(this.CheckOutButton);
            this.MenuPanel.Controls.Add(this.ClientDetailButton);
            this.MenuPanel.Controls.Add(this.ServiesButton);
            this.MenuPanel.Controls.Add(this.PicSlide);
            this.MenuPanel.Controls.Add(this.CloseButton);
            this.MenuPanel.Controls.Add(this.SettingButton);
            this.MenuPanel.Controls.Add(this.RoomButton);
            this.MenuPanel.Controls.Add(this.ClientButton);
            this.MenuPanel.Controls.Add(this.ReservationButton);
            this.MenuPanel.Controls.Add(this.DashboardButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.ShadowDecoration.Parent = this.MenuPanel;
            this.MenuPanel.Size = new System.Drawing.Size(241, 838);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Animated = true;
            this.CheckOutButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.CheckOutButton.CheckedState.Parent = this.CheckOutButton;
            this.CheckOutButton.CustomImages.Parent = this.CheckOutButton;
            this.CheckOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckOutButton.DisabledState.Parent = this.CheckOutButton;
            this.CheckOutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.CheckOutButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CheckOutButton.ForeColor = System.Drawing.Color.White;
            this.CheckOutButton.HoverState.Parent = this.CheckOutButton;
            this.CheckOutButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckOutButton.Image")));
            this.CheckOutButton.Location = new System.Drawing.Point(51, 297);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.ShadowDecoration.Parent = this.CheckOutButton;
            this.CheckOutButton.Size = new System.Drawing.Size(187, 57);
            this.CheckOutButton.TabIndex = 9;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ClientDetailButton
            // 
            this.ClientDetailButton.Animated = true;
            this.ClientDetailButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.ClientDetailButton.CheckedState.Parent = this.ClientDetailButton;
            this.ClientDetailButton.CustomImages.Parent = this.ClientDetailButton;
            this.ClientDetailButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientDetailButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClientDetailButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientDetailButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClientDetailButton.DisabledState.Parent = this.ClientDetailButton;
            this.ClientDetailButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.ClientDetailButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ClientDetailButton.ForeColor = System.Drawing.Color.White;
            this.ClientDetailButton.HoverState.Parent = this.ClientDetailButton;
            this.ClientDetailButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientDetailButton.Image")));
            this.ClientDetailButton.Location = new System.Drawing.Point(51, 234);
            this.ClientDetailButton.Name = "ClientDetailButton";
            this.ClientDetailButton.ShadowDecoration.Parent = this.ClientDetailButton;
            this.ClientDetailButton.Size = new System.Drawing.Size(187, 57);
            this.ClientDetailButton.TabIndex = 8;
            this.ClientDetailButton.Text = "Client Details";
            this.ClientDetailButton.Click += new System.EventHandler(this.ClientDetailButton_Click);
            // 
            // ServiesButton
            // 
            this.ServiesButton.Animated = true;
            this.ServiesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.ServiesButton.CheckedState.Parent = this.ServiesButton;
            this.ServiesButton.CustomImages.Parent = this.ServiesButton;
            this.ServiesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServiesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServiesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServiesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServiesButton.DisabledState.Parent = this.ServiesButton;
            this.ServiesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.ServiesButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ServiesButton.ForeColor = System.Drawing.Color.White;
            this.ServiesButton.HoverState.Parent = this.ServiesButton;
            this.ServiesButton.Image = ((System.Drawing.Image)(resources.GetObject("ServiesButton.Image")));
            this.ServiesButton.Location = new System.Drawing.Point(54, 486);
            this.ServiesButton.Name = "ServiesButton";
            this.ServiesButton.ShadowDecoration.Parent = this.ServiesButton;
            this.ServiesButton.Size = new System.Drawing.Size(184, 57);
            this.ServiesButton.TabIndex = 7;
            this.ServiesButton.Text = "Services";
            this.ServiesButton.Click += new System.EventHandler(this.ServiesButton_Click);
            // 
            // PicSlide
            // 
            this.PicSlide.Image = ((System.Drawing.Image)(resources.GetObject("PicSlide.Image")));
            this.PicSlide.ImageRotate = 0F;
            this.PicSlide.Location = new System.Drawing.Point(3, 102);
            this.PicSlide.Name = "PicSlide";
            this.PicSlide.ShadowDecoration.Parent = this.PicSlide;
            this.PicSlide.Size = new System.Drawing.Size(42, 63);
            this.PicSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSlide.TabIndex = 6;
            this.PicSlide.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Animated = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.CustomImages.Parent = this.CloseButton;
            this.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButton.DisabledState.Parent = this.CloseButton;
            this.CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.HoverState.Parent = this.CloseButton;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(57, 683);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(158, 57);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseTransparentBackground = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // SettingButton
            // 
            this.SettingButton.Animated = true;
            this.SettingButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.SettingButton.CheckedState.Parent = this.SettingButton;
            this.SettingButton.CustomImages.Parent = this.SettingButton;
            this.SettingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingButton.DisabledState.Parent = this.SettingButton;
            this.SettingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.SettingButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SettingButton.ForeColor = System.Drawing.Color.White;
            this.SettingButton.HoverState.Parent = this.SettingButton;
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.Location = new System.Drawing.Point(57, 549);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.ShadowDecoration.Parent = this.SettingButton;
            this.SettingButton.Size = new System.Drawing.Size(184, 57);
            this.SettingButton.TabIndex = 4;
            this.SettingButton.Text = "Setting";
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // RoomButton
            // 
            this.RoomButton.Animated = true;
            this.RoomButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.RoomButton.CheckedState.Parent = this.RoomButton;
            this.RoomButton.CustomImages.Parent = this.RoomButton;
            this.RoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RoomButton.DisabledState.Parent = this.RoomButton;
            this.RoomButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.RoomButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.RoomButton.ForeColor = System.Drawing.Color.White;
            this.RoomButton.HoverState.Parent = this.RoomButton;
            this.RoomButton.Image = ((System.Drawing.Image)(resources.GetObject("RoomButton.Image")));
            this.RoomButton.Location = new System.Drawing.Point(51, 423);
            this.RoomButton.Name = "RoomButton";
            this.RoomButton.ShadowDecoration.Parent = this.RoomButton;
            this.RoomButton.Size = new System.Drawing.Size(184, 57);
            this.RoomButton.TabIndex = 3;
            this.RoomButton.Text = "Room";
            this.RoomButton.Click += new System.EventHandler(this.RoomButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Animated = true;
            this.ClientButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.ClientButton.CheckedState.Parent = this.ClientButton;
            this.ClientButton.CustomImages.Parent = this.ClientButton;
            this.ClientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClientButton.DisabledState.Parent = this.ClientButton;
            this.ClientButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.ClientButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ClientButton.ForeColor = System.Drawing.Color.White;
            this.ClientButton.HoverState.Parent = this.ClientButton;
            this.ClientButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientButton.Image")));
            this.ClientButton.Location = new System.Drawing.Point(51, 360);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.ShadowDecoration.Parent = this.ClientButton;
            this.ClientButton.Size = new System.Drawing.Size(187, 57);
            this.ClientButton.TabIndex = 2;
            this.ClientButton.Text = "Client";
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.Animated = true;
            this.ReservationButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.ReservationButton.CheckedState.Parent = this.ReservationButton;
            this.ReservationButton.CustomImages.Parent = this.ReservationButton;
            this.ReservationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReservationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReservationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReservationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReservationButton.DisabledState.Parent = this.ReservationButton;
            this.ReservationButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.ReservationButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ReservationButton.ForeColor = System.Drawing.Color.White;
            this.ReservationButton.HoverState.Parent = this.ReservationButton;
            this.ReservationButton.Image = ((System.Drawing.Image)(resources.GetObject("ReservationButton.Image")));
            this.ReservationButton.Location = new System.Drawing.Point(51, 171);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.ShadowDecoration.Parent = this.ReservationButton;
            this.ReservationButton.Size = new System.Drawing.Size(187, 57);
            this.ReservationButton.TabIndex = 1;
            this.ReservationButton.Text = "Reservation";
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Animated = true;
            this.DashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.DashboardButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.DashboardButton.CheckedState.Parent = this.DashboardButton;
            this.DashboardButton.CustomImages.Parent = this.DashboardButton;
            this.DashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardButton.DisabledState.Parent = this.DashboardButton;
            this.DashboardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(144)))));
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.HoverState.Parent = this.DashboardButton;
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.Location = new System.Drawing.Point(51, 102);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.ShadowDecoration.Parent = this.DashboardButton;
            this.DashboardButton.Size = new System.Drawing.Size(184, 57);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseTransparentBackground = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click_1);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.CenterPanel;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.uC_AddUser1);
            this.CenterPanel.Controls.Add(this.uC_AddRoom1);
            this.CenterPanel.Controls.Add(this.uC_DashBoard1);
            this.CenterPanel.Controls.Add(this.uC_CustomerDetails1);
            this.CenterPanel.Controls.Add(this.uC_CheckOut1);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CenterPanel.Location = new System.Drawing.Point(241, 67);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.ShadowDecoration.Parent = this.CenterPanel;
            this.CenterPanel.Size = new System.Drawing.Size(1227, 768);
            this.CenterPanel.TabIndex = 2;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1227, 768);
            this.uC_CustomerDetails1.TabIndex = 5;
            this.uC_CustomerDetails1.Visible = false;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uC_CheckOut1.Location = new System.Drawing.Point(0, 0);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1227, 771);
            this.uC_CheckOut1.TabIndex = 4;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uC_AddUser1.Location = new System.Drawing.Point(-3, -3);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1227, 768);
            this.uC_AddUser1.TabIndex = 3;
            this.uC_AddUser1.Visible = false;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.Gold;
            this.uC_AddRoom1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1227, 771);
            this.uC_AddRoom1.TabIndex = 2;
            this.uC_AddRoom1.Visible = false;
            // 
            // uC_DashBoard1
            // 
            this.uC_DashBoard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_DashBoard1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uC_DashBoard1.Location = new System.Drawing.Point(0, 0);
            this.uC_DashBoard1.Name = "uC_DashBoard1";
            this.uC_DashBoard1.Size = new System.Drawing.Size(1227, 771);
            this.uC_DashBoard1.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(241, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(1227, 67);
            this.TopPanel.TabIndex = 1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 50;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 838);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1034);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicSlide)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Panel MenuPanel;
        private Guna.UI2.WinForms.Guna2Button DashboardButton;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Guna.UI2.WinForms.Guna2Button SettingButton;
        private Guna.UI2.WinForms.Guna2Button RoomButton;
        private Guna.UI2.WinForms.Guna2Button ClientButton;
        private Guna.UI2.WinForms.Guna2Button ReservationButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Button ServiesButton;
        private Guna.UI2.WinForms.Guna2PictureBox PicSlide;
        private UC_DashBoard uC_DashBoard1;
        private Guna.UI2.WinForms.Guna2Button CheckOutButton;
        private Guna.UI2.WinForms.Guna2Button ClientDetailButton;
        private UC_AddRoom uC_AddRoom1;
        private UC_AddUser uC_AddUser1;
        private UC_CustomerDetails uC_CustomerDetails1;
        private UC_CheckOut uC_CheckOut1;
    }
}
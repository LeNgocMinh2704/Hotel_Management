
namespace Hotel_Management
{
    partial class UC_AddRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddRoom));
            this.ComboBoxBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonAddRoom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataGridViewAddRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxRoomID = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxBed
            // 
            this.ComboBoxBed.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBed.FocusedState.Parent = this.ComboBoxBed;
            this.ComboBoxBed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxBed.HoverState.Parent = this.ComboBoxBed;
            this.ComboBoxBed.ItemHeight = 30;
            this.ComboBoxBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.ComboBoxBed.ItemsAppearance.Parent = this.ComboBoxBed;
            this.ComboBoxBed.Location = new System.Drawing.Point(909, 388);
            this.ComboBoxBed.Name = "ComboBoxBed";
            this.ComboBoxBed.ShadowDecoration.Parent = this.ComboBoxBed;
            this.ComboBoxBed.Size = new System.Drawing.Size(295, 36);
            this.ComboBoxBed.TabIndex = 0;
            // 
            // ComboBoxRoomType
            // 
            this.ComboBoxRoomType.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxRoomType.FocusedState.Parent = this.ComboBoxRoomType;
            this.ComboBoxRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxRoomType.HoverState.Parent = this.ComboBoxRoomType;
            this.ComboBoxRoomType.ItemHeight = 30;
            this.ComboBoxRoomType.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.ComboBoxRoomType.ItemsAppearance.Parent = this.ComboBoxRoomType;
            this.ComboBoxRoomType.Location = new System.Drawing.Point(901, 296);
            this.ComboBoxRoomType.Name = "ComboBoxRoomType";
            this.ComboBoxRoomType.ShadowDecoration.Parent = this.ComboBoxRoomType;
            this.ComboBoxRoomType.Size = new System.Drawing.Size(295, 36);
            this.ComboBoxRoomType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room Number";
            // 
            // TextBoxRoomNumber
            // 
            this.TextBoxRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRoomNumber.DefaultText = "";
            this.TextBoxRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRoomNumber.DisabledState.Parent = this.TextBoxRoomNumber;
            this.TextBoxRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRoomNumber.FocusedState.Parent = this.TextBoxRoomNumber;
            this.TextBoxRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRoomNumber.HoverState.Parent = this.TextBoxRoomNumber;
            this.TextBoxRoomNumber.Location = new System.Drawing.Point(901, 193);
            this.TextBoxRoomNumber.Name = "TextBoxRoomNumber";
            this.TextBoxRoomNumber.PasswordChar = '\0';
            this.TextBoxRoomNumber.PlaceholderText = "";
            this.TextBoxRoomNumber.SelectedText = "";
            this.TextBoxRoomNumber.ShadowDecoration.Parent = this.TextBoxRoomNumber;
            this.TextBoxRoomNumber.Size = new System.Drawing.Size(295, 38);
            this.TextBoxRoomNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(904, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bed";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice.DefaultText = "";
            this.TextBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrice.DisabledState.Parent = this.TextBoxPrice;
            this.TextBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrice.FocusedState.Parent = this.TextBoxPrice;
            this.TextBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrice.HoverState.Parent = this.TextBoxPrice;
            this.TextBoxPrice.Location = new System.Drawing.Point(909, 475);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.PasswordChar = '\0';
            this.TextBoxPrice.PlaceholderText = "";
            this.TextBoxPrice.SelectedText = "";
            this.TextBoxPrice.ShadowDecoration.Parent = this.TextBoxPrice;
            this.TextBoxPrice.Size = new System.Drawing.Size(295, 38);
            this.TextBoxPrice.TabIndex = 9;
            // 
            // ButtonAddRoom
            // 
            this.ButtonAddRoom.Animated = true;
            this.ButtonAddRoom.AutoRoundedCorners = true;
            this.ButtonAddRoom.BorderRadius = 23;
            this.ButtonAddRoom.CheckedState.Parent = this.ButtonAddRoom;
            this.ButtonAddRoom.CustomImages.Parent = this.ButtonAddRoom;
            this.ButtonAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddRoom.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddRoom.DisabledState.Parent = this.ButtonAddRoom;
            this.ButtonAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddRoom.ForeColor = System.Drawing.Color.White;
            this.ButtonAddRoom.HoverState.Parent = this.ButtonAddRoom;
            this.ButtonAddRoom.Location = new System.Drawing.Point(901, 530);
            this.ButtonAddRoom.Name = "ButtonAddRoom";
            this.ButtonAddRoom.ShadowDecoration.Parent = this.ButtonAddRoom;
            this.ButtonAddRoom.Size = new System.Drawing.Size(303, 49);
            this.ButtonAddRoom.TabIndex = 10;
            this.ButtonAddRoom.Text = "Add Room";
            this.ButtonAddRoom.Click += new System.EventHandler(this.ButtonAddRoom_Click);
            // 
            // DataGridViewAddRoom
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewAddRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAddRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAddRoom.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewAddRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewAddRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewAddRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAddRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAddRoom.ColumnHeadersHeight = 32;
            this.DataGridViewAddRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomid,
            this.roomNo,
            this.roomType,
            this.bed,
            this.price,
            this.booked});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAddRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewAddRoom.EnableHeadersVisualStyles = false;
            this.DataGridViewAddRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAddRoom.Location = new System.Drawing.Point(0, 86);
            this.DataGridViewAddRoom.Name = "DataGridViewAddRoom";
            this.DataGridViewAddRoom.RowHeadersVisible = false;
            this.DataGridViewAddRoom.RowHeadersWidth = 62;
            this.DataGridViewAddRoom.RowTemplate.Height = 28;
            this.DataGridViewAddRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAddRoom.Size = new System.Drawing.Size(836, 518);
            this.DataGridViewAddRoom.TabIndex = 11;
            this.DataGridViewAddRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAddRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewAddRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewAddRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewAddRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewAddRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAddRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAddRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewAddRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewAddRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewAddRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewAddRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewAddRoom.ThemeStyle.HeaderStyle.Height = 32;
            this.DataGridViewAddRoom.ThemeStyle.ReadOnly = false;
            this.DataGridViewAddRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAddRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewAddRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewAddRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewAddRoom.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridViewAddRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAddRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SearchBox
            // 
            this.SearchBox.AutoRoundedCorners = true;
            this.SearchBox.BorderRadius = 23;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.Parent = this.SearchBox;
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.FocusedState.Parent = this.SearchBox;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.HoverState.Parent = this.SearchBox;
            this.SearchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("SearchBox.IconLeft")));
            this.SearchBox.Location = new System.Drawing.Point(162, 11);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.Parent = this.SearchBox;
            this.SearchBox.Size = new System.Drawing.Size(477, 49);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(896, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Room ID";
            // 
            // TextBoxRoomID
            // 
            this.TextBoxRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRoomID.DefaultText = "";
            this.TextBoxRoomID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxRoomID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxRoomID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRoomID.DisabledState.Parent = this.TextBoxRoomID;
            this.TextBoxRoomID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRoomID.FocusedState.Parent = this.TextBoxRoomID;
            this.TextBoxRoomID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxRoomID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxRoomID.HoverState.Parent = this.TextBoxRoomID;
            this.TextBoxRoomID.Location = new System.Drawing.Point(901, 72);
            this.TextBoxRoomID.Name = "TextBoxRoomID";
            this.TextBoxRoomID.PasswordChar = '\0';
            this.TextBoxRoomID.PlaceholderText = "";
            this.TextBoxRoomID.SelectedText = "";
            this.TextBoxRoomID.ShadowDecoration.Parent = this.TextBoxRoomID;
            this.TextBoxRoomID.Size = new System.Drawing.Size(295, 38);
            this.TextBoxRoomID.TabIndex = 14;
            // 
            // roomid
            // 
            this.roomid.DataPropertyName = "roomid";
            this.roomid.HeaderText = "roomid";
            this.roomid.MinimumWidth = 8;
            this.roomid.Name = "roomid";
            // 
            // roomNo
            // 
            this.roomNo.DataPropertyName = "roomNo";
            this.roomNo.HeaderText = "roomNo";
            this.roomNo.MinimumWidth = 8;
            this.roomNo.Name = "roomNo";
            // 
            // roomType
            // 
            this.roomType.DataPropertyName = "roomType";
            this.roomType.HeaderText = "roomType";
            this.roomType.MinimumWidth = 8;
            this.roomType.Name = "roomType";
            // 
            // bed
            // 
            this.bed.DataPropertyName = "bed";
            this.bed.HeaderText = "bed";
            this.bed.MinimumWidth = 8;
            this.bed.Name = "bed";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            // 
            // booked
            // 
            this.booked.DataPropertyName = "booked";
            this.booked.HeaderText = "booked";
            this.booked.MinimumWidth = 8;
            this.booked.Name = "booked";
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.TextBoxRoomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DataGridViewAddRoom);
            this.Controls.Add(this.ButtonAddRoom);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxRoomNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxRoomType);
            this.Controls.Add(this.ComboBoxBed);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(1237, 604);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxBed;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxRoomType;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPrice;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonAddRoom;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAddRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn bed;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn booked;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxRoomID;
    }
}

namespace QlyDVCuoi.Formm
{
    partial class FormThemHDcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grKH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnThemHD = new Guna.UI2.WinForms.Guna2Button();
            this.dateNgayThue = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Ma_Don = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Thue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableHD)).BeginInit();
            this.grKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableHD
            // 
            this.tableHD.AllowUserToAddRows = false;
            this.tableHD.AllowUserToDeleteRows = false;
            this.tableHD.AllowUserToOrderColumns = true;
            this.tableHD.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.tableHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableHD.ColumnHeadersHeight = 50;
            this.tableHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Don,
            this.Ma_DV,
            this.Ngay_Thue,
            this.Ten_KH,
            this.Ma_KH});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableHD.Location = new System.Drawing.Point(0, 355);
            this.tableHD.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tableHD.Name = "tableHD";
            this.tableHD.ReadOnly = true;
            this.tableHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableHD.RowHeadersVisible = false;
            this.tableHD.RowHeadersWidth = 51;
            this.tableHD.RowTemplate.Height = 24;
            this.tableHD.Size = new System.Drawing.Size(868, 283);
            this.tableHD.TabIndex = 38;
            this.tableHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableHD.ThemeStyle.HeaderStyle.Height = 50;
            this.tableHD.ThemeStyle.ReadOnly = true;
            this.tableHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableHD.ThemeStyle.RowsStyle.Height = 24;
            this.tableHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.BackColor = System.Drawing.Color.Transparent;
            this.txtMaKH.BorderColor = System.Drawing.Color.DimGray;
            this.txtMaKH.BorderRadius = 10;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(507, 191);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(315, 42);
            this.txtMaKH.TabIndex = 12;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.BackColor = System.Drawing.Color.Transparent;
            this.txtTenKH.BorderColor = System.Drawing.Color.DimGray;
            this.txtTenKH.BorderRadius = 10;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Location = new System.Drawing.Point(507, 104);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(315, 42);
            this.txtTenKH.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(503, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(503, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên khách hàng";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDV.BackColor = System.Drawing.Color.Transparent;
            this.txtMaDV.BorderColor = System.Drawing.Color.DimGray;
            this.txtMaDV.BorderRadius = 10;
            this.txtMaDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDV.DefaultText = "";
            this.txtMaDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDV.ForeColor = System.Drawing.Color.Black;
            this.txtMaDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDV.Location = new System.Drawing.Point(49, 191);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.PasswordChar = '\0';
            this.txtMaDV.PlaceholderText = "";
            this.txtMaDV.SelectedText = "";
            this.txtMaDV.Size = new System.Drawing.Size(315, 42);
            this.txtMaDV.TabIndex = 5;
            // 
            // txtMaD
            // 
            this.txtMaD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaD.BackColor = System.Drawing.Color.Transparent;
            this.txtMaD.BorderColor = System.Drawing.Color.DimGray;
            this.txtMaD.BorderRadius = 10;
            this.txtMaD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaD.DefaultText = "";
            this.txtMaD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaD.ForeColor = System.Drawing.Color.Black;
            this.txtMaD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaD.Location = new System.Drawing.Point(49, 104);
            this.txtMaD.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMaD.Name = "txtMaD";
            this.txtMaD.PasswordChar = '\0';
            this.txtMaD.PlaceholderText = "";
            this.txtMaD.SelectedText = "";
            this.txtMaD.Size = new System.Drawing.Size(315, 42);
            this.txtMaD.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(45, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thuê";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đơn";
            // 
            // grKH
            // 
            this.grKH.Controls.Add(this.dateNgayThue);
            this.grKH.Controls.Add(this.txtMaKH);
            this.grKH.Controls.Add(this.txtTenKH);
            this.grKH.Controls.Add(this.btnThemHD);
            this.grKH.Controls.Add(this.label6);
            this.grKH.Controls.Add(this.label5);
            this.grKH.Controls.Add(this.txtMaDV);
            this.grKH.Controls.Add(this.txtMaD);
            this.grKH.Controls.Add(this.label4);
            this.grKH.Controls.Add(this.label2);
            this.grKH.Controls.Add(this.label1);
            this.grKH.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grKH.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grKH.ForeColor = System.Drawing.Color.Snow;
            this.grKH.Location = new System.Drawing.Point(0, 0);
            this.grKH.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grKH.Name = "grKH";
            this.grKH.Size = new System.Drawing.Size(868, 347);
            this.grKH.TabIndex = 36;
            this.grKH.Text = "Thông tin thêm hóa đơn";
            this.grKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemHD.BackColor = System.Drawing.Color.Transparent;
            this.btnThemHD.BorderRadius = 10;
            this.btnThemHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemHD.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemHD.ForeColor = System.Drawing.Color.Snow;
            this.btnThemHD.HoverState.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemHD.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemHD.Location = new System.Drawing.Point(555, 275);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(217, 52);
            this.btnThemHD.TabIndex = 37;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // dateNgayThue
            // 
            this.dateNgayThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNgayThue.BackColor = System.Drawing.Color.Transparent;
            this.dateNgayThue.BorderRadius = 10;
            this.dateNgayThue.Checked = true;
            this.dateNgayThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNgayThue.Location = new System.Drawing.Point(49, 285);
            this.dateNgayThue.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayThue.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayThue.Name = "dateNgayThue";
            this.dateNgayThue.Size = new System.Drawing.Size(315, 42);
            this.dateNgayThue.TabIndex = 38;
            this.dateNgayThue.Value = new System.DateTime(2024, 4, 27, 0, 26, 13, 171);
            // 
            // Ma_Don
            // 
            this.Ma_Don.DataPropertyName = "Ma_Don";
            this.Ma_Don.HeaderText = "Mã Đơn";
            this.Ma_Don.MinimumWidth = 6;
            this.Ma_Don.Name = "Ma_Don";
            this.Ma_Don.ReadOnly = true;
            // 
            // Ma_DV
            // 
            this.Ma_DV.DataPropertyName = "Ma_DV";
            this.Ma_DV.FillWeight = 66.38287F;
            this.Ma_DV.HeaderText = "Mã dịch vụ";
            this.Ma_DV.MinimumWidth = 6;
            this.Ma_DV.Name = "Ma_DV";
            this.Ma_DV.ReadOnly = true;
            // 
            // Ngay_Thue
            // 
            this.Ngay_Thue.DataPropertyName = "ThueNgay_";
            this.Ngay_Thue.FillWeight = 78.35511F;
            this.Ngay_Thue.HeaderText = "Ngày Thuê";
            this.Ngay_Thue.MinimumWidth = 6;
            this.Ngay_Thue.Name = "Ngay_Thue";
            this.Ngay_Thue.ReadOnly = true;
            // 
            // Ten_KH
            // 
            this.Ten_KH.DataPropertyName = "Ten_KH";
            this.Ten_KH.HeaderText = "Tên Khách Hàng";
            this.Ten_KH.MinimumWidth = 6;
            this.Ten_KH.Name = "Ten_KH";
            this.Ten_KH.ReadOnly = true;
            // 
            // Ma_KH
            // 
            this.Ma_KH.HeaderText = "Mã Khách Hàng";
            this.Ma_KH.MinimumWidth = 6;
            this.Ma_KH.Name = "Ma_KH";
            this.Ma_KH.ReadOnly = true;
            // 
            // FormThemHDcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 638);
            this.Controls.Add(this.tableHD);
            this.Controls.Add(this.grKH);
            this.Name = "FormThemHDcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM HÓA ĐƠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThemHDcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableHD)).EndInit();
            this.grKH.ResumeLayout(false);
            this.grKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView tableHD;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox grKH;
        private Guna.UI2.WinForms.Guna2Button btnThemHD;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Don;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Thue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KH;
    }
}
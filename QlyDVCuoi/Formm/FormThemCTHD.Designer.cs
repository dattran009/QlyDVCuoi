namespace QlyDVCuoi.Formm
{
    partial class FormThemCTHD
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
            this.btnThemHD = new Guna.UI2.WinForms.Guna2Button();
            this.grKH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbMa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoLg = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma_Don = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnThemHD.Location = new System.Drawing.Point(532, 263);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(244, 56);
            this.btnThemHD.TabIndex = 37;
            this.btnThemHD.Text = "Thêm Chi Tiết hóa đơn";
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // grKH
            // 
            this.grKH.Controls.Add(this.dataGridView1);
            this.grKH.Controls.Add(this.cbMa);
            this.grKH.Controls.Add(this.txtSoLg);
            this.grKH.Controls.Add(this.txtDgia);
            this.grKH.Controls.Add(this.btnThemHD);
            this.grKH.Controls.Add(this.label6);
            this.grKH.Controls.Add(this.label5);
            this.grKH.Controls.Add(this.txtTenDV);
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
            this.grKH.Size = new System.Drawing.Size(973, 347);
            this.grKH.TabIndex = 39;
            this.grKH.Text = "Thông tin thêm hóa đơn";
            this.grKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMa
            // 
            this.cbMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMa.BackColor = System.Drawing.Color.Transparent;
            this.cbMa.BorderColor = System.Drawing.Color.DimGray;
            this.cbMa.BorderRadius = 10;
            this.cbMa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMa.ItemHeight = 30;
            this.cbMa.Location = new System.Drawing.Point(26, 189);
            this.cbMa.Name = "cbMa";
            this.cbMa.Size = new System.Drawing.Size(315, 36);
            this.cbMa.TabIndex = 39;
            this.cbMa.SelectedIndexChanged += new System.EventHandler(this.cbTenDV_SelectedIndexChanged);
            // 
            // txtSoLg
            // 
            this.txtSoLg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLg.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLg.BorderColor = System.Drawing.Color.DimGray;
            this.txtSoLg.BorderRadius = 10;
            this.txtSoLg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLg.DefaultText = "";
            this.txtSoLg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLg.ForeColor = System.Drawing.Color.Black;
            this.txtSoLg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLg.Location = new System.Drawing.Point(484, 183);
            this.txtSoLg.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSoLg.Name = "txtSoLg";
            this.txtSoLg.PasswordChar = '\0';
            this.txtSoLg.PlaceholderText = "";
            this.txtSoLg.SelectedText = "";
            this.txtSoLg.Size = new System.Drawing.Size(315, 42);
            this.txtSoLg.TabIndex = 38;
            // 
            // txtDgia
            // 
            this.txtDgia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDgia.BackColor = System.Drawing.Color.Transparent;
            this.txtDgia.BorderColor = System.Drawing.Color.DimGray;
            this.txtDgia.BorderRadius = 10;
            this.txtDgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDgia.DefaultText = "";
            this.txtDgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDgia.ForeColor = System.Drawing.Color.Black;
            this.txtDgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDgia.Location = new System.Drawing.Point(484, 96);
            this.txtDgia.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDgia.Name = "txtDgia";
            this.txtDgia.PasswordChar = '\0';
            this.txtDgia.PlaceholderText = "";
            this.txtDgia.SelectedText = "";
            this.txtDgia.Size = new System.Drawing.Size(315, 42);
            this.txtDgia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(22, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên dịch vụ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(480, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn giá";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenDV.BackColor = System.Drawing.Color.Transparent;
            this.txtTenDV.BorderColor = System.Drawing.Color.DimGray;
            this.txtTenDV.BorderRadius = 10;
            this.txtTenDV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDV.DefaultText = "";
            this.txtTenDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDV.Enabled = false;
            this.txtTenDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDV.ForeColor = System.Drawing.Color.Black;
            this.txtTenDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDV.Location = new System.Drawing.Point(26, 289);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.PasswordChar = '\0';
            this.txtTenDV.PlaceholderText = "";
            this.txtTenDV.SelectedText = "";
            this.txtTenDV.Size = new System.Drawing.Size(315, 42);
            this.txtTenDV.TabIndex = 5;
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
            this.txtMaD.Location = new System.Drawing.Point(26, 96);
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
            this.label4.Location = new System.Drawing.Point(480, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 152);
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
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đơn";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToOrderColumns = true;
            this.table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table.ColumnHeadersHeight = 50;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Don,
            this.Ma_DV,
            this.So_Luong,
            this.Don_Gia,
            this.Tong_Tien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle3;
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table.Location = new System.Drawing.Point(0, 355);
            this.table.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(973, 345);
            this.table.TabIndex = 40;
            this.table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table.ThemeStyle.HeaderStyle.Height = 50;
            this.table.ThemeStyle.ReadOnly = true;
            this.table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table.ThemeStyle.RowsStyle.Height = 24;
            this.table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(952, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(18, 17);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.Visible = false;
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
            // So_Luong
            // 
            this.So_Luong.DataPropertyName = "So_Luong";
            this.So_Luong.FillWeight = 78.35511F;
            this.So_Luong.HeaderText = "Số lượng";
            this.So_Luong.MinimumWidth = 6;
            this.So_Luong.Name = "So_Luong";
            this.So_Luong.ReadOnly = true;
            // 
            // Don_Gia
            // 
            this.Don_Gia.DataPropertyName = "Don_Gia";
            this.Don_Gia.HeaderText = "Đơn giá";
            this.Don_Gia.MinimumWidth = 6;
            this.Don_Gia.Name = "Don_Gia";
            this.Don_Gia.ReadOnly = true;
            // 
            // Tong_Tien
            // 
            this.Tong_Tien.DataPropertyName = "Tong_Tien";
            this.Tong_Tien.HeaderText = "Tổng Tiền";
            this.Tong_Tien.MinimumWidth = 6;
            this.Tong_Tien.Name = "Tong_Tien";
            this.Tong_Tien.ReadOnly = true;
            // 
            // FormThemCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 700);
            this.Controls.Add(this.grKH);
            this.Controls.Add(this.table);
            this.Name = "FormThemCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM CHI TIẾT HÓA ĐƠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThemCTHD_Load);
            this.grKH.ResumeLayout(false);
            this.grKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThemHD;
        private Guna.UI2.WinForms.Guna2GroupBox grKH;
        private Guna.UI2.WinForms.Guna2TextBox txtDgia;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView table;
        private Guna.UI2.WinForms.Guna2ComboBox cbMa;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Don;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_Tien;
    }
}
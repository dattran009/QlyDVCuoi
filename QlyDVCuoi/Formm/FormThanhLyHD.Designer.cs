namespace QlyDVCuoi.Formm
{
    partial class FormThanhLyHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Ma_Don = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Thue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnChothue = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToOrderColumns = true;
            this.table.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.table.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.table.ColumnHeadersHeight = 50;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Don,
            this.Ma_DV,
            this.Ten_DV,
            this.Ma_KH,
            this.So_,
            this.Don_Gia,
            this.Ngay_Thue,
            this.Tong_Tien});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle15;
            this.table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table.Location = new System.Drawing.Point(1, 142);
            this.table.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(889, 358);
            this.table.TabIndex = 39;
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
            // Ma_Don
            // 
            this.Ma_Don.DataPropertyName = "Ma_Don";
            this.Ma_Don.HeaderText = "Mã đơn";
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
            // Ten_DV
            // 
            this.Ten_DV.DataPropertyName = "Ten_DV";
            this.Ten_DV.HeaderText = "Tên dịch vụ";
            this.Ten_DV.MinimumWidth = 6;
            this.Ten_DV.Name = "Ten_DV";
            this.Ten_DV.ReadOnly = true;
            // 
            // Ma_KH
            // 
            this.Ma_KH.HeaderText = "Mã khách hàng";
            this.Ma_KH.MinimumWidth = 6;
            this.Ma_KH.Name = "Ma_KH";
            this.Ma_KH.ReadOnly = true;
            // 
            // So_
            // 
            this.So_.DataPropertyName = "So_Luong";
            this.So_.HeaderText = "Số lượng";
            this.So_.MinimumWidth = 6;
            this.So_.Name = "So_";
            this.So_.ReadOnly = true;
            // 
            // Don_Gia
            // 
            this.Don_Gia.DataPropertyName = "Don_Gia";
            this.Don_Gia.HeaderText = "Đơn giá";
            this.Don_Gia.MinimumWidth = 6;
            this.Don_Gia.Name = "Don_Gia";
            this.Don_Gia.ReadOnly = true;
            // 
            // Ngay_Thue
            // 
            this.Ngay_Thue.DataPropertyName = "Ngay_Thue";
            this.Ngay_Thue.FillWeight = 78.35511F;
            this.Ngay_Thue.HeaderText = "Ngày thuê";
            this.Ngay_Thue.MinimumWidth = 6;
            this.Ngay_Thue.Name = "Ngay_Thue";
            this.Ngay_Thue.ReadOnly = true;
            // 
            // Tong_Tien
            // 
            this.Tong_Tien.DataPropertyName = "Tong_Tien";
            this.Tong_Tien.HeaderText = "Tổng tiền";
            this.Tong_Tien.MinimumWidth = 6;
            this.Tong_Tien.Name = "Tong_Tien";
            this.Tong_Tien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "Thanh lý hợp đồng với hóa đơn";
            // 
            // cbMaD
            // 
            this.cbMaD.BackColor = System.Drawing.Color.Transparent;
            this.cbMaD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaD.ForeColor = System.Drawing.Color.Black;
            this.cbMaD.ItemHeight = 30;
            this.cbMaD.Location = new System.Drawing.Point(379, 52);
            this.cbMaD.Name = "cbMaD";
            this.cbMaD.Size = new System.Drawing.Size(253, 36);
            this.cbMaD.TabIndex = 40;
            this.cbMaD.SelectedIndexChanged += new System.EventHandler(this.cbMaD_SelectedIndexChanged);
            // 
            // btnChothue
            // 
            this.btnChothue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChothue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChothue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChothue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChothue.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChothue.ForeColor = System.Drawing.Color.Snow;
            this.btnChothue.HoverState.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChothue.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChothue.Location = new System.Drawing.Point(671, 52);
            this.btnChothue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnChothue.Name = "btnChothue";
            this.btnChothue.Size = new System.Drawing.Size(201, 51);
            this.btnChothue.TabIndex = 38;
            this.btnChothue.Text = "Xóa hợp đồng";
            this.btnChothue.Click += new System.EventHandler(this.btnChothue_Click);
            // 
            // FormThanhLyHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 490);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaD);
            this.Controls.Add(this.btnChothue);
            this.Name = "FormThanhLyHD";
            this.Text = "THANH LÝ HỢP ĐỒNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThanhLyHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Don;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Thue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_Tien;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaD;
        private Guna.UI2.WinForms.Guna2Button btnChothue;
    }
}
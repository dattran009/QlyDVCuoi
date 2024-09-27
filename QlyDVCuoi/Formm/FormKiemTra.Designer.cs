namespace QlyDVCuoi.Formm
{
    partial class FormKiemTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKiemTra));
            this.tableDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Ma_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trang_Thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableDV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDV
            // 
            this.tableDV.AllowUserToAddRows = false;
            this.tableDV.AllowUserToDeleteRows = false;
            this.tableDV.AllowUserToOrderColumns = true;
            this.tableDV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.tableDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableDV.ColumnHeadersHeight = 50;
            this.tableDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_DV,
            this.Ten_DV,
            this.Don_gia,
            this.Trang_Thai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableDV.Location = new System.Drawing.Point(77, 54);
            this.tableDV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tableDV.Name = "tableDV";
            this.tableDV.ReadOnly = true;
            this.tableDV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableDV.RowHeadersVisible = false;
            this.tableDV.RowHeadersWidth = 51;
            this.tableDV.RowTemplate.Height = 24;
            this.tableDV.Size = new System.Drawing.Size(708, 460);
            this.tableDV.TabIndex = 34;
            this.tableDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableDV.ThemeStyle.HeaderStyle.Height = 50;
            this.tableDV.ThemeStyle.ReadOnly = true;
            this.tableDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableDV.ThemeStyle.RowsStyle.Height = 24;
            this.tableDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.Ten_DV.FillWeight = 148.3102F;
            this.Ten_DV.HeaderText = "Tên dịch vụ";
            this.Ten_DV.MinimumWidth = 6;
            this.Ten_DV.Name = "Ten_DV";
            this.Ten_DV.ReadOnly = true;
            // 
            // Don_gia
            // 
            this.Don_gia.DataPropertyName = "Don_gia";
            this.Don_gia.FillWeight = 78.35511F;
            this.Don_gia.HeaderText = "Đơn giá";
            this.Don_gia.MinimumWidth = 6;
            this.Don_gia.Name = "Don_gia";
            this.Don_gia.ReadOnly = true;
            // 
            // Trang_Thai
            // 
            this.Trang_Thai.DataPropertyName = "Trang_Thai";
            this.Trang_Thai.HeaderText = "Trạng Thái DV";
            this.Trang_Thai.MinimumWidth = 6;
            this.Trang_Thai.Name = "Trang_Thai";
            this.Trang_Thai.ReadOnly = true;
            // 
            // FormKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 586);
            this.Controls.Add(this.tableDV);
            this.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormKiemTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIỂM TRA TRẠNG THÁI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKiemTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView tableDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trang_Thai;
    }
}
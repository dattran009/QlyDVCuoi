namespace QlyDVCuoi.Formm
{
    partial class FormThongKe
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dtThongKe = new System.Windows.Forms.DataGridView();
            this.lbTong = new System.Windows.Forms.Label();
            this.textTong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExcel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtThongKe
            // 
            this.dtThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThongKe.Location = new System.Drawing.Point(12, 22);
            this.dtThongKe.Name = "dtThongKe";
            this.dtThongKe.RowHeadersWidth = 51;
            this.dtThongKe.RowTemplate.Height = 24;
            this.dtThongKe.Size = new System.Drawing.Size(1101, 602);
            this.dtThongKe.TabIndex = 0;
            // 
            // lbTong
            // 
            this.lbTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTong.Location = new System.Drawing.Point(475, 645);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(145, 25);
            this.lbTong.TabIndex = 2;
            this.lbTong.Text = "Tổng hóa đơn: ";
            // 
            // textTong
            // 
            this.textTong.BorderThickness = 0;
            this.textTong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTong.DefaultText = "";
            this.textTong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTong.FillColor = System.Drawing.SystemColors.Control;
            this.textTong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTong.Location = new System.Drawing.Point(862, 645);
            this.textTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTong.Name = "textTong";
            this.textTong.PasswordChar = '\0';
            this.textTong.PlaceholderText = "";
            this.textTong.SelectedText = "";
            this.textTong.Size = new System.Drawing.Size(128, 25);
            this.textTong.TabIndex = 3;
            this.textTong.Visible = false;
            this.textTong.Load += new System.EventHandler(this.textTong_Load);
            // 
            // btnExcel
            // 
            this.btnExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(933, 642);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(180, 45);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 699);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.textTong);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.dtThongKe);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThongKe_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThongKe_FormClosed);
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.DataGridView dtThongKe;
        public System.Windows.Forms.Label lbTong;
        public Guna.UI2.WinForms.Guna2TextBox textTong;
        private Guna.UI2.WinForms.Guna2Button btnExcel;
    }
}
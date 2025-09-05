namespace Kair_Lanjutan
{
    partial class FormRiwayat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblRiwayatTransaksi = new Label();
            dgvRiwayat = new DataGridView();
            btnLihatStruk = new Button();
            panelNavbar = new Panel();
            label1 = new Label();
            btnHome = new Button();
            btnKasir = new Button();
            btnRiwayat = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // lblRiwayatTransaksi
            // 
            lblRiwayatTransaksi.AutoSize = true;
            lblRiwayatTransaksi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRiwayatTransaksi.Location = new Point(20, 90);
            lblRiwayatTransaksi.Name = "lblRiwayatTransaksi";
            lblRiwayatTransaksi.Size = new Size(249, 38);
            lblRiwayatTransaksi.TabIndex = 1;
            lblRiwayatTransaksi.Text = "Riwayat Transaksi";
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.BackgroundColor = SystemColors.ControlLight;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(20, 140);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.RowHeadersWidth = 62;
            dgvRiwayat.RowTemplate.Height = 28;
            dgvRiwayat.Size = new Size(850, 350);
            dgvRiwayat.TabIndex = 2;
            // 
            // btnLihatStruk
            // 
            btnLihatStruk.Location = new Point(20, 510);
            btnLihatStruk.Name = "btnLihatStruk";
            btnLihatStruk.Size = new Size(150, 35);
            btnLihatStruk.TabIndex = 3;
            btnLihatStruk.Text = "Lihat Struk";
            btnLihatStruk.UseVisualStyleBackColor = true;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.SteelBlue;
            panelNavbar.Controls.Add(label1);
            panelNavbar.Controls.Add(btnHome);
            panelNavbar.Controls.Add(btnKasir);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(900, 77);
            panelNavbar.TabIndex = 8;
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 13);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 4;
            label1.Text = "KasirKu";
            // 
            // btnHome
            // 
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(424, 23);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 38);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            // 
            // btnKasir
            // 
            btnKasir.FlatStyle = FlatStyle.Flat;
            btnKasir.ForeColor = Color.White;
            btnKasir.Location = new Point(520, 23);
            btnKasir.Name = "btnKasir";
            btnKasir.Size = new Size(75, 38);
            btnKasir.TabIndex = 1;
            btnKasir.Text = "Kasir";
            // 
            // btnRiwayat
            // 
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.ForeColor = Color.White;
            btnRiwayat.Location = new Point(615, 23);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(118, 38);
            btnRiwayat.TabIndex = 2;
            btnRiwayat.Text = "Riwayat";
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(790, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(87, 36);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            // 
            // FormRiwayat
            // 
            ClientSize = new Size(900, 600);
            Controls.Add(panelNavbar);
            Controls.Add(btnLihatStruk);
            Controls.Add(dgvRiwayat);
            Controls.Add(lblRiwayatTransaksi);
            Name = "FormRiwayat";
            Text = "FormRiwayat";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRiwayatTransaksi;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Button btnLihatStruk;
        private Panel panelNavbar;
        private Label label1;
        private Button btnHome;
        private Button btnKasir;
        private Button btnRiwayat;
        private Button btnLogout;
    }
}

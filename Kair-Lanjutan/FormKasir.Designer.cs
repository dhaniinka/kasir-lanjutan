
namespace Kair_Lanjutan
{
    partial class FormKasir
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
            gbtotalharga = new GroupBox();
            tbjumlahpesanan = new MaskedTextBox();
            lbljumlahpesanan = new Label();
            tbnamakasir = new MaskedTextBox();
            lblkembali = new Label();
            lblsubtotalminum = new Label();
            lblsubtotalmakan = new Label();
            tbkembali = new MaskedTextBox();
            lblbayar = new Label();
            lblnama = new Label();
            lblhargaminum = new Label();
            lbltotal = new Label();
            tbbayar = new MaskedTextBox();
            lblhargamakan = new Label();
            tbsubtotalminum = new TextBox();
            tbsubtotalmakan = new TextBox();
            tbtotal = new MaskedTextBox();
            tbminum = new TextBox();
            tbmakan = new MaskedTextBox();
            gbdaftar = new GroupBox();
            nudminum = new NumericUpDown();
            nudmakan = new NumericUpDown();
            cmbminum = new ComboBox();
            cmbmakan = new ComboBox();
            lblminum = new Label();
            lblmakan = new Label();
            panelNavbar = new Panel();
            label1 = new Label();
            btnHome = new Button();
            btnKasir = new Button();
            btnRiwayat = new Button();
            btnLogout = new Button();
            btnProses = new Button();
            btnClear = new Button();
            gbtotalharga.SuspendLayout();
            gbdaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudminum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudmakan).BeginInit();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // gbtotalharga
            // 
            gbtotalharga.Controls.Add(tbjumlahpesanan);
            gbtotalharga.Controls.Add(lbljumlahpesanan);
            gbtotalharga.Controls.Add(tbnamakasir);
            gbtotalharga.Controls.Add(lblkembali);
            gbtotalharga.Controls.Add(lblsubtotalminum);
            gbtotalharga.Controls.Add(lblsubtotalmakan);
            gbtotalharga.Controls.Add(tbkembali);
            gbtotalharga.Controls.Add(lblbayar);
            gbtotalharga.Controls.Add(lblnama);
            gbtotalharga.Controls.Add(lblhargaminum);
            gbtotalharga.Controls.Add(lbltotal);
            gbtotalharga.Controls.Add(tbbayar);
            gbtotalharga.Controls.Add(lblhargamakan);
            gbtotalharga.Controls.Add(tbsubtotalminum);
            gbtotalharga.Controls.Add(tbsubtotalmakan);
            gbtotalharga.Controls.Add(tbtotal);
            gbtotalharga.Controls.Add(tbminum);
            gbtotalharga.Controls.Add(tbmakan);
            gbtotalharga.Location = new Point(393, 105);
            gbtotalharga.Name = "gbtotalharga";
            gbtotalharga.Size = new Size(482, 399);
            gbtotalharga.TabIndex = 11;
            gbtotalharga.TabStop = false;
            gbtotalharga.Text = "Total Harga";
            // 
            // tbjumlahpesanan
            // 
            tbjumlahpesanan.Location = new Point(250, 347);
            tbjumlahpesanan.Name = "tbjumlahpesanan";
            tbjumlahpesanan.Size = new Size(204, 31);
            tbjumlahpesanan.TabIndex = 29;
            // 
            // lbljumlahpesanan
            // 
            lbljumlahpesanan.AutoSize = true;
            lbljumlahpesanan.Location = new Point(250, 319);
            lbljumlahpesanan.Name = "lbljumlahpesanan";
            lbljumlahpesanan.Size = new Size(136, 25);
            lbljumlahpesanan.TabIndex = 28;
            lbljumlahpesanan.Text = "Jumlah Pesanan";
            // 
            // tbnamakasir
            // 
            tbnamakasir.Location = new Point(141, 49);
            tbnamakasir.Name = "tbnamakasir";
            tbnamakasir.Size = new Size(313, 31);
            tbnamakasir.TabIndex = 27;
            // 
            // lblkembali
            // 
            lblkembali.AutoSize = true;
            lblkembali.Location = new Point(250, 242);
            lblkembali.Name = "lblkembali";
            lblkembali.Size = new Size(75, 25);
            lblkembali.TabIndex = 25;
            lblkembali.Text = "Kembali";
            // 
            // lblsubtotalminum
            // 
            lblsubtotalminum.AutoSize = true;
            lblsubtotalminum.Location = new Point(24, 319);
            lblsubtotalminum.Name = "lblsubtotalminum";
            lblsubtotalminum.Size = new Size(159, 25);
            lblsubtotalminum.TabIndex = 19;
            lblsubtotalminum.Text = "Subtotal Minuman";
            // 
            // lblsubtotalmakan
            // 
            lblsubtotalmakan.AutoSize = true;
            lblsubtotalmakan.Location = new Point(24, 242);
            lblsubtotalmakan.Name = "lblsubtotalmakan";
            lblsubtotalmakan.Size = new Size(156, 25);
            lblsubtotalmakan.TabIndex = 18;
            lblsubtotalmakan.Text = "Subtotal Makanan";
            // 
            // tbkembali
            // 
            tbkembali.Location = new Point(250, 277);
            tbkembali.Name = "tbkembali";
            tbkembali.Size = new Size(204, 31);
            tbkembali.TabIndex = 23;
            // 
            // lblbayar
            // 
            lblbayar.AutoSize = true;
            lblbayar.Location = new Point(250, 170);
            lblbayar.Name = "lblbayar";
            lblbayar.Size = new Size(55, 25);
            lblbayar.TabIndex = 24;
            lblbayar.Text = "Bayar";
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Location = new Point(24, 49);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(101, 25);
            lblnama.TabIndex = 26;
            lblnama.Text = "Nama Kasir";
            // 
            // lblhargaminum
            // 
            lblhargaminum.AutoSize = true;
            lblhargaminum.Location = new Point(24, 170);
            lblhargaminum.Name = "lblhargaminum";
            lblhargaminum.Size = new Size(140, 25);
            lblhargaminum.TabIndex = 17;
            lblhargaminum.Text = "Harga Minuman";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(250, 101);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(49, 25);
            lbltotal.TabIndex = 20;
            lbltotal.Text = "Total";
            // 
            // tbbayar
            // 
            tbbayar.Location = new Point(250, 205);
            tbbayar.Name = "tbbayar";
            tbbayar.Size = new Size(204, 31);
            tbbayar.TabIndex = 22;
            // 
            // lblhargamakan
            // 
            lblhargamakan.AutoSize = true;
            lblhargamakan.Location = new Point(24, 101);
            lblhargamakan.Name = "lblhargamakan";
            lblhargamakan.Size = new Size(137, 25);
            lblhargamakan.TabIndex = 16;
            lblhargamakan.Text = "Harga Makanan";
            // 
            // tbsubtotalminum
            // 
            tbsubtotalminum.Location = new Point(24, 350);
            tbsubtotalminum.Name = "tbsubtotalminum";
            tbsubtotalminum.Size = new Size(186, 31);
            tbsubtotalminum.TabIndex = 7;
            // 
            // tbsubtotalmakan
            // 
            tbsubtotalmakan.Location = new Point(24, 277);
            tbsubtotalmakan.Name = "tbsubtotalmakan";
            tbsubtotalmakan.Size = new Size(183, 31);
            tbsubtotalmakan.TabIndex = 6;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(250, 129);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(204, 31);
            tbtotal.TabIndex = 21;
            // 
            // tbminum
            // 
            tbminum.Location = new Point(24, 205);
            tbminum.Name = "tbminum";
            tbminum.Size = new Size(183, 31);
            tbminum.TabIndex = 5;
            // 
            // tbmakan
            // 
            tbmakan.Location = new Point(24, 129);
            tbmakan.Name = "tbmakan";
            tbmakan.Size = new Size(183, 31);
            tbmakan.TabIndex = 0;
            // 
            // gbdaftar
            // 
            gbdaftar.Controls.Add(nudminum);
            gbdaftar.Controls.Add(nudmakan);
            gbdaftar.Controls.Add(cmbminum);
            gbdaftar.Controls.Add(cmbmakan);
            gbdaftar.Controls.Add(lblminum);
            gbdaftar.Controls.Add(lblmakan);
            gbdaftar.Location = new Point(24, 105);
            gbdaftar.Name = "gbdaftar";
            gbdaftar.Size = new Size(351, 274);
            gbdaftar.TabIndex = 10;
            gbdaftar.TabStop = false;
            gbdaftar.Text = "Daftar Makanan dan Minuman";
            // 
            // nudminum
            // 
            nudminum.Location = new Point(261, 207);
            nudminum.Name = "nudminum";
            nudminum.Size = new Size(67, 31);
            nudminum.TabIndex = 5;
            // 
            // nudmakan
            // 
            nudmakan.Location = new Point(261, 93);
            nudmakan.Name = "nudmakan";
            nudmakan.Size = new Size(67, 31);
            nudmakan.TabIndex = 4;
            // 
            // cmbminum
            // 
            cmbminum.FormattingEnabled = true;
            cmbminum.Location = new Point(23, 204);
            cmbminum.Name = "cmbminum";
            cmbminum.Size = new Size(218, 33);
            cmbminum.TabIndex = 3;
            // 
            // cmbmakan
            // 
            cmbmakan.FormattingEnabled = true;
            cmbmakan.Location = new Point(23, 93);
            cmbmakan.Name = "cmbmakan";
            cmbmakan.Size = new Size(218, 33);
            cmbmakan.TabIndex = 2;
            // 
            // lblminum
            // 
            lblminum.AutoSize = true;
            lblminum.Location = new Point(23, 160);
            lblminum.Name = "lblminum";
            lblminum.Size = new Size(124, 25);
            lblminum.TabIndex = 1;
            lblminum.Text = "Pilih Minuman";
            // 
            // lblmakan
            // 
            lblmakan.AutoSize = true;
            lblmakan.Location = new Point(23, 49);
            lblmakan.Name = "lblmakan";
            lblmakan.Size = new Size(121, 25);
            lblmakan.TabIndex = 0;
            lblmakan.Text = "Pilih Makanan";
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
            panelNavbar.Size = new Size(887, 77);
            panelNavbar.TabIndex = 7;
            // 
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
            btnRiwayat.Click += btnRiwayat_Click;
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
            // btnProses
            // 
            btnProses.Location = new Point(520, 510);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(100, 41);
            btnProses.TabIndex = 8;
            btnProses.Text = "Ok";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(643, 510);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 41);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 577);
            Controls.Add(gbtotalharga);
            Controls.Add(gbdaftar);
            Controls.Add(panelNavbar);
            Controls.Add(btnProses);
            Controls.Add(btnClear);
            Name = "FormKasir";
            Text = "FormKasir";
            Load += FormKasir_Load;
            gbtotalharga.ResumeLayout(false);
            gbtotalharga.PerformLayout();
            gbdaftar.ResumeLayout(false);
            gbdaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudminum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudmakan).EndInit();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbtotalharga;
        private MaskedTextBox tbjumlahpesanan;
        private Label lbljumlahpesanan;
        private MaskedTextBox tbnamakasir;
        private Label lblkembali;
        private Label lblsubtotalminum;
        private Label lblsubtotalmakan;
        private MaskedTextBox tbkembali;
        private Label lblbayar;
        private Label lblnama;
        private Label lblhargaminum;
        private Label lbltotal;
        private MaskedTextBox tbbayar;
        private Label lblhargamakan;
        private TextBox tbsubtotalminum;
        private TextBox tbsubtotalmakan;
        private MaskedTextBox tbtotal;
        private TextBox tbminum;
        private MaskedTextBox tbmakan;
        private GroupBox gbdaftar;
        private NumericUpDown nudminum;
        private NumericUpDown nudmakan;
        private ComboBox cmbminum;
        private ComboBox cmbmakan;
        private Label lblminum;
        private Label lblmakan;
        private Panel panelNavbar;
        private Label label1;
        private Button btnHome;
        private Button btnKasir;
        private Button btnRiwayat;
        private Button btnLogout;
        private Button btnProses;
        private Button btnClear;
    }
}
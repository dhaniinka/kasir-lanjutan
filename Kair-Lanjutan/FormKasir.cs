using System;
using System.Windows.Forms;

namespace Kair_Lanjutan
{
    public partial class FormKasir : Form
    {
        // Singleton instance
        private static FormKasir instance;
        public static FormKasir Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new FormKasir();
                return instance;
            }
        }

        private FormKasir()
        {
            InitializeComponent();

            // Event
            cmbmakan.SelectedIndexChanged += cmbmakan_SelectedIndexChanged;
            cmbminum.SelectedIndexChanged += cmbminum_SelectedIndexChanged;
            nudmakan.ValueChanged += nudmakan_ValueChanged;
            nudminum.ValueChanged += nudminum_ValueChanged;
            tbbayar.TextChanged += tbbayar_TextChanged;
            btnProses.Click += btnProses_Click;
            btnClear.Click += btnClear_Click;
            btnLogout.Click += btnLogout_Click;
            btnRiwayat.Click += btnRiwayat_Click;
            btnHome.Click += btnHome_Click; // event Home
        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            // Isi combo makanan & minuman
            if (cmbmakan.Items.Count == 0)
                cmbmakan.Items.AddRange(new object[] { "Mie Ayam", "Ayam Geprek", "Bakso Urat" });

            if (cmbminum.Items.Count == 0)
                cmbminum.Items.AddRange(new object[] { "Es Teh", "Es Jeruk", "Air Es" });

            // Default value
            tbmakan.Text = "0";
            tbminum.Text = "0";
            tbsubtotalmakan.Text = "0";
            tbsubtotalminum.Text = "0";
            tbtotal.Text = "0";
            tbbayar.Text = "0";
            tbkembali.Text = "0";
            tbjumlahpesanan.Text = "0";
        }

        // Hitung ulang subtotal & total
        private void HitungTotal()
        {
            int.TryParse(tbmakan.Text, out int hargaMakan);
            int.TryParse(tbminum.Text, out int hargaMinum);

            int subtotalMakan = hargaMakan * (int)nudmakan.Value;
            int subtotalMinum = hargaMinum * (int)nudminum.Value;

            tbsubtotalmakan.Text = subtotalMakan.ToString();
            tbsubtotalminum.Text = subtotalMinum.ToString();

            int total = subtotalMakan + subtotalMinum;
            tbtotal.Text = total.ToString();

            int jumlahPesanan = (int)nudmakan.Value + (int)nudminum.Value;
            tbjumlahpesanan.Text = jumlahPesanan.ToString();
        }

        private void cmbmakan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbmakan.SelectedIndex)
            {
                case 0: tbmakan.Text = "12000"; break;
                case 1: tbmakan.Text = "15000"; break;
                case 2: tbmakan.Text = "20000"; break;
                default: tbmakan.Text = "0"; break;
            }
            HitungTotal();
        }

        private void cmbminum_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbminum.SelectedIndex)
            {
                case 0: tbminum.Text = "3000"; break;
                case 1: tbminum.Text = "5000"; break;
                case 2: tbminum.Text = "2000"; break;
                default: tbminum.Text = "0"; break;
            }
            HitungTotal();
        }

        private void nudmakan_ValueChanged(object sender, EventArgs e) => HitungTotal();
        private void nudminum_ValueChanged(object sender, EventArgs e) => HitungTotal();

        private void tbbayar_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbbayar.Text, out int bayar)) bayar = 0;
            if (!int.TryParse(tbtotal.Text, out int total)) total = 0;

            tbkembali.Text = (bayar - total).ToString();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            string namaKasir = tbnamakasir.Text;
            string makanan = cmbmakan.SelectedIndex >= 0 ? cmbmakan.Text : "-";
            string minuman = cmbminum.SelectedIndex >= 0 ? cmbminum.Text : "-";

            string struk =
                "===== STRUK PEMBELIAN =====\n" +
                "Kasir: " + namaKasir + "\n\n" +
                "Makanan: " + makanan + " x" + nudmakan.Value + "  Rp " + tbsubtotalmakan.Text + "\n" +
                "Minuman: " + minuman + " x" + nudminum.Value + "  Rp " + tbsubtotalminum.Text + "\n" +
                "---------------------------\n" +
                "TOTAL : Rp " + tbtotal.Text + "\n" +
                "BAYAR : Rp " + tbbayar.Text + "\n" +
                "KEMBALI: Rp " + tbkembali.Text + "\n" +
                "JUMLAH PESANAN: " + tbjumlahpesanan.Text + "\n" +
                "===========================";

            MessageBox.Show(struk, "Struk Penjualan");

            // Tambah transaksi ke Riwayat
            FormRiwayat.TambahTransaksi(
                tbnamakasir.Text,
                cmbmakan.Text + " x" + nudmakan.Value + ", " + cmbminum.Text + " x" + nudminum.Value,
                (int)nudmakan.Value + (int)nudminum.Value,
                Convert.ToDecimal(tbtotal.Text)
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbmakan.SelectedIndex = -1;
            cmbminum.SelectedIndex = -1;
            nudmakan.Value = 0;
            nudminum.Value = 0;
            tbmakan.Text = "0";
            tbminum.Text = "0";
            tbsubtotalmakan.Text = "0";
            tbsubtotalminum.Text = "0";
            tbtotal.Text = "0";
            tbbayar.Text = "0";
            tbkembali.Text = "0";
            tbjumlahpesanan.Text = "0";
            tbnamakasir.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = FormLogin.Instance; // gunakan singleton
            login.Show();
            this.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            // Gunakan instance tunggal supaya tidak bikin window baru
            FormRiwayat riwayat = FormRiwayat.Instance;
            riwayat.Show();
            riwayat.BringToFront();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (FormHome.isLoggedIn)
            {
                FormHome home = FormHome.Instance; // gunakan singleton
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Silakan login terlebih dahulu!", "Akses Ditolak",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FormLogin login = FormLogin.Instance; // gunakan singleton
                login.Show();
                this.Hide();
            }
        }
    }
}

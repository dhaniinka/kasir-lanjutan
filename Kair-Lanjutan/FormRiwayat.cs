using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kair_Lanjutan
{
    public partial class FormRiwayat : Form
    {
        // Simpan data transaksi secara global
        public static List<string[]> RiwayatTransaksi = new List<string[]>();

        // Singleton instance
        private static FormRiwayat instance;
        public static FormRiwayat Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new FormRiwayat();
                return instance;
            }
        }

        private FormRiwayat()
        {
            InitializeComponent();

            this.Load += FormRiwayat_Load;

            // Event Navbar
            btnHome.Click += btnHome_Click;
            btnKasir.Click += btnKasir_Click;
            btnRiwayat.Click += btnRiwayat_Click;
            btnLogout.Click += btnLogout_Click; // tombol logout
            btnLihatStruk.Click += btnLihatStruk_Click; // tombol lihat struk
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            // Tambahkan kolom ke DataGridView (sekali saja)
            if (dgvRiwayat.Columns.Count == 0)
            {
                dgvRiwayat.Columns.Add("Tanggal", "Tanggal");
                dgvRiwayat.Columns.Add("Kasir", "Kasir");
                dgvRiwayat.Columns.Add("Pesanan", "Pesanan");
                dgvRiwayat.Columns.Add("Jumlah", "Jumlah");
                dgvRiwayat.Columns.Add("Total", "Total (Rp)");
            }

            TampilkanData();
        }

        // Tampilkan data
        private void TampilkanData()
        {
            dgvRiwayat.Rows.Clear();
            foreach (var item in RiwayatTransaksi)
            {
                dgvRiwayat.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }

        // Tombol "Lihat Struk" di bawah DataGridView
        private void btnLihatStruk_Click(object sender, EventArgs e)
        {
            if (dgvRiwayat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih transaksi terlebih dahulu!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowIndex = dgvRiwayat.SelectedRows[0].Index;
            var transaksi = RiwayatTransaksi[rowIndex];
            string tanggal = transaksi[0];
            string kasir = transaksi[1];
            string pesanan = transaksi[2];
            string jumlah = transaksi[3];
            string total = transaksi[4];

            // Tampilkan struk sama seperti di FormKasir
            string struk =
                "===== STRUK PEMBELIAN =====\n" +
                "Tanggal: " + tanggal + "\n" +
                "Kasir: " + kasir + "\n\n" +
                "Pesanan: " + pesanan + "\n" +
                "Jumlah: " + jumlah + "\n" +
                "Total: Rp " + total + "\n" +
                "===========================";

            MessageBox.Show(struk, "Struk Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method untuk menambah transaksi
        public static void TambahTransaksi(string kasir, string pesanan, int jumlah, decimal total)
        {
            RiwayatTransaksi.Add(new string[]
            {
                DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                kasir,
                pesanan,
                jumlah.ToString(),
                total.ToString("N0")
            });

            if (instance != null && !instance.IsDisposed)
            {
                instance.TampilkanData();
            }
        }

        // Navigasi Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (FormHome.isLoggedIn)
            {
                FormHome.Instance.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Silakan login terlebih dahulu!", "Akses Ditolak",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FormLogin.Instance.Show();
                this.Hide();
            }
        }

        // Navigasi Kasir
        private void btnKasir_Click(object sender, EventArgs e)
        {
            FormKasir.Instance.Show();
            this.Hide();
        }

        // Sudah di form riwayat
        private void btnRiwayat_Click(object sender, EventArgs e) { }

        // Tombol Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormHome.isLoggedIn = false; // reset status login
            FormLogin.Instance.Show();
            this.Hide();
        }
    }
}

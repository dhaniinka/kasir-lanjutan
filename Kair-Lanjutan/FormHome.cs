using System;
using System.Windows.Forms;

namespace Kair_Lanjutan
{
    public partial class FormHome : Form
    {
        // status login global
        public static bool isLoggedIn = false;

        // Singleton instance
        private static FormHome instance;
        public static FormHome Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new FormHome();
                return instance;
            }
        }

        private FormHome()
        {
            InitializeComponent();

            // pasang event
            this.Load += FormHome_Load;
            btnHome.Click += BtnHome_Click;
            btnKasir.Click += BtnKasir_Click;
            btnRiwayat.Click += BtnRiwayat_Click;
            btnLogin.Click += btnLogin_Click;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // inisialisasi awal (kalau ada)
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kamu sudah di halaman Home", "Info");
        }

        private void BtnKasir_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Harus login dulu sebelum masuk ke Kasir!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // buka form login
                FormLogin login = FormLogin.Instance;
                login.Show();
                this.Hide();
            }
            else
            {
                FormKasir kasir = FormKasir.Instance;
                kasir.Show();
                this.Hide();
            }
        }

        private void BtnRiwayat_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Harus login dulu sebelum melihat Riwayat!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // buka form login
                FormLogin login = FormLogin.Instance;
                login.Show();
                this.Hide();
            }
            else
            {
                FormRiwayat riwayat = FormRiwayat.Instance;
                riwayat.Show();
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = FormLogin.Instance;
            login.Show();
            this.Hide();
        }
    }
}

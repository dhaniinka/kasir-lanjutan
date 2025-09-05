using System;
using System.Windows.Forms;

namespace Kair_Lanjutan
{
    public partial class FormLogin : Form
    {
        // Singleton instance
        private static FormLogin instance;
        public static FormLogin Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new FormLogin();
                return instance;
            }
        }

        private FormLogin()
        {
            InitializeComponent();

            // pas pertama kali jalan, password langsung tersembunyi
            tbpassword.UseSystemPasswordChar = true;

            // event handler
            btnlogin.Click += Btnlogin_Click;
            btnexit.Click += Btnexit_Click;
            btnreset.Click += Btnreset_Click;
            cbtampilkanpass.CheckedChanged += Cbtampilkanpass_CheckedChanged;
            btnHome.Click += BtnHome_Click;
            btnKasir.Click += BtnKasir_Click;
            btnRiwayat.Click += BtnRiwayat_Click;
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "123";

            if (tbusername.Text == user && tbpassword.Text == pass)
            {
                MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // tandai sudah login
                FormHome.isLoggedIn = true;

                // buka form home (pakai singleton)
                FormHome home = FormHome.Instance;
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            tbusername.Clear();
            tbpassword.Clear();
            tbusername.Focus();
        }

        private void Cbtampilkanpass_CheckedChanged(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = !cbtampilkanpass.Checked;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormHome home = FormHome.Instance;
            home.Show();
            this.Hide();
        }

        private void BtnKasir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harus login dulu untuk mengakses Kasir!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnRiwayat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harus login dulu untuk mengakses Riwayat!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // jika perlu inisialisasi awal
        }
    }
}


namespace Kair_Lanjutan
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            btnLogin = new Button();
            btnRiwayat = new Button();
            btnKasir = new Button();
            btnHome = new Button();
            label1 = new Label();
            panelNavbar = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(790, 23);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
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
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.SteelBlue;
            panelNavbar.Controls.Add(label1);
            panelNavbar.Controls.Add(btnHome);
            panelNavbar.Controls.Add(btnKasir);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnLogin);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(900, 77);
            panelNavbar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 245);
            label2.Name = "label2";
            label2.Size = new Size(377, 120);
            label2.TabIndex = 2;
            label2.Text = "Selamat Datang di KasirKu. Silahkan pilih menu diatas untuk melanjutkan.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(361, 494);
            label3.Name = "label3";
            label3.Size = new Size(214, 25);
            label3.TabIndex = 3;
            label3.Text = "Kasirku by Inka XI PPLG 3";
            // 
            // FormHome
            // 
            ClientSize = new Size(900, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panelNavbar);
            Name = "FormHome";
            Text = "FormHome";
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRiwayat;
        private Button btnKasir;
        private Button btnHome;
        private Label label1;
        private Panel panelNavbar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}

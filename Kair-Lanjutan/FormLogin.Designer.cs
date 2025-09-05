namespace Kair_Lanjutan
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            cbtampilkanpass = new CheckBox();
            btnreset = new Button();
            btnexit = new Button();
            btnlogin = new Button();
            label1 = new Label();
            lblusername = new Label();
            tbpassword = new TextBox();
            tbusername = new TextBox();
            panelNavbar = new Panel();
            label2 = new Label();
            btnHome = new Button();
            btnKasir = new Button();
            btnRiwayat = new Button();
            pictureBox1 = new PictureBox();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbtampilkanpass
            // 
            cbtampilkanpass.AutoSize = true;
            cbtampilkanpass.Location = new Point(558, 321);
            cbtampilkanpass.Name = "cbtampilkanpass";
            cbtampilkanpass.Size = new Size(197, 29);
            cbtampilkanpass.TabIndex = 16;
            cbtampilkanpass.Text = "Tampilkan Password";
            cbtampilkanpass.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(701, 396);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(112, 34);
            btnreset.TabIndex = 15;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(558, 396);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 14;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(406, 396);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 34);
            btnlogin.TabIndex = 13;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 260);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 12;
            label1.Text = "Password";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(406, 201);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(91, 25);
            lblusername.TabIndex = 11;
            lblusername.Text = "Username";
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(520, 257);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(293, 31);
            tbpassword.TabIndex = 10;
            // 
            // tbusername
            // 
            tbusername.Location = new Point(520, 198);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(293, 31);
            tbusername.TabIndex = 9;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.SteelBlue;
            panelNavbar.Controls.Add(label2);
            panelNavbar.Controls.Add(btnHome);
            panelNavbar.Controls.Add(btnKasir);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(893, 77);
            panelNavbar.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 13);
            label2.Name = "label2";
            label2.Size = new Size(153, 54);
            label2.TabIndex = 4;
            label2.Text = "KasirKu";
            // 
            // btnHome
            // 
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(561, 22);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 38);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            // 
            // btnKasir
            // 
            btnKasir.FlatStyle = FlatStyle.Flat;
            btnKasir.ForeColor = Color.White;
            btnKasir.Location = new Point(657, 22);
            btnKasir.Name = "btnKasir";
            btnKasir.Size = new Size(75, 38);
            btnKasir.TabIndex = 1;
            btnKasir.Text = "Kasir";
            // 
            // btnRiwayat
            // 
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.ForeColor = Color.White;
            btnRiwayat.Location = new Point(752, 22);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(118, 38);
            btnRiwayat.TabIndex = 2;
            btnRiwayat.Text = "Riwayat";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 598);
            Controls.Add(pictureBox1);
            Controls.Add(panelNavbar);
            Controls.Add(cbtampilkanpass);
            Controls.Add(btnreset);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Controls.Add(lblusername);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Name = "FormLogin";
            Text = "Form2";
            Load += FormLogin_Load;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbtampilkanpass;
        private Button btnreset;
        private Button btnexit;
        private Button btnlogin;
        private Label label1;
        private Label lblusername;
        private TextBox tbpassword;
        private TextBox tbusername;
        private Panel panelNavbar;
        private Label label2;
        private Button btnHome;
        private Button btnKasir;
        private Button btnRiwayat;
        private PictureBox pictureBox1;
    }
}
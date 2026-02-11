namespace Pr3_3_Uporov
{
    partial class FormLogin
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
            pnMain = new Panel();
            btnGuest = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            lblLogin = new Label();
            lblPassword = new Label();
            pbLogo = new PictureBox();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.None;
            pnMain.BackColor = Color.FromArgb(233, 245, 255);
            pnMain.Controls.Add(lblPassword);
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(lblLogin);
            pnMain.Location = new Point(28, 118);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(329, 219);
            pnMain.TabIndex = 0;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(67, 97, 238);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(89, 165);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 97, 238);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(89, 129);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(39, 40);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 26);
            txtLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(138, 15);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(52, 19);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(135, 72);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(58, 19);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Пароль";
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = Properties.Resources.Logotip;
            pbLogo.Location = new Point(142, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(384, 361);
            Controls.Add(pbLogo);
            Controls.Add(pnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            Load += Form1_Load;
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Label l;
        private TextBox txtLogin;
        private Label lblLogin;
        private Button btnGuest;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private PictureBox pbLogo;
    }
}

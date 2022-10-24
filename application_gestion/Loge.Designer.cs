
namespace application_gestion
{
    partial class Loge
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linkLabel_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.linkLabel_ForgotPassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_Login);
            this.guna2CustomGradientPanel1.Controls.Add(this.TextBox_Password);
            this.guna2CustomGradientPanel1.Controls.Add(this.TextBox_Username);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(691, 393);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // linkLabel_ForgotPassword
            // 
            this.linkLabel_ForgotPassword.AutoSize = true;
            this.linkLabel_ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_ForgotPassword.Location = new System.Drawing.Point(364, 204);
            this.linkLabel_ForgotPassword.Name = "linkLabel_ForgotPassword";
            this.linkLabel_ForgotPassword.Size = new System.Drawing.Size(86, 13);
            this.linkLabel_ForgotPassword.TabIndex = 3;
            this.linkLabel_ForgotPassword.TabStop = true;
            this.linkLabel_ForgotPassword.Text = "Forgot Password";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderRadius = 10;
            this.btn_Login.CheckedState.Parent = this.btn_Login;
            this.btn_Login.CustomImages.Parent = this.btn_Login;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.Parent = this.btn_Login;
            this.btn_Login.Location = new System.Drawing.Point(233, 232);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.ShadowDecoration.Parent = this.btn_Login;
            this.btn_Login.Size = new System.Drawing.Size(217, 28);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Log in";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Password.BorderRadius = 10;
            this.TextBox_Password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.DefaultText = "Password";
            this.TextBox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.DisabledState.Parent = this.TextBox_Password;
            this.TextBox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.FocusedState.Parent = this.TextBox_Password;
            this.TextBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.HoverState.Parent = this.TextBox_Password;
            this.TextBox_Password.Location = new System.Drawing.Point(233, 165);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '\0';
            this.TextBox_Password.PlaceholderText = "";
            this.TextBox_Password.SelectedText = "";
            this.TextBox_Password.SelectionStart = 8;
            this.TextBox_Password.ShadowDecoration.Parent = this.TextBox_Password;
            this.TextBox_Password.ShortcutsEnabled = false;
            this.TextBox_Password.Size = new System.Drawing.Size(217, 36);
            this.TextBox_Password.TabIndex = 1;
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Username.BorderRadius = 10;
            this.TextBox_Username.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TextBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Username.DefaultText = "Username";
            this.TextBox_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.DisabledState.Parent = this.TextBox_Username;
            this.TextBox_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.FocusedState.Parent = this.TextBox_Username;
            this.TextBox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.HoverState.Parent = this.TextBox_Username;
            this.TextBox_Username.Location = new System.Drawing.Point(233, 110);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PasswordChar = '\0';
            this.TextBox_Username.PlaceholderText = "";
            this.TextBox_Username.SelectedText = "";
            this.TextBox_Username.SelectionStart = 8;
            this.TextBox_Username.ShadowDecoration.Parent = this.TextBox_Username;
            this.TextBox_Username.Size = new System.Drawing.Size(217, 36);
            this.TextBox_Username.TabIndex = 0;
            // 
            // Loge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 393);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loge";
            this.Text = "Loge";
            this.Load += new System.EventHandler(this.Loge_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Username;
    }
}
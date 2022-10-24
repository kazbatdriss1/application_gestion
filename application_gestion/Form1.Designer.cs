
namespace application_gestion
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_lock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_user = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_email = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_calendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_list = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_statistics = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Account = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 30);
            this.panel1.TabIndex = 0;
            // 
            // Btn_close
            // 
            this.Btn_close.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_close.BorderRadius = 0;
            this.Btn_close.ButtonText = "";
            this.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_close.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(40)))), ((int)(((byte)(81)))));
            this.Btn_close.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_close.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_close.Iconimage")));
            this.Btn_close.Iconimage_right = null;
            this.Btn_close.Iconimage_right_Selected = null;
            this.Btn_close.Iconimage_Selected = null;
            this.Btn_close.IconMarginLeft = 0;
            this.Btn_close.IconMarginRight = 0;
            this.Btn_close.IconRightVisible = true;
            this.Btn_close.IconRightZoom = 0D;
            this.Btn_close.IconVisible = true;
            this.Btn_close.IconZoom = 90D;
            this.Btn_close.IsTab = false;
            this.Btn_close.Location = new System.Drawing.Point(1002, 2);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(40)))), ((int)(((byte)(81)))));
            this.Btn_close.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_close.selected = false;
            this.Btn_close.Size = new System.Drawing.Size(25, 25);
            this.Btn_close.TabIndex = 0;
            this.Btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_close.Textcolor = System.Drawing.Color.White;
            this.Btn_close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.Btn_lock);
            this.panel2.Controls.Add(this.Btn_user);
            this.panel2.Controls.Add(this.Btn_product);
            this.panel2.Controls.Add(this.Btn_email);
            this.panel2.Controls.Add(this.Btn_calendar);
            this.panel2.Controls.Add(this.Btn_list);
            this.panel2.Controls.Add(this.Btn_statistics);
            this.panel2.Controls.Add(this.Btn_Account);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 540);
            this.panel2.TabIndex = 1;
            // 
            // Btn_lock
            // 
            this.Btn_lock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_lock.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_lock.BorderRadius = 0;
            this.Btn_lock.ButtonText = "Lock";
            this.Btn_lock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_lock.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_lock.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_lock.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_lock.Iconimage")));
            this.Btn_lock.Iconimage_right = null;
            this.Btn_lock.Iconimage_right_Selected = null;
            this.Btn_lock.Iconimage_Selected = null;
            this.Btn_lock.IconMarginLeft = 0;
            this.Btn_lock.IconMarginRight = 0;
            this.Btn_lock.IconRightVisible = true;
            this.Btn_lock.IconRightZoom = 0D;
            this.Btn_lock.IconVisible = true;
            this.Btn_lock.IconZoom = 90D;
            this.Btn_lock.IsTab = false;
            this.Btn_lock.Location = new System.Drawing.Point(3, 340);
            this.Btn_lock.Name = "Btn_lock";
            this.Btn_lock.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_lock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_lock.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_lock.selected = false;
            this.Btn_lock.Size = new System.Drawing.Size(138, 48);
            this.Btn_lock.TabIndex = 9;
            this.Btn_lock.Text = "Lock";
            this.Btn_lock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_lock.Textcolor = System.Drawing.Color.White;
            this.Btn_lock.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_user
            // 
            this.Btn_user.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_user.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_user.BorderRadius = 0;
            this.Btn_user.ButtonText = "User";
            this.Btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_user.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_user.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_user.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_user.Iconimage")));
            this.Btn_user.Iconimage_right = null;
            this.Btn_user.Iconimage_right_Selected = null;
            this.Btn_user.Iconimage_Selected = null;
            this.Btn_user.IconMarginLeft = 0;
            this.Btn_user.IconMarginRight = 0;
            this.Btn_user.IconRightVisible = true;
            this.Btn_user.IconRightZoom = 0D;
            this.Btn_user.IconVisible = true;
            this.Btn_user.IconZoom = 90D;
            this.Btn_user.IsTab = false;
            this.Btn_user.Location = new System.Drawing.Point(3, 292);
            this.Btn_user.Name = "Btn_user";
            this.Btn_user.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_user.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_user.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_user.selected = false;
            this.Btn_user.Size = new System.Drawing.Size(138, 48);
            this.Btn_user.TabIndex = 6;
            this.Btn_user.Text = "User";
            this.Btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_user.Textcolor = System.Drawing.Color.White;
            this.Btn_user.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_user.Click += new System.EventHandler(this.Btn_user_Click);
            // 
            // Btn_product
            // 
            this.Btn_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_product.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_product.BorderRadius = 0;
            this.Btn_product.ButtonText = "Product";
            this.Btn_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_product.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_product.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_product.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_product.Iconimage")));
            this.Btn_product.Iconimage_right = null;
            this.Btn_product.Iconimage_right_Selected = null;
            this.Btn_product.Iconimage_Selected = null;
            this.Btn_product.IconMarginLeft = 0;
            this.Btn_product.IconMarginRight = 0;
            this.Btn_product.IconRightVisible = true;
            this.Btn_product.IconRightZoom = 0D;
            this.Btn_product.IconVisible = true;
            this.Btn_product.IconZoom = 90D;
            this.Btn_product.IsTab = false;
            this.Btn_product.Location = new System.Drawing.Point(3, 244);
            this.Btn_product.Name = "Btn_product";
            this.Btn_product.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_product.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_product.selected = false;
            this.Btn_product.Size = new System.Drawing.Size(138, 48);
            this.Btn_product.TabIndex = 5;
            this.Btn_product.Text = "Product";
            this.Btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_product.Textcolor = System.Drawing.Color.White;
            this.Btn_product.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_email
            // 
            this.Btn_email.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_email.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_email.BorderRadius = 0;
            this.Btn_email.ButtonText = "Email";
            this.Btn_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_email.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_email.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_email.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_email.Iconimage")));
            this.Btn_email.Iconimage_right = null;
            this.Btn_email.Iconimage_right_Selected = null;
            this.Btn_email.Iconimage_Selected = null;
            this.Btn_email.IconMarginLeft = 0;
            this.Btn_email.IconMarginRight = 0;
            this.Btn_email.IconRightVisible = true;
            this.Btn_email.IconRightZoom = 0D;
            this.Btn_email.IconVisible = true;
            this.Btn_email.IconZoom = 90D;
            this.Btn_email.IsTab = false;
            this.Btn_email.Location = new System.Drawing.Point(3, 196);
            this.Btn_email.Name = "Btn_email";
            this.Btn_email.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_email.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_email.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_email.selected = false;
            this.Btn_email.Size = new System.Drawing.Size(138, 48);
            this.Btn_email.TabIndex = 4;
            this.Btn_email.Text = "Email";
            this.Btn_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_email.Textcolor = System.Drawing.Color.White;
            this.Btn_email.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_calendar
            // 
            this.Btn_calendar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_calendar.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_calendar.BorderRadius = 0;
            this.Btn_calendar.ButtonText = "Calendar";
            this.Btn_calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_calendar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_calendar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_calendar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_calendar.Iconimage")));
            this.Btn_calendar.Iconimage_right = null;
            this.Btn_calendar.Iconimage_right_Selected = null;
            this.Btn_calendar.Iconimage_Selected = null;
            this.Btn_calendar.IconMarginLeft = 0;
            this.Btn_calendar.IconMarginRight = 0;
            this.Btn_calendar.IconRightVisible = true;
            this.Btn_calendar.IconRightZoom = 0D;
            this.Btn_calendar.IconVisible = true;
            this.Btn_calendar.IconZoom = 90D;
            this.Btn_calendar.IsTab = false;
            this.Btn_calendar.Location = new System.Drawing.Point(3, 148);
            this.Btn_calendar.Name = "Btn_calendar";
            this.Btn_calendar.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_calendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_calendar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_calendar.selected = false;
            this.Btn_calendar.Size = new System.Drawing.Size(138, 48);
            this.Btn_calendar.TabIndex = 3;
            this.Btn_calendar.Text = "Calendar";
            this.Btn_calendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_calendar.Textcolor = System.Drawing.Color.White;
            this.Btn_calendar.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_list
            // 
            this.Btn_list.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_list.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_list.BorderRadius = 0;
            this.Btn_list.ButtonText = "List";
            this.Btn_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_list.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_list.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_list.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_list.Iconimage")));
            this.Btn_list.Iconimage_right = null;
            this.Btn_list.Iconimage_right_Selected = null;
            this.Btn_list.Iconimage_Selected = null;
            this.Btn_list.IconMarginLeft = 0;
            this.Btn_list.IconMarginRight = 0;
            this.Btn_list.IconRightVisible = true;
            this.Btn_list.IconRightZoom = 0D;
            this.Btn_list.IconVisible = true;
            this.Btn_list.IconZoom = 90D;
            this.Btn_list.IsTab = false;
            this.Btn_list.Location = new System.Drawing.Point(3, 100);
            this.Btn_list.Name = "Btn_list";
            this.Btn_list.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_list.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_list.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_list.selected = false;
            this.Btn_list.Size = new System.Drawing.Size(138, 48);
            this.Btn_list.TabIndex = 2;
            this.Btn_list.Text = "List";
            this.Btn_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_list.Textcolor = System.Drawing.Color.White;
            this.Btn_list.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_statistics
            // 
            this.Btn_statistics.Activecolor = System.Drawing.Color.Silver;
            this.Btn_statistics.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_statistics.BorderRadius = 0;
            this.Btn_statistics.ButtonText = "Statistics";
            this.Btn_statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_statistics.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_statistics.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_statistics.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_statistics.Iconimage")));
            this.Btn_statistics.Iconimage_right = null;
            this.Btn_statistics.Iconimage_right_Selected = null;
            this.Btn_statistics.Iconimage_Selected = null;
            this.Btn_statistics.IconMarginLeft = 0;
            this.Btn_statistics.IconMarginRight = 0;
            this.Btn_statistics.IconRightVisible = true;
            this.Btn_statistics.IconRightZoom = 0D;
            this.Btn_statistics.IconVisible = true;
            this.Btn_statistics.IconZoom = 90D;
            this.Btn_statistics.IsTab = false;
            this.Btn_statistics.Location = new System.Drawing.Point(3, 52);
            this.Btn_statistics.Name = "Btn_statistics";
            this.Btn_statistics.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_statistics.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_statistics.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_statistics.selected = false;
            this.Btn_statistics.Size = new System.Drawing.Size(138, 48);
            this.Btn_statistics.TabIndex = 1;
            this.Btn_statistics.Text = "Statistics";
            this.Btn_statistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_statistics.Textcolor = System.Drawing.Color.White;
            this.Btn_statistics.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Account
            // 
            this.Btn_Account.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_Account.BackColor = System.Drawing.Color.SlateBlue;
            this.Btn_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Account.BorderRadius = 0;
            this.Btn_Account.ButtonText = "Account";
            this.Btn_Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Account.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Account.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Account.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Account.Iconimage")));
            this.Btn_Account.Iconimage_right = null;
            this.Btn_Account.Iconimage_right_Selected = null;
            this.Btn_Account.Iconimage_Selected = null;
            this.Btn_Account.IconMarginLeft = 0;
            this.Btn_Account.IconMarginRight = 0;
            this.Btn_Account.IconRightVisible = true;
            this.Btn_Account.IconRightZoom = 0D;
            this.Btn_Account.IconVisible = true;
            this.Btn_Account.IconZoom = 90D;
            this.Btn_Account.IsTab = false;
            this.Btn_Account.Location = new System.Drawing.Point(3, 4);
            this.Btn_Account.Name = "Btn_Account";
            this.Btn_Account.Normalcolor = System.Drawing.Color.SlateBlue;
            this.Btn_Account.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.Btn_Account.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Account.selected = false;
            this.Btn_Account.Size = new System.Drawing.Size(138, 48);
            this.Btn_Account.TabIndex = 0;
            this.Btn_Account.Text = "Account";
            this.Btn_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Account.Textcolor = System.Drawing.Color.White;
            this.Btn_Account.TextFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(143, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 540);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_lock;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_user;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_product;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_email;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_calendar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_list;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_statistics;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Account;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_close;
    }
}


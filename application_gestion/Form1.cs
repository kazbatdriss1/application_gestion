using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_gestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Registration Re = new Registration();
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void souspage( object sp)
        {
            if (this.panel3.Controls.Count>0)
                this.panel3.Controls.RemoveAt(0);
            Form F = sp as Form;
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(F);
            this.panel3.Tag = F;
            F.Show();
        }

        private void Btn_user_Click(object sender, EventArgs e)
        {
            souspage(Re);
        }
    }
}

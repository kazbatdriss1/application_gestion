using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace application_gestion
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Username.Text!="" && TextBox_Password.Text !="" && TextBox_email.Text !="")
                {
                    SqlCommand cmd = new SqlCommand("insert into [Username] (username,password_user,email) values(@U,@P,@E)", conixon.cx);
                    cmd.Parameters.AddWithValue("@U",TextBox_Username.Text);
                    cmd.Parameters.AddWithValue("@P",TextBox_Password.Text);
                    cmd.Parameters.AddWithValue("@E",TextBox_email.Text);
                    conixon.opencx();
                    cmd.ExecuteNonQuery();
                    conixon.closncx();
                    MessageBox.Show("User added");
                    TextBox_Username.Clear();
                    TextBox_Password.Clear();
                    TextBox_email.Clear();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        // method recherch
        public void recherch()
        {
            if (TextBox_Username.Text.Trim() != "")
            {
                SqlCommand cmdr = new SqlCommand("select username,password_user,email from Username where username=@us", conixon.cx);
                cmdr.Parameters.AddWithValue("@us", TextBox_Username);
                conixon.opencx();
                SqlDataReader dr = cmdr.ExecuteReader();
                while (dr.Read())
                {
                    TextBox_Username.Text = dr[0].ToString();
                    TextBox_Password.Text = dr[1].ToString();
                    TextBox_email.Text = dr[2].ToString();
                }
                conixon.closncx();
            }   
        }
        private void btn_upda_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Username set password_user=@pass,email=@ema where username=@us", conixon.cx);
            cmd.Parameters.AddWithValue("@us", TextBox_Username);
            cmd.Parameters.AddWithValue("@pass", TextBox_Password.Text);
            cmd.Parameters.AddWithValue("@ema", TextBox_email.Text);
            /*conixon.opencx();
            cmd.ExecuteNonQuery();
            conixon.closncx();*/
        }

        private void btn_dele_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("delete from Username where username=@us", conixon.cx);
            cmd.Parameters.AddWithValue("@us",TextBox_Username);
            conixon.opencx();
            cmd.ExecuteNonQuery();
            conixon.closncx();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox_Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            recherch();
        }
    }
}

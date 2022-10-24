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
using System.Data;

namespace application_gestion
{
    public partial class Loge : Form
    {
        public Loge()
        {
            InitializeComponent();
        }

        private void Loge_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Username.Text != ""  && TextBox_Password.Text !="")
                {
                    SqlCommand cmd = new SqlCommand("verification",conixon.cx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user",TextBox_Username.Text);
                    cmd.Parameters.AddWithValue("@pass", TextBox_Password.Text);
                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@rus";
                    p1.SqlDbType = SqlDbType.Int;
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.SqlDbType = SqlDbType.Int;
                    p2.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(p2);

                    conixon.opencx();
                    cmd.ExecuteNonQuery();
                    conixon.closncx();
                    if (p2.Value.ToString()=="1")
                    {
                        Form1 F1 = new Form1();
                        F1.Show();
                    }
                    else if (p2.Value.ToString()=="0")
                    {
                        MessageBox.Show("user name or pass invalide");
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

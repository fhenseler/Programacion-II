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


namespace SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=basetest;Integrated Security=True;MultipleActiveResultSets=true";

            SqlCommand cm = new SqlCommand("select nombre from provincia where nombre like 'c%' order by nombre", cn);
            SqlCommand cm2 = new SqlCommand("select * from localidad where idprovincia = 3", cn);

            try
            {
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                SqlDataReader dr2 = cm2.ExecuteReader();
                while(dr.Read())
                {
                    comboBox1.Items.Add(dr[0].ToString());
                }
                while (dr2.Read())
                {
                    comboBox2.Items.Add(dr2[0].ToString());
                }
            }
            catch(SqlException et)
            {
                MessageBox.Show(et.Message);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cn.Close();
            }
        }


    }
}

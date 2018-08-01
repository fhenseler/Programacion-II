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

namespace Ejercicio59
{
    public partial class Form1 : Form
    {
        public string comboName = "";
        public string textName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True;MultipleActiveResultSets=true";

            TextBox txtBox = new TextBox();
            textName = txtBox.Text;

            SqlCommand cm = new SqlCommand("INSERT INTO Production.Product (Name, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, DaysToManufacture, SellStartDate) VALUES (@textName, 22, 55, 1, 1, 2, 1, 5)", cn);
            cm.Parameters.Add(new SqlParameter("@textName", textName));

            try
            {
                cn.Open();
                //SqlDataReader dr = cm.ExecuteReader();
                cm.ExecuteNonQuery();
            }
            catch (SqlException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True;MultipleActiveResultSets=true";

            SqlCommand cm = new SqlCommand("DELETE FROM Production.Product where ProductId = 1023", cn);

            try
            {
                cn.Open();
                //SqlDataReader dr = cm.ExecuteReader();
                cm.ExecuteNonQuery();
            }
            catch (SqlException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True;MultipleActiveResultSets=true";

            SqlCommand cm = new SqlCommand("SELECT Name FROM Production.Product", cn);

            try
            {
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0].ToString());
                }
            }
            catch (SqlException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboName = comboBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True;MultipleActiveResultSets=true";

            SqlCommand cm = new SqlCommand("UPDATE Production.Product SET Name = 'Fede' where Name = @comboName", cn);
            cm.Parameters.Add(new SqlParameter("@comboName", comboName));

            try
            {
                cn.Open();
                //SqlDataReader dr = cm.ExecuteReader();
                cm.ExecuteNonQuery();
            }
            catch (SqlException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ee)
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

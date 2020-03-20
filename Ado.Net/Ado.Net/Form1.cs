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

namespace Ado.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql=null;
            string connectionString;
            connectionString= @"Data Source= localhost\SQLEXPRESS;Initial Catalog=University;User ID=UserName;Password=Password";
            sql = new SqlConnection(connectionString);
            try
            {
                sql.Open();
                MessageBox.Show("Connection open!");
                sql.Close();
            }
            catch
            {
                MessageBox.Show("Can not open connection !");
            }
        }
    }
}

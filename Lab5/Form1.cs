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

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1(string table)
        {
            InitializeComponent();
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";

            string sql = "SELECT * FROM " + table;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}

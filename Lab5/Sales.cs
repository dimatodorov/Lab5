using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab5
{
    public class Sales
    {
        public void Add(int id, int id_shop, int id_product,int amount)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "INSERT INTO Sales (Id,Id_shop,Id_product,Amount) VALUES (" + Convert.ToString(id) + "," + Convert.ToString(id_shop) + "," + Convert.ToString(id_product) + "," + Convert.ToString(amount) + ")";
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Sales. Добавлено объектов: {0}", number);
            connection.Close();
        }

        public void Update(int id, int id_shop, int id_product, int amount)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "UPDATE Sales SET Id_shop = " + Convert.ToString(id_shop) + ", Id_product = " + Convert.ToString(id_product) + ", Amount = " + Convert.ToString(amount) + " WHERE Id = " + Convert.ToString(id);
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Sales. Обновлено объектов: {0}", number);
            connection.Close();
        }

        public void Del(int id)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "DELETE  FROM Sales WHERE Id = " + Convert.ToString(id);
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Sales. Удалено объектов: {0}", number);
            connection.Close();
        }

        public void Show()
        {
            Application.Run(new Form1("Sales"));
        }
    }
}

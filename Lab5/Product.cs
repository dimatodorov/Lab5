using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab5
{
    public class Product
    {
        public void Add(int id, string name, float price)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "INSERT INTO Product (Id,Name,Price) VALUES (" + Convert.ToString(id) + ",'" + name + "'," + Convert.ToString(price) + ")";
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Product. Добавлено объектов: {0}", number);
            connection.Close();
        }

        public void Update(int id, string name, float price)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "UPDATE Product SET Name = '" + name + "', Price = " + Convert.ToString(price) + " WHERE Id = " + Convert.ToString(id);
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Product. Обновлено объектов: {0}", number);
            connection.Close();
        }

        public void Del(int id)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "DELETE  FROM Product WHERE Id = " + Convert.ToString(id);
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Product. Удалено объектов: {0}", number);
            connection.Close();
        }

        public void Show()
        {
            Application.Run(new Form1("Product"));
        }
    }
}

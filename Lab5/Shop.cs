using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab5
{
    public class Shop
    {
        public void Add(int id, string adress)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "INSERT INTO Shop (Id,Adress) VALUES (" + Convert.ToString(id) + ", '" + adress + "')";
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Shop. Добавлено объектов: {0}", number);
            connection.Close();
        }

        public void Update(int id, string adress)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "UPDATE Shop SET Adress = '" + adress + " WHERE Id = " + Convert.ToString(id);
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Shop. Обновлено объектов: {0}", number);
            connection.Close();
        }

        public void Del(int id)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Добавление объектов
            string sqlExpression = "DELETE  FROM Shop WHERE Id = " + Convert.ToString(id);
            SqlCommand add = new SqlCommand(sqlExpression, connection);
            int number = add.ExecuteNonQuery();
            Console.WriteLine("Shop. Удалено объектов: {0}", number);
            connection.Close();
        }

        public void Show()
        {
            Application.Run(new Form1("Shop"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab5
{
    class Program
    {
        void add()
        {
            
        }
        
        static void Main(string[] args)
        {
            Database database = new Database();
            database.main();
            Console.ReadKey();
            //string connectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Lab5_veb;Integrated Security=True";
            //string sqlExpression;
            //int number;
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            // Добавление объектов
            //sqlExpression = "INSERT INTO Shop (Id,Adress) VALUES (3, 'Борщаговская 158')";
            //SqlCommand add = new SqlCommand(sqlExpression, connection);
            //number = add.ExecuteNonQuery();
            //Console.WriteLine("Добавлено объектов: {0}", number);
            //connection.Close();
            
            // Удаление объектов
            //sqlExpression = "DELETE  FROM Shop WHERE Id=3";
            //SqlCommand del = new SqlCommand(sqlExpression, connection);
            //number = del.ExecuteNonQuery();
            //Console.WriteLine("Удалено объектов: {0}", number);

            // Удаление объектов
            //sqlExpression = "UPDATE Sales SET Amount=20 WHERE Id=3";
            //SqlCommand up = new SqlCommand(sqlExpression, connection);
            //number = up.ExecuteNonQuery();
            //Console.WriteLine("Обновлено объектов: {0}", number);

            //Application.Run(new Form1()); 
            //connection.Close();
            
            //Console.Read();
        }
    }
}

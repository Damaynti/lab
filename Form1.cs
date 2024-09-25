using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private NpgsqlDataAdapter ClientAdapter;
        private NpgsqlDataAdapter SubscriptionAdapter;
        private NpgsqlDataAdapter ServicesAdapter;
        private NpgsqlDataAdapter VisitAdapter;

        private NpgsqlCommandBuilder ClientBuilder = new NpgsqlCommandBuilder();
        private NpgsqlCommandBuilder SubscriptionBuilder = new NpgsqlCommandBuilder();

        private DataSet dataSet = new DataSet();
        public Form1()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["soda"].ConnectionString;
            ClientAdapter = new NpgsqlDataAdapter("Select * from \"Client\";", connectionString);
            SubscriptionAdapter = new NpgsqlDataAdapter("Select * from \"Subscription\";", connectionString);
            ServicesAdapter=new NpgsqlDataAdapter("Select * from \"Services\";", connectionString);
            VisitAdapter=new NpgsqlDataAdapter("Select * from \"Visit\";", connectionString);


            ClientBuilder = new NpgsqlCommandBuilder(ClientAdapter);
            SubscriptionBuilder = new NpgsqlCommandBuilder(SubscriptionAdapter);
            

            
            ClientAdapter.Fill(dataSet, "Client");
            SubscriptionAdapter.Fill(dataSet, "Subscription");
            ServicesAdapter.Fill(dataSet, "Services");
            VisitAdapter.Fill(dataSet, "Visit");
           

            dataGridView2.DataSource = dataSet.Tables["Client"];
            dataGridView1.DataSource = dataSet.Tables["Subscription"];

            FillManufacturerCombobox();
            
        }

        private void FillManufacturerCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Services_id"]).DataSource =
               dataSet.Tables["Services"];
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Services_id"]).DisplayMember =
                "Name_services";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Services_id"]).ValueMember =
                "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubscriptionAdapter.Update(dataSet, "Subscription");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string startDate = textBoxStartDate.Text;
            string endDate = textBoxEndDate.Text;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    // Создаем SQL-запрос с параметрами
                    string sql = @"SELECT ""услуги"".""Name_services"", COUNT(visit.""id"") AS NumVisits 
                       FROM ""Services"" AS ""услуги"" 
                       LEFT JOIN ""Subscription"" AS sub ON ""услуги"".""id"" = sub.""Services_id"" 
                       LEFT JOIN ""Visit"" AS visit ON sub.""id"" = visit.""subscription_id"" 
                       WHERE visit.""Date_of_visit"" >= @startDate AND visit.""Date_of_visit"" <= @endDate 
                       GROUP BY ""услуги"".""Name_services""";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@startDate", DateTime.Parse(startDate));
                        command.Parameters.AddWithValue("@endDate", DateTime.Parse(endDate));

                        connection.Open();

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable("VisitsReport");
                            dataTable.Columns.Add("Name_services", typeof(string));
                            dataTable.Columns.Add("NumVisits", typeof(int));

                            while (reader.Read())
                            {
                                DataRow row = dataTable.NewRow();
                                row["Name_services"] = reader["Name_services"];
                                row["NumVisits"] = reader["NumVisits"];
                                dataTable.Rows.Add(row);
                            }
                            reader.Close();
                            dataGridView3.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка формата даты: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand("SELECT * FROM getservicereport($1)", sqlConnection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter() { Value = (int)numericUpDown1.Value },
                    }
                };

                sqlConnection.Open();
                 sqlCommand.Prepare();

                DataTable dataTable = new DataTable("ServiceReport");

                using (var sqlAdapter = new NpgsqlDataAdapter(sqlCommand))
                {
                    sqlAdapter.Fill(dataTable);
                }

                // Устанавливаем источник данных для DataGridView или другого элемента управления
                dataGridView4.DataSource = dataTable;
            }

        }

    }
}

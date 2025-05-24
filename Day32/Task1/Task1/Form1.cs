using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BDTur_firmSQL;Integrated Security=True;";
        DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
            InitializeDataTables();
        }

        private void InitializeDataTables()
        {
            DataTable toursTable = new DataTable("Туры");
            toursTable.Columns.Add("Код_тура", typeof(int));
            toursTable.Columns.Add("Название", typeof(string));
            toursTable.Columns.Add("Описание", typeof(string));
            dataSet.Tables.Add(toursTable);

            DataTable touristsTable = new DataTable("Туристы");
            touristsTable.Columns.Add("Код_туриста", typeof(int));
            touristsTable.Columns.Add("Фамилия", typeof(string));
            touristsTable.Columns.Add("Имя", typeof(string));
            touristsTable.Columns.Add("Отчество", typeof(string));
            dataSet.Tables.Add(touristsTable);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTours();
        }

        private void LoadTours()
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlDataAdapter adapter = new("SELECT * FROM Туры", connection);
                adapter.Fill(dataSet.Tables["Туры"]);
                dataGridView1.DataSource = dataSet.Tables["Туры"];
            }
        }

        private void buttonAddTourist_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string sql = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@f, @i, @o)";
                SqlCommand cmd = new(sql, connection);
                cmd.Parameters.AddWithValue("@f", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@i", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@o", textBoxMiddleName.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                LoadTourists();
                MessageBox.Show("Турист добавлен.");
            }
        }

        private void LoadTourists()
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlDataAdapter adapter = new("SELECT * FROM Туристы", connection);
                adapter.Fill(dataSet.Tables["Туристы"]);
                dataGridView2.DataSource = dataSet.Tables["Туристы"];
            }
        }

        private void buttonUpdateTourist_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string sql = "UPDATE Туристы SET Имя = @name WHERE Код_туриста = @id";
                SqlCommand cmd = new(sql, connection);
                cmd.Parameters.AddWithValue("@name", textBoxNewName.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxTouristId.Text));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                LoadTourists();
                MessageBox.Show("Имя туриста обновлено.");
            }
        }

        private void buttonDeleteTour_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string sql = "DELETE FROM Туры WHERE Код_тура = @id";
                SqlCommand cmd = new(sql, connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxTourId.Text));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                LoadTours();
                MessageBox.Show("Тур удален.");
            }
        }

        private void buttonLoadTours_Click(object sender, EventArgs e)
        {
            LoadTours();
        }
    }
}

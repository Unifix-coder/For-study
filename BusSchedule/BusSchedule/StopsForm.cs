using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BusSchedule
{
    public partial class StopsForm : Form
    {

        OleDbConnection connection = new OleDbConnection("Data Source=STUDENT3-18_6;Initial Catalog=BusSchedule;Integrated Security=SSPI;Provider=SQLOLEDB");

        public StopsForm()
        {
            InitializeComponent();
        }

        private void StopsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busScheduleDataSet2.Stops". При необходимости она может быть перемещена или удалена.
            this.stopsTableAdapter.Fill(this.busScheduleDataSet2.Stops);
        }

        private void backClick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void addButtonClick(object sender, EventArgs e)
        {
            
            string txt = addTextBox.Text;
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Stops(Title) VALUES('" + txt + "')");
            
            //Выполнение запроса
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            this.stopsTableAdapter.Fill(this.busScheduleDataSet2.Stops);
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Stops WHERE id=" + Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));

            //Выполнение запроса
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            cmd.Connection = connection;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введен id");
            }
            
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            this.stopsTableAdapter.Fill(this.busScheduleDataSet2.Stops);
        }

        private void redactButton_Click(object sender, EventArgs e)
        {
            string title = titleRedactTextBox.Text;
            OleDbCommand cmd = new OleDbCommand("UPDATE Stops SET Title='" + title + "' WHERE Id=" + Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));

            //Выполнение запроса
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            cmd.Connection = connection;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(cmd.CommandText);
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            this.stopsTableAdapter.Fill(this.busScheduleDataSet2.Stops);
        }
    }

}

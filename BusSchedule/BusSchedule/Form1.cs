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
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection("Data Source=STUDENT3-18_6;Initial Catalog=BusSchedule;Integrated Security=SSPI;Provider=SQLOLEDB");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.dataSet1.Schedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busScheduleDataSet.Router". При необходимости она может быть перемещена или удалена.
            this.routerTableAdapter.Fill(this.busScheduleDataSet.Router);
            connection.Open();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void nextClick(object sender, EventArgs e)
        {
            this.Hide();
            StopsForm form = new StopsForm();
            form.Show();
        }

        
    }
}

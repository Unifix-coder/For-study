using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalenikDB
{
    //форма предназначенная для подтверждения удаления всей информации из БД
    public partial class DeleteAcceptForm : Form
    {
        public DeleteAcceptForm()
        {
            InitializeComponent();
        }

        //реализация кнопки подтверждения удаления всей информации из БД
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //код удаления всей информации из БД
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `names` ", db.getConnection());

            db.openDBConnection();

            command.ExecuteNonQuery();
            MessageBox.Show("Записи удалены");

            db.closeDBConnection();

            //код сворачивания этой формы и открытия главной формы
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        //реализация кнопки возврата на главную форму
        private void BackButton_Click(object sender, EventArgs e)
        {
            //код сворачивания этой формы и открытия главной формы
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}

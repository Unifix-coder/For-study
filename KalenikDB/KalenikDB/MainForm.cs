using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//бибилиотека необходимая для работы с MySql
using MySql.Data.MySqlClient;

namespace KalenikDB
{
    //главная форма предназначенная для основной работы с БД
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //код предназначенный для начальных параметров textbox'ов
            NameTextBox.Text = "Name";
            NameTextBox.ForeColor = Color.Gray;

            SurnameTextBox.Text = "Surname";
            SurnameTextBox.ForeColor = Color.Gray;

            RedactIDTextBox.Text = "1";
            RedactIDTextBox.ForeColor = Color.Gray;

            IDDeleteTextBox.Text = "1";
            IDDeleteTextBox.ForeColor = Color.Gray;

            RedactNameTextBox.Text = "Name";
            RedactNameTextBox.ForeColor = Color.Gray;

            RedactSurnameTextBox.Text = "Surname";
            RedactSurnameTextBox.ForeColor = Color.Gray;
        }

        //кнопка предназначенная для ддобавления информации в БД
        private void AddButton_Click(object sender, EventArgs e)
        {
            //код добавления информации в БД
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `names` (`Name`,`Surname`) VALUES (@Name, @Surname)", db.getConnection());

            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameTextBox.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = SurnameTextBox.Text;

            db.openDBConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись добавлена");

            db.closeDBConnection();
        }

        //Кнопка предназначенная для открытия формы таблицы БД
        private void DBshowButton_Click(object sender, EventArgs e)
        {
            //код сворачивания этой формы и открытия формы БД
            this.Hide();
            ShowDB showdb = new ShowDB();
            showdb.Show();
        }

        //Кнопка предназначенная для открытия формы удаления всей информации БД
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //код сворачивания этой формы и открытия формы удаления всей информации БД
            this.Hide();
            DeleteAcceptForm form = new DeleteAcceptForm();
            form.Show();
        }

        //Кнопка предназначенная для открытия формы информации о приложении
        private void InformationButton_Click(object sender, EventArgs e)
        {
            //код сворачивания этой формы и открытия формы информации о приложении
            this.Hide();
            InformationForm form = new InformationForm();
            form.Show();
        }

        //Кнопка предназначенная для открытия формы предназначеной для печати БД
        private void PrintButton_Click(object sender, EventArgs e)
        {
            //код сворачивания этой формы и открытия формы предназначеной для печати БД
            this.Hide();
            PrintForm form = new PrintForm();
            form.Show();
        }

        //Кнопка предназначенная для закрытия приложения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //код выхода из приложения
            Application.Exit();
        }

        //Кнопка предназначенная для изменения информации в БД
        private void RedactAcceptButton_Click(object sender, EventArgs e)
        {
            //код для изменения информации в БД
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `names` SET `Name`=@Name , `Surname`=@Surname WHERE `id`=@IDnum", db.getConnection());
      
            command.Parameters.Add("@IDnum", MySqlDbType.Int32).Value = RedactIDTextBox.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = RedactNameTextBox.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = RedactSurnameTextBox.Text;

            db.openDBConnection();
            
            //Условие проверки выполнения кода
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись отредактированна");
            else
                MessageBox.Show("Такой записи нет в БД");

            db.closeDBConnection();
        }

        //Кнопка предназначенная для удаления информации из БД по id
        private void IDDeleteButton_Click(object sender, EventArgs e)
        {
            //код дляудаления информации из БД по id
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("DELETE FROM names WHERE id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = IDDeleteTextBox.Text;

            db.openDBConnection();

            //Условие проверки выполнения кода
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись удалена");
            else
                MessageBox.Show("Такой записи нет в БД");

            db.closeDBConnection();
   
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Name")
            {
                NameTextBox.Text = "";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Name";
                NameTextBox.ForeColor = Color.Gray;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void SurnameTextBox_Enter(object sender, EventArgs e)
        {
            if (SurnameTextBox.Text == "Surname")
            {
                SurnameTextBox.Text = "";
                SurnameTextBox.ForeColor = Color.Black;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void SurnameTextBox_Leave(object sender, EventArgs e)
        {
            if (SurnameTextBox.Text == "")
            {
                SurnameTextBox.Text = "Surname";
                SurnameTextBox.ForeColor = Color.Gray;
            }
        }

        //код предназначенный для ввода циферных значений в определенный textbox что бы не допустить появление ошибки кода
        private void IDDeleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void RedactIDTextBox_Enter(object sender, EventArgs e)
        {
            if (RedactIDTextBox.Text == "1")
            {
                RedactIDTextBox.Text = "";
                RedactIDTextBox.ForeColor = Color.Black;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void RedactIDTextBox_Leave(object sender, EventArgs e)
        {
            if (RedactIDTextBox.Text == "")
            {
                RedactIDTextBox.Text = "1";
                RedactIDTextBox.ForeColor = Color.Gray;
            }
        }

        //код предназначенный для ввода циферных значений в определенный textbox что бы не допустить появление ошибки кода
        private void RedactIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void RedactNameTextBox_Enter(object sender, EventArgs e)
        {
            if (RedactNameTextBox.Text == "Name")
            {
                RedactNameTextBox.Text = "";
                RedactNameTextBox.ForeColor = Color.Black;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void RedactNameTextBox_Leave(object sender, EventArgs e)
        {
            if (RedactNameTextBox.Text == "")
            {
                RedactNameTextBox.Text = "Name";
                RedactNameTextBox.ForeColor = Color.Gray;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void RedactSurnameTextBox_Enter(object sender, EventArgs e)
        {
            if (RedactSurnameTextBox.Text == "Surname")
            {
                RedactSurnameTextBox.Text = "";
                RedactSurnameTextBox.ForeColor = Color.Black;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void RedactSurnameTextBox_Leave(object sender, EventArgs e)
        {
            if (RedactSurnameTextBox.Text == "")
            {
                RedactSurnameTextBox.Text = "Surname";
                RedactSurnameTextBox.ForeColor = Color.Gray;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void IDDeleteTextBox_Enter(object sender, EventArgs e)
        {
            if (IDDeleteTextBox.Text == "1")
            {
                IDDeleteTextBox.Text = "";
                IDDeleteTextBox.ForeColor = Color.Black;
            }
        }

        //код предназначенный для появления подсказки в определенном textbox
        private void IDDeleteTextBox_Leave(object sender, EventArgs e)
        {
            if (IDDeleteTextBox.Text == "")
            {
                IDDeleteTextBox.Text = "1";
                IDDeleteTextBox.ForeColor = Color.Gray;
            }
        }
    }
}

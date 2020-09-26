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
    //форма предназначенная для описания приложения
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
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

using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Clients
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(employeeNametextBox1.Text))
                MessageBox.Show("Для поиска введите имя работника!");
            else if(String.IsNullOrWhiteSpace(DateTextBox4.Text))
            {
                informationTextBox2.Text = $"Итог за все время работы: {ConnectDataBase.GetSqlInquiry(string.Format("SELECT SUM (Стоимость) FROM Client WHERE Исполнитель ='{0}' ", employeeNametextBox1.Text))} Рублей.";
            }
            else
            {
                string[] str = DateTextBox4.Text.Split(' ');
                if(str.Length>1)
                {
                    string sql = ConnectDataBase.GetSqlInquiry(string.Format("SELECT SUM (Стоимость) FROM Client WHERE Исполнитель ='{0}' AND `Дата визита` BETWEEN '{1}' AND '{2}' ", employeeNametextBox1.Text, str[0], str[1]));
                    if (String.IsNullOrWhiteSpace(procentTextBox3.Text))
                        MessageBox.Show("Введите проценты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        informationTextBox2.Text = $"Итог за {str[0]} - {str[1]} сумма: {Convert.ToInt32(sql) * Convert.ToInt32(procentTextBox3.Text) / 100} рублей.";
                }
                else
                {
                    string sql = ConnectDataBase.GetSqlInquiry(string.Format("SELECT SUM (Стоимость) FROM Client WHERE Исполнитель ='{0}' AND `Дата визита` ='{1}' ", employeeNametextBox1.Text, DateTextBox4.Text));
                    if (String.IsNullOrWhiteSpace(procentTextBox3.Text))
                        MessageBox.Show("Введите проценты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        informationTextBox2.Text = $"Итог за {DateTextBox4.Text} сумма: {Convert.ToInt32(sql) * Convert.ToInt32(procentTextBox3.Text) / 100} рублей.";
                }
            }
        }

        private void procentTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) 
            {
                e.Handled = true;
            }
        }
    }
}

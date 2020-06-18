using System;
using System.Windows.Forms;


namespace Clients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGirdView();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString() != "Безымянный"
                && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText.ToString().Equals ("id"))
            {
                ConnectDataBase.InputSqlInquiry(string.Format("DELETE FROM Client WHERE id ='{0}'", dataGridView1.CurrentCell.Value.ToString()));
                MessageBox.Show("Успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGirdView();
            }
            else
                MessageBox.Show("Для удаления нажмите на ячейку с id!", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            string sql = string.Format("UPDATE Client SET Имя ='{0}', Фамилия ='{1}'," +
                "'Номер телефона' ='{2}', 'Марка авто' ='{3}', 'Гос номер' ='{4}', 'Тип услуги' ='{5}'," +
                "'Дата визита' ='{6}', Стоимость ='{7}', Исполнитель ='{8}' WHERE id = '{9}'",
                GetClient().FirstName, GetClient().SecondName, GetClient().PhoneNumber,
            GetClient().MarkAuto, GetClient().GovermentNumber, GetClient().TypeOfService,
                GetClient().VisitDate.ToString("dd.MM.yyyy"), GetClient().Cost, GetClient().Employee, GetClient().IdClient);
            ConnectDataBase.InputSqlInquiry(sql);
            FillDataGirdView();
            MessageBox.Show("Запись успешно изменена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            { 
            string sql = string.Format("INSERT INTO Client VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                GetClient().IdClient, GetClient().FirstName, GetClient().SecondName, GetClient().PhoneNumber, GetClient().MarkAuto,
                GetClient().GovermentNumber, GetClient().TypeOfService, GetClient().VisitDate.ToString("dd.MM.yyyy"), GetClient().Cost,
                GetClient().Employee);
            ConnectDataBase.InputSqlInquiry(sql);
              FillDataGirdView();
            MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Введите значения!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SearchButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                MessageBox.Show("Для поиска введите значение!");
            else
            {
                dataGridView2.DataSource = ConnectDataBase.GetData(String.Format("SELECT * FROM Client WHERE " +
                "\"Тип Услуги\"= '{0}' OR Имя ='{0}' OR Фамилия ='{0}' OR \"Номер телефона\" ='{0}' " +
                "OR \"Марка авто\" ='{0}' OR \"Гос номер\" ='{0}' OR \"Тип услуги\" ='{0}' " +
                "OR \"Дата визита\" ='{0}' OR Стоимость ='{0}' " +
                "OR Исполнитель ='{0}'", textBox1.Text));
                dataGridView2.Visible = true;
                Closebutton.Visible = true;
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            Closebutton.Visible = false;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            if (dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
            else
            {
                tb.KeyPress -= tb_KeyPress;
            }
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                if (e.KeyChar != (char)Keys.Back)
                { e.Handled = true; }
            }
        }

        private void FillDataGirdView() => dataGridView1.DataSource = ConnectDataBase.GetData("Select * from Client");
        private Client GetClient()
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            string firstName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            string secodName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            string phoneNumber = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            string markAuto = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            string govermentNumber = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            string typeOfService = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            DateTime visitDate = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value);
            int cost = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value);
            string employee = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
            Client client = new Client(id, firstName, secodName, phoneNumber, markAuto, govermentNumber, typeOfService, visitDate, cost, employee);
            return client;
        }

        private void accountingButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

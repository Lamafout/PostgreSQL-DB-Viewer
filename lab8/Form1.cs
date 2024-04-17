using lab8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace postgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                PG.OpenConnection(hostTextBox.Text, portTextBox.Text, userTextBox.Text, passTextBox.Text, DBTextBox.Text);
            }
            catch (Exception ex) { MessageBox.Show("Error!\n" + ex.Message); }
        }
        private void Form1_Load(object sender, EventArgs eventArgs)
        {
            //PG.OpenConnection("127.0.0.1", "5432", "postgres", "1234", "polit_party_new");
        }

        private void selectClick(object sender, EventArgs eventArgs)
        {
            try
            {
                // переключаем видимость таблицы
                dataGridView1.Visible = true;

                // передаём в таблицу данные с соответствующей таблицы БД
                dataGridView1.DataSource = PG.selectAll(tableTextBox.Text);

                PG.resizeTable(dataGridView1, this);
            }
            catch (Exception ex) {
                MessageBox.Show("Error!\n" + ex.Message); 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aboutClick(object sender, EventArgs e)
        {
            aboutForm form = new aboutForm();
            form.Show();
        }

        private void journalsButton_Click(object sender, EventArgs e)
        {
            journalForm form = new journalForm();
            form.Show();
        }

        private void operationsButton_Click(object sender, EventArgs e)
        {
            dataForm form = new dataForm();
            form.Show();
        }

        private void blackBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                // переключаем видимость таблицы
                dataGridView1.Visible = true;

                // передаём в таблицу данные с соответствующей таблицы БД
                dataGridView1.DataSource = PG.selectAll("event_journal");

                PG.resizeTable(dataGridView1, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }
    }
}

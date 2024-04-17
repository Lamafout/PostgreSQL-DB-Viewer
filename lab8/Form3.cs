using postgr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class journalForm : Form
    {
        public journalForm()
        {
            InitializeComponent();
        }

        private void journalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (journalComboBox.SelectedIndex != null)
            {
                string tempItem = journalComboBox.SelectedItem.ToString();
                DataTable dataTemp = PG.selectAll(tempItem);
                dataGridViewJournal.DataSource = dataTemp;

                dataGridViewJournal.Visible = true;
                PG.resizeTable(dataGridViewJournal, this);
            }
        }
    }
}

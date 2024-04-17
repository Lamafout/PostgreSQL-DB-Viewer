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
    public partial class dataForm : Form
    {
        public dataForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempItem = dataComboBox.SelectedItem.ToString();
            DataTable dataTemp = PG.selectAll(tempItem);
            dataGridViewData.DataSource = dataTemp;

            dataGridViewData.Visible = true;
            PG.resizeTable(dataGridViewData, this);
        }
    }
}

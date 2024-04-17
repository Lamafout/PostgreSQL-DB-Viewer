using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using lab8;
using System.Data.Common;

namespace postgr
{
    public class PG
    {
        private static NpgsqlConnection connection = null;

        public static DataTable selectAll(string tableView)
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    NpgsqlCommand command = connection.CreateCommand();
                    command.CommandText = "Select * from public." + tableView;
                    NpgsqlDataReader data = command.ExecuteReader(CommandBehavior.Default);
                    if (data.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(data);
                        return dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                    data.Close();
                }
                else throw new Exception("Not Opened Connection!");
            }
            else throw new Exception("Not Connected!");
            return null;
        }

        public static void OpenConnection(string host, string port, string user, string pass, string db)
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.Dispose();
            }
            connection = new NpgsqlConnection(@"Server=" + host + ";Port=" + port + ";User Id=" + user + ";Password=" + pass + ";Database=" + db + ";");
            connection.Open();
            if (connection.State == ConnectionState.Open) MessageBox.Show("Connected!");
            else MessageBox.Show("NOT Connected!");
        }

        public static void resizeTable(DataGridView dataGridTemp, Form formTemp)
        {
            // изменяем размер таблицы под её содержимое
            dataGridTemp.AutoResizeColumns();
            dataGridTemp.AutoResizeRows();
            dataGridTemp.Width = dataGridTemp.RowHeadersWidth
                + dataGridTemp.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            dataGridTemp.Height = Math.Min(dataGridTemp.ColumnHeadersHeight
                + dataGridTemp.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 20, 400);
            dataGridTemp.Refresh();
            if (dataGridTemp.Left + dataGridTemp.Width + 32 > formTemp.Width)
                formTemp.Width += dataGridTemp.Left + dataGridTemp.Width + 32 - formTemp.Width;
            if (dataGridTemp.Top + dataGridTemp.Height + 64 > formTemp.Height)
                formTemp.Height += dataGridTemp.Top + dataGridTemp.Height + 64 - formTemp.Height;

        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.DataGridViewTablesInitialize();
        }

        private void DataGridViewTablesInitialize()
        {
            dataGridViewTables.DataSource = DBOjbects.Entities.Table.ToList();
            dataGridViewTables.Columns["table_number"].HeaderText = "№ столика";
            dataGridViewTables.Columns["number_of_seats"].HeaderText = "Количество мест";
            dataGridViewTables.Columns["Color"].HeaderText = "Цвет";
            dataGridViewTables.Columns["Material"].HeaderText = "Материал";
            dataGridViewTables.Columns["Form_Factor"].HeaderText = "Форма";
            dataGridViewTables.Columns["Table_Reservation"].Visible = false;
            dataGridViewTables.Columns["id_table"].Visible = false;
            dataGridViewTables.Columns["color_id"].Visible = false;
            dataGridViewTables.Columns["material_id"].Visible = false;
            dataGridViewTables.Columns["form_id"].Visible = false;
            dataGridViewTables.Columns["img"].Visible = false;
        }

        private void dataGridViewTables_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Table table = (Table)this.dataGridViewTables.Rows[e.RowIndex].DataBoundItem;
            SecondaryForm form = new SecondaryForm(table);
            form.ShowDialog();
            this.DataGridViewTablesInitialize();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewTables.DataSource = DBOjbects.Entities.Table
                .Where(t => t.table_number.ToString().Contains(textBoxSearch.Text)).ToList();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int tableNum = int.Parse(textBoxTableNum.Text);
                DateTime date = DateTime.Parse(textBoxDate.Text);
                TableInfoOnDateForm form = new TableInfoOnDateForm(tableNum, date);
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxTableNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char temp = e.KeyChar;
            if (!Char.IsDigit(temp) && temp != 8)
                e.Handled = true;
        }

        private void buttonShowAmount_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(textBoxDateForAmount.Text);
                MessageBox.Show(DBOjbects.Entities.CallAmounFunction(date).ToList()[0].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

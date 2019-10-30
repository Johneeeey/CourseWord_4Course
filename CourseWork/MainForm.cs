using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            dataGridViewTables.Columns["Table_Reservation"].Visible = false;
            dataGridViewTables.Columns["id_table"].Visible = false;
            dataGridViewTables.Columns["img"].Visible = false;
        }

        private void dataGridViewTables_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Table table = (Table)this.dataGridViewTables.Rows[e.RowIndex].DataBoundItem;
            SecondaryForm form = new SecondaryForm(table);
            form.ShowDialog();
        }
    }
}

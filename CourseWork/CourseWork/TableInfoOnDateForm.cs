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
    public partial class TableInfoOnDateForm : Form
    {
        private int tableNum { get; }
        private DateTime date { get; }
        public TableInfoOnDateForm(int TableNum, DateTime date)
        {
            InitializeComponent();
            this.tableNum = TableNum;
            this.date = date;
            DataGridViewInfoInitialize();
        }

        private void DataGridViewInfoInitialize()
        {
            dataGridViewInfo.DataSource = DBOjbects.Entities.TableInfoOnDate(this.tableNum, this.date).ToList();
            dataGridViewInfo.Columns["reservation_number"].HeaderText = "№ брони";
            dataGridViewInfo.Columns["client_fname"].HeaderText = "Имя клиента";
            dataGridViewInfo.Columns["client_lname"].HeaderText = "Фамилия клиента";
            dataGridViewInfo.Columns["client_phone"].HeaderText = "Телефон";
            dataGridViewInfo.Columns["date_of_reservation"].HeaderText = "Дата";
            dataGridViewInfo.Columns["time_of_reservation"].HeaderText = "Время";
        }
    }
}

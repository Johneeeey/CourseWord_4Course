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
    public partial class SecondaryForm : Form
    {
        private Table Table { get; }
        public SecondaryForm(Table table)
        {
            InitializeComponent();
            this.Table = table;
            this.Fill();
        }

        private void Fill()
        {
            comboBoxColor.DataSource = DBOjbects.Entities.Color.Select(Col => Col.color_name).ToList();
            comboBoxColor.SelectedItem = Table.Color.color_name;
            comboBoxFormFactor.DataSource = DBOjbects.Entities.Form_Factor.Select(f => f.form_name).ToList();
            comboBoxFormFactor.SelectedItem = Table.Form_Factor.form_name;
            comboBoxMaterial.DataSource = DBOjbects.Entities.Material.Select(m => m.material_name).ToList();
            comboBoxMaterial.SelectedItem = Table.Material.material_name;
            textBoxTableNum.Text = Table.table_number.ToString();
            textBoxNumOfSeats.Text = Table.number_of_seats.ToString();
            dataGridViewReservations.DataSource = GetReservations();
            dataGridViewReservations.Columns["id_reservation"].Visible = false;
            dataGridViewReservations.Columns["Table_Reservation"].Visible = false;
        }

        private List<Reservation> GetReservations()
        {
            List<Reservation> reservations = new List<Reservation>();
            foreach(Table_Reservation tr in Table.Table_Reservation)
            {
                reservations.Add(DBOjbects.Entities.Reservation.FirstOrDefault
                    (res => res.id_reservation == tr.reservation_id));
            }
            return reservations;
        }

        private void dataGridViewReservations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Reservation reservation = (Reservation)this.dataGridViewReservations.Rows[e.RowIndex].DataBoundItem;
            ReservationForm form = new ReservationForm(reservation, this.Table.id_table);
            form.ShowDialog();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            ReservationForm form = new ReservationForm(reservation, this.Table.id_table);
            form.ShowDialog();
            this.Fill();
        }
    }
}

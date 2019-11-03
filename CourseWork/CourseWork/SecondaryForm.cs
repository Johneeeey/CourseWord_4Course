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
            textBoxTableNum.Text = Table.table_number == 0 ? 
                Convert.ToString(DBOjbects.Entities.Table.ToList().Last().table_number + 1) :
                Table.table_number.ToString();
            textBoxNumOfSeats.Text = Table.number_of_seats.ToString();
            dataGridViewReservations.DataSource = GetReservations();
            dataGridViewReservations.Columns["id_reservation"].Visible = false;
            dataGridViewReservations.Columns["Table_Reservation"].Visible = false;
            dataGridViewReservations.Columns["reservation_number"].HeaderText = "№ брони";
            dataGridViewReservations.Columns["client_fname"].HeaderText = "Имя клиента";
            dataGridViewReservations.Columns["client_lname"].HeaderText = "Фамилия клиента";
            dataGridViewReservations.Columns["client_phone"].HeaderText = "Телефон";
            dataGridViewReservations.Columns["time_of_reservation"].HeaderText = "Время";
            dataGridViewReservations.Columns["date_of_reservation"].HeaderText = "Дата";
            using (var ms = new MemoryStream(Table.img))
            {
                pictureBox.Image = Image.FromStream(ms);
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.Fill();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            ReservationForm form = new ReservationForm(reservation, this.Table.id_table);
            form.ShowDialog();
            this.Fill();
        }

        private void textBoxTableNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char temp = e.KeyChar;
            if (!Char.IsDigit(temp) && temp != 8)
                e.Handled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Table.table_number = int.Parse(textBoxTableNum.Text);
                this.Table.number_of_seats = int.Parse(textBoxNumOfSeats.Text);
                this.Table.material_id = DBOjbects.Entities.Material.FirstOrDefault(m =>
                  m.material_name == comboBoxMaterial.SelectedItem).id_material;
                this.Table.color_id = DBOjbects.Entities.Color.FirstOrDefault(c =>
                  c.color_name == comboBoxColor.SelectedItem).id_color;
                this.Table.form_id = DBOjbects.Entities.Form_Factor.FirstOrDefault(f =>
                  f.form_name == comboBoxFormFactor.SelectedItem).id_form_factor;
                DBOjbects.Entities.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

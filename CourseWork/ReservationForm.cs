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
    public partial class ReservationForm : Form
    {
        private Reservation Reservation { get; }
        private int Table_id { get; }
        private bool IsShown { get; }
        public ReservationForm(Reservation reservation, int table_id)
        {
            InitializeComponent();
            this.IsShown = false;
            this.Reservation = reservation;
            this.Table_id = table_id;
            this.Fill();
            this.IsShown = true;
        }

        private void Fill()
        {
            textBoxReservNum.Text = Reservation.reservation_number.ToString();
            textBoxClientFname.Text = Reservation.client_fname;
            textBoxClientLname.Text = Reservation.client_lname;
            textBoxClientPhone.Text = Reservation.client_phone;
            textBoxReservTime.Text = Reservation.time_of_reservation.ToString();
            textBoxReservDate.Text = Reservation.date_of_reservation.Date.ToString();
        }

        private void textBoxReservNum_TextChanged(object sender, EventArgs e)
        {
            if (this.IsShown)
            {
                this.Reservation.reservation_number = Int16.Parse(textBoxReservNum.Text);
                this.Reservation.client_fname = textBoxClientFname.Text;
                this.Reservation.client_lname = textBoxClientLname.Text;
                this.Reservation.client_phone = textBoxClientPhone.Text;
                this.Reservation.date_of_reservation = DateTime.Parse(textBoxReservDate.Text);
                this.Reservation.time_of_reservation = TimeSpan.Parse(textBoxReservTime.Text);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!DBOjbects.Entities.Reservation.ToArray().Contains(this.Reservation))
            {
                DBOjbects.Entities.Reservation.Add(this.Reservation);
                Table_Reservation table_Reservation = new Table_Reservation()
                {
                    table_id = this.Table_id,
                    reservation_id = this.Reservation.id_reservation
                };
                DBOjbects.Entities.Table_Reservation.Add(table_Reservation);
            }
            DBOjbects.Entities.SaveChanges();
            this.Close();
        }
    }
}

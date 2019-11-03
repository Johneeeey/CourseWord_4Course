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
        public ReservationForm(Reservation reservation, int table_id)
        {
            InitializeComponent();
            this.Reservation = reservation;
            this.Table_id = table_id;
            this.Fill();
        }

        private void Fill()
        {
            textBoxReservNum.Text = Reservation.reservation_number == 0 ?
                Convert.ToString(DBOjbects.Entities.Reservation.ToList().Last().reservation_number + 1) :
                Reservation.reservation_number.ToString();
            textBoxClientFname.Text = Reservation.client_fname;
            textBoxClientLname.Text = Reservation.client_lname;
            textBoxClientPhone.Text = Reservation.client_phone;
            textBoxReservTime.Text = Reservation.time_of_reservation.ToString("t");
            textBoxReservDate.Text = Reservation.date_of_reservation.Date.ToString("d").Substring(3);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsFieldsEmpty())
                    throw new Exception("Все поля обязательные");
                if (textBoxClientPhone.Text.Length != 11)
                    throw new Exception("Неверный формат номера телефона");
                this.Reservation.reservation_number = Int16.Parse(textBoxReservNum.Text);
                this.Reservation.client_fname = textBoxClientFname.Text;
                this.Reservation.client_lname = textBoxClientLname.Text;
                this.Reservation.client_phone = textBoxClientPhone.Text;
                this.Reservation.date_of_reservation = DateTime.Parse(textBoxReservDate.Text);
                this.Reservation.time_of_reservation = TimeSpan.Parse(textBoxReservTime.Text);
                if (IsDateTimeAvailable())
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
                else
                    throw new Exception("Это время уже занято");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBOjbects.Entities.Reservation.ToArray().Contains(this.Reservation))
                {
                    if (DBOjbects.Entities.Table_Reservation.Where(tr => tr.reservation_id == this.Reservation.id_reservation) != null)
                    {
                        DBOjbects.Entities.Table_Reservation.RemoveRange(
                                DBOjbects.Entities.Table_Reservation.Where(tr => tr.reservation_id == this.Reservation.id_reservation).ToList());
                    }
                    DBOjbects.Entities.Reservation.Remove(this.Reservation);
                    DBOjbects.Entities.SaveChanges();
                }
            this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxReservNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char temp = e.KeyChar;
            if (!Char.IsDigit(temp) && temp != 8)
                e.Handled = true;
        }

        private bool IsFieldsEmpty()
        {
            if(textBoxReservNum.Text.Length==0
                ||textBoxClientFname.Text.Length==0
                || textBoxClientLname.Text.Length==0
                || textBoxClientPhone.Text.Length==0
                || textBoxReservTime.Text.Length==0
                || textBoxReservDate.Text.Length == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsDateTimeAvailable()
        {
            DateTime date = this.Reservation.date_of_reservation;
            TimeSpan time = this.Reservation.time_of_reservation;
            List<Table_Reservation> allReservations = DBOjbects.Entities.Table_Reservation
                .Where(tr => tr.table_id == this.Table_id).ToList();
            foreach(Table_Reservation tr in allReservations)
            {
                Reservation temp = DBOjbects.Entities.Reservation.FirstOrDefault(r =>
                    r.id_reservation == tr.reservation_id);
                if (this.Reservation.id_reservation == temp.id_reservation)
                    return true;
                if (temp.date_of_reservation == date &&
                    (time.Hours >= temp.time_of_reservation.Hours - 5
                    && time.Hours <= temp.time_of_reservation.Hours + 5))
                    return false;
                else if (temp.date_of_reservation == date &&
                    (time.Hours <= temp.time_of_reservation.Hours - 5
                    || time.Hours >= temp.time_of_reservation.Hours + 5))
                    return true;
            }
            return true;
        }
    }
}

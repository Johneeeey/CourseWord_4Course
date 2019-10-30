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
    public partial class DetailsForm : Form
    {
        private Table _table;
        public DetailsForm(string TableNum)
        {
            InitializeComponent();
            CenterToScreen();
            this._table = new Table(Int16.Parse(TableNum));
            FieldsFilling(this._table);
            ButtonSave.Click += SaveButton_ClickForSave;
        }
        public DetailsForm()
        {
            InitializeComponent();
            CenterToScreen();
            TableNumTextBox.Text = Convert.ToString(FileClass.TableList.Count + 1);
            comboBoxStatus.SelectedItem = "Свободен";
            ButtonSave.Click += SaveButton_ClickForAdd;
        }

        private void SaveButton_ClickForSave(object sender, EventArgs e)
        {
            if (!IsFieldsEmpty())
            {
                string[] value = {TableNumTextBox.Text.Trim(),
                            PlaceCountTextBox.Text.Trim(),
                            comboBoxColor.SelectedItem.ToString(),
                            comboBoxForm.SelectedItem.ToString(),
                            comboBoxMaterial.SelectedItem.ToString(),
                            comboBoxStatus.SelectedItem.ToString(),
                            textBoxOwnerName.Text};
                Int16 _tableNum;
                Int16.TryParse(TableNumTextBox.Text, out _tableNum);
                FileClass.ChangeFile(_tableNum, value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте корректность введеных данных", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void SaveButton_ClickForAdd(object sender, EventArgs e)
        {
            if (!IsFieldsEmpty())
            {
                if (!IsFieldsEmpty())
                {
                    this._table.TableNumber = Int16.Parse(TableNumTextBox.Text);
                    this._table.NumberOfSeats = Int16.Parse(PlaceCountTextBox.Text.Trim());
                    this._table.Color = comboBoxColor.SelectedItem.ToString();
                    this._table.FormFactor = comboBoxForm.SelectedItem.ToString();
                    this._table.Material = comboBoxMaterial.SelectedItem.ToString();
                    this._table.Status = comboBoxStatus.SelectedItem.ToString();
                    FileClass.AddToFile(this._table);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Проверьте корректность введенных данных", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Проверьте корректность введенных данных", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void FieldsFilling(Table Table)
        {
            TableNumTextBox.Text = Table.TableNumber.ToString();
            PlaceCountTextBox.Text = Table.NumberOfSeats.ToString();
            comboBoxColor.SelectedItem = Table.Color;
            comboBoxForm.SelectedItem = Table.FormFactor;
            comboBoxMaterial.SelectedItem = Table.Material;
            comboBoxStatus.SelectedItem = Table.Status;
            textBoxOwnerName.Text = Table.Owner;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FileClass.RemoveFromFile(this._table.TableNumber);
            this.Close();
        }

        private bool IsFieldsEmpty()
        {
            if (PlaceCountTextBox.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

        private void PlaceCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char placeCount = e.KeyChar;
            if (!Char.IsDigit(placeCount) && placeCount != 8)
                e.Handled = true;
        }
        
    }
}

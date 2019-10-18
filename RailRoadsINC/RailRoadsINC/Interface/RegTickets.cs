using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RailRoadsINC.Interface
{
    public partial class RegTickets : Form
    {
        SqlConnection sqlC;
        DataSet ds;
        public RegTickets(ref DataSet SqlS, in SqlConnection sqlc)
        {
            InitializeComponent();
            sqlC = sqlc;
            ds = SqlS;
            comboBoxTrainsArrivalPoint.DataSource = (from DataRow row in SqlS.Tables[0].Rows select row["ArrivalPoint"]).ToList();
            comboBoxTrainsArrivalPoint.SelectedIndex = -1;
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> user = new Dictionary<string, string>();
            if (comboBoxTrainsArrivalPoint.SelectedItem != null || comboBoxTrain.SelectedItem != null || numericUpDownSeat.Value != 0)
            {
                user.Add("Arrival", comboBoxTrainsArrivalPoint.SelectedItem.ToString());
                user.Add("Train", comboBoxTrain.SelectedItem.ToString());
                user.Add("SeatNumber", numericUpDownSeat.Value.ToString());
                user.Add("FIO", textBoxFIO.Text.ToString());
                user.Add("Passport", textBox1.Text.ToString());
                MainForm.addReg(in sqlC, user);
                if (MessageBox.Show("Успешно добавлено!")==DialogResult.OK) {
                    this.Close();

                }

            }
            else
            {
                MessageBox.Show("Не все данные введены или введены не корректно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void ComboBoxTrainsArrivalPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTrainsArrivalPoint.SelectedIndex >= 0)
            {
                comboBoxTrain.DataSource = (from DataRow row in ds.Tables[0].Rows where row["ArrivalPoint"] == comboBoxTrainsArrivalPoint.SelectedItem.ToString() select row["ID"]).ToList();
                comboBoxTrain.Enabled = true;
                comboBoxTrain.SelectedIndex = -1;
            }
            else
                comboBoxTrain.Enabled = false;
        }

        private void ComboBoxTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTrain.SelectedIndex >= 0)
            {
                var adapter = new SqlDataAdapter($"Select NumberOfSeats From Train where ID={comboBoxTrain.SelectedItem.ToString()}", sqlC);
                var datas = new DataSet();
                adapter.Fill(datas);
                var seatsArray = datas.Tables[0].Rows[0].ItemArray;
                numericUpDownSeat.Maximum = Convert.ToInt32(seatsArray[0]);
                numericUpDownSeat.Enabled = true;
            }
            else
            {
                numericUpDownSeat.Enabled = false;

            }
        }
        private void NumericUpDownSeat_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSeat.Value != 0)
            {
                textBoxFIO.Enabled = true;
            }
            else
            {
                textBoxFIO.Enabled = false;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxFIO_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFIO.TextLength > 0)
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;
        }

        private void TextBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
    }
}

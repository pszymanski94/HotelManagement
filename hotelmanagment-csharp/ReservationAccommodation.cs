using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ReservationAccommodation : Form
    {
        public ReservationAccommodation()
        {
            InitializeComponent();
            CenterToScreen();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
            radioButton1.Checked = true;
        }

        Random rnd = new Random();
        int price = 0;
        int number_of_days = 0;
        int type_payment =0;
        float to_payment=0;
       
        public void setComboBox()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = localhost; Initial Catalog = Zaliczenie; Integrated Security = True";
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT NumberRoom FROM Rooms where IDType=" + TypPokoju.SelectedValue +" and NumberRoom not in (select NumberRoom from Reservation where not ('"+ DateTime.Parse(dateTimePicker2.Text) + "'< DateArrival OR '" + DateTime.Parse(dateTimePicker1.Text) + "'>DateDeparture))", con);

                SqlDataReader umg = cmd.ExecuteReader();
                while (umg.Read())
                {comboBox1.Items.Add(umg["NumberRoom"]); }
                umg.Close();
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void downloadPrice()
        {
            TimeSpan difference = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);
             number_of_days = (int)difference.TotalDays;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = localhost; Initial Catalog = Zaliczenie; Integrated Security = True";
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Cost FROM RoomsDescription where IDType=" + TypPokoju.SelectedValue, con);

                SqlDataReader umg = cmd.ExecuteReader();
                if (umg.HasRows){
                    umg.Read();
                    price = umg.GetInt32(0);
                }
                umg.Close();
                con.Close();
              
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        public void givePrice()
        {
            Strategy xyz = null;
            switch (type_payment)
            {
                case 1:
                    xyz = new StrategyCash();
                    break;
                case 2:
                    xyz = new StrategyCard();
                    break;
                case 3:
                    xyz = new StrategyPrepayment();
                    break;
            }

            to_payment=xyz.CalculatorStrategy(price, number_of_days);

        }

        public void sendtoBase()
        {
            string value = "Insert into Reservation(Name, Subname, Phone, Email, DateArrival, DateDeparture, NumberRoom, AmountPayable,Payment) values('" + Name_Box.Text + "', '" + Subname_Box.Text + "', '" + Phone_Box.Text + "', '" + Email_Box.Text + "', '" +DateTime.Parse(dateTimePicker1.Text) +
              "', '" + DateTime.Parse(dateTimePicker2.Text) + "',"+(int)comboBox1.SelectedItem+","+to_payment+ ","+ type_payment +")";

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = localhost; Initial Catalog = Zaliczenie; Integrated Security = True";
                con.Open();
                SqlCommand cmd = new SqlCommand(value, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezerwacja powiodła się! Kwota do zapłaty:"+to_payment+" złotych");
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        public void booking(){
            downloadPrice();
            givePrice();
            sendtoBase();
        }
        ////////////////////////////////////////////////////////////////

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rezerwacja_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'jiPPZ509DataSet1.RoomDescription' . Możesz go przenieść lub usunąć.
            this.roomDescriptionTableAdapter.Fill(this.jiPPZ509DataSet1.RoomDescription);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart d = new ThreadStart(booking);
            Thread watek = new Thread(d);
            watek.Start();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Subname_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
       
          

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            type_payment = 1;
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                type_payment = 2;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            setComboBox();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                type_payment = 3;
        }

        private void Phone_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

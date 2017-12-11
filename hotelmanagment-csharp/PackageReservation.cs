using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class PackageReservation : Form
    {
        public void reservation()
        {
            Calculator sport = new CalculatorSport();
            if (checkBox1.Checked)
            {
                sport = new DecoratorMassage(sport);
            }
            if (checkBox2.Checked)
            {
                sport = new DecoratorSauna(sport);
            }
            if (checkBox3.Checked)
            {
                sport = new DecoratorSaltCave(sport);
            }

            string description = sport.getName();
            int price = sport.calculateCost();
            string value = "Insert into ReservationPackage (Description,Name,Subname,Phone,Email,Price) Values ('" + description+ "', '" +Name_Box.Text+ "', '"+Subname_Box.Text + "', '" + Phone_Box.Text + "', '" + Email_Box.Text +"',"+price+")";
           
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = localhost; Initial Catalog = Zaliczenie; Integrated Security = True";
                con.Open();
                SqlCommand cmd = new SqlCommand(value, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dokonano rezerwacji! Opis: "+description+" Cena: "+price.ToString()+" zł");
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        
   }
    

        public PackageReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

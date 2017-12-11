using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AddNews : Form
    {

        public AddNews()
        {
            InitializeComponent();
        }

        public void setNews()
        {
            News abc = new News();
            NewsSQL sql = new NewsSQL(abc);
            NewsEmail mail = new NewsEmail(abc);
            abc.addObserved(sql);
            abc.addObserved(mail);
            abc.setTitle(titleBox.Text);
            abc.setDescription(descriptionBox.Text);
            abc.notifyObservers();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setNews();
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setNews();
        }
    }
}

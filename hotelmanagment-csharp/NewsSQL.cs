using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    class NewsSQL:Observer
    {
        string title;
        string description;
        News news;

        public NewsSQL(News o)
        {
            this.news = o;
        }
        public void update()
        {
             title = news.getTitle();
             description= news.getDescription();

             string value = "Insert into News(Title, Description) values('" +title + "', '" + description + "')";

             try
             {
                 SqlConnection con = new SqlConnection();
                 con.ConnectionString = "Data Source = localhost; Initial Catalog = Zaliczenie; Integrated Security = True";
                 con.Open();
                 SqlCommand cmd = new SqlCommand(value, con);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Zapisano do bazy danych");
             }
             catch (Exception ex)
             { MessageBox.Show(ex.Message); }
        }
    }
}

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
    public partial class SeeReservations : Form
    {
        public SeeReservations()
        {
            InitializeComponent();
        }

        private void SeeReservations_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'jiPPZ509DataSet1.ReserPackage' . Możesz go przenieść lub usunąć.
            this.reserPackageTableAdapter.Fill(this.jiPPZ509DataSet1.ReserPackage);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'jiPPZ509DataSet1.ReservationList' . Możesz go przenieść lub usunąć.
            this.reservationListTableAdapter.Fill(this.jiPPZ509DataSet1.ReservationList);

        }
    }
}

using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmPrikazKorisnika : Form
    {
        private APIService _sercvice = new APIService("Korisnici");
        public frmPrikazKorisnika()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KorisniciSearchObject request = new KorisniciSearchObject() { Ime = txtIme.Text };

            dgwKorisnici.DataSource = await _sercvice.Get<IEnumerable<Models.Korisnici>>(request);
        }

        private async void frmPrikazKorisnika_Load(object sender, EventArgs e)
        {
            dgwKorisnici.DataSource = await _sercvice.Get<IEnumerable<Models.Korisnici>>();
        }
    }
}

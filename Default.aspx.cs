using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ornek2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;

            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);

            Response.Write(sayi1 + sayi2);

        }

        protected void btnCikar_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;

            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);

            Response.Write(sayi1 - sayi2);
        }

        protected void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;

            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);

            Response.Write(sayi1 * sayi2);
        }

        protected void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;

            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);

            Response.Write(sayi1 / sayi2);
        }
    }
}
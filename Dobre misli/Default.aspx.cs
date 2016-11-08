using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    public partial class Default : System.Web.UI.Page
    {
        public static List<Label> ToughLabels = new List<Label>();
        protected void Page_Load(object sender, EventArgs e)
        {
            misel.Text = "";
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            Label l = new Label();
            l.Text = "\""+Request.Form["misel"]+"\"";
            l.Style.Add("display", "block");
            ToughLabels.Add(l);
            if (ToughLabels.Count > 0)
            {
                foreach (Label lab in ToughLabels)
                {
                    FindControl("misli").Controls.AddAt(0, lab);
                }
            }
        }
    }
    
}
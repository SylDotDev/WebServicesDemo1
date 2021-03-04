using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebService2SoapClient client =
                new CalculatorService.CalculatorWebService2SoapClient();
            int result = client.Add(Convert.ToInt32(txtX.Text),
                Convert.ToInt32(txtY.Text));
            lblResult.Text = result.ToString();
        }
    }
}
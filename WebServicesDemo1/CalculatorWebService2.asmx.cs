using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo1
{
    /// <summary>
    /// Summary description for CalculatorWebService2
    /// </summary>
    [WebService(Namespace = "http://sylvia.net/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService2 : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public int Add(int x, int y)
        {
            List<string> calculations;

            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }

            string strRecentCalculation = x.ToString() + " + " + y.ToString() +
                " = " + (x + y).ToString();

            calculations.Add(strRecentCalculation);
            Session["CALCULATIONS"] = calculations;

            return x + y;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations.");
                return calculations;
            }
            else 
            {
                return (List<string>)Session["CALCULATIONS"];
            
            }
        }
    }
}

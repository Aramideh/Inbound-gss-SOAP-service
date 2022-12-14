using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Outbound_Math_Soap_Service
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int a, int b)
        {
            return (a + b);
        }
        [WebMethod]
        public System.Double Subtract(System.Double A, System.Double B)
        {
            return (A - B);
        }
        [WebMethod]
        public System.Double Multiply(System.Double A, System.Double B)
        {
            return A * B;
        }
        [WebMethod]
        public System.Double Divide(System.Double A, System.Double B)
        {
            if (B == 0) return -1;
            return Convert.ToSingle(A / B);
        }


    }
}

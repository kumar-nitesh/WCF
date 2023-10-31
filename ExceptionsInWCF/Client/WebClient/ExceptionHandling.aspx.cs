using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ServiceReference;

namespace WebClient
{
    /// <summary>
    /// Once the exception occurs, the channel becomes faulty.
    /// </summary>
    public partial class ExceptionHandling : System.Web.UI.Page
    {
        DivideClient proxy = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new DivideClient();
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.Text = proxy.DivideNumber(Convert.ToInt32(txtNum.Text), Convert.ToInt32(txtDenom.Text)).ToString();
            }
            catch(FaultException faultMessage)
            {
                lblResult.Text = faultMessage.Message;
            }
        }
    }
}
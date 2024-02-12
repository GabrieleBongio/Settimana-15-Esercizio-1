using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void ShowNameSurname(object sender, EventArgs e)
        {
            Response.Write(ConfigurationManager.AppSettings["name"]);
        }
    }
}

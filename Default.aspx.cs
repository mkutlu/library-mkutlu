using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace library
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void deneme_onClickEvent(object sender, EventArgs e)
        {
            Response.Write("<script>alert('deneme.')</script>");
        }
    }
}
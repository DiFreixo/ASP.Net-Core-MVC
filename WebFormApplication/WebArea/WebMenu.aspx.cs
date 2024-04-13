using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArea
{
    public partial class WebMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetangulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebRetangulo.aspx");
        }

        protected void btnTriangulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebTriangulo.aspx");
        }

        protected void btnQuadrado_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebQuadrado.aspx");
        }

        protected void btnCirculo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebCirculo.aspx");
        }
    }
}
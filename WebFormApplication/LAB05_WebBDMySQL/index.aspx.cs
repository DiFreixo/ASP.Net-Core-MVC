using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB05_WebBDMySQL
{
    public partial class index : System.Web.UI.Page
    {
        DBConnect ligacao = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNFormandos.Text = ligacao.Count().ToString();
            lblMedia.Text = ligacao.Media().ToString("0.00");
            
            if(!Page.IsPostBack)
            {
                lblMensagem.Text = Request.QueryString["r"];
                ligacao.Bind(ref GridView1);
                GridView1.DataBind();
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormInsert.aspx");
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormUpdate.aspx");
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormDelete.aspx");
        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            ligacao.Bind(ref GridView1);
            GridView1.DataBind();
        }
    }
}
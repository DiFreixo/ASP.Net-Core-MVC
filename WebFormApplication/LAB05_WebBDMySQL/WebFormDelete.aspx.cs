using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB05_WebBDMySQL
{
    public partial class WebFormDelete : System.Web.UI.Page
    {
        DBConnect ligacao = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ligacao.CarregarFormandos(ref ddlFormandos);
            }
        }

        protected void ddlFormandos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome_aux = "";
            char genero = ' ';
            int idade = 0;
            string id = ddlFormandos.SelectedItem.Text;

            if (id.Length > 0)
            {
                id = id.Substring(0, id.IndexOf(' '));
                ligacao.DevolverFormando(id, ref nome_aux, ref genero, ref idade);

                lblNome.Text = nome_aux;
                lblGenero.Text = genero.ToString();
                lblIdade.Text = idade.ToString();
            }
            else
            {
                lblNome.Text = "";
                lblGenero.Text = "";
                lblIdade.Text = "";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx?r=Cancelou o procedimento de apagar!");
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            string id = ddlFormandos.SelectedItem.Text;

            if (id.Length > 0)
            {
                id = id.Substring(0, id.IndexOf(' '));
                if (ligacao.Delete(id))
                {
                    Response.Redirect("index.aspx?r=Apagou com sucesso.");
                }
                else
                {
                    Response.Redirect("index.aspx?r=Erro na eliminação do formando!");
                }
            }
        }
    }
}
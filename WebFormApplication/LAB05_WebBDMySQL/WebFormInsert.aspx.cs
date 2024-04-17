using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB05_WebBDMySQL
{
    public partial class WebFormInsert : System.Web.UI.Page
    {
        DBConnect ligacao = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                carregarIdades();
                ddlIdade.SelectedIndex = 17;
            }
        }


        void carregarIdades()
        {
            for (int i = 1; i <= 150; i++)
            {
                ddlIdade.Items.Add(i.ToString());
            }
        }

        bool verificarCampos()
        {
            txtNome.Text = txtNome.Text.Trim();
            txtNome.Text = Regex.Replace(txtNome.Text, @"\s+", " ");
            if (txtNome.Text.Length == 0)
            {
                lblMensagem.Text = "Erro no campo Nome!";
                txtNome.Focus();
                return false;
            }

            if (rbMasculino.Checked == false && rbFeminino.Checked == false)
            {
                lblMensagem.Text = "Erro no campo Género!";
                return false;
            }

            return true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            char genero = 'M';
            if (verificarCampos())
            {
                if (rbFeminino.Checked)
                {
                    genero = 'F';
                }
                if (ligacao.Insert(txtNome.Text, genero, ddlIdade.SelectedItem.Text))
                {
                    Response.Redirect("index.aspx?r=Inseriu com sucesso!");
                    //lblMensagem.Text = "Inseriu com sucesso!";
                }
                else
                {
                    lblMensagem.Text = "ERRO na inserção!";
                }
            }

        }
    }
}
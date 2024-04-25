using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB05_WebBDMySQL
{
    public partial class WebFormUpdate : System.Web.UI.Page
    {

        DBConnect ligacao = new DBConnect();
        string idSelecionado = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (!this.IsPostBack)
                {
                    ligacao.CarregarFormandos(ref ddlFormando);
                    carregarIdades();
                    ddlIdade.SelectedIndex = 17;
                }
            }
        }


        protected void ddlFormando_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome_aux = "";
            char genero = ' ';
            int idade = 0;
            string id = ddlFormando.SelectedItem.Text;

            if (id.Length > 0)
            {
                id = id.Substring(0, id.IndexOf(' '));
                idSelecionado = id;
                ligacao.DevolverFormando(id, ref nome_aux, ref genero, ref idade);
                txtID.Text = id;
                txtNome.Text = nome_aux;
                ddlIdade.SelectedValue = idade.ToString();
                lblMensagem.Text = "";

                
                if (genero == 'F')
                {
                    rbFeminino.Checked = true;
                    rbMasculino.Checked = false;
                }
                else if (genero == 'M')
                {
                    rbMasculino.Checked = true;
                    rbFeminino.Checked = false;
                }
            }
            else
            {
                txtID.Text = "";
                txtNome.Text = "";                
                ddlIdade.SelectedIndex = 17;
                rbMasculino.Checked = false;
                rbFeminino.Checked = false;
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx?r=Cancelou o procedimento de atualizar!");
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            
            char genero = 'M';
            if (verificarCampos())
            {
                if (rbFeminino.Checked)
                {
                    genero = 'F';
                }
                if (ligacao.Update(idSelecionado, txtNome.Text, genero, ddlIdade.SelectedItem.Text))
                {
                    Response.Redirect("index.aspx?r=Atualizou com sucesso!");
                }
                else
                {
                    lblMensagem.Text = "ERRO na atualização!";
                }
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


    }
}
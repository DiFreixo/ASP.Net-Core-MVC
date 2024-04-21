using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace LAB05_WebBDMySQL
{
    public partial class Logon : System.Web.UI.Page
    {
        DBConnect ligacao = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Restaura o valor da senha do ViewState
                if (ViewState["Password"] != null)
                    txtPassword.Attributes["value"] = ViewState["Password"].ToString();
            }
        }
       
        protected void btnLogon_Click(object sender, EventArgs e)
        {
            if(ligacao.ValidateUser(txtEmail.Text, txtPassword.Text))
            {
                Session["userName"] = txtEmail.Text;
                FormsAuthentication.RedirectFromLoginPage(txtEmail.Text, false);
                Response.Redirect("index.aspx");
            }
            else
            {
                lblMensagem.Text = "Nome ou Palavra Passe incorreto!";
            }
        }


        protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {
            string currentPassword = txtPassword.Text;

            if (CheckBox1.Checked)
            {   // exibe a password
                txtPassword.TextMode = TextBoxMode.SingleLine; ;
            }
            else
            {   // oculta a password
                txtPassword.TextMode = TextBoxMode.Password;
            }

            txtPassword.Attributes["value"] = currentPassword;
        }
    }
}
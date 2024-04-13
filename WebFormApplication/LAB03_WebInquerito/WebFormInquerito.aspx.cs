using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB03_WebInquerito
{
    public partial class WebFormInquerito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            TextBox1.MaxLength = 60;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string display = "", comida = "", clube = "";

            // verificar qual checkbox está selecionada
            if(CheckBox1.Checked)
            {
                comida = CheckBox1.Text;
            }

            if (CheckBox2.Checked)
            {
                if(comida.Length > 0)
                {
                    comida = comida + ", ";
                }
                comida += CheckBox2.Text;
            }

            if (CheckBox3.Checked)
            {
                if (comida.Length > 0)
                {
                    comida = comida + " e ";
                }
                comida += CheckBox3.Text;
            }


            // verificar qual radioButton está selecionado
            if(RadioButton1.Checked)
            {
                clube = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                clube = RadioButton2.Text;
            }
            else if (RadioButton3.Checked)
            {
                clube = RadioButton3.Text;
            }


            display = TextBox1.Text + " vive em " + ListBox1.Text +
                ", gosta de comer " + comida + " e o seu clube do coração é o " + clube;
            Label1.Text = display;

            ClientScript.RegisterStartupScript(this.GetType(), "Mensagem", "alert('" + display + "');", true);
        
            DBConnect ligacao = new DBConnect();
            if(ligacao.Insert(TextBox1.Text, ListBox1.Text, comida, clube))
            {
                Label1.Text = "Inseriu com sucesso!";
            }
            else
            {
                Label1.Text = "Erro na inserção!";
            }

        }
    }
}
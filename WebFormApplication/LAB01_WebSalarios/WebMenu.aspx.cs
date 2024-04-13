using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB01_WebSalarios
{
    public partial class WebMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
               
                //Declaração de variáveis 
                double bruto, segSocial, irs, liquido;

                //Obtenção dos dados

                bruto = double.Parse(txtSalarioBruto.Text);

                //Cáculos 
                segSocial = bruto * 0.2;
                if (bruto < 500)
                {
                    irs = 0;
                }
                else if (bruto >= 500 && bruto < 1000)
                {
                    irs = bruto * 0.12;
                }
                else if (bruto >= 1000 && bruto < 1500)
                {
                    irs = bruto * 0.15;
                }
                else
                {
                    irs = bruto * 0.18;
                }

                liquido = bruto - segSocial - irs;

                //Apresentação do resultado
                txtLiquido.Text = liquido.ToString("0.00 €");

                
                Console.WriteLine("Líquido: " + liquido.ToString("0.00 €"));
            }
            catch
            {
                txtLiquido.Text = "ERRO!";
            }
           
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLiquido.Text = "";
            txtSalarioBruto.Text = "";
        }
    }
}
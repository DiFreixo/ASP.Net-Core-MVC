using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB02_WebCalendario
{
    public partial class WebFormCalendario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIdade.Text = "";
            if (!IsPostBack)
            {
                int i;
                for(i=1; i <= 31; i++)
                {
                    DropDownListDia.Items.Add(i.ToString());
                }

                for (i = 1; i <= 12; i++)
                {
                    DropDownListMes.Items.Add(i.ToString());
                }

                for (i = DateTime.Today.Year; i >= 1900; i--)
                {
                    DropDownListAno.Items.Add(i.ToString());
                }

                DropDownListAno.Items.FindByText("2000").Selected = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblDataNascimento.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        // calcular quantos dias faltam para o aniversário
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(lblDataNascimento.Text == "" || Calendar1.SelectedDate > DateTime.Today)
            {
                lblIdade.Text = "Tem que indicar uma data!";
                lblInfo.Text = "";
            }
            else{
                DateTime dataNascimento = Calendar1.SelectedDate, today = DateTime.Today;
                int age = today.Year - dataNascimento.Year;
                
                if(dataNascimento > today.AddYears(-age))
                {
                    // significa que ainda não fez anos
                    lblInfo.Text  = "Ainda falta(m) " + (dataNascimento.AddYears(age) - today).TotalDays.ToString() + " dia(s) para o aniversário!";
                   
                    age--;
                }
                else
                {
                    // significa que já fez anos
                    lblInfo.Text = "Ainda falta(m) " + (dataNascimento.AddYears(age + 1) - today).TotalDays.ToString() + " dia(s) para o aniversário!";
                }

                lblIdade.Text = age.ToString() + " anos";
                // calcular os dias vividos
                int diasVividos = (today - dataNascimento).Days;
                lblDiasVividos.Text = "Já viveu " + diasVividos.ToString() + " dia(s)!";

                // determinar o signo e atualizar a imagem
                lblSigno.Text = "Signo: " + horoscopo(dataNascimento.Day, dataNascimento.Month, ref imagem);
            }
        }

        // alterar a data selecionada do calendário e do lblDataNascimento
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(txtDataNascimento.Text);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                lblDataNascimento.Text = Calendar1.SelectedDate.ToShortDateString();
                lblInfo.Text = "";
                lblIdade.Text = "";

            }
            catch
            {
                txtDataNascimento.Text = "Data incorreta!";
            }

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + txtDataNascimento.Text + "');", true);
        }

        //Construir a data no formato dd/MM/AAAA a apartir dos valores introduzidos nos dropDownList
        protected void Button3_Click(object sender, EventArgs e)
        {
            string data = DropDownListDia.SelectedValue + "/" + DropDownListMes.SelectedValue + "/" + DropDownListAno.SelectedValue;
            try
            {
                DateTime dateTime = Convert.ToDateTime(data);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                lblDataNascimento.Text = Calendar1.SelectedDate.ToShortDateString();
                txtDataNascimento.Text = data;
                lblInfo.Text = "";

            }
            catch
            {
                txtDataNascimento.Text = "Data incorreta!";
            }
        }

        private string horoscopo(int dia, int mes, ref Image imagem)
        {
            string signo = "";
            
            mes = int.Parse(DropDownListMes.SelectedValue);
            dia = int.Parse(DropDownListDia.SelectedValue);
            
            if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            {
                signo = "Virgem";
                imagem.ImageUrl = "~/img/virgem.jpg";
            }
            if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            {
                signo = "Balança";
                imagem.ImageUrl = "~/img/balanca.jpg";
            }
            if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            {
                signo = "Escorpião";
                imagem.ImageUrl = "~/img/escorpiao.jpg";
            }
            if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            {
                signo = "Sagitário";
                imagem.ImageUrl = "~/img/sagitario.jpg";
            }
            if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            {
                signo = "Capricórnio";
                imagem.ImageUrl = "~/img/capricornio.jpg";
            }
            if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
            {
                signo = "Aquário";
                imagem.ImageUrl = "~/img/aquario.jpg";
            }
            if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
            {
                signo = "Peixes";
                imagem.ImageUrl = "~/img/peixes.jpg";
                return signo;
            }
            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 20))
            {
                signo = "Carneiro";
                imagem.ImageUrl = "~/img/carneiro.jpg";
            }
            if ((mes == 4 && dia >= 21) || (mes == 5 && dia <= 20))
            {
                signo = "Touro";
                imagem.ImageUrl = "~/img/touro.jpg";
            }
            if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            {
                signo = "Gêmeos";
                imagem.ImageUrl = "~/img/gemeos.jpg";
            }
            if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
            {
                signo = "Caranguejo";
                imagem.ImageUrl = "~/img/caranguejo.jpg";
            }
            if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
            {
                signo = "Leão";
                imagem.ImageUrl = "~/img/leao.jpg";
            }
            return signo;
        }



        private string horoscopo(DateTime data)
        {
            string signo = "";
            int mes, dia;
            mes = data.Month;
            dia = data.Day;

            if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            {
                signo = "Virgem";
                imagem.ImageUrl = "~/img/virgem.jpg";
                return signo;
            }
            if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            {
                signo = "Balança";
                imagem.ImageUrl = "~/img/balanca.jpg";
                return signo;
            }
            if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            {
                signo = "Escorpião";
                imagem.ImageUrl = "~/img/escorpiao.jpg";
                return signo;
            }
            if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            {
                signo = "Sagitário";
                imagem.ImageUrl = "~/img/sagitario.jpg";
                return signo;
            }
            if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            {
                signo = "Capricórnio";
                imagem.ImageUrl = "~/img/capricornio.jpg";
                return signo;
            }
            if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
            {
                signo = "Aquário";
                imagem.ImageUrl = "~/img/aquario.jpg";
                return signo;
            }
            if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
            {
                signo = "Peixes";
                imagem.ImageUrl = "~/img/peixes.jpg";
                return signo;
            }
            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 20))
            {
                signo = "Carneiro";
                imagem.ImageUrl = "~/img/carneiro.jpg";
                return signo;
            }
            if ((mes == 4 && dia >= 21) || (mes == 5 && dia <= 20))
            {
                signo = "Touro";
                imagem.ImageUrl = "~/img/touro.jpg";
                return signo;
            }
            if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            {
                signo = "Gêmeos";
                imagem.ImageUrl = "~/img/gemeos.jpg";
                return signo;
            }
            if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
            {
                signo = "Caranguejo";
                imagem.ImageUrl = "~/img/caranguejo.jpg";
                return signo;
            }
            if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
            {
                signo = "Leão";
                imagem.ImageUrl = "~/img/leao.jpg";
                return signo;
            }
            return "";
        }

    }
}
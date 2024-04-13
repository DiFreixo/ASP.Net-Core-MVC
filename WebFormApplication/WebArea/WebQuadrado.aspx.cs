﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArea
{
    public partial class WebQuadrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (Math.Pow(float.Parse("0" + txtLargura.Text), 2)).ToString();

            }
            catch
            {
                lblResultado.Text = "ERRO!";
            }
        }

        protected void menu_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebMenu.aspx");
        }
    }
}
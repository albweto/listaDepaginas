using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace listaDepaginas
{
  
    public partial class index : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == string.Empty)
            {
                Label1.Text = "El valor no puede ser nulo";
            }
            else {
               
                ListBox1.Items.Add(TextBox1.Text);
                TextBox1.Text = "";
                Label1.Text = "";

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebServicePersona.Service1Client servicio = new WebServicePersona.Service1Client();
            var persona = servicio.GetPersona(12345, "Juanito", "Perez", 25);

            lblcedula.Text = persona.cedula.ToString(); 
            lblnombre.Text = persona.nombre;
            lblapellido.Text = persona.apellido;
            lbledad.Text = persona.edad.ToString();



        }
    }
}
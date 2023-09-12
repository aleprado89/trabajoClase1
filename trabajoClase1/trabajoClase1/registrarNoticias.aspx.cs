using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trabajoClase1
{
    public partial class registrarNoticias : System.Web.UI.Page
    {
        /*VARIABLES*/

        string correo, nombre, seleccion;

        /*METODOS*/

        //Load
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        /*EVENTOS*/

        //Verificar Persona
        protected void verificarPersonaBT_Click(object sender, EventArgs e)
        {
            correo = correoTB.Text;
            nombre = nombreTB.Text;

            if (correo != "" && nombre != "")
            {
                int cantidadSeleccionada = 0;
                seleccion = "Temas Seleccionados (";

                if (politicaCB.Checked == true)
                {
                    seleccion = seleccion + "-" + "Política";
                    cantidadSeleccionada++;
                }
                if (deportesCB.Checked == true)
                {
                    seleccion = seleccion + "-" + "Deportes";
                    cantidadSeleccionada++;
                }
                if (espectaculoCB.Checked == true)
                {
                    seleccion = seleccion + "-" + "Espectáculo";
                    cantidadSeleccionada++;
                }
                if (internacionalCB.Checked == true)
                {
                    seleccion = seleccion + "-" + "Internacional";
                    cantidadSeleccionada++;
                }
                if (sociedadCB.Checked == true)
                {
                    seleccion = seleccion + "-" + "Sociedad";
                    cantidadSeleccionada++;
                }
                seleccion = seleccion + "-).";

                if (cantidadSeleccionada == 0)
                {
                    resultadoLB.Text = "Falta seleccionar los temas de interés.";
                }
                else
                {
                    resultadoLB.Text = nombre + " - " + correo + " - " + seleccion;
                }
            }
            else
            {
                resultadoLB.Text = "Falta registrar una direccion de correo válida o nombre.";
            }
        }
    }
}
using System;
using System.Web.UI;
// Namespace del cliente generado para el servicio WCF

namespace WebApp
{
    public partial class Pagos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }

        protected void btnRegistrarPago_Click(object sender, EventArgs e)
        {
   
            var client = new Pago();

            try
            {
             
                int idEstudiante = Convert.ToInt32(Estudiante.SelectedValue);
                double montoPago = Convert.ToDouble(Pago.Text);
               
                client.RegistrarPago(idEstudiante, montoPago);
              
                lblMensaje.Text = "El pago se ha registrado correctamente.";
            }
            catch (Exception ex)
            {
               
                lblMensaje.Text = "Error al registrar el pago: " + ex.Message;
            }
            finally
            {
                
                client.Close();
            }
        }
    }

    public partial class EstadoCuenta : Page
    {
        protected void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            
            var client = new Pago();

            try
            {
                
                int idEstudiante = Convert.ToInt32(ddlEstudiantes.SelectedValue);
                
                var estadoCuenta = client.ObtenerEstadoCuenta(idEstudiante);
                // Mostrar el estado de cuenta en algún control de la interfaz de usuario 
                gvEstadoCuenta.DataSource = estadoCuenta;
                gvEstadoCuenta.DataBind();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y mostrar un mensaje de error
                lblMensaje.Text = "Error al generar el estado de cuenta: " + ex.Message;
            }
            finally
            {
                // Siempre cerrar el cliente del servicio WCF
                client.Close.();
            }
        }
    }
}

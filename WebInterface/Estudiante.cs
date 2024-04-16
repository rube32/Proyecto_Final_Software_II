using System;
using System.Web.UI.WebControls;
using WebApp.WcfService;

namespace WebApp
{
    public partial class Estudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEstudiantes();
            }
        }

        private void CargarEstudiantes()
        {
            var client = new Estudiante();

            try
            {
                var estudiantes = client.ObtenerListaEstudiantes();
                gvEstudiantes.DataSource = estudiantes;
                gvEstudiantes.DataBind();
            }
            catch (Exception ex)
            {
                // Manejar error
            }
            finally
            {
                client.Close();
            }
        }

        protected void gvEstudiantes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "VerDetalles")
            {
                int rowIndex = int.Parse(e.CommandArgument.ToString());
                int idEstudiante = int.Parse(Estudiantes.DataKeys[rowIndex]["Id"].ToString());
                Response.Redirect($"EstudianteDetalle.aspx?id={idEstudiante}");
            }
        }
    }
}

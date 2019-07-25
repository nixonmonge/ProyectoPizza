using Pizza.Dal;
using Pizza.Ef;
using Pizza.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Pizza
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Empleados usuarioIngresado = EmpleadosServicio.FactoryLogin(TxtUsuario, TxtClave);
            string encriptacion = Util.Base64Encode(Util.Encriptar(TxtClave.Text));
            // clave admin= Pz8/P3E/YDE/Pz8/fj8BP394SgorPz8/Pz8/GT8be04=

            Empleados usuarioBase = EmpleadosDal.Validar(usuarioIngresado);

            if (usuarioBase == null)
            {
                PanelError.Visible = true;
            }
            else
            {
                PanelError.Visible = false;
                // guardar la sesion
                Session["usuario"] = usuarioBase; // genero una cookie

                Response.Redirect("Index.aspx");
            }
        }
    }
}
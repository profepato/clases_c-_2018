using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*IMPORTANTE!!!!*/
using System.Web.SessionState;

namespace Clase_021018_ASP {
    /// <summary>
    /// Descripción breve de SaludarHandler
    /// </summary>
    public class SaludarHandler : IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext c) {
            c.Response.ContentType = "text/html";
            c.Response.Write("<h1>Hola desde Handler!</h1>");

            String nombre = c.Request.Params["nombre"];
            c.Response.Write("Que tal "+nombre+"<br>");
            c.Response.Write("<a href='Default.aspx'>Volver</a>");

            // IDAO_Producto dp = new IDAO_Producto();

            // dp.Create(pro);

            if (nombre == "Palacios") {
                c.Session["mensaje"] = "Usted es Palacios";
                c.Response.Redirect("Default.aspx");
            }
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Clase_021018_ASP {
    /// <summary>
    /// Descripción breve de SumarHandler
    /// </summary>
    public class SumarHandler : IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "texto/html";
            context.Response.Write("Hola a todos");
            int n1, n2, suma;

            n1 = int.Parse(context.Request.Params["s1"]);

            n2 = int.Parse(context.Request.Params["s2"]);

            suma = n1 + n2;

            context.Session["resultado"] = suma;

            context.Response.Redirect("Resultado.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}
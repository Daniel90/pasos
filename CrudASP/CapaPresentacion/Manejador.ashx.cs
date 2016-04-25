using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaPresentacion
{
    /// <summary>
    /// Descripción breve de Manejador
    /// </summary>
    public class Manejador : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["Registro"] != null)
            {
                DataTable tbRegistro = (DataTable)context.Session["Registro"];
                DataRow drRegistro = tbRegistro.Select(string.Format("codigo={0}", context.Request.QueryString["codigo"]))[0];
                byte[] imagen = (byte[])drRegistro["imagen"];
                context.Response.ContentType = "image/jpg";
                context.Response.OutputStream.Write(imagen, 0, imagen.Length);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
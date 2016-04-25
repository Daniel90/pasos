using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaNegocio;

namespace CapaPresentacion
{
    /// <summary>
    /// Descripción breve de Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            
            
                        
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
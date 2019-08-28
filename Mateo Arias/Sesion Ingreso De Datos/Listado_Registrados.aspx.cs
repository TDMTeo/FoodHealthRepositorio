﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Logistica
{
    public partial class Listado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaPersona();
            GvUsuarios.DataBind();
        }

        protected void GvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaPersona();
            GvUsuarios.DataBind();
            GridViewRow fila = GvUsuarios.SelectedRow;
            String nombre = fila.Cells[2].Text;
            Response.Write("<script>alert(" + nombre + ")</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GvUsuarios.DataSource = Mostrar.ListaPersona();
            GvUsuarios.DataBind();
        }
    }
}
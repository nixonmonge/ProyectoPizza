﻿using Pizza.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class WebOrdenesIngresadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewOrdenes.DataSource = OrdenesDal.ListarOrdenes();
            GridViewOrdenes.DataBind();

        }
    }
}
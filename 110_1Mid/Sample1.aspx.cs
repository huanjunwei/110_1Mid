﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Mid
{
    public partial class Sample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) { 
            string code==
            
            
            }
            string list = "";
            int i;
            for (i = 0; i < cl.Inter.Items.Count; i++)
            {
                if (cl_Inter.Items[i].Selected)
                {
                    list += cl_Inter.Items[i].Value + "/n";
                }

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz {
    public partial class Quiz20210511_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string tb_Name = "";
            string tb_ID = "";
            
            if (Session["Name"] != null || Session["ID"] != null)
            {
                tb_ID = (string)Session["ID"];
                tb_Name = (string)Session["Name"];
                Response.Write("ID: " + tb_ID + "<br />" + "Name: " + tb_Name);
            }
        }
    }
}
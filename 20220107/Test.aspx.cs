using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20220107
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Txt.Text = "你選擇了" + ddl_User.SelectedValue;
        }
    }
}
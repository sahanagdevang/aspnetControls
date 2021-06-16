using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetControls
{
    public partial class Site3 : BaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public override Panel searchPanel
        {
            get
            {
                return this.searchpanel;
            }
        }

        public override Button SearchButton
        {
            get
            {
                return this.SearchBtn;
            }
        }

        public override string SearchTerm
        {
            get
            {
                return this.SearchTextBox.Text;
            }
        }
        //Session["S"] is the session variable
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            Session["SELECTED_MASTERPAGE"] = DropDownList1.SelectedValue;
            Response.Redirect(Request.Url.AbsoluteUri);
            //Response.Redirect("~/Site4.Master");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Session["SELECTED_MASTERPAGE"] != null) 
            {
                DropDownList1.SelectedValue = Session["SELECTED_MASTERPAGE"].ToString();
            }
        }
    }
}
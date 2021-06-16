using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetControls
{
    public partial class Site2 : System.Web.UI.MasterPage

    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //Master Property - Content pages uses this property to set its controls  on the master page
        public TextBox TextBoxOnMasterPage
        {
            get
            {
                return this.txtMasterPage;
            }
        }

        public Panel SearchPanel
        {
            get
            {
                return this.panelsearch;
            }
        }

        public Button SearchButton
        {
            get
            {
                return this.btnSearch;
            }
        }

        public string SearchTerm
        {
            get
            {
                return this.txtSearch.Text;
            }
        }       
    }
}
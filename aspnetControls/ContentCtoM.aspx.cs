using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetControls
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Type casting has to be done to retrieve the master page associated with the content page using Master property
            //Typecasting the master page
            //((Site2)Master).TextBoxOnMasterPage.Text = Textbox1.Text;


            //instead of typecasting, we can use Master type directive

            Master.TextBoxOnMasterPage.Text = Textbox1.Text;
            //To retrieve a master page associated with a content page, we can use
            //either Master property or page.Master Property


            //Whenever a property returns the Object, it should be typecast to actual master page
            //((Site2)Page.Master).TextBoxOnMasterPage.Text = Textbox1.Text;
        }
    }
}
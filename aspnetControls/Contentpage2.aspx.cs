using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetControls
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData(null);

            }
        }

        public void GetData(string SPName)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetPerson", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter searchParameter = new SqlParameter("@SearchTerm", searchTerm ?? string.Empty)
                //cmd.Parameters.Add(searchParameter);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }

}
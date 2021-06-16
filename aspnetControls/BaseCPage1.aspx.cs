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
    public partial class WebForm8 : BasePage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Master.SearchButton.Click += new EventHandler(SearchButton_Click);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData(null);

            }
        }
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            GetData(Master.SearchTerm);
        }
        public void GetData(string SPName)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSearchRole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter searchParameter = new SqlParameter("@SearchTerm", SPName ?? string.Empty);
                cmd.Parameters.Add(searchParameter);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }

        }

    }
    }
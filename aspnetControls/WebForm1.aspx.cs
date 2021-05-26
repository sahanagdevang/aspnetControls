using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace aspnetControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CheckBox2.Focus();
                CheckBox1.Checked = true;
                HyperLink1.Focus();
                ListItem genderList = new ListItem("Gender","4");
                DropDownList1.Items.Add(genderList);


                //fetching from database
                DropDownList2.DataSource = GetData("spGetRoles", null);
                DropDownList2.DataBind();


                CheckBoxList1.SelectedIndex = 0;
            }
            
        }


        //method to fetch listitems from Database to dropdownlist2
        public DataSet GetData(string SPName, SqlParameter SPParameter)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(SPName, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (SPParameter != null)
            {
                da.SelectCommand.Parameters.Add(SPParameter);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("yellow has been selected ");
        }
        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                Response.Write("Red has been selected ");
            }

        }
        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Blue has been selected ");
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            StringBuilder sbUserChoice = new StringBuilder();
            if (CheckBox1.Checked)
            {
                sbUserChoice.Append(CheckBox1.Text);
            }
            if (CheckBox2.Checked)
            {
                sbUserChoice.Append(" " + CheckBox2.Text);
            }
            if (CheckBox3.Checked)
            {
                sbUserChoice.Append(" " + CheckBox3.Text);
            }
            Response.Write("Checkbox Selection is: " + sbUserChoice.ToString());
        }


        //ImageButton is as same as Button (can drag and drop at design level)
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("TextBox has: " + TextBox1.Text + "<br/>");      
        }

        //This button is for Radio buttons
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if(RadioButton1.Checked)
            {
                Response.Write(RadioButton1.Text + "<br/>");
            }
            if (RadioButton2.Checked)
            {
                Response.Write(RadioButton2.Text + "<br/>");
            }

        }


        //After clicking this it gives text, value, index of dropdownlist1
        //and
        // Gives all the checked items's text,value, index of checkboxlist1
        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "-1")
            {
                Response.Write("Please select the gender");
            }
            else
            {
                Response.Write("SelectedItem.Text: " + DropDownList1.SelectedItem.Text + "<br/>");
                Response.Write("SelectedItem.Value: " + DropDownList1.SelectedItem.Value + "<br/>");
                Response.Write("SelectedItem.Index: " + DropDownList1.SelectedIndex + "<br/>");
                Response.Write("<br/>");

            }


            foreach (ListItem li in CheckBoxList1.Items)
            {
                if(CheckBoxList1.SelectedItem != null)
                // If Selected Item is null, It gives nullVAlueException. So it is better to handle that this way
                //if (li.Selected)
                {
                    Response.Write("Text: " + li.Text + "<br/>");
                    Response.Write("Value: " + li.Value + "<br/>");
                    Response.Write("Index: " + CheckBoxList1.Items.IndexOf(li) + "<br/>");
                    Response.Write("If we dont select anything.. It gives -1" +li.Text + "<br/>");
                }
            }
        }


        //If AutoPostBack is set to True. This code executes as soon as change is made in textBox 
        //(AutoPostBox Property works similarly to all controls)
        protected void TextBox1_TextChanged(object sender, EventArgs e )
        { 
            Response.Write("AutoPostBack");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("You selected: " + RadioButton1.Text + "<br/>");
        }


        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("You selected: " + RadioButton2.Text + "<br/>");
        }



        //Selects All checkboxes and adds them in listBox 
        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
            ListBox2.Items.Clear();
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    ListBox2.Items.Add(li.Text);
                }
            }

            if (CheckBoxList1.SelectedIndex == -1)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Black;

            }
            Label1.Text = ListBox2.Items.Count.ToString() + " item(s) selected";
        }


        //Deselects All checkboxes and adds nothing in listBox 

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = false;      
            }
            ListBox2.Items.Clear();
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    ListBox2.Items.Add(li.Text);
                }
            }

            if (CheckBoxList1.SelectedIndex == -1)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            Label1.Text = ListBox2.Items.Count.ToString() + " item(s) selected";
        }


        //If changes are made in checkboxlist  by checking/unchecking, items gets stored in listBox2
        public void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox2.Items.Clear();
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    ListBox2.Items.Add(li.Text);
                }
            }

            if (CheckBoxList1.SelectedIndex == -1)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            Label1.Text = ListBox2.Items.Count.ToString() + " item(s) selected";
        }
        protected void listBtn2_Click(object sender, EventArgs e)
        {
            //if(ListBox1.SelectedIndex != -1)
            foreach (ListItem li in ListBox1.Items)
            {
                if (ListBox1.SelectedItem != null)
                {
                    Response.Write("You selected Text: " + ListBox1.SelectedItem.Text + "<br/>");
                    Response.Write("You selected Value: " + ListBox1.SelectedItem.Value + "<br/>");
                    Response.Write("You selected Index: " + ListBox1.SelectedIndex.ToString() + "<br/>");
                    Response.Write("<br/>");


                }
            }

            //foreach(ListItem li in ListBox1.Items)
            //{
            //    Response.Write("You selected Text: " + li.Text + "<br/>");
            //    Response.Write("You selected Value: " + li.Value + "<br/>");
            //    Response.Write("You selected Index: " + ListBox1.SelectedIndex.ToString() + "<br/>");
            //}
            
        }


        //gives details of items in bulleted list. this bulledlist can be ordered and also unordered.
        //Bulleted items can be used as text/hyperling/bullet using displayMode property
        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            ListItem li = BulletedList1.Items[e.Index];

            Response.Write("Text= " + li.Text + "<br/>");
            Response.Write("Value= " + li.Value + "<br/>");
            Response.Write("Indext= " + e.Index.ToString() + "<br/>");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem != null)
            {
                Response.Write("<br/>");
                Response.Write("You selected Text: " + RadioButtonList1.SelectedItem.Text + "<br/>");
                Response.Write("You selected Value: " + RadioButtonList1.SelectedItem.Value + "<br/>");
                Response.Write("You selected Index: " + RadioButtonList1.SelectedIndex.ToString() + "<br/>");

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
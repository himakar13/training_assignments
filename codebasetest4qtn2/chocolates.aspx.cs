using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace codebasetest4qtn2
{
    public partial class chocolates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "a C", "b C", "c C", "d C", "e C" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }



        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jfif";



        }




        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "a C")
            {
                TextBox1.Text = "Rs 120";
            }
            else if (DropDownList1.Text == "b C")
            {
                TextBox1.Text = "Rs 140";
            }
            else if (DropDownList1.Text == "c C")
            {
                TextBox1.Text = "Rs 150";
            }
            else if (DropDownList1.Text == "d C")
            {
                TextBox1.Text = "Rs 160";
            }
            else if (DropDownList1.Text == "e C")
            {
                TextBox1.Text = "Rs 170";
            }



            else
            {
                TextBox1.Text = "Rs 1300";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);

            if (DropDownList1.Text.Equals("+"))
            {
                result = num1 + num2;
                TextBox3.Text = result.ToString();
            }
            else if (DropDownList1.Text.Equals("-"))
            {
                result = num1 - num2;
                TextBox3.Text = result.ToString();
            }
            else if (DropDownList1.Text.Equals("*"))
            {
                result = num1 * num2;
                TextBox3.Text = result.ToString();
            }
            else if (DropDownList1.Text.Equals("/"))
            {
                result = num1 / num2;
                TextBox3.Text = result.ToString();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            /*double input = Convert.ToDouble(TextBox3.Text);
            int whole = Convert.ToInt32(Math.Floor(input));
            double dec = input - whole;
            string binaryResult = "";
            string binaryResult2 = "";
            while (whole > 0)
            {
                binaryResult = (whole % 2).ToString() + binaryResult;
                whole = whole / 2;
            }
            while (dec != 0)
            {
                dec = dec * 2;
                if (dec > 1)
                {
                    binaryResult2 = binaryResult2 + "1";
                    dec = dec - 1;
                }
            }
            string finalResult = binaryResult + "." + binaryResult2;
            TextBox6.Text = finalResult;*/
        }
        /* string base10Input = TextBox3.Text;
         string binaryResult = "";
         string binaryResult2 = "";
         string[] splitInput = base10Input.Split('.');
         int whole = Convert.ToInt32(splitInput[0]);
         double dec = Convert.ToDouble(splitInput[1]);
         if (dec == 0)
         {
             binaryResult = Convert.ToString(whole, 2);
             TextBox6.Text = binaryResult;
         }
         else if (dec != 0)
         {
             while (whole > 0)
             {
                 binaryResult = whole % 2 + binaryResult;
                 whole = whole / 2;
             }
             while (dec != 0)
             {
                 dec = dec * 2;
                 if (dec > 1)
                 {
                     binaryResult2 = binaryResult2 + 1;
                     dec = dec - 1;
                 }
             }
             TextBox6.Text = binaryResult + "." + binaryResult2;
         }*/

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            double input = Convert.ToDouble(TextBox3.Text);
            int whole = Convert.ToInt32(Math.Floor(input));
            double dec = input - whole;
            string binaryResult = "";
            string binaryResult2 = "";
            while (whole > 0)
            {
                binaryResult = (whole % 2).ToString() + binaryResult;
                whole = whole / 2;
            }
            while (dec != 0)
            {
                dec = dec * 2;
                if (dec > 1)
                {
                    binaryResult2 = binaryResult2 + "1";
                    dec = dec - 1;
                }
            }
            string finalResult = binaryResult + "." + binaryResult2;
            TextBox6.Text = finalResult;
        }
    }
}
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
            
            double base10Input = Convert.ToDouble(TextBox3.Text);
            int whole = Convert.ToInt32(Math.Floor(base10Input));
            double dec = base10Input - whole;
            string binaryResult = Convert.ToString(whole, 2);
            string binaryResult2 = "";
            double firstDec = dec;

            while (dec != 0)
            {                
                dec = dec * 2;
                if (firstDec.Equals(dec)) {
                    break;
                }
                else if (dec > 1)
                {
                    binaryResult2 = binaryResult2 + "1";
                    dec = dec - 1;
                }
            }

            if (binaryResult2.Equals(""))
            {
                string finalResult = binaryResult;
                TextBox6.Text = finalResult;
            }
            else
            {
                string finalResult = binaryResult + "." + binaryResult2;
                TextBox6.Text = finalResult;
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
            
        }
         
        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string source = TextBox6.Text;
            int count0 = 0;
            int count1 = 0;
            foreach (char zero in source) {
                if (zero == '0') count0++;
            }
            TextBox4.Text = count0.ToString();
            foreach (char one in source)
            {
                if (one == '1') count1++;
            }
            TextBox5.Text = count1.ToString();
        }
    }
}
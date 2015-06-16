using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {

            string age = ageTextBox.Text;

            string currency = moneyTextBox.Text;

            string result = "At age " + age + " you should have more than " + currency + " dollars patna"; 
            

            resultLabel.Text = result;


        }
    }
}
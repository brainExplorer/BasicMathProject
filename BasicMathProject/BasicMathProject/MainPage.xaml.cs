using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BasicMathProject.MathOperations;
namespace BasicMathProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            selectRandomProc();
            createRandomNumbers(lbMathSign.Text);
        }

        private void ButtonConfirm_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(EntryConfirm.Text))
            {
                Number number = new Number();
                List<int> ints = new List<int>();
                ints.Add(Convert.ToInt32(lbfirstValue.Text));
                ints.Add(Convert.ToInt32(lbSecondValue.Text));
                string sign = lbMathSign.Text;
                int? result = number.getNumbers(ints.ToArray(), lbMathSign.Text);
                if (result == Convert.ToInt32(EntryConfirm.Text))
                {
                    cleanContents();
                    selectRandomProc();
                    createRandomNumbers(lbMathSign.Text);
                }
                else
                {
                    EntryConfirm.Text = String.Empty;
                }
            }
            else
            {
                EntryConfirm.Text = String.Empty;
                DisplayAlert("Error","You entered invalid value. Please enter a correct answer","Cancel");
            }

        }
        private void createRandomNumbers(string sign)
        {
            Random random = new Random();
            int max = sign == "/" || sign == "*" ? 9 : 50;
            if (sign == "/" || sign == "-")
            {
                lbfirstValue.Text = (random.Next(1, max)).ToString();
                lbSecondValue.Text = (random.Next(1, Convert.ToInt32(lbfirstValue.Text))).ToString();
            }
            else
            {
                lbfirstValue.Text = (random.Next(1, max)).ToString();
                lbSecondValue.Text = (random.Next(1, max)).ToString();
            }
            
        }
        private void selectRandomProc()
        {
            char[] Signs = new char[4] {'d','m','s','a'};
            Random random = new Random();
            int i = random.Next(0, 3);
            lbMathSign.Text = Signs[i]=='d' ? "/" : Signs[i] == 'm' ? "*" : Signs[i] == 's' ? "-" : "a";
        }
        private void cleanContents()
        {
            lbfirstValue.Text = String.Empty;
            lbSecondValue.Text = String.Empty;
            lbMathSign.Text = String.Empty;
            EntryConfirm.Text = String.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();            
        }

        List<String> history = new List<string>();

        private decimal num1 = 0;
        private decimal num2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;
        bool uptoButtonClicked = false;
        bool equalClick = false;


        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
           
            if (equalClick == true)
            {
                TopDisplay.Text += "1";
                txtDisplay.Text = "";
                txtDisplay.Text += "1";
                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "1";
                TopDisplay.Text += "1";

            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
         
            if (equalClick == true)
            {
                TopDisplay.Text += "2";
                txtDisplay.Text = "";
                txtDisplay.Text += "2";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "2";
                TopDisplay.Text += "2";

            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            
            if (equalClick == true)
            {
                TopDisplay.Text += "3";
                txtDisplay.Text = "";
                txtDisplay.Text += "3";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "3";
                TopDisplay.Text += "3";

            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
        
            if (equalClick == true)
            {
                TopDisplay.Text += "4";
                txtDisplay.Text = "";
                txtDisplay.Text += "4";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "4";
                TopDisplay.Text += "4";

            }

        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
         
            if (equalClick == true)
            {
                TopDisplay.Text += "5";
                txtDisplay.Text = "";
                txtDisplay.Text += "5";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "5";
                TopDisplay.Text += "5";
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
      
            if (equalClick == true)
            {
                TopDisplay.Text += "6";
                txtDisplay.Text = "";
                txtDisplay.Text += "6";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "6";
                TopDisplay.Text += "6";
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
         
            if (equalClick == true)
            {
                TopDisplay.Text += "7";
                txtDisplay.Text = "";
                txtDisplay.Text += "7";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "7";
                TopDisplay.Text += "7";

            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
         
            if (equalClick == true)
            {
                TopDisplay.Text += "8";
                txtDisplay.Text = "";
                txtDisplay.Text += "8";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "8";
                TopDisplay.Text += "8";

            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
     
            if (equalClick == true)
            {
                TopDisplay.Text += "9";
                txtDisplay.Text = "";
                txtDisplay.Text += "9";

                equalClick = false;
            }
            else
            {
                txtDisplay.Text += "9";
                TopDisplay.Text += "9";
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
        
            if (equalClick == true)
            {
                TopDisplay.Text += "0";
                txtDisplay.Text = "";
                txtDisplay.Text += "0";

                equalClick = false;
            }

            else
            {
                txtDisplay.Text += "0";
                TopDisplay.Text += "0";
            }
            if (decimal.Parse(txtDisplay.Text) == 0 & !txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text = "0";
            }
        
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtDisplay.Text = "";
                TopDisplay.Text = TopDisplay.Text.Remove(txtDisplay.Text.Length - txtDisplay.Text.Length);

            }
            catch (Exception)
            {
                txtDisplay.Text = "";
                TopDisplay.Text = "";
            }
            

        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
     
            txtDisplay.Text = "";
            TopDisplay.Text = "";
           



        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (equalClick == true)
            {
                txtHistory.Text += "";
                txtDisplay.Text = "0";
                TopDisplay.Text += "";

            }
            else
            {
                try
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                    TopDisplay.Text = TopDisplay.Text.Remove(TopDisplay.Text.Length - 1, 1);

                }
                catch (Exception)
                {
                    txtDisplay.Text = "";
                    TopDisplay.Text = "";


                }
            }


        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                num1 += decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                TopDisplay.Text += "/";


                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = true;
            }
            catch (Exception)
            {
                txtDisplay.Text = "";
                TopDisplay.Text = "";
            }
    
         
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 += decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                TopDisplay.Text += "x";


                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = true;
                divideButtonClicked = false;
            }
            catch (Exception)
            {

                txtDisplay.Text = "";
                TopDisplay.Text = "";
            }
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                num1 += decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                TopDisplay.Text += "-";


                plusButtonClicked = false;
                minusButtonClicked = true;
                multiplyButtonClicked = false;
                divideButtonClicked = false;

            }
            catch (Exception)
            {
                txtDisplay.Text = "";
                TopDisplay.Text = "";
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 += decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                TopDisplay.Text += "+";


                plusButtonClicked = true;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
              
            }
            catch (Exception)
            {
                txtDisplay.Text = "";
                TopDisplay.Text = "";
            }
        }

        private void BtnEqu_Click(object sender, RoutedEventArgs e)
        {
           

            if (plusButtonClicked == true)
              {
                  num2 = num1 + decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = num2.ToString();
                history.Add(TopDisplay.Text + " = " + num2.ToString());
                TopDisplay.Text = "";
                num1 = 0;
              }
             else if (minusButtonClicked == true)
             {
                num2 = num1 - decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = num2.ToString();
                history.Add(TopDisplay.Text + " = " + num2.ToString());
                TopDisplay.Text = "";
                num1 = 0;
            }
             else if (multiplyButtonClicked == true)
             {
                num2 = num1 * decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = num2.ToString();
                history.Add(TopDisplay.Text + " = " + num2.ToString());
                TopDisplay.Text = "";
                num1 = 0;
            }
             else if (divideButtonClicked == true)
             {
                num2 = num1 / decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = num2.ToString();
                history.Add(TopDisplay.Text + " = " + num2.ToString());
                TopDisplay.Text = "";
                num1 = 0;

            }
            else if (uptoButtonClicked == true)
            {
                double y;
                double x; 

                x = double.Parse(txtDisplay.Text);
                
                y = Math.Pow(Convert.ToDouble(num1), x);
                txtDisplay.Text = y.ToString();
                history.Add(TopDisplay.Text + " = " + y.ToString());
                TopDisplay.Text = "";
                num1 = 0;

            }

            txtHistory.Text = "";

            foreach (string i in history)
            {
                txtHistory.Text += i;
                txtHistory.Text += "\n";
            }
            equalClick = true;

        }

        private void BtnCom_Click(object sender, RoutedEventArgs e)
        {
            
           
            if (txtDisplay.Text == "")
            {

                txtDisplay.Text += "0,";
                TopDisplay.Text += "0,";
            }
            if (txtDisplay.Text.Contains(","))
            {
            }

            else
            {
                txtDisplay.Text += ",";
                TopDisplay.Text += ",";

            }
            
        }

        private void BtnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (decimal.Parse(txtDisplay.Text) < 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(1);
                    TopDisplay.Text = TopDisplay.Text.Substring(1);
                }
                else if (decimal.Parse(txtDisplay.Text) >= 0)
                {
                    if (equalClick == true)
                    {
                        txtDisplay.Text = "-";
                        TopDisplay.Text = "-";
                        equalClick = false;
                    }
                    else
                    {
                        txtDisplay.Text = "-" + txtDisplay.Text;
                        TopDisplay.Text = "-" + TopDisplay.Text;

                    }
                }
   
            }
            catch (Exception)
            {
                TopDisplay.Text = "";
                txtDisplay.Text = "";
            }
            
        }
        private void btnUppTo_click(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 += decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                TopDisplay.Text += "^";


                plusButtonClicked = false;
                minusButtonClicked = false;
                multiplyButtonClicked = false;
                divideButtonClicked = false;
                uptoButtonClicked = true;
            }
            catch (Exception)
            {

                txtDisplay.Text = "";
                TopDisplay.Text = "";
            }

        }


        private void txtDisplay_TextChagned(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnClearHistory_Clck(object sender, RoutedEventArgs e)
        {
            txtHistory.Text = "";
        }

        private void BtnSqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(txtDisplay.Text);
                double y = double.Parse(txtDisplay.Text);
                x = Math.Sqrt(x);

                txtDisplay.Text = x.ToString();
                TopDisplay.Text = x.ToString();
                history.Add("√" + y.ToString() + "=" + x.ToString());
                txtHistory.Text = "";

                foreach (string i in history)
                {
                    txtHistory.Text += i;
                    txtHistory.Text += "\n";
                }
                equalClick = true;
            }
            catch (Exception)
            {

            }
        
        }

        private void BtnSquare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(txtDisplay.Text);
                double y = double.Parse(txtDisplay.Text);
                x = x * x;

                txtDisplay.Text = x.ToString();
                TopDisplay.Text = x.ToString();
                history.Add( y.ToString()+ "²" + "=" + x.ToString());
                txtHistory.Text = "";

                foreach (string i in history)
                {
                    txtHistory.Text += i;
                    txtHistory.Text += "\n";
                }
    
            }
            catch (Exception)
            {

            }
           
        }

        private void BtnPrct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(txtDisplay.Text);
                double y = double.Parse(txtDisplay.Text);
                x = x / 100;

                txtDisplay.Text = x.ToString();
                TopDisplay.Text = x.ToString();
                history.Add(y.ToString() + "%" + "=" + x.ToString());
                txtHistory.Text = "";

                foreach (string i in history)
                {
                    txtHistory.Text += i;
                    txtHistory.Text += "\n";
                }

            }
            catch (Exception)
            {

            }
            }

        private void yuanToSek_click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(txtDisplay.Text);
                double y = double.Parse(txtDisplay.Text);
                x = y * 1.55;

                txtDisplay.Text = x.ToString();
                TopDisplay.Text = x.ToString();
                history.Add("Yuan to Sek\n" + y.ToString() + "=" + x.ToString());
                txtHistory.Text = "";

                foreach (string i in history)
                {
                    txtHistory.Text += i;
                    txtHistory.Text += "\n";
                }
                equalClick = true;
            }
            catch (Exception)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace McDonalds
{
    public partial class Form1 : Form
    {
        //global variables
        double burgers = 8.19;
        double fries = 3.50;
        double drinks = 2.00;
        double subtotal;
        double taxAmount;
        double total;
        double change;
        double tendered;
        double order = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            //Plays Sound for cash register
            SoundPlayer ching = new SoundPlayer(Properties.Resources.Ching_WAV);
            ching.Play();

            try
            {
                burgers = Convert.ToDouble(burgerInput.Text);
                fries = Convert.ToDouble(fryInput.Text);
                drinks = Convert.ToDouble(drinkInput.Text);

                //Calculations for my food
                subtotal = (burgers * 8.19) + (fries * 3.50) + (drinks * 2.00);
                taxAmount = subtotal * 0.13;
                total = subtotal + taxAmount;

                subtotalLabel.Text = "Subtotal";

                //Displays the calculations
                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxAmountOutput.Text = $"{taxAmount.ToString("C")}";
                totalAmountOutput.Text = $"{total.ToString("C")}";

                //Shows the hidden labels and buttons
                subtotalLabel.Visible = true;
                taxLabel.Visible = true;
                totalLabel.Visible = true;
                tenderedLabel.Visible = true;
                tenderedInput.Visible = true;
                calculateChangeButton.Visible = true;
            }
            catch
            {
                subtotalLabel.Text = "Error";
                subtotalLabel.Visible = true;
            }
        }
        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
         SoundPlayer ching = new SoundPlayer(Properties.Resources.Ching_WAV);
            ching.Play();

            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);

                if (tendered >= total)
                {
                    //Calculates change
                    change = tendered - total;
                    changeOutput.Text = $"{change.ToString("C")}";
                    printReceiptButton.Visible = true;
                    printReceiptButton.Enabled = true;
                    changeLabel.Visible = true;
                }
                else
                {
                    changeOutput.Text = "Error";
                }
            }
            catch
            {
                changeOutput.Text = "Error";
            }
        }
        private void printReceiptButton_Click(object sender, EventArgs e)
        {

            //Sound for my printer
            SoundPlayer print = new SoundPlayer(Properties.Resources.Pinter_WAV);
            print.Play();

            //Hidden Message code
            hiddenmessageLabel.Text = "Bet you cant see this";

            //Displays the receipt
            receiptOutput.Text += $"\nOrder Number #{order++}";
            Thread.Sleep(500);
            Refresh();
            receiptOutput.Text += $"\nSeptember 25th, 2024";
            Thread.Sleep(500);
            Refresh();
            receiptOutput.Text += $"\n\nBurgers     x{burgers}  @ $8.19";
            Thread.Sleep(500);
            Refresh();
            receiptOutput.Text += $"\nFries       x{fries}  @ $3.50";
            Thread.Sleep(500);
            Refresh();
            print.Play();
            receiptOutput.Text += $"\nDrinks      x{drinks}  @ $2.00";
            Thread.Sleep(500);
            Refresh();
            receiptOutput.Text += $"\n\nSubtotal:         {subtotal.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptOutput.Text += $"\nTax:              {taxAmount.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptOutput.Text += $"\nTotal:            {total.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            print.Play();
            receiptOutput.Text += $"\nTendered:         {tendered.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptOutput.Text += $"\nChange:           {change.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            print.Stop();
            receiptOutput.Text += $"\n\nThanks for Choosing Mcdonalds ";

            newOrderButton.Visible = true;
            printReceiptButton.Enabled = false;

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //Resets all the inputs, and outputs
            burgerInput.Text = $"";
            fryInput.Text = $"";
            drinkInput.Text = $"";
            receiptOutput.Text = $"";
            subtotalOutput.Text = $"";
            taxAmountOutput.Text = $"";
            totalAmountOutput.Text = $"";
            tenderedInput.Text = $"";
            changeOutput.Text = $"";
            hiddenmessageLabel.Text = $"";

            //Hides buttons, and labels
            calculateChangeButton.Enabled = true;
            printReceiptButton.Enabled = true;
            newOrderButton.Enabled = true;
            calculateChangeButton.Visible = false;
            printReceiptButton.Visible = false;
            newOrderButton.Visible = false;
            changeLabel.Visible = false;
            subtotalLabel.Visible = false;
            taxLabel.Visible = false;
            totalLabel.Visible = false;
            tenderedLabel.Visible = false;
            tenderedInput.Visible = false;

        }
    }
}

       
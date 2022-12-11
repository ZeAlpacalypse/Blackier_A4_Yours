using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackierLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Chad Blackier
         * Due Date:Nov 17th, 2022
         * This program calculates the price of a trip based on the number of people and the location.
         * The program restricts the user on what data it will accept and also has a discount for using 
         * cash over a credit card.*/

        /* Name: ResetTrip
         * Sent: none
         * Returned: none
        This function is to reset the form. It sets the cursor to the text box and check both the credit and Cuba rad buttons.*/
        private void ResetTrip()
        {
            txtPeople.Text = "";
            txtPrice.Text = "";
            grpTrip.Hide();
            txtPeople.Focus();
            radCuba.Checked = true;
            radCredit.Checked = true;

        }
         /* Name: ResetTrip
         * Sent: none
         * Returned: none
         * This function sets the flight included check box to not be selected when Florida is the destination.*/
        private void SetFlight()
        {
            if (radFlorida.Checked)
            {
                chkFlightInc.Checked = false;
            }
            else
            {
                chkFlightInc.Checked = true;
            }

        }
         /* Name: ResetTrip
         * Sent: string and string
         * Returned: none
         * This function is used to create and display MsgBoxes. It requires 2 strings to be sent in the order of the message then the title.*/
        private void DisplayMsg(string msg, string title)
        {
            MessageBox.Show(msg, title);
        }
        //Calls the ResetAll function to reset the form on load.
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTrip();
        }
        //Calls the ResetAll function to reset the form when the Reset button is clicked.
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTrip();
        }
        //Calls the SetFlight function to check the chkbox for the flight included.
        private void radCuba_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }
        //Calls the SetFlight function to un-check the chkbox for the flight included.
        private void radFlorida_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }
        //Calls the SetFlight function to check the chkbox for the flight included.
        private void radMexico_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }
        //Books a trip and calculates a price based on the location and number of people. 
        private void btnBook_Click(object sender, EventArgs e)
        {
            // Variables used to populate the display lbl
            string location, cashDiscount, flightInc, tripInfo;
            // Constants used to restrict the number of people
            const int MINPEOPLE = 1, MAXPEOPLE = 10;
            // Constants used for prices
            const double MEX = 2300.79, OTHER = 2150.5, DISCOUNT = 0.9;
            // Variable set to the amount entered by the user
            int people;
            // Variable set to the total price
            double price;

            // Checks the value entered by the user. Requires int
            if (int.TryParse(txtPeople.Text, out int value))
            {
                /* Set the variable people to the value entered by the user.
                 * Populates the first var used to create display lbl*/
                people = value;
                tripInfo = "Booked by Chad Blackier \n \n People: "
                                                  + people.ToString("D2")
                                                  + "\n Location: ";

                // Checks if the value is between 1 and 10 using const
                if (people >= MINPEOPLE && people <= MAXPEOPLE)
                {
                    //Calcs and sets price for Florida and Cuba
                    if (radCuba.Checked || radFlorida.Checked)
                    {
                        price = OTHER * people;
                    }
                    //Calcs and sets price for Mexico
                    else
                    {
                        price = MEX * people;
                    }
                    // Creates next part of display lbl if chkbox is check. Only checked for Cuba and Mexico.
                    if (chkFlightInc.Checked)
                    {
                        flightInc = "\n Flight Included";
                    }
                    // Sets var to null is chk is not checked. Is checked for Florida
                    else
                    {
                        flightInc = null;
                    }
                    // Applies discount to price if radbtn Cash is selected. Populates next part of the display lbl
                    if (radCash.Checked)
                    {
                        price = price * DISCOUNT;
                        cashDiscount = "\n Cash Discount Applied";

                    }
                    // Sets the var for cash discount to null
                    else
                    {
                        cashDiscount = null;
                    }

                    // Displays The price in the txtbox in the grpbox Book. 
                    txtPrice.Text = price.ToString("c2");

                    // Checks if the val entered by user is 1 or 3. Displays a msg with the DisplayMsg funstion and tells the user about the offer.
                    switch (people)
                    {
                        case 1:
                        case 3:
                            DisplayMsg("Special when booking single or triple. \n BOGO Special - Call 555-1212 to recieve another person free!", "Limited Time Offer");
                            break;
                        default:

                            break;
                    }
                    // Checks if the radbtn Cuba is checked and sets the location to Cuba. Creates the rest of the display lbl using data enetered by the user.
                    if (radCuba.Checked)
                    {

                        location = radCuba.Text;
                        lblTripInfo.Text = tripInfo
                                           + location.ToUpper()
                                           + flightInc
                                           + cashDiscount
                                           + "\n Price: " + price.ToString("c2");


                    }
                    // Checks if the radbtn Florida is checked and sets the location to Florida. Creates the rest of the display lbl using data enetered by the user.
                    else if (radFlorida.Checked)
                    {
                        location = radFlorida.Text;
                        lblTripInfo.Text = tripInfo
                                          + location.ToUpper()
                                          + flightInc
                                          + cashDiscount
                                          + "\n Price: " + price.ToString("c2"); ;
                    }
                    // Checks if the radbtn Mexico is checked and sets the location to Mexico. Creates the rest of the display lbl using data enetered by the user.
                    else
                    {
                        location = radMexico.Text;
                        lblTripInfo.Text = tripInfo
                                          + location.ToUpper()
                                          + flightInc
                                          + cashDiscount
                                          + "\n Price: " + price.ToString("c2");
                    }
                    // Shows the grpTrip with the display label formatted to show the user the trip information before confirmation. Disables the grpBook
                    grpTrip.Show();
                    grpBook.Enabled = false;
                }
                // Displays a msgbox telling the user to enter a val between 1-10. Highlights the number for the user.
                else
                {
                    DisplayMsg("People must be between 1-10", "Input Error");
                    txtPeople.SelectAll();
                }



            }
            // Displays a msgbox telling the user to enter an int
            else
            {
                DisplayMsg("People must be a whole number", "Input Error");
            }
        }
        // Displays a mesgbox confirming the trip booking and resetiing the form. Enables the grpBook 
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DisplayMsg("Trip Booked and paid. \n Price: " + txtPrice.Text, "Confirmation Email Sent");
            ResetTrip();
            txtPeople.Focus();
            grpBook.Enabled = true;
        }
    }
}
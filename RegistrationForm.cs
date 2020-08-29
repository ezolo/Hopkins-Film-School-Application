//Programmer: Eva Zolotarev
//Project: Zolotarev_4 (Individual Assignment #4)
//Due Date: 5/05/2020
//Description: The program for Hopkin's Film School lets users enter their registration information, including the type of classes they want to take, which classes they want to take, and their payment option. (Form Class: RegistrationForm)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Zolotarev_4
{
    public partial class RegistrationForm : Form
    {
        //Constant
        private const int MAX_CLASSES = 4;
        //Variables
        private decimal countItems;
        private decimal LIVE_ACTION_COST = 79.95m;
        private decimal ANIMATION_COST = 99.95m;
        private string requestedEmail;
       

        public RegistrationForm()
        {
            
        InitializeComponent();

            //Inputs constant into statement about max classes
            availableClassesLabel.Text = "A maximum of " + MAX_CLASSES + " classes is allowed for registration:";

            //Status of Registrant--Filled with data from array
            ArrayList statusRegistrant = new ArrayList();
            statusComboBox.Text = "";
            statusRegistrant.Add("Actor");
            statusRegistrant.Add("Producer");
            statusRegistrant.Add("Director");
            statusRegistrant.Add("Animator");
            statusRegistrant.Add("Cinematographer");
            statusRegistrant.Add("Drama Teacher");
            statusRegistrant.Add("Light Technician");
            statusRegistrant.Add("Sound Technician");
            statusComboBox.DataSource = statusRegistrant;
            statusComboBox.SelectedIndex = -1;

            //When we enter form, liveAction button is checked & the correct values are displayed & information cleared
            numbOfClasses.Text = "";
            registrationTotal.Text = "";
            //Method placed inside RegistrationForm()
            PopulateBoxes();
        }

        //First method. Grabs text files from LiveActionClasses and inputs whenever liveActionButton.checked
        private void PopulateBoxes()
        {
            try
            {
                StreamReader inputFiles;
                if (liveActionButton.Checked)
                {
                    inputFiles = File.OpenText("LiveActionClasses.txt");

                    while (inputFiles.EndOfStream == false)
                    {
                        classesListBox.Items.Add(inputFiles.ReadLine());
                    }
                    inputFiles.Close();
                    //Calculates Price for the Class Type Selected
                    pricesForClassTypes.Text = LIVE_ACTION_COST.ToString("c");

                    //Checkbox Controls and results
                    if (receiptRequestedLabel.Checked)
                    {
                        requestedEmail = "Yes";
                    }
                    else
                    {
                        requestedEmail = "No";
                    }
                }
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        //Second method. Counts amount of classes selected, total registration price, and type of class price
        private void UpdateTotals()
        {
            try
            {
                //Counts the amount of classes selected
                int selections = classesListBox.SelectedItems.Count;
                numbOfClasses.Text = selections.ToString();
                if (liveActionButton.Checked)
                {
                    //Counts the total registration price
                    countItems = selections * LIVE_ACTION_COST;
                    registrationTotal.Text = countItems.ToString("c");
                    //Price per Live Action class
                    pricesForClassTypes.Text = LIVE_ACTION_COST.ToString("c");
                }
                else
                {
                    //Counts the total registration price
                    countItems = selections * ANIMATION_COST;
                    registrationTotal.Text = countItems.ToString("c");
                    //Price per Animation Class
                    pricesForClassTypes.Text = ANIMATION_COST.ToString("c");
                }
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        //Third Method. Clears values and returns form back to original state. 
        private void ResetForm()
            {
            //Clears values
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dobTextBox.Text = "";
            statusComboBox.SelectedIndex = -1;
            liveActionButton.Checked = true;
            numbOfClasses.Text = "";
            registrationTotal.Text = "";
            cashButton.Checked = true;
            receiptRequestedLabel.Checked = false;
            classesListBox.SelectedIndex = -1;
            //Brings Focus back to firstNameTextBox
            firstNameTextBox.Focus();
        }

        //Calculation from UpdateTotal implemented
            private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
             {
            UpdateTotals();
             }

        //When save clicked, checks if all information is submitted, displays message, and updates the RegistrationData.txt
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectionsTwo = classesListBox.SelectedItems.Count;

                if (firstNameTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill in the 'first name' category before proceeding.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lastNameTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill in the 'last name' category before proceeding.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (emailTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill in the 'Email Address' category before proceeding.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dobTextBox.Text == "  /  /")
                {
                    MessageBox.Show("Please fill in the 'Date of Birth' category before proceeding.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (0 >= selectionsTwo || selectionsTwo >= 5)
                {
                    MessageBox.Show("Please select one to four classes before proceeding", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //This allows the program to list selected items in listbox
                    StringBuilder message = new StringBuilder();
                    foreach (object selectedItem in classesListBox.SelectedItems)
                    {
                        message.AppendLine(selectedItem.ToString());
                    }
                    if (cashButton.Checked)
                    {
                        MessageBox.Show(("Registration Summary" + System.Environment.NewLine + "Registration Date: " + dateSelection.Text +
                        System.Environment.NewLine + "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text +
                        System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Date of Birth: " +
                        dobTextBox.Text + System.Environment.NewLine + "Status: " + statusComboBox.Text + System.Environment.NewLine + "Classes Selected: " +
                        System.Environment.NewLine + message + System.Environment.NewLine + "Number of classes selected: " + numbOfClasses.Text + System.Environment.NewLine +
                        "Price per class: " + pricesForClassTypes.Text + System.Environment.NewLine + "Total Registration Price: " +
                        registrationTotal.Text + System.Environment.NewLine + "Payment Type: Cash" + System.Environment.NewLine + "Email Receipt: " + requestedEmail), "Hopkin's Film School Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Registration Summary Information to RegistrationData.txt
                    }
                    if (checkButton.Checked)
                    {
                        MessageBox.Show(("Registration Summary" + System.Environment.NewLine + "Registration Date: " + dateSelection.Text +
                        System.Environment.NewLine + "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text +
                        System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Date of Birth: " +
                        dobTextBox.Text + System.Environment.NewLine + "Status: " + statusComboBox.Text + System.Environment.NewLine + "Classes Selected: " +
                        System.Environment.NewLine + message + System.Environment.NewLine + "Number of classes selected: " + numbOfClasses.Text + System.Environment.NewLine +
                        "Price per class: " + pricesForClassTypes.Text + System.Environment.NewLine + "Total Registration Price: " +
                         registrationTotal.Text + System.Environment.NewLine + "Payment Type: Check" + System.Environment.NewLine + "Email Receipt: " + requestedEmail), "Hopkin's Film School Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Summary Information to RegistrationData.txt
                    //Write order information to output file
                    StreamWriter outputFile;
                    outputFile = File.AppendText("RegistrationData.txt");
                    //Title
                    outputFile.WriteLine("Registration Summary");
                    //Registration Date
                    outputFile.WriteLine(dateSelection.Text);
                    //Registrant Name
                    outputFile.WriteLine(firstNameTextBox.Text + " " + lastNameTextBox.Text);
                    //Email Address
                    outputFile.WriteLine(emailTextBox.Text);
                    //Date of Birth 
                    outputFile.WriteLine(dobTextBox.Text);
                    //Status
                    outputFile.WriteLine(statusComboBox.Text);
                    //Classes Selected
                    outputFile.WriteLine(message);
                    //Number of Classes
                    outputFile.WriteLine(numbOfClasses.Text);
                    //Price Per Class
                    outputFile.WriteLine(pricesForClassTypes.Text);
                    //Total Registration Price
                    outputFile.WriteLine(registrationTotal.Text);
                    //Payment Type
                    if (cashButton.Checked)
                    {
                        outputFile.WriteLine("Payment Type: Cash");
                    }
                    else
                    {
                        outputFile.WriteLine("Payment Type: Check");
                    }
                    //Email Receipt or not
                    if (receiptRequestedLabel.Checked)
                    {
                        outputFile.WriteLine("Yes");
                    }
                    else
                    {
                        outputFile.WriteLine("No");
                    }
                    //Blank Line
                    outputFile.WriteLine();
                    outputFile.Close();

                    //Clears form after message is displayed
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        //Clears form after user clicks "Clear" strip menu item
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //Asks user message whether they really want to leave the program or continue. If user decides to leave, program is closed. 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //Displays message to know for sure if user wants to leave program.
                var result = MessageBox.Show("Are you sure you wish to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //Display current date (reported by system clock) in sale date control
            dateSelection.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        //If animationButton clicked, values for listBox are updated
        private void animationButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                numbOfClasses.Text = "";
                registrationTotal.Text = "";
                classesListBox.Items.Clear();
                StreamReader inputFile;
                if (animationButton.Checked)
                {
                    inputFile = File.OpenText("AnimationClasses.txt");

                    while (inputFile.EndOfStream == false)
                    {
                        classesListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close();
                    //Calculates Price for the class type selected

                    pricesForClassTypes.Text = ANIMATION_COST.ToString("c");
                }
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        //If liveActionButton clicked, values for listBox are updated
        private void liveActionButton_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            numbOfClasses.Text = "";
            registrationTotal.Text = "";
            classesListBox.Items.Clear();
            StreamReader inputFileTwo;
                if (liveActionButton.Checked)
                {
                    inputFileTwo = File.OpenText("LiveActionClasses.txt");

                    while (inputFileTwo.EndOfStream == false)
                    {
                        classesListBox.Items.Add(inputFileTwo.ReadLine());
                    }
                    inputFileTwo.Close();
                    //Calculated the price for the class type selected
                    pricesForClassTypes.Text = LIVE_ACTION_COST.ToString("c");
                }
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        //Responses for the checkboxes users select
        private void receiptRequestedLabel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (receiptRequestedLabel.Checked)
                {
                    requestedEmail = "Yes";
                }
                else
                {
                    requestedEmail = "No";
                }
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        //Displays form that is instance of a class 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm newForm = new AboutForm();
            newForm.ShowDialog();
        }

        private void numbOfClasses_Click(object sender, EventArgs e)
        {

        }
    }
}




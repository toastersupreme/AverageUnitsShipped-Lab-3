// Author: Willem Vidler
// Date: January 20th 2021
// Updated: February 22nd 2021
// Description: 
// This program takes 7 days worth of units shipped and gives you the average for 3 employees, and then the average of all of them together 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShipped
{
    public partial class formAverageUnitsShipped : Form
    {
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;

        // Class-level variable declerations
        int currentDay = 0;
        int currentEmployee = 0;
        double totalAverage = 0;

        int[,] entryArray = new int[NumberOfEmployees, NumberOfDays];

        // Make arrays for output
        TextBox[] employeeTextBoxes;
        Label[] employeeAverages;

        public formAverageUnitsShipped()
        {
            InitializeComponent();

            // Making the arrays
            employeeTextBoxes = new TextBox[] { textboxPastEntries, textBoxPastEntries2, textBoxPastEntries3};
            employeeAverages = new Label[] { labelAverageOutput, labelAverageOutput2, labelAverageOutput3};
        }

        /// <summary>
        /// Allows entry of numerical data into the program, but makes sure that the data is numerical and that it between the minimum and maximum value allowed by the program.
        /// Once the program has 7 entries it stops the user from putting in anymore data unless they click the reset button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare constants and variables
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;

            // Validate that the number entered is a whole number
            if (int.TryParse(textboxEntryNumbers.Text, out entryArray[currentEmployee, currentDay]))
            {
                // Validate that the number entered is between 0 and 5000
                if (entryArray[currentEmployee, currentDay] >= MinimumUnits && entryArray[currentEmployee, currentDay] <= MaximumUnits)
                {
                    // Enter the current entry in the current employee's textbox
                    employeeTextBoxes[currentEmployee].Text += entryArray[currentEmployee, currentDay] + "\r\n";

                    // Check if we have entered day 7.
                    if (currentDay >= NumberOfDays - 1)
                    {
                        int employeeTotal = 0;

                        // Calculate and display the employee total
                        for (int day = 0; day < NumberOfDays; day++)
                        {
                            employeeTotal += entryArray[currentEmployee, day];
                        }

                        // Calculate and display the employee's average in their output label.
                        employeeAverages[currentEmployee].Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2);
                        totalAverage += Math.Round((double)employeeTotal);
                        // Now at day 7, reset and go ot the next employee
                        currentDay = 0;
                        currentEmployee++;
                                              
                    }else
                    {
                        //Adjust the day and set the day counter
                        currentDay++;
                        
                    }

                    // Check if we have entered all employees.
                    if (currentEmployee >= NumberOfEmployees)
                    {
                        //Calculate and display the overall average
                        labelTotalAverageOutput.Text = "Average per Day: " + Math.Round(totalAverage / (NumberOfDays * NumberOfEmployees), 2);

                        currentDay = 0;
                        currentEmployee = 0;

                        // Disable input controls and focus reset
                        textboxEntryNumbers.Enabled = false;
                        buttonEnter.Enabled = false;
                        buttonReset.Focus();


                    }else
                    {
                        labelDay.Text = "Day " + (currentDay + 1);
                    }

                    textboxEntryNumbers.Clear();
                    

                }
                else
                {
                    // The value entered is less than 0 or greater than 5000
                    MessageBox.Show("Enter a value between " + MinimumUnits +
                        " and " + MaximumUnits + ".", "Invalid Entry!");
                    textboxEntryNumbers.SelectAll();
                    textboxEntryNumbers.Focus();
                }
            }
            else
            {
                // The value entered is not an integer
                MessageBox.Show("Entry must be a numberic value.", "Invalid Entry!");
                textboxEntryNumbers.SelectAll();
                textboxEntryNumbers.Focus();
            }
            

        }

        /// <summary>
        /// Resets the form for new data entry, including resetting class variables and re-enabling controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear the input and output fields.
            textboxEntryNumbers.Clear();
            textboxPastEntries.Clear();
            textBoxPastEntries2.Clear();
            textBoxPastEntries3.Clear();
            labelAverageOutput.Text = string.Empty;
            labelAverageOutput2.Text = string.Empty;
            labelAverageOutput3.Text = string.Empty;
            labelTotalAverageOutput.Text = string.Empty;

            // Reset the global variables.
            totalAverage = 0;
            currentDay = 0;           
            labelDay.Text = "Day " + (currentDay + 1);           

            // Re-enable any controls that may be disabled.
            textboxEntryNumbers.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus for easy data entry.
            textboxEntryNumbers.Focus();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

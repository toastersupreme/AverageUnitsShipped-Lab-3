// Author: Willem Vidler
// Date: January 20th 2021
// Description: 
// This program takes 7 days worth of units shipped and gives you the average

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
        // Class-level variable declerations
        int currentDay = 1;
        int currentTotal = 0;

        public formAverageUnitsShipped()
        {
            InitializeComponent();
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
            const int MaximumDays = 7;
            int lastEntry;

            // Validate that the number entered is a whole number.
            if (int.TryParse(textboxEntryNumbers.Text, out lastEntry))
            {
                // Validate that the number entered is between 0 and 5000
                if (lastEntry >= MinimumUnits && lastEntry <= MaximumUnits)
                {
                    // If the entry is valid
                    // Add the newest entry to the list of past entries
                    textboxPastEntries.Text += lastEntry + "\r\n";
                    // Increment currentTotal by the entry
                    currentTotal += lastEntry;
                    // Increment the day by 1
                    currentDay++;
                    // Clear the entry textbox
                    textboxEntryNumbers.Clear();

                    // If the day is > 7
                    if (currentDay > MaximumDays)
                    {
                        //Determine the average
                        double averageUnits;
                        averageUnits = (double)currentTotal / (double)MaximumDays;
                        // Output the result
                        labelAverageOutput.Text = "Average per Day: " + Math.Round(averageUnits, 2);
                        // Disable controls
                        textboxEntryNumbers.Enabled = false;
                        buttonEnter.Enabled = false;
                        // Set focus to the reset button.
                        buttonReset.Focus();
                    }
                    // If the day is <= 7
                    else
                    {
                        // Display the current day  
                        labelDay.Text = "Day " + currentDay;
                        // Set focus to the new entry textbox
                        textboxEntryNumbers.Focus();
                    }

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
            labelAverageOutput.Text = string.Empty;

            // Reset the global variables.
            currentDay = 1;
            currentTotal = 0;

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

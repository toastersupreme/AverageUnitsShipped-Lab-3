
namespace AverageUnitsShipped
{
    partial class formAverageUnitsShipped
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textboxEntryNumbers = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textboxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPastEntries2 = new System.Windows.Forms.TextBox();
            this.textBoxPastEntries3 = new System.Windows.Forms.TextBox();
            this.labelAverageOutput2 = new System.Windows.Forms.Label();
            this.labelAverageOutput3 = new System.Windows.Forms.Label();
            this.labelTotalAverageOutput = new System.Windows.Forms.Label();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(12, 41);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(61, 23);
            this.labelUnitsPrompt.TabIndex = 1;
            this.labelUnitsPrompt.Text = "&Units:";
            // 
            // textboxEntryNumbers
            // 
            this.textboxEntryNumbers.Location = new System.Drawing.Point(79, 38);
            this.textboxEntryNumbers.Name = "textboxEntryNumbers";
            this.textboxEntryNumbers.Size = new System.Drawing.Size(69, 23);
            this.textboxEntryNumbers.TabIndex = 2;
            this.toolTip.SetToolTip(this.textboxEntryNumbers, "Enter the units shipped for the specified day");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(12, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(40, 23);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day 1";
            // 
            // textboxPastEntries
            // 
            this.textboxPastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textboxPastEntries.Location = new System.Drawing.Point(12, 99);
            this.textboxPastEntries.Multiline = true;
            this.textboxPastEntries.Name = "textboxPastEntries";
            this.textboxPastEntries.ReadOnly = true;
            this.textboxPastEntries.Size = new System.Drawing.Size(128, 144);
            this.textboxPastEntries.TabIndex = 4;
            this.toolTip.SetToolTip(this.textboxPastEntries, "Displays the units shipped for all days entered so far for empoyee 1");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(12, 260);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(128, 23);
            this.labelAverageOutput.TabIndex = 5;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average units shipped for the week for employee 1");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 323);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(128, 23);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to process the current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(159, 323);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(128, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset this form to allow a new week of entries");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(308, 323);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(128, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to end the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textBoxPastEntries2
            // 
            this.textBoxPastEntries2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPastEntries2.Location = new System.Drawing.Point(159, 99);
            this.textBoxPastEntries2.Multiline = true;
            this.textBoxPastEntries2.Name = "textBoxPastEntries2";
            this.textBoxPastEntries2.ReadOnly = true;
            this.textBoxPastEntries2.Size = new System.Drawing.Size(128, 144);
            this.textBoxPastEntries2.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxPastEntries2, "Displays the units shipped for all days entered so far for empoyee 2");
            // 
            // textBoxPastEntries3
            // 
            this.textBoxPastEntries3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPastEntries3.Location = new System.Drawing.Point(308, 99);
            this.textBoxPastEntries3.Multiline = true;
            this.textBoxPastEntries3.Name = "textBoxPastEntries3";
            this.textBoxPastEntries3.ReadOnly = true;
            this.textBoxPastEntries3.Size = new System.Drawing.Size(128, 144);
            this.textBoxPastEntries3.TabIndex = 10;
            this.toolTip.SetToolTip(this.textBoxPastEntries3, "Displays the units shipped for all days entered so far for empoyee 3");
            // 
            // labelAverageOutput2
            // 
            this.labelAverageOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput2.Location = new System.Drawing.Point(159, 260);
            this.labelAverageOutput2.Name = "labelAverageOutput2";
            this.labelAverageOutput2.Size = new System.Drawing.Size(128, 23);
            this.labelAverageOutput2.TabIndex = 8;
            this.labelAverageOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput2, "Displays the calculated average units shipped for the week for employee 2");
            // 
            // labelAverageOutput3
            // 
            this.labelAverageOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput3.Location = new System.Drawing.Point(308, 260);
            this.labelAverageOutput3.Name = "labelAverageOutput3";
            this.labelAverageOutput3.Size = new System.Drawing.Size(128, 23);
            this.labelAverageOutput3.TabIndex = 11;
            this.labelAverageOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput3, "Displays the calculated average units shipped for the week for employee 3");
            // 
            // labelTotalAverageOutput
            // 
            this.labelTotalAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAverageOutput.Location = new System.Drawing.Point(12, 291);
            this.labelTotalAverageOutput.Name = "labelTotalAverageOutput";
            this.labelTotalAverageOutput.Size = new System.Drawing.Size(424, 23);
            this.labelTotalAverageOutput.TabIndex = 12;
            this.labelTotalAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelTotalAverageOutput, "Displays the calculated average units shipped for the week for all employees");
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.AutoSize = true;
            this.labelEmployee1.Location = new System.Drawing.Point(39, 74);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee1.TabIndex = 3;
            this.labelEmployee1.Text = "Employee 1";
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.AutoSize = true;
            this.labelEmployee2.Location = new System.Drawing.Point(189, 74);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee2.TabIndex = 6;
            this.labelEmployee2.Text = "Employee 2";
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.AutoSize = true;
            this.labelEmployee3.Location = new System.Drawing.Point(339, 74);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(68, 15);
            this.labelEmployee3.TabIndex = 9;
            this.labelEmployee3.Text = "Employee 3";
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(448, 360);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.labelTotalAverageOutput);
            this.Controls.Add(this.labelAverageOutput3);
            this.Controls.Add(this.labelAverageOutput2);
            this.Controls.Add(this.textBoxPastEntries3);
            this.Controls.Add(this.textBoxPastEntries2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textboxPastEntries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textboxEntryNumbers);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textboxEntryNumbers;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textboxPastEntries;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxPastEntries2;
        private System.Windows.Forms.TextBox textBoxPastEntries3;
        private System.Windows.Forms.Label labelAverageOutput2;
        private System.Windows.Forms.Label labelAverageOutput3;
        private System.Windows.Forms.Label labelTotalAverageOutput;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.Label labelEmployee3;
    }
}


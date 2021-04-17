// Exam 2, Part 3
// CIS 199-XX
// Spring 2019
// Prompt the user to enter state abbreviation and purchase price.
// Finds associated sales tax for state (or 0) if not.
// Calculates and displays sales tax % and total (with tax).

// By: Andrew L. Wright

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double GetSalesTaxPct(string state)
        {
            // The states in which we have a presence
            string[] states = { "KY", "IN", "OH", "TN", "IL", "WV", "WI", "VA", "NC", "SC", "GA", "FL" };

            // The sales tax percent for each state above
            double[] salesTaxes = { 0.06, 0.07, 0.0575, 0.07, 0.0625, 0.06, 0.05, 0.043, 0.0475, 0.06, 0.04, 0.06 };

            double salesTaxPct = 0; // Matching sales tax, assumes not found
            int index = 0;          // Current position being searched, start at first subscript
            bool found = false;     // Have we found a match yet?

            while (index < states.Length && !found)
            {
                if (state == states[index])
                    found = true;
                else
                    ++index;
            }

            if (found)
                salesTaxPct = salesTaxes[index];

            return salesTaxPct;
        }

        // OR

        //public double GetSalesTaxPct(string state)
        //{
        //    // The states in which we have a presence
        //    string[] states = { "KY", "IN", "OH", "TN", "IL", "WV", "WI", "VA", "NC", "SC", "GA", "FL" };

        //    // The sales tax percent for each state above
        //    double[] salesTaxes = { 0.06, 0.07, 0.0575, 0.07, 0.0625, 0.06, 0.05, 0.043, 0.0475, 0.06, 0.04, 0.06 };

        //    double salesTaxPct = 0; // Matching sales tax, assumes not found
        //    bool found = false;     // Have we found a match yet?

        //    for (int index = 0; index < states.Length && !found; ++index)
        //    {
        //        if (state == states[index])
        //        {
        //            found = true;
        //            salesTaxPct = salesTaxes[index];
        //        }
        //    }

        //    return salesTaxPct;
        //}

        // OR

        //public double GetSalesTaxPct(string state)
        //{
        //    // The states in which we have a presence
        //    string[] states = { "KY", "IN", "OH", "TN", "IL", "WV", "WI", "VA", "NC", "SC", "GA", "FL" };

        //    // The sales tax percent for each state above
        //    double[] salesTaxes = { 0.06, 0.07, 0.0575, 0.07, 0.0625, 0.06, 0.05, 0.043, 0.0475, 0.06, 0.04, 0.06 };

        //    int index = 0;          // Current position being searched, start at first subscript

        //    while (index < states.Length && state != states[index])
        //            ++index;

        //    if (index < states.Length) // Must have found a match
        //        return salesTaxes[index];
        //    else // No match
        //        return 0;
        //}

        private void calcTaxBtn_Click(object sender, EventArgs e)
        {
            string stateInput;    // Entered state
            double purchasePrice; // Entered purchase price
            double salesTaxPct;   // Sales tax % for given state
            double total;         // Calculated total (with tax)

            stateInput = stateTxt.Text.ToUpper(); // Extracts state and converts to upper case letters

            // Try to parse purchase price, error message when invalid
            if (double.TryParse(purchasePriceTxt.Text, out purchasePrice) && purchasePrice > 0)
            {
                // Add code here to:
                // Call method to determine salesTaxPct
                // Calculate total (with tax)
                // Display sales tax percentage (in salesTaxPctOutputLbl on form), % format
                // Display total with tax (in totalOutputLbl on form), currency format

                salesTaxPct = GetSalesTaxPct(stateInput);
                total = purchasePrice * (1 + salesTaxPct);

                salesTaxPctOutputLbl.Text = $"{salesTaxPct:P}";
                totalOutputLbl.Text = $"{total:C}";
            }
            else
            {
                MessageBox.Show("Please enter valid purchase price!");
            }

        }
    }
}

using SoftwareConstructionClassLibrary;

namespace SoftwareConstructionUI
{
    public partial class Week2UI : Form
    {

        TwoNumbers numbers;

        public Week2UI()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Executes a TwoNumbers class method based on the provided method name and updates the user interface with the result
        /// </summary>
        /// <param name="method">The name of the method to be executed.</param>
        private void RunMethod(string method)
        {


            txtResult.Text = "RESULT\r\n";
            switch (method)
            {
                case "Method to return 1st Number":
                    txtResult.Text += $"◼ First number = {numbers.FirstNumber.ToString()}";
                    break;
                case "Method to return 2nd Number":
                    txtResult.Text += $"◼ Second number = {numbers.SecondNumber.ToString()}";
                    break;
                case "Method to return larger of the two numbers":
                    txtResult.Text += $"◼ Largest number = {(numbers.LargestNumber() == 0 ? "Numbers are the same" : numbers.LargestNumber().ToString())}";
                    break;
                case "Method to test equality":
                    txtResult.Text += $"◼ The numbers are{(numbers.NumbersAreEqual() == true ? "" : " not")} equal";
                    break;
                case "Method to calculate and return GCD":
                    txtResult.Text += $"◼ GCD of the two numbers {numbers.FirstNumber.ToString()} & {numbers.SecondNumber.ToString()}" +
                        $" = {(numbers.CalculateGCD().ToString())}";
                    break;
                case "Method to add to numbers":
                    numbers.AddToNumbers((int)nudFirstNumber.Value, (int)nudSecondNumber.Value);
                    txtResult.Text += $"◼ Values added to the numbers";
                    break;
                case "Method to return string":
                    txtResult.Text += numbers.ToString();
                    break;
                default:
                    break;
            }


        }


        /// <summary>
        /// Handles the click event for the Constructor button.
        /// Initializes the TwoNumbers class instance if the provided numbers are valid.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnConstructor_Click(object sender, EventArgs e)
        {
            // Check if the numeric values are positive
            if ((int)nudFirstNumber.Value > 0 && (int)nudSecondNumber.Value > 0)
            {
                // Disable the Constructor button and enable the method selection drop down
                btnConstructor.Enabled = false;
                cboMethod.Enabled = true;
                txtResult.Text = "RESULT\r\nTwoNumbers Class Instantiated ✅";
                txtResult.Text += "\r\nMethod selection now available";

                btnConstructor.BackColor = Color.Gray;
                txtResult.ForeColor = Color.LimeGreen;

                // Instantiate the TwoNumbers class with the form input values.
                numbers = new TwoNumbers((int)nudFirstNumber.Value, (int)nudSecondNumber.Value);

            }
            else
            {
                // Failed validation result
                txtResult.Text = "RESULT\r\nFailed to instantiate class";
                txtResult.Text += "\r\nREASON -> Both integers need to be positive > 0";
                txtResult.ForeColor = Color.Red;
            }

        }


        /// <summary>
        /// Handler for combo box change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboMethod_OnChange(object sender, EventArgs e)
        {
            btnCallMethod.Enabled = true;
            btnCallMethod.BackColor = Color.LightGreen;

        }


        /// <summary>
        /// Handler for Call method button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCallMethod_Click(object sender, EventArgs e)
        {
            RunMethod(cboMethod.Text);
        }
    }
}

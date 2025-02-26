﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SoftwareConstructionClassLibrary;

namespace SoftwareConstructionUI
{
    public partial class Week3UI : Form
    {


        private ArrayOfNumbers numbers;
        List<int> list = new List<int>();

        public Week3UI()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Executes a ArrayOfNumbers class method based on the provided method name and updates the user interface with the result
        /// </summary>
        /// <param name="method">The name of the method to be executed.</param>
        private void RunMethod(string method)
        {


            txtResult.Text = "RESULT\r\n";
            switch (method)
            {
                case "Method to return max number":
                    txtResult.Text += $"◼ Max number in array = {numbers.GetMaxValue()}";
                    break;
                case "Method to test equality":
                    txtResult.Text += $"◼ {(numbers.DetermineEquality((int)nudFirstNumber.Value, (int)nudSecondNumber.Value) == true ? "Two numbers are equal" : "The two numbers are NOT equal")}";
                    break;
                case "Method to calculate and return GCD":
                    txtResult.Text += $"◼ GCD of the two numbers {numbers.GetArrayElementValue((int)nudFirstNumber.Value).ToString()} & {numbers.GetArrayElementValue((int)nudSecondNumber.Value).ToString()}" +
                        $" = {(numbers.CalculateGCD((int)nudFirstNumber.Value, (int)nudSecondNumber.Value))}";
                    break;
                case "Method to return number of elements":
                    txtResult.Text += $"◼ Number of elements in the array = {numbers.CountElements()}";
                    break;
                case "Method to sum all elements in the array":
                    txtResult.Text += $"◼ Sum of all elements = {numbers.SumElements()}";
                    break;
                case "Method to return array average":
                    txtResult.Text += $"◼ Average value in the array = {numbers.AverageElements()}";
                    break;
                case "Method to return string representation of the array":
                    txtResult.Text += $"{numbers.ToString()}";
                    break;
                case "Mutator Method 1 - Scalar Multiply":
                    numbers.ScalarMultiply((int)nudFirstNumber.Value);
                    txtResult.Text += "Method complete";
                    break;
                case "Mutator Method 2 - Add constant":
                    numbers.AddConstant((int)nudFirstNumber.Value);
                    txtResult.Text += "Method complete";
                    break;
                case "Accessor Method 1 - Return element value at index":
                    txtResult.Text += $"◼ Array value at index {(int)nudFirstNumber.Value} = {numbers.GetArrayElementValue((int)nudFirstNumber.Value)}";
                    break;
                case "Accessor Method 2 - Set element value at index":
                    numbers.SetArrayElementValue((int)nudFirstNumber.Value, (int)nudSecondNumber.Value);
                    txtResult.Text += "Element value set";
                    break;
                default:
                    break;
            }


        }


        /// <summary>
        /// Renders user instructions in the Terminal window.
        /// </summary>
        /// <param name="type">The type of operation constructor or method</param>
        /// <param name="index">The index method in the cbo input</param>
        private void renderInstructions(string type, int index)
        {

            txtResult.Text = "INSTRUCTIONS\r\n";
            if (type == "constructor")
            {
                if (index == 0)
                {
                    txtResult.Text += "◼ STEP 1 - Use Input 1 to specify array size\r\n◼ STEP 2 - Click on Constructor button";
                    nudFirstNumber.Enabled = true;


                }
                else
                {
                    txtResult.Text += "◼ STEP 1 - Use Input 2 + Add button to create/ add to array values\r\n◼ STEP 2 - Click on Constructor button";
                    nudSecondNumber.Enabled = true;
                    btnAddNumber.Enabled = true;
                }
            }

            if (type == "method")
            {
                nudFirstNumber.Enabled = false;
                nudSecondNumber.Enabled = false;
                nudFirstNumber.Value = 0;
                nudSecondNumber.Value = 0;
                switch (index)
                {
                   
                    case 1:                        
                    case 2:
                        txtResult.Text += "◼ STEP 1 - Enter two array indices params using input 1 and input 2\r\n◼ STEP 2 - Click on Run Method";
                        nudFirstNumber.Enabled = true;
                        nudSecondNumber.Enabled = true;
                        nudFirstNumber.Maximum = numbers.CountElements() - 1;
                        nudSecondNumber.Maximum = numbers.CountElements() - 1;
                        break;
                    case 0:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        txtResult.Text += "◼ STEP 1 - Click on Run Method";
                        break;
                    case 7:
                        txtResult.Text += "◼ STEP 1 - Use Input 1 to specify scalar value\r\n◼ STEP 2 - Click on Run Method";
                        nudFirstNumber.Enabled = true;
                        break;
                    case 8:
                        txtResult.Text += "◼ STEP 1 - Use Input 1 to specify value\r\n◼ STEP 2 - Click on Run Method";
                        nudFirstNumber.Enabled = true;
                        break;
                    case 9:
                        nudFirstNumber.Maximum = numbers.CountElements() - 1;
                        txtResult.Text += "◼ STEP 1 - Use Input 1 to specify index number\r\n◼ STEP 2 - Click on Run Method";
                        nudFirstNumber.Enabled = true;
                        break;
                    case 10:
                        nudFirstNumber.Maximum = numbers.CountElements() - 1;
                        nudSecondNumber.Maximum = 1000000;
                        txtResult.Text += "◼ STEP 1 - Use Input 1 to specify index number , Input 2 to specify new value\r\n◼ STEP 2 - Click on Run Method";
                        nudFirstNumber.Enabled = true;
                        nudSecondNumber.Enabled = true;
                        break;




                }

            }



        }




        /// <summary>
        /// Handler for constructor combo box change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboConstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudFirstNumber.Enabled = false;
            nudSecondNumber.Enabled = false;
            btnAddNumber.Enabled = false;
            btnConstructor.Enabled = true;
            renderInstructions("constructor", cboConstructor.SelectedIndex);


        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            string text = "";
            list.Add((int)nudSecondNumber.Value);
            foreach (int i in list)
            {
                text += $"{i},";
            }

        }

        /// <summary>
        /// Handler for Call constructor button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConstructor_Click(object sender, EventArgs e)
        {
            txtResult.ForeColor = Color.LimeGreen;
            txtResult.Text = "RESULT\r\n";
            if (cboConstructor.SelectedIndex == 0)
            {
                if (nudFirstNumber.Value < 2)
                {
                    txtResult.Text = "RESULT\r\nFailed to instantiate class";
                    txtResult.Text += "\r\nREASON -> Array size < 2";
                    txtResult.ForeColor = Color.Red;
                    return;
                }
                numbers = new ArrayOfNumbers((int)nudFirstNumber.Value);

            }
            else
            {
                if (list.Count < 2)
                {
                    txtResult.Text = "RESULT\r\nFailed to instantiate class";
                    txtResult.Text += "\r\nREASON -> Array size < 2";
                    txtResult.ForeColor = Color.Red;
                    return;

                }
                numbers = new ArrayOfNumbers(list.ToArray());

            }

            txtResult.Text += "ArrayOfNumbers Class Instantiated ✅";
            txtResult.Text += "\r\nMethod selection now available";
            nudFirstNumber.Enabled = false;
            nudSecondNumber.Enabled = false;
            btnAddNumber.Enabled = false;
            btnConstructor.Enabled = false;
            cboConstructor.Enabled = false;
            cboMethod.Enabled = true;


        }

        /// <summary>
        /// Handler for method combo box change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCallMethod.Enabled = true;
            btnCallMethod.BackColor = Color.LimeGreen;
            renderInstructions("method", cboMethod.SelectedIndex);
        }

        /// <summary>
        /// Handler for Call method button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCallMethod_Click(object sender, EventArgs e)
        {
    
            RunMethod(cboMethod.Text);
        }
    }
}

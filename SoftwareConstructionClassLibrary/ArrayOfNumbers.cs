using System;

namespace SoftwareConstructionClassLibrary
{

    /// <summary>
    /// Represents a an array of numbers class
    /// </summary>
    public class ArrayOfNumbers
    {

        // Private instance field for encapsulation
        private int[] _arrayNumbers;


        // Constructor
        public ArrayOfNumbers(int size)
        {
            _arrayNumbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                _arrayNumbers[i] = 0;
            }


        }

        // Constructor
        public ArrayOfNumbers(int[] arrayNumbers)
        {
            _arrayNumbers = (int[])arrayNumbers.Clone();

        }


        // Accessor method (GET)
        public int GetArrayElementValue(int index)
        {

            return _arrayNumbers[index];

        }


        // Accessor method (SET)
        public void SetArrayElementValue(int index, int value)
        {
            _arrayNumbers[index] = value;

        }

        /// <summary>
        /// Method to return the max value in the array
        /// </summary>
        /// <returns>Max value</returns>
        public int GetMaxValue()
        {
            int value = 0;
            if (_arrayNumbers.Length == 0)
                return value;

            foreach (var item in _arrayNumbers)
            {
                if (item > value)
                {
                    value = item;
                }

            }
            return value;

        }


        /// <summary>
        /// Method to determine if the array indices are equal
        /// </summary>
        /// <returns>true or false</returns>
        public bool DetermineEquality(int a, int b)
        {
            return _arrayNumbers[a] == _arrayNumbers[b];
        }



        /// <summary>
        /// Method to calcuate GCD (Euclid's algorithm - subtraction method)
        /// </summary>
        /// <returns>greatest common divisor (GCD) of the two integers a b</returns>
        public int CalculateGCD(int a, int b)
        {
            a = _arrayNumbers[a];
            b = _arrayNumbers[b];

            // loop until the two numbers match
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;


        }


        /// <summary>
        /// Method to return array length
        /// </summary>
        /// <returns>Length of the array</returns>
        public int CountElements()
        {
            return _arrayNumbers.Length;
        }



        /// <summary>
        /// Method to sum all elements in the array
        /// </summary>
        /// <returns>Sum of all the elements</returns>
        public int SumElements()
        {
            return _arrayNumbers.Sum();

        }


        public decimal AverageElements()
        {
            return Math.Round(((decimal)SumElements() / (decimal)CountElements()), 2);
        }


        /// <summary>
        /// Method to overide ToString method to return the state of the fields/ object
        /// </summary>
        /// <returns>String of object values</returns>
        public override string ToString()
        {
            int index = 0;
            string result = "";
            foreach (var item in _arrayNumbers)
            {
                result += $"Array position {index} has value {item}\r\n";
                index++;

            }

            return result;


        }




        /// <summary>
        /// Method to multiply array elements
        /// </summary>
        /// <param name="scalar">Scalar value</param>
        public void ScalarMultiply(int scalar)
        {
            for (int i = 0; i < _arrayNumbers.Length; i++)
            {
                _arrayNumbers[i] *= scalar;
            }

        }

        /// <summary>
        /// Method to add constant to array elements
        /// </summary>
        /// <param name="value">Constant value</param>
        public void AddConstant(int value) 
            {
                for (int i = 0; i < _arrayNumbers.Length; i++)
                {
                    _arrayNumbers[i] += value;
                }

            }


    }

}
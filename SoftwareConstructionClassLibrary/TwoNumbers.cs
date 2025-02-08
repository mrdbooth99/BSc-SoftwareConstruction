namespace SoftwareConstructionClassLibrary
{

    /// <summary>
    /// Represents a two numbers class
    /// </summary>
    public class TwoNumbers
    {

        // Private instance fields for encapsulation
        private int _firstNumber;
        private int _secondNumber;




        // Constructor to initialise fields
        public TwoNumbers(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;


        }


        public int FirstNumber
        {
            get { return _firstNumber; }
        }

        public int SecondNumber
        {
            get { return _secondNumber; }
        }


        /// <summary>
        /// Method to determine if the instance fields are equal
        /// </summary>
        /// <returns>true or false</returns>
        public bool NumbersAreEqual()
        {
            return _firstNumber == _secondNumber;
        }


        /// <summary>
        /// Method to return the larger of the two instance fields
        /// </summary>
        /// <returns>the largest number or 0 if the fields are equal</returns>
        public int LargestNumber()
        {
            if (!NumbersAreEqual())
            {

                return _firstNumber > _secondNumber ? _firstNumber : _secondNumber;
            }
            return 0;
        }



        /// <summary>
        /// Method to calcuate GCD (Euclid's algorithm - subtraction method)
        /// </summary>
        /// <returns>greatest common divisor (GCD) of the two integers a b</returns>
        public int CalculateGCD()
        {
            int a = _firstNumber;
            int b = _secondNumber;

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
        /// Method to add to the instance fields
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        public void AddToNumbers(int a, int b)
        {
            _firstNumber += a;
            _secondNumber += b;
        }

        /// <summary>
        /// Method to overide ToString method to return the state of the fields/ object
        /// </summary>
        /// <returns>String of object values</returns>
        public override string ToString()
        {
            return $"◼ First Number = {_firstNumber}\r\n" +
                $"◼ Second Number = {_secondNumber}\r\n" +
                $"◼ Max = {(LargestNumber() == 0 ? "Numbers are the same" : LargestNumber().ToString())}\r\n" +
                $"◼ Equal = {(NumbersAreEqual() == true ? "Yes" : "No")}\r\n" +
                $"◼ GCD = {CalculateGCD()}";
        }


    }

}


namespace SoftwareConstructionClassLibrary
{

    /// <summary>
    /// Represents a an array of numbers class
    /// </summary>
    public class ArrayOfNumbers
    {

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

          





    }
}

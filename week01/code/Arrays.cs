public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // -------------------------------------------
        // create an array to hold 'length' multiples
        double[] multiples = new double[length];

        // loop from 0 to length - 1
        // for each index calculate multiple by multiplying the base number by index + 1
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // return the completed array of multiples
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // -------------------------------------------
        // calculate how much to rotate and adjust if the amount is larger than the list size
        int effectiveAmount = amount % data.Count;

        // get the last 'effectiveAmount' elements to form the rotated part
        List<int> rotatedPart = data.GetRange(data.Count - effectiveAmount, effectiveAmount);
        
        // get the elements at the beginning to the split point as the remaining part
        List<int> remainingPart = data.GetRange(0, data.Count - effectiveAmount);

        // clear the list -- rebuild by adding the rotated part and then the remaining part
        data.Clear();
        data.AddRange(rotatedPart);
        data.AddRange(remainingPart);
    }
}

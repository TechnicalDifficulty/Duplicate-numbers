using DuplicateNumbers;
using System;
using Xunit;

namespace DuplicateNumbersTest
{
    public class DuplicateNumbersTest
    {
        [Fact]
        public void Checking_Values_in_Array()
        {
            //ARRANGE 
            var obj = new DuplicateNumbersProgram();
            //ACT
            int[] testArr = new int[] { 1, 2, 3, 4};
            obj.findDuplicates(testArr);
            //ASSERT

            
        }
    }
}

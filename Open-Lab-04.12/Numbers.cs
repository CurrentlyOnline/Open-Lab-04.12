using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int vysledok = 55 - sum;
            return vysledok;
        }
    }
}

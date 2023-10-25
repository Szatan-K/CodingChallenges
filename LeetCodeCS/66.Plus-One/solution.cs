public class Solution {
    public int[] PlusOne(int[] digits) {
        int r=1;
        int len = digits.Length;
        for (int i = len-1; i >= 0; i--)
        {
            digits[i] += r;
            if (digits[i] == 10)
                digits[i]=0;
            else
                return digits;

        }
        int[] res= new int[len+1];
        res[0]=1;
        Array.Copy(digits, 0, res, 1, len);
        return res;
    }
}
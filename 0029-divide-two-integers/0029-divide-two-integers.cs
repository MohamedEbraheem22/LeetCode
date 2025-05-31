public class Solution {
    public int Divide(int dividend, int divisor) {
        if (dividend == int.MinValue && divisor == -1)
            return int.MaxValue;

        bool isNegative = (dividend < 0) ^ (divisor < 0);  

        long absDividend = Math.Abs((long)dividend);
        long absDivisor = Math.Abs((long)divisor);

        int res = 0;
        while (absDividend >= absDivisor) {
            long temp = absDivisor;
            int multiple = 1;
            while(absDividend > (temp<<1))
            {
                temp<<=1;
                multiple<<=1;
            }
            absDividend -= temp;
            res +=multiple;
        }

        return isNegative ? -res : res;
    }
}

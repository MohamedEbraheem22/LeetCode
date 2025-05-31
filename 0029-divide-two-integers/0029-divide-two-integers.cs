public class Solution {
    public int Divide(int dividend, int divisor) {
       if (divisor == 0)
        throw new DivideByZeroException();

    if (dividend == int.MinValue && divisor == -1)
        return int.MaxValue;

    bool negative = (dividend < 0) ^ (divisor < 0);  // تحدد علامة الناتج

    long dividendL = Math.Abs((long)dividend);
    long divisorL = Math.Abs((long)divisor);

    int result = 0;

    while (dividendL >= divisorL) {
        long temp = divisorL;
        int multiple = 1;

        // نضاعف temp لحد ما يكون أكبر من dividendL
        while (dividendL >= (temp << 1)) {
            temp <<= 1;     // temp = temp * 2
            multiple <<= 1; // multiple = multiple * 2
        }

        dividendL -= temp;  // نطرح أكبر مضاعف من dividend
        result += multiple; // نضيف عدد المضاعفات للناتج
    }

    return negative ? -result : result;
             
        }
        
        
    }

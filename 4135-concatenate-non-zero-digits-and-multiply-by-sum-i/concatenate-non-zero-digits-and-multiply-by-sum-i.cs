public class Solution {
    public long SumAndMultiply(int n) {
        
        if(n < 0) {
            n = n * -1;
        }

        string s = string.Join("", n.ToString().Split('0'));
        int withoutZeros = s.Length == 0 ? 0 : int.Parse(s);

        int sum = 0;
        int temp = withoutZeros;
        do {
            // 1234
            int rem = temp % 10; // 4
            temp = temp / 10; // 1234 / 10 = 123
            sum += rem; // 0 + 4
        }while(temp != 0);

        long ans = (long)withoutZeros * sum;
        return ans;
        
    }
}
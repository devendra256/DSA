public class Solution {
    public int MostFrequentEven(int[] nums) {
        
        int allOdd = -1;
        Dictionary<int, int> evenDict = new Dictionary<int, int>();

        foreach(int num in nums) {
            if(num % 2 != 0)
                continue;

            evenDict[num] = evenDict.GetValueOrDefault(num) + 1;
            allOdd *= -1;
        }
        if(evenDict.Count == 0)
            return -1;

        int result = -1;
        int maxFreq = 0;

        foreach (var pair in evenDict)
        {
            if (pair.Value > maxFreq || (pair.Value == maxFreq && pair.Key < result)) {
                maxFreq = pair.Value;
                result = pair.Key;
            }
        }

        return result;
    }
}
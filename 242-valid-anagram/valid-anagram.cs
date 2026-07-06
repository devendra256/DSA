public class Solution {
    public bool IsAnagram(string s, string t) {

        Dictionary<char, int> map = new();

        foreach(char ch in s) {
            if(map.ContainsKey(ch)) {
                map[ch]++;
            } else {
                map[ch] = 1;
            }
        }

        foreach(char ch in t) {
            if(!map.ContainsKey(ch)) 
                return false;
            if(map[ch] == 1) {
                map.Remove(ch);
            } else {
                map[ch]--;
            }            
        }
        return map.Count == 0 ? true : false;
    }
}
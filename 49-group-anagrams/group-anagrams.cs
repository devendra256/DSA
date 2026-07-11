public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        var map = new Dictionary<string, List<string>>();

        foreach(var str in strs) {
            string key = sortStr(str);
            if(!map.TryGetValue(key, out var list)) {
                list = new List<string>();
                map[key] = list;
            }
            list.Add(str);
        }
        return map.Values.Cast<IList<string>>().ToList();
    }

    public static string sortStr(string str) {
        char[] chArr = str.ToCharArray();
        Array.Sort(chArr);
        return new string(chArr);
    }
}
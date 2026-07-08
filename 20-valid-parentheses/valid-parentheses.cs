public class Solution {
    public bool IsValid(string s) {

        if(s.Length % 2 != 0)
            return false;

        Stack<char> stack = new Stack<char>();

        foreach(var ch in s) {
            if(ch == '(' || ch == '[' || ch == '{') {
                stack.Push(ch);
            } else if(ch == ')' && stack.Count != 0 && stack.Peek() == '(') {
                stack.Pop();
            } else if(ch == ']' && stack.Count != 0 && stack.Peek() == '[') {
                stack.Pop();
            } else if(ch == '}' && stack.Count != 0 && stack.Peek() == '{') {
                stack.Pop();
            } else {
                return false;
            }
        }

        return stack.Count == 0 ? true : false;

    }
}
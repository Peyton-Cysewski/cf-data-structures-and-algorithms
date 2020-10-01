package utilities;

public class MultiBracketValidation {
    public static boolean multiBracketValidation(String input) {
            Stack<Character> brackets = new Stack();
            for (int i = 0; i < input.length(); i++) {
                Character l = input.charAt(i);
                if (l == '{' || l == '(' || l == '[')
                    brackets.push(l);
                else if (l == '}' || l == ')' || l == ']') {
                    Character r = brackets.pop();
                    if (l != r)
                        return false;
                }
            }
            return brackets.isEmpty();
    }
}

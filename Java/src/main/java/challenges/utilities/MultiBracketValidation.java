package challenges.utilities;

import java.util.HashMap;

public class MultiBracketValidation {
    public static boolean multiBracketValidation(String input) {
            Stack<Character> brackets = new Stack();
            HashMap<Character, Character> dict = new HashMap();
            dict.put('{', '}');
            dict.put('(', ')');
            dict.put('[', ']');
            for (int i = 0; i < input.length(); i++) {
                Character c = input.charAt(i);
                if (c == '{' || c == '(' || c == '[')
                    brackets.push(c);
                else if (c == '}' || c == ')' || c == ']') {
                    Character n = brackets.pop();
                    if (dict.get(n) != c)
                        return false;
                }
            }
            return brackets.isEmpty();
    }
}

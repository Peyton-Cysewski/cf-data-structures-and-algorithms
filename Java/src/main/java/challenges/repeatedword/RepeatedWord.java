package challenges.repeatedword;

import java.util.Arrays;
import java.util.HashSet;

public class RepeatedWord {
    public static String firstRepeated(String words) {
        if (words == null) return null;
        String[] wordArr = words.toLowerCase().replaceAll("[.]|,","").split(" ");
        HashSet<String> set = new HashSet<>();
        for (String word : wordArr) {
            if (set.contains(word)) return word;
            else set.add(word);
        }
        return null;
    }

    public static String firstRepeatedWithForLoops(String words) {
        if (words == null) return null;
        String[] wordArr = words.toLowerCase().replaceAll("[.]|,","").split(" ");
        for (int i = 1; i < wordArr.length; i++) {
            for (int j = i - 1; j > -1; j--) {
                if (wordArr[i].equals(wordArr[j])) return wordArr[i];
            }
        }
        return null;
    }
}

package challenges.repeatedword;

import org.junit.Test;
import static org.junit.Assert.*;

public class RepeatedWordTest {
    @Test public void testRepeatedWord() {
        String input = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only";
        assertEquals("it", RepeatedWord.firstRepeated(input));
    }

    @Test public void testNoRepeatedWords() {
        String input = "The. quick. brown. fox ..jumps over a lazy dog.";
        assertNull(RepeatedWord.firstRepeated(input));
    }

    @Test public void testEmptyString() {
        String input = "";
        assertNull(RepeatedWord.firstRepeated(input));
    }

    @Test public void testNullString() {
        String input = null;
        assertNull(RepeatedWord.firstRepeated(input));
    }

    @Test public void testRepeatedWordWithForLoops() {
        String input = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only";
        assertEquals("it", RepeatedWord.firstRepeatedWithForLoops(input));
    }

    @Test public void testNoRepeatedWordsWithForLoops() {
        String input = "The. quick. brown. fox ..jumps over a lazy dog.";
        assertNull(RepeatedWord.firstRepeatedWithForLoops(input));
    }

    @Test public void testEmptyStringWithForLoops() {
        String input = "";
        assertNull(RepeatedWord.firstRepeatedWithForLoops(input));
    }

    @Test public void testNullStringWithForLoops() {
        String input = null;
        assertNull(RepeatedWord.firstRepeatedWithForLoops(input));
    }
}

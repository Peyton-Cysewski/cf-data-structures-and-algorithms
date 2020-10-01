package utilities;

import org.junit.Test;
import static org.junit.Assert.*;

public class MultiBracketValidationTest {
    @Test public void test1() {
        String input = "{}";
        assertTrue(MultiBracketValidation.multiBracketValidation(input));
    }

    @Test public void test2() {
        String input = "{}(){}";
        assertTrue(MultiBracketValidation.multiBracketValidation(input));
    }

    @Test public void test3() {
        String input = "()[[Extra Characters]]";
        assertTrue(MultiBracketValidation.multiBracketValidation(input));
    }

    @Test public void test4() {
        String input = "(){}[[]]";
        assertTrue(MultiBracketValidation.multiBracketValidation(input));
    }

    @Test public void test5() {
        String input = "{}{Code}[Fellows](())";
        assertTrue(MultiBracketValidation.multiBracketValidation(input));
    }

    @Test public void test6() {
        String input = "[({}]";
        assertFalse(MultiBracketValidation.multiBracketValidation(input));
    }

    @Test public void test7() {
        String input = "(](";
        assertFalse(MultiBracketValidation.multiBracketValidation(input));
    }

    @Test public void test8() {
        String input = "{(})";
        assertFalse(MultiBracketValidation.multiBracketValidation(input));
    }
}

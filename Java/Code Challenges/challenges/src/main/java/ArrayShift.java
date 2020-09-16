public class ArrayShift {
    public static int[] insertShiftArray (int[] input, int value) {
        if (input.length == 0){
            return new int[]{value};
        }
        int[] output = new int[input.length + 1];
        int middle = input.length / 2;
        if (input.length % 2 == 1) {
            middle++;
        }
        int counter = 0;
        int outputCounter = 0;
        while (outputCounter < output.length) {
            if (outputCounter < middle) {
                output[outputCounter] = input[counter];
            } else if (outputCounter == middle) {
                output[outputCounter] = value;
                counter--;
            } else {
                output[outputCounter] = input[counter];
            }
            counter++;
            outputCounter++;
        }
        return output;
//        return new int[]{1,2,3,4,5};
    }
}
public class ArrayReverse {
	public static void main(String[] args) {

    int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7};
    
		for (int num : reverseArray(nums)) {
			System.out.println(num);
		}
	}
	
	public static int[] reverseArray(int[] array) {
		int temp;
		for (int i = 0; i < array.length / 2; i++) {
			temp = array[array.length - i - 1];
			array[array.length - i - 1] = array[i];
			array[i] = temp;
		}
		return array;
	}
}
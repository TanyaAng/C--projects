import java.util.Scanner;

/**
 * Created by 112-pc on 15.3.2016 г..
 */
public class SumOfNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number = scan.nextInt();
        int sum =0;
        for (int i = 1; i <=number ; i++) {
            sum += i*2;
        }
        System.out.println(sum);
    }
}

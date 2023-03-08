import java.io.*;
import java.util.*;


public class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(String s, long n) {
        long count = 0;
        long len = s.length();

        if (s.length() == 1) {
            if (s.charAt(0) == 'a') {
                return n;
            } else {
                return 0;
            }
        }

        // Count number of 'a' in the string
        for (int j = 0; j < len; j++) {
            if (s.charAt(j) == 'a') {
                count++;
            }
        }
        
        long div = n / len;
        count = div * count;

        long mod = n % len;
        // now for remaining go thru the loop again.
        for (int j = 0; j < mod; j++){
            if (s.charAt(j) == 'a') {
                count++;
            }
        }
        return (count);

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        long n = scanner.nextLong();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        long result = repeatedString(s, n);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}

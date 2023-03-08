public class App {

    static int min(int x, int y, int z) {
        if (x <= y && x <= z) return x;
        if (y <= x && y <= z) return y;
        else return z;
    }

    static int editDist(String str1, String str2, int str1Len, int Str2Len) 
    {
        // If first string is empty, the only option is to
        // insert all characters of second string into first
        if (str1Len == 0) return Str2Len;

        // If second string is empty, the only option is to
        // remove all characters of first string
        if (Str2Len == 0) return str1Len;

        // If last characters of two strings are same, nothing
        // much to do. Ignore last characters and get count for
        // remaining strings.
        if (str1.charAt(str1Len - 1) == str2.charAt(Str2Len - 1))
            return editDist(str1, str2, str1Len - 1, Str2Len - 1);

        // If last characters are not same, consider all three
        // operations on last character of first string, recursively
        // compute minimum cost for all three operations and take
        // minimum of three values.
        return 1 + min(editDist(str1, str2, str1Len, Str2Len - 1),    // Insert
                editDist(str1, str2, str1Len - 1, Str2Len),   // Remove
                editDist(str1, str2, str1Len - 1, Str2Len - 1) // Replace
        );
    }

    public static void main(String args[]) {
        String str1 = "Wednesday";
        String str2 = "Thursday";

        System.out.println(editDist(str1, str2, str1.length(), str2.length()));
    }
}


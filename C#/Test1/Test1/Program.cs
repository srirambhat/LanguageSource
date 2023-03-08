using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
class Student
{
    public String firstName;
    public String lastName;

}

public enum Greetings
{
    Morning,
    Afternoon,
    Evening,
    Night
}

public class AddOne
{
    public int x;

    public static AddOne operator +(AddOne a, AddOne b)
    {
        AddOne addone = new AddOne();
        addone.x = a.x + b.x + 1;
        return addone;
    }
}

public static class Extensions
{
    public static IEnumerator<T> GetEnumerator<T>(this
        IEnumerator<T> enumerator) => enumerator;
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

/*
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday" };
            myList.Insert(4,"Friday");

            foreach (string listEntry in myList)
                Console.WriteLine("listEntry: " +listEntry);

            Console.ReadLine();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myStringList = new List<string>()
                        { "Hello", "Goodbye", "Today", "Tomorrow" };

            Console.WriteLine($"Greeting at: {myStringList[3]}");
            if (myStringList.Contains("Goodbye"))
            {
                Console.WriteLine("Goodbye appears in the list.");
            }

            Console.ReadLine();
        }
    }
}
 
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 5 planets closest to the sun, in order: ");
            string[] planets =
              new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };

            foreach (string planet in planets)
            {
                // Use the special char \t to insert a tab in the printed line.
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nNow listed alphabetically: ");

            // Array.Sort() is a method on the Array class.
            // Array.Sort() does its work in-place in the planets array,
            // which leaves you without a copy of the original array. The
            // solution is to copy the old array to a new one and sort it.
            string[] sortedNames = planets;
            Array.Sort(sortedNames);

            // This demonstrates that (a) sortedNames contains the same
            // strings as planets and (b) that they're now sorted.
            foreach (string planet in sortedNames)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nList by name length - shortest first: ");

            // This algorithm is called "Bubble Sort": It's the simplest
            // but worst-performing sort. The Array.Sort() method is much
            // more efficient, but you can't use it directly to sort the
            // planets in order of name length because it sorts strings,
            // not their lengths.
            int outer;  // Index of the outer loop
            int inner;  // Index of the inner loop

            // Loop DOWN from last index to first: planets[4] to planets[0].
            for (outer = planets.Length - 1; outer >= 0; outer--)
            {
                // On each outer loop, loop through all elements BEYOND the
                // current outer element. This loop goes up, from planets[1]
                // to planets[4]. Using the for loop, you can traverse the
                // array in either direction.
                for (inner = 1; inner <= outer; inner++)
                {
                    // Compare adjacent elements. If the earlier one is longer
                    // than the later one, swap them. This shows how you can
                    // swap one array element with another when they're out of
                    // order.
                    if (planets[inner - 1].Length > planets[inner].Length)
                    {
                        // Temporarily store one planet.
                        string temp = planets[inner - 1];

                        // Now overwrite that planet with the other one.
                        planets[inner - 1] = planets[inner];

                        // Finally, reclaim the planet stored in temp and put
                        // it in place of the other.
                        planets[inner] = temp;
                    }
                }
            }

            foreach (string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.Read();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] myStrings = { "Hello", "Goodbye", "Today", "Tomorrow" };
            IEnumerator<string> stringEnum = (IEnumerator<string>)new
                List<string>(myStrings).GetEnumerator();

            while ((string)stringEnum.Current != "Hello")
                stringEnum.MoveNext();

            int sum = 0;
            int count = 0;
            foreach (var thisString in stringEnum)
            {
                Console.WriteLine($"The current string is: {thisString}.");
                Console.WriteLine($"It's {thisString.Length} characters long.");
                sum += thisString.Length;
                count++;
            }

            double average = (double)sum / count;
            Console.WriteLine($"The average character length is: {average}.");
            Console.ReadLine();

        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a maximum interest rate.
            int maximumInterest = 50;

            // Prompt user to enter source principal.
            Console.Write("Enter principal: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);

            // If the principal is negative …
            if (principal < 0)
            {
                // … generate an error message …
                Console.WriteLine("Principal cannot be negative");
            }
            else  // Go here only if principal was > 0: thus valid.
            {
                //  … otherwise, enter the interest rate.
                Console.Write("Enter interest: ");
                string interestInput = Console.ReadLine();
                decimal interest = Convert.ToDecimal(interestInput);

                // If the interest is negative or too large …
                if (interest < 0 || interest > maximumInterest)
                {
                    //  … generate an error message as well.
                    Console.WriteLine("Interest cannot be negative " +
                                      "or greater than " + maximumInterest);
                    interest = 0;
                }
                else  // Reach this point only if all is well.
                {
                    // Both the principal and the interest appear to be
                    // legal; finally, input the number of years.
                    Console.Write("Enter number of years: ");
                    string durationInput = Console.ReadLine();
                    int duration = Convert.ToInt32(durationInput);

                    // Verify the input.
                    Console.WriteLine();  // Skip a line.
                    Console.WriteLine("Principal     = " + principal);
                    Console.WriteLine("Interest      = " + interest + "%");
                    Console.WriteLine("Duration      = " + duration + " years");
                    Console.WriteLine();

                    // Now loop through the specified number of years.
                    int year = 1;
                    while (year <= duration)
                    {
                        // Calculate the value of the principal plus interest.
                        decimal interestPaid;
                        interestPaid = principal * (interest / 100);

                        // Now calculate the new principal by adding
                        // the interest to the previous principal amount.
                        principal = principal + interestPaid;

                        // Round off the principal to the nearest cent.
                        principal = decimal.Round(principal, 2);

                        // Output the result.
                        Console.WriteLine(year + " - " + principal);

                        // Skip over to next year.
                        year = year + 1;
                    }
                }
            }

            Console.Read();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        public static string LetterType(char letter) => letter switch
        {
            >= 'a' and <= 'z' => "lowercase letter",
            >= 'A' and <= 'Z' => "uppercase letter",
            >= '1' and <= '9' => "number",
            >= ':' and <= '@' or
            >= '[' and <= '`' or
            >= '{' and <= '~' => "special character",
            _ => "Unknown letter type"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("a is a " + LetterType('a') + ".");
            Console.WriteLine("B is an " + LetterType('B') + ".");
            Console.WriteLine("3 is a " + LetterType('3') + ".");
            Console.WriteLine("? is a " + LetterType('?') + ".");
            Console.WriteLine("À is a " + LetterType('À') + ".");
            Console.ReadLine();
        }

    }
}


namespace Test1
{
    internal class Program
    {
        public static string GreetString(Greetings value) => value switch
        {
            Greetings.Morning => "Good Morning!",
            Greetings.Afternoon => "Good Afternoon!",
            Greetings.Evening => "See you tomorrow!",
            Greetings.Night => "Are you still here?",

            // Added solely to cover all cases.
            _ => "Not sure what time it is!"
        };

        static void Main(string[] args)
        {
            Console.WriteLine(GreetString(Greetings.Morning));
            Console.WriteLine(GreetString(Greetings.Afternoon));
            Console.WriteLine(GreetString(Greetings.Evening));
            Console.WriteLine(GreetString(Greetings.Night));
            Console.ReadLine();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddOne foo = new AddOne();
            foo.x = 2;

            AddOne bar = new AddOne();
            bar.x = 3;

            // And 2 + 3 now is 6…
            Console.WriteLine((foo + bar).x.ToString());
            Console.Read();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder2 = new StringBuilder();
            builder2.Append(5);
            builder2.Append(true);
            builder2.Append(9.9);
            builder2.Append(2 + 4);
            Console.WriteLine(builder2.ToString());
            Console.ReadKey();

        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double MyVar = 123.456;
            Console.WriteLine($"This is the exponential form: {MyVar:E}.");
            Console.WriteLine($"This is the exponential form: {MyVar:C}.");
            Console.WriteLine($"This is the percent form: {MyVar:#.#%}.");
            Console.WriteLine($"This is the zero padded form: {MyVar:0000.0000}.");

            Console.ReadLine();
        }
    }
}

 namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Keep looping -- inputting numbers until the user
            // enters a blank line rather than a number.
            for (; ; )
            {
                // First input a number -- terminate when the user
                // inputs nothing but a blank line.
                Console.WriteLine("Enter a double number");
                string numberInput = Console.ReadLine();

                if (numberInput.Length == 0)
                {
                    break;
                }

                double number = Double.Parse(numberInput);

                // Now input the specifier codes; split them
                // using spaces as dividers.
                Console.WriteLine("Enter the format specifiers"
                                  + " separated by a blank "
                                  + "(Example: C E F1 N0 0000000.00000)");
                char[] separator = { ' ' };
                string formatString = Console.ReadLine();
                string[] formats = formatString.Split(separator);

                // Loop through the list of format specifiers.
                foreach (string s in formats)
                {
                    if (s.Length != 0)
                    {
                        // Create a complete format specifier
                        // from the letters entered earlier.
                        string formatCommand = "{0:" + s + "}";

                        // Output the number entered using the
                        // reconstructed format specifier.
                        Console.Write(
                             "The format specifier {0} results in ", formatCommand);
                        try
                        {
                            Console.WriteLine(formatCommand, number);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("<illegal control>");
                        }
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
 
namespace Test1
{
    internal class Program
    {
        // RemoveWhiteSpace -- The RemoveSpecialChars method removes every
        //    occurrence of the specified characters from the string.
        public static string RemoveSpecialChars(string input, char[] targets)
        {
            // Split the input string up using the target
            // characters as the delimiters.
            string[] subStrings = input.Split(targets);

            // output will contain the eventual output information.
            string output = "";

            // Loop through the substrings originating from the split.
            foreach (string subString in subStrings)
            {
                output = String.Concat(output, subString);
            }
            return output;
        }

        static void Main(string[] args)
        {
            string name = "This is a sample text";
            char[] removeList = { ' ', '+' };

            Console.WriteLine("Returned String: " +RemoveSpecialChars(name, removeList));

            Console.ReadLine();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the white space characters.
            char[] whiteSpace = { ' ', '\n', '\t' };

            // Start with a string embedded with white space.
            string s = " this is a\nstring"; // Contains spaces & newline.
            Console.WriteLine("before:" + s);

            // Output the string with the white space missing.
            Console.Write("after:");

            // Start looking for the white space characters.
            for (; ; )
            {
                // Find the offset of the character; exit the loop
                // if there are no more.
                int offset = s.IndexOfAny(whiteSpace);

                if (offset == -1)
                {
                    break;
                }

                // Break the string into the part prior to the
                // character and the part after the character.
                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);

                // Now put the two substrings back together with the
                // character in the middle missing.
                s = String.Concat(before, after);

                // Loop back up to find next white space char in
                // this modified s.
            }

            Console.WriteLine(s);
            Console.Read();
        }
    }
}
*/

/*
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Christa  ",
                                     "  Sarah",
                                     "Jonathan",
                                     "Sam",
                                     " Schmekowitz "};
            foreach (string s in names)
            {
                Console.WriteLine("This is the name '" + s + "' before");
            }
            Console.WriteLine();

            // This time, fix the strings so they are
            // left justified and all the same length.
            // First, copy the source list into a list that you can manipulate.
            List<string> stringsToAlign = new List<string>();

            // At the same time, remove any unnecessary spaces from either end
            // of the names.
            for (int i = 0; i < names.Count; i++)
            {
                string trimmedName = names[i].Trim();
                stringsToAlign.Add(trimmedName);
            }

            // Now find the length of the longest string so that
            // all other strings line up with that string.
            int maxLength = 0;
            foreach (string s in stringsToAlign)
            {
                if (s.Length > maxLength)
                {
                    maxLength = s.Length;
                }
            }

            // Now justify all the strings to the length of the maximum string.
            for (int i = 0; i < stringsToAlign.Count; i++)
            {
                stringsToAlign[i] = stringsToAlign[i].PadRight(maxLength + 1);
            }

            // Finally output the resulting padded, justified strings.
            Console.WriteLine("The following are the same names "
                            + "normalized to the same length");

            foreach (string s in stringsToAlign)
            {
                Console.WriteLine("This is the name '" + s + "' afterwards");
            }


            Console.ReadLine();
        }
    }
}

namespace Test1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] brothers = { "Chuck", "Bob", "Steve", "Mike" };

            string theBrothers = string.Join(":", brothers);

            Console.WriteLine(theBrothers);
            Console.ReadLine();
        }
    }
}

/*
namespace Test1
{
    internal class Program
    {

        public static bool IsAllDigits(string raw)
        {
            // First get rid of any benign characters at either end;
            // if there's nothing left, you don't have a number.
            string s = raw.Trim();  // Ignore white space on either side.
            if (s.Length == 0) return false;

            // Loop through the string.
            for (int index = 0; index < s.Length; index++)
            {
                // Minus signs are OK, so go to the next character.
                if (s[index] == '-' && index == 0) continue;

                // A nondigit indicates that the string probably isn't a number.
                if (Char.IsDigit(s[index]) == false) return false;
            }

            // No nondigits found; it's probably okay.
            return true;
        }

        public static void Main(string[] args)
        {
            // Prompt the user to input a sequence of numbers.
            Console.WriteLine(
            "Input a series of numbers separated by commas:");

            // Read a line of text.
            string input = Console.ReadLine();
            Console.WriteLine();

            // Now convert the line into individual segments
            // based upon either commas or spaces.
            char[] dividers = { ',', ' ' };
            string[] segments = input.Split(dividers);

            // Convert each segment into a number.
            int sum = 0;

            foreach (string s in segments)
            {
                // Skip any empty segments.
                if (s.Length > 0)
                {
                    // Skip strings that aren't numbers.
                    if (IsAllDigits(s))
                    {
                        // Convert the string into a 32-bit int.
                        int num = 0;
                        if (Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Next number = {0}", num);
                            // Add this number into the sum.
                            sum += num;
                        }
                        // If parse fails, move on to next number.
                    }
                }
            }

            // Output the sum.
            Console.WriteLine("Sum = {0}", sum);
            Console.Read();
        }
    }
}


/*
namespace Test1
{
    internal class Program
    {

        public static bool IsAllDigits(string raw)
        {
            // First get rid of any benign characters at either end;
            // if there's nothing left, you don't have a number.
            string s = raw.Trim();  // Ignore white space on either side.
            if (s.Length == 0) return false;

            // Loop through the string.
            for (int index = 0; index < s.Length; index++)
            {
                // Minus signs are OK, so go to the next character.
                if (s[index] == '-' && index == 0) continue;

                // A nondigit indicates that the string probably isn't a number.
                if (Char.IsDigit(s[index]) == false) return false;
            }

            // No nondigits found; it's probably okay.
            return true;
        }


        static void Main(string[] args)
        {
            // Input a string from the keyboard.
            Console.WriteLine("Enter an integer number");
            string s = Console.ReadLine();

            // First check to see if this could be a number.
            if (!IsAllDigits(s)) // Call the special method.
            {
                Console.WriteLine("Hey! That isn't a number");
            }
            else
            {
                // Convert the string into an integer.
                int n = Int32.Parse(s);

                // Now write out the number times 2.
                Console.WriteLine("2 * " + n + " = " + (2 * n));
            }

            Console.Read();
        }
    }
}


/* 
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;

            name = "ABC";
            if (string.IsNullOrEmpty(name)) {
                Console.WriteLine("String is NULL");
            }
            Console.ReadLine();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "chuck";
            string properName = char.ToUpper(name[0]).ToString() + name.Substring(1, name.Length - 1);

            Console.WriteLine("Proper Name: " +properName);
            Console.ReadLine();
        }
            
    }
}
 
namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Each line you enter will be "
                       + "added to a sentence until you "
                       + "enter EXIT or QUIT");

            // Ask the user for input; continue concatenating
            // the phrases input until the user enters exit or
            // quit (start with an empty sentence).
            string sentence = "";

            for (; ; )
            {
                Console.WriteLine("Enter a string ");
                string line = Console.ReadLine();

                // Exit the loop if line is a terminator.
                string[] terms = { "EXIT", "exit", "QUIT", "quit" };

                // Compare the string entered to each of the
                // legal exit commands.
                bool quitting = false;

                foreach (string term in terms)
                {
                    // Break out of the for loop if you have a match.
                    if (String.Compare(line, term) == 0)
                    {
                        quitting = true;
                    }
                }

                if (quitting == true)
                {
                    break;
                }

                // Otherwise, add it to the sentence.
                sentence = String.Concat(sentence, line);

                // Let the user know how she's doing.
                Console.WriteLine("\nyou've entered: " + sentence);
            }

        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.firstName = "Sriram";
            student.lastName = "Bhat";
            Console.WriteLine("Hello World " +student.firstName + " " + student.lastName);

            Console.Write("Press any key to continue... ");
            Console.Read();
        }
    }
}

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your option: ");
            string line = Console.ReadLine().ToLower();
            bool termFound = false;

            string[] terms = { "exit", "quit" };

            foreach (string term in terms)
            {
                if (line.CompareTo(term) == 0)
                {
                    Console.WriteLine(term + " Found");
                    termFound = true;
                    break;
                }
            }

            if (!termFound)
            { 
                Console.WriteLine(line + " Not found");
            }

            Console.WriteLine("Press any key to continue... ");
            Console.ReadLine();
        }
    }
}

*/

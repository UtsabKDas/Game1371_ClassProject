using UnityEngine;

// L6 - Variables, Data Types & Operators  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
public class L6_VariablesDataTypesOperators : MonoBehaviour
{
    void Start()
    {
        // ---------- DECLARING & ASSIGNING ----------

        // Write an example variable declaration for EACH data type
        // (int, float, double, char, bool, string).
        //int i;
        //float f;
        //double d;
        //char c;
        //bool b;
        //string s;


        // Write a declaration with the same name as a previous one.
        // What happens? Why?

        //int s; - Does not compile because can't have two variables with the same name

        // Write examples of variable assignment using the previous declarations.
        // i = 5;
        // f = i;
        // d = f;
        // 
        // c = 'a';
        // b = true;
        // s = "Blargh";

        // Write examples of variable declaration AND assignment on the same line.
        

        // Declare and initialize an int variable.
        int i1 = 0;

        // Declare a second int variable that is initialized with the previous variable.
        int i2 = i1;

        // Declare an int variable. Do NOT initialize it.
        int i3;


        // Declare a second int variable that is initialized with that uninitialized
        //int i4 = i3;

        // variable. What happens? Why?
        // Uninitilaized variables cannot be assigned. 

        // ---------- STRINGS & CHARS ----------

        // Declare a string, set it to "Hello".
        string x = "Hello";


        // Output the length of the string.
        Debug.Log(x.Length);

        // Output each letter in the string one at a time.
        Debug.Log(x[0]);
        Debug.Log(x[1]);
        Debug.Log(x[2]);
        Debug.Log(x[3]);
        Debug.Log(x[4]);


        // Declare a string, try to assign it a value of 1. What happens?


        // Declare a char, try to assign it a value of "Hello". What happens?

        // Declare a string, try to assign it a value of 'I'. What happens?
        string myString = "";

        // Declare a string, try to assign it a value of "I". What happens?

        // Declare an int, try to assign it a value of 1.0. What happens?

        // Declare a float, try to assign it a value of 1. What happens?

        // Assign an int value into a float variable. Does it work? Why?
        // Now assign a float value into an int variable. What happens? Why?

        // ---------- ARITHMETIC OPERATORS ----------

        // Print the result of 10 + 5, 10 - 5, 10 * 5, 10 / 5, and 10 % 3.

        // Print 7 / 2 using two ints. What do you get? Why isn't it 3.5?
        Debug.Log(7 / 2);


        // Print 7 / 2 using two floats (7f / 2f). What do you get now?
        Debug.Log(7f / 2f);

        // Print 7 % 2 and 8 % 2. What is % actually telling you?
        Debug.Log(15 % 6);

        // Print 2 + 3 * 4. Now print (2 + 3) * 4. Why are they different?

        // ---------- ASSIGNMENT & SHORTHAND ----------

        // Start with int x = 10. Use += , -= , *= , /= , %= one at a time,
        // printing x after each. What does each one do?

        // Use ++ and -- on a variable. Print before and after.

        // PRE vs POST: given int i = 5, print (i++) then print i.
        // Then given int j = 5, print (++j) then print j. What is the difference?

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        // int a = 5; int b = a; a = 10; Debug.Log(b);   // what prints? why?
        int a = 5;
        int b = a;
        a = 10;
        Debug.Log(b);


        // int health = 100, damage = 30, potion = 2;
        // health -= damage; health += potion; Debug.Log(health);

        // int coins = 17, players = 4;
        // int each = coins / players; int left = coins % players;
        // Debug.Log(each + " each, " + left + " left over");

        // ---------- PROBLEM SOLVING ----------

        // Given int a = 5 and int b = 9, swap their values WITHOUT a third
        // variable. (Hint: use + and - .) Print a and b to prove it worked.
    }
}

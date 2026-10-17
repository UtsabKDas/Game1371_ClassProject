using UnityEngine;

// L11 - Methods I: Writing & Calling Methods  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
// First, write the methods BELOW Start, and call them FROM Start.
public class L11_MethodsI : MonoBehaviour
{
    // Some fields for our methods to use.
    int health = 100;

    void Start()
    {
        // ---------- CALLING A METHOD ----------

        // Call ShowTitle() twice from here. How many lines print? Why does
        // writing the method once let us reuse it?


        ShowTitle();

        // ---------- PARAMETERS: PASSING INFO IN ----------

        // Call TakeDamage(15). Then call TakeDamage(30). Print health after
        // each. How did the SAME method behave differently?

        // Call ShowRoom("Guard Room", "south, east") to test the two-parameter
        // version. What happens if you swap the two arguments' order?

        // ---------- RETURN: SENDING A RESULT BACK ----------

        // int total = Add(2, 3);  then print total. What is it?

        // Print IsAlive() directly. Now TakeDamage(200) and print IsAlive()
        // again. What changed?

        // ---------- PUTTING IT TOGETHER ----------

        // In order: ShowTitle(); TakeDamage(15); Debug.Log(IsAlive());
        // Read it top to bottom - does Start now read like a plan?

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        // int total = Double(5) + Double(2);  Debug.Log(total);
        // What value does total hold, and why?
    }

    // ---------- WRITE THESE METHODS ----------

    // void ShowTitle() - prints "THE DUNGEON". (A method that returns nothing
    // is a 'void' method.)

    void ShowTitle()
    {
        Debug.Log("===========");
        Debug.Log("THE DUNGEON");
        Debug.Log("===========");

        Debug.Log(health);
        TakeDamage(15);
        Debug.Log(health);

        int total = Add(2, 3);
        TakeDamage(Add(5, 10));
    }


    // void TakeDamage(int amount) - subtracts amount from health, then prints
    // health. (One PARAMETER: information passed in.)

    void TakeDamage(int amount)
    {
        health -= amount;
    }

    void OutputStringXNumOfTimes(string y, int x)
    {
        for(int i = 0; i < x; i++)
        {
            Debug.Log(y);
        }
    }

    // void ShowRoom(string name, string exits) - prints the name, then
    // prints "Exits: " + exits. (TWO parameters.)



    // int Add(int a, int b) - RETURNS a + b. (A return TYPE of int, and a
    // 'return' statement.)

    int Add(int a, int b)
    {
        return a + b;
    }

    // bool IsAlive() - RETURNS health > 0. (Returns a bool - no parameters
    // needed.)

    bool IsAlive()
    {
        return health > 0;
    }

    // int Double(int n) - RETURNS n * 2. (Used by the predict question above.)
}

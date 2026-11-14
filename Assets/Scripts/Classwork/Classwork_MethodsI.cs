using UnityEngine;
// Methods I
// Work through the TODOs. Attach this to an empty GameObject and press Play to test
// (For "write a method" tasks, add the method to THIS class, below Start.)
public class Classwork_Methods_I : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Does this method take input? Does it return a value?
        // TODO     1. void ShowTitle()
        // Answer:  <YOUR ANSWER HERE>
        // TODO     2. int Add(int a, int b)
        // Answer:  <YOUR ANSWER HERE>
        // TODO     3. bool IsEven(int n)
        // Answer:  <YOUR ANSWER HERE>
        // TODO     4. void Heal(int amount)
        // Answer:  <YOUR ANSWER HERE>

        // TODO A2. Write the CALL for each:
        // TODO     5. call ShowTitle()
        // TODO     6. call Add with 4 and 9
        // TODO     7. call Heal with 25
        // TODO     8. store the result of Add(2, 2) in an int called sum

        // TODO A3. Predict the output (write your prediction, then test):
        // TODO     9.  void Say() { Debug.Log("hi"); }
        //              then Say(); Say();
        // Answer:  <YOUR ANSWER HERE>
        // TODO     10. int Twice(int n) { return n * 2; }
        //              Debug.Log(Twice(6));
        // Answer:  <YOUR ANSWER HERE>

        // TODO A4. Fix the bug, then write the corrected version:
        // TODO     11. int Add(int a, int b) { a + b; }       // missing something
        // TODO     12. void Greet(name) { Debug.Log(name); }  // missing something
        // TODO     13. ShowTitle;                             // how do you call it?

        // TODO     14. Write  void PrintExits(string exits)  that prints
        //              "Exits: " + exits.

        // TODO     15. Write  int Square(int n)  that returns n * n.

        // TODO     16. Write  bool IsLowHealth(int hp)  that returns true when hp < 30.

        // TODO     17. MAX OF TWO: int Max(int a, int b) returns the larger.

        Max(5, 3);

        // TODO     18. GREETER: string Greeting(string name) RETURNS
        //              "Hello, <name>!" (returns it, does not print it).

        // TODO     19. IS EVEN: bool IsEven(int n) returns true when n is even.
    }

    // Write your methods for tasks 14-19 here.

    int Max(int a, int b)
    {
        int returnValue = a;
        if (b > a)
        {
            returnValue = b;
        }
        return returnValue;
    }
}
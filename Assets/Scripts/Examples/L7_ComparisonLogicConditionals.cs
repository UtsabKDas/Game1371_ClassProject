using UnityEngine;

// L7 - Comparison, Logic & Conditionals  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
public class L7_ComparisonLogicConditionals : MonoBehaviour
{
    void Start()
    {
        // ---------- COMPARISON OPERATORS ----------

        // Declare two ints, assign them to values of your choice. Print the
        // result of each comparison operator we went through in class.

        // I have two lines of code: bool x = (5 == 5) and bool y = (5 = 5).
        // One of these is a bug. Which, and why?

        // Print the result of "cat" == "cat" and "cat" == "Cat".
        // Are strings case-sensitive here?

        // ---------- LOGICAL OPERATORS ----------

        // Print all four combinations for && :
        // true && true, true && false, false && true, false && false.

        // Print all four combinations for || .

        // Print !true and !false. In words, what does ! do?

        // Given bool hasWeapon = true, hasAmmo = false, print the result of
        // (hasWeapon && hasAmmo) and (hasWeapon || hasAmmo).

        // ---------- IF / ELSE ----------

        // Write an if that prints "You win!" only when a score is above 100.

        // Add an else that prints "Keep trying." otherwise. Change the score
        // and re-run to hit each branch.

        // Write an if WITHOUT braces, then put a second line under it.
        // Is the second line part of the if? Why or why not?

        // ---------- ELSE IF CHAINS ----------

        // Given int health, print "Dead" (<= 0), "Careful!" (< 30), or "Fine".
        // Test each branch. Does the ORDER of the conditions matter? Try
        // reordering them and see what breaks.

        // ---------- COMBINING & NESTING ----------

        // Print "Ready for battle" only when health > 50 AND armor > 10.

        // Write the same check using a NESTED if (an if inside an if).
        // Which is easier to read - the && version or the nested version?

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        // int health = 100;
        // if (health > 0) { Debug.Log("Alive"); }
        // if (health > 50) { Debug.Log("Healthy"); }
        // What prints? (Note: these are two SEPARATE ifs, not if/else.)

        // int health = 25;
        // if (health > 0) { Debug.Log("Alive"); }
        // else if (health < 50) { Debug.Log("Hurt"); }
        // What prints, and what does NOT print? Why?

        // int health = 30; int enemyDistance = 5; bool hasAmmo = true;
        // Write an if/else-if/else using all three that prints a different
        // action for each situation. Predict which one runs.
    }
}

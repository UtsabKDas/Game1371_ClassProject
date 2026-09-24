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

        //int a = 23;
        //int b = 13;
        //
        //Debug.Log(a > b);
        //Debug.Log(a >= b);
        //Debug.Log(a < b);
        //Debug.Log(a <= b);
        //Debug.Log(a != b);
        //Debug.Log(a == b);

        // I have two lines of code: bool x = (5 == 5) and bool y = (5 = 5).
        // One of these is a bug. Which, and why?

        // bool y = (5 = 5) is the bug because you can't assign 5 to 5.

        // Print the result of "cat" == "cat" and "cat" == "Cat".
        // Are strings case-sensitive here?

        //Debug.Log("cat" == "cat");
        //Debug.Log("cat" == "Cat");

        // ---------- LOGICAL OPERATORS ----------

        // Print all four combinations for && :
        // true && true, true && false, false && true, false && false.

        //Debug.Log(true && true);
        //Debug.Log(true && false);
        //Debug.Log(false && true);
        //Debug.Log(false && false);

        // Print all four combinations for || .

        //Debug.Log(true || true);
        //Debug.Log(true || false);
        //Debug.Log(false || true);
        //Debug.Log(false || false);

        // Print !true and !false. In words, what does ! do?

        //Debug.Log(!true);
        //Debug.Log(!false);

        // Given bool hasWeapon = true, hasAmmo = false, print the result of
        // (hasWeapon && hasAmmo) and (hasWeapon || hasAmmo).

        //bool hasWeapon = true;
        //bool hasAmmo = false;
        //
        //Debug.Log(hasWeapon && hasAmmo);
        //Debug.Log(hasWeapon || hasAmmo);

        // ---------- IF / ELSE ----------

        // Write an if that prints "You win!" only when a score is above 100.
        //int score = 200;
        //if (score > 100)
        //{
        //    Debug.Log("You win!");
        //}
        //else
        //{
        //    Debug.Log("Keep trying.");
        //}


        // Add an else that prints "Keep trying." otherwise. Change the score
        // and re-run to hit each branch.

        // Write an if WITHOUT braces, then put a second line under it.
        // Is the second line part of the if? Why or why not?

        //bool isAlive = false;
        //
        //if (isAlive)
        //    Debug.Log("You are alive");
        //    Debug.Log("Hoorah!");
        //
        //
        //
        // ---------- ELSE IF CHAINS ----------

        // Given int health, print "Dead" (<= 0), "Careful!" (< 30), or "Fine".
        // Test each branch. Does the ORDER of the conditions matter? Try
        // reordering them and see what breaks.

        //int health = 20;
        //
        //if(health <= 0)
        //{
        //    Debug.Log("Dead");
        //}
        //else if(health < 30)
        //{
        //    Debug.Log("Careful!");
        //}
        //else
        //{
        //    Debug.Log("Fine");
        //}

        // ---------- COMBINING & NESTING ----------

        // Print "Ready for battle" only when health > 50 AND armor > 10.

        //int health = 40;
        //int armor = 20;
        //
        //if(health > 50 && armor > 10)
        //{
        //    Debug.Log("Ready for battle!");
        //}
        //
        //// Write the same check using a NESTED if (an if inside an if).
        //
        //if (health > 50)
        //{
        //    if (armor > 10)
        //    {
        //        Debug.Log("Ready for battle!");
        //    }
        //}

        // Which is easier to read - the && version or the nested version?

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        //int health = 100;
        //if (health > 0) 
        //{ 
        //    Debug.Log("Alive"); 
        //}
        //if (health > 50) 
        //{ 
        //    Debug.Log("Healthy"); 
        //}

        // What prints? (Note: these are two SEPARATE ifs, not if/else.)

        //int health = 25;
        //if (health > 0) 
        //{ 
        //    Debug.Log("Alive"); 
        //}
        //else if (health < 50) 
        //{ 
        //    Debug.Log("Hurt"); 
        //}
        // What prints, and what does NOT print? Why?

        int goblinAC = 6;
        int goblinHealth = 20;
        int playerStrengthBonus = 2;
        int attackRoll = Random.Range(1, 21);
        int attackRollAndModifier = attackRoll + playerStrengthBonus;

        if(attackRollAndModifier >= goblinAC)
        {
            Debug.Log("Hit Goblin");

            int damageRoll = Random.Range(1, 9);
            int damageRollAndModifier = damageRoll + playerStrengthBonus;
            if (attackRoll == 20)
            {
                Debug.Log("Critical Hit");
                damageRollAndModifier *= 2;
            }
            goblinHealth -= damageRollAndModifier;
        }
        else
        {
            Debug.Log("You Miss!");
        }

    }
}

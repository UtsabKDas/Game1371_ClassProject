using UnityEngine;

// L9 - Arrays & foreach (In-Class Classwork)
// Work through the TODOs in order. Attach this to an empty GameObject and press Play to test.
// Directions:
//   Section A - read the code and write your predicted answer, then test it.
//   Section B - write the code for each task.
//   Section C - solve each mini-interview problem (the approach is up to you).
public class Classwork_Arrays_Foreach : MonoBehaviour
{
    void Start()
    {
        // For Section A, use this array:
        int[] loot = { 5, 10, 15, 20 };

        // ============================================================
        // SECTION A: Trace & Predict (predict, then test)
        // ============================================================
        // A1. loot[0]
        // Answer: <YOUR ANSWER HERE>
        //
        // A2. loot[3]
        // Answer: <YOUR ANSWER HERE>
        //
        // A3. loot.Length
        // Answer: <YOUR ANSWER HERE>
        //
        // A4. loot[loot.Length - 1]
        // Answer: <YOUR ANSWER HERE>
        //
        // A5. loot[4]        (valid, or ERROR?)
        // Answer: <YOUR ANSWER HERE>
        //
        // A6. loot[-1]       (valid, or ERROR?)
        // Answer: <YOUR ANSWER HERE>
        //
        // A7. What does this print?
        //     foreach (int g in loot)
        //     {
        //         Debug.Log(g);
        //     }
        // Answer: <YOUR ANSWER HERE>
        //
        // A8. What does this print?
        //     for (int i = 0; i < 2; i++)
        //     {
        //         Debug.Log(loot[i]);
        //     }
        // Answer: <YOUR ANSWER HERE>

        // ============================================================
        // SECTION B: Application (write the code)
        // ============================================================
        // B1. Declare three arrays (write the full lines):
        //     a) three room names as strings: "Hall", "Vault", "Cell"
        //     b) four potion counts as ints: 2, 4, 6, 8
        //     c) an empty array that holds 5 ints (all start at 0)
        //
        // B2. TOTAL LOOT: add up every value in the loot array above and print
        //     the total.
        //
        // B3. INVENTORY LIST: given a string[] of items, print each item together
        //     with its index, like "0: torch".
        //
        // B4. UPGRADE A SLOT: change the third item of an int[] to a new value,
        //     then print the whole array.

        // ============================================================
        // SECTION C: Mini-Interview (write the code)
        // ============================================================
        // C1. STRONGEST ENEMY: given int[] enemyHealth, find and print the
        //     largest value (don't use a built-in Max).
        //
        // C2. COUNT THE POTIONS: given a string[] of items and a target word
        //     (say "potion"), print how many times the target appears.
        //
        // C3. REVERSE ROLL CALL: given a string[] of party members, print the
        //     names from last to first.
        //
        // C4. SURVIVORS: given int[] enemyHealth, print how many enemies are
        //     still alive (health above 0).
        //
        // C5. SORT THE LOOT: given an int[] of values in any order, rearrange
        //     them so they run from smallest to largest, then print them in order.
        //
        // C6. FIND IN THE SORTED LOOT: using the now-sorted values from C5, look
        //     for a particular value and print whether it is in the list and, if
        //     so, at what index.
        //
        // C7. PALINDROME WORD: given a word (say "level"), print whether it reads
        //     the same forwards and backwards.
    }
}

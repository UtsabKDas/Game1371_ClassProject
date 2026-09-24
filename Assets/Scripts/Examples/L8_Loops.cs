using UnityEngine;

// L8 - Loops  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
// WARNING: a loop with no exit freezes Unity - be ready to trace before you run.
public class L8_Loops : MonoBehaviour
{
    void Start()
    {
        // ---------- WHILE ----------

        // Write a while loop that prints 1, 2, 3, 4, 5. What must change inside
        // the loop so it eventually stops?

        // Write a while loop whose condition starts FALSE. How many times does
        // the body run? Why?

        // ---------- DO-WHILE ----------

        // Write a do-while loop whose condition starts FALSE. How many times
        // does the body run now? How is this different from while?

        // ---------- FOR ----------

        // Write a for loop that prints 0, 1, 2, 3. Point out the three parts:
        // start, condition, step.

        // Change the condition from i < 4 to i <= 4. What changes? (off-by-one)

        // Write a for loop that counts by 2: 0, 2, 4, 6, 8.

        // Write a for loop that counts DOWN from 5 to 1 (step of -1).

        // ---------- FOR vs WHILE ----------

        // Write a for loop AND a while loop that both print 0, 1, 2.
        // In a comment, say when you'd reach for each one.

        // ---------- BREAK & CONTINUE ----------

        // Loop i from 0 to 9. Use break to STOP the loop when i reaches 5.
        // What is the last number printed?

        // Loop i from 0 to 9. Use continue to SKIP printing when i is 3.
        // Which number is missing from the output?

        // Loop i from 0 to 9. Use continue to skip every i where i % 3 == 0.
        // Which numbers print?

        // ---------- NESTED LOOPS ----------

        // Write a loop inside a loop that prints a 3x3 grid of "*".

        // ---------- INFINITE LOOP (trace, do NOT run unless ready) ----------

        // Write (but do not run) a while loop that never ends. In a comment,
        // say what makes it infinite and what single line would fix it.

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        // int score = 0;
        // for (int i = 1; i <= 5; i++) { score += 10; }
        // Debug.Log(score);            // what prints?

        // for (int i = 0; i < 10; i++) { if (i == 3) break; Debug.Log(i); }
        // what numbers print?

        // for (int i = 0; i < 10; i++) { if (i == 3) continue; Debug.Log(i); }
        // what numbers print?

        // ---------- PROBLEM SOLVING ----------

        // Simulate spawning 20 enemies: print "Enemy spawned" for each one,
        // and for every 5th enemy ALSO print "Boss incoming!". (Hint: % .)
    }
}

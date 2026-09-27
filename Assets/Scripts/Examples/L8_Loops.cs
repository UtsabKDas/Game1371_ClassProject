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

        //int num = 1;
        //while(num <= 5)
        //{
        //    Debug.Log(num);
        //    num++;
        //}
        //
        //// Write a while loop whose condition starts FALSE. How many times does
        //// the body run? Why?
        //while(false)
        //{
        //    Debug.Log(num);
        //}
        //
        //
        //
        //// ---------- DO-WHILE ----------
        //
        //// Write a do-while loop whose condition starts FALSE. How many times
        //// does the body run now? How is this different from while?
        //do
        //{
        //    Debug.Log(num);
        //} while (false);
        //
        //
        //// ---------- FOR ----------
        //
        //// Write a for loop that prints 0, 1, 2, 3. Point out the three parts:
        //// start, condition, step.
        //
        //for(int i = 0; i <= 4; i++)
        //{
        //    Debug.Log(i);
        //}
        //
        //// Change the condition from i < 4 to i <= 4. What changes? (off-by-one)
        //
        //// Write a for loop that counts by 2: 0, 2, 4, 6, 8.
        //
        //for(int i = 0; i <= 8; i += 2)
        //{
        //    Debug.Log(i);
        //}
        //
        //for (int i = 0; i < 10; i += 2)
        //{
        //    Debug.Log(i);
        //}
        //
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i * 2);
        //}
        //
        //// Write a for loop that counts DOWN from 5 to 1 (step of -1).
        //for(int i = 5; i > 0; i--)
        //{
        //    Debug.Log(i);
        //}
        //
        //
        //
        //// ---------- FOR vs WHILE ----------
        //
        //// Write a for loop AND a while loop that both print 0, 1, 2.
        //// In a comment, say when you'd reach for each one.
        //
        //for(int i = 0; i < 3; i++)
        //{
        //    Debug.Log(i);
        //}
        //
        //int x = 0;
        //while(x < 3)
        //{
        //    Debug.Log(x);
        //    x++;
        //}
        //
        //// ---------- BREAK & CONTINUE ----------
        //
        //// Loop i from 0 to 9. Use break to STOP the loop when i reaches 5.
        //// What is the last number printed?
        //
        //for(int y = 0; y < 10; y++)
        //{ 
        //    if (y == 5)
        //    {
        //        break;
        //    }
        //    Debug.Log(y);
        //}
        //
        //// Loop i from 0 to 9. Use continue to SKIP printing when i is 3.
        //// Which number is missing from the output?
        //
        //for (int i = 0; i < 10; i++)
        //{
        //    if(i == 3)
        //    {
        //        continue;
        //    }
        //    Debug.Log(i);
        //}
        //
        //
        //// Loop i from 0 to 9. Use continue to skip every i where i % 3 == 0.
        //// Which numbers print?
        //
        //for (int i = 0; i < 10; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        continue;
        //    }
        //    Debug.Log(i);
        //}

        // ---------- NESTED LOOPS ----------

        // Write a loop inside a loop that prints chess position designations

        for(int i = 0; i < 8; i++)
        {
            for (int j = 1; j < 9; j++)
            {
                char boardPositionX = (char)('a' + i);
                int boardPositionY = (j);
                string output = "" + boardPositionX + boardPositionY;
                Debug.Log(output);
            }
        }
        


        // ---------- INFINITE LOOP (trace, do NOT run unless ready) ----------

        // Write (but do not run) a while loop that never ends. In a comment,
        // say what makes it infinite and what single line would fix it.

        while(true)
        {

        }

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

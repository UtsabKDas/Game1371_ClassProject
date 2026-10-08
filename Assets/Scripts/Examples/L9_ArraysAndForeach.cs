using UnityEngine;

// L9 - Arrays & foreach  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
public class L9_ArraysAndForeach : MonoBehaviour
{
    void Start()
    {
        // Declare an int[] called scores holding 10, 20, 30, 40.
        int[] scores = { 10, 20, 30, 40 };
        string[] playerNames = { "Fender", "Olivier", "Hendrix", "Connor" };
        // Print the FIRST item. What index is it? 
        //Debug.Log(scores[0]);
        //
        //// Print the THIRD item. What index did you use?
        //Debug.Log(scores[2]);
        //
        //// Print the LAST item using scores.Length. Write the index expression.
        //Debug.Log(scores[scores.Length - 1]);
        //
        //// Change the second item to 99, then print it.
        //scores[1] = 99;
        //Debug.Log(scores[1]);
        //
        //// Print scores.Length. What does it tell you?
        //Debug.Log(scores.Length);
        //
        //// Try to print scores[4] (one past the end). What happens? Why?
        //// Debug.Log(scores[4]); // Causes an index out of bounds bug
        //
        //// Use new to make an int[] of 5 items without listing values:
        //// int[] slots = new int[5];  Print slots[0]. What default value is in it?
        //int[] slots = new int[5]; // array of {0,0,0,0,0}
        //Debug.Log(slots[0]);
        //slots[0] = 5;
        //
        //// Make a bool[] of 3 with new. What is the default value of each?
        //bool[] newer = new bool[3]; // array of {false, false, false}

        if(scores.Length != playerNames.Length)
        {
            Debug.Log("Scores and player names array lengths are mismatched");
            return;
        }
        // Use a for loop to print every score with its index, like "0: 10".
        for(int i = 0; i < scores.Length; i++)
        {
            Debug.Log(playerNames[i] + "'s Score: " + scores[i]);
        }

        // Use a foreach to print every score (no index).
        foreach(int score in scores)
        {
            if(score == 30)
            {
                continue;
            }
            Debug.Log(score);
        }

        // In a comment: when is foreach nicer than a for loop? When do you NEED
        // a for loop instead?



        // TRY IT: foreach (int h in health) { h += 10; }  then print health[0].
        // Did the array actually change? Why or why not?
        int[] healthValues = { 5, 4, 20, 3 };
        //foreach (int h in healthValues) 
        //{ 
        //    h += 10; 
        //}

        for(int i = 0; i < healthValues.Length; i++)
        {
            healthValues[0] += 10;
        }


        // Given int[] damage = { 4, 8, 15 }, use a foreach to add them all up
        // and print the total.
        int[] damage = { 4, 8, 15 };
        int sum = 0;
        //foreach(int d in damage)
        //{
        //    sum += d;
        //}
        //Debug.Log(sum);


        // Write code that find's the LARGEST value in an int[] and outputs it
        int smallest = int.MaxValue;
        for(int i = 0; i < scores.Length; i++)
        {
            if (scores[i] < smallest)
            {
                smallest = scores[i];
            }
        }
        Debug.Log(smallest);

        int[] a = {0,1,2};
        int[] b = a;
        b[0] = 99;
        Debug.Log(a[0]);

        int[] c = {0,1,2};
        int[] d = (int[])c.Clone();
        d[0] = 99;
        Debug.Log(c[0]);

        // Why are the two above different?

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        // int[] scores = { 10, 20, 30, 40 };
        // Debug.Log(scores[2]);

        // int[] nums = { 4, 8, 15 };
        // int sum = 0;
        // foreach (int n in nums)
        // {
        //      sum += n;
        // }
        // Debug.Log(sum);

        // int[] x = {0,1,2};
        // int[] y = x;
        // y[y.Length/2] = 5;
        // Debug.Log(x[x.Length/2]);
    }
}

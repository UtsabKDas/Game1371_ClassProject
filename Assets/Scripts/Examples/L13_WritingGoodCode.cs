using UnityEngine;

// L13 - Writing Good Code  (guided in-class example)
// Attach to an empty GameObject and press Play. We CLEAN UP code together.
// Most tasks here are about REWRITING code to read better, not new features.
public class L13_WritingGoodCode : MonoBehaviour
{
    void Start()
    {
        // ---------- NAME IT CLEARLY ----------

        // Here is an unclear declaration:  int h = 100;
        // Rewrite it with a clear name. Which reads better to a stranger, and why?
        //   int h = 100;              // unclear
        //   int playerHealth = 100;   // clear

        // ---------- NO MAGIC NUMBERS ----------

        // This line has a "magic number":  health -= 40;   // why 40?
        // Replace 40 with a named constant, then use it:
        //   const int TrapDamage = 40;
        //   health -= TrapDamage;
        // Why is the constant version easier to change later?

        // ---------- DON'T REPEAT YOURSELF (DRY) ----------

        // Imagine you copied these two lines for five different rooms:
        //   Debug.Log("Guard Room");
        //   Debug.Log("Exits: south");
        // Write ONE method ShowRoom(string name, string exits) and call it
        // for two rooms instead of copying. (Add the method below Start.)

        // ---------- ONE METHOD, ONE JOB ----------

        // A method called UpdateAndDraw() does two things at once. Name the TWO
        // methods you would split it into. Why is one-job-per-method better?

        // ---------- COMMENT THE WHY, NOT THE WHAT ----------

        // Compare these two comments on the same line:
        //   health -= 40;  // subtract 40 from health   (says the obvious)
        //   health -= 40;  // spike trap: the deadliest hazard here
        // Which comment is useful? Rewrite a bad "what" comment into a "why".

        // Here is a WHY comment worth keeping - add the clamp under it:
        //   // clamp so health never shows negative
        //   if (health < 0) { health = 0; }

        // ---------- BEFORE AND AFTER ----------

        // Refactor this so a stranger understands it (clear name + constant):
        //   x -= 40;
        // into something like:
        //   health -= TrapDamage;
    }

    // ---------- WRITE THIS METHOD ----------

    // void ShowRoom(string name, string exits) - prints name, then
    // "Exits: " + exits.  (Used by the DRY task above.)
}

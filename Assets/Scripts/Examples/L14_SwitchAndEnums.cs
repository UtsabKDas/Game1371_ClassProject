using UnityEngine;

// L14 - Switch Statements & Enums  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
// Remember: in C#, every non-empty case must end with break.
public class L14_SwitchAndEnums : MonoBehaviour
{
    void Start()
    {
        // ---------- THE PROBLEM: A LONG else-if CHAIN ----------

        // Given string command = "look", write this as if / else-if / else:
        //   "go"   -> Move()   (just Debug.Log("Move") for now)
        //   "look" -> Look()   (Debug.Log("Peer"))
        //   else   -> Debug.Log("Huh?")

        // ---------- THE SAME LOGIC, AS A switch ----------

        // Rewrite the chain above as a switch(command) with cases "go" and
        // "look" and a default. Which version is easier to read as it grows?

        // ---------- WHY EVERY CASE NEEDS break ----------

        // In your switch, delete the break after the "go" case (but keep its
        // Debug.Log). What does the compiler say? (In C# this will NOT compile.)
        // Put the break back.

        // ---------- FALLTHROUGH (and why C# blocks it) ----------

        // Predict: with two cases where the FIRST has code but no break,
        //   case 1: Debug.Log("one");   // no break
        //   case 2: Debug.Log("two"); break;
        // does this compile? In a comment, say what C# does here and why.

        // ---------- GROUPING CASES (the useful kind) ----------

        // Given char letter, write a switch that prints "vowel" for
        // 'a','e','i','o','u' by STACKING the empty cases, and "other" otherwise.
        // Why is stacking empty cases allowed when fallthrough with code is not?

        // ---------- ENUMS: A NAMED SET ----------

        // Declare  enum DoorState { Locked, Unlocked, Open }  (at the bottom of
        // this file, outside the class or inside - your choice).

        // Declare a DoorState vault = DoorState.Locked. Then, if a bool hasKey
        // is true, set vault = DoorState.Unlocked. Print vault.

        // ---------- switch + enum TOGETHER ----------

        // Write a switch(vault) with a case for each DoorState that prints a
        // different message (Locked -> "It rattles.", Unlocked -> "It clicks.",
        // Open -> "You step through.").

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        // string command = "look";
        // switch (command) {
        //   case "go":   Debug.Log("Move"); break;
        //   case "look": Debug.Log("Peer"); break;
        //   default:     Debug.Log("?");    break;
        // }
        // What prints? Which cases are skipped, and why?

        // ---------- THINK IN STATES ----------

        // In a comment, sketch a door's states as a simple diagram:
        // Locked -> Unlocked -> Open, and note what triggers each change.
    }

    // Declare your enum(s) here (e.g. DoorState).
}

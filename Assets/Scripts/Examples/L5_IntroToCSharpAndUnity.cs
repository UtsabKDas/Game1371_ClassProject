using UnityEngine;

// L5 - Intro to C# and Unity  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
public class L5_IntroToCSharpAndUnity : MonoBehaviour
{
    void Start()
    {
        // Print a welcome message to the Console with Debug.Log.
        Debug.Log("Welcome");
        // Print your own name on its own line.
        Debug.Log("Utsab");
        // Remove the semicolon from a Debug.Log line. What error appears? Put it back.

        // Type debug.log("hi") with a lowercase d and l. What happens? Why?
        // (C# is case-sensitive.)
        Debug.Log("hi");
        // Print the number 5 with NO quotes. Now print "5" WITH quotes.
        // Do they look the same in the Console? Are they the same to the computer?
        Debug.Log(5);
        Debug.Log("5");


        // Print a sentence that joins text and a number using + ,
        // e.g. "I have " + 3 + " lives".

        Debug.Log("I have " + 3 + " lives");

        // Print two separate messages with two Debug.Log calls. What order do
        // they appear in?

        // RICH TEXT: print a message using <b>...</b> to make part of it bold.
        Debug.Log("<b>Bold</b>");

        // RICH TEXT: print a message using <color=red>...</color>.
        Debug.Log("<color=red>Red</color>");

        // RICH TEXT: print a message using <size=40>...</size>.
        Debug.Log("<size=40>Big Text</size>");

        // Try Debug.LogWarning("...") and Debug.LogError("...").
        // How does each look different in the Console?
        Debug.LogWarning("...");
        Debug.LogError("...");

        // In your own words (as a comment): what is the difference between
        // Unity, C#, and a script?

        // In your own words (as a comment): what does it mean that our class
        // says ": MonoBehaviour"?
    }

    void Update()
    {
        // Print a short message here. Press Play. What happens in the Console,
        // and why does it happen so many times? (Update runs once per frame.)
        // After you observe it, comment the line out so it stops flooding.

        Debug.Log("Update");
    }
}

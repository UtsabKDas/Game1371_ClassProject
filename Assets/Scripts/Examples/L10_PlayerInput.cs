using UnityEngine;
using UnityEngine.InputSystem;

// L10 - Player Input: Keyboard & Mouse  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
// Input is read every frame, so most of our work goes in Update().

public class L10_PlayerInput : MonoBehaviour
{

    public InputAction moveUp, moveDown, moveLeft, moveRight;
    void Start()
    {
        // Print a one-time "The dungeon awaits. Move with N." message.
        // Why does a one-time message belong in Start and NOT in Update?
    }

    void Update()
    {
        // ---------- READING A KEY ----------

        // When the N key is pressed this frame, print "You go north."
        //   if (Keyboard.current.wKey.wasPressedThisFrame) { ... }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("You Move North");
        }

        // Put a Debug.Log at the very top of Update (outside any if). Press Play.
        // How many times does it print, and why? Comment it out afterward.

        // ---------- wasPressedThisFrame vs isPressed ----------

        // Use Keyboard.current.spaceKey.wasPressedThisFrame to print "Tap!"
        // Then use Keyboard.current.spaceKey.isPressed to print "Held..."
        // HOLD the space bar. Which message repeats, and which fires once? Why?

        // ---------- READING THE MOUSE ----------

        // When the LEFT mouse button is pressed this frame, print "Left click!"
        //   if (Mouse.current.leftButton.wasPressedThisFrame) { ... }

        Debug.Log(Mouse.current.delta.ReadValue());

        // Do the same for the RIGHT mouse button ("Right click!").

        // ---------- INPUT + CONDITIONALS ----------

        // Space -> print "Attack!", ELSE IF right mouse -> print "Block!".
        //   if (Keyboard.current.spaceKey.wasPressedThisFrame) { ... }
        //   else if (Mouse.current.rightButton.wasPressedThisFrame) { ... }
        // Can BOTH branches run on the same frame? Why or why not?

        // ---------- WALKING THE DUNGEON ----------

        // Track an int currentRoom (declare it as a field above Start).
        // When N is pressed, set currentRoom = 1 and print "Guard Room."
        // Add S to go back to room 0 ("Entrance Hall."). Guard against going
        // below 0 or above your last room.

        // ---------- NEW vs OLD INPUT ----------

        // In a comment, write the OLD-Input-class equivalent of each new call:
        //   Keyboard.current.spaceKey.wasPressedThisFrame  ->  ?
        //   Mouse.current.leftButton.wasPressedThisFrame   ->  ?
        // (We use the new system; you just need to RECOGNIZE the old one.)

        // ---------- COMMON MISTAKES (predict, then test) ----------

        // Move an input check into Start() instead of Update(). What happens
        // when you press the key? Why?

        // Use wasPressedThisFrame for a key you want to HOLD to keep moving.
        // Why does the movement feel wrong? What should you use instead?
    }
}

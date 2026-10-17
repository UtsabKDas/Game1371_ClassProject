using UnityEngine;

// L12 - Methods II: How Methods Behave  (guided in-class example)
// Attach to an empty GameObject and press Play. We fill in the answers together.
// This lecture is about SCOPE (where variables live), optional parameters, and
// overloading. Write the methods below Start and call them from Start.
public class L12_MethodsII : MonoBehaviour
{
    int health = 100;      // a FIELD - visible to every method in this class
    int gold = 0;
    int goblinHealth = 30;

    void Start()
    {
        // ---------- WHAT IS SCOPE? ----------

        // Inside a method Attack(), declare int damage = 10. Then try to print
        // 'damage' HERE in Start. What error appears? Why is damage "gone"?

        // ---------- LOCAL VARIABLES vs FIELDS ----------

        // Call Hit(). It uses a LOCAL int blow = 5 to lower the FIELD health.
        // Print health before and after. Why can Hit see health but Start
        // cannot see blow?

        // ---------- PARAMETERS ARE LOCAL TOO ----------

        // Call AddGold(10). Inside, amount is changed (amount = amount + 1)
        // before adding to gold. Print gold. Did changing 'amount' inside the
        // method affect anything the caller passed? Why not?

        // ---------- OVERLOADING: SAME NAME, DIFFERENT INPUTS ----------

        // Call Attack();  then call Attack(25);  Print goblinHealth after each.
        // How does C# know WHICH Attack to run each time?

        // ---------- OPTIONAL PARAMETERS ----------

        // Call Heal();  then call Heal(25);  Print health after each.
        // What value does Heal() use when you pass nothing? Why?

        // ---------- PREDICT THE OUTPUT (trace, then run) ----------

        // Starting health is 100. Heal() is called, then Heal(30) is called.
        // What is health now? How much total healing happened?
    }

    // ---------- WRITE THESE METHODS ----------

    // void Attack() - calls Attack(10). (This is the no-argument overload.)

    // void Attack(int damage) - subtracts damage from goblinHealth.
    // (Same NAME as above, different PARAMETERS = overloading.)

    // void Hit() - declares a local int blow = 5, then does health -= blow.

    // void AddGold(int amount) - does amount = amount + 1; then gold += amount.

    // void Heal(int amount = 10) - does health += amount. (OPTIONAL parameter:
    // the caller may leave it out and get the default 10.)
}

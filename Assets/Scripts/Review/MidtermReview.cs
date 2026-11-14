using UnityEngine;
// MIDTERM REVIEW: 
// Replay the whole dungeon in Start() using arrays and methods.
// Fill in the run, write the methods below, and press Play after each step.
public class MidtermReview : MonoBehaviour
{
    // MEMBER VARIABLES
    string playerName = "Hero";
    int health = 100;
    int attack = 5;
    int defense = 0;
    int armorClass = 12;

    int gold = 0;
    bool hasKey = false;
    int itemCount = 0;
    int openSlotIndex = 0;
    int criticalHitRoll = 20;

    // CONSTANTS
    const int standardDieSides = 20;
    const int critMultiplier = 2;
    const int potionPrice = 5;
    const int maxHealth = 100;
    const int maxGold = 999;
    const int criticalHealth = 30;
    const int woundedHealth = 60;
    const string healthMessageCritical = "Critical";
    const string healthMessageWounded = "Wounded";
    const string healthMessageHealthy = "Healthy";

    // ROOMS / ROOM INFO
    string[] roomNames =
    {
        "The Entrance Hall", 
        "The Guard Room", 
        "The Flooded Passage",
        "The Armoury", 
        "The Treasure Room", 
        "The Goblin's Den",
        "The Campfire", 
        "The Old Study", 
        "The Sunlit Gate"
    };
    string[] roomDescriptions =
    {
        "A torch flickers on the wall; a doorway leads north.",
        "A rusty sword rests on a table, and a key glints beside it.",
        "Ankle-deep water fills the hall; a spike trap waits underfoot.",
        "Dented armour lines the walls; a sturdy shield still hangs here.",
        "Raided long ago, but a few coin piles still glint in the dust.",
        "A goblin blocks the way, blade bared. The fight begins!",
        "A ring of cold stones, just right for a short rest.",
        "A dusty desk stands here, its drawers shut tight.",
        "An iron portcullis stands between you and the daylight beyond."
    };
    int[] roomGold = { 12, 0, 0, 0, 30, 0, 0, 0, 0 };
    bool[] roomVisited = new bool[9];

    // ENEMIES - Index 0 is Goblin, Index 1 is Giant Spider
    string[] enemyNames = { "Goblin", "Giant Spider" };
    int[] enemyHealth = { 20, 24 };
    int[] enemyAttack = { 8, 6 };
    int[] enemyDefense = { 2, 1 };
    int[] enemyArmorClass = { 10, 13 };

    // INVENTORY
    string[] inventory = new string[6]; // Max inventory capacity of six, starts with ""

    void Start()
    {
        int currentRoom = 0;
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins.");
        
        // ROOM 0  Entrance Hall
        // Show the room's name and description.
        ShowRoom(currentRoom);
        // Pick up the gold in this room.
        FindGold(roomGold[currentRoom]);
        // Add the torch to your pack.
        AddItem("torch");

        // Move to next Room
        currentRoom++;

        // ROOM 1  Guard Room
        // Show the room.
        ShowRoom(currentRoom);
        // Take the rusty sword (it raises your attack) and add it to your pack.
        AddItem("rusty sword");
        // Grab the rusty key, add it to your pack, and remember that you have it.
        AddItem("key");

        currentRoom--;
        ShowRoom(currentRoom);

        // ROOM 2  Flooded Passage
        // Show the room.
        // Step on the spike trap and take the damage.

        // ROOM 3  Armoury
        // Show the room.
        // Take the shield (it raises your defense) and add it to your pack.

        // ROOM 4  Treasure Room
        // Show the room.
        // Pick up the gold in this room.
        // Loot the four coin piles, one at a time.
        // Work out how many potions you could buy and how much gold is left over.

        // ROOM 5  Goblin's Den
        // Show the room.
        // Fight the goblin.

        // ROOM 6  Campfire
        // Show the room.
        // Rest a while to recover some health.

        // ROOM 7  Old Study
        // Show the room.
        // Search the drawers one by one until you find the spare key.

        // ROOM 8  Sunlit Gate
        // Show the room.
        // Check a discount on a price without spending your real gold.
        // List everything in your pack.
        // Count the closing gate down from five to one.
        // If you have the key and you are still alive, unlock the gate and
        //   escape; otherwise, explain why you are stuck.
        // Count how many rooms you explored.
    }

    // METHODS
    // Write each one. The stubs let the file compile before you fill them in.

    // Print the room's name and description, and mark the room as visited.
    void ShowRoom(int index)
    {
        Debug.Log(roomNames[index]);
        if (!roomVisited[index])
        {
            Debug.Log(roomDescriptions[index]);
            roomVisited[index] = true;
        }
    }

    // Add gold to the hero and report the new total.
    void FindGold(int amount)
    {
        gold += amount;
        gold = Mathf.Clamp(gold, 0, maxGold);
    }

    // Put an item into the next open inventory slot.
    void AddItem(string item)
    {
        if (openSlotIndex < inventory.Length)
        {
            inventory[openSlotIndex++] = item;
        }
        else
        {
            Debug.Log("Inventory is full");
        }
    }

    // Lower the hero's health, then report the hero's condition.
    void TakeDamage(int amount)
    {

    }

    // Return
    // "Critical" (if health less than 30),
    // "Wounded" (if health less than 60), or
    // "Healthy" (any other health)
    string HealthStatus()
    {
        string status = healthMessageHealthy;
        if(health < criticalHealth)
        {
            status = healthMessageCritical;
        }
        else if(health >= criticalHealth && health < woundedHealth)
        {
            status = healthMessageWounded;
        }
        return status;
    }

    // Return a roll of a 20-sided die.
    int RollDice()
    {
        return Random.Range(1, standardDieSides + 1);
    }

    void WaitRounds()
    {
        int rounds = 0;
        rounds ++;
    }

    void WaitRounds(int amount)
    {
        int rounds = 0;
        rounds += amount;
    }

    // Overload: return a roll from 1 up to the given number of sides.
    int RollDice(int sides)
    {
        return Random.Range(1, sides + 1);
    }

    //// ENEMIES - Index 0 is Goblin, Index 1 is Giant Spider
    //string[] enemyNames = { "Goblin", "Giant Spider" };
    //int[] enemyHealth = { 20, 24 };
    //int[] enemyAttack = { 8, 6 };
    //int[] enemyDefense = { 2, 1 };
    //int[] enemyArmorClass = { 10, 13 };

    // Fight the enemy at enemyIndex, trading blows until one side falls.
    void Combat(int enemyIndex)
    {
        Debug.Log("You fight a " + enemyNames[enemyIndex]);
        int round = 1;
        while(health > 0 && enemyHealth[enemyIndex] > 0)
        {
            int heroAttackRoll = RollDice();
            string roundMessage = "Round "+ round + ": You rolled a " + heroAttackRoll + ". ";
            if(heroAttackRoll + attack >= enemyArmorClass[enemyIndex])
            {
                int damage = attack;
                if(heroAttackRoll >= criticalHitRoll)
                {
                    damage *= critMultiplier;
                }
                damage -= enemyDefense[enemyIndex];
                enemyHealth[enemyIndex] -= damage;
                roundMessage += "You deal " + damage + " damage. ";
            }
            else
            {
                roundMessage += "You miss. ";
            }
            if (enemyHealth[enemyIndex] > 0)
            {
                int enemyRoll = RollDice();
                if (enemyRoll + enemyAttack[enemyIndex] >= armorClass)
                {
                    int damage = enemyAttack[enemyIndex];
                    if (enemyRoll >= criticalHitRoll)
                    {
                        damage *= critMultiplier;
                    }
                    damage -= defense;
                    health -= damage;
                    roundMessage += enemyNames[enemyIndex] + " deals " + damage + " damage. ";
                }
                else
                {
                    roundMessage += enemyNames[enemyIndex] + " misses. ";
                }
            }
            Debug.Log(roundMessage);
            round++;
        }

        if (enemyHealth[enemyIndex] < 0)
        {
            Debug.Log("The " + enemyNames[enemyIndex] + " is defeated!");
        }
        else
        {
            Debug.Log("You are defeated");
        }
    }

    // Rest for a number of turns (3 by default), healing each turn.
    void Rest(int turns = 3)
    {

    }

    // Preview a discount on a price. The caller's own value is left unchanged.
    void PreviewDiscount(int price)
    {

    }
}
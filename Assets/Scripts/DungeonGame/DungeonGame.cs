using UnityEngine;

public class DungeonGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        const int goldInHall = 12;
        const int swordBonus = 7;
        const int trapDamage = 20;
        const int shieldBonus = 4;
        const int treasureGold = 11;
        const int potionPrice = 5;

        string playerName = "Hero";
        int playerHealth = 100;
        int attack = 5;
        int agility = 3;
        int gold = 0;
        bool hasKey = false;
        int defense = 0;
        int goblinHealth = 20;
        int goblinAttack = 8;
        int goblinDefense = 2;

        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins.");

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        
        if(goldInHall < 10)
        {
            Debug.Log("Just a few coins");
        }
        else
        {
            Debug.Log("A decent purse");
        }
            
        gold += goldInHall;
        Debug.Log("You gather some coins. Gold is now " + gold + ".");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        attack += swordBonus;
        Debug.Log("You take the sword. Attack is now " + attack + ".");

        Debug.Log("");
        Debug.Log("The goblin wakes and charges after you!");
        playerHealth -= goblinAttack - defense;
        if(playerHealth <= 0)
        {
            playerHealth = 0;
            Debug.Log("Game Over");
            return;
        }
        else if(playerHealth < 30)
        {
            Debug.Log("You are badly wounded");
        }
        else
        {
            Debug.Log("Tis but a flesh wound");
        }
        Debug.Log("The goblin hits you. Your health is now " + playerHealth + ".");
        goblinHealth -= attack - goblinDefense;
        Debug.Log("You strike back. Goblin health is now " + goblinHealth + ".");
        if (goblinHealth <= 0)
        {
            Debug.Log("Goblin is Dead");
        }
        else
        {
            Debug.Log("The goblin is wounded but still on its feet.");
        }
        hasKey = true;
        Debug.Log("You grab the rusty key. hasKey is now " + hasKey + ".");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Flooded Passage");
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        playerHealth -= trapDamage;
        if (playerHealth <= 0)
        {
            playerHealth = 0;
            Debug.Log("Game Over");
            return;
        }
        else if (playerHealth < 30)
        {
            Debug.Log("You are badly wounded");
        }
        else
        {
            Debug.Log("Tis but a flesh wound");
        }
        Debug.Log("You step on a spike trap! Health is now " + playerHealth + ".");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Armory");
        Debug.Log("Dented armor lines the walls. A sturdy shield still hangs here.");
        defense += shieldBonus;
        Debug.Log("You take the shield. Defense is now " + defense + ".");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Treasure Room");
        Debug.Log("It seems this room has been raided, but some coins remain.");
        gold += treasureGold;
        Debug.Log("You collect the coins. Gold is now " + gold + ".");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Merchant's Nook");
        Debug.Log("A hooded trader sells healing potions for " + potionPrice + " gold each.");
        int affordable = gold / potionPrice;
        int change = gold % potionPrice;
        Debug.Log("You can afford " + affordable + " potions, with " + change + " gold left over.");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Sunlit Gate");
        Debug.Log("Daylight pours through an iron portcullis - the way out of the dungeon!");
        if (hasKey)
        {
            Debug.Log("You step through and escape into the open air.");
        }
        else
        {
            Debug.Log("You can't open the gate. You must go back and find the key");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

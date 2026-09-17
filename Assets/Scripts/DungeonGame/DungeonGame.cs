using UnityEngine;

public class DungeonGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hero Info
        string playerName = "Utsab";
        int health = 100;
        int attack = 5;
        int gold = 0;

        Debug.Log("==== DUNGEON GAME ====");
        Debug.Log("Welcome, " + playerName + ". Your escape begins.");

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        int goldLootInEntranceHall = 50;
        Debug.Log("You find " + goldLootInEntranceHall + " gold.");
        gold += goldLootInEntranceHall;
        Debug.Log("You now have " + gold + " gold.");
        Debug.Log("You move into the next room");

        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner");
        Debug.Log("Goblin wakes up");
        int goblinAttack = 2;
        int goblinHealth = 5;
        Debug.Log("The goblin hits you for " + goblinAttack + " damage");
        health -= goblinAttack;
        Debug.Log("You attack for " + attack + " damage");
        goblinHealth -= attack;
        Debug.Log("You move into the next room");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

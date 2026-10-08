using UnityEngine;

public class Review1 : MonoBehaviour
{
    void Start()
    {
        // ==================================================================
        // PART A  -  TRACE & PREDICT     (predict the output, then check)
        // ==================================================================

        // A1. int division and remainder
        // int arrows = 23;
        // int quivers = 5;
        // Debug.Log(arrows / quivers);
        // Debug.Log(arrows % quivers);
        // My answer: ______________________________________

        // A2. compound assignment - trace mana step by step
        // int mana = 4;
        // mana += 6;
        // mana *= 3;
        // mana -= 5;
        // mana /= 6;
        // mana %= 3;
        // Debug.Log(mana);
        // My answer: ______________________________________

        // A3. logical operators in a game context
        // bool hasTorch = true;
        // bool inDark = true;
        // int enemies = 2;
        // bool canRest = !inDark && enemies == 0;
        // bool needLight = inDark && !hasTorch;
        // bool safeish = hasTorch || enemies < 3;
        // Debug.Log(canRest + " " + needLight + " " + safeish);
        // My answer: ______________________________________

        // A4. else-if chain - which ONE runs?
        // int enemies = 4;
        // if (enemies == 0)
        // {
        //     Debug.Log("Clear");
        // }
        // else if (enemies <= 3)
        // {
        //     Debug.Log("Skirmish");
        // }
        // else
        // {
        //     Debug.Log("Swarm");
        // }
        // My answer: ______________________________________

        // A5. while - what are the TWO final values printed?
        // int enemies = 40;
        // int rounds = 0;
        // while (enemies > 1)
        // {
        //     enemies = enemies / 2;
        //     rounds++;
        // }
        // Debug.Log(enemies + " " + rounds);
        // My answer: ______________________________________

        // ==================================================================
        // PART B  -  FIX THE BUG    (write the fix + a // note on what was wrong)
        // ==================================================================

        // B1. Meant: Dead at 0 or below, Low under 30, otherwise Fine.
        //90int hp = 10;
        //90
        //90if (hp <= 0)
        //90{
        //90    Debug.Log("Dead");
        //90}
        //90else if (hp < 30)
        //90{
        //90    Debug.Log("Low Health");
        //90}
        //90else
        //90{
        //90    Debug.Log("Fine");
        //90}

        // B2. Average of three scores.
        //int a = 90, b = 85, c = 78;
        //double average = (a + b + c) / 3;
        //Debug.Log(average);

        // B3. Meant to fight while BOTH still have health.
        int heroHP = 30;
        int goblinHP = 20;
        while (heroHP > 0 && goblinHP > 0)
        {
            heroHP -= 5;
            goblinHP -= 7;
        }



        // ==================================================================
        // PART C  -  APPLICATION
        // ==================================================================

        // C1. GOLD RUSH: a vault is collapsing. Each turn you grab a random 3-8
        //     gold and add it to your total. The moment your total reaches 40 or
        //     more, or if 5 turns pass, stop grabbing right then and escape.
        //     Simulate this using what we have learned. 
        int turns = 5;
        int gold = 0;
        while(turns > 0 && gold < 40)
        {
            gold += Random.Range(3,9);
            turns -= 1;
        }
        Debug.Log("You escaped. You got " + gold + " gold!");

        // C2. MONSTER FIGHT: you have 100 health, you fight a monster with 30
        //     health. Each of your attacks deals a random 4-9 damage. Every other
        //     turn, the monster attacks deal a random 3-5 damage. Keep attacking
        //     until the monster or player is defeated, printing each hit and the
        //     monster's and player's remaining health then once one dies, print
        //     how many attacks it took (if the player wins, output the number
        //     of attacks the player did. If the monster wins, output the number
        //     of attacks the monster did)

        int health = 100;
        int monsterHealth = 30;
        int attacks = 0;
        int monsterAttacks = 0;


        int n = 1;
        for (int m = 1; ; m++)
        {
            Debug.Log("You attack!");
            attacks++;
            int damage = Random.Range(4, 10);
            Debug.Log("You deal " + damage + " damage!");
            monsterHealth -= damage;
            Debug.Log("The monster has " + monsterHealth + " health remaining.");
            if (monsterHealth <= 0)
            {
                Debug.Log("You defeated the monster in " + attacks + " hits!");
                break;
            }

            if (m % 2 == 1)
            {
                Debug.Log("The monster attacks!");
                monsterAttacks++;
                int monsterDamage = Random.Range(3, 6);
                Debug.Log("The monster deals " + monsterDamage + " damage!");
                health -= monsterDamage;
                Debug.Log("You have " + health + " health remaining.");
                if (health <= 0)
                {
                    Debug.Log("You were defeated in " + monsterAttacks + " hits!");
                    break;
                }
            }
        }




        // ==================================================================
        // PART D  -  MINI-INTERVIEW: Solve with what we've learned so far
        // ==================================================================

        // D1. TRAP OR TREASURE: for turns 1 to 50, every 4th turn print "Trap",
        //     every 7th turn print "Treasure", a turn that is both prints
        //     "Jackpot", and any other turn prints the turn number.

        for(int turn = 1; turn <= 50; turn++)
        {
            if (turn % 7 == 0 && turn % 4 == 0)
            {
                Debug.Log("Jackpot");
            }
            else if (turn % 7 == 0)
            {
                Debug.Log("Treasure");
            }
            else if (turn % 4 == 0)
            {
                Debug.Log("Trap");
            }
            else
            {
                Debug.Log(turn);
            }
        }

        // D2. REVERSE A NUMBER: given int n (try 1234), print its digits reversed
        //     (4321). Use math, not text.

        // D3. OMEN YEARS: on the planet Vashti a year is an "Omen year" when it is
        //     divisible by 5. But if it is also divisible by 25 the omen is broken
        //     and it is an "Ordinary year" - UNLESS it is divisible by 100, which
        //     makes it a "Great omen". Given an int year (try 15, 25, and 100),
        //     print which kind of year it is.

        // D4. COUNT THE WORDS: a string is just a row of characters you can walk
        //     through one index at a time (word[0], word[1], ... up to
        //     word.Length - 1). Given a sentence (try "the sunless keep awaits")
        //     whose words are separated by single spaces, print how many words it
        //     contains.
    }
}
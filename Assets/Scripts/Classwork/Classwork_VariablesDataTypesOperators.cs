using UnityEngine;

// Variables, Data Types & Operators
// Attach this to an empty GameObject and press Play. Work through the TODOs.
public class Classwork_VariablesDataTypesOperators : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Declare a variable of the RIGHT type (write the full line):
        // TODO   1. arrows: 12
        int arrowCount = 12;

        // TODO   2. player's name: Kael
        string playerName = "Kael";

        // TODO   3. gate is open: true
        bool isGateOpen = true;

        // TODO   4. a single grade letter: B
        char gradeLetter = 'B';

        // TODO   5. move speed: 4.5
        double moveSpeed = 4.5;

        // TODO   6. a precise price: 19.99
        float precisePrice = 19.99f;


        // TODO A2. Name the TYPE (int / float / double / char / bool / string):
        // TODO   7. number of potions: int
        // TODO   8. character name: string
        // TODO   9. is the door locked: bool
        // TODO   10. one keyboard key as a letter: char

        // TODO A3. Compute the result (write the value as a comment):
        // TODO   11. 8 + 5 = 13
        // TODO   12. 15 / 4 = 3
        // TODO   13. 20 % 6 = 2
        // TODO   14. 10 % 2 = 0
        // TODO   15. 2 + 3 * 4 = 14
        // TODO   16. (2 + 3) * 4 = 20

        // TODO A4. Rewrite each with a COMPOUND operator:
        // +=, -=, *=, /=, %=
        // TODO   17. score = score + 100;
        int score = 0;
        score += 100;

        // TODO   18. health = health - 20;
        int health = 100;
        health -= 20;

        // TODO   19. speed = speed * 2;
        //int speed = 5;
        //speed *= 2;

        // TODO   20. lives = lives - 1;   (also show the -- form)
        int lives = 3;
        lives -= 1;
        lives--;

        // TODO A5. PREDICT the final value (write it as a comment):
        // TODO   21.   int x = 10;
        //              x += 5;
        //              x -= 3;
        //              12

        // TODO   22.   int h = 100;
        //              h -= 30;
        //              h += 2 * 20;
        //              110

        // TODO 23. Declare four stats for a MONSTER (name, health, attack,
        //          alive) with proper types, then print them on one line.
        string monsterName = "John";
        int monsterHealth = 10;
        int monsterAttack = 10000000;
        bool monsterIsAlive = true;

        Debug.Log("Name: " + monsterName + ", Health: " + monsterHealth + " , Attack: " + monsterAttack + ", Alive: " + monsterIsAlive);

        // TODO 24. int health = 100; apply a 25 hit, a 40 heal, a 60 hit with
        //          compound operators, printing health after each. What three
        //          numbers appear?
        int health24 = 100;
        health24 -= 25;
        Debug.Log(health24);
        health24 += 40;
        Debug.Log(health24);
        health24 -= 60;
        Debug.Log(health24); // 115 - 60 = 55

        // TODO 25. Fix each broken line, then write the corrected version:
        double speed = 5.5;
        string name = "Aria";
        int g = 20;


        // TODO 26. SWAP: int a = 3; int b = 8; write code that swaps them so
        //          a becomes 8 and b becomes 3. Try this first with an extra
        //          variable, then do it without any other variables.

        int a = 3;
        int b = 8;

        int c = a;
        a = b;
        b = c;

        a += b;     // a is 11
        b = a - b;  // b is 3
        a -= b;     // a is 8

        // TODO 27. SECONDS TO CLOCK: given int totalSeconds, print hours, 
        //          minutes and seconds: e.g. if totalSeconds is set to:
        //              125, output is "2m 5s"
        //              3600, output is "1h"
        //              10000, output is "2h 46m 40s"

        int totalSeconds = 10000;
        int hours = totalSeconds / 3600;
        int leftoverSeconds = totalSeconds % 3600;
        int minutes = leftoverSeconds / 60;
        leftoverSeconds = leftoverSeconds % 60;
        int seconds = leftoverSeconds;

        Debug.Log(hours + "h " + minutes + "m " + seconds + "s");
    }
}

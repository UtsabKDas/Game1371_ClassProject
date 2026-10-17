using UnityEngine;
// Methods II in-class walkthrough. Minigame: COIN RUSH (a platformer).
// Part 1: write our own methods. Part 2: refactor the repeated level code.
// Attach to an empty GameObject and press Play after each step.
public class L12_Methods_II_Extra : MonoBehaviour
{
    int score = 0;
    int coins = 0;
    int lives = 3;
    int nextLifeScore = 1000;   // the next score that earns a bonus life

    void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log(score);
        while(score >= nextLifeScore)
        {
            nextLifeScore += 1000;
            AddLives();
        }
    }

    void AddScore(int scoreToAdd, bool isBonusActive)
    {
        if(isBonusActive)
        {
            scoreToAdd *= 2;
        }
        AddScore(scoreToAdd);
    }

    void AddCoin()
    {
        coins++;
        AddScore(100);
        Debug.Log("Grabbed a coin! Coins: " + coins + ", Score: " + score);
    }

    void StompEnemy()
    {
        AddScore(200);
        Debug.Log("Stomped an enemy! Score: " + score);
    }

    void AddLives(int livesToAdd = 1)
    {
        lives += livesToAdd;
    }

    bool IsDead()
    {
        return lives <= 0;
    }

    void RemoveLife()
    {
        lives--;
        if(IsDead())
        {
            Debug.Log("GAME OVER!");
        }
        else
        {
            Debug.Log("Lives left: " + lives);
        }
    }

    void SpendCoins()
    {
        coins -= 5;
    }

    void SpendCoins(int inputCoins)
    {
        inputCoins -= 5;
    }


    void Start()
    {
        Debug.Log("=== COIN RUSH ===");
        { 
        // ===================== PART 1: WRITE OUR OWN METHODS =====================
        /* A1. Write a method that adds a given number of points to the score and
        //     prints the new score. Inside the same method, award a bonus life:
        //     when the score reaches nextLifeScore (declared above), add a life
        //     and raise nextLifeScore so that you gain a life after the next 1000
        //     points added to your score. Call it with 100 to test. */

        AddScore(10000);

        /*// A2. Write a method for grabbing a coin: it adds 1 to coins, awards 100
        //     points, and prints the coin count. Call it.*/

        AddCoin();

        // A3. Write a method for stomping an enemy: it awards 200 points. Call it.

        StompEnemy();


        // A4. OVERLOADING. Write a second version of your add points method with
        //     the same name and one extra true/false parameter for whether a Star
        //     bonus is active. When it is true, add double the points. (One name
        //     covers the normal case and the doubled case.) Test it with a normal
        //     call and a doubled call.
        AddScore(100, true);
        AddScore(100, false);
        

        // A5. OPTIONAL PARAMETER. Write a method that gives the player extra lives
        //     and prints the new total, where the amount defaults to 1 when the
        //     caller passes nothing. (The default keeps the common call short.)
        //     Call it once with nothing and once with 3.

        AddLives();
        AddLives(5);
        
        // A6. RETURN VALUE and a DECISION. Write a method that returns true when
        //     lives is 0 or less.
        //
        //     Write another method that removes one life, then with if/else prints 
        //     "GAME OVER!" when you are out of lives, otherwise print the lives left. 
        //     (A method can hand back an answer your code acts on.)
        //     Call the remove a life method a few times.

        RemoveLife();
        }
        // A7. PARAMETERS ARE LOCAL. Write a method that takes a number of coins to
        //     spend, subtracts 5 from that number inside the method, and prints it.
        //     Make a variable set to coins, pass it in, then print your variable
        //     again. It is unchanged. (A parameter is the method's own copy, while
        //     member variables like score are shared.)

        SpendCoins();
        SpendCoins(coins);

        // ===================== PART 2: REFACTOR THE LEVEL CODE =====================
        // The level below was written the slow way, with the same lines copied for
        // every coin and enemy. It works, but it is long, and changing one rule
        // means editing many spots. Replace it using the methods from Part 1.


        void CollectCoins(int numOfCoins)
        {
            for(int i = 0; i < numOfCoins; i++)
            {
                AddCoin();
            }
        }

        CollectCoins(3);
        void StompEnemies(int numOfEnemies)
        {
            StompEnemy();
        }

        StompEnemies(2);

        // B1. Replace the three coin blocks with a for loop that collects a coin
        //     three times.

        // B2. Replace the two enemy blocks with two calls to your stomp method.

        // B3. The level now reads as a short list of actions instead of repeated
        //     math. What could I do instead of calling these multiple times?
    }

    // ---------- WE WRITE OUR METHODS DOWN HERE (below Start) ----------

}
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
        //     enemies /= 2;
        //     rounds++;
        // }
        // Debug.Log(enemies + " " + rounds);
        // My answer: ______________________________________

        // ==================================================================
        // PART B  -  FIX THE BUG    (write the fix + a // note on what was wrong)
        // ==================================================================

        // B1. Meant: Dead at 0 or below, Low under 30, otherwise Fine.
        // int hp = 10;
        // if (hp < 100)
        // {
        //     Debug.Log("Fine");
        // }
        // else if (hp < 30)
        // {
        //     Debug.Log("Low Health");
        // }
        // else if (hp <= 0)
        // {
        //     Debug.Log("Dead");
        // }

        // B2. Average of three scores.
        // int a = 90, b = 85, c = 78;
        // float average = (a + b + c) / 3;
        // Debug.Log(average);

        // B3. Meant to fight while BOTH still have health.
        // int heroHP = 30;
        // int goblinHP = 20;
        // while (heroHP > 0 || goblinHP > 0)
        // {
        //     heroHP -= 5;
        //     goblinHP -= 7;
        // }

        // ==================================================================
        // PART C  -  APPLICATION
        // ==================================================================

        // C1. GOLD RUSH: a vault is collapsing. Each turn you grab a random 3-8
        //     gold and add it to your total. The moment your total reaches 40 or
        //     more, or if 5 turns pass, stop grabbing right then and escape.
        //     Simulate this using what we have learned. 

        // C2. MONSTER FIGHT: you have 100 health, you fight a monster with 30
        //     health. Each of your attacks deals a random 4-9 damage. Every other
        //     turn, the monster attacks deal a random 3-5 damage. Keep attacking
        //     until the monster or player is defeated, printing each hit and the
        //     monster's and player's remaining health then once one dies, print
        //     how many attacks it took (if the player wins, output the number
        //     of attacks the player did. If the monster wins, output the number
        //     of attacks the monster did)

        // ==================================================================
        // PART D  -  MINI-INTERVIEW: Solve with what we've learned so far
        // ==================================================================

        // D1. TRAP OR TREASURE: for turns 1 to 50, every 4th turn print "Trap",
        //     every 7th turn print "Treasure", a turn that is both prints
        //     "Jackpot", and any other turn prints the turn number.

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

        // ==================================================================
        // PART E  -  EXTRA PRACTICE  (OPTIONAL: fast finishers / homework)
        // ==================================================================

        // --- more Trace & Predict ---
        // E1. increment: post (wave++) vs pre (++wave)
        //     int wave = 3;
        //     int shown = wave++;
        //     int next = ++wave;
        //     Debug.Log(shown + " " + next + " " + wave);
        //     My answer: ______________________________________
        //
        // E2. three separate ifs - which run?
        //     bool locked = true;
        //     bool trapped = false;
        //     bool glowing = true;
        //     if (locked)
        //     {
        //         Debug.Log("It's locked.");
        //     }
        //     if (trapped)
        //     {
        //         Debug.Log("A trap springs!");
        //     }
        //     if (glowing)
        //     {
        //         Debug.Log("It glows faintly.");
        //     }
        //     My answer: ______________________________________
        //
        // E3. do-while - how many times does the body run?
        //     int potions = 0;
        //     int drunk = 0;
        //     do
        //     {
        //         drunk++;
        //         potions--;
        //     }
        //     while (potions > 0);
        //     Debug.Log(drunk);
        //     My answer: ______________________________________
        //
        // E4. string operations
        //     string spell = "Fireball";
        //     Debug.Log(spell.Length);
        //     Debug.Log(spell.ToLower());
        //     Debug.Log(spell[spell.Length - 1]);
        //     Debug.Log(spell.Substring(0, 4));
        //     My answer: ______________________________________

        // --- more Fix the Bug ---
        // E5. Meant to print the odd numbers 1..9.
        //     int i = 1;
        //     while (i <= 9)
        //     {
        //         if (i % 2 == 0)
        //         {
        //             continue;
        //         }
        //         Debug.Log(i);
        //         i++;
        //     }
        //
        // E6. Meant to print each letter of the word
        //     string word = "sword";
        //     for (int j = 0; j <= word.Length; j++)
        //     {
        //         Debug.Log(word[j]);
        //     }
        //
        // E7. Meant to count down from 5 to 1
        //     for (int k = 5; k > 0; k++)
        //     {
        //         Debug.Log(k);
        //     }

        // --- more Application ---
        // E8. COMBO METER: you land some number of hits in a row. Each hit is
        //     worth 10 points, but every 5th hit is a combo worth double (20).
        //     Print the running score after each hit, then the final score based
        //     on a variable number of hits. 
        // E9. TORCH SUPPLY: you have some gold; torches cost 7 each. Print how
        //     many torches you can buy and how much gold is left over. If nothing
        //     is left over, also print "Perfect change!"

        // --- more Mini-Interview ---
        // E10. SUM OF SQUARES: given int n (try 5), print 1*1 + 2*2 + ... + n*n. (55)
        // E11. FACTORIAL: given int n (try 6), print n! = 1 * 2 * ... * n. (720)
        // E12. SUM OF DIGITS: given int n (try 472), print the sum of its digits.
        // E13. PERFECT NUMBER: given int n (try 28), a number is "perfect" when its
        //      divisors below it add up to itself (28 = 1+2+4+7+14). Print whether
        //      n is perfect.
        // E14. FIBONACCI: print the first n numbers of the Fibonacci sequence
        //      (each is the sum of the previous two, starting 0, 1).
        // E15. GCD: given two ints a and b (try 48 and 36), print their greatest
        //      common divisor (the largest number that divides both evenly).
        // E16. NUMBER PALINDROME: given int n (try 12321), print whether it reads
        //      the same forwards and backwards.
        // E17. COLLATZ: given int n (try 6), repeat until n becomes 1: if n is
        //      even, halve it; if odd, do 3*n + 1. Print each value, then the
        //      number of steps it took.
        // E18. REVERSE A STRING: given a string word (try "dungeon"), print it
        //      backwards.
        // E19. COUNT VOWELS: given a string phrase, print how many vowels
        //      (a, e, i, o, u) it contains.

        // --- more string parsing (walk the characters by index) ---
        // E20. COUNT A LETTER: given a word (try "sunless") and a letter (try
        //      's'), print how many times that letter appears.
        // E21. STRING PALINDROME: given a word (try "level"), print whether it
        //      reads the same forwards and backwards by comparing the characters
        //      at both ends and working inward.
        // E22. CENSOR THE VOWELS: given a word (try "dungeon"), build and print a
        //      new string that is the same but with every vowel replaced by a '*'
        //      (so "dungeon" becomes "d*ng**n").
    }
}
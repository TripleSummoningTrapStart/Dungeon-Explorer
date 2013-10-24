/*BasicDiceSystem.Cs
 * Author: Josh Reed And David Gabriel
 * 
 * This Script takes in a string separated by a d giving the number of times to roll the type of dice and the type of dice it should roll
 * it will then generate a random number to simulate the roll of a die and add it to the sum repeating the sepecified amount of times and
 * returns that sum
 * */
using UnityEngine;
using System.Collections;

public class BasicDiceSystem : MonoBehaviour {
	  
	  /// <summary>
	  /// Roll the specified dice.
	  /// </summary>
	  /// <param name='dice'>
	  /// string containing the number of rolls and the type of die
	  /// </param>
      public static int Roll(string dice)
      {
		// splits the string into 2 parts
        string[] rollType = dice.Split('d');
		
		//the number of specified rolls
        int numOfRolls = int.Parse(rollType[0]);
		
		//the type of die specified
        int typeOfDice = int.Parse(rollType[1]);
		
		//the total of the rolls
		int sum = 0;
		
		// random number generator
		System.Random rand = new System.Random(); 
		
		// rolls a simulated die for the specified number of times
		for (int i = 0; i < numOfRolls; i++)
		{
			sum += rand.Next(1, typeOfDice);
		}	 

        return sum;
      }
}

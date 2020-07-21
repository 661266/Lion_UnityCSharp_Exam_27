/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    
    public GameObject[] characters;
    
    private List<int> usedNumbers;
    public int number;
    void Start()
    {
        
        int randomNumber = Random.Range(1, characters.Length);
        
        foreach (GameObject character in characters)
        {
      
            while (usedNumbers.Contains(randomNumber) {
                randomNumber = Random.Range(1, characters.Length);
            }
            
            usedNumbers.Add(randomNumber);
            
            character.GetComponent<CharacterController>().number = randomNumber;
        }
    }
}*/

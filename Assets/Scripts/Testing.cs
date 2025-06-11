using System;
using UnityEngine;

public class Testing : MonoBehaviour
{   // start of the code for this class. We use this to comment out. 
    // the character ; represents the end of a line of code.  
    int age = 10; //an integer will be a whole number, which can be changed. Think of a counter or player lives
    double weight = 72.5; // a decimal point number
    float weightTwo = 72.5f; // float is used for countdowns, speeds and player controls. Uses less memory than a double
    char firstInitial = 'I'; // a single character - we use sing quotation mark
    string firstName = "Keith"; // a string is a collection or array, so we can enter multiple characters
    bool isCompleted = true; // used to check if a value is true or false. E.g., is player alive or not? If not then end game.

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            Console.WriteLine("tested");
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            Console.WriteLine("False test");
        }

    }
} //End of teh scope for this class

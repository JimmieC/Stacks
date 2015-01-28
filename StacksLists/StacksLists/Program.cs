using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace StacksLists
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 100; a++) //For loop so every time the user has tried to parse an input the question "Text to parse: " is printed again. This way the application will repeat itself untill manually closed
            {
                Stack theStack = new Stack(); //Create new object of class Stack
                string theString; //Declare a string called theString which will be used to store the input of the user



                Console.Write("Text to Parse: "); //Print "Text to Parse: " in the console
                theString = Console.ReadLine(); // The users input will be stored in string theString

                for (int i = 0; i < theString.Length; i++) //Another for loop that goes through every character in the string the user inputs from left to right.  
                {
                    
                    char eachChar; //Declare variable char eachChar
                    eachChar = theString[i]; //the variable eachChar is equal to the character in the users input string, position equal to the value currently in the for loop

                    if ((eachChar == '(') || (eachChar == '{') || (eachChar == '[')) //If the eachChar is equal to ( or { or [ 
                    {
                        theStack.Push(eachChar); // then call the method push from theStack which will place the ( or { or [ on top of the stack
                    }
                    if ((eachChar == ')') || (eachChar == '}') || (eachChar == ']')) // If the eachChar is equal to ) or } or ] 
                    {
                        if (theStack.stackCountGet() >= 1) //If the stacks count is greater then or equal to one
                        {
                           
                            
                            object test = theStack.Peek(); //Then declared object test is equal to the method Peek which returns the value on top of the stack
                            if (theStack.Peek() != null) //If the top of the stack is not equal to null
                            {
                                if ((test.ToString() == "(") && (eachChar == ')') || (test.ToString() == "{" && eachChar == '}') || (test.ToString() == "[" && eachChar == ']')) //If sats to check whether the top of the stack is the opposite equivelent to the eachChar in this round of the for loop
                                {
                                    theStack.Pop(); //If it is ex. ) is the eachChar and ( is the top of the stack, then this method will call to take the item on top of the stack off
                                }
                                else
                                {
                                    theStack.stackCountTerminate(); //Otherwise call terminate method to make value of count 99
                                }

                            }
                            
                        }
                        else
                        {
                            theStack.stackCountTerminate(); // If the stack is equal to or greater then one then 
                        }                             
                    }

                }
                if (theStack.stackCountGet() == 0) //If the stack count is eqaul to zero then the users input was correct
                {
                    Console.WriteLine("Succesful!");//Write in the console that succesful
                    Console.Beep(1000, 300); //Nice Sound to associate with succes
                 
                }
                else
                {
                    Console.WriteLine("No good!"); //Otherwise if the stack count is not zero 
                    Console.Beep(500, 300); //Tune to associate with failure
                    Console.Beep(400, 500);
                }



                
                
            }            
            
   

            


        }
    }
}

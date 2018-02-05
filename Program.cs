using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    int n, sumN = 0, sumND = 0;
		    
		    UserInput.Input(out n);
		
            Console.WriteLine("Superperfect numbers within the range from 1 to {0}:", n);
		
            for (int i = 1; i <= n; i++) //loop through each number from 1 to n
            {
                for (int j = 1; j <= i/2; j++) //looking for the dividers of each number
                {
                    if (i % j == 0) sumN += j;
                }
                sumN += i; //finally add to the sum of dividers the number itself as its last divider

                for (int j = 1; j <= sumN/2; j++) //looking for the dividers of sumN
                {
                    if (sumN % j == 0) sumND += j;
                }
                sumND += sumN; //finally add to the sum of dividers the number itself as its last divider
			
                if (sumND == i * 2) //check the number (i) for superpefect features
                {
                    Console.WriteLine(i);
                }
                sumN = 0; //sum reset
                sumND = 0; //sum reset
            }	
		}
	}
	
	class UserInput
    {
    	public static void Input(out int x)
    	{
	    	x = 1;
	    	//Console.Write("Enter the max of the range (from 1 to max): ");
	    	try
	    	{
		    	x = int.Parse(Console.ReadLine());
		    	if (x < 1)
		    	{
		    		Console.WriteLine("Wrong input. You should enter a positive integer number.");
			    	Environment.Exit(0);
			    }
		    }
		    catch (Exception e)
		    {
			    Console.WriteLine("Wrong input. You should enter a positive integer number.");
			    Console.WriteLine(e);
		    }
	    }
    }
}
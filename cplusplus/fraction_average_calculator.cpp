// DigiOz Multimedia
// Creation Date: 5/29/03
//
// This program uses the same class as was used in Lab Exercise
// 7 and 8. The purpose of this program is to allow a user to 
// enter a number of fractions through the keyboard. These 
// fractional numbers, will then be added together to obtain a total 
// for all the fractions entered by the user. The total is then 
// divided by the number of fractions entered by the user to 
// calculate the Average of these sets of fractions. 
//
// This program has been constructed through multiple files. In 
// other words, there is a seperate file for the class definition,
// one for the members functions, and another for the driver of it.
//
//
// Table of Variables:
// -------------------
// num       = Numerator of the fraction (a) or (c) or result
// denom     = Denominator of the fraction (b) or (d) or result
// dummychar = Dummy Character that contains the fraction symbol
// total     = Object of type fraction that holds total of fractions
// avg       = Object of type fraction that holds average of fractions
// fract[n]  = N-th Array Element from Array fract
// response  = Contains a Y or N depending if the user wants to 
//             continue calculating another set of fractions
// i         = Counter Variable for loop
// n         = Number of fractions entered by user to program

#include <iostream>

using namespace std;

#include "pr8_cd.h"


int main()
{
	const int SIZE=100;
	fraction fract[SIZE];                     // Array of size 100 defined
	fraction avg, total;                      // Two fraction objects created

	int n=0;
	char response;

	
	cout << "                    Fraction Average Calculation Program\n";
	cout << "                    ------------------------------------\n\n";


	while (response != 'N')
	{
		
		cout << endl;

		for(int i=0; i<=SIZE; i++) 
		{
			cout << n+1 << ". ";
			fract[i].getfraction();               // stores fraction in array
			fract[i].lowterms();                  // reduces it to lowest term
			
			if (fract[i].endloop == 1)            // Allows the user to break
			{                                     // through the loop if he 
				break;                            // is done entering all the
				fract[i].endloop = 0;             // fractions for the Average
			}

			n++;

		}



		total = fract[0];             // initializing total to first array element

		for(i=1; i<=n; i++)
		{
			total.gettotal(fract[i]); // Adding up all fractions for array element
		}                             // 0 to N for our total value

		avg.getaverage(total, n);     // Calculating total Average of fractions

		total.lowterms();             
		avg.lowterms();

		cout << "Total = ";
		total.showfraction();         // Showing the total of all fractions
		cout << "\n";

		cout << "Average = ";
		avg.showfraction();           // Showing the average of all fractions
		cout << "\n";
		
		
		cout << "\nCalculate Another Average of Group of Fractions? (Y/N) ";
		cin >> response;              // Allowing user to average another set of 
		cout << "\n\n";               // fractions without exiting the program


	}


	return 0;
}

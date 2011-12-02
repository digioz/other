// DigiOz Multimedia 
// Creation Date: 5/20/03
//
// The purpose of this program is to generate a table of multiplication
// given a specific denominator of a fraction. 
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
// fract1    = First Fraction Object for column header printing
// fract2    = Second Fraction Object for column header printing
// fract3    = Relult Fraction Object for column header printing
// fract4    = FirstFraction Object for row header printing
// fract5    = Second Fraction Object for row header printing
// fract6    = Result Fraction Object for row header printing
// fract7    = First Fraction Object for table body printing
// fract8    = Second Fraction Object for table body printing
// fract9    = Result Fraction Object for table body printing
// response  = Contains a Y or N depending if the user wants to 
//             continue calculating another set of fractions
// i         = Counter Variable for rows
// j         = Counter Variable for columns
// n         = Denominator entered by user for table generation
//

#include <iostream>

using namespace std;

#include "pr8_cd.h"


int main()
{
	char response;
	int i;
	int j;
	int n;

	cout << "                Fraction Multiplication Table Generator Program\n";
	cout << "                -----------------------------------------------\n\n";


	while (response != 'N')
	{

		cout << "Please Enter an integer denominator for the fraction\n";
		cin >> n;
		cout << "\n";
		cout << "     ";

		for(i=0; i<n-1; i++)        // loop to create header of the table
		{
			fraction fract1(i, n);
			fraction fract2(1, n);
			fraction fract3;
			fract3.addition(fract1, fract2, fract3);
			fract3.lowterms(fract3);
			cout << "\t";
			fract3.showfraction(fract3);
			
			if (i+1 == n-1)
			{ cout << "\n"; }

		}

		cout << "----------";

		for(i=1; i<n; i++)        // loop to underline the table header                   
		{
			cout << "-------";

			if (i+1 == n)
			{ cout << endl; }

		}

		for (j=1; j<n; j++)       // Double loop for creating body of table
		{
			fraction fract4(j-1, n);
			fraction fract5(1, n);
			fraction fract6;
			fract6.addition(fract4, fract5, fract6);
			fract6.lowterms(fract6);
			fract6.showfraction(fract6);
			
			for (i=1; i<n; i++)
			{
				
				fraction fract7(j, n);
				fraction fract8(i, n);
				fraction fract9;
				fract9.multiply(fract7, fract8, fract9);
				fract9.lowterms(fract9);
				cout << "\t";
				fract9.showfraction(fract9);
				

				if (i+1 == n)
				{ cout << "\n"; }


			}

		}


		cout << "\nCalculate Another (Y or N)? ";
		cin >> response;
		cout << "\n\n";


	}


	return 0;
}

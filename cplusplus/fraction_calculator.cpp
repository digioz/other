// DigiOz Multimedia
// Creation Date: 4/15/03
//
// The purpose of this program is to create an interface 
// through which users can add, subtract, divide, and 
// multiply two fractional numbers together. For this 
// program to function, the user is prompted to enter 
// the operation that is to be calculated in the format
// (a/b + c/d) on the keyboard, where the sign '+' can
// be replaced with either a '-', '*' or a '/' to perform
// the respective mathematical operation. The program then
// calculates the results from one of the following equations:
//
//        a/b + c/d = (a*d + b*c) / (b*d)
//        a/b - c/d = (a*d - b*c) / (b*d)
//        a/b * c/d = (a*c) / (b*d)
//        a/b / c/d = (a*d) / (b*c)
//
// The divisor and the divident of the result are then assigned 
// to two different variables, which are displayed on the 
// screen as the result of the calculation.
// 
// This program is part 2 of a 3 part exercise and closely
// follows exercise 12 in chapeter 3 of the Lafore Book. It is 
// a modification of part 1 of the lab exercise.  
//
// Table of Variables:
// -------------------
// a         = Numerator of the first fraction
// b         = Denominator of the first fraction
// c         = Numerator of the second fraction
// d         = Denominator of the second fraction
// dummychar = Dummy Character that contains the fraction symbol
// divisor   = Numerator of the resulting fraction
// divident  = Denominator of the resulting fraction
// sign      = Variable containing the respective operation to be
//             performed by the program
// response  = Contains a Y or N depending if the user wants to 
//             continue calculating another set of fractions

#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
	int a, b, c, d;
	char dummychar;
	char sign;
	char response;
	int divisor, divident;

	while (response != 'N')
	{
		cout << "Enter Fraction,Operator,Fraction (form a/b + c/d): ";
	    cin >> a >> dummychar >> b >> sign >> c >> dummychar >> d;
	    cout << "\n";

		switch (sign)
		{
		case '+':
			divisor = a*d + b*c;
			divident = b*d;
			break;
		case '-':
			divisor = a*d - b*c;
			divident = b*d;
			break;
		case '*':
			divisor = a*c;
			divident = b*d;
			break;
		case '/':
			divisor = a*d;
			divident = b*c;
			break;
		}

		cout << "Result of the fraction is: " << divisor << "/" << divident << "\n\n";

		cout << "Calculate Another (Y or N)? ";
		cin >> response;
		cout << "\n\n";

	}

	return 0;
}

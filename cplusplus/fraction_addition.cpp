// DigiOz Multimedia
// Creation Date: 4/15/03
//
// The purpose of this program is to create an interface 
// through which users can add two fractional numbers 
// together. For this, program to function, the user is 
// first prompted to enter the first fraction in the form
// of a/b, then the second fraction in the form of c/d. 
// The program then calculates the addition of these two 
// fractions using the equation ((a*d)+(b*c))/(b*d). 
// The divisor and the divident are assigned to two 
// different variables, which are then displayed on the 
// screen as the result of the calculation.
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

#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
	int a, b, c, d;
	char dummychar;
	int divisor, divident;

	cout << "Enter First Fraction (form a/b): ";
	cin >> a >> dummychar >> b;
	cout << "\n";

	cout << "Enter Second Fraction (form c/d): ";
	cin >> c >> dummychar >> d;
	cout << "\n";

	divisor = a*d + b*c;
	divident = b*d;


	cout << "Result of the fraction is: " << divisor << "/" << divident << "\n\n";

	return 0;
}











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
// Table of Variables:
// -------------------
// fract1.num       = Numerator of the first fraction (a)
// fract1.denom     = Denominator of the first fraction (b)
// fract2.num       = Numerator of the second fraction (c)
// fract2.denom     = Denominator of the second fraction (d)
// fract1.dummychar = Dummy Character that contains the fraction symbol 1
// fract2.dummychar = Dummy Character that contains the fraction symbol 2
// divisor.result   = Numerator of the resulting fraction
// divident.result  = Denominator of the resulting fraction
// sign.sign        = Variable containing the respective operation to be
//                    performed by the program
// response.response= Contains a Y or N depending if the user wants to 
//                    continue calculating another set of fractions

#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

////////////////////////////////////////////////////////////////
struct fraction
{
	int num;
	int denom;
	int result;
	char dummychar;
	char sign;
	char response;
};
////////////////////////////////////////////////////////////////

int main()
{
	fraction fract1, fract2, sign, divisor, divident, response;

	while (response.response != 'N')
	{
		cout << "Enter Fraction,Operator,Fraction (form a/b + c/d): ";
	    cin >> fract1.num >> fract1.dummychar >> fract1.denom
			>> sign.sign >> fract2.num >> fract2.dummychar 
			>> fract2.denom;
	    cout << "\n";

		switch (sign.sign)
		{
		case '+':
			divisor.result = fract1.num*fract2.denom + fract1.denom*fract2.num;
			divident.result = fract1.denom*fract2.denom;
			break;
		case '-':
			divisor.result = fract1.num*fract2.denom - fract1.denom*fract2.num;
			divident.result = fract1.denom*fract2.denom;
			break;
		case '*':
			divisor.result = fract1.num*fract2.num;
			divident.result = fract1.denom*fract2.denom;
			break;
		case '/':
			divisor.result = fract1.num*fract2.denom;
			divident.result = fract1.denom*fract2.num;
			break;
		}

		cout << "Answer= " << divisor.result << "/" 
			 << divident.result << "\n\n";

		cout << "Calculate Another (Y or N)? ";
		cin >> response.response;
		cout << "\n\n";

	}

	return 0;
}

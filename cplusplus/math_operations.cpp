// DigiOz Multimedia
// Creation Date: 3/20/03
//
// The purpose of this program is to take two numeric variables
// through the keyboard and return the sum, product, difference 
// and quotient of the two numbers to the screen. 
//
// Table of Variables:
// -------------------
// num1 = First Numeric variable Entered by user through keyboard
// num2 = Second Numeric variable Entered by user through keyboard
// sum  = Sum of the two numbers 
// product = product of the two numbers 
// difference = difference of the two numbers
// quotient = quotient of the two numbers
//

#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double num1;
	double num2;
	double sum, product, difference, quotient;

	cout << "Enter First Number: ";
	cin >> num1;
	cout << "Enter Second Number: ";
	cin >> num2;
	cout << "\n\n";

	sum = num1 + num2;
	product = num1 * num2;
	difference = num1 - num2;
	quotient = num1 / num2;

	cout << "The Sum of the two numbers is: ";
	cout << sum;
	cout << "\n";
	cout << "The Product of the two numbers is: ";
	cout << product;
	cout << "\n";
	cout << "The Difference of the two numbers is: ";
	cout << difference;
	cout << "\n";
	cout << "The Quotient of the two numbers is: ";
	cout << quotient;
	cout << "\n\n";

	return 0;

}

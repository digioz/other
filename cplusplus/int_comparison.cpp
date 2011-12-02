// DigiOz Multimedia
// Creation Date: 4/3/03
//
// The purpose of this program is to compare several integers 
// with each other and print the smallest of them to the screen.
// The number of integers to be compared will be entered by the
// user along with the first integer. The remaining integers will
// then be entered from the inside of an if statement one by one
// and compared to the previous integer to find the smallest of 
// each pair. 
//
// Table of Variables:
// -------------------
// j        = loop counter
// counter  = The total number of integers to be compared
// number   = The integer number entered by the user
// smallest = Smallest integer entered by the user
// 
//

#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
	int j;
	int counter;
	int number;
	int smallest;

	cout << "Enter the number of integers you wish to compare (at least two): ";
	cin >> counter;
	cout << "\n";

	cout << "Enter integer number 1: ";
	cin >> smallest;

	for (j=2; j<=counter; j++)
	{
		cout << "Enter integer number " << j << ": ";
		cin >> number;

		if (number < smallest)
		{
			smallest = number;		
		
		}
		
	}
	

	cout << "\n";
	cout << "The smallest integer you entered was " << smallest << endl;
	cout << "\n";
	

	return 0;

}


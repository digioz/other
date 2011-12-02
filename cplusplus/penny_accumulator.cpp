// DigiOz Multimedia
// Creation Date: 3/27/03
//
// The purpose of this program is to calculate the accumulated
// value of pennies after each day, if we were to be given one 
// penny to start the first day, and double each previous day 
// thereafter for a certain number of days specified by the user.
// We would also like to know after how many days will we make at
// least $1,000,000.  
//
// Table of Variables:
// -------------------
// days       =  number of days the user wants to 
//               calculate accumulation of pennies for
// dday       =  the day you will have at least $1,000,000
// added      =  number of pennies added each day
// total      =  total number of pennies added so far
// sum        =  total value of pennies added so far
//


#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
	int i=1;
	int days;
	int dday;
	int added=1;
	double total=1;
    double sum=0.01;

	cout << "Enter Number Of Days to Calculate Accumulation: ";
	cin >> days;
    cout << " \n\n";
	cout << setw(6) << "Days" << setw(15) << "Value" 
		 << setiosflags(ios::fixed) << setiosflags(ios::showpoint) 
		 << setprecision(2) << endl;
	cout << "---------------------" << endl;

	while (i <= days)
	{
		cout << setw(6) << i << setw(15) << sum 
			 << setiosflags(ios::fixed) << setiosflags(ios::showpoint) 
			 << setprecision(2) << endl;

		added *= 2;
		total += added;
		sum = total / 100;
		i++;

		if (sum < 1000000)
		{
			dday = i + 1;
		}
	}

	cout << "\n\n";
	cout << "You will make at least $1,000,000 on day " << dday;
	cout << "\n\n";

	return 0;

}


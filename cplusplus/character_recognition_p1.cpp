// DigiOz Multimedia
// Creation Date: 3/20/03
//
// The purpose of this program is to take a single character
// through the keyboard as an argument, return a non-zero 
// integer if the letter is lowercase, or a zero if the letter
// is uppercase. 
//
// Table of Variables:
// -------------------
// data1 = User character input through the keyboard
//


#include <iostream>
#include <cmath>
#include <cctype>
using namespace std;

int main()
{
	char data1;
	int answer;

	cout << "Please Enter a Character through the Keyboard: ";
	cin >> data1;
	cout << " \n\n";

	answer = islower(data1);

	cout << "Your answer is ";
	cout << answer;
	cout << " \n\n";

	return 0;

}


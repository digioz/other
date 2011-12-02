// DigiOz Multimedia
// Creation Date: 6/03/03
//
// The purpose of this program is to obtain an array string
// (word) from the user through the keyboard, and display the 
// first and last letter of the word on the screen. If the first 
// letter in the word entered by the user begins with a consonant,
// the first character of the word is moved to the last position
// and append "ay" is added to the end of it. However, if the 
// word begins with a vowel, the program simply adds an "ay" to 
// the end of the word.  
//
// Table of Variables:
// -------------------
// s1    = String Array Variable Input by user
// s2    = String Array Variable that holds the first letter of the
//         string input by user
// s3    = String Array Variable that holds user input minus the 
//         first letter of the input array
// s4    = String Array Variable that holds "ay" inside it
// n     = Variable that contains the first array element number 
//         that does not contain a vowel (aeiouAEIOU) inside it
// count = Loop Counter which exits the loop once 5 words are 
//         entered by the user

#include <iostream>
#include <string>
using namespace std;

int main()
{

	string s1, s2, s3;           // Defining string objects
	string s4("ay");             // string object with preset value
	int n=0;
	int count=1;

	cout << "                       Pig Latin String Converter\n";
	cout << "                       --------------------------\n\n";
	
	do
	{
		cout << "Enter a word: ";
		cin >> s1;

		s2=s1[0];                // value of s2 to first array element
		s3=s1;                   
		s3.erase(0,1);

		cout << "The first and last letter of "
		     << s1 << " are "
		     << s2 << " and " << s1[s1.size()-1] << "\n";
  
	    n = s1.find_first_not_of("aeiouAEIOU");
		s2 = s1[0];

	    if(n != 1)
		{
			cout << "In Pig Latin, the word is " << s3 << s2 << s4;
		}
		else
		{
			cout << "In Pig Latin, the word is " << s1 << s4;
		}
	
	    cout << "\n\n";

 

		count++;

	} while (count < 6);



	return 0;

}


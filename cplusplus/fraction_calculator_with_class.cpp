// DigiOz Multimedia
// Creation Date: 5/13/03
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
// to two different variables. Those values are then simplified
// to the lowest terms, which are then displayed on the screen
// as the result of the calculation.
//
// Table of Variables:
// -------------------
// num       = Numerator of the first fraction (a)
// denom     = Denominator of the first fraction (b)
// dummychar = Dummy Character that contains the fraction symbol
// sign      = Variable containing the respective operation to be
//              performed by the program
// fract1    = Fraction Object variable 1
// fract2    = Fraction Object variable 2
// fract3    = Fraction Object variable 3
// response  = Contains a Y or N depending if the user wants to 
//              continue calculating another set of fractions

#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

///////////////////////////// fraction Class ///////////////////////////////
class fraction
{

private:
	int num;
	int denom;
	char dummychar;


public:

	fraction() : num(0), denom(0)
	{  }                                  // Constructor

	void getfraction()                    // Input fractions and sign
	{
		cout << "Please Enter Fraction: ";
	    cin >> num >> dummychar >> denom;
	    cout << "\n";
	}

	
	void addition(fraction& fr1, fraction& fr2, fraction& fr3);  // decl. of addition function
	void subtract(fraction& fr1, fraction& fr2, fraction& fr3);  // decl. of subtract.function
	void multiply(fraction& fr1, fraction& fr2, fraction& fr3);  // decl. of multipl. function
	void divide(fraction& fr1, fraction& fr2, fraction& fr3);    // decl. of division function
	void lowterms(fraction& fr3);               // declaration of lowterms function
		
	void showfraction(fraction& fr3)            // Display result on the screen
	{
		cout << "Answer= " << fr3.num << "/" 
			 << fr3.denom << "\n\n";
	}


};

// ------------------------------ Addition ------------------------------

void fraction::addition(fraction& fr1, fraction& fr2, fraction& fr3)
{
	fr3.num = fr1.num*fr2.denom + fr1.denom*fr2.num;
	fr3.denom = fr1.denom*fr2.denom;
}

// ----------------------------- Subtraction-----------------------------

void fraction::subtract(fraction& fr1, fraction& fr2, fraction& fr3)
{
	fr3.num = fr1.num*fr2.denom - fr1.denom*fr2.num;
	fr3.denom = fr1.denom*fr2.denom;
}

// ---------------------------- Multiplication---------------------------

void fraction::multiply(fraction& fr1, fraction& fr2, fraction& fr3)
{
	fr3.num = fr1.num*fr2.num;
	fr3.denom = fr1.denom*fr2.denom;
}

// ------------------------------ Division ------------------------------

void fraction::divide(fraction& fr1, fraction& fr2, fraction& fr3)
{
	fr3.num = fr1.num*fr2.denom;
	fr3.denom = fr1.denom*fr2.num;
}

// ------------------------ Lowest Term Function ------------------------

void fraction::lowterms(fraction& fr3)                  // Simplify to lowest terms
		{
			long tnum, tden, temp, gcd;

			tnum = labs(fr3.num);
			tden = labs(fr3.denom);
			
			if(tden==0)
			{ cout << "Illegal fraction: division by 0 \n"; exit(1); }
			else if(tnum==0)
			{ fr3.num=0; fr3.denom=1; return; }

			while(tnum != 0)
			{
				if(tnum < tden)
				{ temp=tnum; tnum=tden; tden=temp; }
			tnum = tnum - tden;
			}
		gcd = tden;
		fr3.num = fr3.num / gcd;
		fr3.denom = fr3.denom / gcd;

		}

char getsign();                        // declaration of getsign function

//////////////////////////////////////////////////////////////////////////

int main()
{
	fraction fract1, fract2, fract3;
	char response;
	char sgn;



	while (response != 'N')
	{

		fract1.getfraction();
		fract2.getfraction();
		sgn = getsign();
		

		switch (sgn)                   // Arithmetic Switch
		{
		case '+':
			fract3.addition(fract1, fract2, fract3);
			break;
		case '-':
			fract3.subtract(fract1, fract2, fract3);               
			break;
		case '*':
			fract3.multiply(fract1, fract2, fract3);             
			break;
		case '/':
			fract3.divide(fract1, fract2, fract3);                
			break;
		}

		fract3.lowterms(fract3);                   // function call to simplify terms

		fract3.showfraction(fract3);

		cout << "Calculate Another (Y or N)? ";
		cin >> response;
		cout << "\n\n";

	}

	return 0;
}

///////////////////////////////////////////////////////////////////////////////

char getsign()
	{
        char sign;

		cout << "Please Enter Mathematic Operation: ";
		cin >> sign;
		cout << "\n";
		return sign;
	}

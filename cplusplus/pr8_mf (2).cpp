// pr8_mf.cpp
// member function definitions
//

#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std; 

#include "pr8_cd.h"

// ------------------------------- Input --------------------------------

void fraction::getfraction()              // Input fractions and sign
{
	cout << "Please Enter Fraction: ";
	cin >> num >> dummychar >> denom;
	cout << "\n";
}

// ------------------------------ Display ------------------------------

void fraction::showfraction(fraction& fr3)          // Display result on the screen
{
	cout << fr3.num << "/" 
		 << fr3.denom;
}

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

void fraction::lowterms(fraction& fr3)    // Simplify to lowest terms
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

char getsign();                  // declaration of getsign function

//////////////////////////////////////////////////////////////////////////
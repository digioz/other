// pr8_mf.cpp
// member function definitions 
//

#include <iostream>
#include <iomanip>
using namespace std; 

#include "pr8_cd.h"

// ------------------------------- Input --------------------------------

void fraction::getfraction()                // Input fractions and sign
{
	cout << "Please Enter Fraction (0/1 to end input): ";
	cin >> num >> dummychar >> denom;
	cout << "\n";

	if(num==0 && denom==1){ endloop=1; }
}

// ------------------------------ Display ------------------------------

void fraction::showfraction()  // Display result on the screen
{
	cout << num << "/" 
		 << denom;
}

// ------------------------------ Total ---------------------------------

void fraction::gettotal(fraction fr1)    // Total of multiple fractions
{
	num = (fr1.num*denom) + (fr1.denom*num);
	denom = (fr1.denom * denom);

}

// ------------------------------ Average -------------------------------

void fraction::getaverage(fraction fr1, int n)  // Avg several fractions
{
	num = fr1.num;
	denom = fr1.denom*n;

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

void fraction::lowterms()    // Simplify to lowest terms
		{
			long tnum, tden, temp, gcd;

			tnum = labs(num);
			tden = labs(denom);
			
			if(tden==0)
			{ cout << "Illegal fraction: division by 0 \n"; exit(1); }
			else if(tnum==0)
			{ num=0; denom=1; return; }

			while(tnum != 0)
			{
				if(tnum < tden)
				{ temp=tnum; tnum=tden; tden=temp; }
			tnum = tnum - tden;
			}
		gcd = tden;
		num = num / gcd;
		denom = denom / gcd;

		}

char getsign();                  // declaration of getsign function

//////////////////////////////////////////////////////////////////////////
// DigiOz Multimedia
// Creation Date: 4/22/03
//
// The purpose of this program is to calculate the cost
// of building a Desk using four functions. The first 
// function will ask the user for the number of drawers
// the desired desk should have, the second function asks
// for the type of wood to be used, the third function 
// will calculate the cost of the order, and a fourth 
// function will display the actual cost of the customers
// order on the computer screen. 
//
// Table of Variables:
// -------------------
// nd     = Number of drawers obtained through nodrawers function
// wdtype = Type of wood specified by user, obtained through woodtype function
// cst    = Calculated cost of making the desk, obtained through findcost funtion

#include <iostream>
using namespace std;

void nodrawers(int&);
void woodtype(char&);
void findcost(int&, char&, float&);
void dispcost(float&);

void main()
{
	int nd;
	char wdtype;
	float cst;

	nodrawers(nd);
	woodtype(wdtype);
	findcost(nd, wdtype, cst);

	dispcost(cst);
}

// ------------------ function to obtain number of drawers ------------------

void nodrawers(int& nd)
{
	cout << "Enter the Number of Drawers in the Desk: ";
	cin >> nd;
}

// -------------------- function to obtain type of wood ---------------------

void woodtype(char& wdtype)
{
	cout << "Enter type of Wood (m for mahogany, o for oak, p for pine): ";
	cin >> wdtype;
	cout << "\n\n";
}

// ------------------ function to calculate cost of desk --------------------

void findcost(int& nd, char& wdtype, float& cst)
{
	switch (wdtype)
	{
	case 'm':
		cst = (nd * 30) + 180;
		break;
	case 'o':
		cst = (nd * 30) + 140;
		break;
	case 'p':
		cst = (nd * 30) + 100;
		break;
	default:
		cout << "Invalid Wood Selection, try again.\n";
		cst = 0;
	}
}

// -------------- function to display cost of desk to screen ----------------

void dispcost(float& cst)
{
	cout << "The cost of building your Desk is $"
	     << cst
		 << "\n\n";
}

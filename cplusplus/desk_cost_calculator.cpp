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
// n       = Number of drawers obtained through nodrawers function
// wood    = Type of wood specified by user, obtained through woodtype function
// cost    = Calculated cost of making the desk, obtained through findcost funtion
// nd      = Variable to hold number of drawers inside nodrawers function
// wdtype  = Variable to hold type of wood inside woodtype function
// ndd     = Copy of the n variable to be used inside the findcost function
// wddtype = Copy of the wood variable to be used inside the findcost function
// cst     = Variable to hold calculated cost of desk inside findcost function
// cost2   = Copy of cost variable to display cost to screen inside dispcost function

#include <iostream>
using namespace std;

int nodrawers();
char woodtype();
float findcost(int, char);
void dispcost(float);

int main()
{
	int n;
	char wood;
	float cost;

	n = nodrawers();
	wood = woodtype();
	cost = findcost(n, wood);

	dispcost(cost);

	return 0;
}

// ------------------ function to obtain number of drawers ------------------

int nodrawers()
{
	int nd;
	cout << "Enter the Number of Drawers in the Desk: ";
	cin >> nd;
		
	return nd;
}

// -------------------- function to obtain type of wood ---------------------

char woodtype()
{
	char wdtype;
	cout << "Enter type of Wood (m for mahogany, o for oak, p for pine): ";
	cin >> wdtype;
	cout << "\n\n";

	return wdtype;
}

// ------------------ function to calculate cost of desk --------------------

float findcost(int ndd, char wddtype)
{
	float cst;

	switch (wddtype)
	{
	case 'm':
		cst = (ndd * 30) + 180;
		break;
	case 'o':
		cst = (ndd * 30) + 140;
		break;
	case 'p':
		cst = (ndd * 30) + 100;
		break;
	default:
		cout << "Invalid Wood Selection, try again.\n";
		cst = 0;
	}

	return cst;
}

// -------------- function to display cost of desk to screen ----------------

void dispcost(float cost2)
{
	cout << "The cost of building your Desk is $"
	     << cost2
		 << "\n\n";
}

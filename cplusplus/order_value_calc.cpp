// DigiOz Multimedia
// Creation Date: 4/3/03
//
// The purpose of this program is to process the mail order house's 5 
// given product orders in the quantities specified by the user. The
// user will first enter a product number, and a quantity for that 
// product through the keyboard. The program will then calculate the
// total value of the order for that specific product, and ask the 
// user if he/she wishes to add more products to this value. If the 
// user response positive to this question by entering a "Y", the 
// program will take the user through the loop again, and allow them
// to enter another product through the keyboard. 
// Once the user is finished entering all the products in the quantity
// desired, the total value of orders is displayed on the screen, when 
// the user responds to the question to continue entering a value with
// an "N" (standing for No). 
// 
//
// Table of Variables:
// -------------------
// productno = Product number, which can range from 1 to 5
// quantity1 = Quantity of product 1 which is sold at $2.98 each
// quantity2 = Quantity of product 2 which is sold at $4.50 each
// quantity3 = Quantity of product 3 which is sold at $9.98 each
// quantity4 = Quantity of product 4 which is sold at $4.49 each
// quantity5 = Quantity of product 5 which is sold at $6.87 each
// value     = Total retail value of all products sold
// response  = Variable for asking user if they want to enter more products
//

#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
	int productno, quantity1, quantity2, quantity3, quantity4, quantity5;
	char response='Y';
	double value=0;

	while (response == 'Y')
	{
		cout << "Please Choose Product Number to enter quantity for: ";
		cin >> productno;

		switch(productno)
		{
		case 1:
			cout << "Enter quantity of product 1 sold: ";
			cin >> quantity1;
			value += (quantity1 * 2.98);
			break;
		case 2:
			cout << "Enter quantity of product 2 sold: ";
			cin >> quantity2;
			value += (quantity2 * 4.50);
			break;
		case 3:
			cout << "Enter quantity of product 3 sold: ";
			cin >> quantity3;
			value += (quantity3 * 9.98);
			break;
		case 4:
			cout << "Enter quantity of product 4 sold: ";
			cin >> quantity4;
			value += (quantity4 * 4.49);
			break;
		case 5:
			cout << "Enter quantity of product 5 sold: ";
			cin >> quantity5;
			value += (quantity5 * 6.87);
			break;
		default:
			cout << "Error: Invalid Product Number Selected.";
			break;
		}

		cout << "\n";
		cout << "Enter another product (Y or N)? ";
		cin >> response;
		cout << "\n";
	}

	cout << "\n";
	cout << "Total Value of Products: " 
		 << setiosflags(ios::fixed) << setiosflags(ios::showpoint) 
		 << setprecision(2) << value << endl;
	cout << "\n";

	return 0;

}


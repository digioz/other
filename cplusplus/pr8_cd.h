// pr8_cd.h
//

#ifndef pr8_cd_h
#define pr8_cd_h

class fraction
{

private:
	long num;
	long denom;
	char dummychar;

public:
	int endloop;
	
	fraction() : num(0), denom(0), endloop(0) {  }    // Constructors

	void getfraction();                   // Input fractions and sign

	void showfraction();     // declaration of display function

	void gettotal(fraction fr1);         // Total several fractions together

	void getaverage(fraction fr1, int n); // Average fractions together
		
                                          // declaration of addition function
	void addition(fraction& fr1, fraction& fr2, fraction& fr3);
                                          // declaration of subtract.function
	void subtract(fraction& fr1, fraction& fr2, fraction& fr3);
                                          // declaration of multipl. function
	void multiply(fraction& fr1, fraction& fr2, fraction& fr3);
                                          // declaration of division function
	void divide(fraction& fr1, fraction& fr2, fraction& fr3);

	void lowterms();         // declaration of lowterms function

		
};

#endif

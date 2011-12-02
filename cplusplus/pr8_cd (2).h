// pr8_cd.h
//

#ifndef pr8_cd_h
#define pr6_cd_h

class fraction
{

private:
	int num;
	int denom;
	char dummychar;

public:

	fraction() : num(0), denom(0) {  }    // Constructors
	fraction(int frnum, int frdenom) : num(frnum), denom(frdenom) {  }

	void getfraction();                   // Input fractions and sign
	
                                          // declaration of addition function
	void addition(fraction& fr1, fraction& fr2, fraction& fr3);
                                          // declaration of subtract.function
	void subtract(fraction& fr1, fraction& fr2, fraction& fr3);
                                          // declaration of multipl. function
	void multiply(fraction& fr1, fraction& fr2, fraction& fr3);
                                          // declaration of division function
	void divide(fraction& fr1, fraction& fr2, fraction& fr3);

	void lowterms(fraction& fr3);         // declaration of lowterms function

	void showfraction(fraction& fr3);     // declaration of display function
		
};

#endif

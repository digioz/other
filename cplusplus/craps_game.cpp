// DigiOz Multimedia
// Creation Date: 4/29/03
//
// This program simulates playing of a game of Craps. Our job 
// here was to modify the code to add some chatter to the code
// so that depending on the outcome of the roll of dice, the 
// player is prompted a different set of randomly generated
// chatter text to make the game more fun. We have also added
// wagering to this program, to allow the player to bet on the
// rolling of dice. Depending on if the player looses or wins,
// the betting amount is added or subtracted from the total 
// available balance. The game ends when the player looses all 
// of his or her money. The program has also been modified to 
// randomize the outcome of the rolling of dice to make the 
// game more fair. If a player bets more then he or she has 
// in the bank, the program will prompt the player to enter 
// a new betting amount, since there would not be enough money 
// available in his bank to place that bet. 
//
// Table of Variables:
// -------------------
// Status     = Enumeration type containing "CONTINUE", "WON", or "LOST"
// sum        = total value returned from the rolling of dice
// myPoint    = Variable to hold the first roll value if user has to roll again
// gameStatus = is an Enumeration of type Status
// die1       = total rolled value of dice one inside the "rollDice" function
// die2       = total rolled value of dice two inside the "rollDice" function
// workSum    = Cumulative value rolled by dice one and two which is returned 
//

#include <iostream>
using namespace std;
#include <cstdlib>
#include <ctime>

int rollDice( void );  // function prototype
void chatter1( void ); // chatter function 1
void chatter2( void ); // chatter function 2
void chatter3( void ); // chatter function 3

int main()
{
   enum Status { CONTINUE, WON, LOST };
   int sum, myPoint;
   Status gameStatus;
   int bank=1000, bet;

   cout << "Welcome. You have $1000 in your bank.\n\n";

do
{
   cout << "Please Place your bet: ";
   cin >> bet;
   
   if (bet > bank)
   {
	   cout << "You can't bet more then you have in the bank. Bet again!\n";
	   cout << "Enter your new bet now: ";
	   cin >> bet;
   }
   
   srand(time(0));
   sum = rollDice();        // first roll of the dice

switch ( sum ) 
   {
      case 7: 
      case 11:                  // win on first roll
         gameStatus = WON;

	     chatter1();

		 bank += bet;
		 cout << "Your bank balance is $" << bank << endl;
         break;
      case 2: 
      case 3: 
      case 12:                 // lose on first roll
         gameStatus = LOST;
	     
		 chatter2();

		 bank -= bet;
		 cout << "Your bank balance is $" << bank << endl;
         break;
      default:                 // remember point
         gameStatus = CONTINUE;
         myPoint = sum;
         cout << "Your point for this game is " << myPoint << " . Roll Again." << endl;
         break;                // optional   
    }

 while ( gameStatus == CONTINUE )   //keep rolling
 {
      sum = rollDice();

      if ( sum == myPoint )       // win by making point
	  {
        gameStatus = WON;
		bank += bet;
		cout << "You are damn lucky. You WON by making point!\n";
		cout << "Your bank balance is $" << bank << endl;
	  }
      else
	  {
		  if ( sum == 7 )          // lose by rolling 7
		  {
            cout << "You rolled a 7. You LOST!\n";
		  }
		  gameStatus = LOST;

		  chatter3();

		  bank -= bet;
		  cout << "Your bank balance is $" << bank << endl;
	  }
 }

 if ( gameStatus == WON )
      cout << "Player wins" << "\n\n";
   else
      cout << "Player loses" << "\n\n";
}
while (bank > 0);

cout << "You lost all your money. Game is Over!\n\n";

   return 0;
}

//////////////////////////////////////////////////////////////////////////

int rollDice( void )
{
   int die1, die2, workSum;

   die1 = 1 + rand() % 6;
   die2 = 1 + rand() % 6;
   workSum = die1 + die2;

   cout << "Player rolled " << die1 << " + " << die2
        << " = " << workSum << endl;

   return workSum;
}

/////////////////////////////////////////////////////////////////////////

void chatter1( void )

{  

switch (1 + rand() % 9) 
		 {
            case 1:
                cout << "Oh, so you think you have it figured out, huh?\n";
				break;
			case 2:
			    cout << "You won on the first roll you lucky dog!\n";
				break;
			case 3:
			    cout << "Are you sure these dice are not fixed?\n";
				break;
			case 4:
			    cout << "There must be something wrong with the dice.\n";
				break;
			case 5:
				cout << "Luck seems to be on your side today.\n";
				break;
			case 6:
				cout << "Very good. You won on the first roll.\n";
				break;
			case 7:
				cout << "How can a person be this lucky?\n";
				break;
			case 8:
				cout << "You WON. On the first roll. Damn!\n";
				break;
			case 9:
				cout << "You Won on the first roll. Can I check out the dice?\n";
				break;
		 }
}

////////////////////////////////////////////////////////////////////////////


void chatter2( void )

{  

switch (1 + rand() % 9) 
		 {
            case 1:
                cout << "I knew you were a looser. You lost on the first roll!\n";
				break;
			case 2:
			    cout << "You lost on the first roll. Shame on you.\n";
				break;
			case 3:
			    cout << "Now we know that the dice are not fixed?\n";
				break;
			case 4:
			    cout << "Lost again. I am getting bored here.\n";
				break;
			case 5:
				cout << "Oh, come on. Are you going to cry?\n";
				break;
			case 6:
				cout << "Looser on the first roll AGAIN!\n";
				break;
			case 7:
				cout << "This is getting boring. You lost again.\n";
				break;
			case 8:
				cout << "A few more rolls of dice and you will get rid of all your money!\n";
				break;
			case 9:
				cout << "To loose or not to loose. To LOOSE. You Lost on first roll!\n";
				break;
		 }
}

/////////////////////////////////////////////////////////////////////////

void chatter3( void )

{  

switch (1 + rand() % 9) 
		 {
            case 1:
                cout << "I knew you were a looser. \n";
				break;
			case 2:
			    cout << "You lost. Shame on you.\n";
				break;
			case 3:
			    cout << "Now we know that the dice are not fixed?\n";
				break;
			case 4:
			    cout << "Lost again? I am getting bored here.\n";
				break;
			case 5:
				cout << "Oh, come on. Are you going to cry?\n";
				break;
			case 6:
				cout << "Looser Looser. Why don't you give up.\n";
				break;
			case 7:
				cout << "This is getting boring. You lost again.\n";
				break;
			case 8:
				cout << "A few more rolls of dice and you will get rid of all your money!\n";
				break;
			case 9:
				cout << "To loose or not to loose. To LOOSE. You Lost!\n";
				break;
		 }
}

////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
    /// <summary>
    /// This class is for Cards such as Get of Jail Free, etc.
    /// </summary>
    
       public class Card   
       {
           public string[] communityChestCardArray = new string[16];
           public string[] chanceCardArray = new string[16];
           
           public Card()
           {
               for (int i = 0; i <= 15; i++)//assign titles to each element in both arrays
               {
                   communityChestCardArray[i] = "\n*Community Chest Card*\n";
                   chanceCardArray[i] = "\n*Chance Card*\n";
               }

               //array for community chest cards
               communityChestCardArray[0] += "Go To Jail!";
               communityChestCardArray[1] += "Advance to Go (collect $200)";
               communityChestCardArray[2] += "Bank error inuhih your favor (collect $75)";
               communityChestCardArray[3] += "Doctors fee (pay $50)";
               communityChestCardArray[4] += "Advance to Go (collect $200)";
               communityChestCardArray[5] += "Go To Jail!";
               communityChestCardArray[6] += "Get ou of jail free (you may keep this card until you need it)";
               communityChestCardArray[7] += "Birthday (collect $10 from each player)";
               communityChestCardArray[8] += "Grand Opera night (collect $50 from each player)";
               communityChestCardArray[9] += "Income tax refund (collect $20 from the bank)";
               communityChestCardArray[10] += "Life insurance matures (collect $100 from the bank)";
               communityChestCardArray[11] += "Pay hospital fees of $100";
               communityChestCardArray[12] += "Pay school fees of $100";
               communityChestCardArray[13] += "Recieve $25 consultancy fee";
               communityChestCardArray[14] += "You inherit $100";
               communityChestCardArray[15] += "Holiday fund matures (recieve $100)";
               
               //array for chance cards
               chanceCardArray[0] += "Advance to go (collect $200)";
               chanceCardArray[1] += "Advance to Golden Bay";
               chanceCardArray[2] += "Get out of jail free";
               chanceCardArray[3] += "Pay poor tax of $15";
               chanceCardArray[4] += "You have been elected chairman of the board (pay each player $50)";
               chanceCardArray[5] += "Make general repairs on all your property (for each house pay $25, for each hotel $100)";
               chanceCardArray[6] += "Go back 3 spaces";
               chanceCardArray[7] += "Advance to St. Charles Place";
               chanceCardArray[8] += "A total ten times the amount thrown";
               chanceCardArray[9] += "You have won a crossword competition (collect $100)";
               chanceCardArray[10] += "Your building loan matures (collect $150)";
               chanceCardArray[11] += "Advance token to nearest Utility (If unowned, you may buy it from the Bank. If owned, throw dice and pay owner a total ten times the amount thrown)";
               chanceCardArray[12] += "Bank pays your dividend of $50";
               chanceCardArray[13] += "Advance token to the nearest Railroad and pay owner twice the rental to which he/she is otherwise entitled. If Railroad is unowned, you may buy it from the Bank. (There are two of these.)";
               chanceCardArray[14] += "Take a walk on the Boardwalk (advance token to Boardwalk)";
               chanceCardArray[15] += "Pay poor tax of $15";
           }
        public override string ToString()        
        {
            throw new System.NotImplementedException();
        }

        public string GetCard()//get a random card
        {
            int whichDeck;

            Random randomDeck = new Random();            
            whichDeck = randomDeck.Next(0, 3);//randomly choose which array to generate a card from

            if (whichDeck == 1)
            {
                return GetCommunityCard();
            }
            else
            {
                return GetChanceCard();                    
            }                          
        }

        public string GetCommunityCard()
        {
            //generate random community card
            int card;
            Random randomCommunityCard = new Random();
            card = randomCommunityCard.Next(communityChestCardArray.Length);
            return communityChestCardArray[card];
        }

        public string GetChanceCard()
        {
            //generate random chance card
            int card;            
            Random randomChanceCard = new Random();
            card = randomChanceCard.Next(chanceCardArray.Length);
            return chanceCardArray[card];
        }
    }
}

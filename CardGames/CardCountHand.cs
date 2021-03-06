﻿//using System;
//using System.Collections.Generic;

//namespace CardGames
//{
//    public class CardCountHand : Hand
//    {
//        List<Card> cards = new List<Card>();

//        public override int EvaluateHand()
//        {
//            int handTotal = 0;

//            foreach(Card card in cardsInHand)
//            {
//                if (card.GetRank().ToString() == "1" || card.GetRank().ToString() == "A")
//                    handTotal += 1;
//                else if (card.GetRank().ToString() == "2")
//                    handTotal += 2;
//                else if (card.GetRank().ToString() == "3")
//                    handTotal += 3;
//                else if (card.GetRank().ToString() == "4")
//                    handTotal += 4;
//                else if (card.GetRank().ToString() == "5")
//                    handTotal += 5;
//                else if (card.GetRank().ToString() == "6")
//                    handTotal += 6;
//                else if (card.GetRank().ToString() == "7")
//                    handTotal += 7;
//                else if (card.GetRank().ToString() == "8")
//                    handTotal += 8;
//                else if (card.GetRank().ToString() == "9")
//                    handTotal += 9;
//                else if (card.GetRank().ToString() == "10" || card.GetRank().ToString() == "J" || card.GetRank().ToString() == "Q" || card.GetRank().ToString() == "K")
//                    handTotal += 10;
//            }
//            return handTotal;
//        }
//        public override int CompareTo(Hand OtherHandObject)
//        {
//            if (this.EvaluateHand() == OtherHandObject.EvaluateHand())
//                return 0;
//            else if (this.EvaluateHand() < OtherHandObject.EvaluateHand())
//                return -1;
//            else
//                return 1;
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace CardGames
{
    public class CardCountHand : Hand
    {
        public override int CompareTo(Hand OtherHandObject)
        {
            if (this.EvaluateHand() == OtherHandObject.EvaluateHand())
                return 0;
            else if (this.EvaluateHand() < OtherHandObject.EvaluateHand())
                return -1;
            else
                return 1;
        }

        public override int EvaluateHand()
        {
            int handTotal = 0;

            for(int i = 0; i < this.GetNumberOfCards(); i++)
            {
                Card card = this.GetCardAtIndex(i);
                if (card.GetRank().ToString() == "1" || card.GetRank().ToString() == "A")
                    handTotal += 1;
                else if (card.GetRank().ToString() == "2")
                    handTotal += 2;
                else if (card.GetRank().ToString() == "3")
                    handTotal += 3;
                else if (card.GetRank().ToString() == "4")
                    handTotal += 4;
                else if (card.GetRank().ToString() == "5")
                    handTotal += 5;
                else if (card.GetRank().ToString() == "6")
                    handTotal += 6;
                else if (card.GetRank().ToString() == "7")
                    handTotal += 7;
                else if (card.GetRank().ToString() == "8")
                    handTotal += 8;
                else if (card.GetRank().ToString() == "9")
                    handTotal += 9;
                else if (card.GetRank().ToString() == "10" || card.GetRank().ToString() == "J" || card.GetRank().ToString() == "Q" || card.GetRank().ToString() == "K")
                    handTotal += 10;
            }
            return handTotal;
        }

        string toStringOutput = "";
        public override string ToString()
        {
            foreach (Card cards in cardsInHand)
            {
                toStringOutput = toStringOutput + cards + " ";
            }
            return toStringOutput;
        }
    }
}


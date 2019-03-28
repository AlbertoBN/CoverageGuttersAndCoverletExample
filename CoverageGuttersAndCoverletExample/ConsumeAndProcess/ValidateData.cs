using System;
using System.Collections.Generic;

namespace ConsumeAndProcess
{
    public class ValidateData
    {

        public List<EmployeeTimeCard> Validate(List<EmployeeTimeCard> cardsList)
        {

            List<EmployeeTimeCard> invalidCards = new List<EmployeeTimeCard>();

            foreach (var card in cardsList)
            {
                if (card.PunchOut.CompareTo(card.PunchIn) <= 0)
                {
                    InvalidateCard(invalidCards, card);
                    continue;
                }

                TimeSpan t = card.PunchOut - card.PunchIn;

                if (t.TotalHours > card.HoursLimit &&
                    !card.IsOvertimeAllowed)
                {
                    InvalidateCard(invalidCards, card);
                    continue;
                }
                card.IsValid = true;
            }
            return invalidCards;
        }

        private static void InvalidateCard(List<EmployeeTimeCard> invalidCards, EmployeeTimeCard card)
        {
            card.IsValid = false;
            invalidCards.Add(card);
        }
    }
}
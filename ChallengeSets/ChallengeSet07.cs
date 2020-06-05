using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if(businesses == null || businesses.Count == 0) return 0;
            int count = 0;
            foreach (var item in businesses)
            {
                if (item.TotalRevenue - item.TotalExpenses < 0)
                {
                    count++;
                }
            }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            var list = businesses.Where(x => x.TotalRevenue -x.TotalExpenses > 0).Select(x => x.Name);
            return String.Join(",", list);
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            if (business.ParentCompany == null)
            {
                return business.Name;
            }

            business.Name = GetNameOfHighestParentCompany(business.ParentCompany);
            return business.Name;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            for (int i =0; i < 3; i++)
            {
                if (finalBoard[i, 0] == finalBoard[i, 1] && finalBoard[i, 0] == finalBoard[i, 2])

                {
                    if (finalBoard[i, 0] == 'X')
                    {
                        return TicTacToeResult.X;
                    }
                    else return TicTacToeResult.O;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (finalBoard[0, i] == finalBoard[1, i] && finalBoard[0, i] == finalBoard[2, i])
                {
                    if (finalBoard[0, i] == 'X')
                    {
                        return TicTacToeResult.X;
                    }
                    else return TicTacToeResult.O;
                }
            }
            if(finalBoard[0, 0] == finalBoard[1, 1] && finalBoard[0, 0] == finalBoard[2, 2])
            {
                if (finalBoard[0, 0] == 'X')
                {
                    return TicTacToeResult.X;
                }
                else return TicTacToeResult.O;
            }
            if(finalBoard[2, 0] == finalBoard[1, 1] && finalBoard[2, 0] == finalBoard[0, 2])
            {
                if (finalBoard[0, 0] == 'X')
                {
                    return TicTacToeResult.X;
                }
                else return TicTacToeResult.O;
            }
            return TicTacToeResult.Draw;

        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers.Length == 0)
            {
                return false;
            }
            int count = 0;
            int arrayCount = 0;
            bool yes = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                yes = false;
                arrayCount++;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] == targetNumber)
                    {
                        yes = true;
                    }
                }
                if (yes == true)
                {
                    count++;
                }
            }
            if (count == arrayCount)
            {
                return true;
            }
            else return false;
        }

    }
}

using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengeSets.Tests
{
    public class ChallengeSet08Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 0, 1 }, true)]
        [InlineData(new[] { 2, 1, 1, 3, 0, 0, 4 }, true)]
        [InlineData(new[] { 2, 2, -1, 3 }, true)]
        [InlineData(new[] { 1, 1, 1, 1, 2, 4, -1 }, true)]
        [InlineData(new[] { 2, 5, 3, 2, 4, -4, 1, 2, 3, 1, 2, 11, 1, 1, 6, 0, 0, 8, 0, 2, -9 }, true)]
        [InlineData(new[] { 2, 5, 3, 2, 4, -4, 1, 2, 3, 1, 2, 11, 1, 1, 6, 6, 0, 8, 0, 2, -5 }, true)]
        [InlineData(new[] { 2, 5, 3, 2, 4, -4, 1, 2, 3, 1, 2, 1, -1, 1, 6, 0, 0, 8, 0, 2, -9 }, false)]
        [InlineData(new[] { 1, -2 }, false)]
        [InlineData(new[] { 1, 2, 0, -1 }, false)]
        [InlineData(new[] { -1, 2, 3 }, false)]
        [InlineData(new[] { 2, 1, -1, 4 }, false)]
        [InlineData(new[] { 3, 0, 2, -2 }, false)]
        public void CanHopAcross(int[] hopAmount, bool expected)
        {
            //Arrange
            ChallengeSet08 challenger = new ChallengeSet08();
            //Act
            bool actual = challenger.CanHopAcross(hopAmount);
            //Assert
            Assert.Equal(expected, actual);
        }



        /*
         * Frogger!!
         * The 'O' is the path. The 'X' is blocked!
         * The 'O' will alays start on the left side.
         * The Finish will always be on the right side.
         * Return Y if path is clear, N if its not clear!
         * Happy Frogging!
         *
         * !!ONE TEST HAS MORE THAN ONE STARTING POINT!!
         * 
         */

        [Theory]
        [InlineData(new char[] { 'X', 'X', 'X' }, // Yes
                    new char[] { 'O', 'O', 'X' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengeSet08.Frogger.Y)]

        [InlineData(new char[] { 'X', 'X', 'X' }, // Yes
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'O', 'O', 'X' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'X', 'X', 'X' }, ChallengeSet08.Frogger.Y)]

        [InlineData(new char[] { 'O', 'O', 'X' }, // Yes
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' }, ChallengeSet08.Frogger.Y)]

        [InlineData(new char[] { 'X', 'X', 'X' }, // Yes
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'O', 'O', 'O' },
                    new char[] { 'X', 'X', 'X' }, ChallengeSet08.Frogger.Y)]

        [InlineData(new char[] { 'O', 'O', 'X' }, // No 
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'X', 'X', 'X' }, ChallengeSet08.Frogger.N)]

        [InlineData(new char[] { 'X', 'X', 'X' }, // No
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'O', 'O', 'X' },
                    new char[] { 'X', 'X', 'X' }, ChallengeSet08.Frogger.N)]

        [InlineData(new char[] { 'X', 'X', 'X' }, // No
                    new char[] { 'O', 'X', 'X' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'X', 'X', 'X' }, ChallengeSet08.Frogger.N)]

        [InlineData(new char[] { 'O', 'O', 'X' }, // Yes
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'O', 'X' }, ChallengeSet08.Frogger.Y)]

        [InlineData(new char[] { 'X', 'O', 'O' }, // No
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'O', 'O', 'X' }, ChallengeSet08.Frogger.N)]

        [InlineData(new char[] { 'O', 'O', 'X' }, // Yes
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'O', 'O', 'X' }, ChallengeSet08.Frogger.Y)]

        [InlineData(new char[] { 'X', 'O', 'X' }, // No
                    new char[] { 'X', 'O', 'O' },
                    new char[] { 'X', 'X', 'X' },
                    new char[] { 'X', 'O', 'X' },
                    new char[] { 'O', 'O', 'X' }, ChallengeSet08.Frogger.N)]
        public void GetTheFrogAcross(char[] row1, char[] row2, char[] row3, char[] row4, char[] row5, ChallengeSet08.Frogger expected)
        {
            // Arrange
            ChallengeSet08 challenger = new ChallengeSet08();
            char[,] finalResult = new char[5, 3];
            for (int col = 0; col < 3; col++) finalResult[0, col] = row1[col];
            for (int col = 0; col < 3; col++) finalResult[1, col] = row2[col];
            for (int col = 0; col < 3; col++) finalResult[2, col] = row3[col];
            for (int col = 0; col < 3; col++) finalResult[3, col] = row4[col];
            for (int col = 0; col < 3; col++) finalResult[4, col] = row5[col];

            // Act
            ChallengeSet08.Frogger actual = challenger.GetTheFrogAcross(finalResult);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

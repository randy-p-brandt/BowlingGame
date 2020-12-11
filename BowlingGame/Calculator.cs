namespace BowlingGame
{
    class Calculator
    {
        private int[] rolls;

        private Calculator(int[] rolls)
        {
            this.rolls = rolls;
        }

        public static Calculator GetRollCalculator(int[] rolls)
        {
            return new Calculator(rolls);
        }

        public void GetScoreForAllRollsInGame(ref int score)
        {
            int box = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                // strikes
                if (rolls[box] == 10)
                {
                    score += rolls[box] + rolls[box +1] + rolls[box + 2];
                    box++;
                }
                // spare
                else if (rolls[box] != 10 &&
                    rolls[box] + rolls[box + 1] == 10) 
                {
                    score += 10 + rolls[box + 2];
                    box+= 2;
                }
                else
                {
                    score += rolls[box] + rolls[box + 1];
                    box+= 2;
                }
            }
        }
    }
}

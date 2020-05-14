namespace BowlingGame
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int s = 0;
            int i = 0;

            for (int f = 0; f < 10; f++)
            {
                if (rolls[i] + rolls[i + 1] == 10)
                {
                    s += 10 + rolls[i + 2];
                }
                else
                {
                    s += rolls[i] + rolls[i + 1];
                }

                i = i + 2;
            }

            return s;
        }
    }
}

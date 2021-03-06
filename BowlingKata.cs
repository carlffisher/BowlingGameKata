using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    public class BowlingKataClass
    {

        public int incrementedtotal;
        public int temp_int;
        public int ScoreStringIndex;
        public int IncrementedIndexBy2;
        public int FrameCount;
        public const int STRLENSPAREBONUS = 22; // == 11 frame game
        public const int STRLENSTRIKEBONUS = 22; // == 10 frame game + 2 bonus balls

        public int DummyCalculateGameScore(string StringOfScores, int IncrementedIndexBy2)
        {
            return 1;
        }

        public int CalculateGameScore(string StringOfScores, int IncrementedIndexBy2, int incrementedtotal)
        {
            bool SpareBonusBall = false;


            if (IncrementedIndexBy2 == (StringOfScores.Length-2)) // Not > than!
            {
                return incrementedtotal;
            }

            if (StringOfScores[IncrementedIndexBy2] == 'X') // It's a STRIKE ...
            {
                incrementedtotal += 10;
                IncrementedIndexBy2 += 2;

                if (IncrementedIndexBy2 == (STRLENSTRIKEBONUS-2)) // It's the STRIKE bonus balls ...
                {
                    if ((StringOfScores[IncrementedIndexBy2] == 'X') || (StringOfScores[IncrementedIndexBy2] == '/'))
                    {
                        incrementedtotal += 10;
                    }
                    else
                    {
                        if (StringOfScores[IncrementedIndexBy2] != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2]);
                    }

                    if ((StringOfScores[IncrementedIndexBy2+1] == 'X') || (StringOfScores[IncrementedIndexBy2+1] == '/'))
                    {
                        incrementedtotal += 10;
                    }
                    else
                    {
                        if (StringOfScores[IncrementedIndexBy2+1] != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2+1]);
                    }

                    return incrementedtotal; // ... end of Strike bonus ball
                }

                if (IncrementedIndexBy2 < (StringOfScores.Length-2))
                {
                    if ((StringOfScores[IncrementedIndexBy2] == 'X') || (StringOfScores[IncrementedIndexBy2] == '/'))
                    {
                        incrementedtotal += 10;


                        if ((StringOfScores[IncrementedIndexBy2 + 2] == 'X') || (StringOfScores[IncrementedIndexBy2 + 2] == '/'))
                        {
                            incrementedtotal += 10;
                        }
                        else
                        {
                            if (StringOfScores[IncrementedIndexBy2 + 2] != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2 + 2]);
                        }
                    }
                    else
                    {
                         if (StringOfScores[IncrementedIndexBy2] != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2]);
                         if (StringOfScores[IncrementedIndexBy2+1] != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2+1]);
                    }


                }
                   
                incrementedtotal = CalculateGameScore(StringOfScores, IncrementedIndexBy2, incrementedtotal);
            }
            else if (StringOfScores[IncrementedIndexBy2] == '/') // It's a SPARE ...
            {
                incrementedtotal += 10;
                IncrementedIndexBy2 += 2;

                if (IncrementedIndexBy2 == (STRLENSPAREBONUS - 2))
                {
                    SpareBonusBall = true;
                    incrementedtotal += 10;
                }

                if (IncrementedIndexBy2 <= (StringOfScores.Length - 2))
                {
                    if ((StringOfScores[IncrementedIndexBy2] == 'X') || (StringOfScores[IncrementedIndexBy2] == '/'))
                    {
                        if (!SpareBonusBall) incrementedtotal += 10;
                    }
                    else
                    {
                        if (!SpareBonusBall)
                        {
                            if (StringOfScores[IncrementedIndexBy2] != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2]);
                        }
                    }
                }

               //   incrementedtotal += 10;
               // IncrementedIndexBy2 += 2;

                incrementedtotal = CalculateGameScore(StringOfScores, IncrementedIndexBy2, incrementedtotal);
            }
            else
            {
                // It's an OPEN frame...

                if (StringOfScores[IncrementedIndexBy2]   != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2]);
                if (StringOfScores[IncrementedIndexBy2+1] != '-') incrementedtotal += (int)Char.GetNumericValue(StringOfScores[IncrementedIndexBy2+1]);

                IncrementedIndexBy2 += 2;
                incrementedtotal = CalculateGameScore(StringOfScores, IncrementedIndexBy2, incrementedtotal);
            }

            return incrementedtotal;
        }

      

                    /* Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces the total score for the game.Here are some things that the program will not do:

                    We will not check for valid rolls.
                    We will not check for correct number of rolls and frames.
                    We will not provide scores for intermediate frames.
                    Depending on the application, this might or might not be a valid way to define a complete story, but we do it here for purposes of keeping the kata light. I think you’ll see that improvements like those above would go in readily if they were needed for real.

                    We can briefly summarize the scoring for this form of bowling:

                    Each game, or “line” of bowling, includes ten turns, or “frames” for the bowler.
                    In each frame, the bowler gets up to two tries to knock down all the pins.
                    If in two tries, he fails to knock them all down, his score for that frame is the total number of pins knocked down in his two tries.
                    If in two tries he knocks them all down, this is called a “spare” and his score for the frame is ten plus the number of pins knocked down on his next throw (in his next turn).
                    If on his first try in the frame he knocks down all the pins, this is called a “strike”. His turn is over, and his score for the frame is ten plus the simple total of the pins knocked down in his next two rolls.
                    If he gets a spare or strike in the last (tenth) frame, the bowler gets to throw one or two more bonus balls, respectively.These bonus throws are taken as part of the same turn.If the bonus throws knock down all the pins, the process does not repeat: the bonus throws are only used to calculate the score of the final frame.
                    The game score is the total of all frame scores.
                    */
     }
}

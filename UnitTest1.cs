using NUnit.Framework;
using FluentAssertions;

namespace BowlingKata
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]

        public void Test2()
        {
            // Let's try to send a dummy string to a dummy function that will return a dummy total game score as an int ...

            // bowlingkataclass = new();
            
            //bowlingkataclass.DummyCalculateGameScore("1", 0).Should().Be(1); // score of double 5 in ea of 12 frames
        }


        [Test]
        public void Test3()
        {
            // Let's try to send strings repesenting the score from mixed OPEN and SPARE frames)
            // to a recursive function that will return the total game score as an int ...

            // set up return and sent pararmeters ...

             BowlingKataClass bowlingkataclass = new();
            // bowlingkataclass.CalculateGameScore("/-/-/-/-/-/-/-/-/-/-/-", 0, 0).Should().Be(200); // yes - 200 points with b ball

            /*
                         bowlingkataclass.CalculateGameScore("/-/-/-/-/-/-/-/-/-/-/-", 0, 0).Should().Be(200); // yes - 200 points with b ball
                         bowlingkataclass.CalculateGameScore("5555555555555555", 0, 0).Should().Be(80);
                         bowlingkataclass.CalculateGameScore("00000000000000000000", 0, 0).Should().Be(0);
                         bowlingkataclass.CalculateGameScore("00/-00/-/-/-0000/-01", 0, 0).Should().Be(71);
                         bowlingkataclass.CalculateGameScore("/-81/-/-/-0032/-0100", 0, 0).Should().Be(93);
                         bowlingkataclass.CalculateGameScore("/-81/-/-/-0032/-01/-54", 0, 0).Should().Be(112); 
                         bowlingkataclass.CalculateGameScore("90159057209015905720", 0, 0).Should().Be(76);
                  */

                         //   bowlingkataclass.CalculateGameScore("/-81/-/-/-0032/-0100", 0, 0).Should().Be(93);
                         //   bowlingkataclass.CalculateGameScore("/-/-/-/-/-/-/-/-/-/-/-", 0, 0).Should().Be(200); // yes - 200 points with b ball
        }

        [Test]
        public void Test4()
        {
            // Let's try to strings (repesenting the score from STRIKE frames ...)

            // set up return and sent pararmeters ...

            BowlingKataClass bowlingkataclass = new();

            //  bowlingkataclass.CalculateGameScore("5555555555555555", 0, 0).Should().Be(80);


            //  bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-X-X-", 0, 0).Should().Be(300); 
            // bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-0000", 0, 0).Should().Be(150);
            // bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-00", 0, 0).Should().Be(170);
            //   bowlingkataclass.CalculateGameScore("X-X-X-000000000000000", 0, 0).Should().Be(50); 
            //   bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-X-X-", 0, 0).Should().Be(190);
            // bowlingkataclass.CalculateGameScore("X-X-X-00000000000000", 0, 0).Should().Be(60); 
            //    bowlingkataclass.CalculateGameScore("X- X- X- 00 00 00 00 00 00 00", 0, 0).Should().Be(60); 
            //  bowlingkataclass.CalculateGameScore("X-000000000000000000", 0, 0).Should().Be(10); 
            // bowlingkataclass.CalculateGameScore("X-X-0000000000000000", 0, 0).Should().Be(30); 
            //  bowlingkataclass.CalculateGameScore("X-X-X-00000000000000", 0, 0).Should().Be(60); 
            //  bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-X-X-", 0, 0).Should().Be(190);
            //  bowlingkataclass.CalculateGameScore("X-113300000000000000", 0, 0).Should().Be(20); 
            // bowlingkataclass.CalculateGameScore("X-X-X-00000000000000", 0, 0).Should().Be(20); 
            // bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-X-X-", 0, 0).Should().Be(300);


            //   bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-XX", 0, 0).Should().Be(300);   // A full card good
            //   bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-00", 0, 0).Should().Be(280);   // good 
            // bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X---", 0, 0).Should().Be(280);   // good
            // bowlingkataclass.CalculateGameScore("X-X-X-00000000000000", 0, 0).Should().Be(50); 
            // bowlingkataclass.CalculateGameScore("X-X-X-00000000000000", 0, 0).Should().Be(50); 
            //   bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-0000", 0, 0).Should().Be(150);


            //    bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-XX", 0, 0).Should().Be(300);   // A full card good

            //    bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-00", 0, 0).Should().Be(280);   // good 


               bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-XX", 0, 0).Should().Be(300);   // A full card good
               bowlingkataclass.CalculateGameScore("X-X-X-X---------------", 0, 0).Should().Be(90);   // good
               bowlingkataclass.CalculateGameScore("--X---X---------------", 0, 0).Should().Be(20);   // good
               bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X-X-", 0, 0).Should().Be(290);   // good
               bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X--X", 0, 0).Should().Be(280);   // 280 
               bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-X---", 0, 0).Should().Be(270); // good
               bowlingkataclass.CalculateGameScore("X-X-X-X-X-X-X-X-X-----", 0, 0).Should().Be(240); // good
               bowlingkataclass.CalculateGameScore("X---X-X-X-X-X-X-X-----", 0, 0).Should().Be(190); // good
               bowlingkataclass.CalculateGameScore("55555555555555555555--", 0, 0).Should().Be(100); //g

            //   bowlingkataclass.CalculateGameScore("--/---/-/-/-----/-57--", 0, 0).Should().Be(87); // g
            bowlingkataclass.CalculateGameScore("--X-------/-----/-----", 0, 0).Should().Be(30); // n f 40
            bowlingkataclass.CalculateGameScore("--X---/---/-----/-----", 0, 0).Should().Be(40); // n f 40
          //   bowlingkataclass.CalculateGameScore("/-/-/-/-/-/-/-/-/-/-/-", 0, 0).Should().Be(200); // g
          //   bowlingkataclass.CalculateGameScore("/-/-/-/-/-/-/-/-/-/---", 0, 0).Should().Be(200); // g

        }

    }
}


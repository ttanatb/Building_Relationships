using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    class Lover
    {
        int lovePoints = 0;
        int destructionPoints = 0;
        public bool loveState = false;
        string description = null;

        public int AddLovePoints(int points)
        {
            lovePoints += points;
            return lovePoints;
        }

        public int UpdateLovePoints()
        {
            return lovePoints;
        }
        
        public string Introduce(int introTimes)
        {
            //assigning variables
            string line1 = null;
            string line2 = null;
            string line3 = null;
            string message = null;
            string enter = "\n";

            //your introductory message
            line1 = "You: Hey! My name is Billding. Nice to meet you!";


            //list of response based on how many times you have introduced yourself
            if (introTimes == 0)
            {
                line2 = "Cementha: Oh, hey. I'm Cementha. Nice to meet you, too";
                line3 = "She blushes a little as she looks away.";
                lovePoints = AddLovePoints(6);
            }

            else if (introTimes == 1)
            {
                line2 = "Cementha: You silly goose! You already introduced yourself to me.";
                line3 = "She giggles at your silliness.";
                lovePoints = AddLovePoints(3);
            }

            else if (introTimes == 2)
            {
                line2 = "Cementha: Ahahahaha. Why are you introducing yourself again?.";
                line3 = "She giggles, this time noticibly less amused.";
                lovePoints = AddLovePoints(1);
            }
            else if (introTimes == 3)
            {
                line2 = "Cementha: Ugh... Maybe you should stop.";
                line3 = "She doesn't seem too happy with your introductions. I wonder why.";
                lovePoints = AddLovePoints(-1);
            }
            else if (introTimes > 3)
            {
                line2 = "Cementha: Seriously?";
                line3 = "Maybe you should stop introducing yourself.";
                lovePoints = AddLovePoints(-3);
            }

            //adds the lines up to a message
            if (line3 != null && line2 != null)
            {
                message = enter + line1 + enter + line2 + enter + line3;
            }
            else if (line3 == null && line2 == null)
            {
                message = enter + line1;
            }
            else if (line3 == null && line2 != null)
            {
                message = enter + line1 + enter + line2;
            }

            return message;
        }

        public string Talk(int introTimes, int talkTimes)
        {
            //assigning variables
            string message = null;
            string line1 = null;
            string line2 = null;
            string line3 = null;
            string enter = "\n";

            //triggers the line of coversation
            if (introTimes == 0)
            {
                line1 = "Maybe you should intruduce yourself to her first.";
            }
            else if (talkTimes == 1)
            {
                line1 = "You: Hey I really like your new paint job.";
                line2 = "Cementha: Thanks I just got it done yesterday";
                line3 = "You: Nice.";
                lovePoints = AddLovePoints(6);
            }
            else if (talkTimes == 0)
            {
                line1 = "You: Is this your first full moon?";
                line2 = "Cementha: Yeah, it is.";
                line3 = "You: Oh me too.";
                lovePoints = AddLovePoints(8);
            }
            else if (talkTimes == 2)
            {
                line1 = "You: Do you like it in this neighborhood?";
                line2 = "Cementha: Yeah, it's really quiet here. I love it.";
                line3 = "You: Same.";
                lovePoints = AddLovePoints(6);
            }
            else if (talkTimes == 3)
            {
                line1 = "You: Have you see any good movies lately?";
                line2 = "Cementha: Ugh.. I haven't seen a movie before. That's probably because I can't move.";
                line3 = "You: Oh me too.";
                lovePoints = AddLovePoints(5);
            }
            else if (talkTimes == 4)
            {
                line1 = "You: What do you like to do in your free time?";
                line2 = "Cementha: I don't know... I can't really move so I don't really do anything.";
                line3 = "You: Oh, I see.";
                lovePoints = AddLovePoints(4);
            }
            else if (talkTimes == 5)
            {
                line1 = "You: What's your favorite food?";
                line2 = "Cementha: I'm a building... I don't really eat.";
                line3 = "You: Oh, right. I forgot about that.";
                lovePoints = AddLovePoints(3);
            }
            else if (talkTimes > 5)
            {
                line1 = "You can't think of any more topics to talk about";
            }

            //adds the lines to a message
            if (line3 != null && line2 != null)
            {
                message = enter + line1 + enter + line2 + enter + line3;
            }
            else if (line3 == null && line2 == null)
            {
                message = enter + line1;
            }
            else if (line3 == null && line2 !=null)
            {
                message = enter + line1 + enter + line2;
            }

            return message;
        }

        public string Flirt(int introTimes, int FlirtTimes, int LovePoints)
        {
            //assigning variables
            string line1 = null;
            string line2 = null;
            string line3 = null;
            string message = null;
            string enter = "\n";

            //obtains your flirting message
            //this is based on how many times you have flirted before
            if (FlirtTimes == 0)
            {
                line1 = "You: Hey baby, did it hurt when you fell from heaven?";
            }
            else if (FlirtTimes == 1)
            {
                line1 = "You: If I could rearrange the alphabet, I would put U and I together.";
            }
            else if (FlirtTimes == 2)
            {
                line1 = "You: I'm not an architect but I can picture a blueprint of you and me together.";
            }
            else if (FlirtTimes == 3)
            {
                line1 = "You: Everytime I look into your windows, I get more and more lost.";
            }
            else if (FlirtTimes == 4)
            {
                line1 = "You: Did you get your new paintjob on a discount? Because with me it would be 100% off.";
            }
            else if (FlirtTimes > 4)
            {
                line1 = "You can't think of any more pick-up lines";
            }

            //triggers the response
            //this is based on how much love points you have
            if (introTimes == 0 && FlirtTimes <= 4)
            {
                line2 = "Cementha: Ugh... Thanks?";
                line3 = "She seems confused. Maybe you should've introduced yourself first.";
                LovePoints = AddLovePoints(1);
            }
            else if (introTimes > 0 && LovePoints < 15 && FlirtTimes <= 4)
            {
                line2 = "Cementha: Aww.";
                line3 = "She seems happy.";
                LovePoints = AddLovePoints(5);
            }
            else if (introTimes > 0 && LovePoints >= 15 && LovePoints < 30 && FlirtTimes <= 4)
            {
                line2 ="Cementha: Aww, thanks. That's very cute.";
                line3 = "She seems flattered.";
                LovePoints = AddLovePoints(7);
            }
            else if (introTimes > 0 && LovePoints >= 30 && LovePoints < 50 && FlirtTimes <= 4)
            {
                line2 = "Cementha: Aww, thanks. I like it when you say things like that.";
                line3 = "She seems really hapy with what you said.";
                LovePoints = AddLovePoints(10);
            }
            else if (introTimes > 0 && LovePoints >= 50 && FlirtTimes <= 4)
            {
                line2 = "Cementha: Aww, thanks baby.";
                line3 = "Her cute smile shines with a slight blush.";
                LovePoints = AddLovePoints(12);
            }
            message = enter + line1 + enter + line2 + enter + line3;
            return message;
        }

        public string MakeLove(int introduceTimes, int LovePoints)
        {
            string message = null;
            string line1 = null;
            string line2 = null;
            string line3 = null;
            string enter = "\n";

            line1 = "Do you want to make love?";

            if (LovePoints >= 0 && LovePoints < 30)
            {
                line2 = "Cementha: Ew... creeepy...";
                line3 = "Maybe you should talk to her more before doing so.";
                AddLovePoints(-5);
            }
            else if (LovePoints >= 30 && LovePoints < 50 || introduceTimes < 1)
            {
                line2 = "Cementha: Ugh.... Ah....";
                line3 = "Well this is awkward...";
                AddLovePoints(-3);

            }
            else if (LovePoints >= 50 && LovePoints < 70 && introduceTimes > 0)
            {
                line2 = "Cementha: Hmm... The night is still young... Maybe not right now.";
                int times = 0;
                if (times == 0)
                {
                    AddLovePoints(3);
                    times++;
                }
            }
            else if (LovePoints > 70 && introduceTimes > 0)
            {
                line2 = "Cementha: Sure.";
            }

            if (line3 == null && line2 == null)
            {
                message = enter + line1;
            }
            else if (line3 == null && line2 != null)
            {
                message = enter + line1 + enter + line2;
            }
            return message;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameJam
{
    public partial class GameJam : Form
    {
        public GameJam()
        {
            InitializeComponent();

            //opening message
            rtbMessage.Text = "Welcome to Building Dating Simulator 2016" + Environment.NewLine;
            rtbMessage.Text += "Please bare with this game.";

            //initial button visibility
            btnGlassidy.Visible = false;
            btnWallecia.Visible = false;
            btnFloorsicca.Visible = false;
            btnSol.Visible = false;
            btnCementha.Visible = false;
            btnInitiate.Visible = false;
            lblLovePoints.Visible = false;
            btnTalk.Visible = false;
            btnFlirt.Visible = false;
            btnMakeLove.Visible = false;
            label3.Visible = false;
            btnIntroduce.Visible = false;
            btnContinue.Visible = false;
        }

        //defining variables
        public int LovePoints = 0;

        //stuff
        int btnIntroduceTimes = 0;
        int btnFlirtTimes = 0;
        int btnMakeLoveTimes = 0;
        int btnTalkTimes = 0;

        Lover cementha = new Lover();

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            rtbMessage.Text = "Welcome to the neighborhood. You are a recently constructed building ready for your first night of the full moon. What people do not know about you buildings is that every full moon you become sentient living beings. You gaze around the block as you review the information you have about the female buildings around the block." + Environment.NewLine;
            btnGlassidy.Visible = true;
            btnWallecia.Visible = true;
            btnFloorsicca.Visible = true;
            btnSol.Visible = true;
            btnCementha.Visible = true;
            btnNext.Visible = false;
        }
        private void btnGlassidy_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "Located a block down, Glassidy stood in the corner of the intersection. Although she stood beautifully gleaming with elegance, the fact that her walls are entirely made of glass kinds of bother you. It's kind of too... revealing. You don't even know how many middle-aged business men enters her daily. The thought of that makes you shudder. She's probably too skanky for you anyways.";
            btnInitiate.Visible = false;
        }
        private void btnWallecia_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "Wallecia is a recently renovated building that stood a few blocks away from you. From base to ceiling, she stood with confidence that emminated her own flare. Before she could as fabulous as she is now, she used to be built entirely of old bricks and outdated architecture. Back then he was always frustrated that her exterior never matched what he had to offer in the interior. Now that she is renovated, she has been more excited for the full moon than ever. However, I don't think I really am into buildings like her. I'm not judging but like... yeah. You know?";
            btnInitiate.Visible = false;
        }

        private void btnSol_Click_1(object sender, EventArgs e)
        {
            rtbMessage.Text = "Sol is one of those buildings who could always rock her 'brick' look. There are days when you just stare at her, your mind wandering of the endless ways you can use her multiple entrances... Wait, GOD NO! She's a dormitary, she's underaged. I don't want to be reported and torn down... Not just yet.";
            btnInitiate.Visible = false;
        }

        private void btnCementha_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "Cementha is probably the building of my dreams. Such composure, a high-rise in fact! She has the curvature other people die just thinking about. Apparently you've also heard that, with her earthquake-proof architecture, she's supper sturdy and resistant. Oh, yeah.";
            btnInitiate.Visible = true; 
            
        }

        private void btnFloorsicca_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "Floorsicca? What kind of name is Floorsicca? Anyways, apparently I've been told that her underground floors are the most expansive in the block. She is one of those buildings that really is all about that basement. But she also has tons of wires that she apparently can use to do 'very Japanese things' to you. Honestly though... I don't really find out what she can do with her wires. I think I'll pass on this one.";
            btnInitiate.Visible = false;
        }
        private void btnInitiate_Click_1(object sender, EventArgs e)
        {
            rtbMessage.Text = "As the light of the full moon shines upon you, your body feels envigorated with new energy. You slowly move towards Cementha. \n";
            
            

            btnGlassidy.Visible = false;
            btnWallecia.Visible = false;
            btnFloorsicca.Visible = false;
            btnSol.Visible = false;
            btnCementha.Visible = false;
            btnInitiate.Visible = false;

            btnTalk.Visible = true;
            btnFlirt.Visible = true;

            btnMakeLove.Visible = true;
            btnIntroduce.Visible = true;
            lblLovePoints.Visible = true;
            label3.Visible = true;

            lblLovePoints.Text = LovePoints.ToString();
        }
        private void btnIntroduce_Click_1(object sender, EventArgs e)
        {
            string message = cementha.Introduce(btnIntroduceTimes);
            rtbMessage.Text += Environment.NewLine + message;
            btnIntroduceTimes++;

            LovePoints = cementha.UpdateLovePoints();
            lblLovePoints.Text = LovePoints.ToString();
        }

        private void btnTalk_Click_1(object sender, EventArgs e)
        {
            string message = cementha.Talk(btnIntroduceTimes, btnTalkTimes);
            rtbMessage.Text += Environment.NewLine + message;
            btnTalkTimes++;

            if (btnIntroduceTimes == 0)
            {
                btnTalkTimes--;
            }

            LovePoints = cementha.UpdateLovePoints();
            lblLovePoints.Text = LovePoints.ToString();
        }

        private void btnFlirt_Click_1(object sender, EventArgs e)
        {
            //calls the method
            string message = cementha.Flirt(btnIntroduceTimes, btnFlirtTimes, LovePoints);
            rtbMessage.Text += Environment.NewLine + message; //updates message
            btnFlirtTimes++;

            //updates lovepoints
            LovePoints = cementha.UpdateLovePoints();
            lblLovePoints.Text = LovePoints.ToString();
        }
        private void btnMakeLove_Click_1(object sender, EventArgs e)
        {
            string message = cementha.MakeLove(btnIntroduceTimes, LovePoints);
            rtbMessage.Text += Environment.NewLine + message;
            btnMakeLoveTimes++;

            LovePoints = cementha.UpdateLovePoints();
            lblLovePoints.Text = LovePoints.ToString();

            if (LovePoints >= 69)
            {
                rtbMessage.Text += Environment.NewLine;
                rtbMessage.Text += "She looks into your eyes with firm confidence." + Environment.NewLine;
                rtbMessage.Text += Environment.NewLine + "You have recieved her consent";

                btnTalk.Visible = false;
                btnFlirt.Visible = false;
                btnMakeLove.Visible = false;
                label3.Visible = false;
                //label4.Visible = false;
                lblLovePoints.Visible = false;
                btnIntroduce.Visible = false;
                btnContinue.Visible = true;
            }
        }

        int btnContinueTimes = 0;

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            if (LovePoints != 69)
            {
                if (btnContinueTimes == 0)
                {
                    rtbMessage.Text = "You approach her slowly, silence spilling into the air. You gaze into her eyes as you leaned in forward and press your glass windows against hers. A feeling of warmth fills your body. It is as if the insulation system overheatted again. Pushing her down you hovered above her, locking your eyes with her." + Environment.NewLine + Environment.NewLine;
                    rtbMessage.Text += "You: Are you ready, Cementha" + Environment.NewLine;
                    rtbMessage.Text += "Cementha: Yes, Billding, I am!";
                    rtbMessage.Text += Environment.NewLine + Environment.NewLine;
                }

                else if (btnContinueTimes == 1)
                {
                    rtbMessage.Text += "potato";
                    rtbMessage.Text += Environment.NewLine + Environment.NewLine;
                    
                }

                else if (btnContinueTimes == 2)
                {
                    rtbMessage.Text += "The end" + Environment.NewLine;
                    rtbMessage.Text += "Click the button to see where you should go next.";
                    
                }
                else if (btnContinueTimes == 3)
                {
                    btnContinue.Visible = false;
                    System.Diagnostics.Process.Start("https://www.biblegateway.com");
                }
            }
            else if (LovePoints == 69)
            {
                rtbMessage.Text += "This is the secret sex message";
            }

            btnContinueTimes++;
        }
    }
}
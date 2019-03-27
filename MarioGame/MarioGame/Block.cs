using System.Drawing;
using System.Windows.Forms;

namespace MarioGame
{
    internal class Block
    {
        internal PictureBox block;

        internal Block(Point p, string s)
        {
            block = new PictureBox();
            block.Parent = Engine.form;
            block.Size = new Size(Engine.x, Engine.x);
            block.Left = p.X; block.Top = p.Y;
            block.Tag = "block";

            block.Name = s;
            switch (s)
            {
                case "land":
                    {
                        block.Image = Resources.landImage;
                        break;
                    }
                case "brick":
                    {
                        block.Image = Resources.brickImage;
                        break;
                    }
                case "questionMark ":
                    {
                        block.Image = Resources.questionMarkImage;
                        break;
                    }
                case "invincible":
                    {
                        block.Image = Resources.invincibleImage;
                        break;
                    }
                case "pipe1":
                    {
                        block.Image = Resources.pipeImages[0];
                        break;
                    }
                case "pipe2":
                    {
                        block.Image = Resources.pipeImages[1];
                        break;
                    }
                case "pipe3":
                    {
                        block.Image = Resources.pipeImages[2];
                        break;
                    }
                case "pipe4":
                    {
                        block.Image = Resources.pipeImages[3];
                        break;
                    }
                case "flag1":
                    {
                        block.Image = Resources.flagImages[0];
                        break;
                    }
                case "flag2":
                    {
                        block.Image = Resources.flagImages[1];
                        break;
                    }
            }
            block.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarioGame
{
    internal static class Resources
    {
        internal static int[,] levelOne;
        internal static Block[,] b;
        internal static List<Enemy> levelOneEnemies = new List<Enemy>();
        internal static List<Bonus> levelOneBonuses = new List<Bonus>();
        internal static List<Fireball> fireballs = new List<Fireball>();
        #region Imgaes
        internal static Image landImage = Image.FromFile(@"../../Images/land.png");
        internal static Image brickImage = Image.FromFile(@"../../Images/brick.png");
        internal static Image questionMarkImage = Image.FromFile(@"../../Images/questionMark.png");
        internal static Image disabledQImage = Image.FromFile(@"../../Images/disabledQ.png");
        internal static Image invincibleImage = Image.FromFile(@"../../Images/invincible.png");
        internal static Image[] pipeImages = new Image[]
        {
            Image.FromFile(@"../../Images/pipe1.png"),
            Image.FromFile(@"../../Images/pipe2.png"),
            Image.FromFile(@"../../Images/pipe3.png"),
            Image.FromFile(@"../../Images/pipe4.png")
        };
        internal static Image[] flagImages = new Image[]
        {
            Image.FromFile(@"../../Images/flag1.png"),
            Image.FromFile(@"../../Images/flag2.png")
        };
        internal static Image mushroomImage = Image.FromFile(@"../../Images/mushroom.png");
        internal static Image flowerImage = Image.FromFile(@"../../Images/flower.png");
        internal static Image oneUpImage = Image.FromFile(@"../../Images/oneUp.png");
        #endregion

        internal static void Init()
        {
            b = new Block[212, 14];
            levelOne = new int[212, 14];
            GetLevelOneBlocks();
            GetLevelOneEnemies();
        }

        #region GetAttributes
        static MyAttribute getAtribute(blocks b)
        {
            return (MyAttribute)Attribute.GetCustomAttribute(
                typeof(blocks).GetField(Enum.GetName(typeof(blocks), b)),
                typeof(MyAttribute));
        }
        static Block getBlock(blocks b, Point p)
        {
            MyAttribute local = getAtribute(b);
            Block r = new Block(p, local.tag);
            return r;
        }

        static MyAttribute getAtribute(enemies en)
        {
            return (MyAttribute)Attribute.GetCustomAttribute(
                typeof(enemies).GetField(Enum.GetName(typeof(enemies), en)),
                typeof(MyAttribute));
        }
        static Enemy getEnemy(enemies en, Point p)
        {
            MyAttribute local = getAtribute(en);
            Enemy r = new Enemy(p, local.tag);
            return r;
        }

        static MyAttribute getAtribute(bonus b)
        {
            return (MyAttribute)Attribute.GetCustomAttribute(
                typeof(bonus).GetField(Enum.GetName(typeof(bonus), b)),
                typeof(MyAttribute));
        }
        internal static Bonus getBonus(bonus b, Point p)
        {
            MyAttribute local = getAtribute(b);
            Bonus r = new Bonus(p, local.tag);
            return r;
        }
        #endregion

        internal static void GetLevelOneBlocks()
        {
            #region Land
            for (int i = 0; i < 212; i++)
            {
                if (i == 70 || i == 71 || i == 87 || i == 88 || i == 89 || i == 153 || i == 154)
                    continue;
                levelOne[i, 12] = 1;
                levelOne[i, 13] = 1;
            }
            #endregion

            #region Brick
            levelOne[20, 8] = 2; levelOne[22, 8] = 2; levelOne[24, 8] = 2;
            levelOne[77, 8] = 2; levelOne[79, 8] = 2;
            for (int i = 80; i < 88; i++)
                levelOne[i, 4] = 2;
            levelOne[91, 4] = 2; levelOne[92, 4] = 2; levelOne[93, 4] = 2;
            levelOne[100, 8] = 2;
            levelOne[118, 8] = 2;
            levelOne[121, 4] = 2; levelOne[122, 4] = 2; levelOne[123, 4] = 2;
            levelOne[128, 4] = 2; levelOne[129, 8] = 2; levelOne[130, 8] = 2; levelOne[131, 4] = 2;
            levelOne[168, 8] = 2; levelOne[169, 8] = 2; levelOne[171, 8] = 2;
            #endregion

            #region QuestionMark
            levelOne[16, 8] = 3; levelOne[21, 8] = 3; levelOne[23, 8] = 3; levelOne[22, 4] = 3;
            levelOne[64, 7] = 3;
            levelOne[78, 8] = 3;
            levelOne[94, 4] = 3; levelOne[94, 8] = 3;
            levelOne[101, 8] = 3;
            levelOne[106, 8] = 3; levelOne[109, 8] = 3; levelOne[112, 8] = 3; levelOne[109, 4] = 3;
            levelOne[129, 4] = 3; levelOne[130, 4] = 3;
            levelOne[170, 8] = 3;
            #endregion

            #region Invincible
            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    levelOne[134 + j, 11 - i] = 4;
                    levelOne[143 - j, 11 - i] = 4;
                    levelOne[148 + j, 11 - i] = 4;
                    levelOne[158 - j, 11 - i] = 4;
                }
                levelOne[152, 11 - i] = 4;
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = i; j < 8; j++)
                    levelOne[181 + j, 11 - i] = 4;
                levelOne[189, 11 - i] = 4;
            }
            levelOne[198, 11] = 4;
            #endregion

            #region Pipe
            levelOne[28, 10] = 5; levelOne[29, 10] = 6; levelOne[28, 11] = 7; levelOne[29, 11] = 8;

            levelOne[38, 9] = 5; levelOne[39, 9] = 6;
            for (int i = 10; i < 12; i++)
            {
                levelOne[38, i] = 7; levelOne[39, i] = 8;
            }

            levelOne[46, 8] = 5; levelOne[47, 8] = 6;
            levelOne[57, 8] = 5; levelOne[58, 8] = 6;
            for (int i = 9; i < 12; i++)
            {
                levelOne[46, i] = 7; levelOne[47, i] = 8;
                levelOne[57, i] = 7; levelOne[58, i] = 8;
            }

            levelOne[163, 10] = 5; levelOne[164, 10] = 6; levelOne[163, 11] = 7; levelOne[164, 11] = 8;
            levelOne[179, 10] = 5; levelOne[180, 10] = 6; levelOne[179, 11] = 7; levelOne[180, 11] = 8;
            #endregion

            #region Flag
            levelOne[198, 2] = 9;
            for (int i = 3; i < 11; i++)
                levelOne[198, i] = 10;
            #endregion

            #region Block Attributes
            for (int i = 0; i < 212; i++)
                for (int j = 0; j < 14; j++)
                    if (levelOne[i, j] != 0)
                        switch (levelOne[i, j])
                        {
                            case 1:
                                {
                                    b[i, j] = getBlock(blocks.land, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 2:
                                {
                                    b[i, j] = getBlock(blocks.brick, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 3:
                                {
                                    b[i, j] = getBlock(blocks.questionMark, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 4:
                                {
                                    b[i, j] = getBlock(blocks.invincible, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 5:
                                {
                                    b[i, j] = getBlock(blocks.pipe1, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 6:
                                {
                                    b[i, j] = getBlock(blocks.pipe2, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 7:
                                {
                                    b[i, j] = getBlock(blocks.pipe3, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 8:
                                {
                                    b[i, j] = getBlock(blocks.pipe4, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 9:
                                {
                                    b[i, j] = getBlock(blocks.flag1, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                            case 10:
                                {
                                    b[i, j] = getBlock(blocks.flag2, new Point(i * Engine.x, j * Engine.x));
                                    break;
                                }
                        }

            b[16, 8].block.Name = b[23, 8].block.Name = b[22, 4].block.Name = b[94, 4].block.Name
                = b[106, 8].block.Name = b[109, 8].block.Name = b[112, 8].block.Name
                = b[129, 4].block.Name = b[130, 4].block.Name = b[170, 8].block.Name = "questionMark 0";
            b[21, 8].block.Name = b[78, 8].block.Name = b[109, 4].block.Name = "questionMark mushroom";
            b[64, 7].block.Name = "questionMark oneUp"; b[64, 7].block.Image = null;
            b[101, 8].block.Name = "questionMark star";
            #endregion
        }

        internal static void GetLevelOneEnemies()
        {
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(22 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(40 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(51 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(52 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(80 * Engine.x, 3 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(80 * Engine.x, 3 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(97 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(99 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.turtle, new Point(107 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(114 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(115 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(123 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(125 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add( getEnemy(enemies.goomba, new Point(127 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(129 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(175 * Engine.x, 11 * Engine.x)));
            levelOneEnemies.Add(getEnemy(enemies.goomba, new Point(176 * Engine.x, 11 * Engine.x)));
        }
    }
}

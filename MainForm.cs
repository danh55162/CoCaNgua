using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaNgua
{
    public partial class MainForm : Form
    {
        // Create Controls
        Button[] Square = new Button[56];
        Button[] InHouse = new Button[4];
        Button[,] FinishSquare = new Button[4, 6];

        // Create Players
        Players RedPlayer = new Players();
        Players BluePlayer = new Players();
        Players YellowPlayer = new Players();
        Players GreenPlayer = new Players();
        #region Method
        public MainForm()
        {
            InitializeComponent();
            DesignGame();
            RedPlayer.SortNumber = PlayerIndex.RedIndex;
            RedPlayer.Name = PlayerIndex.RedName;
            BluePlayer.SortNumber = PlayerIndex.BlueIndex;
            BluePlayer.Name = PlayerIndex.BlueName;
            YellowPlayer.SortNumber = PlayerIndex.YellowIndex;
            YellowPlayer.Name = PlayerIndex.YellowName;
            GreenPlayer.SortNumber = PlayerIndex.YellowIndex;
            GreenPlayer.Name = PlayerIndex.GreenName;

        }


        
        private void DesignGame()
        {
            #region CreateAndColorSquare
            // 
            // CreateButtonArray/Property
            //
            for (int i = 0; i < 56; i++)
            {
                Square[i] = new Button()
                {
                    FlatStyle = FlatStyle.Flat,
                    Enabled = false,
                    Size = new Size(34, 34),
                };
                Square[i].FlatAppearance.BorderSize = 2;
                if (i < 13)
                {
                    Square[i].FlatAppearance.BorderColor = Color.Red;
                }
                else if (i < 27)
                {
                    Square[i].FlatAppearance.BorderColor = Color.Blue;
                }
                else if (i < 41)
                {
                    Square[i].FlatAppearance.BorderColor = Color.Yellow;
                }
                else
                {
                    Square[i].FlatAppearance.BorderColor = Color.Green;
                    if (i == 55)
                    {
                        Square[i].FlatAppearance.BorderColor = Color.Red;
                    }
                }
                this.Controls.Add(Square[i]);
            }

            //
            // DrawStartButton
            //
            Square[0].BackgroundImage = global::CoCaNgua.Properties.Resources.RedStart;
            Square[14].BackgroundImage = global::CoCaNgua.Properties.Resources.BlueStart;
            Square[28].BackgroundImage = global::CoCaNgua.Properties.Resources.YellowStart;
            Square[42].BackgroundImage = global::CoCaNgua.Properties.Resources.GreenStart;
            #endregion

            #region SetSquareLocation
            // 
            // SetSquareLocation
            //
            int SquareWidth = 270, SquareHeight = 52;
            for (int t = 0; t < 56; t++)
            {
                if (t == 13 || t == 27 || t == 41 || t == 55)
                {
                    // Finish Square
                    switch (t)
                    {
                        case 13: SquareHeight += 54;
                            break;
                        case 27: SquareWidth += 54;
                            break;
                        case 41: SquareHeight -= 54;
                            break;
                        case 55: SquareWidth -= 54;
                            break;
                    }
                }
                else if (t % 14 == 0)
                {
                    // Next to Finish Square
                    switch (t)
                    {
                        case 14: SquareHeight += 54;
                            break;
                        case 28: SquareWidth += 54;
                            break;
                        case 42: SquareHeight -= 54;
                            break;
                        case 56: SquareWidth -= 54;
                            break;
                    }
                }
                else
                {
                    // Normal Square
                    switch (t / 7)
                    {
                        case 0:
                        case 3: SquareHeight += 40;
                            break;
                        case 1:
                        case 6: SquareWidth -= 40;
                            break;
                        case 2:
                        case 5: SquareWidth += 40;
                            break;
                        case 4:
                        case 7: SquareHeight -= 40;
                            break;
                        default:
                            break;
                    }
                }
                Square[t].Location = new Point(SquareWidth, SquareHeight);
            }
            #endregion

            #region CreateAndDrawHouse

            // 
            // DrawHouse
            //

            Button RedHouse = new Button();
            Button BlueHouse = new Button();
            Button YellowHouse = new Button();
            Button GreenHouse = new Button();
            DrawHouse(RedHouse, 29, 51, Color.Red);
            DrawHouse(BlueHouse, 29, 440, Color.Blue);
            DrawHouse(YellowHouse, 417, 440, Color.Yellow);
            DrawHouse(GreenHouse, 417, 51, Color.Green);
            //
            // DrawHorse
            //
            // i : For each House
            // t : For each InHouse (Horse)
            int Width = 60, Height = 80;
            for (int i = 0; i < 4; i++)
            {
                // Set Main Location for each color
                switch (i)
                {
                    case 1: Height += 480;
                        break;
                    case 2: Width += 478;
                        break;
                    case 3: Height -= 480;
                        break;
                }
                // Create InHouse Horse (Array)
                for (int t = 0; t < 4; t++)
                {
                    InHouse[t] = new Button()
                    {
                        Size = new Size(32, 32),
                        Enabled = false,
                        FlatStyle = FlatStyle.Flat
                    };
                    switch (t)
                    {
                        // Draw Horse in each house
                        case 0: InHouse[t].Location = new Point(Width, Height);
                            break;
                        case 1: InHouse[t].Location = new Point(Width + 50, Height);
                            break;
                        case 2: InHouse[t].Location = new Point(Width, Height + 50);
                            break;
                        case 3: InHouse[t].Location = new Point(Width + 50, Height + 50);
                            break;
                    }
                    switch (i)
                    {
                        // Design Horse
                        case 0:
                            {
                                InHouse[t].BackgroundImage = global::CoCaNgua.Properties.Resources.RedHorse;
                                InHouse[t].FlatAppearance.BorderColor = Color.Red;
                            }
                            break;
                        case 1:
                            {
                                InHouse[t].BackgroundImage = global::CoCaNgua.Properties.Resources.BlueHorse;
                                InHouse[t].FlatAppearance.BorderColor = Color.Blue;
                            }
                            break;
                        case 2:
                            {
                                InHouse[t].BackgroundImage = global::CoCaNgua.Properties.Resources.YellowHorse;
                                InHouse[t].FlatAppearance.BorderColor = Color.Yellow;
                            }
                            break;
                        case 3:
                            {
                                InHouse[t].BackgroundImage = global::CoCaNgua.Properties.Resources.GreenHorse;
                                InHouse[t].FlatAppearance.BorderColor = Color.Green;
                            }
                            break;
                    }
                    this.Controls.Add(InHouse[t]);
                    InHouse[t].BringToFront();
                }
            }

            #endregion

            #region CreateAndDrawFinishSquare

            string Location = "C:\\Users\\nguye\\Desktop\\CoCaNgua\\CoCaNgua\\FinishImage\\";
            int FinishWidth = 310, FinishHeight = 331;
            int k = 40;
            for (int i = 0; i < 4; i++)
            {
                for (int t = 5; t >= 0; t--)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                string ImgLocation = Location + (t + 1).ToString() + "Red" + ".png";
                                FinishSquare[i, t] = new Button()
                                {
                                    Enabled = false,
                                    Location = new Point(FinishWidth, FinishHeight - k),
                                    Size = new Size(64, 32),
                                    BackgroundImage = new Bitmap(ImgLocation),
                                };
                                FinishSquare[i, t].FlatStyle = FlatStyle.Flat;
                                FinishSquare[i, t].FlatAppearance.BorderColor = Color.Red;
                            }
                            break;
                        case 1:
                            {
                                string ImgLocation = Location + (t + 1).ToString() + "Blue" + ".png";
                                FinishSquare[i, t] = new Button()
                                {
                                    Enabled = false,
                                    Location = new Point(FinishWidth - k, FinishHeight),
                                    Size = new Size(32, 64),
                                    BackgroundImage = new Bitmap(ImgLocation),
                                };
                                FinishSquare[i, t].FlatStyle = FlatStyle.Flat;
                                FinishSquare[i, t].FlatAppearance.BorderColor = Color.Blue;
                            }
                            break;
                        case 2:
                            {
                                string ImgLocation = Location + (t + 1).ToString() + "Yellow" + ".png";
                                FinishSquare[i, t] = new Button()
                                {
                                    Enabled = false,
                                    Location = new Point(FinishWidth, FinishHeight + k + 30),
                                    Size = new Size(64, 32),
                                    BackgroundImage = new Bitmap(ImgLocation),
                                };
                                FinishSquare[i, t].FlatStyle = FlatStyle.Flat;
                                FinishSquare[i, t].FlatAppearance.BorderColor = Color.Yellow;
                            }
                            break;
                        case 3:
                            {
                                string ImgLocation = Location + (t + 1).ToString() + "Green" + ".png";
                                FinishSquare[i, t] = new Button()
                                {
                                    Enabled = false,
                                    Location = new Point(FinishWidth + k + 30, FinishHeight),
                                    Size = new Size(32, 64),
                                    BackgroundImage = new Bitmap(ImgLocation),
                                };
                                FinishSquare[i, t].FlatStyle = FlatStyle.Flat;
                                FinishSquare[i, t].FlatAppearance.BorderColor = Color.Green;
                            }
                            break;
                    }
                    k += 40;
                    this.Controls.Add(FinishSquare[i, t]);
                }
                k = 40;
            }

            #endregion

            #region CenterSquare
            PictureBox CenterSquare = new PictureBox()
            {
                Location = new Point(FinishWidth, FinishHeight),
                Size = new Size(64, 64),
                Image = global::CoCaNgua.Properties.Resources.Center,
            };
            this.Controls.Add(CenterSquare);
            #endregion

            #region NameButton

            Button btnRedHouse = new Button();
            DrawName(btnRedHouse, 130, 225, Color.Red);
            Button btnBlueHouse = new Button();
            DrawName(btnBlueHouse, 130, 471, Color.Blue);
            Button btnYellowName = new Button();
            DrawName(btnYellowName, 450, 471, Color.Yellow);
            Button btnGreenName = new Button();
            DrawName(btnGreenName, 450, 225, Color.Green);

            #endregion
            
        }

        #endregion

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInfo Info = new FormInfo();
            Info.ShowDialog();
        }
    }
}

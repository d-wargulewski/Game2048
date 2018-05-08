using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    public partial class Game : Form
    {
        #region Variables
        private Button[,] btnTab;
        int iDirection = 0; // 0 = up, 1 = down, 2 = left, 3 = right
        int iScore = 0;
        int iTolerance = 30; // touchpad tolerance
        bool bChange = false;
        bool bChangeOnBoard;
        Point pStart;
        Point pEnd;
        #endregion

        #region Methods
        public Game()
        {
            InitializeComponent();

            // array initialization
            btnTab = new Button[/*A,B,C,D*/,/*1,2,3,4*/]
            {   { A1, A2, A3, A4 },
                { B1, B2, B3, B4 },
                { C1, C2, C3, C4 },
                { D1, D2, D3, D4 }  };
        }

        private bool SetDirection(KeyEventArgs e)
        {
            // 0 = up, 1 = down, 2 = left, 3 = right

                 if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) { iDirection = 0; return true; }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) { iDirection = 1; return true; }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) { iDirection = 2; return true; }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) { iDirection = 3; return true; }

            else { return false; }
        }

        private void SetDirection(string direction)
        {
            // 0 = up, 1 = down, 2 = left, 3 = right
                 if (direction == "up") this.iDirection = 0;
            else if (direction == "down") this.iDirection = 1;
            else if (direction == "left") this.iDirection = 2;
            else if (direction == "right") this.iDirection = 3;
        }

        private bool GameMove()
        {
            bChange = false;
            
            // Cycle: sort, add, sort
            #region UP
            if (iDirection == 0) // up
            {
                // sort
                do
                {
                    bChangeOnBoard = false;

                    // move
                    for (int h = 0; h <= 3; h++) // horizontal
                    {
                        for (int v = 0; v <= 2; v++) // vertical
                        {
                            if (btnTab[v, h].Text == "" & btnTab[v + 1, h].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v + 1, h].Text;
                                btnTab[v + 1, h].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);


                // add
                for (int h = 0; h <= 3; h++) // horizontal
                {
                    for (int v = 0; v <= 2; v++) // vertical
                    {
                        if (btnTab[v, h].Text == btnTab[v + 1, h].Text && btnTab[v, h].Text != "")
                        {
                            iScore += (int.Parse(btnTab[v, h].Text) * 2);
                            btnTab[v, h].Text = (int.Parse(btnTab[v, h].Text) * 2).ToString();
                            btnTab[v + 1, h].Text = "";

                            bChange = true;
                        }
                    }
                }


                // sort
                do
                {
                    bChangeOnBoard = false;

                    for (int h = 0; h <= 3; h++) // horizontal
                    {
                        for (int v = 0; v <= 2; v++) // vertical
                        {
                            if (btnTab[v, h].Text == "" & btnTab[v + 1, h].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v + 1, h].Text;
                                btnTab[v + 1, h].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);
            }
            #endregion
            #region DOWN
            if (iDirection == 1) // down
            {
                // Cycle: sort, add, sort

                // sort
                do
                {
                    bChangeOnBoard = false;

                    for (int h = 0; h <= 3; h++) // horizontal
                    {
                        for (int v = 3; v > 0; v--) // vertical
                        {
                            if (btnTab[v, h].Text == "" & btnTab[v - 1, h].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v - 1, h].Text;
                                btnTab[v - 1, h].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);


                // add
                for (int h = 0; h <= 3; h++) // horizontal
                {
                    for (int v = 3; v > 0; v--) // vertical
                    {
                        if (btnTab[v, h].Text == btnTab[v - 1, h].Text && btnTab[v, h].Text != "")
                        {
                            iScore += (int.Parse(btnTab[v, h].Text) * 2);
                            btnTab[v, h].Text = (int.Parse(btnTab[v, h].Text) * 2).ToString();
                            btnTab[v - 1, h].Text = "";
                            bChange = true;
                        }
                    }
                }


                // sort
                do
                {
                    bChangeOnBoard = false;

                    for (int h = 0; h <= 3; h++) // horizontal
                    {
                        for (int v = 3; v > 0; v--) // vertical
                        {
                            // Przesun
                            if (btnTab[v, h].Text == "" & btnTab[v - 1, h].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v - 1, h].Text;
                                btnTab[v - 1, h].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);
            }
            #endregion
            #region LEFT
            if (iDirection == 2) // left
            {
                // Cycle: sort, add, sort

                // sort
                do
                {
                    bChangeOnBoard = false;

                    for (int v = 0; v <= 3; v++) // vertical
                    {
                        for (int h = 0; h <= 2; h++) // horizontal
                        {
                            if (btnTab[v, h].Text == "" & btnTab[v, h + 1].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v, h + 1].Text;
                                btnTab[v, h + 1].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);


                // add
                for (int v = 0; v <= 3; v++) // vertical
                {
                    for (int h = 0; h <= 2; h++) // horizontal
                    {
                        if (btnTab[v, h].Text == btnTab[v, h + 1].Text && btnTab[v, h].Text != "")
                        {
                            iScore += (int.Parse(btnTab[v, h].Text) * 2);
                            btnTab[v, h].Text = (int.Parse(btnTab[v, h].Text) * 2).ToString();
                            btnTab[v, h + 1].Text = "";
                            bChange = true;
                        }
                    }
                }


                // sort
                do
                {
                    bChangeOnBoard = false;

                    for (int v = 0; v <= 3; v++) // vertical
                    {
                        for (int h = 0; h <= 2; h++) // horizontal
                        {
                            if (btnTab[v, h].Text == "" & btnTab[v, h + 1].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v, h + 1].Text;
                                btnTab[v, h + 1].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);
            }
            #endregion
            #region RIGHT
            if (iDirection == 3) // right
            {
                // Cycle: sort, add, sort

                // sort
                do
                {
                    bChangeOnBoard = false;

                    for (int v = 0; v <= 3; v++) // vertical
                    {
                        for (int h = 3; h >= 1; h--) // horizontal
                        {
                            if (btnTab[v, h].Text == "" & btnTab[v, h - 1].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v, h - 1].Text;
                                btnTab[v, h - 1].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);


                // add
                for (int v = 0; v <= 3; v++) // vertical
                {
                    for (int h = 3; h > 0; h--) // horizontal
                    {
                        if (btnTab[v, h].Text == btnTab[v, h - 1].Text && btnTab[v, h].Text != "")
                        {
                            iScore += (int.Parse(btnTab[v, h].Text) * 2);
                            btnTab[v, h].Text = (int.Parse(btnTab[v, h].Text) * 2).ToString();
                            btnTab[v, h - 1].Text = "";
                            bChange = true;
                        }
                    }
                }


                // sort
                do
                {
                    bChangeOnBoard = false;

                    for (int v = 0; v <= 3; v++) // vertical
                    {
                        for (int h = 3; h >= 1; h--) // horizontal
                        {
                            if (btnTab[v, h].Text == "" & btnTab[v, h - 1].Text != "")
                            {
                                btnTab[v, h].Text = btnTab[v, h - 1].Text;
                                btnTab[v, h - 1].Text = "";

                                bChangeOnBoard = true;
                                bChange = true;
                            }
                        }
                    }
                } while (bChangeOnBoard);
            }
            #endregion

            return bChange;
        }

        private void UpdateScore()
        {
            scoreButton.Text = "Score: " + iScore.ToString();
        }

        private void GenerateField()
        {
            // array initialization
            // 16 - max records
            // 0 - horizontal
            // 1 - vertical
            int[,] iEmptyFields = new int[16, 2];

            int iNumberOfRecords = 0;
            for (int h = 0; h <= 3; h++) // horizontal
            {
                for (int v = 0; v <= 3; v++) // vertical
                {
                    if (btnTab[h, v].Text == String.Empty)
                    {
                        iEmptyFields[iNumberOfRecords, 0] = h;
                        iEmptyFields[iNumberOfRecords, 1] = v;
                        iNumberOfRecords++;
                    }
                }
            }

            if (iNumberOfRecords == 0)
            {
                // 
            }
            else
            {
                Random rdmDrawNumber = new Random();
                int record = rdmDrawNumber.Next(0, iNumberOfRecords);

                btnTab[ iEmptyFields[record,0], iEmptyFields[record,1] ].Text = "2";
            }
        }

        private void UpdateFieldsColor()
        {
            for (int h = 0; h <= 3; h++) // horizontal
            {
                for (int v = 0; v <= 3; v++) // vertical
                {
                    switch (btnTab[h, v].Text)
                    {
                        case "":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(204, 192, 180);
                            break;
                        case "2":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(250, 250, 240);
                            break;
                        case "4":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(236, 224, 200);
                            break;
                        case "8":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(242, 177, 121);
                            break;
                        case "16":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(236, 141, 83);
                            break;
                        case "32":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(245, 125, 95);
                            break;
                        case "64":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(233, 90, 55);
                            break;
                        case "128":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(243, 217, 107);
                            break;
                        case "256":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(241, 208, 75);
                            break;
                        case "512":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(228, 192, 42);
                            break;
                        case "1024":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(227, 186, 20);
                            break;
                        case "2048":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(236, 196, 0);
                            break;
                        case "4096":
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(94, 218, 146);
                            break;
                        default:
                            btnTab[h, v].BackColor = System.Drawing.Color.FromArgb(94, 218, 146);
                            break;
                    }
                }
            }
        }

        private void NewGameClick(object sender, EventArgs e)
        {
            foreach (Button btn in btnTab)
                btn.Text = "";

            iScore = 0;
            scoreButton.Text = "Score: " + iScore.ToString();

            GenerateField();
            UpdateFieldsColor();
        }

        private void _2048_KeyDown(object sender, KeyEventArgs e)
        {
            if (SetDirection(e) == true)
            {
                if (GameMove() == true)
                {
                    GenerateField();
                    UpdateScore();
                    UpdateFieldsColor();
                }
            }
        }
        #endregion

        #region TouchPad
        private void TouchPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pStart = MousePosition;
        }

        private void touchPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // Variables
            pEnd = MousePosition;
            string where = "";

            // Vectors
            Point v1_p = new Point(t_screen.Size.Width / 2, t_screen.Size.Height / 2);
            Point v1_k = new Point(t_screen.Size.Width, t_screen.Size.Height / 2);
            Point v1   = new Point(v1_k.X - v1_p.X, v1_k.Y - v1_p.Y);

            Point v2_p = new Point(pStart.X, pStart.Y);
            Point v2_k = new Point(pEnd.X, pEnd.Y);
            Point v2   = new Point(v2_k.X - v2_p.X, v2_k.Y * (-1) - v2_p.Y * (-1));

            // Two vectors Scalar Product
            double ScalarProduct = (v1.X * v2.X + v1.Y * v2.Y);

            // Vectors lengths
            double v_length1 = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2));
            double v_length2 = Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2));

            // Cos alfa
            double dCosAlfa = ScalarProduct / (v_length1 * v_length2);

            int iAngle = (int)(((Math.Acos(dCosAlfa) / Math.PI) * 2) * 90);

            if (v2.Y < 0)
                iAngle = iAngle * (-1);


            if (iAngle >= (0 - iTolerance) && iAngle <= (0 + iTolerance))
                where = "right";
            else if (iAngle >= (90 - iTolerance) && iAngle <= (90 + iTolerance))
                where = "up";
            else if (iAngle >= (180 - iTolerance) && iAngle <= 180 | iAngle <= (-180 + iTolerance) && iAngle >= -180)
                where = "left";
            else if (iAngle <= (-90 + iTolerance) && iAngle >= (-90 - iTolerance))
                where = "down";
            else
                where = "";

            SetDirection(where);
            where = "";

            GameMove();
            UpdateScore();

            if (bChange == true)
            {
                GenerateField();
                bChange = false;
            }

            UpdateFieldsColor();
        }
        #endregion
    }
}

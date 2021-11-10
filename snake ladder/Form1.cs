using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_ladder
{
    public partial class Form1 : Form
    {
        Button[] buttons = null;
        Random random = new Random();
        int Lines;
        bool turn = true;
        public Form1()
        {
            InitializeComponent();
        }



        //בניית לוח המשחק 

        public void initBoard()
        {
            
            board_game.Controls.Clear();
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);

            Graphics gr = board_game.CreateGraphics();
            Pen MyPen = new Pen(Brushes.Black, 4);

            int Size_board = random.Next(4, 10);
            //int Size_board = 4;
            this.buttons = new Button[Size_board * Size_board];

            pictureBox1.Tag = 0;
            pictureBox2.Tag = 0;

            Lines = Convert.ToInt32(Size_board);

            //int Lines = Convert.ToInt32(10);
            float x = 0f;
            float y = 0f;
            float X_Space = ((board_game.Width - MyPen.Width) * 1.0f / Lines);
            float Y_Space = ((board_game.Height - MyPen.Width) * 1.0f / Lines);
            Font MyFont = new Font("Arial", (board_game.Width <= board_game.Height)
                ? X_Space / 3 : Y_Space / 3);

            for (int i = 0; i < Lines; i++)
            {
                gr.DrawLine(MyPen, x, y, x, Y_Space * Lines);
                x += X_Space;
            }


            x = 0f;

            for (int i = 0; i < Lines; i++)
            {
                gr.DrawLine(MyPen, x, y, X_Space * Lines, y);
                y += Y_Space;
            }

            x = 0f;
            y = 0f;
            int Counter = Lines * Lines - 1;

            int top = 0, left = 0;
            int golds = 2;

            for (int text_i = Lines -1; text_i >= 0 ; text_i--)
            {
                for (int text_j = Lines -1 ; text_j >= 0 ; text_j--)
                {
                    Button l = new Button();
                    l.Width = (int)X_Space;
                    l.Height = (int)Y_Space;
                    l.Text = Counter.ToString();
                    l.Top = top;
                    l.Left = left;
                    l.FlatStyle = FlatStyle.Flat;
                    
                    
                    if (Counter < Lines * Lines - 1)
                    {
                        if (random.Next(3) == 1)
                        {
                            int randomIndex = Counter;

                            int midLength = (Lines * Lines - 1) / 2;

                            if (golds > 0 && randomIndex < midLength)
                            {
                                l.Tag = -1;
                                golds--;
                                l.BackColor = Color.Gold;
                            }
                            else
                            {


                                while (randomIndex == Counter)
                                {
                                    randomIndex = random.Next(Size_board * Size_board - 1);
                                }

                                if (randomIndex < Counter)
                                    l.BackColor = Color.Red;
                                else
                                    l.BackColor = Color.AliceBlue;

                                l.Tag = randomIndex;
                            }

                        }
                    }
                   



                    buttons[Counter] = l;


                    board_game.Controls.Add(l);


                    x += X_Space;
                    left += (int)X_Space;

                    Counter--;
                }
                y += Y_Space;
                top += (int)Y_Space;
                left = 0;
                x = 0f;

            }
        }


        private void Start_Click(object sender, EventArgs e)
        {
            GameCube.Enabled = true;
            initBoard();

        }

        private Button getCell(int value)
        {
            foreach (Button button in buttons)
            {
                if (button.Text == value.ToString())
                {
                    return button;
                }
            }
            return null;
        }

        private void clearBorders()
        {
            foreach (Button button in buttons)
            {
                button.FlatAppearance.BorderColor = Color.Black;
                button.FlatAppearance.BorderSize = 1;
            }
        }
        bool isGloded = false;
        private void updateSolider(PictureBox pictureBox, int Roll)
        {
            clearBorders();


            bluePositionLbl.Text = ((int)(pictureBox1.Tag)).ToString() + " - ";
            redPositionLbl.Text = ((int)(pictureBox2.Tag)).ToString() + " - ";


            Button prevCell = getCell((int)(pictureBox.Tag));
            prevCell.FlatAppearance.BorderColor = Color.Green;
            prevCell.FlatAppearance.BorderSize = 3;

            pictureBox.Tag = (int)(pictureBox.Tag) + Roll;

            if ((int)(pictureBox.Tag) + Roll < Lines * Lines)
            {
                Button nextCell = getCell((int)(pictureBox.Tag));
                if (nextCell != null)
                {
                    nextCell.FlatAppearance.BorderColor = Color.Green;
                    nextCell.FlatAppearance.BorderSize = 3;
                }




                prevCell.Controls.Remove(pictureBox);
                nextCell.Controls.Add(pictureBox);

                if (nextCell.Tag != null)
                {

                    if ((int)nextCell.Tag == -1)
                    {

                        

                        int bluePostition = (int)pictureBox1.Tag;
                        int redPostition = (int)pictureBox2.Tag;

                        if ((turn && bluePostition < redPostition) || (!turn && bluePostition > redPostition))
                        {
                            isGloded = true;
                            Button blueCell = getCell(bluePostition);
                            Button redCell = getCell(redPostition);

                            pictureBox1.Tag = redPostition;
                            pictureBox2.Tag = bluePostition;


                            blueCell.Controls.Clear();
                            blueCell.Controls.Add(pictureBox2);

                            redCell.Controls.Clear();
                            redCell.Controls.Add(pictureBox1);
                        }
                    }
                    else
                    {
                        Button targetCell = getCell((int)nextCell.Tag);
                        pictureBox.Tag = int.Parse(targetCell.Text);
                        prevCell.Controls.Remove(pictureBox);
                        targetCell.Controls.Add(pictureBox);
                    }


                }
            }

            else
            {
                MessageBox.Show(turn ? "הכחול ניצח!" : "האדום ניצח");
                initBoard();
            }

            


            //foreach (Button button in buttons)
            //{
            //    if (int.Parse(button.Text) == (int)(pictureBox.Tag))
            //    {

            //        if (button.Tag != null)
            //        {
            //            if ((int)(button.Tag) == -1)
            //            {
            //                int bluePostition = (int)pictureBox1.Tag;
            //                int redPostition = (int)pictureBox2.Tag;
            //                pictureBox1.Tag = redPostition;
            //                pictureBox2.Tag = bluePostition;

            //                if ((turn && bluePostition < redPostition) || (!turn && bluePostition > redPostition))
            //                {

            //                    Button blueLabel = getCell(bluePostition);
            //                    Button redLabel = getCell(redPostition);

            //                    blueLabel.Controls.Remove(pictureBox1);
            //                    redLabel.Controls.Add(pictureBox2);

            //                    break;
            //                }
            //                else
            //                    button.Controls.Add(pictureBox);
            //            }
            //            else
            //            {
            //                int updatedPosition = (int)(button.Tag);
            //                pictureBox.Tag = updatedPosition;
            //                foreach (Button button1 in buttons)
            //                {
            //                    if (int.Parse(button1.Text) == updatedPosition)
            //                    {
            //                        button1.Controls.Add(pictureBox);
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            button.Controls.Add(pictureBox);
            //        }

                    
            //    }
            //}


            


            bluePositionLbl.Text += ((int)(pictureBox1.Tag)).ToString();
            redPositionLbl.Text += ((int)(pictureBox2.Tag)).ToString();

        }

        private void GameCube_Click(object sender, EventArgs e)
        {

            Random R_Roll = new Random();
            int Roll = R_Roll.Next(1, Lines);
            textBox1.Text = Roll.ToString();
            updateSolider(turn ? pictureBox1 : pictureBox2, Roll);
            turn = !turn;
            if (isGloded)
            {
                turnLbl.BackColor = Color.Gold;
                turnLbl.Text = turn ? "Turn: Blue" : "Turn: Red";
                isGloded = false;
            }
            else
            {
                turnLbl.Text = turn ? "Turn: Blue" : "Turn: Red";
                turnLbl.BackColor = Color.Transparent;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareCircleCross
{
    public partial class Form1 : Form
    {
        public bool MyTurn { get; set; }
        public Pen RedPen = new Pen(Color.Red, 2);
        public Pen BlackPen = new Pen(Color.Black, 2);
        public Rectangle Rectangle { get; set; }
        //public int CompAttCnt = 0;
        public int PlayerMoves = 0;
        //public enum Squares : int    //Not using this correctly
        //{
        //    Sq1,
        //    Sq2,
        //    Sq3,
        //    Sq4,
        //    Sq5,
        //    Sq6,
        //    Sq7,
        //    Sq8,
        //    Sq9
        //}
        
        public List<int> possibleChoices = new List<int>()
        {//Remove from this list as squares are claimed
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8
        };
        
        public Form1()
        {
            InitializeComponent();
        }
        public void CheckWinCondition()
        {
            // Setup variables so if conditions are shorter, and more legible
            var red = Color.Red;
            var blue = Color.Blue;
            var squareOne = Sq1.BackColor;
            var squareTwo = Sq2.BackColor;
            var squareThree = Sq3.BackColor;
            var squareFour = Sq4.BackColor;
            var squareFive = Sq5.BackColor;
            var squareSix = Sq6.BackColor;
            var squareSeven = Sq7.BackColor;
            var squareEight = Sq8.BackColor;
            var squareNine = Sq9.BackColor;

            // Check blue conditions
            //top horiz
            if (squareOne==blue && squareTwo==blue && squareThree == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }
            //mid horiz
            if (squareFour == blue && squareFive == blue && squareSix == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }
            //bottom horiz
            if (squareSeven == blue && squareEight == blue && squareNine == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }
            //left vert
            if (squareOne == blue && squareFour == blue && squareSeven == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }
            //mid vert
            if (squareTwo == blue && squareFive == blue && squareEight == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }
            //right vert
            if (squareThree == blue && squareSix == blue && squareNine == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }
            //upright cross
            if (squareSeven == blue && squareFive == blue && squareThree == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }
            //upleft cross
            if (squareOne == blue && squareFive == blue && squareNine == blue)
            {
                MessageBox.Show("Blue wins!");
                return;
            }


            // Check red conditions
            //top horiz
            if (squareOne == red && squareTwo == red && squareThree == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
            //mid horiz
            if (squareFour == red && squareFive == red && squareSix == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
            //bottom horiz
            if (squareSeven == red && squareEight == red && squareNine == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
            //left vert
            if (squareOne == red && squareFour == red && squareSeven == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
            //mid vert
            if (squareTwo == red && squareFive == red && squareEight == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
            //right vert
            if (squareThree == red && squareSix == red && squareNine == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
            //upright cross
            if (squareSeven == red && squareFive == red && squareThree == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
            //upleft cross
            if (squareOne == red && squareFive == red && squareNine == red)
            {
                MessageBox.Show("red wins!");
                return;
            }
        }
        public void ComputerTurn()
        {
            if (PlayerMoves == 5) return;
            // Random mode first, grab a number 1-9 and check if that square is claimed
            Random rd = new Random();
            int choiceIndex = rd.Next(0,possibleChoices.Count);
            int choiceActual = possibleChoices[choiceIndex];
            ComputerAttempt(choiceActual);
            
        }
        public void ComputerAttempt(int sq)
        {
            CheckWinCondition();
            //CompAttCnt++;
            //Console.WriteLine(CompAttCnt);
            Console.WriteLine(sq);
            switch (sq)
            {
                case 0:
                    if (Sq1.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq1.BackColor = Color.Red;
                        possibleChoices.Remove(0);
                    }
                    break;

                case 1:
                    if (Sq2.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq2.BackColor = Color.Red;
                        possibleChoices.Remove(1);
                    }
                    break;
                case 2:
                    if (Sq3.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq3.BackColor = Color.Red;
                        possibleChoices.Remove(2);
                    }
                    break;
                case 3:
                    if (Sq4.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq4.BackColor = Color.Red;
                        possibleChoices.Remove(3);
                    }
                    break;
                case 4:
                    if (Sq5.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq5.BackColor = Color.Red;
                        possibleChoices.Remove(4);
                    }
                    break;
                case 5:
                    if (Sq6.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq6.BackColor = Color.Red;
                        possibleChoices.Remove(5);
                    }
                    break;
                case 6:
                    if (Sq7.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq7.BackColor = Color.Red;
                        possibleChoices.Remove(6);
                    }
                    break;
                case 7:
                    if (Sq8.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq8.BackColor = Color.Red;
                        possibleChoices.Remove(7);
                    }
                    break;
                case 8:
                    if (Sq9.BackColor == Color.Blue)
                    {
                        ComputerTurn();
                    }
                    else
                    {
                        Sq9.BackColor = Color.Red;
                        possibleChoices.Remove(8);
                    }
                    break;
                default:
                    MessageBox.Show("No more moves!");
                    break;
            }
            CheckWinCondition();
        }

        private void Sq1_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq1.ClientRectangle;
            Sq1.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(0);
            CheckWinCondition();
            ComputerTurn();
        }

        private void Sq2_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq2.ClientRectangle;
            Sq2.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(1);
            CheckWinCondition();
            ComputerTurn();

        }

        private void Sq3_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq3.ClientRectangle;
            Sq3.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(2);
            CheckWinCondition();
            ComputerTurn();

        }

        private void Sq4_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq4.ClientRectangle;
            Sq4.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(3);
            CheckWinCondition();
            ComputerTurn();

        }

        private void Sq5_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq5.ClientRectangle;
            Sq5.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(4);
            CheckWinCondition();
            ComputerTurn();

        }

        private void Sq6_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq6.ClientRectangle;
            Sq6.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(5);
            CheckWinCondition();
            ComputerTurn();

        }

        private void Sq7_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq7.ClientRectangle;
            Sq7.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(6);
            CheckWinCondition();
            ComputerTurn();

        }

        private void Sq8_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq8.ClientRectangle;
            Sq8.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(7);
            CheckWinCondition();
            ComputerTurn();

        }

        private void Sq9_DoubleClick(object sender, EventArgs e)
        {
            Rectangle = Sq9.ClientRectangle;
            Sq9.BackColor = Color.Blue;
            MyTurn = false;
            PlayerMoves++;
            possibleChoices.Remove(8);
            CheckWinCondition();
            ComputerTurn();

        }
    }
}

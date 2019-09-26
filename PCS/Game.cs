using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        int boardSize = SetupForm.size;
        Random rand = new Random(SetupForm.seed);
        int[,] solution, guess;
        List<String> rowList, colList;

        private void Game_Load(object sender, EventArgs e)
        {

            solution = new int[boardSize, boardSize];
            guess = new int[boardSize, boardSize];


            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Box box = new Box();
                    box.Height = 20;
                    box.Width = 20;
                    box.Top = 100 + (20 * i);
                    box.Left = 100 + (20 * j);
                    box.Click += Box_Click;
                    box.BorderStyle = BorderStyle.FixedSingle;
                    box.BackColor = Color.Gray;
                    box.row = i;
                    box.col = j;
                    
                    this.Controls.Add(box);

                    if (rand.Next(0, 3) == 0)
                    {
                        solution[i, j] = 0;
                       // box.BackColor = Color.White;

                    }
                    else
                    {
                        solution[i, j] = 1;
                      //  box.BackColor = Color.Black;

                    }
                }
                //row numbers
                string row = "";
                
                for (int j = 0; j < boardSize; j++)
                {
                    if (j == 0 && solution[i, j] == 0 || j == boardSize - 1 && solution[i, j] == 0)
                    {

                    }
                    else
                    {
                        row += solution[i, j];
                    }

                }

                rowList = new List<String>();


                rowList = row.Split('0').ToList();
                rowList.RemoveAll(item => item =="");
                


                for (int k = 0; k < rowList.Count; k++)
                {

                   

                    Label sideLabel = new Label();
                    sideLabel.Width = 15;
                    sideLabel.Height = 20;
                    sideLabel.Top = 102 + 20 * i;
                    sideLabel.Left = 105 - rowList.Count * 20 + 20 * k;
                    sideLabel.Text = rowList[k].Length.ToString();
                    this.Controls.Add(sideLabel);


                }

            }
            //col numbers
            for (int i = 0; i < boardSize; i++)
            {
                string col = "";
                for (int j = 0; j < boardSize; j++)
                {
                    if (j == 0 && solution[j, i] == 0 || j == boardSize - 1 && solution[j, i] == 0)
                    {

                    }
                    else
                    {
                        col += solution[j, i];
                    }
                }
                colList = new List<String>();
                colList = col.Split('0').ToList();
                colList.RemoveAll(item => item == "");

                for (int k = 0; k < colList.Count; k++)
                {

                    Label sideLabel = new Label();
                    sideLabel.Width = 20;
                    sideLabel.Height = 20;
                    sideLabel.Top =  105 - colList.Count * 20 + 20 * k;
                    sideLabel.Left = 102 + 20 * i;
                    sideLabel.Text = colList[k].Length.ToString();
                    this.Controls.Add(sideLabel);
                }
            }
            this.Size = new Size(boardSize * 70, boardSize * 70);
        }

        private Boolean checkSolution()
        {
            int correctBoxes = 0;
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (guess[i, j] == solution[i, j])
                    {
                        correctBoxes++;
                    }
                }
            }
            if (correctBoxes == boardSize * boardSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Box_Click(object sender, EventArgs e)
        {
            Box boxClicked = (Box)sender;
            
            MouseEventArgs mouseEvent = (MouseEventArgs)e;

            if(mouseEvent.Button == MouseButtons.Left)
            {
                boxClicked.BackColor = Color.Black;
                guess[boxClicked.row, boxClicked.col] = 1;
            }
            else if(mouseEvent.Button == MouseButtons.Right)
            {
                boxClicked.BackColor = Color.White;
                guess[boxClicked.row, boxClicked.col] = 0;
            }
            

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (guess[i,j] == 1 || guess[i,j] ==0)
                    {
                        if (checkSolution() == true)
                        {
                            this.Close();
                            MessageBox.Show("You win");
                        }
                    }
                }
            }
        }
    }
}
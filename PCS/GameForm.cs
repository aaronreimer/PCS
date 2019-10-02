using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PCS
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        int size, seed, seconds, minutes;
        public static bool timed;
        static int[,] guess, solution;
        Random rand;
        List<String> rowList, colList;
        

        private void TxtSize_TextChanged(object sender, EventArgs e)
        {
            lblSize.Text = "x " + txtSize.Text;
        }

        private void BtnBest_Click(object sender, EventArgs e)
        {
            /* pnlTimes.Visible = true;
             pnlSetupControls.Visible = false;
             pnlTimes.Left = 0;
             pnlTimes.Top = 0;

             StreamReader sr = new StreamReader("times.txt");
             string line;
             while (!sr.EndOfStream)
             {
                 line = sr.ReadLine();
                 if (line.StartsWith("z"))
                 {
                     if (tbcBestTimes.TabPages.ContainsKey(line[1] + "x" + line[1]))
                     {

                     }
                     else
                     {
                         tbcBestTimes.TabPages.Add(line[1] + "x" + line[1]);
                     }


                 }
             }*/
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {

            foreach (Label l in pnlGamePanel.Controls.OfType<Label>())
            {
                l.Visible = false;
            }
            foreach (Box b  in pnlGamePanel.Controls.OfType<Box>())
            {
                b.Visible = false;
            }
            try
            {
                size = int.Parse(txtSize.Text);
            }
            catch (Exception)
            {

            }
            try
            {

                seed = int.Parse(txtSeed.Text);
                seed = txtSeed.Text.GetHashCode();

            }
            catch (Exception)
            {
                Random r = new Random();
                seed = r.Next();

            }

            timed = chkTimeAttack.Checked;
            rand = new Random(seed);
            pnlGamePanel.Visible = true;
            pnlSetupControls.Visible = false;
            lblTimer.Visible = GameForm.timed;
            tmrGameTimer.Enabled = GameForm.timed;

            solution = new int[size, size];
            guess = new int[size, size];


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    guess[i, j] = 3;
                    Box box = new Box();
                    box.Height = 20;
                    box.Width = 20;
                    box.Top = 100 + (20 * i);
                    box.Left = 100 + (20 * j);

                    box.MouseDown += Box_Click;
                    box.BorderStyle = BorderStyle.FixedSingle;
                    box.BackColor = Color.Gray;
                    box.row = i;
                    box.col = j;
                    pnlGamePanel.Controls.Add(box);
                    int result = rand.Next(0, 3);
                    if (result == 0)
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

                for (int j = 0; j < size; j++)
                {
                    if (j == 0 && solution[i, j] == 0 || j == size - 1 && solution[i, j] == 0)
                    {

                    }
                    else
                    {
                        row += solution[i, j];
                    }

                }

                rowList = new List<String>();


                rowList = row.Split('0').ToList();
                rowList.RemoveAll(item => item == "");



                for (int k = 0; k < rowList.Count; k++)
                {
                    Label sideLabel = new Label();
                    sideLabel.Width = 15;
                    sideLabel.Height = 20;
                    sideLabel.Top = 102 + 20 * i;
                    sideLabel.Left = 105 - rowList.Count * 20 + 20 * k;
                    sideLabel.Text = "0";
                    
                    sideLabel.Text = rowList[k].Length.ToString();
                    
                    pnlGamePanel.Controls.Add(sideLabel);
                }
            }

            //col numbers
            for (int i = 0; i < size; i++)
            {

                string col = "";
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 && solution[j, i] == 0 || j == size - 1 && solution[j, i] == 0)
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
                    sideLabel.Top = 105 - colList.Count * 20 + 20 * k;
                    sideLabel.Left = 102 + 20 * i;

                    string a = "1" + colList[k].Length.ToString();
                    if (a.Contains("1"))
                    {
                        sideLabel.Text = "0";
                    }
                    else
                    {
                        sideLabel.Text = colList[k].Length.ToString();
                    }
               
                        
                
                    
                    pnlGamePanel.Controls.Add(sideLabel);
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Debug.Write(solution[i, j]);
                }
            }
            Debug.Write("\n");

        }



        private void BtnBack_Click(object sender, EventArgs e)
        {
            pnlGamePanel.Visible = false;
            pnlSetupControls.Visible = true;
        }

        private void Box_Click(object sender, EventArgs e)
        {
            Box boxClicked = (Box)sender;

            MouseEventArgs mouseEvent = (MouseEventArgs)e;

            if (mouseEvent.Button == MouseButtons.Left)
            {
                if (boxClicked.BackColor == Color.Black)
                {
                    boxClicked.BackColor = Color.Gray;
                    guess[boxClicked.row, boxClicked.col] = 3;
                }
                else
                {
                    boxClicked.BackColor = Color.Black;
                    guess[boxClicked.row, boxClicked.col] = 1;
                }
            }
            else if (mouseEvent.Button == MouseButtons.Right)
            {
                if (boxClicked.BackColor == Color.White)
                {
                    boxClicked.BackColor = Color.Gray;
                    guess[boxClicked.row, boxClicked.col] = 3;
                }
                else
                {
                    boxClicked.BackColor = Color.White;
                    guess[boxClicked.row, boxClicked.col] = 0;
                }
            }


            if (checkSolution() == true)
            {
                LockBoard();
                if (GameForm.timed)
                {

                    try
                    {
                        Debug.WriteLine(size + minutes + seconds);
                        StreamWriter sw = new StreamWriter("times.txt", true);
                        sw.WriteLine("z" + size);
                        sw.WriteLine("m" + minutes);
                        sw.WriteLine("s" + seconds);
                        sw.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }

                MessageBox.Show("You win");


            }
        }

        private void TmrGameTimer_Tick(object sender, EventArgs e)
        {
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }

            if (seconds < 10)
            {
                lblTimer.Text = "Time: " + minutes + ":0" + seconds++;
            }
            else
            {
                lblTimer.Text = "Time: " + minutes + ":" + seconds++;
            }
        }

        private void BtnSolution_Click(object sender, EventArgs e)
        {
            foreach (Box box in pnlGamePanel.Controls.OfType<Box>())
            {
                if (solution[box.row, box.col] == 1)
                {
                    box.BackColor = Color.Black;
                }
                else
                {
                    box.BackColor = Color.White;
                }
            }
            LockBoard();
        }

        private Boolean checkSolution()
        {
            int correct = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (guess[i, j] == solution[i, j])
                    {
                        correct++;

                    }
                }
            }
            if (correct == size * size)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void LockBoard()
        {
            tmrGameTimer.Stop();
            foreach (Box b in pnlGamePanel.Controls.OfType<Box>())
            {
                b.Enabled = false;

            }

        }
    }
}


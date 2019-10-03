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
        Boolean creationMode = false;
        

        private void TxtSize_TextChanged(object sender, EventArgs e)
        {
            lblSize.Text = "x " + txtSize.Text;
        }


        private void BtnCreate_Click(object sender, EventArgs e)
        {
            msSave.Enabled = true;
            ClearGameBoard();
            creationMode = true;
            try
            {
                size = int.Parse(txtSize.Text);
            }
            catch (Exception)
            {

            }
            pnlGamePanel.Visible = true;
            pnlSetupControls.Visible = false;
            guess = new int[size, size];
            GenerateBlank();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            msSave.Enabled = true;
            ClearGameBoard();
            try
            {
                size = int.Parse(txtSize.Text);
                seed = int.Parse(txtSeed.Text);

            }
            catch (Exception)
            {
                try
                {
                    seed = txtSeed.Text.GetHashCode();
                }
                catch (Exception)
                {
                    Random r = new Random();
                    seed = r.Next();
                }
            }

            timed = chkTimeAttack.Checked;
            rand = new Random(seed);
            pnlGamePanel.Visible = true;
            pnlSetupControls.Visible = false;
            lblTimer.Visible = GameForm.timed;
            tmrGameTimer.Enabled = GameForm.timed;

            solution = new int[size, size];
            guess = new int[size, size];


            GenerateSolution(rand);
            
            setupLabels(solution);

        }
        private void GenerateBlank()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    guess[i, j] = 3;
                    Box box = new Box
                    {
                        Height = 20,
                        Width = 20,
                        Top = 100 + (20 * i),
                        Left = 100 + (20 * j)
                    };

                    box.MouseDown += Box_Click;
                    box.BorderStyle = BorderStyle.FixedSingle;
                    box.BackColor = Color.Gray;
                    box.row = i;
                    box.col = j;
                    pnlGamePanel.Controls.Add(box);

                }
            }

         }
        private void ClearGameBoard()
        {
            pnlGamePanel.Controls.OfType<Box>().ToList().ForEach(box => box.Dispose());
            pnlGamePanel.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Dispose());
        }

        private void GenerateSolution(Random rand)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    guess[i, j] = 3;
                    Box box = new Box
                    {
                        Height = 20,
                        Width = 20,
                        Top = 100 + (20 * i),
                        Left = 100 + (20 * j)
                    };

                    box.MouseDown += Box_Click;
                    box.BorderStyle = BorderStyle.FixedSingle;
                    box.BackColor = Color.Gray;
                    box.row = i;
                    box.col = j;
                    pnlGamePanel.Controls.Add(box);
                    if (rand.Next(0,3) == 0)
                    {
                        solution[i, j] = 0;
                    }
                    else
                    {
                        solution[i, j] = 1;
                    }
                }
            }
        }
        private void setupLabels(int[,] solution)
        {

            for (int i = 0; i < size; i++)
            {

                string row = "";
                string col = "";
                for (int j = 0; j < size; j++)
                {
                    if ((j != 0 || solution[i, j] != 0) && (j != size - 1 || solution[i, j] != 0))
                    {
                        row += solution[i, j];
                    }

                    if ((j != 0 || solution[j, i] != 0) && (j != size - 1 || solution[j, i] != 0))
                    {
                        col += solution[j, i];
                    }

                }

                rowList = new List<String>();
                rowList = row.Split('0').ToList();
                rowList.RemoveAll(item => item == "");

                colList = new List<String>();
                colList = col.Split('0').ToList();
                colList.RemoveAll(item => item == "");
                if(rowList.Count == 0)
                {
                    Label sideLabel = new Label
                    {
                        Width = 15,
                        Height = 15,
                        Top = 102 + 20 * i,
                        Left = 85,
                        Text = "0"
                    };

                    pnlGamePanel.Controls.Add(sideLabel);
                }
                for (int k = 0; k < rowList.Count; k++)
                {
                    Label sideLabel = new Label
                    {
                        Width = 15,
                        Height = 15,
                        Top = 102 + 20 * i,
                        Left = 105 - rowList.Count * 20 + 20 * k,

                        Text = rowList[k].Length.ToString()
                    };
                    pnlGamePanel.Controls.Add(sideLabel);
                }
                if(colList.Count == 0)
                {
                    Label sideLabel = new Label
                    {
                        Width = 20,
                        Height = 15,
                        Top = 85,
                        Left = 102 + 20 * i,
                        Text = "0"
                    };
                    pnlGamePanel.Controls.Add(sideLabel);
                }
                for (int k = 0; k < colList.Count; k++)
                {
                    Label sideLabel = new Label
                    {
                        Width = 20,
                        Height = 15,
                        Top = 105 - colList.Count * 20 + 20 * k,
                        Left = 102 + 20 * i,
                        Text = colList[k].Length.ToString()
                    };
                    pnlGamePanel.Controls.Add(sideLabel);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            pnlGamePanel.Visible = false;
            pnlSetupControls.Visible = true;
            msSave.Enabled = false;
        }



        private void MsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MsSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            String filename;
            if (creationMode)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //cmode
                    filename = saveFileDialog.FileName;
                    sw = new StreamWriter(filename);

                    sw.Write("c");
                    sw.Write("\r\n" +size);
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            sw.Write("\r\n" + guess[i, j]);
                        }
                    }
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Unimplemented");
            }
        }

        private void MsLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PCS Files|*.PCS";
            StreamReader sr;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pnlSetupControls.Visible = false;
                pnlGamePanel.Visible = true;
                ClearGameBoard();
                sr = new StreamReader(ofd.FileName);
                sr.ReadLine();
                size = int.Parse(sr.ReadLine());
                solution = new int[size, size];
                guess = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        solution[i, j] = int.Parse(sr.ReadLine());
                    }
                }
                GenerateBlank();
                setupLabels(solution);
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            msSave.Enabled = false;
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

            if (!creationMode) {
                if (checkSolution())
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


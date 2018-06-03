using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACO_Maze_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap originalImage;
        private Bitmap resImage;
        private Bitmap bwImage;
        private ImageProcessor imageProcessor;
        private ACO aco;
        private int[,] mazeMatrix;
        private int timesteps = 0;
        
        private void Form1_Load(object sender, EventArgs e) {
            imageProcessor = new ImageProcessor();
        }

        private void load_Image() {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open Maze Image";
            openDialog.Filter = "JPEG|*.jpg|PNG|*.png|BITMAP|*.bmp";
            openDialog.Multiselect = false;
            openDialog.ShowDialog();
            if (openDialog.FileName != null) {
                originalImage = new Bitmap(Image.FromFile(openDialog.FileName));
                resImage = imageProcessor.resizeBitmap(originalImage, new Size((int)numWidth.Value,(int)numHeight.Value));
                bwImage = imageProcessor.image2BW(resImage,(double)numThreshold.Value);
                mazeMatrix = imageProcessor.getImageMatrix(bwImage);
                grpACO.Enabled = true;
                pictureBox1.Image = bwImage;
            }
        }

        private void refresh_image() {
            resImage = imageProcessor.resizeBitmap(originalImage, new Size((int)numWidth.Value, (int)numHeight.Value));
            bwImage = imageProcessor.image2BW(resImage, (double)numThreshold.Value);
            mazeMatrix = imageProcessor.getImageMatrix(bwImage);
            pictureBox1.Image = bwImage;
        }

        private void start_aco() {
            aco = new ACO(mazeMatrix, (int)numAnt.Value, (double)numEvaporation.Value);
            timesteps = 0;
            lblTimesteps.Text = "Time Steps: " +timesteps;
            timer.Start();
            btnFast.Enabled = true;
            btnStop.Enabled = true;
            grpMaze.Enabled = false;
            btnFast.Enabled = false;
        }

        private void step_aco() {
            int[,] mazeMatrix;
            double[,] solnMatrix;
            aco.step_time((int)numInterval.Value, out mazeMatrix, out solnMatrix);
            if (cboView.Text == "Ants View")
                pictureBox1.Image = imageProcessor.matrix2Image(mazeMatrix);
            else
                pictureBox1.Image = imageProcessor.matrix2Image(solnMatrix);
            timesteps += (int)numInterval.Value;
            lblTimesteps.Text = "Time Steps: " + timesteps;
            
        }

        private void stop_aco() {
            timer.Stop();
            grpMaze.Enabled = true;
            btnStart.Enabled = true;
            btnFast.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            load_Image();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            refresh_image();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            start_aco();
        }

        private void timer_Tick(object sender, EventArgs e) {
            step_aco();
        }

        private void btnFast_Click(object sender, EventArgs e) {
            step_aco();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            stop_aco();
        }
     

    }
}

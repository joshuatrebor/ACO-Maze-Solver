namespace ACO_Maze_Solver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.grpMaze = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.grpACO = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.lblTimesteps = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numEvaporation = new System.Windows.Forms.NumericUpDown();
            this.numAnt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMaze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.grpACO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEvaporation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 634);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 102);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Maze";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Threshold Value";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(103, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 156);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start ACO";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpMaze
            // 
            this.grpMaze.Controls.Add(this.label4);
            this.grpMaze.Controls.Add(this.label2);
            this.grpMaze.Controls.Add(this.numThreshold);
            this.grpMaze.Controls.Add(this.numWidth);
            this.grpMaze.Controls.Add(this.btnRefresh);
            this.grpMaze.Controls.Add(this.label3);
            this.grpMaze.Controls.Add(this.numHeight);
            this.grpMaze.Controls.Add(this.btnLoad);
            this.grpMaze.Location = new System.Drawing.Point(999, 288);
            this.grpMaze.Name = "grpMaze";
            this.grpMaze.Size = new System.Drawing.Size(175, 135);
            this.grpMaze.TabIndex = 10;
            this.grpMaze.TabStop = false;
            this.grpMaze.Text = "Maze Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Resolution Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Resolution Width";
            // 
            // numThreshold
            // 
            this.numThreshold.DecimalPlaces = 2;
            this.numThreshold.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numThreshold.Location = new System.Drawing.Point(112, 24);
            this.numThreshold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(55, 20);
            this.numThreshold.TabIndex = 13;
            this.numThreshold.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(112, 50);
            this.numWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(55, 20);
            this.numWidth.TabIndex = 12;
            this.numWidth.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(112, 76);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(55, 20);
            this.numHeight.TabIndex = 11;
            this.numHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // grpACO
            // 
            this.grpACO.Controls.Add(this.btnStop);
            this.grpACO.Controls.Add(this.btnFast);
            this.grpACO.Controls.Add(this.cboView);
            this.grpACO.Controls.Add(this.lblTimesteps);
            this.grpACO.Controls.Add(this.btnStart);
            this.grpACO.Controls.Add(this.label8);
            this.grpACO.Controls.Add(this.numEvaporation);
            this.grpACO.Controls.Add(this.numAnt);
            this.grpACO.Controls.Add(this.label7);
            this.grpACO.Controls.Add(this.numInterval);
            this.grpACO.Controls.Add(this.label5);
            this.grpACO.Enabled = false;
            this.grpACO.Location = new System.Drawing.Point(999, 429);
            this.grpACO.Name = "grpACO";
            this.grpACO.Size = new System.Drawing.Size(175, 217);
            this.grpACO.TabIndex = 11;
            this.grpACO.TabStop = false;
            this.grpACO.Text = "ACO Settings";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(103, 185);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 23);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(9, 185);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(88, 23);
            this.btnFast.TabIndex = 27;
            this.btnFast.Text = "Fast Forward";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // lblTimesteps
            // 
            this.lblTimesteps.AutoSize = true;
            this.lblTimesteps.Location = new System.Drawing.Point(16, 132);
            this.lblTimesteps.Name = "lblTimesteps";
            this.lblTimesteps.Size = new System.Drawing.Size(55, 13);
            this.lblTimesteps.TabIndex = 25;
            this.lblTimesteps.Text = "Timesteps";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Evaporation Rate";
            // 
            // numEvaporation
            // 
            this.numEvaporation.DecimalPlaces = 4;
            this.numEvaporation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numEvaporation.Location = new System.Drawing.Point(111, 76);
            this.numEvaporation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEvaporation.Name = "numEvaporation";
            this.numEvaporation.Size = new System.Drawing.Size(55, 20);
            this.numEvaporation.TabIndex = 23;
            this.numEvaporation.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // numAnt
            // 
            this.numAnt.Location = new System.Drawing.Point(111, 50);
            this.numAnt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAnt.Name = "numAnt";
            this.numAnt.Size = new System.Drawing.Size(55, 20);
            this.numAnt.TabIndex = 21;
            this.numAnt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ant Count";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(112, 24);
            this.numInterval.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(55, 20);
            this.numInterval.TabIndex = 17;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Timestep Interval";
            // 
            // cboView
            // 
            this.cboView.FormattingEnabled = true;
            this.cboView.Items.AddRange(new object[] {
            "Ants View",
            "Pheromone Heat Map"});
            this.cboView.Location = new System.Drawing.Point(16, 102);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(150, 21);
            this.cboView.TabIndex = 12;
            this.cboView.Text = "Ants View";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1005, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "MAZE SOLVER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1012, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ant Colony Optimization";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 658);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpACO);
            this.Controls.Add(this.grpMaze);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAZE SOLVER USING ANT COLONY OPTIMIZATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMaze.ResumeLayout(false);
            this.grpMaze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.grpACO.ResumeLayout(false);
            this.grpACO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEvaporation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpMaze;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpACO;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numEvaporation;
        private System.Windows.Forms.NumericUpDown numAnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Label lblTimesteps;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


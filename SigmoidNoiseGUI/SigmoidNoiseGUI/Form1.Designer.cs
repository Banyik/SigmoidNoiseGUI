namespace SigmoidNoiseGUI
{
    partial class SN
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.Seed = new System.Windows.Forms.Label();
            this.randomSeedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xySize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.repetition = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.smoothness = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.xStart = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.yStart = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showFirstFunction = new System.Windows.Forms.CheckBox();
            this.showSecondFunction = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.graphCanvas = new System.Windows.Forms.PictureBox();
            this.firstFunctionNumeric = new System.Windows.Forms.NumericUpDown();
            this.secondFunctionNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFunctionNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondFunctionNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(425, 425);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(489, 12);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(100, 22);
            this.seedBox.TabIndex = 1;
            // 
            // Seed
            // 
            this.Seed.AutoSize = true;
            this.Seed.Location = new System.Drawing.Point(443, 15);
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(40, 16);
            this.Seed.TabIndex = 2;
            this.Seed.Text = "Seed";
            // 
            // randomSeedCheckBox
            // 
            this.randomSeedCheckBox.AutoSize = true;
            this.randomSeedCheckBox.Location = new System.Drawing.Point(595, 14);
            this.randomSeedCheckBox.Name = "randomSeedCheckBox";
            this.randomSeedCheckBox.Size = new System.Drawing.Size(117, 20);
            this.randomSeedCheckBox.TabIndex = 4;
            this.randomSeedCheckBox.Text = "Random Seed";
            this.randomSeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "X;Y size";
            // 
            // xySize
            // 
            this.xySize.Location = new System.Drawing.Point(503, 50);
            this.xySize.Maximum = new decimal(new int[] {
            425,
            0,
            0,
            0});
            this.xySize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.xySize.Name = "xySize";
            this.xySize.Size = new System.Drawing.Size(120, 22);
            this.xySize.TabIndex = 6;
            this.xySize.Value = new decimal(new int[] {
            425,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Repetition Amount";
            // 
            // repetition
            // 
            this.repetition.Location = new System.Drawing.Point(565, 82);
            this.repetition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.repetition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repetition.Name = "repetition";
            this.repetition.Size = new System.Drawing.Size(120, 22);
            this.repetition.TabIndex = 8;
            this.repetition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Smoothness";
            // 
            // smoothness
            // 
            this.smoothness.Location = new System.Drawing.Point(531, 110);
            this.smoothness.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.smoothness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smoothness.Name = "smoothness";
            this.smoothness.Size = new System.Drawing.Size(120, 22);
            this.smoothness.TabIndex = 10;
            this.smoothness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "X Start";
            // 
            // xStart
            // 
            this.xStart.Location = new System.Drawing.Point(503, 141);
            this.xStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xStart.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xStart.Name = "xStart";
            this.xStart.Size = new System.Drawing.Size(120, 22);
            this.xStart.TabIndex = 12;
            this.xStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y Start";
            // 
            // yStart
            // 
            this.yStart.Location = new System.Drawing.Point(503, 167);
            this.yStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yStart.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.yStart.Name = "yStart";
            this.yStart.Size = new System.Drawing.Size(120, 22);
            this.yStart.TabIndex = 14;
            this.yStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "1. Sigmoid Function";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "2. Sigmoid Function";
            // 
            // showFirstFunction
            // 
            this.showFirstFunction.AutoSize = true;
            this.showFirstFunction.Location = new System.Drawing.Point(678, 215);
            this.showFirstFunction.Name = "showFirstFunction";
            this.showFirstFunction.Size = new System.Drawing.Size(62, 20);
            this.showFirstFunction.TabIndex = 19;
            this.showFirstFunction.Text = "Show";
            this.showFirstFunction.UseVisualStyleBackColor = true;
            this.showFirstFunction.CheckedChanged += new System.EventHandler(this.showFirstFunction_CheckedChanged);
            // 
            // showSecondFunction
            // 
            this.showSecondFunction.AutoSize = true;
            this.showSecondFunction.Location = new System.Drawing.Point(678, 246);
            this.showSecondFunction.Name = "showSecondFunction";
            this.showSecondFunction.Size = new System.Drawing.Size(62, 20);
            this.showSecondFunction.TabIndex = 20;
            this.showSecondFunction.Text = "Show";
            this.showSecondFunction.UseVisualStyleBackColor = true;
            this.showSecondFunction.CheckedChanged += new System.EventHandler(this.showSecondFunction_CheckedChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(443, 414);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(89, 23);
            this.generateButton.TabIndex = 21;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // graphCanvas
            // 
            this.graphCanvas.Location = new System.Drawing.Point(778, 15);
            this.graphCanvas.Name = "graphCanvas";
            this.graphCanvas.Size = new System.Drawing.Size(517, 251);
            this.graphCanvas.TabIndex = 22;
            this.graphCanvas.TabStop = false;
            this.graphCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.graphCanvas_Paint);
            // 
            // firstFunctionNumeric
            // 
            this.firstFunctionNumeric.Location = new System.Drawing.Point(572, 213);
            this.firstFunctionNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.firstFunctionNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstFunctionNumeric.Name = "firstFunctionNumeric";
            this.firstFunctionNumeric.Size = new System.Drawing.Size(100, 22);
            this.firstFunctionNumeric.TabIndex = 23;
            this.firstFunctionNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstFunctionNumeric.ValueChanged += new System.EventHandler(this.firstFunctionNumeric_ValueChanged);
            // 
            // secondFunctionNumeric
            // 
            this.secondFunctionNumeric.Location = new System.Drawing.Point(572, 244);
            this.secondFunctionNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.secondFunctionNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondFunctionNumeric.Name = "secondFunctionNumeric";
            this.secondFunctionNumeric.Size = new System.Drawing.Size(100, 22);
            this.secondFunctionNumeric.TabIndex = 24;
            this.secondFunctionNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondFunctionNumeric.ValueChanged += new System.EventHandler(this.secondFunctionNumeric_ValueChanged);
            // 
            // SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 450);
            this.Controls.Add(this.secondFunctionNumeric);
            this.Controls.Add(this.firstFunctionNumeric);
            this.Controls.Add(this.graphCanvas);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.showSecondFunction);
            this.Controls.Add(this.showFirstFunction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.smoothness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repetition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xySize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomSeedCheckBox);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.seedBox);
            this.Controls.Add(this.canvas);
            this.Name = "SN";
            this.Text = "SigmoidNoiseGUI";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFunctionNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondFunctionNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.Label Seed;
        private System.Windows.Forms.CheckBox randomSeedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xySize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown repetition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown smoothness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown xStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown yStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox showFirstFunction;
        private System.Windows.Forms.CheckBox showSecondFunction;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.PictureBox graphCanvas;
        private System.Windows.Forms.NumericUpDown firstFunctionNumeric;
        private System.Windows.Forms.NumericUpDown secondFunctionNumeric;
    }
}



namespace Calculator.Winforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDivided = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnNumberDot = new System.Windows.Forms.Button();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tiCloseApp = new System.Windows.Forms.Timer(this.components);
            this.gbNumbers = new System.Windows.Forms.GroupBox();
            this.mnMain.SuspendLayout();
            this.gbNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNumber1
            // 
            this.btnNumber1.Location = new System.Drawing.Point(6, 131);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(40, 30);
            this.btnNumber1.TabIndex = 0;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(144, 131);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(40, 30);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            this.btnSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber9
            // 
            this.btnNumber9.Location = new System.Drawing.Point(98, 59);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(40, 30);
            this.btnNumber9.TabIndex = 2;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Location = new System.Drawing.Point(52, 59);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(40, 30);
            this.btnNumber8.TabIndex = 3;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Location = new System.Drawing.Point(6, 59);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(40, 30);
            this.btnNumber7.TabIndex = 4;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber6
            // 
            this.btnNumber6.Location = new System.Drawing.Point(98, 95);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(40, 30);
            this.btnNumber6.TabIndex = 5;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Location = new System.Drawing.Point(52, 95);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(40, 30);
            this.btnNumber5.TabIndex = 6;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Location = new System.Drawing.Point(6, 95);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(40, 30);
            this.btnNumber4.TabIndex = 7;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Location = new System.Drawing.Point(98, 131);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(40, 30);
            this.btnNumber3.TabIndex = 8;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Location = new System.Drawing.Point(52, 131);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(40, 30);
            this.btnNumber2.TabIndex = 9;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(144, 59);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(40, 30);
            this.btnMulti.TabIndex = 11;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            this.btnMulti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(144, 95);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(40, 30);
            this.btnSubtraction.TabIndex = 12;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            this.btnSubtraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(190, 23);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(40, 174);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 30);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnDivided
            // 
            this.btnDivided.Location = new System.Drawing.Point(144, 23);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(40, 30);
            this.btnDivided.TabIndex = 15;
            this.btnDivided.Text = "/";
            this.btnDivided.UseVisualStyleBackColor = true;
            this.btnDivided.Click += new System.EventHandler(this.btnDivided_Click);
            this.btnDivided.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblOutput.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(12, 74);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblOutput.Size = new System.Drawing.Size(236, 36);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTimer.Location = new System.Drawing.Point(12, 35);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(236, 30);
            this.lblTimer.TabIndex = 18;
            this.lblTimer.Text = "Close on %s";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNumber0
            // 
            this.btnNumber0.Location = new System.Drawing.Point(6, 167);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(132, 30);
            this.btnNumber0.TabIndex = 19;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnNumberDot
            // 
            this.btnNumberDot.Location = new System.Drawing.Point(144, 167);
            this.btnNumberDot.Name = "btnNumberDot";
            this.btnNumberDot.Size = new System.Drawing.Size(40, 30);
            this.btnNumberDot.TabIndex = 20;
            this.btnNumberDot.Text = ".";
            this.btnNumberDot.UseVisualStyleBackColor = true;
            this.btnNumberDot.Click += new System.EventHandler(this.btnNumberDot_Click);
            this.btnNumberDot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.mnStart,
            this.mnAbout});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(256, 24);
            this.mnMain.TabIndex = 21;
            this.mnMain.Text = "menuStrip1";
            this.mnMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(37, 20);
            this.mnFile.Text = "File";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(103, 22);
            this.mnExit.Text = "Close";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnStart
            // 
            this.mnStart.Name = "mnStart";
            this.mnStart.Size = new System.Drawing.Size(43, 20);
            this.mnStart.Text = "Start";
            this.mnStart.Click += new System.EventHandler(this.mnStart_Click);
            // 
            // mnAbout
            // 
            this.mnAbout.Name = "mnAbout";
            this.mnAbout.Size = new System.Drawing.Size(52, 20);
            this.mnAbout.Text = "About";
            this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click);
            // 
            // tiCloseApp
            // 
            this.tiCloseApp.Interval = 1000;
            this.tiCloseApp.Tick += new System.EventHandler(this.tiCloseApp_Tick);
            // 
            // gbNumbers
            // 
            this.gbNumbers.Controls.Add(this.btnReset);
            this.gbNumbers.Controls.Add(this.btnNumberDot);
            this.gbNumbers.Controls.Add(this.btnNumber1);
            this.gbNumbers.Controls.Add(this.btnNumber0);
            this.gbNumbers.Controls.Add(this.btnSum);
            this.gbNumbers.Controls.Add(this.btnNumber9);
            this.gbNumbers.Controls.Add(this.btnNumber8);
            this.gbNumbers.Controls.Add(this.btnNumber7);
            this.gbNumbers.Controls.Add(this.btnDivided);
            this.gbNumbers.Controls.Add(this.btnNumber6);
            this.gbNumbers.Controls.Add(this.btnNumber5);
            this.gbNumbers.Controls.Add(this.btnEqual);
            this.gbNumbers.Controls.Add(this.btnNumber4);
            this.gbNumbers.Controls.Add(this.btnSubtraction);
            this.gbNumbers.Controls.Add(this.btnNumber3);
            this.gbNumbers.Controls.Add(this.btnMulti);
            this.gbNumbers.Controls.Add(this.btnNumber2);
            this.gbNumbers.Enabled = false;
            this.gbNumbers.Location = new System.Drawing.Point(12, 105);
            this.gbNumbers.Name = "gbNumbers";
            this.gbNumbers.Size = new System.Drawing.Size(236, 206);
            this.gbNumbers.TabIndex = 22;
            this.gbNumbers.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(256, 314);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.gbNumbers);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.mnMain);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.gbNumbers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnNumberDot;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnAbout;
        private System.Windows.Forms.Timer tiCloseApp;
        private System.Windows.Forms.GroupBox gbNumbers;
        private System.Windows.Forms.ToolStripMenuItem mnStart;
    }
}


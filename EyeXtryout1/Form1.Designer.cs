namespace EyeXtryout1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxEssay = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxSampleInterval = new System.Windows.Forms.MaskedTextBox();
            this.buttonResetScreen = new System.Windows.Forms.Button();
            this.buttonResetRecording = new System.Windows.Forms.Button();
            this.labelGazePoint = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEssay
            // 
            this.textBoxEssay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEssay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEssay.Enabled = false;
            this.textBoxEssay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEssay.Location = new System.Drawing.Point(18, 18);
            this.textBoxEssay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxEssay.Multiline = true;
            this.textBoxEssay.Name = "textBoxEssay";
            this.textBoxEssay.ReadOnly = true;
            this.textBoxEssay.Size = new System.Drawing.Size(1253, 689);
            this.textBoxEssay.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.maskedTextBoxSampleInterval);
            this.panelButtons.Controls.Add(this.buttonResetScreen);
            this.panelButtons.Controls.Add(this.buttonResetRecording);
            this.panelButtons.Controls.Add(this.labelGazePoint);
            this.panelButtons.Controls.Add(this.buttonPlay);
            this.panelButtons.Controls.Add(this.buttonRecord);
            this.panelButtons.Location = new System.Drawing.Point(18, 717);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1253, 45);
            this.panelButtons.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sample interval";
            // 
            // maskedTextBoxSampleInterval
            // 
            this.maskedTextBoxSampleInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSampleInterval.Location = new System.Drawing.Point(556, 11);
            this.maskedTextBoxSampleInterval.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.maskedTextBoxSampleInterval.Mask = "00";
            this.maskedTextBoxSampleInterval.Name = "maskedTextBoxSampleInterval";
            this.maskedTextBoxSampleInterval.Size = new System.Drawing.Size(51, 26);
            this.maskedTextBoxSampleInterval.TabIndex = 6;
            this.maskedTextBoxSampleInterval.TextChanged += new System.EventHandler(this.maskedTextBoxSampleInterval_TextChanged);
            // 
            // buttonResetScreen
            // 
            this.buttonResetScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetScreen.Location = new System.Drawing.Point(619, 5);
            this.buttonResetScreen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonResetScreen.Name = "buttonResetScreen";
            this.buttonResetScreen.Size = new System.Drawing.Size(141, 35);
            this.buttonResetScreen.TabIndex = 5;
            this.buttonResetScreen.Text = " Reset screen";
            this.buttonResetScreen.UseVisualStyleBackColor = true;
            this.buttonResetScreen.Click += new System.EventHandler(this.buttonResetScreen_Click);
            // 
            // buttonResetRecording
            // 
            this.buttonResetRecording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetRecording.Location = new System.Drawing.Point(769, 5);
            this.buttonResetRecording.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonResetRecording.Name = "buttonResetRecording";
            this.buttonResetRecording.Size = new System.Drawing.Size(155, 35);
            this.buttonResetRecording.TabIndex = 3;
            this.buttonResetRecording.Text = "Reset recording";
            this.buttonResetRecording.UseVisualStyleBackColor = true;
            this.buttonResetRecording.Click += new System.EventHandler(this.buttonResetRecording_Click);
            // 
            // labelGazePoint
            // 
            this.labelGazePoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGazePoint.Location = new System.Drawing.Point(5, 12);
            this.labelGazePoint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGazePoint.Name = "labelGazePoint";
            this.labelGazePoint.Size = new System.Drawing.Size(600, 20);
            this.labelGazePoint.TabIndex = 2;
            this.labelGazePoint.Text = "Gaze point";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Location = new System.Drawing.Point(1015, 5);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(113, 35);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecord.Location = new System.Drawing.Point(1136, 5);
            this.buttonRecord.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(113, 35);
            this.buttonRecord.TabIndex = 0;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 780);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.textBoxEssay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Citolab eyetracker - tekst lezen";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEssay;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelGazePoint;
        private System.Windows.Forms.Button buttonResetRecording;
        private System.Windows.Forms.Button buttonResetScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSampleInterval;
    }
}


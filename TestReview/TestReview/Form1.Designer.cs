namespace TestReview
{
    partial class TestReview
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
            this.questionButton = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.SourceGroup = new System.Windows.Forms.GroupBox();
            this.hardGroup = new System.Windows.Forms.GroupBox();
            this.questionsRadio = new System.Windows.Forms.RadioButton();
            this.newQuestionsRadio = new System.Windows.Forms.RadioButton();
            this.YesRadio = new System.Windows.Forms.RadioButton();
            this.NoRadio = new System.Windows.Forms.RadioButton();
            this.SourceGroup.SuspendLayout();
            this.hardGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionButton
            // 
            this.questionButton.Location = new System.Drawing.Point(210, 12);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(217, 23);
            this.questionButton.TabIndex = 0;
            this.questionButton.Text = "Generate Question";
            this.questionButton.UseVisualStyleBackColor = true;
            this.questionButton.Click += new System.EventHandler(this.questionButton_Click);
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(12, 59);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(618, 23);
            this.questionBox.TabIndex = 1;
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(210, 140);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(217, 23);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "Show answer";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(12, 194);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(618, 23);
            this.answerBox.TabIndex = 3;
            // 
            // SourceGroup
            // 
            this.SourceGroup.Controls.Add(this.newQuestionsRadio);
            this.SourceGroup.Controls.Add(this.questionsRadio);
            this.SourceGroup.Location = new System.Drawing.Point(12, 235);
            this.SourceGroup.Name = "SourceGroup";
            this.SourceGroup.Size = new System.Drawing.Size(200, 100);
            this.SourceGroup.TabIndex = 4;
            this.SourceGroup.TabStop = false;
            this.SourceGroup.Text = "Source";
            // 
            // hardGroup
            // 
            this.hardGroup.Controls.Add(this.NoRadio);
            this.hardGroup.Controls.Add(this.YesRadio);
            this.hardGroup.Location = new System.Drawing.Point(430, 235);
            this.hardGroup.Name = "hardGroup";
            this.hardGroup.Size = new System.Drawing.Size(200, 100);
            this.hardGroup.TabIndex = 5;
            this.hardGroup.TabStop = false;
            this.hardGroup.Text = "Struggled?";
            // 
            // questionsRadio
            // 
            this.questionsRadio.AutoSize = true;
            this.questionsRadio.Location = new System.Drawing.Point(25, 36);
            this.questionsRadio.Name = "questionsRadio";
            this.questionsRadio.Size = new System.Drawing.Size(93, 19);
            this.questionsRadio.TabIndex = 0;
            this.questionsRadio.TabStop = true;
            this.questionsRadio.Text = "questions.txt";
            this.questionsRadio.UseVisualStyleBackColor = true;
            this.questionsRadio.CheckedChanged += new System.EventHandler(this.questionsRadio_CheckedChanged);
            // 
            // newQuestionsRadio
            // 
            this.newQuestionsRadio.AutoSize = true;
            this.newQuestionsRadio.Location = new System.Drawing.Point(26, 65);
            this.newQuestionsRadio.Name = "newQuestionsRadio";
            this.newQuestionsRadio.Size = new System.Drawing.Size(117, 19);
            this.newQuestionsRadio.TabIndex = 1;
            this.newQuestionsRadio.TabStop = true;
            this.newQuestionsRadio.Text = "newQuestions.txt";
            this.newQuestionsRadio.UseVisualStyleBackColor = true;
            this.newQuestionsRadio.CheckedChanged += new System.EventHandler(this.newQuestionsRadio_CheckedChanged);
            // 
            // YesRadio
            // 
            this.YesRadio.AutoSize = true;
            this.YesRadio.Location = new System.Drawing.Point(13, 37);
            this.YesRadio.Name = "YesRadio";
            this.YesRadio.Size = new System.Drawing.Size(42, 19);
            this.YesRadio.TabIndex = 0;
            this.YesRadio.TabStop = true;
            this.YesRadio.Text = "Yes";
            this.YesRadio.UseVisualStyleBackColor = true;
            this.YesRadio.CheckedChanged += new System.EventHandler(this.YesRadio_CheckedChanged);
            // 
            // NoRadio
            // 
            this.NoRadio.AutoSize = true;
            this.NoRadio.Location = new System.Drawing.Point(14, 71);
            this.NoRadio.Name = "NoRadio";
            this.NoRadio.Size = new System.Drawing.Size(41, 19);
            this.NoRadio.TabIndex = 1;
            this.NoRadio.TabStop = true;
            this.NoRadio.Text = "No";
            this.NoRadio.UseVisualStyleBackColor = true;
            this.NoRadio.CheckedChanged += new System.EventHandler(this.NoRadio_CheckedChanged);
            // 
            // TestReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(642, 364);
            this.Controls.Add(this.hardGroup);
            this.Controls.Add(this.SourceGroup);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.questionButton);
            this.Name = "TestReview";
            this.Text = "Test Review Program";
            this.SourceGroup.ResumeLayout(false);
            this.SourceGroup.PerformLayout();
            this.hardGroup.ResumeLayout(false);
            this.hardGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button questionButton;
        private TextBox questionBox;
        private Button answerButton;
        private TextBox answerBox;
        private GroupBox SourceGroup;
        private RadioButton newQuestionsRadio;
        private RadioButton questionsRadio;
        private GroupBox hardGroup;
        private RadioButton NoRadio;
        private RadioButton YesRadio;
    }
}
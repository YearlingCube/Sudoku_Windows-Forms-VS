namespace Sudoku_Windows_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BeginnerCheckBox = new System.Windows.Forms.CheckBox();
            this.IntermediateCheckBox = new System.Windows.Forms.CheckBox();
            this.AdvancedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(123, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 389);
            this.panel1.TabIndex = 0;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(713, 41);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(713, 12);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 2;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(713, 415);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BeginnerCheckBox
            // 
            this.BeginnerCheckBox.AutoSize = true;
            this.BeginnerCheckBox.Location = new System.Drawing.Point(713, 283);
            this.BeginnerCheckBox.Name = "BeginnerCheckBox";
            this.BeginnerCheckBox.Size = new System.Drawing.Size(68, 17);
            this.BeginnerCheckBox.TabIndex = 4;
            this.BeginnerCheckBox.Text = "Beginner";
            this.BeginnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // IntermediateCheckBox
            // 
            this.IntermediateCheckBox.AutoSize = true;
            this.IntermediateCheckBox.Location = new System.Drawing.Point(713, 306);
            this.IntermediateCheckBox.Name = "IntermediateCheckBox";
            this.IntermediateCheckBox.Size = new System.Drawing.Size(84, 17);
            this.IntermediateCheckBox.TabIndex = 5;
            this.IntermediateCheckBox.Text = "Intermediate";
            this.IntermediateCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdvancedCheckBox
            // 
            this.AdvancedCheckBox.AutoSize = true;
            this.AdvancedCheckBox.Location = new System.Drawing.Point(713, 329);
            this.AdvancedCheckBox.Name = "AdvancedCheckBox";
            this.AdvancedCheckBox.Size = new System.Drawing.Size(75, 17);
            this.AdvancedCheckBox.TabIndex = 6;
            this.AdvancedCheckBox.Text = "Advanced";
            this.AdvancedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Difficulty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdvancedCheckBox);
            this.Controls.Add(this.IntermediateCheckBox);
            this.Controls.Add(this.BeginnerCheckBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox BeginnerCheckBox;
        private System.Windows.Forms.CheckBox IntermediateCheckBox;
        private System.Windows.Forms.CheckBox AdvancedCheckBox;
        private System.Windows.Forms.Label label1;
    }
}


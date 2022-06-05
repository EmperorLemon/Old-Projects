
namespace Roll_The_Dice
{
    partial class DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRoller));
            this.RollButton = new System.Windows.Forms.Button();
            this.InputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberDisplay = new System.Windows.Forms.Label();
            this.WarningText = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadTail = new System.Windows.Forms.Button();
            this.flipResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RollButton
            // 
            this.RollButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(347, 262);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(100, 75);
            this.RollButton.TabIndex = 0;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // InputField
            // 
            this.InputField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputField.Location = new System.Drawing.Point(370, 50);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(50, 22);
            this.InputField.TabIndex = 1;
            this.InputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputField.Click += new System.EventHandler(this.InputField_Click);
            this.InputField.TextChanged += new System.EventHandler(this.InputField_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Max Number";
            // 
            // NumberDisplay
            // 
            this.NumberDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.NumberDisplay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberDisplay.Location = new System.Drawing.Point(370, 167);
            this.NumberDisplay.Name = "NumberDisplay";
            this.NumberDisplay.Size = new System.Drawing.Size(50, 37);
            this.NumberDisplay.TabIndex = 3;
            this.NumberDisplay.Text = "0";
            this.NumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WarningText
            // 
            this.WarningText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WarningText.AutoSize = true;
            this.WarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningText.ForeColor = System.Drawing.Color.Red;
            this.WarningText.Location = new System.Drawing.Point(470, 50);
            this.WarningText.Name = "WarningText";
            this.WarningText.Size = new System.Drawing.Size(13, 20);
            this.WarningText.TabIndex = 4;
            this.WarningText.Text = ".";
            // 
            // listView
            // 
            this.listView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 50);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(121, 388);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recently Rolled";
            // 
            // HeadTail
            // 
            this.HeadTail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HeadTail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HeadTail.FlatAppearance.BorderSize = 5;
            this.HeadTail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadTail.Location = new System.Drawing.Point(585, 167);
            this.HeadTail.Name = "HeadTail";
            this.HeadTail.Size = new System.Drawing.Size(127, 89);
            this.HeadTail.TabIndex = 7;
            this.HeadTail.Text = "Play Heads or Tails";
            this.HeadTail.UseVisualStyleBackColor = true;
            this.HeadTail.Click += new System.EventHandler(this.HeadTail_Click);
            // 
            // flipResult
            // 
            this.flipResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flipResult.AutoSize = true;
            this.flipResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipResult.Location = new System.Drawing.Point(554, 294);
            this.flipResult.Name = "flipResult";
            this.flipResult.Size = new System.Drawing.Size(181, 17);
            this.flipResult.TabIndex = 8;
            this.flipResult.Text = "The Coin has landed on";
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flipResult);
            this.Controls.Add(this.HeadTail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.WarningText);
            this.Controls.Add(this.NumberDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.RollButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiceRoller";
            this.Text = "Roll The Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberDisplay;
        private System.Windows.Forms.Label WarningText;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HeadTail;
        private System.Windows.Forms.Label flipResult;
    }
}


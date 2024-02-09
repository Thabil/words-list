namespace words_list
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 411);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.ItemHeight = 20;
            this.wordsListBox.Location = new System.Drawing.Point(255, 142);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(267, 164);
            this.wordsListBox.TabIndex = 36;
            this.wordsListBox.SelectedIndexChanged += new System.EventHandler(this.wordsListBox_SelectedIndexChanged);
            // 
            // changeButton
            // 
            this.changeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeButton.BackgroundImage")));
            this.changeButton.Location = new System.Drawing.Point(138, 209);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(87, 37);
            this.changeButton.TabIndex = 35;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.Location = new System.Drawing.Point(138, 269);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 37);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeButton.BackgroundImage")));
            this.removeButton.Location = new System.Drawing.Point(138, 153);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(87, 37);
            this.removeButton.TabIndex = 33;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.Location = new System.Drawing.Point(138, 94);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 37);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(255, 105);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(267, 26);
            this.inputTextBox.TabIndex = 31;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(264, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "ADD,Remove, Change and Clear ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordsListBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
    }
}


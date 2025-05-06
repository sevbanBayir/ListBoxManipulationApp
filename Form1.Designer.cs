namespace ListBoxManipulationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainListBox
            // 
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 15;
            this.mainListBox.Location = new System.Drawing.Point(12, 12);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(200, 154);
            this.mainListBox.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 175);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PlaceholderText = "Enter item text";
            this.inputTextBox.Size = new System.Drawing.Size(200, 23);
            this.inputTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 204);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(117, 204);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(95, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(12, 233);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(95, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(117, 233);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(95, 23);
            this.reverseButton.TabIndex = 5;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 271);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.mainListBox);
            this.Name = "Form1";
            this.Text = "ListBox Fun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button reverseButton;
    }
} 
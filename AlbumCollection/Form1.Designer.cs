namespace AlbumCollection
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
            this.AlbumInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OrigLabel = new System.Windows.Forms.Label();
            this.SortedLabel = new System.Windows.Forms.Label();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlbumInput
            // 
            this.AlbumInput.Location = new System.Drawing.Point(191, 12);
            this.AlbumInput.Name = "AlbumInput";
            this.AlbumInput.Size = new System.Drawing.Size(97, 20);
            this.AlbumInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Album Name: ";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(191, 40);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(97, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(88, 40);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrigLabel
            // 
            this.OrigLabel.BackColor = System.Drawing.SystemColors.Control;
            this.OrigLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrigLabel.Location = new System.Drawing.Point(12, 174);
            this.OrigLabel.Name = "OrigLabel";
            this.OrigLabel.Size = new System.Drawing.Size(155, 217);
            this.OrigLabel.TabIndex = 4;
            this.OrigLabel.Text = "Original List\r\n*************";
            // 
            // SortedLabel
            // 
            this.SortedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SortedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SortedLabel.Location = new System.Drawing.Point(233, 174);
            this.SortedLabel.Name = "SortedLabel";
            this.SortedLabel.Size = new System.Drawing.Size(155, 217);
            this.SortedLabel.TabIndex = 5;
            this.SortedLabel.Text = "Sorted List\r\n************";
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Location = new System.Drawing.Point(120, 114);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(143, 13);
            this.WrongLabel.TabIndex = 6;
            this.WrongLabel.Text = "Album not found in collection";
            this.WrongLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.WrongLabel);
            this.Controls.Add(this.SortedLabel);
            this.Controls.Add(this.OrigLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlbumInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AlbumInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label OrigLabel;
        private System.Windows.Forms.Label SortedLabel;
        private System.Windows.Forms.Label WrongLabel;
    }
}


namespace TramScheduleGUI
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
            this.DisplayRoutesButton = new System.Windows.Forms.Button();
            this.DisplayTramsButton = new System.Windows.Forms.Button();
            this.DisplayStopsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DisplayRoutesButton
            // 
            this.DisplayRoutesButton.Location = new System.Drawing.Point(28, 89);
            this.DisplayRoutesButton.Name = "DisplayRoutesButton";
            this.DisplayRoutesButton.Size = new System.Drawing.Size(133, 57);
            this.DisplayRoutesButton.TabIndex = 0;
            this.DisplayRoutesButton.Text = "Display Routes";
            this.DisplayRoutesButton.UseVisualStyleBackColor = true;
            this.DisplayRoutesButton.Click += new System.EventHandler(this.DisplayRoutesButton_Click);
            // 
            // DisplayTramsButton
            // 
            this.DisplayTramsButton.Location = new System.Drawing.Point(28, 190);
            this.DisplayTramsButton.Name = "DisplayTramsButton";
            this.DisplayTramsButton.Size = new System.Drawing.Size(133, 57);
            this.DisplayTramsButton.TabIndex = 1;
            this.DisplayTramsButton.Text = "Display Trams";
            this.DisplayTramsButton.UseVisualStyleBackColor = true;
            // 
            // DisplayStopsButton
            // 
            this.DisplayStopsButton.Location = new System.Drawing.Point(28, 287);
            this.DisplayStopsButton.Name = "DisplayStopsButton";
            this.DisplayStopsButton.Size = new System.Drawing.Size(133, 57);
            this.DisplayStopsButton.TabIndex = 2;
            this.DisplayStopsButton.Text = "Display Stops";
            this.DisplayStopsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the tram schedule app";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(195, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 260);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(473, 89);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(247, 260);
            this.listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayStopsButton);
            this.Controls.Add(this.DisplayTramsButton);
            this.Controls.Add(this.DisplayRoutesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayRoutesButton;
        private System.Windows.Forms.Button DisplayTramsButton;
        private System.Windows.Forms.Button DisplayStopsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}


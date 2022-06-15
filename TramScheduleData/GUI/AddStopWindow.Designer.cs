namespace GUI
{
    partial class AddStopWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfStoptextBox = new System.Windows.Forms.TextBox();
            this.DetailsOfTheStopBox = new System.Windows.Forms.TextBox();
            this.AddStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the stop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details of the stop";
            // 
            // NameOfStoptextBox
            // 
            this.NameOfStoptextBox.Location = new System.Drawing.Point(258, 94);
            this.NameOfStoptextBox.Name = "NameOfStoptextBox";
            this.NameOfStoptextBox.Size = new System.Drawing.Size(231, 27);
            this.NameOfStoptextBox.TabIndex = 2;
            // 
            // DetailsOfTheStopBox
            // 
            this.DetailsOfTheStopBox.Location = new System.Drawing.Point(258, 145);
            this.DetailsOfTheStopBox.Name = "DetailsOfTheStopBox";
            this.DetailsOfTheStopBox.Size = new System.Drawing.Size(231, 27);
            this.DetailsOfTheStopBox.TabIndex = 3;
            // 
            // AddStop
            // 
            this.AddStop.Location = new System.Drawing.Point(258, 218);
            this.AddStop.Name = "AddStop";
            this.AddStop.Size = new System.Drawing.Size(165, 36);
            this.AddStop.TabIndex = 4;
            this.AddStop.Text = "Add stop";
            this.AddStop.UseVisualStyleBackColor = true;
            this.AddStop.Click += new System.EventHandler(this.AddStop_Click);
            // 
            // AddStopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStop);
            this.Controls.Add(this.DetailsOfTheStopBox);
            this.Controls.Add(this.NameOfStoptextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStopWindow";
            this.Text = "AddStopWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NameOfStoptextBox;
        private TextBox DetailsOfTheStopBox;
        private Button AddStop;
    }
}
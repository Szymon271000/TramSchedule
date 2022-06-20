namespace GUI
{
    partial class EditRouteWindow
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
            this.ListRouteBox = new System.Windows.Forms.ListBox();
            this.ListStopBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdatedRouteList = new System.Windows.Forms.ListBox();
            this.DeleteAStopButton = new System.Windows.Forms.Button();
            this.AddAStopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListRouteBox
            // 
            this.ListRouteBox.FormattingEnabled = true;
            this.ListRouteBox.ItemHeight = 20;
            this.ListRouteBox.Location = new System.Drawing.Point(44, 46);
            this.ListRouteBox.Name = "ListRouteBox";
            this.ListRouteBox.Size = new System.Drawing.Size(215, 284);
            this.ListRouteBox.TabIndex = 0;
            this.ListRouteBox.SelectedIndexChanged += new System.EventHandler(this.ListRouteBox_SelectedIndexChanged);
            // 
            // ListStopBox
            // 
            this.ListStopBox.FormattingEnabled = true;
            this.ListStopBox.ItemHeight = 20;
            this.ListStopBox.Location = new System.Drawing.Point(352, 46);
            this.ListStopBox.Name = "ListStopBox";
            this.ListStopBox.Size = new System.Drawing.Size(191, 284);
            this.ListStopBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a route";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a stop to add";
            // 
            // UpdatedRouteList
            // 
            this.UpdatedRouteList.FormattingEnabled = true;
            this.UpdatedRouteList.ItemHeight = 20;
            this.UpdatedRouteList.Location = new System.Drawing.Point(597, 46);
            this.UpdatedRouteList.Name = "UpdatedRouteList";
            this.UpdatedRouteList.Size = new System.Drawing.Size(191, 284);
            this.UpdatedRouteList.TabIndex = 4;
            // 
            // DeleteAStopButton
            // 
            this.DeleteAStopButton.Location = new System.Drawing.Point(380, 369);
            this.DeleteAStopButton.Name = "DeleteAStopButton";
            this.DeleteAStopButton.Size = new System.Drawing.Size(166, 40);
            this.DeleteAStopButton.TabIndex = 5;
            this.DeleteAStopButton.Text = "Delete a stop";
            this.DeleteAStopButton.UseVisualStyleBackColor = true;
            this.DeleteAStopButton.Click += new System.EventHandler(this.DeleteAStopButton_Click);
            // 
            // AddAStopButton
            // 
            this.AddAStopButton.Location = new System.Drawing.Point(597, 369);
            this.AddAStopButton.Name = "AddAStopButton";
            this.AddAStopButton.Size = new System.Drawing.Size(166, 40);
            this.AddAStopButton.TabIndex = 6;
            this.AddAStopButton.Text = "Add a stop";
            this.AddAStopButton.UseVisualStyleBackColor = true;
            this.AddAStopButton.Click += new System.EventHandler(this.AddAStopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a stop to delete";
            // 
            // EditRouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddAStopButton);
            this.Controls.Add(this.DeleteAStopButton);
            this.Controls.Add(this.UpdatedRouteList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListStopBox);
            this.Controls.Add(this.ListRouteBox);
            this.Name = "EditRouteWindow";
            this.Text = "EditRouteWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListRouteBox;
        private ListBox ListStopBox;
        private Label label1;
        private Label label2;
        private ListBox UpdatedRouteList;
        private Button DeleteAStopButton;
        private Button AddAStopButton;
        private Label label3;
    }
}
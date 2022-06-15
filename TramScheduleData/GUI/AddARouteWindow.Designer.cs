namespace GUI
{
    partial class AddARouteWindow
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
            this.AddStop = new System.Windows.Forms.Button();
            this.NameOfRouteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddStop
            // 
            this.AddStop.Location = new System.Drawing.Point(362, 205);
            this.AddStop.Name = "AddStop";
            this.AddStop.Size = new System.Drawing.Size(165, 36);
            this.AddStop.TabIndex = 9;
            this.AddStop.Text = "Add Route";
            this.AddStop.UseVisualStyleBackColor = true;
            this.AddStop.Click += new System.EventHandler(this.AddStop_Click);
            // 
            // NameOfRouteBox
            // 
            this.NameOfRouteBox.Location = new System.Drawing.Point(362, 145);
            this.NameOfRouteBox.Name = "NameOfRouteBox";
            this.NameOfRouteBox.Size = new System.Drawing.Size(231, 27);
            this.NameOfRouteBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name of the route";
            // 
            // AddARouteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStop);
            this.Controls.Add(this.NameOfRouteBox);
            this.Controls.Add(this.label1);
            this.Name = "AddARouteWindow";
            this.Text = "AddARouteWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddStop;
        private TextBox NameOfRouteBox;
        private Label label1;
    }
}
namespace GUI
{
    partial class Form1
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
            this.DisplayRoutesButton = new System.Windows.Forms.Button();
            this.DisplayTramsButton = new System.Windows.Forms.Button();
            this.DisplayStopsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAStopButton = new System.Windows.Forms.Button();
            this.AddARouteButton = new System.Windows.Forms.Button();
            this.EditARouteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayRoutesButton
            // 
            this.DisplayRoutesButton.BackColor = System.Drawing.SystemColors.Info;
            this.DisplayRoutesButton.Location = new System.Drawing.Point(12, 82);
            this.DisplayRoutesButton.Name = "DisplayRoutesButton";
            this.DisplayRoutesButton.Size = new System.Drawing.Size(137, 52);
            this.DisplayRoutesButton.TabIndex = 0;
            this.DisplayRoutesButton.Text = "Display routes";
            this.DisplayRoutesButton.UseVisualStyleBackColor = false;
            this.DisplayRoutesButton.Click += new System.EventHandler(this.DisplayRoutesButton_Click);
            // 
            // DisplayTramsButton
            // 
            this.DisplayTramsButton.BackColor = System.Drawing.SystemColors.Info;
            this.DisplayTramsButton.Location = new System.Drawing.Point(12, 173);
            this.DisplayTramsButton.Name = "DisplayTramsButton";
            this.DisplayTramsButton.Size = new System.Drawing.Size(137, 52);
            this.DisplayTramsButton.TabIndex = 1;
            this.DisplayTramsButton.Text = "Display trams";
            this.DisplayTramsButton.UseVisualStyleBackColor = false;
            this.DisplayTramsButton.Click += new System.EventHandler(this.DisplayTramsButton_Click);
            // 
            // DisplayStopsButton
            // 
            this.DisplayStopsButton.BackColor = System.Drawing.SystemColors.Info;
            this.DisplayStopsButton.Location = new System.Drawing.Point(12, 264);
            this.DisplayStopsButton.Name = "DisplayStopsButton";
            this.DisplayStopsButton.Size = new System.Drawing.Size(137, 52);
            this.DisplayStopsButton.TabIndex = 2;
            this.DisplayStopsButton.Text = "Display stops";
            this.DisplayStopsButton.UseVisualStyleBackColor = false;
            this.DisplayStopsButton.Click += new System.EventHandler(this.DisplayStopsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the tram schedule app";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(228, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 244);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(422, 80);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(347, 244);
            this.listBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // AddAStopButton
            // 
            this.AddAStopButton.BackColor = System.Drawing.SystemColors.Info;
            this.AddAStopButton.Location = new System.Drawing.Point(228, 363);
            this.AddAStopButton.Name = "AddAStopButton";
            this.AddAStopButton.Size = new System.Drawing.Size(137, 52);
            this.AddAStopButton.TabIndex = 9;
            this.AddAStopButton.Text = "Add a stop";
            this.AddAStopButton.UseVisualStyleBackColor = false;
            this.AddAStopButton.Click += new System.EventHandler(this.AddAStopButton_Click);
            // 
            // AddARouteButton
            // 
            this.AddARouteButton.BackColor = System.Drawing.SystemColors.Info;
            this.AddARouteButton.Location = new System.Drawing.Point(422, 363);
            this.AddARouteButton.Name = "AddARouteButton";
            this.AddARouteButton.Size = new System.Drawing.Size(137, 52);
            this.AddARouteButton.TabIndex = 10;
            this.AddARouteButton.Text = "Add a route";
            this.AddARouteButton.UseVisualStyleBackColor = false;
            this.AddARouteButton.Click += new System.EventHandler(this.AddARouteButton_Click);
            // 
            // EditARouteButton
            // 
            this.EditARouteButton.BackColor = System.Drawing.SystemColors.Info;
            this.EditARouteButton.Location = new System.Drawing.Point(632, 363);
            this.EditARouteButton.Name = "EditARouteButton";
            this.EditARouteButton.Size = new System.Drawing.Size(137, 52);
            this.EditARouteButton.TabIndex = 11;
            this.EditARouteButton.Text = "Edit a route";
            this.EditARouteButton.UseVisualStyleBackColor = false;
            this.EditARouteButton.Click += new System.EventHandler(this.EditARouteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditARouteButton);
            this.Controls.Add(this.AddARouteButton);
            this.Controls.Add(this.AddAStopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayStopsButton);
            this.Controls.Add(this.DisplayTramsButton);
            this.Controls.Add(this.DisplayRoutesButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Tram Schedule";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DisplayRoutesButton;
        private Button DisplayTramsButton;
        private Button DisplayStopsButton;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Button AddAStopButton;
        private Button AddARouteButton;
        private Button EditARouteButton;
    }
}
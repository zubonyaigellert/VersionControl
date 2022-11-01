namespace ajandek
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ballbutton = new System.Windows.Forms.Button();
            this.carbutton = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.presentbtn = new System.Windows.Forms.Button();
            this.ribboncolorbtn = new System.Windows.Forms.Button();
            this.boxcolorbtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.boxcolorbtn);
            this.mainPanel.Controls.Add(this.ribboncolorbtn);
            this.mainPanel.Controls.Add(this.presentbtn);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.ballbutton);
            this.mainPanel.Controls.Add(this.carbutton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next:";
            // 
            // ballbutton
            // 
            this.ballbutton.Location = new System.Drawing.Point(97, 66);
            this.ballbutton.Name = "ballbutton";
            this.ballbutton.Size = new System.Drawing.Size(85, 56);
            this.ballbutton.TabIndex = 1;
            this.ballbutton.Text = "BALL";
            this.ballbutton.UseVisualStyleBackColor = true;
            this.ballbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // carbutton
            // 
            this.carbutton.Location = new System.Drawing.Point(12, 66);
            this.carbutton.Name = "carbutton";
            this.carbutton.Size = new System.Drawing.Size(79, 56);
            this.carbutton.TabIndex = 0;
            this.carbutton.Text = "CAR";
            this.carbutton.UseVisualStyleBackColor = true;
            this.carbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(97, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // presentbtn
            // 
            this.presentbtn.Location = new System.Drawing.Point(191, 66);
            this.presentbtn.Name = "presentbtn";
            this.presentbtn.Size = new System.Drawing.Size(89, 55);
            this.presentbtn.TabIndex = 4;
            this.presentbtn.Text = "PRESENT";
            this.presentbtn.UseVisualStyleBackColor = true;
            // 
            // ribboncolorbtn
            // 
            this.ribboncolorbtn.BackColor = System.Drawing.Color.Fuchsia;
            this.ribboncolorbtn.Location = new System.Drawing.Point(188, 158);
            this.ribboncolorbtn.Name = "ribboncolorbtn";
            this.ribboncolorbtn.Size = new System.Drawing.Size(92, 24);
            this.ribboncolorbtn.TabIndex = 5;
            this.ribboncolorbtn.UseVisualStyleBackColor = false;
            this.ribboncolorbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // boxcolorbtn
            // 
            this.boxcolorbtn.BackColor = System.Drawing.Color.Lime;
            this.boxcolorbtn.Location = new System.Drawing.Point(188, 128);
            this.boxcolorbtn.Name = "boxcolorbtn";
            this.boxcolorbtn.Size = new System.Drawing.Size(92, 24);
            this.boxcolorbtn.TabIndex = 6;
            this.boxcolorbtn.UseVisualStyleBackColor = false;
            this.boxcolorbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ballbutton;
        private System.Windows.Forms.Button carbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boxcolorbtn;
        private System.Windows.Forms.Button ribboncolorbtn;
        private System.Windows.Forms.Button presentbtn;
    }
}


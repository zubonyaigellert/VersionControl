namespace week07
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
            this.dgwTick = new System.Windows.Forms.DataGridView();
            this.dgwPortfolio = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPortfolio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTick
            // 
            this.dgwTick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTick.Location = new System.Drawing.Point(12, 12);
            this.dgwTick.Name = "dgwTick";
            this.dgwTick.RowHeadersWidth = 51;
            this.dgwTick.RowTemplate.Height = 24;
            this.dgwTick.Size = new System.Drawing.Size(338, 426);
            this.dgwTick.TabIndex = 0;
            // 
            // dgwPortfolio
            // 
            this.dgwPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPortfolio.Location = new System.Drawing.Point(356, 12);
            this.dgwPortfolio.Name = "dgwPortfolio";
            this.dgwPortfolio.RowHeadersWidth = 51;
            this.dgwPortfolio.RowTemplate.Height = 24;
            this.dgwPortfolio.Size = new System.Drawing.Size(315, 426);
            this.dgwPortfolio.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwPortfolio);
            this.Controls.Add(this.dgwTick);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPortfolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTick;
        private System.Windows.Forms.DataGridView dgwPortfolio;
        private System.Windows.Forms.Button button1;
    }
}


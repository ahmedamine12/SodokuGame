
namespace SudokuGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.verifierButton = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(239, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 191);
            this.panel1.TabIndex = 0;
            // 
            // verifierButton
            // 
            this.verifierButton.AutoSize = true;
            this.verifierButton.Location = new System.Drawing.Point(12, 91);
            this.verifierButton.Name = "verifierButton";
            this.verifierButton.Size = new System.Drawing.Size(75, 23);
            this.verifierButton.TabIndex = 1;
            this.verifierButton.Text = "Verifer";
            this.verifierButton.UseVisualStyleBackColor = true;
            this.verifierButton.Click += new System.EventHandler(this.verifierButton_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(12, 161);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 2;
            this.NewGame.Text = "Rejouer";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.verifierButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button verifierButton;
        private System.Windows.Forms.Button NewGame;
    }
}


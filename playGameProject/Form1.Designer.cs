
namespace playGameProject
{
    partial class back1State
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(back1State));
            this.startText = new System.Windows.Forms.Button();
            this.timeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startText
            // 
            this.startText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startText.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.startText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.ForeColor = System.Drawing.SystemColors.Control;
            this.startText.Location = new System.Drawing.Point(62, 41);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(158, 42);
            this.startText.TabIndex = 1;
            this.startText.Text = "Play Game";
            this.startText.UseVisualStyleBackColor = false;
            this.startText.Click += new System.EventHandler(this.startText_Click);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeText.Location = new System.Drawing.Point(88, 57);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(35, 13);
            this.timeText.TabIndex = 2;
            this.timeText.Text = "label1";
            // 
            // back1State
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.startText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "back1State";
            this.Text = "Worlds Best Game ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startText;
        private System.Windows.Forms.Label timeText;
    }
}


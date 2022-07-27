namespace BaluNatanApp
{
    partial class StarterForm
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
            this.Task1Button = new MaterialSkin.Controls.MaterialButton();
            this.Task2Button = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Task1Button
            // 
            this.Task1Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Task1Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Task1Button.Depth = 0;
            this.Task1Button.HighEmphasis = true;
            this.Task1Button.Icon = null;
            this.Task1Button.Location = new System.Drawing.Point(43, 88);
            this.Task1Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Task1Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Task1Button.Size = new System.Drawing.Size(94, 36);
            this.Task1Button.TabIndex = 0;
            this.Task1Button.Text = "ZADANIE 1";
            this.Task1Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Task1Button.UseAccentColor = false;
            this.Task1Button.UseVisualStyleBackColor = true;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // Task2Button
            // 
            this.Task2Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Task2Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Task2Button.Depth = 0;
            this.Task2Button.HighEmphasis = true;
            this.Task2Button.Icon = null;
            this.Task2Button.Location = new System.Drawing.Point(43, 148);
            this.Task2Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Task2Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Task2Button.Name = "Task2Button";
            this.Task2Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Task2Button.Size = new System.Drawing.Size(94, 36);
            this.Task2Button.TabIndex = 1;
            this.Task2Button.Text = "ZADANIE 2";
            this.Task2Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Task2Button.UseAccentColor = false;
            this.Task2Button.UseVisualStyleBackColor = true;
            this.Task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 211);
            this.Controls.Add(this.Task2Button);
            this.Controls.Add(this.Task1Button);
            this.Name = "StarterForm";
            this.Text = "Balu Natan";
            this.Load += new System.EventHandler(this.StarterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Task1Button;
        private MaterialSkin.Controls.MaterialButton Task2Button;
    }
}
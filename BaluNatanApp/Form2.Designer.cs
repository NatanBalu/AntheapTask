namespace BaluNatanApp
{
    partial class Form2
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
            this.EditFIleButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // EditFIleButton
            // 
            this.EditFIleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFIleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditFIleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditFIleButton.Depth = 0;
            this.EditFIleButton.HighEmphasis = true;
            this.EditFIleButton.Icon = null;
            this.EditFIleButton.Location = new System.Drawing.Point(24, 86);
            this.EditFIleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditFIleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditFIleButton.Name = "EditFIleButton";
            this.EditFIleButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditFIleButton.Size = new System.Drawing.Size(203, 36);
            this.EditFIleButton.TabIndex = 0;
            this.EditFIleButton.Text = "Wybierz plik z napisami";
            this.EditFIleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditFIleButton.UseAccentColor = false;
            this.EditFIleButton.UseVisualStyleBackColor = true;
            this.EditFIleButton.Click += new System.EventHandler(this.EditFIleButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 144);
            this.Controls.Add(this.EditFIleButton);
            this.Name = "Form2";
            this.Text = "Zadanie 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton EditFIleButton;
    }
}
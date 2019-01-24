namespace SpaceInvaders
{
    partial class GameOver
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
            this.lb_End = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_End
            // 
            this.lb_End.AutoSize = true;
            this.lb_End.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_End.ForeColor = System.Drawing.Color.Red;
            this.lb_End.Location = new System.Drawing.Point(192, 173);
            this.lb_End.Name = "lb_End";
            this.lb_End.Size = new System.Drawing.Size(405, 112);
            this.lb_End.TabIndex = 0;
            this.lb_End.Text = "YOU WON!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created by: Artur R. M. D. Azevedo";
            // 
            // bt_GoBack
            // 
            this.bt_GoBack.BackColor = System.Drawing.Color.Black;
            this.bt_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_GoBack.ForeColor = System.Drawing.Color.LightGray;
            this.bt_GoBack.Location = new System.Drawing.Point(12, 388);
            this.bt_GoBack.Margin = new System.Windows.Forms.Padding(0);
            this.bt_GoBack.Name = "bt_GoBack";
            this.bt_GoBack.Size = new System.Drawing.Size(75, 23);
            this.bt_GoBack.TabIndex = 2;
            this.bt_GoBack.Text = "Go Back";
            this.bt_GoBack.UseVisualStyleBackColor = false;
            this.bt_GoBack.Click += new System.EventHandler(this.bt_GoBack_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_GoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_End);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_GoBack;
    }
}
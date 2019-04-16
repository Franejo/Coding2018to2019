namespace YEETEDMYSKEETED
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(5, 13);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(349, 550);
            this.B1.TabIndex = 0;
            this.B1.Text = "Better";
            this.B1.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(360, 13);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(371, 550);
            this.B2.TabIndex = 1;
            this.B2.Text = "Choose";
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(737, 13);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(372, 550);
            this.B3.TabIndex = 2;
            this.B3.Text = "Correctly";
            this.B3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 634);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Name = "Form1";
            this.Text = "Skeet on a bih on monday";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
    }
}


namespace ICA3_RadiusFencatory
{
    partial class ICA3_RadiusFencatory
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
            this.B_Play = new System.Windows.Forms.Button();
            this.TimerClick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // B_Play
            // 
            this.B_Play.Location = new System.Drawing.Point(110, 123);
            this.B_Play.Name = "B_Play";
            this.B_Play.Size = new System.Drawing.Size(75, 23);
            this.B_Play.TabIndex = 0;
            this.B_Play.Text = "Play!";
            this.B_Play.UseVisualStyleBackColor = true;
            this.B_Play.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // TimerClick
            // 
            this.TimerClick.Interval = 20;
            this.TimerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
            // 
            // ICA3_RadiusFencatory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.B_Play);
            this.Name = "ICA3_RadiusFencatory";
            this.Text = "ICA3 - Ball Fencatory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Play;
        private System.Windows.Forms.Timer TimerClick;
    }
}


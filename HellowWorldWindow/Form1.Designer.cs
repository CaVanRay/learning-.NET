namespace HelloWorldWindow
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
            this.lblHelloWorld = new System.Windows.Forms.Button();
            this.lblGoodbyeWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.Location = new System.Drawing.Point(12, 12);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(278, 75);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Click Here!";
            this.lblHelloWorld.UseVisualStyleBackColor = true;
            this.lblHelloWorld.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGoodbyeWorld
            // 
            this.lblGoodbyeWorld.Location = new System.Drawing.Point(12, 105);
            this.lblGoodbyeWorld.Name = "lblGoodbyeWorld";
            this.lblGoodbyeWorld.Size = new System.Drawing.Size(278, 75);
            this.lblGoodbyeWorld.TabIndex = 1;
            this.lblGoodbyeWorld.Text = "Click Here!";
            this.lblGoodbyeWorld.UseVisualStyleBackColor = true;
            this.lblGoodbyeWorld.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGoodbyeWorld);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblHelloWorld;
        private System.Windows.Forms.Button lblGoodbyeWorld;
    }
}


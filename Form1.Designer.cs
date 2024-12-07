namespace CustomMessageApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.errorButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.criticalButton = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(360, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 38);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(360, 20);
            this.messageTextBox.TabIndex = 1;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(12, 64);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // errorButton
            // 
            this.errorButton.Location = new System.Drawing.Point(93, 64);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(75, 23);
            this.errorButton.TabIndex = 3;
            this.errorButton.Text = "Error";
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(174, 64);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(75, 23);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "Information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // criticalButton
            // 
            this.criticalButton.Location = new System.Drawing.Point(255, 64);
            this.criticalButton.Name = "criticalButton";
            this.criticalButton.Size = new System.Drawing.Size(75, 23);
            this.criticalButton.TabIndex = 5;
            this.criticalButton.Text = "Critical";
            this.criticalButton.UseVisualStyleBackColor = true;
            this.criticalButton.Click += new System.EventHandler(this.criticalButton_Click);
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(12, 93);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(75, 23);
            this.compileButton.TabIndex = 6;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 131);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.criticalButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.errorButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Form1";
            this.Text = "Custom Message Box App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button errorButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button criticalButton;
        private System.Windows.Forms.Button compileButton;
    }
}

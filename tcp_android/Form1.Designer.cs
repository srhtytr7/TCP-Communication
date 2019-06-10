namespace tcp_android
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
            this.button_asServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_asClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_asServer
            // 
            this.button_asServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_asServer.Location = new System.Drawing.Point(109, 135);
            this.button_asServer.Name = "button_asServer";
            this.button_asServer.Size = new System.Drawing.Size(169, 163);
            this.button_asServer.TabIndex = 0;
            this.button_asServer.Text = "As a Server";
            this.button_asServer.UseVisualStyleBackColor = true;
            this.button_asServer.Click += new System.EventHandler(this.Button_asServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TCP Communication Example with Android";
            // 
            // button_asClient
            // 
            this.button_asClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_asClient.Location = new System.Drawing.Point(367, 135);
            this.button_asClient.Name = "button_asClient";
            this.button_asClient.Size = new System.Drawing.Size(169, 163);
            this.button_asClient.TabIndex = 0;
            this.button_asClient.Text = "As a Client";
            this.button_asClient.UseVisualStyleBackColor = true;
            this.button_asClient.Click += new System.EventHandler(this.Button_asClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_asClient);
            this.Controls.Add(this.button_asServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_asServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_asClient;
    }
}


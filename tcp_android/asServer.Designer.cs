namespace tcp_android
{
    partial class asServer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_server_start = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button_server_start
            // 
            this.button_server_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_server_start.Location = new System.Drawing.Point(53, 492);
            this.button_server_start.Name = "button_server_start";
            this.button_server_start.Size = new System.Drawing.Size(208, 109);
            this.button_server_start.TabIndex = 11;
            this.button_server_start.Text = "SERVER START";
            this.button_server_start.UseVisualStyleBackColor = true;
            this.button_server_start.Click += new System.EventHandler(this.Button_server_start_Click);
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_send.Location = new System.Drawing.Point(53, 431);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(208, 35);
            this.button_send.TabIndex = 12;
            this.button_send.Text = "SEND";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "As Server";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 316);
            this.listBox1.TabIndex = 9;
            // 
            // asServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_server_start);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "asServer";
            this.Text = "asServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AsServer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_server_start;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
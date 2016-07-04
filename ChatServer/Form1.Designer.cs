namespace ChatServer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chatlistbox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendrichtextbox = new System.Windows.Forms.RichTextBox();
            this.sendmsgbtn = new System.Windows.Forms.Button();
            this.createserverbtn = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.sendbackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chatlistbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ChatBox";
            // 
            // chatlistbox
            // 
            this.chatlistbox.FormattingEnabled = true;
            this.chatlistbox.Location = new System.Drawing.Point(6, 19);
            this.chatlistbox.Name = "chatlistbox";
            this.chatlistbox.Size = new System.Drawing.Size(448, 173);
            this.chatlistbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendrichtextbox);
            this.groupBox2.Controls.Add(this.sendmsgbtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SendBox";
            // 
            // sendrichtextbox
            // 
            this.sendrichtextbox.Location = new System.Drawing.Point(6, 19);
            this.sendrichtextbox.Name = "sendrichtextbox";
            this.sendrichtextbox.Size = new System.Drawing.Size(448, 106);
            this.sendrichtextbox.TabIndex = 4;
            this.sendrichtextbox.Text = "";
            // 
            // sendmsgbtn
            // 
            this.sendmsgbtn.Location = new System.Drawing.Point(187, 131);
            this.sendmsgbtn.Name = "sendmsgbtn";
            this.sendmsgbtn.Size = new System.Drawing.Size(90, 23);
            this.sendmsgbtn.TabIndex = 3;
            this.sendmsgbtn.Text = "Send Message";
            this.sendmsgbtn.UseVisualStyleBackColor = true;
            // 
            // createserverbtn
            // 
            this.createserverbtn.Location = new System.Drawing.Point(12, 12);
            this.createserverbtn.Name = "createserverbtn";
            this.createserverbtn.Size = new System.Drawing.Size(99, 23);
            this.createserverbtn.TabIndex = 1;
            this.createserverbtn.Text = "Create Server";
            this.createserverbtn.UseVisualStyleBackColor = true;
            this.createserverbtn.Click += new System.EventHandler(this.sendmsgbtn_Click);
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(117, 17);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(40, 13);
            this.statuslbl.TabIndex = 2;
            this.statuslbl.Text = "Status:";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(397, 426);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.createserverbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Chat Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox chatlistbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox sendrichtextbox;
        private System.Windows.Forms.Button sendmsgbtn;
        private System.Windows.Forms.Button createserverbtn;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Button exitbtn;
        private System.ComponentModel.BackgroundWorker sendbackgroundWorker1;
    }
}


namespace ffxiv.act.logsim
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
            this.list_log = new System.Windows.Forms.ListView();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_fileOut = new System.Windows.Forms.TextBox();
            this.txt_fileIn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_lineWrite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_log
            // 
            this.list_log.Location = new System.Drawing.Point(64, 147);
            this.list_log.Name = "list_log";
            this.list_log.Size = new System.Drawing.Size(287, 175);
            this.list_log.TabIndex = 6;
            this.list_log.UseCompatibleStateImageBehavior = false;
            this.list_log.View = System.Windows.Forms.View.List;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(151, 90);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(49, 13);
            this.lbl_timer.TabIndex = 4;
            this.lbl_timer.Text = "00:00:00";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(70, 85);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_fileOut
            // 
            this.txt_fileOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fileOut.Enabled = false;
            this.txt_fileOut.Location = new System.Drawing.Point(70, 59);
            this.txt_fileOut.Name = "txt_fileOut";
            this.txt_fileOut.Size = new System.Drawing.Size(558, 20);
            this.txt_fileOut.TabIndex = 2;
            this.txt_fileOut.Text = "output.txt";
            // 
            // txt_fileIn
            // 
            this.txt_fileIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fileIn.Location = new System.Drawing.Point(70, 30);
            this.txt_fileIn.Name = "txt_fileIn";
            this.txt_fileIn.Size = new System.Drawing.Size(477, 20);
            this.txt_fileIn.TabIndex = 1;
            this.txt_fileIn.Text = "input.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_lineWrite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_timer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.txt_fileOut);
            this.groupBox1.Controls.Add(this.txt_fileIn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // lbl_lineWrite
            // 
            this.lbl_lineWrite.AutoSize = true;
            this.lbl_lineWrite.Location = new System.Drawing.Point(206, 90);
            this.lbl_lineWrite.Name = "lbl_lineWrite";
            this.lbl_lineWrite.Size = new System.Drawing.Size(13, 13);
            this.lbl_lineWrite.TabIndex = 8;
            this.lbl_lineWrite.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Input";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(553, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 542);
            this.Controls.Add(this.list_log);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ffxiv.act.logsim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_log;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_fileOut;
        private System.Windows.Forms.TextBox txt_fileIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_lineWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


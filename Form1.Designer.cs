namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            lsbMsg = new ListBox();
            txtMsg = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Cornsilk;
            lbl.Font = new Font("Georgia", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = SystemColors.HotTrack;
            lbl.Location = new Point(33, 34);
            lbl.Name = "lbl";
            lbl.Size = new Size(371, 56);
            lbl.TabIndex = 0;
            lbl.Text = "Echo Messenger";
            // 
            // lsbMsg
            // 
            lsbMsg.FormattingEnabled = true;
            lsbMsg.Location = new Point(142, 132);
            lsbMsg.Name = "lsbMsg";
            lsbMsg.Size = new Size(403, 199);
            lsbMsg.TabIndex = 1;
            lsbMsg.SelectedIndexChanged += lsbMsg_SelectedIndexChanged;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(142, 362);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(403, 23);
            txtMsg.TabIndex = 2;
            txtMsg.TextChanged += txtMsg_TextChanged;
            txtMsg.KeyDown += txtMsg_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.NavajoWhite;
            btnSend.Location = new Point(563, 361);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtMsg);
            Controls.Add(lsbMsg);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private ListBox lsbMsg;
        private TextBox txtMsg;
        private Button btnSend;
    }
}

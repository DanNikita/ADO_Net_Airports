namespace Airports
{
    partial class FormCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCon));
            label1 = new Label();
            label2 = new Label();
            txt_login = new TextBox();
            label3 = new Label();
            txt_password = new TextBox();
            btn_connect = new Button();
            label4 = new Label();
            txt_pgserver = new TextBox();
            label5 = new Label();
            txt_pgdb = new TextBox();
            lbl_status = new Label();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 0;
            label1.Text = "Please enter server information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 105);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Postgres Login";
            // 
            // txt_login
            // 
            txt_login.Location = new Point(129, 105);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(100, 23);
            txt_login.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 137);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 3;
            label3.Text = "Postgres password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(129, 134);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 4;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(11, 198);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(161, 23);
            btn_connect.TabIndex = 5;
            btn_connect.Text = "Establish connection";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 36);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 6;
            label4.Text = "Postgres server";
            // 
            // txt_pgserver
            // 
            txt_pgserver.Location = new Point(129, 36);
            txt_pgserver.Name = "txt_pgserver";
            txt_pgserver.Size = new Size(100, 23);
            txt_pgserver.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 68);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 8;
            label5.Text = "Server's database";
            // 
            // txt_pgdb
            // 
            txt_pgdb.Location = new Point(129, 68);
            txt_pgdb.Name = "txt_pgdb";
            txt_pgdb.Size = new Size(100, 23);
            txt_pgdb.TabIndex = 9;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(12, 170);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(124, 15);
            lbl_status.TabIndex = 10;
            lbl_status.Text = "Status: Not connected";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 227);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Use default";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FormCon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(471, 275);
            Controls.Add(radioButton1);
            Controls.Add(lbl_status);
            Controls.Add(txt_pgdb);
            Controls.Add(label5);
            Controls.Add(txt_pgserver);
            Controls.Add(label4);
            Controls.Add(btn_connect);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(txt_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCon";
            Text = "Connection Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_login;
        private Label label3;
        private TextBox txt_password;
        private Button btn_connect;
        private Label label4;
        private TextBox txt_pgserver;
        private Label label5;
        private TextBox txt_pgdb;
        private Label lbl_status;
        private RadioButton radioButton1;
    }
}

namespace Airports
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lbl_validatedA = new Label();
            btn_valA = new Button();
            label2 = new Label();
            txt_inputA = new TextBox();
            groupBox2 = new GroupBox();
            lbl_validatedB = new Label();
            btn_valB = new Button();
            label3 = new Label();
            txt_inputB = new TextBox();
            btn_calc = new Button();
            chk_search = new CheckedListBox();
            datagrid_search = new DataGridView();
            textBox1 = new TextBox();
            btn_search = new Button();
            btn_clear = new Button();
            bindingSource1 = new BindingSource(components);
            btn_update = new Button();
            btn_ask = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(310, 109);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 99);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(310, 109);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter two airports and validate them to calculate distance between them or use search first ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(lbl_validatedA);
            groupBox1.Controls.Add(btn_valA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_inputA);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 214);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Point A";
            // 
            // lbl_validatedA
            // 
            lbl_validatedA.AutoSize = true;
            lbl_validatedA.Location = new Point(102, 65);
            lbl_validatedA.Name = "lbl_validatedA";
            lbl_validatedA.Size = new Size(138, 15);
            lbl_validatedA.TabIndex = 5;
            lbl_validatedA.Text = "Validated - Airport exists!";
            lbl_validatedA.Visible = false;
            // 
            // btn_valA
            // 
            btn_valA.Location = new Point(9, 61);
            btn_valA.Name = "btn_valA";
            btn_valA.Size = new Size(75, 23);
            btn_valA.TabIndex = 4;
            btn_valA.Text = "Validate";
            btn_valA.UseVisualStyleBackColor = true;
            btn_valA.Click += btn_valA_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 25);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter Name or IATA";
            // 
            // txt_inputA
            // 
            txt_inputA.Location = new Point(122, 22);
            txt_inputA.Name = "txt_inputA";
            txt_inputA.Size = new Size(194, 23);
            txt_inputA.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(lbl_validatedB);
            groupBox2.Controls.Add(btn_valB);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(txt_inputB);
            groupBox2.Location = new Point(361, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 214);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Point B";
            // 
            // lbl_validatedB
            // 
            lbl_validatedB.AutoSize = true;
            lbl_validatedB.Location = new Point(99, 65);
            lbl_validatedB.Name = "lbl_validatedB";
            lbl_validatedB.Size = new Size(138, 15);
            lbl_validatedB.TabIndex = 6;
            lbl_validatedB.Text = "Validated - Airport exists!";
            lbl_validatedB.Visible = false;
            // 
            // btn_valB
            // 
            btn_valB.Location = new Point(9, 61);
            btn_valB.Name = "btn_valB";
            btn_valB.Size = new Size(75, 23);
            btn_valB.TabIndex = 5;
            btn_valB.Text = "Validate";
            btn_valB.UseVisualStyleBackColor = true;
            btn_valB.Click += btn_valB_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 25);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 5;
            label3.Text = "Enter Name or IATA";
            // 
            // txt_inputB
            // 
            txt_inputB.Location = new Point(122, 22);
            txt_inputB.Name = "txt_inputB";
            txt_inputB.Size = new Size(194, 23);
            txt_inputB.TabIndex = 4;
            // 
            // btn_calc
            // 
            btn_calc.Location = new Point(504, 9);
            btn_calc.Name = "btn_calc";
            btn_calc.Size = new Size(112, 23);
            btn_calc.TabIndex = 6;
            btn_calc.Text = "Calculate distance";
            btn_calc.UseVisualStyleBackColor = true;
            btn_calc.Click += btn_calc_Click;
            // 
            // chk_search
            // 
            chk_search.FormattingEnabled = true;
            chk_search.ImeMode = ImeMode.NoControl;
            chk_search.Items.AddRange(new object[] { "Country", "City", "Region" });
            chk_search.Location = new Point(12, 264);
            chk_search.Name = "chk_search";
            chk_search.Size = new Size(146, 58);
            chk_search.TabIndex = 7;
            // 
            // datagrid_search
            // 
            datagrid_search.AllowUserToDeleteRows = false;
            datagrid_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_search.Location = new Point(164, 264);
            datagrid_search.Name = "datagrid_search";
            datagrid_search.Size = new Size(519, 174);
            datagrid_search.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 328);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 9;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(12, 357);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(146, 23);
            btn_search.TabIndex = 10;
            btn_search.Text = "Search!";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(12, 386);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(146, 23);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "rel_aviation";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(12, 416);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(118, 23);
            btn_update.TabIndex = 12;
            btn_update.Text = "Submit";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_ask
            // 
            btn_ask.Location = new Point(134, 416);
            btn_ask.Name = "btn_ask";
            btn_ask.Size = new Size(24, 23);
            btn_ask.TabIndex = 13;
            btn_ask.Text = "?";
            btn_ask.UseVisualStyleBackColor = true;
            btn_ask.Click += btn_ask_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(btn_ask);
            Controls.Add(btn_update);
            Controls.Add(btn_clear);
            Controls.Add(btn_search);
            Controls.Add(textBox1);
            Controls.Add(datagrid_search);
            Controls.Add(chk_search);
            Controls.Add(btn_calc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Airports";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_search).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_valA;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txt_inputA;
        private Label label3;
        private TextBox txt_inputB;
        private Button btn_valB;
        private Button btn_calc;
        private Label lbl_validatedA;
        private Label lbl_validatedB;
        private CheckedListBox chk_search;
        private DataGridView datagrid_search;
        private TextBox textBox1;
        private Button btn_search;
        private Button btn_clear;
        public BindingSource bindingSource1;
        private Button btn_update;
        private Button btn_ask;
    }
}
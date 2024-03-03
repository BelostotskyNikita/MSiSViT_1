namespace MSiSViT_1
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
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            Column_i = new DataGridViewTextBoxColumn();
            Column_Operand = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Button_Parse = new Button();
            dataGridView1 = new DataGridView();
            Column_J = new DataGridViewTextBoxColumn();
            Column_Operator = new DataGridViewTextBoxColumn();
            Column_f1j = new DataGridViewTextBoxColumn();
            Button_Test = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            Label_Volume = new Label();
            Label_Length = new Label();
            Label_Dictionary = new Label();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1081, 721);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView2, 1, 0);
            tableLayoutPanel3.Controls.Add(Button_Parse, 0, 1);
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Controls.Add(Button_Test, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(3, 364);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.Size = new Size(1075, 353);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column_i, Column_Operator, dataGridViewTextBoxColumn3 });
            dataGridView2.Location = new Point(540, 4);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(532, 260);
            dataGridView2.TabIndex = 4;
            // 
            // Column_i
            // 
            Column_i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_i.HeaderText = "i";
            Column_i.MinimumWidth = 6;
            Column_i.Name = "Column_i";
            // 
            // Column_Operand
            // 
            Column_Operand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Operand.HeaderText = "Операнд";
            Column_Operand.MinimumWidth = 6;
            Column_Operand.Name = "Column_Operand";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "f_2_i";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Button_Parse
            // 
            Button_Parse.BackColor = Color.FromArgb(0, 192, 0);
            Button_Parse.Dock = DockStyle.Fill;
            Button_Parse.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Button_Parse.ForeColor = SystemColors.ControlText;
            Button_Parse.Location = new Point(3, 272);
            Button_Parse.Margin = new Padding(3, 4, 3, 4);
            Button_Parse.Name = "Button_Parse";
            Button_Parse.Size = new Size(531, 77);
            Button_Parse.TabIndex = 2;
            Button_Parse.Text = "Parse";
            Button_Parse.UseVisualStyleBackColor = false;
            Button_Parse.Click += Button_Parse_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_J, Column_Operand, Column_f1j });
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(531, 260);
            dataGridView1.TabIndex = 3;
            // 
            // Column_J
            // 
            Column_J.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_J.HeaderText = "j";
            Column_J.MinimumWidth = 6;
            Column_J.Name = "Column_J";
            // 
            // Column_Operator
            // 
            Column_Operator.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Operator.HeaderText = "Оператор";
            Column_Operator.MinimumWidth = 6;
            Column_Operator.Name = "Column_Operator";
            // 
            // Column_f1j
            // 
            Column_f1j.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_f1j.HeaderText = "f_1_j";
            Column_f1j.MinimumWidth = 6;
            Column_f1j.Name = "Column_f1j";
            // 
            // Button_Test
            // 
            Button_Test.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Button_Test.BackColor = Color.FromArgb(0, 192, 0);
            Button_Test.Font = new Font("Calibri", 14.25F);
            Button_Test.Location = new Point(540, 271);
            Button_Test.Name = "Button_Test";
            Button_Test.Size = new Size(532, 79);
            Button_Test.TabIndex = 5;
            Button_Test.Text = "Test";
            Button_Test.UseVisualStyleBackColor = false;
            Button_Test.Click += Button_Test_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 267F));
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1075, 352);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 4);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(877, 344);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Label_Volume, 0, 2);
            tableLayoutPanel2.Controls.Add(Label_Length, 0, 1);
            tableLayoutPanel2.Controls.Add(Label_Dictionary, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(886, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(261, 344);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Label_Volume
            // 
            Label_Volume.Anchor = AnchorStyles.Left;
            Label_Volume.AutoSize = true;
            Label_Volume.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Volume.Location = new Point(3, 275);
            Label_Volume.Name = "Label_Volume";
            Label_Volume.Size = new Size(22, 21);
            Label_Volume.TabIndex = 4;
            Label_Volume.Text = "...";
            // 
            // Label_Length
            // 
            Label_Length.Anchor = AnchorStyles.Left;
            Label_Length.AutoSize = true;
            Label_Length.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Length.Location = new Point(3, 160);
            Label_Length.Name = "Label_Length";
            Label_Length.Size = new Size(22, 21);
            Label_Length.TabIndex = 3;
            Label_Length.Text = "...";
            // 
            // Label_Dictionary
            // 
            Label_Dictionary.Anchor = AnchorStyles.Left;
            Label_Dictionary.AutoSize = true;
            Label_Dictionary.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Label_Dictionary.Location = new Point(3, 46);
            Label_Dictionary.Name = "Label_Dictionary";
            Label_Dictionary.Size = new Size(22, 21);
            Label_Dictionary.TabIndex = 0;
            Label_Dictionary.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 721);
            Controls.Add(tableLayoutPanel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Parser";
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column_i;
        private DataGridViewTextBoxColumn Column_Operand;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button Button_Parse;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_J;
        private DataGridViewTextBoxColumn Column_Operator;
        private DataGridViewTextBoxColumn Column_f1j;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Label_Volume;
        private Label Label_Length;
        private Label Label_Dictionary;
        private RichTextBox richTextBox1;
        private Button Button_Test;
    }
}

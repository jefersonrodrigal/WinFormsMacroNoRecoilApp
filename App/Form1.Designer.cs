namespace MacroApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxY = new GroupBox();
            nVertValue = new NumericUpDown();
            groupBoxX = new GroupBox();
            nHorValue = new NumericUpDown();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnReset = new Button();
            btnUpdate = new Button();
            groupBox4 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            cBoxAttack = new CheckBox();
            cBoxDefense = new CheckBox();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            nThreadValue = new NumericUpDown();
            notify1 = new NotifyIcon(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            cBoxFunction = new ComboBox();
            tbOperator = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBoxY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nVertValue).BeginInit();
            groupBoxX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nHorValue).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nThreadValue).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxY
            // 
            groupBoxY.Controls.Add(nVertValue);
            groupBoxY.Location = new Point(13, 61);
            groupBoxY.Margin = new Padding(3, 2, 3, 2);
            groupBoxY.Name = "groupBoxY";
            groupBoxY.Padding = new Padding(3, 2, 3, 2);
            groupBoxY.Size = new Size(430, 40);
            groupBoxY.TabIndex = 0;
            groupBoxY.TabStop = false;
            groupBoxY.Text = "Grau de Força Vertical  (Y)";
            // 
            // nVertValue
            // 
            nVertValue.Location = new Point(366, 13);
            nVertValue.Margin = new Padding(3, 2, 3, 2);
            nVertValue.Name = "nVertValue";
            nVertValue.Size = new Size(58, 23);
            nVertValue.TabIndex = 0;
            // 
            // groupBoxX
            // 
            groupBoxX.Controls.Add(nHorValue);
            groupBoxX.Location = new Point(14, 105);
            groupBoxX.Margin = new Padding(3, 2, 3, 2);
            groupBoxX.Name = "groupBoxX";
            groupBoxX.Padding = new Padding(3, 2, 3, 2);
            groupBoxX.Size = new Size(430, 36);
            groupBoxX.TabIndex = 1;
            groupBoxX.TabStop = false;
            groupBoxX.Text = "Grau de Força Horizontal (X)";
            // 
            // nHorValue
            // 
            nHorValue.Location = new Point(366, 13);
            nHorValue.Margin = new Padding(3, 2, 3, 2);
            nHorValue.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nHorValue.Name = "nHorValue";
            nHorValue.Size = new Size(58, 23);
            nHorValue.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 20);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 23);
            comboBox1.TabIndex = 2;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 3);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Operadores";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.WhiteSmoke;
            btnReset.Location = new Point(202, 371);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 22);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(104, 371);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Alterar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Location = new Point(14, 202);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(271, 51);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Macro - Pressione F2 -Ativar / Desativar";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 20);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Desabilitado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(123, 20);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 19);
            radioButton2.TabIndex = 0;
            radioButton2.Text = "Habilitado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // cBoxAttack
            // 
            cBoxAttack.AutoSize = true;
            cBoxAttack.Checked = true;
            cBoxAttack.CheckState = CheckState.Checked;
            cBoxAttack.Location = new Point(353, 5);
            cBoxAttack.Margin = new Padding(3, 2, 3, 2);
            cBoxAttack.Name = "cBoxAttack";
            cBoxAttack.Size = new Size(81, 19);
            cBoxAttack.TabIndex = 10;
            cBoxAttack.Text = "Atacantes";
            cBoxAttack.UseVisualStyleBackColor = true;
            // 
            // cBoxDefense
            // 
            cBoxDefense.AutoSize = true;
            cBoxDefense.Checked = true;
            cBoxDefense.CheckState = CheckState.Checked;
            cBoxDefense.Location = new Point(353, 28);
            cBoxDefense.Margin = new Padding(3, 2, 3, 2);
            cBoxDefense.Name = "cBoxDefense";
            cBoxDefense.Size = new Size(90, 19);
            cBoxDefense.TabIndex = 11;
            cBoxDefense.Text = "Defensores";
            cBoxDefense.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(14, 371);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nThreadValue);
            groupBox1.Location = new Point(13, 145);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(430, 36);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Valor da Thread No Recoil";
            // 
            // nThreadValue
            // 
            nThreadValue.Location = new Point(366, 13);
            nThreadValue.Margin = new Padding(3, 2, 3, 2);
            nThreadValue.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nThreadValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nThreadValue.Name = "nThreadValue";
            nThreadValue.Size = new Size(58, 23);
            nThreadValue.TabIndex = 0;
            nThreadValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // notify1
            // 
            notify1.Icon = (Icon)resources.GetObject("notify1.Icon");
            notify1.Visible = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(461, 455);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(groupBoxX);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(groupBoxY);
            tabPage1.Controls.Add(cBoxAttack);
            tabPage1.Controls.Add(cBoxDefense);
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(453, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Macro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(cBoxFunction);
            tabPage2.Controls.Add(tbOperator);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(453, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inserir Operador";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Location = new Point(18, 366);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // cBoxFunction
            // 
            cBoxFunction.FormattingEnabled = true;
            cBoxFunction.Items.AddRange(new object[] { "Atacante", "Defensor" });
            cBoxFunction.Location = new Point(276, 45);
            cBoxFunction.Name = "cBoxFunction";
            cBoxFunction.Size = new Size(155, 23);
            cBoxFunction.TabIndex = 3;
            // 
            // tbOperator
            // 
            tbOperator.Location = new Point(18, 45);
            tbOperator.Name = "tbOperator";
            tbOperator.Size = new Size(164, 23);
            tbOperator.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 17);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 1;
            label4.Text = "Função";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 17);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Operador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 457);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RainbownSixMacro";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBoxY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nVertValue).EndInit();
            groupBoxX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nHorValue).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nThreadValue).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxY;
        private GroupBox groupBoxX;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnReset;
        private Button btnUpdate;
        private GroupBox groupBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown nVertValue;
        private NumericUpDown nHorValue;
        private CheckBox cBoxAttack;
        private CheckBox cBoxDefense;
        private Button btnDelete;
        private GroupBox groupBox1;
        private NumericUpDown nThreadValue;
        private NotifyIcon notify1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private TextBox tbOperator;
        private Button button1;
        private ComboBox cBoxFunction;
    }
}

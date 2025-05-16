namespace Gestion_Empleados
{
    partial class FormEmpleados
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(507, 246);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(155, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 76);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(454, 50);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "JEFE", "CARGO1", "CARGO2", "CARGO3" });
            comboBox1.Location = new Point(269, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 23);
            textBox2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(155, 156);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(507, 141);
            dataGridView2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 85);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Cargo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 85);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Salario:";
            // 
            // button2
            // 
            button2.Location = new Point(269, 601);
            button2.Name = "button2";
            button2.Size = new Size(273, 38);
            button2.TabIndex = 9;
            button2.Text = "Volver al Dashboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 661);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "FormEmpleados";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}
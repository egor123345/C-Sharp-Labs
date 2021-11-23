namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button21 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.mem_plus = new System.Windows.Forms.Button();
            this.mem_save = new System.Windows.Forms.Button();
            this.mem_minus = new System.Windows.Forms.Button();
            this.mem_read = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Delete = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.output_pane = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.ForeColor = System.Drawing.SystemColors.Control;
            this.button21.Location = new System.Drawing.Point(125, 268);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(116, 47);
            this.button21.TabIndex = 41;
            this.button21.Text = "2";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // point
            // 
            this.point.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.SetColumnSpan(this.point, 2);
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.ForeColor = System.Drawing.SystemColors.Control;
            this.point.Location = new System.Drawing.Point(125, 321);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(238, 47);
            this.point.TabIndex = 45;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // mem_plus
            // 
            this.mem_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mem_plus.BackColor = System.Drawing.SystemColors.GrayText;
            this.mem_plus.ForeColor = System.Drawing.SystemColors.Control;
            this.mem_plus.Location = new System.Drawing.Point(125, 56);
            this.mem_plus.Name = "mem_plus";
            this.mem_plus.Size = new System.Drawing.Size(116, 47);
            this.mem_plus.TabIndex = 0;
            this.mem_plus.Text = "M+";
            this.mem_plus.UseVisualStyleBackColor = false;
            this.mem_plus.Click += new System.EventHandler(this.mem_plus_Click);
            // 
            // mem_save
            // 
            this.mem_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mem_save.BackColor = System.Drawing.SystemColors.GrayText;
            this.mem_save.ForeColor = System.Drawing.SystemColors.Control;
            this.mem_save.Location = new System.Drawing.Point(3, 56);
            this.mem_save.Name = "mem_save";
            this.mem_save.Size = new System.Drawing.Size(116, 47);
            this.mem_save.TabIndex = 25;
            this.mem_save.Text = "MS";
            this.mem_save.UseVisualStyleBackColor = false;
            this.mem_save.Click += new System.EventHandler(this.mem_save_Click);
            // 
            // mem_minus
            // 
            this.mem_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mem_minus.BackColor = System.Drawing.SystemColors.GrayText;
            this.mem_minus.ForeColor = System.Drawing.SystemColors.Control;
            this.mem_minus.Location = new System.Drawing.Point(247, 56);
            this.mem_minus.Name = "mem_minus";
            this.mem_minus.Size = new System.Drawing.Size(116, 47);
            this.mem_minus.TabIndex = 26;
            this.mem_minus.Text = "M-";
            this.mem_minus.UseVisualStyleBackColor = false;
            this.mem_minus.Click += new System.EventHandler(this.mem_minus_Click);
            // 
            // mem_read
            // 
            this.mem_read.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mem_read.BackColor = System.Drawing.SystemColors.GrayText;
            this.mem_read.ForeColor = System.Drawing.SystemColors.Control;
            this.mem_read.Location = new System.Drawing.Point(369, 56);
            this.mem_read.Name = "mem_read";
            this.mem_read.Size = new System.Drawing.Size(116, 47);
            this.mem_read.TabIndex = 27;
            this.mem_read.Text = "MR";
            this.mem_read.UseVisualStyleBackColor = false;
            this.mem_read.Click += new System.EventHandler(this.mem_read_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.SystemColors.GrayText;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clear.Location = new System.Drawing.Point(3, 109);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(116, 47);
            this.button_clear.TabIndex = 28;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.SystemColors.GrayText;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(247, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 47);
            this.button10.TabIndex = 30;
            this.button10.Text = "/";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button21_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.SystemColors.GrayText;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(369, 109);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 47);
            this.button11.TabIndex = 31;
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button21_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(3, 162);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(116, 47);
            this.button12.TabIndex = 32;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button21_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(125, 162);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(116, 47);
            this.button13.TabIndex = 33;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button21_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(247, 162);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(116, 47);
            this.button14.TabIndex = 34;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button21_Click);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.BackColor = System.Drawing.SystemColors.GrayText;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.SystemColors.Control;
            this.button15.Location = new System.Drawing.Point(369, 162);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(116, 47);
            this.button15.TabIndex = 35;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button21_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.ForeColor = System.Drawing.SystemColors.Control;
            this.button16.Location = new System.Drawing.Point(3, 215);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(116, 47);
            this.button16.TabIndex = 36;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button21_Click);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.SystemColors.Control;
            this.button17.Location = new System.Drawing.Point(125, 215);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(116, 47);
            this.button17.TabIndex = 37;
            this.button17.Text = "5";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button21_Click);
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.SystemColors.Control;
            this.button18.Location = new System.Drawing.Point(247, 215);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(116, 47);
            this.button18.TabIndex = 38;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button21_Click);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.BackColor = System.Drawing.SystemColors.GrayText;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.ForeColor = System.Drawing.SystemColors.Control;
            this.button19.Location = new System.Drawing.Point(369, 215);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(116, 47);
            this.button19.TabIndex = 39;
            this.button19.Text = "+";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.ForeColor = System.Drawing.SystemColors.Control;
            this.button20.Location = new System.Drawing.Point(3, 268);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(116, 47);
            this.button20.TabIndex = 40;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.ForeColor = System.Drawing.SystemColors.Control;
            this.button22.Location = new System.Drawing.Point(247, 268);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(116, 47);
            this.button22.TabIndex = 42;
            this.button22.Text = "3";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button21_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Delete, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button22, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button20, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button19, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button18, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button17, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button13, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_clear, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mem_minus, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.mem_save, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mem_plus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button24, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.point, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button21, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.calc, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.output_pane, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button16, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mem_read, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.SystemColors.GrayText;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.Delete.Location = new System.Drawing.Point(125, 109);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 47);
            this.Delete.TabIndex = 49;
            this.Delete.Text = "Del";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.ForeColor = System.Drawing.SystemColors.Control;
            this.button24.Location = new System.Drawing.Point(3, 321);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(116, 47);
            this.button24.TabIndex = 44;
            this.button24.Text = "0";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button21_Click);
            // 
            // calc
            // 
            this.calc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc.Location = new System.Drawing.Point(369, 268);
            this.calc.Name = "calc";
            this.tableLayoutPanel1.SetRowSpan(this.calc, 2);
            this.calc.Size = new System.Drawing.Size(116, 100);
            this.calc.TabIndex = 46;
            this.calc.Text = "=";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // output_pane
            // 
            this.output_pane.AutoSize = true;
            this.output_pane.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.SetColumnSpan(this.output_pane, 4);
            this.output_pane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_pane.ForeColor = System.Drawing.SystemColors.Control;
            this.output_pane.Location = new System.Drawing.Point(3, 0);
            this.output_pane.Name = "output_pane";
            this.output_pane.Size = new System.Drawing.Size(0, 29);
            this.output_pane.TabIndex = 47;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel1.SetColumnSpan(this.button4, 2);
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(247, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 49);
            this.button4.TabIndex = 48;
            this.button4.Text = ")";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button21_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(3, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 49);
            this.button1.TabIndex = 48;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button mem_read;
        private System.Windows.Forms.Button mem_minus;
        private System.Windows.Forms.Button mem_save;
        private System.Windows.Forms.Button mem_plus;
        private System.Windows.Forms.Label output_pane;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}


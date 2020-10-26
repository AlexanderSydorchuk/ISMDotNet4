namespace ISMDotNet4
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
            this.lb_array_length = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.tb_arr_length = new System.Windows.Forms.TextBox();
            this.dtg_arr_enter = new System.Windows.Forms.DataGridView();
            this.lb_SumOfNegative = new System.Windows.Forms.Label();
            this.b_DescendingOrder = new System.Windows.Forms.Button();
            this.b_accept = new System.Windows.Forms.Button();
            this.lb_Max = new System.Windows.Forms.Label();
            this.lb_IndexOfMax = new System.Windows.Forms.Label();
            this.lb_AbsMax = new System.Windows.Forms.Label();
            this.lb_SumPositiveNumIndexes = new System.Windows.Forms.Label();
            this.lb_AmountOfPositiveNumbers = new System.Windows.Forms.Label();
            this.lb_AmountOfIntegers = new System.Windows.Forms.Label();
            this.b_DeleteNegativeNumbers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_arr_enter)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_array_length
            // 
            this.lb_array_length.AutoSize = true;
            this.lb_array_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_array_length.Location = new System.Drawing.Point(12, 30);
            this.lb_array_length.Name = "lb_array_length";
            this.lb_array_length.Size = new System.Drawing.Size(247, 16);
            this.lb_array_length.TabIndex = 0;
            this.lb_array_length.Text = "Введіть кількість елементів у масиві:";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(372, 28);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 3;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(213, 12);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(234, 13);
            this.lb_error.TabIndex = 4;
            this.lb_error.Text = "Число повинне бути цілим і більшим за нуль!";
            this.lb_error.Visible = false;
            // 
            // tb_arr_length
            // 
            this.tb_arr_length.Location = new System.Drawing.Point(265, 29);
            this.tb_arr_length.Name = "tb_arr_length";
            this.tb_arr_length.Size = new System.Drawing.Size(100, 20);
            this.tb_arr_length.TabIndex = 5;
            this.tb_arr_length.TextChanged += new System.EventHandler(this.tb_arr_length_TextChanged_1);
            // 
            // dtg_arr_enter
            // 
            this.dtg_arr_enter.AllowUserToAddRows = false;
            this.dtg_arr_enter.AllowUserToDeleteRows = false;
            this.dtg_arr_enter.AllowUserToOrderColumns = true;
            this.dtg_arr_enter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_arr_enter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_arr_enter.Location = new System.Drawing.Point(12, 57);
            this.dtg_arr_enter.Name = "dtg_arr_enter";
            this.dtg_arr_enter.Size = new System.Drawing.Size(642, 95);
            this.dtg_arr_enter.TabIndex = 6;
            // 
            // lb_SumOfNegative
            // 
            this.lb_SumOfNegative.AutoSize = true;
            this.lb_SumOfNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SumOfNegative.Location = new System.Drawing.Point(12, 166);
            this.lb_SumOfNegative.Name = "lb_SumOfNegative";
            this.lb_SumOfNegative.Size = new System.Drawing.Size(136, 15);
            this.lb_SumOfNegative.TabIndex = 8;
            this.lb_SumOfNegative.Text = "Сума від\'ємних чисел: ";
            // 
            // b_DescendingOrder
            // 
            this.b_DescendingOrder.Location = new System.Drawing.Point(472, 225);
            this.b_DescendingOrder.Name = "b_DescendingOrder";
            this.b_DescendingOrder.Size = new System.Drawing.Size(182, 23);
            this.b_DescendingOrder.TabIndex = 14;
            this.b_DescendingOrder.Text = "Сортувати в порядку спадання";
            this.b_DescendingOrder.UseVisualStyleBackColor = true;
            this.b_DescendingOrder.Click += new System.EventHandler(this.b_DescendingOrder_Click);
            // 
            // b_accept
            // 
            this.b_accept.Location = new System.Drawing.Point(472, 163);
            this.b_accept.Name = "b_accept";
            this.b_accept.Size = new System.Drawing.Size(182, 23);
            this.b_accept.TabIndex = 15;
            this.b_accept.Text = "Застосувати\r\n";
            this.b_accept.UseVisualStyleBackColor = true;
            this.b_accept.Click += new System.EventHandler(this.b_accept_Click);
            // 
            // lb_Max
            // 
            this.lb_Max.AutoSize = true;
            this.lb_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Max.Location = new System.Drawing.Point(12, 184);
            this.lb_Max.Name = "lb_Max";
            this.lb_Max.Size = new System.Drawing.Size(130, 15);
            this.lb_Max.TabIndex = 16;
            this.lb_Max.Text = "Максимальне число: ";
            // 
            // lb_IndexOfMax
            // 
            this.lb_IndexOfMax.AutoSize = true;
            this.lb_IndexOfMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_IndexOfMax.Location = new System.Drawing.Point(12, 202);
            this.lb_IndexOfMax.Name = "lb_IndexOfMax";
            this.lb_IndexOfMax.Size = new System.Drawing.Size(182, 15);
            this.lb_IndexOfMax.TabIndex = 17;
            this.lb_IndexOfMax.Text = "Індекс максимального числа:  ";
            // 
            // lb_AbsMax
            // 
            this.lb_AbsMax.AutoSize = true;
            this.lb_AbsMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_AbsMax.Location = new System.Drawing.Point(12, 220);
            this.lb_AbsMax.Name = "lb_AbsMax";
            this.lb_AbsMax.Size = new System.Drawing.Size(194, 15);
            this.lb_AbsMax.TabIndex = 18;
            this.lb_AbsMax.Text = "Максимальне число по модулю: ";
            // 
            // lb_SumPositiveNumIndexes
            // 
            this.lb_SumPositiveNumIndexes.AutoSize = true;
            this.lb_SumPositiveNumIndexes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SumPositiveNumIndexes.Location = new System.Drawing.Point(12, 237);
            this.lb_SumPositiveNumIndexes.Name = "lb_SumPositiveNumIndexes";
            this.lb_SumPositiveNumIndexes.Size = new System.Drawing.Size(185, 15);
            this.lb_SumPositiveNumIndexes.TabIndex = 19;
            this.lb_SumPositiveNumIndexes.Text = "Сума індексів додатних чисел: ";
            // 
            // lb_AmountOfPositiveNumbers
            // 
            this.lb_AmountOfPositiveNumbers.AutoSize = true;
            this.lb_AmountOfPositiveNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_AmountOfPositiveNumbers.Location = new System.Drawing.Point(12, 254);
            this.lb_AmountOfPositiveNumbers.Name = "lb_AmountOfPositiveNumbers";
            this.lb_AmountOfPositiveNumbers.Size = new System.Drawing.Size(161, 15);
            this.lb_AmountOfPositiveNumbers.TabIndex = 20;
            this.lb_AmountOfPositiveNumbers.Text = "Кількість додатних чисел: ";
            // 
            // lb_AmountOfIntegers
            // 
            this.lb_AmountOfIntegers.AutoSize = true;
            this.lb_AmountOfIntegers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_AmountOfIntegers.Location = new System.Drawing.Point(12, 271);
            this.lb_AmountOfIntegers.Name = "lb_AmountOfIntegers";
            this.lb_AmountOfIntegers.Size = new System.Drawing.Size(136, 15);
            this.lb_AmountOfIntegers.TabIndex = 21;
            this.lb_AmountOfIntegers.Text = "Кількість цілих чисел: ";
            // 
            // b_DeleteNegativeNumbers
            // 
            this.b_DeleteNegativeNumbers.Location = new System.Drawing.Point(472, 254);
            this.b_DeleteNegativeNumbers.Name = "b_DeleteNegativeNumbers";
            this.b_DeleteNegativeNumbers.Size = new System.Drawing.Size(182, 23);
            this.b_DeleteNegativeNumbers.TabIndex = 22;
            this.b_DeleteNegativeNumbers.Text = "Видалити від\'ємні числа";
            this.b_DeleteNegativeNumbers.UseVisualStyleBackColor = true;
            this.b_DeleteNegativeNumbers.Click += new System.EventHandler(this.b_DeleteNegativeNumbers_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(666, 380);
            this.Controls.Add(this.b_DeleteNegativeNumbers);
            this.Controls.Add(this.lb_AmountOfIntegers);
            this.Controls.Add(this.lb_AmountOfPositiveNumbers);
            this.Controls.Add(this.lb_SumPositiveNumIndexes);
            this.Controls.Add(this.lb_AbsMax);
            this.Controls.Add(this.lb_IndexOfMax);
            this.Controls.Add(this.lb_Max);
            this.Controls.Add(this.b_accept);
            this.Controls.Add(this.b_DescendingOrder);
            this.Controls.Add(this.lb_SumOfNegative);
            this.Controls.Add(this.dtg_arr_enter);
            this.Controls.Add(this.tb_arr_length);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.lb_array_length);
            this.Name = "Form1";
            this.Text = "Обробка масивів";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_arr_enter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

 
        private System.Windows.Forms.Label lb_array_length;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.TextBox tb_arr_length;
        private System.Windows.Forms.DataGridView dtg_arr_enter;
        private System.Windows.Forms.Label lb_SumOfNegative;
        private System.Windows.Forms.Button b_DescendingOrder;
        private System.Windows.Forms.Button b_accept;
        private System.Windows.Forms.Label lb_Max;
        private System.Windows.Forms.Label lb_IndexOfMax;
        private System.Windows.Forms.Label lb_AbsMax;
        private System.Windows.Forms.Label lb_SumPositiveNumIndexes;
        private System.Windows.Forms.Label lb_AmountOfPositiveNumbers;
        private System.Windows.Forms.Label lb_AmountOfIntegers;
        private System.Windows.Forms.Button b_DeleteNegativeNumbers;
    }
}


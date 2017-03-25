namespace CalculatorUI
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_FirstNumber = new System.Windows.Forms.TextBox();
            this.tb_SecondNumber = new System.Windows.Forms.TextBox();
            this.lb_FirstNumber = new System.Windows.Forms.Label();
            this.lb_SecondNumber = new System.Windows.Forms.Label();
            this.lb_Result = new System.Windows.Forms.Label();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.lb_ChooseAction = new System.Windows.Forms.Label();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btn_Substraction = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_FirstNumber
            // 
            this.tb_FirstNumber.Location = new System.Drawing.Point(95, 10);
            this.tb_FirstNumber.Name = "tb_FirstNumber";
            this.tb_FirstNumber.Size = new System.Drawing.Size(128, 20);
            this.tb_FirstNumber.TabIndex = 0;
            // 
            // tb_SecondNumber
            // 
            this.tb_SecondNumber.Location = new System.Drawing.Point(95, 36);
            this.tb_SecondNumber.Name = "tb_SecondNumber";
            this.tb_SecondNumber.Size = new System.Drawing.Size(128, 20);
            this.tb_SecondNumber.TabIndex = 1;
            // 
            // lb_FirstNumber
            // 
            this.lb_FirstNumber.AutoSize = true;
            this.lb_FirstNumber.Location = new System.Drawing.Point(12, 13);
            this.lb_FirstNumber.Name = "lb_FirstNumber";
            this.lb_FirstNumber.Size = new System.Drawing.Size(80, 13);
            this.lb_FirstNumber.TabIndex = 2;
            this.lb_FirstNumber.Text = "Первое число:";
            // 
            // lb_SecondNumber
            // 
            this.lb_SecondNumber.AutoSize = true;
            this.lb_SecondNumber.Location = new System.Drawing.Point(12, 39);
            this.lb_SecondNumber.Name = "lb_SecondNumber";
            this.lb_SecondNumber.Size = new System.Drawing.Size(78, 13);
            this.lb_SecondNumber.TabIndex = 3;
            this.lb_SecondNumber.Text = "Второе число:";
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Location = new System.Drawing.Point(12, 157);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(62, 13);
            this.lb_Result.TabIndex = 5;
            this.lb_Result.Text = "Результат:";
            // 
            // tb_Result
            // 
            this.tb_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Result.Location = new System.Drawing.Point(95, 154);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(128, 20);
            this.tb_Result.TabIndex = 4;
            // 
            // lb_ChooseAction
            // 
            this.lb_ChooseAction.AutoSize = true;
            this.lb_ChooseAction.Location = new System.Drawing.Point(12, 68);
            this.lb_ChooseAction.Name = "lb_ChooseAction";
            this.lb_ChooseAction.Size = new System.Drawing.Size(110, 13);
            this.lb_ChooseAction.TabIndex = 6;
            this.lb_ChooseAction.Text = "Выберите действие:";
            // 
            // btn_Addition
            // 
            this.btn_Addition.Location = new System.Drawing.Point(15, 93);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(95, 23);
            this.btn_Addition.TabIndex = 7;
            this.btn_Addition.Text = "Сложение";
            this.btn_Addition.UseVisualStyleBackColor = true;
            this.btn_Addition.Click += new System.EventHandler(this.btn_Addition_Click);
            // 
            // btn_Substraction
            // 
            this.btn_Substraction.Location = new System.Drawing.Point(128, 93);
            this.btn_Substraction.Name = "btn_Substraction";
            this.btn_Substraction.Size = new System.Drawing.Size(95, 23);
            this.btn_Substraction.TabIndex = 8;
            this.btn_Substraction.Text = "Вычитание";
            this.btn_Substraction.UseVisualStyleBackColor = true;
            this.btn_Substraction.Click += new System.EventHandler(this.btn_Substraction_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(128, 122);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(95, 23);
            this.btn_Division.TabIndex = 10;
            this.btn_Division.Text = "Деление";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.Location = new System.Drawing.Point(15, 122);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(95, 23);
            this.btn_Multiplication.TabIndex = 9;
            this.btn_Multiplication.Text = "Умножение";
            this.btn_Multiplication.UseVisualStyleBackColor = true;
            this.btn_Multiplication.Click += new System.EventHandler(this.btn_Multiplication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 189);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_Substraction);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.lb_ChooseAction);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.lb_SecondNumber);
            this.Controls.Add(this.lb_FirstNumber);
            this.Controls.Add(this.tb_SecondNumber);
            this.Controls.Add(this.tb_FirstNumber);
            this.Name = "MainForm";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_FirstNumber;
        private System.Windows.Forms.TextBox tb_SecondNumber;
        private System.Windows.Forms.Label lb_FirstNumber;
        private System.Windows.Forms.Label lb_SecondNumber;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Label lb_ChooseAction;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btn_Substraction;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Multiplication;
    }
}


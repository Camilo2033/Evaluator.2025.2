namespace Evaluator.UI.Windows
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnResult = new Button();
            btnPow = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnCloseParethesis = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnOpenParenthesis = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.DodgerBlue;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(10, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(391, 39);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 18F);
            btn7.Location = new Point(14, 59);
            btn7.Name = "btn7";
            btn7.Size = new Size(48, 44);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 18F);
            btn4.Location = new Point(12, 109);
            btn4.Name = "btn4";
            btn4.Size = new Size(48, 44);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 18F);
            btn1.Location = new Point(12, 159);
            btn1.Name = "btn1";
            btn1.Size = new Size(48, 44);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 18F);
            btn2.Location = new Point(66, 159);
            btn2.Name = "btn2";
            btn2.Size = new Size(48, 44);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 18F);
            btn5.Location = new Point(66, 109);
            btn5.Name = "btn5";
            btn5.Size = new Size(48, 44);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 18F);
            btn8.Location = new Point(68, 59);
            btn8.Name = "btn8";
            btn8.Size = new Size(48, 44);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 18F);
            btn3.Location = new Point(122, 159);
            btn3.Name = "btn3";
            btn3.Size = new Size(48, 44);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 18F);
            btn6.Location = new Point(122, 109);
            btn6.Name = "btn6";
            btn6.Size = new Size(48, 44);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 18F);
            btn9.Location = new Point(124, 59);
            btn9.Name = "btn9";
            btn9.Size = new Size(48, 44);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Microsoft Sans Serif", 18F);
            btnDot.Location = new Point(124, 209);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(48, 44);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 18F);
            btn0.Location = new Point(14, 209);
            btn0.Name = "btn0";
            btn0.Size = new Size(102, 44);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.DodgerBlue;
            btnResult.Font = new Font("Microsoft Sans Serif", 18F);
            btnResult.Location = new Point(182, 209);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(204, 44);
            btnResult.TabIndex = 22;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.DodgerBlue;
            btnPow.Font = new Font("Microsoft Sans Serif", 18F);
            btnPow.Location = new Point(290, 159);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(96, 44);
            btnPow.TabIndex = 21;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 18F);
            btnClear.Location = new Point(290, 109);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 44);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DodgerBlue;
            btnDelete.Font = new Font("Microsoft Sans Serif", 18F);
            btnDelete.Location = new Point(292, 59);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 44);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCloseParethesis
            // 
            btnCloseParethesis.BackColor = Color.DodgerBlue;
            btnCloseParethesis.Font = new Font("Microsoft Sans Serif", 18F);
            btnCloseParethesis.Location = new Point(234, 159);
            btnCloseParethesis.Name = "btnCloseParethesis";
            btnCloseParethesis.Size = new Size(48, 44);
            btnCloseParethesis.TabIndex = 18;
            btnCloseParethesis.Text = ")";
            btnCloseParethesis.UseVisualStyleBackColor = false;
            btnCloseParethesis.Click += btnCloseParethesis_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.DodgerBlue;
            btnMinus.Font = new Font("Microsoft Sans Serif", 18F);
            btnMinus.Location = new Point(234, 109);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(48, 44);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.DodgerBlue;
            btnMultiply.Font = new Font("Microsoft Sans Serif", 18F);
            btnMultiply.Location = new Point(236, 59);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(48, 44);
            btnMultiply.TabIndex = 16;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.DodgerBlue;
            btnPlus.Font = new Font("Microsoft Sans Serif", 18F);
            btnPlus.Location = new Point(180, 109);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(48, 44);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.DodgerBlue;
            btnDivide.Font = new Font("Microsoft Sans Serif", 18F);
            btnDivide.Location = new Point(182, 59);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(48, 44);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.DodgerBlue;
            btnOpenParenthesis.Font = new Font("Microsoft Sans Serif", 18F);
            btnOpenParenthesis.Location = new Point(180, 159);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(48, 44);
            btnOpenParenthesis.TabIndex = 23;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(400, 275);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnResult);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParethesis);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnPlus);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnDot;
        private Button btn0;
        private Button btnResult;
        private Button btnPow;
        private Button btnClear;
        private Button btnDelete;
        private Button btnCloseParethesis;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnOpenParenthesis;
    }
}

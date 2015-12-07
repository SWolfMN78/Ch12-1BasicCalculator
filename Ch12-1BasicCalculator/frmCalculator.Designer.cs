namespace Ch12_1BasicCalculator
{
    partial class frmCalculator
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
            this.lblEquationAnswer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnPosNeg = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.lblTextDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnMemoryStore = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.lblMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEquationAnswer
            // 
            this.lblEquationAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquationAnswer.Location = new System.Drawing.Point(8, 104);
            this.lblEquationAnswer.Name = "lblEquationAnswer";
            this.lblEquationAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEquationAnswer.Size = new System.Drawing.Size(232, 23);
            this.lblEquationAnswer.TabIndex = 0;
            this.lblEquationAnswer.Text = "0";
            this.lblEquationAnswer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(48, 136);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(128, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 32);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.ForeColor = System.Drawing.Color.Blue;
            this.btn7.Location = new System.Drawing.Point(48, 176);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(32, 32);
            this.btn7.TabIndex = 22;
            this.btn7.Text = "&7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.ForeColor = System.Drawing.Color.Blue;
            this.btn4.Location = new System.Drawing.Point(48, 216);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(32, 32);
            this.btn4.TabIndex = 19;
            this.btn4.Text = "&4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.Color.Blue;
            this.btn1.Location = new System.Drawing.Point(48, 256);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(32, 32);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "&1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.ForeColor = System.Drawing.Color.Blue;
            this.btn0.Location = new System.Drawing.Point(48, 296);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(32, 32);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "&0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.ForeColor = System.Drawing.Color.Blue;
            this.btn8.Location = new System.Drawing.Point(88, 176);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(32, 32);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "&8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.ForeColor = System.Drawing.Color.Blue;
            this.btn5.Location = new System.Drawing.Point(88, 216);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(32, 32);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "&5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.Color.Blue;
            this.btn2.Location = new System.Drawing.Point(88, 256);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(32, 32);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "&2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnPosNeg
            // 
            this.btnPosNeg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPosNeg.ForeColor = System.Drawing.Color.Blue;
            this.btnPosNeg.Location = new System.Drawing.Point(88, 296);
            this.btnPosNeg.Name = "btnPosNeg";
            this.btnPosNeg.Size = new System.Drawing.Size(32, 32);
            this.btnPosNeg.TabIndex = 10;
            this.btnPosNeg.Text = "+/-";
            this.btnPosNeg.UseVisualStyleBackColor = true;
            this.btnPosNeg.Click += new System.EventHandler(this.btnPosNeg_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.ForeColor = System.Drawing.Color.Blue;
            this.btn9.Location = new System.Drawing.Point(128, 176);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(32, 32);
            this.btn9.TabIndex = 24;
            this.btn9.Text = "&9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.ForeColor = System.Drawing.Color.Blue;
            this.btn6.Location = new System.Drawing.Point(128, 216);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(32, 32);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "&6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.ForeColor = System.Drawing.Color.Blue;
            this.btn3.Location = new System.Drawing.Point(128, 256);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 32);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "&3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.ForeColor = System.Drawing.Color.Blue;
            this.btnDecimal.Location = new System.Drawing.Point(128, 296);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(32, 32);
            this.btnDecimal.TabIndex = 9;
            this.btnDecimal.Text = "&.";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(168, 176);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 32);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "&/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(168, 216);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(32, 32);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "&*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.Red;
            this.btnSubtract.Location = new System.Drawing.Point(168, 256);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 32);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "&-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.Color.Red;
            this.btnAddition.Location = new System.Drawing.Point(168, 296);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(32, 32);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "&+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquareRoot.ForeColor = System.Drawing.Color.Blue;
            this.btnSquareRoot.Location = new System.Drawing.Point(208, 176);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(32, 32);
            this.btnSquareRoot.TabIndex = 2;
            this.btnSquareRoot.Text = "sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.ForeColor = System.Drawing.Color.Blue;
            this.btnReciprocal.Location = new System.Drawing.Point(208, 216);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReciprocal.Size = new System.Drawing.Size(32, 32);
            this.btnReciprocal.TabIndex = 3;
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.Red;
            this.btnEqual.Location = new System.Drawing.Point(208, 256);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(32, 72);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "&=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // lblTextDisplay
            // 
            this.lblTextDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTextDisplay.Location = new System.Drawing.Point(8, 64);
            this.lblTextDisplay.Name = "lblTextDisplay";
            this.lblTextDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTextDisplay.Size = new System.Drawing.Size(232, 23);
            this.lblTextDisplay.TabIndex = 22;
            this.lblTextDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "Shawn J. Wolf\r\nBasic & Memory Calculator\r\nProjects 12-1 && 14-1";
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMemoryClear.ForeColor = System.Drawing.Color.Blue;
            this.btnMemoryClear.Location = new System.Drawing.Point(8, 296);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(32, 32);
            this.btnMemoryClear.TabIndex = 14;
            this.btnMemoryClear.Text = "M&C";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // btnMemoryStore
            // 
            this.btnMemoryStore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMemoryStore.ForeColor = System.Drawing.Color.Blue;
            this.btnMemoryStore.Location = new System.Drawing.Point(8, 176);
            this.btnMemoryStore.Name = "btnMemoryStore";
            this.btnMemoryStore.Size = new System.Drawing.Size(32, 32);
            this.btnMemoryStore.TabIndex = 11;
            this.btnMemoryStore.Text = "M&S";
            this.btnMemoryStore.UseVisualStyleBackColor = true;
            this.btnMemoryStore.Click += new System.EventHandler(this.btnMemoryStore_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMemoryRecall.ForeColor = System.Drawing.Color.Blue;
            this.btnMemoryRecall.Location = new System.Drawing.Point(8, 216);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(32, 32);
            this.btnMemoryRecall.TabIndex = 12;
            this.btnMemoryRecall.Text = "M&R";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btnMemoryRecall_Click);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMemoryAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnMemoryAdd.Location = new System.Drawing.Point(8, 256);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(32, 32);
            this.btnMemoryAdd.TabIndex = 13;
            this.btnMemoryAdd.Text = "&M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = true;
            this.btnMemoryAdd.Click += new System.EventHandler(this.btnMemoryAdd_Click);
            // 
            // lblMemory
            // 
            this.lblMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.Location = new System.Drawing.Point(8, 136);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(32, 32);
            this.lblMemory.TabIndex = 28;
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 336);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.btnMemoryAdd);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnMemoryStore);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTextDisplay);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnPosNeg);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEquationAnswer);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquationAnswer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnPosNeg;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label lblTextDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryStore;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Label lblMemory;
    }
}


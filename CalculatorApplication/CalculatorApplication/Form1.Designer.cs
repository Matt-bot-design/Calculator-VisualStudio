
namespace CalculatorApplication
{
    partial class Form1
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
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculatorDisplay.Location = new System.Drawing.Point(12, 9);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(294, 59);
            this.calculatorDisplay.TabIndex = 0;
            this.calculatorDisplay.Text = "0";
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 100);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(63, 40);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 146);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(63, 40);
            this.btnFour.TabIndex = 2;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(12, 284);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(141, 40);
            this.btnEqual.TabIndex = 3;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(243, 238);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(63, 40);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(243, 146);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(63, 40);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(243, 100);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(63, 40);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(150, 238);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(63, 40);
            this.btnClr.TabIndex = 8;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(81, 238);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(63, 40);
            this.btnDec.TabIndex = 9;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(12, 238);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(63, 40);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 192);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(63, 40);
            this.btnOne.TabIndex = 11;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(81, 192);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(63, 40);
            this.btnTwo.TabIndex = 12;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(150, 192);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(63, 40);
            this.btnThree.TabIndex = 13;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(150, 146);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(63, 40);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(150, 100);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(63, 40);
            this.btnNine.TabIndex = 15;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(81, 146);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(63, 40);
            this.btnFive.TabIndex = 16;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(81, 100);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(63, 40);
            this.btnEight.TabIndex = 17;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 341);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.calculatorDisplay);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
    }
}


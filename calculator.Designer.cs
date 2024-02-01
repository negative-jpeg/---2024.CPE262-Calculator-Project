using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1___CPE262_Calculator_Project
{
    public partial class calculator
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
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
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            EqualBtn = new Button();
            EightBtn = new Button();
            FiveBtn = new Button();
            TwoBtn = new Button();
            ZeroBtn = new Button();
            NineBtn = new Button();
            SixBtn = new Button();
            ThreeBtn = new Button();
            DotBtn = new Button();
            MinusBtn = new Button();
            DivideBtn = new Button();
            UndoBtn = new Button();
            ClearBtn = new Button();
            PlusBtn = new Button();
            MultiplyBtn = new Button();
            MinusPlusBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.BackColor = SystemColors.ControlLightLight;
            TxtBox.Font = new Font("Segoe UI", 40F);
            TxtBox.Location = new Point(12, 12);
            TxtBox.Name = "TxtBox";
            TxtBox.PlaceholderText = "0";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(440, 96);
            TxtBox.TabIndex = 0;
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.BackColor = SystemColors.ControlLightLight;
            SevenBtn.Font = new Font("Segoe UI", 22F);
            SevenBtn.Location = new Point(12, 123);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(80, 80);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = false;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.BackColor = SystemColors.ControlLightLight;
            FourBtn.Font = new Font("Segoe UI", 22F);
            FourBtn.Location = new Point(12, 209);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(80, 80);
            FourBtn.TabIndex = 1;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = false;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.BackColor = SystemColors.ControlLightLight;
            OneBtn.Font = new Font("Segoe UI", 22F);
            OneBtn.Location = new Point(12, 295);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(80, 80);
            OneBtn.TabIndex = 1;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = false;
            OneBtn.Click += OneBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.BackColor = Color.DarkRed;
            EqualBtn.FlatStyle = FlatStyle.Popup;
            EqualBtn.Font = new Font("Segoe UI", 26F);
            EqualBtn.ForeColor = SystemColors.ControlLightLight;
            EqualBtn.Location = new Point(372, 295);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(80, 166);
            EqualBtn.TabIndex = 1;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = false;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.BackColor = SystemColors.ControlLightLight;
            EightBtn.Font = new Font("Segoe UI", 22F);
            EightBtn.Location = new Point(98, 123);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(80, 80);
            EightBtn.TabIndex = 1;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = false;
            EightBtn.Click += EightBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.BackColor = SystemColors.ControlLightLight;
            FiveBtn.Font = new Font("Segoe UI", 22F);
            FiveBtn.Location = new Point(98, 209);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(80, 80);
            FiveBtn.TabIndex = 1;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = false;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.BackColor = SystemColors.ControlLightLight;
            TwoBtn.Font = new Font("Segoe UI", 22F);
            TwoBtn.Location = new Point(98, 295);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(80, 80);
            TwoBtn.TabIndex = 1;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = false;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.BackColor = SystemColors.ControlLightLight;
            ZeroBtn.Font = new Font("Segoe UI", 22F);
            ZeroBtn.Location = new Point(98, 381);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(80, 80);
            ZeroBtn.TabIndex = 1;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = false;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.BackColor = SystemColors.ControlLightLight;
            NineBtn.Font = new Font("Segoe UI", 22F);
            NineBtn.Location = new Point(184, 123);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(80, 80);
            NineBtn.TabIndex = 1;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = false;
            NineBtn.Click += NineBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.BackColor = SystemColors.ControlLightLight;
            SixBtn.Font = new Font("Segoe UI", 22F);
            SixBtn.Location = new Point(184, 209);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(80, 80);
            SixBtn.TabIndex = 1;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = false;
            SixBtn.Click += SixBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.BackColor = SystemColors.ControlLightLight;
            ThreeBtn.Font = new Font("Segoe UI", 22F);
            ThreeBtn.Location = new Point(184, 295);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(80, 80);
            ThreeBtn.TabIndex = 1;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = false;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.BackColor = SystemColors.ControlLightLight;
            DotBtn.Font = new Font("Segoe UI", 24F);
            DotBtn.Location = new Point(184, 381);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(80, 80);
            DotBtn.TabIndex = 1;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = false;
            DotBtn.Click += DotBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.BackColor = SystemColors.ControlLightLight;
            MinusBtn.Font = new Font("Segoe UI", 18F);
            MinusBtn.Location = new Point(286, 209);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(80, 80);
            MinusBtn.TabIndex = 1;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = false;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.BackColor = SystemColors.ControlLightLight;
            DivideBtn.Font = new Font("Segoe UI", 18F);
            DivideBtn.Location = new Point(286, 381);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(80, 80);
            DivideBtn.TabIndex = 1;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = false;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // UndoBtn
            // 
            UndoBtn.BackColor = SystemColors.ControlLightLight;
            UndoBtn.Font = new Font("Segoe UI", 18F);
            UndoBtn.Location = new Point(372, 209);
            UndoBtn.Name = "UndoBtn";
            UndoBtn.Size = new Size(80, 80);
            UndoBtn.TabIndex = 1;
            UndoBtn.Text = "Del";
            UndoBtn.UseVisualStyleBackColor = false;
            UndoBtn.Click += UndoBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = SystemColors.ControlLightLight;
            ClearBtn.Font = new Font("Segoe UI", 18F);
            ClearBtn.Location = new Point(372, 123);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(80, 80);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Clr";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.BackColor = SystemColors.ControlLightLight;
            PlusBtn.Font = new Font("Segoe UI", 18F);
            PlusBtn.Location = new Point(286, 123);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(80, 80);
            PlusBtn.TabIndex = 1;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = false;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.BackColor = SystemColors.ControlLightLight;
            MultiplyBtn.Font = new Font("Segoe UI", 18F);
            MultiplyBtn.Location = new Point(286, 295);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(80, 80);
            MultiplyBtn.TabIndex = 1;
            MultiplyBtn.Text = "*";
            MultiplyBtn.UseVisualStyleBackColor = false;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.BackColor = SystemColors.ControlLightLight;
            MinusPlusBtn.Font = new Font("Segoe UI", 18F);
            MinusPlusBtn.Location = new Point(12, 381);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(80, 80);
            MinusPlusBtn.TabIndex = 1;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = false;
            MinusPlusBtn.Click += MinusPlusBtn_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(464, 473);
            Controls.Add(MinusPlusBtn);
            Controls.Add(UndoBtn);
            Controls.Add(DotBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(EqualBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(DivideBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(TwoBtn);
            Controls.Add(OneBtn);
            Controls.Add(PlusBtn);
            Controls.Add(MinusBtn);
            Controls.Add(SixBtn);
            Controls.Add(FiveBtn);
            Controls.Add(FourBtn);
            Controls.Add(ClearBtn);
            Controls.Add(NineBtn);
            Controls.Add(EightBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Name = "calculator";
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void ModuloBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TxtBox.Text = "";
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if(TxtBox.Text.Length > 0)
            {
                TxtBox.Text = TxtBox.Text.Remove(TxtBox.Text.Length - 1, 1);
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst - valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "+":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "*":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst / valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;

                case "%":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst % valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if(TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button EqualBtn;
        private Button EightBtn;
        private Button FiveBtn;
        private Button TwoBtn;
        private Button ZeroBtn;
        private Button NineBtn;
        private Button SixBtn;
        private Button ThreeBtn;
        private Button DotBtn;
        private Button MinusBtn;
        private Button DivideBtn;
        private Button UndoBtn;
        private Button ClearBtn;
        private Button PlusBtn;
        private Button MultiplyBtn;
        private Button MinusPlusBtn;
    }
}

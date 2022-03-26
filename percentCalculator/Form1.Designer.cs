namespace percentCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.totalRatioTitle = new System.Windows.Forms.Label();
            this.totalRatioText1 = new System.Windows.Forms.TextBox();
            this.totalRatioLabel1 = new System.Windows.Forms.Label();
            this.totalRatioText2 = new System.Windows.Forms.TextBox();
            this.totalRatioLabel2 = new System.Windows.Forms.Label();
            this.totalRatioText3 = new System.Windows.Forms.TextBox();
            this.totalRatioLabel3 = new System.Windows.Forms.Label();
            this.totalValuesLabel3 = new System.Windows.Forms.Label();
            this.totalValuesText3 = new System.Windows.Forms.TextBox();
            this.totalValuesLabel2 = new System.Windows.Forms.Label();
            this.totalValuesText2 = new System.Windows.Forms.TextBox();
            this.totalValuesLabel1 = new System.Windows.Forms.Label();
            this.totalValuesText1 = new System.Windows.Forms.TextBox();
            this.totalValuesTitle = new System.Windows.Forms.Label();
            this.pointInDeLabel5 = new System.Windows.Forms.Label();
            this.pointInDeText3 = new System.Windows.Forms.TextBox();
            this.pointInDeLabel2 = new System.Windows.Forms.Label();
            this.pointInDeText2 = new System.Windows.Forms.TextBox();
            this.pointInDeLabel1 = new System.Windows.Forms.Label();
            this.pointInDeText1 = new System.Windows.Forms.TextBox();
            this.pointInDeTitle = new System.Windows.Forms.Label();
            this.pointInDiRatioLabel4 = new System.Windows.Forms.Label();
            this.pointInDiRatioText3 = new System.Windows.Forms.TextBox();
            this.pointInDiRatioLabel2 = new System.Windows.Forms.Label();
            this.pointInDiRatioText2 = new System.Windows.Forms.TextBox();
            this.pointInDiRatioLabel1 = new System.Windows.Forms.Label();
            this.pointInDiRatioText1 = new System.Windows.Forms.TextBox();
            this.pointInDiRatioTitle = new System.Windows.Forms.Label();
            this.pointInDiRatioLabel3 = new System.Windows.Forms.Label();
            this.pointInDiRatioCheck = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.fixCheckBox = new System.Windows.Forms.CheckBox();
            this.pointInDeLabel3 = new System.Windows.Forms.Label();
            this.pointInDeLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalRatioTitle
            // 
            this.totalRatioTitle.AutoSize = true;
            this.totalRatioTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalRatioTitle.Location = new System.Drawing.Point(25, 22);
            this.totalRatioTitle.Name = "totalRatioTitle";
            this.totalRatioTitle.Size = new System.Drawing.Size(282, 15);
            this.totalRatioTitle.TabIndex = 0;
            this.totalRatioTitle.Text = "전체값에서 일정 비율에 해당하는 값을 계산합니다.";
            // 
            // totalRatioText1
            // 
            this.totalRatioText1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalRatioText1.Location = new System.Drawing.Point(25, 43);
            this.totalRatioText1.Name = "totalRatioText1";
            this.totalRatioText1.PlaceholderText = "전체값 100 ";
            this.totalRatioText1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalRatioText1.Size = new System.Drawing.Size(100, 23);
            this.totalRatioText1.TabIndex = 1;
            this.totalRatioText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalRatioText1.TextChanged += new System.EventHandler(this.totalRatioTextChanged);
            this.totalRatioText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // totalRatioLabel1
            // 
            this.totalRatioLabel1.AutoSize = true;
            this.totalRatioLabel1.Location = new System.Drawing.Point(131, 48);
            this.totalRatioLabel1.Name = "totalRatioLabel1";
            this.totalRatioLabel1.Size = new System.Drawing.Size(19, 15);
            this.totalRatioLabel1.TabIndex = 2;
            this.totalRatioLabel1.Text = "의";
            // 
            // totalRatioText2
            // 
            this.totalRatioText2.Location = new System.Drawing.Point(187, 43);
            this.totalRatioText2.Name = "totalRatioText2";
            this.totalRatioText2.PlaceholderText = "비율값 20";
            this.totalRatioText2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalRatioText2.Size = new System.Drawing.Size(100, 23);
            this.totalRatioText2.TabIndex = 3;
            this.totalRatioText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalRatioText2.TextChanged += new System.EventHandler(this.totalRatioTextChanged);
            this.totalRatioText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // totalRatioLabel2
            // 
            this.totalRatioLabel2.AutoSize = true;
            this.totalRatioLabel2.Location = new System.Drawing.Point(293, 46);
            this.totalRatioLabel2.Name = "totalRatioLabel2";
            this.totalRatioLabel2.Size = new System.Drawing.Size(33, 15);
            this.totalRatioLabel2.TabIndex = 4;
            this.totalRatioLabel2.Text = "% 는";
            // 
            // totalRatioText3
            // 
            this.totalRatioText3.Enabled = false;
            this.totalRatioText3.Location = new System.Drawing.Point(370, 43);
            this.totalRatioText3.Name = "totalRatioText3";
            this.totalRatioText3.PlaceholderText = "일부값 20";
            this.totalRatioText3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalRatioText3.Size = new System.Drawing.Size(100, 23);
            this.totalRatioText3.TabIndex = 5;
            this.totalRatioText3.TabStop = false;
            this.totalRatioText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalRatioLabel3
            // 
            this.totalRatioLabel3.AutoSize = true;
            this.totalRatioLabel3.Location = new System.Drawing.Point(476, 46);
            this.totalRatioLabel3.Name = "totalRatioLabel3";
            this.totalRatioLabel3.Size = new System.Drawing.Size(46, 15);
            this.totalRatioLabel3.TabIndex = 6;
            this.totalRatioLabel3.Text = "입니다.";
            // 
            // totalValuesLabel3
            // 
            this.totalValuesLabel3.AutoSize = true;
            this.totalValuesLabel3.Location = new System.Drawing.Point(476, 111);
            this.totalValuesLabel3.Name = "totalValuesLabel3";
            this.totalValuesLabel3.Size = new System.Drawing.Size(60, 15);
            this.totalValuesLabel3.TabIndex = 13;
            this.totalValuesLabel3.Text = "% 입니다.";
            // 
            // totalValuesText3
            // 
            this.totalValuesText3.Enabled = false;
            this.totalValuesText3.Location = new System.Drawing.Point(370, 106);
            this.totalValuesText3.Name = "totalValuesText3";
            this.totalValuesText3.PlaceholderText = "비율값 20";
            this.totalValuesText3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalValuesText3.Size = new System.Drawing.Size(100, 23);
            this.totalValuesText3.TabIndex = 12;
            this.totalValuesText3.TabStop = false;
            this.totalValuesText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalValuesLabel2
            // 
            this.totalValuesLabel2.AutoSize = true;
            this.totalValuesLabel2.Location = new System.Drawing.Point(293, 111);
            this.totalValuesLabel2.Name = "totalValuesLabel2";
            this.totalValuesLabel2.Size = new System.Drawing.Size(39, 15);
            this.totalValuesLabel2.TabIndex = 11;
            this.totalValuesLabel2.Text = "(은)는";
            // 
            // totalValuesText2
            // 
            this.totalValuesText2.Location = new System.Drawing.Point(187, 106);
            this.totalValuesText2.Name = "totalValuesText2";
            this.totalValuesText2.PlaceholderText = "일부값 20";
            this.totalValuesText2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalValuesText2.Size = new System.Drawing.Size(100, 23);
            this.totalValuesText2.TabIndex = 10;
            this.totalValuesText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalValuesText2.TextChanged += new System.EventHandler(this.totalValuesTextChanged);
            this.totalValuesText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // totalValuesLabel1
            // 
            this.totalValuesLabel1.AutoSize = true;
            this.totalValuesLabel1.Location = new System.Drawing.Point(131, 111);
            this.totalValuesLabel1.Name = "totalValuesLabel1";
            this.totalValuesLabel1.Size = new System.Drawing.Size(31, 15);
            this.totalValuesLabel1.TabIndex = 9;
            this.totalValuesLabel1.Text = "에서";
            // 
            // totalValuesText1
            // 
            this.totalValuesText1.Location = new System.Drawing.Point(25, 106);
            this.totalValuesText1.Name = "totalValuesText1";
            this.totalValuesText1.PlaceholderText = "전체값 100 ";
            this.totalValuesText1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalValuesText1.Size = new System.Drawing.Size(100, 23);
            this.totalValuesText1.TabIndex = 8;
            this.totalValuesText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalValuesText1.TextChanged += new System.EventHandler(this.totalValuesTextChanged);
            this.totalValuesText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // totalValuesTitle
            // 
            this.totalValuesTitle.AutoSize = true;
            this.totalValuesTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalValuesTitle.Location = new System.Drawing.Point(25, 85);
            this.totalValuesTitle.Name = "totalValuesTitle";
            this.totalValuesTitle.Size = new System.Drawing.Size(270, 15);
            this.totalValuesTitle.TabIndex = 7;
            this.totalValuesTitle.Text = "전체값의 일정 값에 해당하는 비율을 계산합니다.";
            // 
            // pointInDeLabel5
            // 
            this.pointInDeLabel5.AutoSize = true;
            this.pointInDeLabel5.Location = new System.Drawing.Point(485, 175);
            this.pointInDeLabel5.Name = "pointInDeLabel5";
            this.pointInDeLabel5.Size = new System.Drawing.Size(46, 15);
            this.pointInDeLabel5.TabIndex = 20;
            this.pointInDeLabel5.Text = "입니다.";
            // 
            // pointInDeText3
            // 
            this.pointInDeText3.Enabled = false;
            this.pointInDeText3.Location = new System.Drawing.Point(370, 170);
            this.pointInDeText3.Name = "pointInDeText3";
            this.pointInDeText3.PlaceholderText = "증가값 50";
            this.pointInDeText3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointInDeText3.Size = new System.Drawing.Size(64, 23);
            this.pointInDeText3.TabIndex = 19;
            this.pointInDeText3.TabStop = false;
            this.pointInDeText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointInDeLabel2
            // 
            this.pointInDeLabel2.AutoSize = true;
            this.pointInDeLabel2.Location = new System.Drawing.Point(293, 175);
            this.pointInDeLabel2.Name = "pointInDeLabel2";
            this.pointInDeLabel2.Size = new System.Drawing.Size(59, 15);
            this.pointInDeLabel2.TabIndex = 18;
            this.pointInDeLabel2.Text = "로 바뀌면";
            // 
            // pointInDeText2
            // 
            this.pointInDeText2.Location = new System.Drawing.Point(187, 170);
            this.pointInDeText2.Name = "pointInDeText2";
            this.pointInDeText2.PlaceholderText = "변경값 150";
            this.pointInDeText2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointInDeText2.Size = new System.Drawing.Size(100, 23);
            this.pointInDeText2.TabIndex = 17;
            this.pointInDeText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointInDeText2.TextChanged += new System.EventHandler(this.pointInDeTextChanged);
            this.pointInDeText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // pointInDeLabel1
            // 
            this.pointInDeLabel1.AutoSize = true;
            this.pointInDeLabel1.Location = new System.Drawing.Point(131, 175);
            this.pointInDeLabel1.Name = "pointInDeLabel1";
            this.pointInDeLabel1.Size = new System.Drawing.Size(39, 15);
            this.pointInDeLabel1.TabIndex = 16;
            this.pointInDeLabel1.Text = "이(가)";
            // 
            // pointInDeText1
            // 
            this.pointInDeText1.Location = new System.Drawing.Point(25, 170);
            this.pointInDeText1.Name = "pointInDeText1";
            this.pointInDeText1.PlaceholderText = "기준값 100 ";
            this.pointInDeText1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointInDeText1.Size = new System.Drawing.Size(100, 23);
            this.pointInDeText1.TabIndex = 15;
            this.pointInDeText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointInDeText1.TextChanged += new System.EventHandler(this.pointInDeTextChanged);
            this.pointInDeText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // pointInDeTitle
            // 
            this.pointInDeTitle.AutoSize = true;
            this.pointInDeTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointInDeTitle.Location = new System.Drawing.Point(25, 149);
            this.pointInDeTitle.Name = "pointInDeTitle";
            this.pointInDeTitle.Size = new System.Drawing.Size(363, 15);
            this.pointInDeTitle.TabIndex = 14;
            this.pointInDeTitle.Text = "기준값이 변경값으로 변화시 얼만큼 증가/감소 했는지 계산합니다.";
            // 
            // pointInDiRatioLabel4
            // 
            this.pointInDiRatioLabel4.AutoSize = true;
            this.pointInDiRatioLabel4.Location = new System.Drawing.Point(476, 242);
            this.pointInDiRatioLabel4.Name = "pointInDiRatioLabel4";
            this.pointInDiRatioLabel4.Size = new System.Drawing.Size(46, 15);
            this.pointInDiRatioLabel4.TabIndex = 27;
            this.pointInDiRatioLabel4.Text = "입니다.";
            // 
            // pointInDiRatioText3
            // 
            this.pointInDiRatioText3.Enabled = false;
            this.pointInDiRatioText3.Location = new System.Drawing.Point(370, 237);
            this.pointInDiRatioText3.Name = "pointInDiRatioText3";
            this.pointInDiRatioText3.PlaceholderText = "변경값 120";
            this.pointInDiRatioText3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointInDiRatioText3.Size = new System.Drawing.Size(100, 23);
            this.pointInDiRatioText3.TabIndex = 26;
            this.pointInDiRatioText3.TabStop = false;
            this.pointInDiRatioText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointInDiRatioLabel2
            // 
            this.pointInDiRatioLabel2.AutoSize = true;
            this.pointInDiRatioLabel2.Location = new System.Drawing.Point(258, 242);
            this.pointInDiRatioLabel2.Name = "pointInDiRatioLabel2";
            this.pointInDiRatioLabel2.Size = new System.Drawing.Size(17, 15);
            this.pointInDiRatioLabel2.TabIndex = 25;
            this.pointInDiRatioLabel2.Text = "%";
            // 
            // pointInDiRatioText2
            // 
            this.pointInDiRatioText2.Location = new System.Drawing.Point(187, 237);
            this.pointInDiRatioText2.Name = "pointInDiRatioText2";
            this.pointInDiRatioText2.PlaceholderText = "비율값 20";
            this.pointInDiRatioText2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointInDiRatioText2.Size = new System.Drawing.Size(70, 23);
            this.pointInDiRatioText2.TabIndex = 24;
            this.pointInDiRatioText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointInDiRatioText2.TextChanged += new System.EventHandler(this.pointInDiRatioTextChanged);
            this.pointInDiRatioText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // pointInDiRatioLabel1
            // 
            this.pointInDiRatioLabel1.AutoSize = true;
            this.pointInDiRatioLabel1.Location = new System.Drawing.Point(131, 242);
            this.pointInDiRatioLabel1.Name = "pointInDiRatioLabel1";
            this.pointInDiRatioLabel1.Size = new System.Drawing.Size(39, 15);
            this.pointInDiRatioLabel1.TabIndex = 23;
            this.pointInDiRatioLabel1.Text = "이(가)";
            // 
            // pointInDiRatioText1
            // 
            this.pointInDiRatioText1.Location = new System.Drawing.Point(25, 237);
            this.pointInDiRatioText1.Name = "pointInDiRatioText1";
            this.pointInDiRatioText1.PlaceholderText = "기준값 100 ";
            this.pointInDiRatioText1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pointInDiRatioText1.Size = new System.Drawing.Size(100, 23);
            this.pointInDiRatioText1.TabIndex = 22;
            this.pointInDiRatioText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointInDiRatioText1.TextChanged += new System.EventHandler(this.pointInDiRatioTextChanged);
            this.pointInDiRatioText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // pointInDiRatioTitle
            // 
            this.pointInDiRatioTitle.AutoSize = true;
            this.pointInDiRatioTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointInDiRatioTitle.Location = new System.Drawing.Point(25, 216);
            this.pointInDiRatioTitle.Name = "pointInDiRatioTitle";
            this.pointInDiRatioTitle.Size = new System.Drawing.Size(311, 15);
            this.pointInDiRatioTitle.TabIndex = 21;
            this.pointInDiRatioTitle.Text = "기준값에서 일정 비율로 증가/감소한 결과를 계산합니다.";
            // 
            // pointInDiRatioLabel3
            // 
            this.pointInDiRatioLabel3.AutoSize = true;
            this.pointInDiRatioLabel3.Location = new System.Drawing.Point(331, 242);
            this.pointInDiRatioLabel3.Name = "pointInDiRatioLabel3";
            this.pointInDiRatioLabel3.Size = new System.Drawing.Size(33, 15);
            this.pointInDiRatioLabel3.TabIndex = 29;
            this.pointInDiRatioLabel3.Text = "% 는";
            // 
            // pointInDiRatioCheck
            // 
            this.pointInDiRatioCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pointInDiRatioCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pointInDiRatioCheck.FormattingEnabled = true;
            this.pointInDiRatioCheck.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pointInDiRatioCheck.Items.AddRange(new object[] {
            "증가",
            "감소"});
            this.pointInDiRatioCheck.Location = new System.Drawing.Point(274, 237);
            this.pointInDiRatioCheck.Name = "pointInDiRatioCheck";
            this.pointInDiRatioCheck.Size = new System.Drawing.Size(52, 23);
            this.pointInDiRatioCheck.TabIndex = 30;
            this.pointInDiRatioCheck.TextChanged += new System.EventHandler(this.pointInDiRatioComboChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(25, 280);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 31;
            this.resetButton.Text = "초기화";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_click);
            // 
            // fixCheckBox
            // 
            this.fixCheckBox.AutoSize = true;
            this.fixCheckBox.Location = new System.Drawing.Point(423, 280);
            this.fixCheckBox.Name = "fixCheckBox";
            this.fixCheckBox.Size = new System.Drawing.Size(106, 19);
            this.fixCheckBox.TabIndex = 32;
            this.fixCheckBox.Text = "항상 위로 표시";
            this.fixCheckBox.UseVisualStyleBackColor = true;
            this.fixCheckBox.CheckedChanged += new System.EventHandler(this.fixCheckBox_CheckedChanged);
            // 
            // pointInDeLabel3
            // 
            this.pointInDeLabel3.AutoSize = true;
            this.pointInDeLabel3.ForeColor = System.Drawing.Color.Black;
            this.pointInDeLabel3.Location = new System.Drawing.Point(438, 175);
            this.pointInDeLabel3.Name = "pointInDeLabel3";
            this.pointInDeLabel3.Size = new System.Drawing.Size(17, 15);
            this.pointInDeLabel3.TabIndex = 33;
            this.pointInDeLabel3.Text = "%";
            // 
            // pointInDeLabel4
            // 
            this.pointInDeLabel4.AutoSize = true;
            this.pointInDeLabel4.Location = new System.Drawing.Point(458, 175);
            this.pointInDeLabel4.Name = "pointInDeLabel4";
            this.pointInDeLabel4.Size = new System.Drawing.Size(0, 15);
            this.pointInDeLabel4.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(541, 314);
            this.Controls.Add(this.pointInDeLabel4);
            this.Controls.Add(this.pointInDeLabel3);
            this.Controls.Add(this.fixCheckBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pointInDiRatioCheck);
            this.Controls.Add(this.pointInDiRatioLabel3);
            this.Controls.Add(this.pointInDiRatioLabel4);
            this.Controls.Add(this.pointInDiRatioText3);
            this.Controls.Add(this.pointInDiRatioLabel2);
            this.Controls.Add(this.pointInDiRatioText2);
            this.Controls.Add(this.pointInDiRatioLabel1);
            this.Controls.Add(this.pointInDiRatioText1);
            this.Controls.Add(this.pointInDiRatioTitle);
            this.Controls.Add(this.pointInDeLabel5);
            this.Controls.Add(this.pointInDeText3);
            this.Controls.Add(this.pointInDeLabel2);
            this.Controls.Add(this.pointInDeText2);
            this.Controls.Add(this.pointInDeLabel1);
            this.Controls.Add(this.pointInDeText1);
            this.Controls.Add(this.pointInDeTitle);
            this.Controls.Add(this.totalValuesLabel3);
            this.Controls.Add(this.totalValuesText3);
            this.Controls.Add(this.totalValuesLabel2);
            this.Controls.Add(this.totalValuesText2);
            this.Controls.Add(this.totalValuesLabel1);
            this.Controls.Add(this.totalValuesText1);
            this.Controls.Add(this.totalValuesTitle);
            this.Controls.Add(this.totalRatioLabel3);
            this.Controls.Add(this.totalRatioText3);
            this.Controls.Add(this.totalRatioLabel2);
            this.Controls.Add(this.totalRatioText2);
            this.Controls.Add(this.totalRatioLabel1);
            this.Controls.Add(this.totalRatioText1);
            this.Controls.Add(this.totalRatioTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "퍼센트 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalRatioTitle;
        private TextBox totalRatioText1;
        private Label totalRatioLabel1;
        private TextBox totalRatioText2;
        private Label totalRatioLabel2;
        private TextBox totalRatioText3;
        private Label totalRatioLabel3;
        private Label totalValuesLabel3;
        private TextBox totalValuesText3;
        private Label totalValuesLabel2;
        private TextBox totalValuesText2;
        private Label totalValuesLabel1;
        private TextBox totalValuesText1;
        private Label totalValuesTitle;
        private Label pointInDeLabel5;
        private TextBox pointInDeText3;
        private Label pointInDeLabel2;
        private TextBox pointInDeText2;
        private Label pointInDeLabel1;
        private TextBox pointInDeText1;
        private Label pointInDeTitle;
        private Label pointInDiRatioLabel4;
        private TextBox pointInDiRatioText3;
        private Label pointInDiRatioLabel2;
        private TextBox pointInDiRatioText2;
        private Label pointInDiRatioLabel1;
        private TextBox pointInDiRatioText1;
        private Label pointInDiRatioTitle;
        private Label pointInDiRatioLabel3;
        private ComboBox pointInDiRatioCheck;
        private Button resetButton;
        private CheckBox fixCheckBox;
        private Label pointInDeLabel3;
        private Label pointInDeLabel4;
    }
}
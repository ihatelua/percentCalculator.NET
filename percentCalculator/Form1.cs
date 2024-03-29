namespace percentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pointInDiRatioCheck.SelectedIndex = 0;
            multiLang.SelectedIndex = 0;
            this.ActiveControl = resetButton;


            multiLang.Visible = false;  // 미구현
        }

        // 초기화 버튼 클릭
        private void resetButton_click(object sender, EventArgs e)
        {
            // 모든 텍스트박스 값 지우기
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox != null) textBox.Text = string.Empty;
                }
            }

            // 결과값은 한번더 지워준다.
            totalRatioText3.Text = string.Empty;
            totalValuesText3.Text = string.Empty;
            pointInDeText3.Text = string.Empty;
            pointInDiRatioText3.Text = string.Empty;

            // 증가/감소 라벨값 삭제 - v1.1.0 fixed
            pointInDeLabel4.Text = string.Empty;

            pointInDiRatioCheck.SelectedIndex = 0;
        }

        // 항상 위로 표시 이벤트
        private void fixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        // 숫자포맷 이벤트
        private void numberFormatCheckChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                // 모든 텍스트박스 숫자포맷 바꾸기
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        if (// 결과값은 숫자포맷을 적용하지않는다.
                            !control.Name.Equals("totalRatioText3") &&
                            !control.Name.Equals("totalValuesText3") &&
                            !control.Name.Equals("pointInDeText3") &&
                            !control.Name.Equals("pointInDiRatioText3") &&

                            // 퍼센트는 숫자포맷을 적용하지않는다. - 숫자포맷 체크를 설정했을때 % 부분도 숫자포맷이 적용되는 이슈 v1.1.2 fixed
                            !control.Name.Equals("totalRatioText2") &&
                            !control.Name.Equals("pointInDiRatioText2"))
                        {
                            TextBox textBox = (TextBox)control;
                            double convertNum = 0;
                            double.TryParse(textBox.Text, out convertNum);
                            if (textBox != null && convertNum != 0) textBox.Text = string.Format("{0:#,##0}", convertNum);
                        }
                    }
                }
            }
            else
            {
                // 모든 텍스트박스 숫자포맷 바꾸기
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        if (// 결과값은 숫자포맷을 적용하지않는다.
                            !control.Name.Equals("totalRatioText3") &&
                            !control.Name.Equals("totalValuesText3") &&
                            !control.Name.Equals("pointInDeText3") &&
                            !control.Name.Equals("pointInDiRatioText3") &&

                            // 퍼센트는 숫자포맷을 적용하지않는다. - 숫자포맷 체크를 설정했을때 % 부분도 숫자포맷이 적용되는 이슈 v1.1.2 fixed
                            !control.Name.Equals("totalRatioText2") &&
                            !control.Name.Equals("pointInDiRatioText2"))
                        {
                            TextBox textBox = (TextBox)control;
                            double convertNum = 0;
                            double.TryParse(textBox.Text, out convertNum);
                            if (textBox != null && convertNum != 0) textBox.Text = string.Format("{0:0} ", convertNum);
                        }
                    }
                }
            }
            
        }

        // 다국어 이벤트
        private void multiLangChanged(object sender, EventArgs e)
        {

        }

        // 숫자만 입력받기
        private void onlyNumber(object sender, KeyPressEventArgs e)
        {
            // 숫자와 '.' 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // 오직 '.' 1개만 허용
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // 전체값 일정비율 계산 이벤트
        private void totalRatioTextChanged(object sender, EventArgs e)
        {
            // 값 가져오기
            double result = 0;
            double totalRatioText1_value = 0;
            double totalRatioText2_value = 0;

            if ((sender as TextBox).Text != "" && totalRatioText1.Text != "" && totalRatioText2.Text != "") // 값이 없을때 결과값이 없어져야 하는데 '0.00' 으로 적용되는 이슈~~ - v1.1.2 fixed
            {
                if ((sender as TextBox).Name == "totalRatioText1")
                {
                    double.TryParse((sender as TextBox).Text.Replace(",", ""), out totalRatioText1_value);
                    double.TryParse(totalRatioText2.Text, out totalRatioText2_value);
                }
                else
                {
                    double.TryParse(totalRatioText1.Text, out totalRatioText1_value);
                    double.TryParse((sender as TextBox).Text, out totalRatioText2_value);
                }

                // 결과계산
                double divCal = totalRatioText2_value / 100;
                if (!double.IsNaN(divCal)) // 널 체크
                {
                    if (double.IsInfinity(divCal)) // 무한 체크
                    {
                        result = 0;
                    }
                    else
                    {
                        result = totalRatioText1_value * divCal;
                    }
                }
                else
                {
                    result = 0;
                }

                // 출력
                string format = "";
                if (numberFormatCheck.Checked)  // 숫자포맷 적용시
                {
                    format = string.Format("{0:#,##0.00} ", result);
                }
                else
                {
                    format = string.Format("{0:0.00} ", result);
                }

                totalRatioText3.Text = format;
            }
            else
            {
                totalRatioText3.Text = string.Empty;
            }
            
        }

        // 전체값 일정값 비율 계산 이벤트
        private void totalValuesTextChanged(object sender, EventArgs e)
        {
            // 값 가져오기
            double result = 0;
            double totalValuesText1_value = 0;
            double totalValuesText2_value = 0;

            if ((sender as TextBox).Text != "" && totalValuesText1.Text != "" && totalValuesText2.Text != "") // 값이 없을때 결과값이 없어져야 하는데 '0.00' 으로 적용되는 이슈~~ - v1.1.2 fixed
            {
                if ((sender as TextBox).Name == "totalValuesText1")
                {
                    double.TryParse((sender as TextBox).Text, out totalValuesText1_value);
                    double.TryParse(totalValuesText2.Text, out totalValuesText2_value);
                }
                else
                {
                    double.TryParse(totalValuesText1.Text, out totalValuesText1_value);
                    double.TryParse((sender as TextBox).Text, out totalValuesText2_value);
                }

                // 결과계산
                double divCal = totalValuesText2_value / totalValuesText1_value;
                if (!double.IsNaN(divCal)) // 널 체크
                {
                    if (double.IsInfinity(divCal)) // 무한 체크
                    {
                        result = 0;
                    }
                    else
                    {
                        result = 100 * divCal;
                    }
                }
                else
                {
                    result = 0;
                }

                // 출력
                string format = string.Format("{0:0.00} ", result);
                totalValuesText3.Text = format;
            }
            else
            {
                totalValuesText3.Text = string.Empty;
            }
            
        }


        // 기준값 얼마나 증가/감소했는지 계산 이벤트
        private void pointInDeTextChanged(object sender, EventArgs e)
        {
            bool labelCheck = true;

            // 값 가져오기
            double result = 0;
            double pointInDeText1_value = 0;
            double pointInDeText2_value = 0;

            if ((sender as TextBox).Text != "" && pointInDeText1.Text != "" && pointInDeText2.Text != "")   // 값이 없을때 결과값이 없어져야 하는데 '0.00' 으로 적용되는 이슈~~ - v1.1.2 fixed
            {
                if ((sender as TextBox).Name == "pointInDeText1")
                {
                    double.TryParse((sender as TextBox).Text, out pointInDeText1_value);
                    double.TryParse(pointInDeText2.Text, out pointInDeText2_value);
                    if ((sender as TextBox).Text.Equals("") || pointInDeText2.Text.Equals(""))
                    {
                        labelCheck = false;
                    }
                }
                else
                {
                    double.TryParse(pointInDeText1.Text, out pointInDeText1_value);
                    double.TryParse((sender as TextBox).Text, out pointInDeText2_value);
                    if (pointInDeText1.Text.Equals("") || (sender as TextBox).Text.Equals(""))
                    {
                        labelCheck = false;
                    }
                }

                // 결과계산
                // 빈값일때 증가/감소 라벨 지우기
                if (pointInDeText1_value == 0 || pointInDeText2_value == 0)
                {
                    pointInDeLabel4.Text = string.Empty;
                }

                double divCal = ((pointInDeText2_value - pointInDeText1_value) / pointInDeText1_value);
                if (!double.IsNaN(divCal)) // 널 체크
                {
                    if (double.IsInfinity(divCal)) // 무한 체크
                    {
                        result = 0;
                    }
                    else
                    {
                        result = divCal * 100;
                    }
                }
                else
                {
                    result = 0;
                }

                // 출력
                if (labelCheck && result != 0) // 값을 '0'으로 넣었을 때도 증가/감소 라벨이 보이지않도록 수정 - v1.1.1 fixed
                {
                    if (result < 0)
                    {
                        pointInDeLabel4.Text = "감소";
                        pointInDeLabel4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f58222");
                    }
                    else
                    {
                        pointInDeLabel4.Text = "증가";
                        pointInDeLabel4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f58222");
                    }
                }
                else
                {
                    pointInDeLabel4.Text = string.Empty;
                }

                string format = string.Format("{0:0.00} ", Math.Abs(result));
                pointInDeText3.Text = format;
            }
            else
            {
                pointInDeText3.Text = string.Empty;
                pointInDeLabel4.Text = string.Empty;
            }

            
        }


        // 기준값 일정비율 계산 이벤트
        private void pointInDiRatioTextChanged(object sender, EventArgs e)
        {
            // 값 가져오기
            double result = 0;
            double pointInDiRatioText1_value = 0;
            double pointInDiRatioText2_value = 0;
            int pointInDiRatioCheck_value = 0;

            if ((sender as TextBox).Text != "" && pointInDiRatioText1.Text != "" && pointInDiRatioText2.Text != "") // 값이 없을때 결과값이 없어져야 하는데 '0.00' 으로 적용되는 이슈~~ - v1.1.2 fixed
            {
                if ((sender as TextBox).Name == "pointInDiRatioText1")
                {
                    double.TryParse((sender as TextBox).Text, out pointInDiRatioText1_value);
                    double.TryParse(pointInDiRatioText2.Text, out pointInDiRatioText2_value);

                    String selectText = pointInDiRatioCheck.SelectedItem.ToString();
                    if (selectText.Equals("증가"))
                    {
                        pointInDiRatioCheck_value = 1;
                    }
                    else
                    {
                        pointInDiRatioCheck_value = -1;
                    }
                }
                else
                {
                    double.TryParse(pointInDiRatioText1.Text, out pointInDiRatioText1_value);
                    double.TryParse((sender as TextBox).Text, out pointInDiRatioText2_value);

                    String selectText = pointInDiRatioCheck.SelectedItem.ToString();
                    if (selectText.Equals("증가"))
                    {
                        pointInDiRatioCheck_value = 1;
                    }
                    else
                    {
                        pointInDiRatioCheck_value = -1;
                    }
                }


                // 결과계산
                double divCal = pointInDiRatioText1_value * (pointInDiRatioText2_value / 100);
                if (!double.IsNaN(divCal)) // 널 체크
                {
                    if (double.IsInfinity(divCal)) // 무한 체크
                    {
                        result = 0;
                    }
                    else
                    {
                        result = pointInDiRatioText1_value + (divCal * pointInDiRatioCheck_value);
                    }
                }
                else
                {
                    result = 0;
                }

                // 출력
                string format = "";
                if (numberFormatCheck.Checked)
                {
                    format = string.Format("{0:#,##0.00} ", Math.Abs(result));
                }
                else
                {
                    format = string.Format("{0:0.00} ", Math.Abs(result));
                }
                pointInDiRatioText3.Text = format;
            }
            else
            {
                pointInDiRatioText3.Text = string.Empty;
            }
            
        }


        private void pointInDiRatioComboChanged(object sender, EventArgs e)
        {
            // 값 가져오기
            double result = 0;
            double pointInDiRatioText1_value = 0;
            double pointInDiRatioText2_value = 0;
            int pointInDiRatioCheck_value = 0;

            if (pointInDiRatioText1.Text != "" && pointInDiRatioText2.Text != "")    // 값이 없을때 결과값이 0.00 으로 적용되는 이슈 - v1.1.2 fixed
            {
                double.TryParse(pointInDiRatioText1.Text, out pointInDiRatioText1_value);
                double.TryParse(pointInDiRatioText2.Text, out pointInDiRatioText2_value);
                String selectText = (sender as ComboBox).SelectedItem.ToString();
                if (selectText.Equals("증가"))
                {
                    pointInDiRatioCheck_value = 1;
                }
                else
                {
                    pointInDiRatioCheck_value = -1;
                }

                // 결과계산
                double divCal = pointInDiRatioText1_value * (pointInDiRatioText2_value / 100);
                if (!double.IsNaN(divCal)) // 널 체크
                {
                    if (double.IsInfinity(divCal)) // 무한 체크
                    {
                        result = 0;
                    }
                    else
                    {
                        result = pointInDiRatioText1_value + (divCal * pointInDiRatioCheck_value);
                    }
                }
                else
                {
                    result = 0;
                }

                // 출력
                string format = "";
                if (numberFormatCheck.Checked)
                {
                    format = string.Format("{0:#,##0.00} ", Math.Abs(result));
                }
                else
                {
                    format = string.Format("{0:0.00} ", Math.Abs(result));
                }
                pointInDiRatioText3.Text = format;
            }
            else
            {
                pointInDiRatioText3.Text = string.Empty;
            }
        }

        private void focusLeave(object sender, EventArgs e)
        {
            if (numberFormatCheck.Checked)
            {
                double convertNum = 0;
                double.TryParse((sender as TextBox).Text.Replace(",", ""), out convertNum);
                if(convertNum != 0)
                {
                    (sender as TextBox).Text = string.Format("{0:#,##0}", convertNum);
                }
            }
        }

        // 폼이나 라벨을 클릭할때
        private void form1_click(object sender, EventArgs e)
        {
            this.ActiveControl = totalRatioTitle;  // 포커스를 해제시킨다.
        }
    }

    
}
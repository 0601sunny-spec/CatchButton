namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 초기 상태 저장
            initialSize = target.Size;
            initialFont = target.Font;
        }

        private void target_MouseEnter(object sender, EventArgs e)
        {
            // 놓친 횟수 증가 및 게임오버 검사
            misses++;
            if (misses >= 20)
            {
                MessageBox.Show("Game Over");
                // 모든 버튼 비활성화
                foreach (Control c in this.Controls)
                {
                    if (c is Button b)
                        b.Enabled = false;
                }
                // 재시작 버튼만 보이게 하고 활성화
                restartButton.Visible = true;
                restartButton.Enabled = true;

                this.Text = $"Game Over - 점수: {score}";
                return;
            }

            // 마우스가 버튼에 진입하면 도망간 것으로 간주하여 점수 감점
            score -= 10;
            if (score < 0) score = 0;

            // 버튼이 폼 밖으로 안 나가도록 크기 고려하고 위치를 무작위로 변경
            int maxX = Math.Max(0, this.ClientSize.Width - target.Width);
            int maxY = Math.Max(0, this.ClientSize.Height - target.Height);

            int nextX = rd.Next(0, maxX + 1);
            int nextY = rd.Next(0, maxY + 1);

            target.Location = new Point(nextX, nextY);

            // 점수를 폼 제목에 표시
            this.Text = $"점수: {score}";
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            // 게임 초기화
            score = 0;
            misses = 0;

            // 버튼 크기 및 글꼴 초기화
            target.Size = initialSize;
            target.Font = initialFont;

            // 버튼 위치를 중앙으로 재배치
            target.Location = new Point((this.ClientSize.Width - target.Width) / 2,
                                        (this.ClientSize.Height - target.Height) / 2);

            // 버튼 활성화 및 재시작 버튼 숨김
            target.Enabled = true;
            restartButton.Visible = false;
            restartButton.Enabled = false;

            this.Text = $"점수: {score}";
        }

        private void target_MouseClick(object sender, MouseEventArgs e)
        {
            // 클릭 성공: 점수 추가 및 버튼 크기 10% 축소
            score += 100;

            // 축하 메시지 표시
            MessageBox.Show("축하합니다!");

            // 현재 크기에서 10% 축소 (최소 크기 방지)
            int newWidth = Math.Max(30, (int)(target.Width * 0.9));
            int newHeight = Math.Max(20, (int)(target.Height * 0.9));
            target.Size = new Size(newWidth, newHeight);

            // 글씨 크기도 10% 축소하여 텍스트가 잘리지 않도록 함 (최소 폰트 사이즈 보장)
            float newFontSize = Math.Max(8f, target.Font.Size * 0.9f);
            target.Font = new Font(target.Font.FontFamily, newFontSize, target.Font.Style);

            // 축소 후 버튼이 폼 영역을 벗어나지 않도록 위치 보정
            int maxX = Math.Max(0, this.ClientSize.Width - target.Width);
            int maxY = Math.Max(0, this.ClientSize.Height - target.Height);
            int clampedX = Math.Min(Math.Max(0, target.Location.X), maxX);
            int clampedY = Math.Min(Math.Max(0, target.Location.Y), maxY);
            target.Location = new Point(clampedX, clampedY);

            // 점수를 폼 제목에 표시
            this.Text = $"점수: {score}";
        }

        private void target_Click(object sender, EventArgs e)
        {
            // (사용하지 않음) 클릭 이벤트는 MouseClick을 사용함
        }

        Random rd = new Random();
        int score = 0;
        int misses = 0;
        Size initialSize;
        Font initialFont;

    }
}

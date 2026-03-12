namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void target_MouseEnter(object sender, EventArgs e)
        {
            Random rd = new Random();

            // 버튼이 폼 밖으로 안 나가도록 크기 고려
            int maxX = this.ClientSize.Width - target.Width;
            int maxY = this.ClientSize.Height - target.Height;

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            target.Location = new Point(nextX, nextY);

            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }

        private void target_MouseClick(object sender, MouseEventArgs e)
        {
            // 디자이너에서 참조하는 이벤트 처리기 구현(빈 구현으로 디자이너 로드 오류 방지)
        }

        private void target_Click(object sender, EventArgs e)
        {
            MessageBox.Show("축하합니다!");
        }
    }
}

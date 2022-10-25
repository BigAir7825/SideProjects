namespace TestReview
{
    public partial class TestReview : Form
    {
        public List<string> questions;
        public List<string> answers;
        public int listIndex;
        public TestReview()
        {
            InitializeComponent();
            FileWork makeLists = new FileWork("C:\\Users\\Will\\source\\repos\\TestReview\\TestReview\\questions.txt");
            questions = makeLists.questions;
            answers = makeLists.answers;

            answerButton.Enabled = false;
            questionButton.Enabled = false;
            questionBox.Enabled = false;
            answerBox.Enabled = false;
            hardGroup.Enabled = false;
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
                answerBox.Clear();
                if (answerButton.Enabled == false)
                    answerButton.Enabled = true;

                Random random = new Random();
                listIndex = random.Next(questions.Count);
                questionBox.Text = questions[listIndex];
        }

        private void questionsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (questionButton.Enabled == false)
            {
                questionButton.Enabled = true;
                questionBox.Enabled = true;
                answerBox.Enabled = true;
                hardGroup.Enabled = true;
            }
        }

        private void newQuestionsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (questionButton.Enabled == false)
            {
                questionButton.Enabled = true;
                questionBox.Enabled = true;
                answerBox.Enabled = true;
                hardGroup.Enabled = true;
            }
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            answerButton.Enabled = false;

            answerBox.Text = answers[listIndex];
        }

        private void YesRadio_CheckedChanged(object sender, EventArgs e)
        {
            FileWork output = new FileWork("C:\\Users\\Will\\source\\repos\\TestReview\\TestReview\\newQuestions.txt");
            output.WriteToFile("C:\\Users\\Will\\source\\repos\\TestReview\\TestReview\\newQuestions.txt", questionBox.Text, answerBox.Text);
            NoRadio.Checked = false;
        }

        private void NoRadio_CheckedChanged(object sender, EventArgs e)
        {
            YesRadio.Checked = false;
        }
    }
}
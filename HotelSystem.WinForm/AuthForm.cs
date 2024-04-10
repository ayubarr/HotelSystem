namespace HotelSystem.WinForm
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
         //   if(CheckLoginAndPassword())

        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            richTextBox_Login.BackColor = SystemColors.Window;
            richTextBox_Password.BackColor = SystemColors.Window;
            label_ErrorLogin.Visible = false;
            label_ErrorPassword.Visible = false;
        }

        private void AuthForm_Click(object sender, EventArgs e)
        {
            AuthForm_Load(sender, e);
        }



        private bool CheckLoginAndPassword()
        {
            if (string.IsNullOrEmpty(richTextBox_Login.Text))
            {
                richTextBox_Login.BackColor = Color.FromArgb(255, 192, 192);
                label_ErrorLogin.Visible = true;
                return false;

            }
            if (string.IsNullOrEmpty(richTextBox_Password.Text))
            {
                richTextBox_Password.BackColor = Color.FromArgb(255, 192, 192);
                label_ErrorPassword.Visible = true;
                return false;
            }
            return true;
        }

        #region Registration
        private bool registrationFormOpened = false;
        private RegistrationForm registrationForm;
        private void button_GoToRegistration_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm();
        }
    
        // �����, ������� ����� ��������� ����� �����������
        private void OpenRegistrationForm()
        {
            // ���� ����� ����������� ��� �������, �� ������ ������ �� ��������
            if (registrationFormOpened && registrationForm != null)
            {
                registrationForm.Activate();
            }
            else
            {
                // ����� ������� ����� ��������� ����� ����������� � ��������� ��
                registrationForm = new RegistrationForm();
                registrationForm.Show();
                // ������������� ����, ��� ����� ����������� �������
                registrationFormOpened = true;
            }
        }
        #endregion
    }
}

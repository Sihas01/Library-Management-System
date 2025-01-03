using Library_Management_System.Model;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(null, EventArgs.Empty);
        }

        public void Form1_Load(object sender, EventArgs e) 
        {
            Member member1 = new Member("usero1", "John", "john@gmail.com", "0751171926","1234");
            label1.Text = member1.Name;
            label2.Text = member1.Id;
        }
    }
}

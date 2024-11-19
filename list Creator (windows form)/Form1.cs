using System.Windows.Forms;

namespace list_Creator__windows_form_
{
    public partial class Form1 : Form
    {
        private List<Person> people;
        int counter_i = 0;
        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (name_tb.Text != "" && surname_tb.Text != "" && age_tb.Text != "" && cartificate_cb.SelectedItem != "" && (gender_male_rb.Checked || gender_famale_rb.Checked) && address_rtb.Text != "")
            {
                string counter = counter_i.ToString();
                string name = name_tb.Text;
                string surname = surname_tb.Text;
                string age = age_tb.Text;
                string cartificate = (string)cartificate_cb.SelectedItem;
                string address = address_rtb.Text;
                DateTime birthday = birthday_dtp.Value;
                string dateTimeString = birthday.ToString("yyyy-MM-dd HH:mm:ss");
                string gender;
                if (gender_male_rb.Checked)
                {
                    gender = "male";
                }
                else
                {
                    gender = "famale";
                }
                counter_i++;
                counter = counter_i.ToString();
                people.Add(new Person { No = counter , name = name, surname = surname, age = age, gender = gender, birthday = dateTimeString, address = address, cartificate = cartificate });
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = people;
            }
        }
        internal class Person
        {
            public string No { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string age { get; set; }
            public string gender { get; set; }
            public string birthday { get; set; }
            public string cartificate { get; set; }
            public string address { get; set; }
        }
    }
}

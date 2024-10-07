namespace EmployeeApplication
{
    public partial class frmEmployeeDataBase : Form
    {
        public frmEmployeeDataBase()
        {
            InitializeComponent();
        }
        public class Employee
        {
            private string EmployeeID;
            private string fname;
            private string lname;
            private string position;

            public Employee()
            {
                EmployeeID = "";
                fname = "";
                lname = "";
                position = "";
            }
            public Employee(string EmployeeID, string fname, string lname, string position)
            {
                this.EmployeeID = EmployeeID;
                this.fname = fname;
                this.lname = lname;
                this.position = position;
            }
            public string employeeID
            {
                get { return EmployeeID; }
                set { EmployeeID = value; }
            }
            public string Fname
            {
                get { return fname; }
                set { fname = value; }
            }
            public string Lname
            {
                get { return lname; }
                set { lname = value; }
            }
            public string Postion
            {
                get { return position; }
                set { position = value; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IDText = textID.Text.Trim(); 
            int employeeID;

            // Validate Employee ID input
            if (!int.TryParse(IDText, out employeeID))
            {
                MessageBox.Show("Invalid Input! Please enter a valid employee ID.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fname = textfname.Text.Trim(); 
            string lname = textlname.Text.Trim(); 
            string position = textPosBox.Text.Trim();

            // Validate First Name input
            if (string.IsNullOrEmpty(fname) || !IsValidInput(fname))
            {
                {
                    MessageBox.Show("Invalid Input! Please enter a valid First Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validate Last Name input
            if (string.IsNullOrEmpty(lname) || !IsValidInput(lname))
            {
                {
                    MessageBox.Show("Invalid Input! Please enter a valid Last Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validate Position input
            if (string.IsNullOrEmpty(position) || !IsValidInput(position))
            {
                {
                    MessageBox.Show("Invalid Input! Please enter a valid Position.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Create Employee object
            Employee employ = new Employee(employeeID.ToString(), fname, lname, position);

            // Add the employee data to the DataGridView
            string[] row = new string[]
            {
                employ.employeeID,
                employ.Fname,
                employ.Lname,
                employ.Postion
            };

            dataGridView1.Rows.Add(row);

            // Clear input fields
            textID.Clear();
            textfname.Clear(); // This was incorrectly named as textlname in the original
            textlname.Clear();
            textPosBox.Clear();
        }

        // Method to validate input to contain only letters
        private bool IsValidInput(string input)
        {
            foreach (char C in input)
            {
                if (!char.IsLetter(C) && !char.IsWhiteSpace(C))
                {
                    return false;
                }
            }
            return true;
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEmployeeDataBase_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns [0].Name="id";
            dataGridView1.Columns[1].Name = "firstName";
            dataGridView1.Columns[2].Name = "lastName";
            dataGridView1.Columns[3].Name = "position";
        }
    }
}

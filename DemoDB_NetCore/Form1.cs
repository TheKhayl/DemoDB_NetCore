using DemoDB_NetCore.Data;
using Microsoft.IdentityModel.Tokens;

namespace DemoDB_NetCore
{
    public partial class Form1 : Form
    {

        private ModelContext _context;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _context = new ModelContext();
        }

        public void LoadData()
        {
            dgvEmployee.DataSource = _context.EmployeeList.ToList();
        }

        bool CheckTextBoxes()
        {
            if (txtboxName.Text.IsNullOrEmpty()
                || txtboxEmail.Text.IsNullOrEmpty()
                || txtboxAddress.Text.IsNullOrEmpty()
                )
            {
                MessageBox.Show(
                    "Name, Email and Address are empty! Please add details to it!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtboxName;
            LoadData();
            dgvEmployee.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            if(dgvEmployee.Rows.Count != 0) { dgvEmployee.CurrentCell = null; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (CheckTextBoxes() == false) { return; }

            Employee employee = new Employee();

            employee.Name = txtboxName.Text;
            employee.Email = txtboxEmail.Text;
            employee.Address = txtboxAddress.Text;

            _context.EmployeeList.Add(employee);
            _context.SaveChanges();
            MessageBox.Show("Employee added successfully!");
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxName.Text = txtboxEmail.Text = txtboxAddress.Text = "";
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow?.DataBoundItem is Employee selectedEmployee)
            {
                txtboxName.Text = selectedEmployee.Name;
                txtboxEmail.Text = selectedEmployee.Email;
                txtboxAddress.Text = selectedEmployee.Address;
            }

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow?.DataBoundItem is Employee selectedEmployee)
            {
                if (CheckTextBoxes() == false) { return; }

                selectedEmployee.Name = txtboxName.Text;
                selectedEmployee.Email = txtboxEmail.Text;
                selectedEmployee.Address = txtboxAddress.Text;

                _context.EmployeeList.Update(selectedEmployee);
                _context.SaveChanges();
                MessageBox.Show($"Employee ID: {selectedEmployee.EmployeeID}\n\nSuccessfully updated!");

                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtboxName.Text = txtboxEmail.Text = txtboxAddress.Text = "";
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow?.DataBoundItem is Employee selectedEmployee)
            {
                _context.EmployeeList.Remove(selectedEmployee);
                _context.SaveChanges();
                MessageBox.Show("Successfully deleted!");

                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtboxName.Text = txtboxEmail.Text = txtboxAddress.Text = "";
                LoadData();
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count == 0) { return; }

            if(dgvEmployee.CurrentRow != null)
            {
                this.ActiveControl = txtboxName;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtboxName.Text = txtboxEmail.Text = txtboxAddress.Text = "";
                dgvEmployee.ClearSelection();
                dgvEmployee.CurrentCell = null;
            } else
            {
                MessageBox.Show(
                    "Please select a record!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            
        }
    }
}

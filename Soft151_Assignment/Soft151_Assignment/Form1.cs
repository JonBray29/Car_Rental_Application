using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Soft151_Assignment
{
    public partial class hireCars : Form
    {
        public static ArrayList companies;
        public static ArrayList companiesFilter;
        public static ArrayList carFilter;

        string file = @"G:\assignmentSoft151\Soft151_Assignment\courseworkInput.Txt";
        public static int selectedCompany;
        public static int selectedCar;
        public hireCars()
        {
            InitializeComponent();
            companies = new ArrayList();
            companiesFilter = new ArrayList();
            carFilter = new ArrayList();
        }
        //Load Arrays when form loads --------------------------------------------------------------------------------------
        private void hireForms_Load(object sender, EventArgs e)
        {
            readFile();
            showCompany(companies);
            showCars();
            this.lstCompanies.SetSelected(0, true);
            if (lstCars.Items.Count > 0)
                this.lstCars.SetSelected(0, true);
            btnSaveCarAdd.Hide();
            btnSaveCarEdit.Hide();
            btnSaveCompanyAdd.Hide();
            btnSaveCompanyEdit.Hide();
        }
        //------------------------------------------------------------------------------------------------------------------

        //Read in file -----------------------------------------------------------------------------------------------------
        public void readFile()
        {

            lstCompanies.Items.Clear();
            lstCars.Items.Clear();

            string compId, compName, compAddress, compPostcode, carId, carMake, carReg, carFuel, carService, carNotes;
            int numberOfCars;

            //Open File
            StreamReader readFile = new StreamReader(file);

            //Read the data
            while(! readFile.EndOfStream)
            {
                //company data
                compId = readFile.ReadLine();
                compName = readFile.ReadLine();
                compAddress = readFile.ReadLine();
                compPostcode = readFile.ReadLine();
                numberOfCars = Convert.ToInt32(readFile.ReadLine());

                //car data
                ArrayList cars = new ArrayList();
                for (int i = 0; i < numberOfCars; i++)
                {
                    carId = readFile.ReadLine();
                    carMake = readFile.ReadLine();
                    carReg = readFile.ReadLine();
                    carFuel = readFile.ReadLine();
                    carService = readFile.ReadLine();
                    carNotes = readFile.ReadLine();

                    //Create car
                    Car newCar = new Car(carId, carMake, carReg, carFuel, carService, carNotes);

                    //Add to Array
                    cars.Add(newCar);
                }

                //Create Company
                Company newCompany = new Company(compId, compName, compAddress, compPostcode, numberOfCars, cars);

                //Add to array
                companies.Add(newCompany);
            }
            readFile.Close();
        }
        // -----------------------------------------------------------------------------------------------------------------
      
        //Set Edit buttons to enable text boxes and have infomation in text boxes ------------------------------------------
        private void enableCompanyEditing()
        {
            if (lstCompanies.SelectedItem != null)
            {
                //Enable textboxes
                txtCompanyIdNumber.Enabled = true;
                txtCompanyName.Enabled = true;
                txtCompanyAddress.Enabled = true;
                txtCompanyPostcode.Enabled = true;

                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                {
                    txtCompanyIdNumber.Text = ((Company)companiesFilter[selectedCompany]).getCompanyIdNumber().ToString();
                    txtCompanyName.Text = ((Company)companiesFilter[selectedCompany]).getCompanyName().ToString();
                    txtCompanyAddress.Text = ((Company)companiesFilter[selectedCompany]).getCompanyAddress().ToString();
                    txtCompanyPostcode.Text = ((Company)companiesFilter[selectedCompany]).getCompanyPostcode().ToString();
                }
                else
                {

                    txtCompanyIdNumber.Text = ((Company)companies[selectedCompany]).getCompanyIdNumber().ToString();
                    txtCompanyName.Text = ((Company)companies[selectedCompany]).getCompanyName().ToString();
                    txtCompanyAddress.Text = ((Company)companies[selectedCompany]).getCompanyAddress().ToString();
                    txtCompanyPostcode.Text = ((Company)companies[selectedCompany]).getCompanyPostcode().ToString();
                }
                btnSaveCompanyEdit.Show();
            }
        }
        private void enableCarEditing()
        {

            if (lstCars.SelectedItem != null)
            {
                //Enable textboxes
                txtCarIdNumber.Enabled = true;
                txtCarMakeAndModel.Enabled = true;
                txtCarRegistration.Enabled = true;
                txtCarFuelType.Enabled = true;
                txtCarLastServiceDate.Enabled = true;
                txtCarComments.Enabled = true;

                Company company;
                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                {
                    company = (Company)companiesFilter[selectedCompany];
                }
                else
                {
                    company = (Company)companies[selectedCompany];
                }

                Car car;
                if (carFilter.Count > 0 && txtSearchCar.Text.Length > 0)
                {
                    car = (Car)carFilter[selectedCar];
                }
                else
                {
                    car = (Car)company.getCars()[selectedCar];
                }

                txtCarIdNumber.Text = car.getTheCarIdNumber();
                txtCarMakeAndModel.Text = car.getTheCarMakeAndModel();
                txtCarRegistration.Text = car.getTheCarRegistration();
                txtCarFuelType.Text = car.getTheCarFuelType();
                txtCarLastServiceDate.Text = car.getTheCarLastServiceDate();
                txtCarComments.Text = car.getTheCarComments();

                btnSaveCarEdit.Show();
            }
        }
        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            //Hide unwanted buttons
            btnSaveCompanyAdd.Hide();
            btnSaveCarAdd.Hide();
            btnSaveCarEdit.Hide();
            btnAddCompany.Hide();
            btnAddCar.Hide();
            btnDeleteCompany.Hide();
            btnDeleteCar.Hide();
            btnEditCar.Hide();
            btnCancelCar.Hide();
            enableCompanyEditing();
        }
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            //Hide unwanted buttons
            btnSaveCarAdd.Hide();
            btnSaveCompanyAdd.Hide();
            btnSaveCompanyEdit.Hide();
            btnAddCompany.Hide();
            btnAddCar.Hide();
            btnDeleteCompany.Hide();
            btnDeleteCar.Hide();
            btnEditCompany.Hide();
            btnCancelCompany.Hide();
            enableCarEditing();
        }
        //------------------------------------------------------------------------------------------------------------------

        //Cancel Editing ---------------------------------------------------------------------------------------------------
        private void cancelCompanyEditing()
        {
            //Clear texboxes and disable
            txtCompanyIdNumber.Enabled = false;
            txtCompanyName.Enabled = false;
            txtCompanyAddress.Enabled = false;
            txtCompanyPostcode.Enabled = false;

            txtCompanyIdNumber.Text = "";
            txtCompanyName.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyPostcode.Text = "";

            btnSaveCompanyAdd.Hide();
            btnSaveCompanyEdit.Hide();
        }
        private void cancelCarEditing()
        {
            //Clear texboxes and disable
            txtCarIdNumber.Enabled = false;
            txtCarMakeAndModel.Enabled = false;
            txtCarRegistration.Enabled = false;
            txtCarFuelType.Enabled = false;
            txtCarLastServiceDate.Enabled = false;
            txtCarComments.Enabled = false;

            txtCarIdNumber.Text = "";
            txtCarMakeAndModel.Text = "";
            txtCarRegistration.Text = "";
            txtCarFuelType.Text = "";
            txtCarLastServiceDate.Text = "";
            txtCarComments.Text = "";

            btnSaveCarAdd.Hide();
            btnSaveCarEdit.Hide();
        }
        private void btnCancelCompany_Click(object sender, EventArgs e)
        {
            //Show wanted buttons
            btnAddCompany.Show();
            btnAddCar.Show();
            btnDeleteCompany.Show();
            btnDeleteCar.Show();
            btnEditCar.Show();
            btnCancelCar.Show();
            cancelCompanyEditing();
        }
        private void btnCancelCar_Click(object sender, EventArgs e)
        {
            //Show wanted buttons
            btnAddCompany.Show();
            btnAddCar.Show();
            btnDeleteCompany.Show();
            btnDeleteCar.Show();
            btnEditCompany.Show();
            btnCancelCompany.Show();
            cancelCarEditing();
        }
        //------------------------------------------------------------------------------------------------------------------

        //Add a new company and car 
        private void enableAddCompany()
        {
            //Enable textboxes
            txtCompanyIdNumber.Enabled = true;
            txtCompanyName.Enabled = true;
            txtCompanyAddress.Enabled = true;
            txtCompanyPostcode.Enabled = true;

            btnSaveCompanyAdd.Show();
        }
        private void enableAddCar()
        {
            //Enable textboxes
            txtCarIdNumber.Enabled = true;
            txtCarMakeAndModel.Enabled = true;
            txtCarRegistration.Enabled = true;
            txtCarFuelType.Enabled = true;
            txtCarLastServiceDate.Enabled = true;
            txtCarComments.Enabled = true;

            btnSaveCarAdd.Show();
        }
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            btnSaveCompanyEdit.Hide();
            enableAddCompany();
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            btnSaveCarEdit.Hide();
            enableAddCar();
        }
        //------------------------------------------------------------------------------------------------------------------

        //Show arrays in listboxes -----------------------------------------------------------------------------------------
        private void showCompany(ArrayList companiesToShow)
        {
            string companyOutput;
            lstCompanies.Items.Clear();
            foreach (Company currentCompany in companiesToShow)
            {
                companyOutput = currentCompany.showCompanyDetails();
                lstCompanies.Items.Add(companyOutput);
            }
        }
        private void showCars()
        {
            if (lstCompanies.SelectedItem != null)
            {
                Company tempCompany;
                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                   tempCompany = (Company)companiesFilter[selectedCompany];
                else
                    tempCompany = (Company)companies[selectedCompany];

                lstCars.Items.Clear();

                if (carFilter.Count > 0 && txtSearchCar.Text.Length > 0)
                {
                    foreach (Car c in carFilter)
                    {
                        lstCars.Items.Add(c.showCarDetails());
                    }
                }
                else
                {
                    foreach (Car c in tempCompany.getCars())
                    {
                        lstCars.Items.Add(c.showCarDetails());
                    }
                }
            }
        }
        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCompany = lstCompanies.SelectedIndex;
            if (lstCompanies.SelectedItem != null)
            {
                showCars();
            }
        }
        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCar = lstCars.SelectedIndex;
        }
        //------------------------------------------------------------------------------------------------------------------

        //Add new company/car ----------------------------------------------------------------------------------------------
        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            string id = txtCompanyIdNumber.Text;
            string name = txtCompanyName.Text;
            string address = txtCompanyAddress.Text;
            string postcode = txtCompanyPostcode.Text;

            //Data Exception
            if (!String.IsNullOrWhiteSpace(id) && !String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(address)
                && !String.IsNullOrWhiteSpace(postcode))
            {
                Company company = new Company(id, name, address, postcode);
                companies.Add(company);
                showCompany(companies);
                txtSearchCompany.Clear();

                btnAddCompany.Show();
                btnAddCar.Show();
                btnDeleteCompany.Show();
                btnDeleteCar.Show();
                btnEditCar.Show();
                btnCancelCar.Show();
                disableCompanyTextBoxes();
            }
            else
            {
                MessageBox.Show("Error: All boxes must have value");
            }
        }
        private void btnSaveCarAdd_Click(object sender, EventArgs e)
        {
            string id = txtCarIdNumber.Text;
            string makeAndModel = txtCarMakeAndModel.Text;
            string registration = txtCarRegistration.Text;
            string fuel = txtCarFuelType.Text;
            string service = txtCarLastServiceDate.Text;
            string comments = txtCarComments.Text;

            //Data Exception
            if (!String.IsNullOrWhiteSpace(id) && !String.IsNullOrWhiteSpace(makeAndModel) &&
                !String.IsNullOrWhiteSpace(registration) && !String.IsNullOrWhiteSpace(fuel) &&
                !String.IsNullOrWhiteSpace(service) && !String.IsNullOrWhiteSpace(comments))
            {
                Company company;
                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                {
                    company = (Company)companiesFilter[selectedCompany];
                }
                else
                {
                    company = (Company)companies[selectedCompany];
                }

                Car car = new Car(id, makeAndModel, registration, fuel, service, comments);

                company.getCars().Add(car);

                showCars();
                showCompany(companies);
                btnAddCompany.Show();
                btnAddCar.Show();
                btnDeleteCompany.Show();
                btnDeleteCar.Show();
                btnEditCompany.Show();
                btnCancelCompany.Show();
                disableCarTextBoxes();
            }
            else
            {
                MessageBox.Show("Error: All boxes must have a value");
            }
        }
        //------------------------------------------------------------------------------------------------------------------

        //Edit company/Car details -----------------------------------------------------------------------------------------
        private void btnSaveCompanyEdit_Click(object sender, EventArgs e)
        {
            //Data Exception
            if (!String.IsNullOrWhiteSpace(txtCompanyIdNumber.Text) && !String.IsNullOrWhiteSpace(txtCompanyName.Text) &&
                !String.IsNullOrWhiteSpace(txtCompanyAddress.Text) && !String.IsNullOrWhiteSpace(txtCompanyPostcode.Text))
            {
                Company company;
                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                {
                    company = (Company)companiesFilter[selectedCompany];
                }
                else
                {
                    company = (Company)companies[selectedCompany];
                }
                company.setCompanyIdNumber(txtCompanyIdNumber.Text);
                company.setCompanyName(txtCompanyName.Text);
                company.setCompanyAddress(txtCompanyAddress.Text);
                company.setCompanyPostcode(txtCompanyPostcode.Text);
                showCompany(companies);

                btnAddCompany.Show();
                btnAddCar.Show();
                btnDeleteCompany.Show();
                btnDeleteCar.Show();
                btnEditCar.Show();
                btnCancelCar.Show();
                disableCompanyTextBoxes();
            }
            else
            {
                MessageBox.Show("Error: All boxes must have a value");
            }
        }
        private void btnSaveCarEdit_Click(object sender, EventArgs e)
        {
            //Data Exception
            if (!String.IsNullOrWhiteSpace(txtCarIdNumber.Text) && !String.IsNullOrWhiteSpace(txtCarMakeAndModel.Text) &&
                !String.IsNullOrWhiteSpace(txtCarRegistration.Text) && !String.IsNullOrWhiteSpace(txtCarFuelType.Text) && 
                !String.IsNullOrWhiteSpace(txtCarLastServiceDate.Text) && !String.IsNullOrWhiteSpace(txtCarComments.Text))
            {
                Company company;
                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                {
                    company = (Company)companiesFilter[selectedCompany];
                }
                else
                {
                    company = (Company)companies[selectedCompany];
                }

                Car car;
                if (carFilter.Count > 0 && txtSearchCar.Text.Length > 0)
                {
                    car = (Car)carFilter[selectedCar];
                }
                else
                {
                    car = (Car)company.getCars()[selectedCar];
                }

                car.setTheCarIdNumber(txtCarIdNumber.Text);
                car.setTheCarMakeAndModel(txtCarMakeAndModel.Text);
                car.setTheCarRegistration(txtCarRegistration.Text);
                car.setTheCarFuelType(txtCarFuelType.Text);
                car.setTheCarLastServiceDate(txtCarLastServiceDate.Text);
                car.setTheCarComments(txtCarComments.Text);
                showCompany(companies);
                showCars();
                btnAddCompany.Show();
                btnAddCar.Show();
                btnDeleteCompany.Show();
                btnDeleteCar.Show();
                btnEditCompany.Show();
                btnCancelCompany.Show();
                disableCarTextBoxes();
                txtSearchCompany.Clear();
                txtSearchCar.Clear();
            }
            else
            {
                MessageBox.Show("Error: All boxes must have a value");
            }
        }
        //------------------------------------------------------------------------------------------------------------------

        //Clear fields on click save ---------------------------------------------------------------------------------------
        private void disableCompanyTextBoxes()
        {
            //Disable and clear textboxes
            btnSaveCompanyEdit.Hide();
            btnSaveCompanyAdd.Hide();

            txtCompanyIdNumber.Enabled = false;
            txtCompanyName.Enabled = false;
            txtCompanyAddress.Enabled = false;
            txtCompanyPostcode.Enabled = false;

            txtCompanyIdNumber.Text = "";
            txtCompanyName.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyPostcode.Text = "";
        }
        private void disableCarTextBoxes()
        {
            //Disable and clear textboxes
            btnSaveCarEdit.Hide();
            btnSaveCarAdd.Hide();

            txtCarIdNumber.Enabled = false;
            txtCarMakeAndModel.Enabled = false;
            txtCarRegistration.Enabled = false;
            txtCarFuelType.Enabled = false;
            txtCarLastServiceDate.Enabled = false;
            txtCarComments.Enabled = false;

            txtCarIdNumber.Text = "";
            txtCarMakeAndModel.Text = "";
            txtCarRegistration.Text = "";
            txtCarFuelType.Text = "";
            txtCarLastServiceDate.Text = "";
            txtCarComments.Text = "";
        }
        //------------------------------------------------------------------------------------------------------------------

        //Delete fields ----------------------------------------------------------------------------------------------------
        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            if (companies.Count > 0)
            {
                Company toDelete;
                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                {
                    toDelete = (Company)companiesFilter[selectedCompany];
                    companiesFilter.Remove(toDelete);
                }
                else
                {
                    toDelete = (Company)companies[selectedCompany];
                }
                companies.Remove(toDelete);
                showCompany(companies);
                showCars();
            }
        }
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (lstCompanies.SelectedItem != null)
            {
                Company company;
                if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
                {
                    company = (Company)companiesFilter[selectedCompany];
                }
                else
                {
                    company = (Company)companies[selectedCompany];
                }

                if (company.getCars().Count > 0)
                {
                    Car toDelete;
                    if (carFilter.Count > 0 && txtSearchCar.Text.Length > 0)
                    {
                        toDelete = (Car)carFilter[selectedCar];
                        carFilter.Remove(toDelete);
                    }
                    else
                    {
                        toDelete = (Car)company.getCars()[selectedCar];
                    }

                    company.getCars().Remove(toDelete);

                    showCars();
                    showCompany(companies);
                    lstCompanies.SetSelected(selectedCompany, true);
                }
            }
        
        }
        //------------------------------------------------------------------------------------------------------------------

        //Search Company/Car -----------------------------------------------------------------------------------------------
        private void searchCompany_TextChanged(object sender, EventArgs e)
        {
            //Find if input text can be found in any of the infomation
            string input = txtSearchCompany.Text.ToLower();
            companiesFilter.Clear();
            foreach (Company company in companies)
            {
                if (company.getCompanyIdNumber().ToLower().Contains(input))
                {
                    companiesFilter.Add(company);
                }
                else if (company.getCompanyName().ToLower().Contains(input))
                {
                    companiesFilter.Add(company);
                }
                else if (company.getCompanyAddress().ToLower().Contains(input))
                {
                    companiesFilter.Add(company);
                }
                else if (company.getCompanyPostcode().ToLower().Contains(input))
                {
                    companiesFilter.Add(company);
                }
            }
            showCompany(companiesFilter);
            showCars();

            if (companiesFilter.Count > 0)
            {
                lstCompanies.SelectedIndex = 0;
            }
        }
        private void txtSearchCar_TextChanged(object sender, EventArgs e)
        {
            //Find if input text can be found in any of the infomation
            string input = txtSearchCar.Text.ToLower();
            Company selected;
            if (companiesFilter.Count > 0 && txtSearchCompany.Text.Length > 0)
            {
                selected = (Company)companiesFilter[selectedCompany];
            }
            else
            {
                selected = (Company)companies[selectedCompany];
            }

            carFilter.Clear();
            foreach (Car car in selected.getCars())
            {
                if (car.getTheCarIdNumber().ToLower().Contains(input))
                {
                    carFilter.Add(car);
                }
                else if (car.getTheCarMakeAndModel().ToLower().Contains(input))
                {
                    carFilter.Add(car);
                }
                else if (car.getTheCarRegistration().ToLower().Contains(input))
                {
                    carFilter.Add(car);
                }
                else if (car.getTheCarFuelType().ToLower().Contains(input))
                {
                    carFilter.Add(car);
                }
                else if (car.getTheCarLastServiceDate().ToLower().Contains(input))
                {
                    carFilter.Add(car);
                }
                else if (car.getTheCarComments().ToLower().Contains(input))
                {
                    carFilter.Add(car);
                }
            }
            showCars();

            if (carFilter.Count > 0)
            {
                lstCars.SelectedIndex = 0;
            }
        }
        //------------------------------------------------------------------------------------------------------------------

        //Write to file ----------------------------------------------------------------------------------------------------
        private static void writeFile(string file)
        {
            StreamWriter sw = new StreamWriter(file);
            foreach (Company company in companies)
            {
                sw.WriteLine(company.getCompanyIdNumber());
                sw.WriteLine(company.getCompanyName());
                sw.WriteLine(company.getCompanyAddress());
                sw.WriteLine(company.getCompanyPostcode());
                sw.WriteLine(company.getNumberOfCars());
                foreach (Car car in company.getCars())
                {
                    sw.WriteLine(car.getTheCarIdNumber());
                    sw.WriteLine(car.getTheCarMakeAndModel());
                    sw.WriteLine(car.getTheCarRegistration());
                    sw.WriteLine(car.getTheCarFuelType());
                    sw.WriteLine(car.getTheCarLastServiceDate());
                    sw.WriteLine(car.getTheCarComments());
                }
            }
            sw.Close();        
        }
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            writeFile(file);
        }
        //------------------------------------------------------------------------------------------------------------------
    }
}

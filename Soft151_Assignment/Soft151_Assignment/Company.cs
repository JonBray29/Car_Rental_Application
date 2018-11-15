using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Soft151_Assignment
{
    class Company
    {
        private string companyIdNumber;
        private string companyName;
        private string companyAddress;
        private string companyPostcode;
        private int numberOfCars
        {
            get
            {
                return cars.Count;
            }
        }
        private ArrayList cars;

        public Company()
        {

        }

        public Company(string theCompanyIdNumber, string theCompanyName, string theCompanyAddress, string theCompanyPostcode)
        {
            companyIdNumber = theCompanyIdNumber;
            companyName = theCompanyName;
            companyAddress = theCompanyAddress;
            companyPostcode = theCompanyPostcode;
            cars = new ArrayList();
        }

        public Company(string theCompanyIdNumber, string theCompanyName, string theCompanyAddress, string theCompanyPostcode, int numberOfCars, ArrayList cars)
        {
            companyIdNumber = theCompanyIdNumber;
            companyName = theCompanyName;
            companyAddress = theCompanyAddress;
            companyPostcode = theCompanyPostcode;
            this.cars = cars;
        }

        public string showCompanyDetails()
        {
            return string.Format("Company ID: {0}. Name: {1}. Address: {2}, {3}. Number of cars: {4}.", 
                                companyIdNumber, companyName, companyAddress, companyPostcode, numberOfCars);
        }

        //Setters
        public void setCompanyIdNumber(string idNumber)
        {
            companyIdNumber = idNumber;
        }
        public void setCompanyName(string name)
        {
            companyName = name;
        }
        public void setCompanyAddress(string address)
        {
            companyAddress = address;
        }
        public void setCompanyPostcode(string postcode)
        {
            companyPostcode = postcode;
        }
        public void setNumberOfCars(int numOfCars)
        {
            //numberOfCars = numOfCars;
        }
        public void setCars(ArrayList theirCars)
        {
            cars = theirCars;
        }

        //Getters
        public string getCompanyIdNumber()
        {
            return companyIdNumber;
        }
        public string getCompanyName()
        {
            return companyName;
        }
        public string getCompanyAddress()
        {
            return companyAddress;
        }
        public string getCompanyPostcode()
        {
            return companyPostcode;
        }
        public int getNumberOfCars()
        {
            return numberOfCars;
        }
        public ArrayList getCars()
        {
            return cars;
        }

    }
}

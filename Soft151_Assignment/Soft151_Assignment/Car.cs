using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft151_Assignment
{
    class Car
    {
        private string carIdNumber;
        private string carMakeAndModel;
        private string carRegistration;
        private string carFuelType;
        private string carLastServiceDate;
        private string carComments;

        public Car()
        {

        }

        public Car(string idNumber, string makeAndModel, string registration, 
                    string fuelType, string lastServiceDate, string comments)
        {
            carIdNumber = idNumber;
            carMakeAndModel = makeAndModel;
            carRegistration = registration;
            carFuelType = fuelType;
            carLastServiceDate = lastServiceDate;
            carComments = comments;
        }

        public string showCarDetails()
        {
            return string.Format("Car ID: {0}. Make and Model: {1}. Registration: {2}. Fuel Type: {3}. Last Service Date: {4}. Comments: {5}",
                                carIdNumber, carMakeAndModel, carRegistration, carFuelType, carLastServiceDate, carComments);
        }

        //Setters
        public void setTheCarIdNumber(string theCarIdNumber)
        {
            carIdNumber = theCarIdNumber;
        }
        public void setTheCarMakeAndModel(string theCarMakeAndModel)
        {
            carMakeAndModel = theCarMakeAndModel;
        }
        public void setTheCarRegistration(string theCarRegistration)
        {
            carRegistration = theCarRegistration;
        }
        public void setTheCarFuelType(string theCarFuelType)
        {
            carFuelType = theCarFuelType;
        }
        public void setTheCarLastServiceDate(string theCarLastServiceDate)
        {
            carLastServiceDate = theCarLastServiceDate;
        }
        public void setTheCarComments(string theCarComments)
        {
            carComments = theCarComments;
        }

        //Getters
        public string getTheCarIdNumber()
        {
            return carIdNumber;
        }
        public string getTheCarMakeAndModel()
        {
            return carMakeAndModel;
        }
        public string getTheCarRegistration()
        {
            return carRegistration;
        }
        public string getTheCarFuelType()
        {
            return carFuelType;
        }
        public string getTheCarLastServiceDate()
        {
            return carLastServiceDate;
        }
        public string getTheCarComments()
        {
            return carComments;
        }

    }
}

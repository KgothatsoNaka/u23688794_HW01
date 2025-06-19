using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23688794_HW01.Models
{
    public class RescueBusModel
    {
        public List<Driver> Drivers { get; set; } = new List<Driver>();

        public string SearchFirstName { get; set; }
        public string SearchServiceType { get; set; }

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();


        public static RescueBusModel GetSampleData()
        {
            return new RescueBusModel
            {
                Drivers = new List<Driver>
                {
                new Driver { FirstName = "John", LastName = "Doe", PhoneNumber = "123-456-7890", ServiceType = "Advanced Life Support", ImageUrl = "/images/Drivers/Mdriver1.jpg" },
                new Driver { FirstName = "Jane", LastName = "Smith", PhoneNumber = "987-654-3210", ServiceType = "Basic Life Support", ImageUrl = "/images/Drivers/Fdriver1.jpg" },
                new Driver { FirstName = "Mike", LastName = "Johnson", PhoneNumber = "265-555-7855", ServiceType ="Patient Transport", ImageUrl = "/images/Drivers/Mdriver2.jpg" },
                new Driver { FirstName = "Emily", LastName = "Davis", PhoneNumber = "444-414-4648", ServiceType ="Medical Utility Vehicle", ImageUrl = "/images/Drivers/Fdriver2.jpg" },
                new Driver { FirstName = "Chris", LastName = "Brown", PhoneNumber = "313-233-1563", ServiceType = "Event Medical Ambulance", ImageUrl = "/images/Drivers/Mdriver3.jpg" },
                new Driver { FirstName = "Sarah", LastName = "Wilson", PhoneNumber = "222-112-2262", ServiceType = "Air Ambulance", ImageUrl = "/images/Drivers/Fdriver3.jpg" },
                new Driver { FirstName = "Alice", LastName = "Green", PhoneNumber = "041-122-1151", ServiceType = "Advanced Life Support", ImageUrl = "/images/Drivers/Mdriver4.jpg" },
                new Driver { FirstName = "Bob", LastName = "White", PhoneNumber = "645-666-6666", ServiceType = "Basic Life Support", ImageUrl = "/images/Drivers/Fdriver4.jpg" },
                new Driver { FirstName = "Charlie", LastName = "Black", PhoneNumber = "777-497-7797", ServiceType = "Patient Transport", ImageUrl = "/images/Drivers/Mdriver5.jpg" },
                new Driver { FirstName = "Diana", LastName = "Blue", PhoneNumber = "868-888-8288", ServiceType = "Medical Utility Vehicle", ImageUrl = "/images/Drivers/Fdriver5.jpg" }
                },

                Vehicles = new List<Vehicle>
                {
                new Vehicle { Type = "Advanced Life Support", RegistrationNumber = "AMB-1234", ServiceType = "Advanced Life Support", VImageUrl = "/images/vehicles/ambulance.jpg" },
                new Vehicle { Type = "Basic Life Support", RegistrationNumber = "BLS-5678", ServiceType = "Basic Life Support", VImageUrl = "/images/vehicles/basic_support.jpg" },
                new Vehicle { Type = "Patient Transport", RegistrationNumber = "PT-5678", ServiceType = "Patient Transport", VImageUrl = "/images/vehicles/patient_transport.jpg" },
                new Vehicle { Type = "Medical Utility Vehicle", RegistrationNumber = "MUV-9101", ServiceType = "Medical Utility Vehicle", VImageUrl = "/images/vehicles/medical_utility.jpg" },
                new Vehicle { Type = "Event Medical Ambulance", RegistrationNumber = "EMA-1122", ServiceType = "Event Medical Ambulance", VImageUrl = "/images/vehicles/event_medical.jpg" },
                new Vehicle { Type = "Air Ambulance", RegistrationNumber = "AA-3344", ServiceType = "Air Ambulance", VImageUrl = "/images/vehicles/air_ambulance.jpg" }
                }

            };


        }


        public RescueBusModel SearchDrivers()
        {

            var model = GetSampleData();

            if (!string.IsNullOrEmpty(SearchFirstName))
            {
                model.Drivers = model.Drivers
                    .Where(d => d.FirstName.Contains(SearchFirstName)).ToList();

            }
            if (!string.IsNullOrEmpty(SearchServiceType))
            {
                model.Drivers = model.Drivers
                    .Where(d => d.ServiceType.ToString().Equals(SearchServiceType, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return model;
        }

    }




























    public class Driver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceType { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string RegistrationNumber { get; set; }
        public string ServiceType { get; set; }
        public string VImageUrl { get; set; }
    }






}

















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Booked
    {
        private string TourName = "";
        private List<string> NameBookedCus = new List<string>();
        private List<string> PhoneBookedCus = new List<string>();
        private List<string> EmailBookedCus = new List<string>();
        private List<string> AddressBookedCus = new List<string>();

        private List<string> NameCus = new List<string>();
        private List<string> GenderCus = new List<string>();
        private List<string> DayOfBirthCus = new List<string>();

        public Booked(string tourname)
        {
            TourName = tourname;
        }

        public string getset_TourName
        {
            get { return TourName; }
            set { TourName = value; }
        }

        public List<string> getset_NameBookedCus
        {
            get { return NameBookedCus; }
            set { NameBookedCus.Add(value.ToString()); }
        }
        public List<string> getset_PhoneBookedCus
        {
            get { return PhoneBookedCus; }
            set { PhoneBookedCus.Add(value.ToString()); }
        }
        public List<string> getset_EmailBookedCus
        {
            get { return EmailBookedCus; }
            set { EmailBookedCus.Add(value.ToString()); }
        }
        public List<string> getset_AddressBookedCus
        {
            get { return AddressBookedCus; }
            set { AddressBookedCus.Add(value.ToString()); }
        }


        public List<string> getset_NameCus
        {
            get { return NameCus; }
            set { NameCus.Add(value.ToString()); }
        }
        public List<string> getset_GenderCus
        {
            get { return GenderCus; }
            set { GenderCus.Add(value.ToString()); }
        }
        public List<string> getset_DayOfBirthCus
        {
            get { return DayOfBirthCus; }
            set { DayOfBirthCus.Add(value.ToString()); ; }
        }
    }
}

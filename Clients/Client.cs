using System;

namespace Clients
{
    class Client
    {
        private int idClient;
        private string firstName;
        private string secondName;
        private string phoneNumber;
        private string markAuto;
        private string govermentNumber;
        private string typeOfService;
        private DateTime visitDate;
        private int cost;
        private string employee;

        public Client(int idClient, string firstName, string secondName, string phoneNumber, string markAuto, string govermentNumber, string typeOfService, DateTime visitDate, int cost, string employee)
        {
            this.IdClient = idClient;
            this.firstName = firstName;
            this.secondName = secondName;
            this.phoneNumber = phoneNumber;
            this.markAuto = markAuto;
            this.govermentNumber = govermentNumber;
            this.typeOfService = typeOfService;
            this.visitDate = visitDate;
            this.cost = cost;
            this.employee = employee;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string MarkAuto { get => markAuto; set => markAuto = value; }
        public string GovermentNumber { get => govermentNumber; set => govermentNumber = value; }
        public string TypeOfService { get => typeOfService; set => typeOfService = value; }
        public DateTime VisitDate { get => visitDate; set => visitDate = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Employee { get => employee; set => employee = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public int IdClient { get => idClient; set => idClient = value; }
    }
}

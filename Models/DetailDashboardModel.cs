namespace TeleMedichineProject.Models
{
    public class DetailDashboardModel
    {
        public string? AppointmentNo { get; set; }
        public string? Registration { get; set; }
        public string? PatientName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string? MedicalNo { get; set; }
        public string? VisitTypeValue { get; set; }
        public string? WorkStationCode { get; set; }
        public string? MobilePhoneNo { get; set; }
        public string? PhoneNo { get; set; }
        public string? EmailAddress { get; set; }
        public string? Address { get; set; }
    }
}

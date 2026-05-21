namespace TeleMedichineProject.Models.DTO
{
    public class TransactionNumberResult
    {
        public string? TransactionNumber { get; set; }
    }


    public class VitalSignHistory
    {
        public string? VitalSignName { get; set; }
        public string? VitalSignCode { get; set; }
        public string? VitalSignUnit { get; set; }
        public string? Value { get; set; }
    }

    public class LaboratoryHistory
    {
        public string? JobOrderNo { get; set; }
        public string? RegistrationNo { get; set; }
        public string? ItemName1  { get; set; }
        public string? ResultValue { get; set; }
    }
}

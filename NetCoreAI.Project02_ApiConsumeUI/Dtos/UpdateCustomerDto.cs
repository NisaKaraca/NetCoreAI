namespace NetCoreAI.Project02_ApiConsumeUI.Dtos
{
    public class UpdateCustomerDto
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public decimal customerBalance { get; set; }
    }
}

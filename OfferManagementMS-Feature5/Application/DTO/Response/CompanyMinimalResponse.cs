namespace Application.DTO.Response
{
    public class CompanyMinimalResponse
    {
        public Guid CompanyId { get; set; }
        public string BusinessName { get; set; }
        public string Logo { get; set;}
        public string BusinessSector { get; set; }
        public int WorkerQuantity { get; set;}
    }
}

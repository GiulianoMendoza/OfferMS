namespace Application.DTO.Response
{
    public class ApplicantMinimalResponse
    {
        public Guid UserId { get; set; }
        public UbicationResponse Ubication { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}

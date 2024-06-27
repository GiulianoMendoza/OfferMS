using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request
{
    public class ApplicationRequest
    {
        [Required(ErrorMessage = "El ID de oferta es obligatorio.")]
        public Guid OfferId { get; set; }
    }
}

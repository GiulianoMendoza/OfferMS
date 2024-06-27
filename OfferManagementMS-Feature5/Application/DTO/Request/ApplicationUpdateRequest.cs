using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request
{
    public class ApplicationUpdateRequest
    {
        [Required(ErrorMessage = "El tipo de estado de la postulación es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "ApplicationStatusTypeId debe ser mayor a cero.")]
        [DefaultValue(0)]
        public int ApplicationStatusTypeId { get; set; }
    }
}

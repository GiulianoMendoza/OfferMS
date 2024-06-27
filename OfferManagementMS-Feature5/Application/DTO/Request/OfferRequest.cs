using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request
{
    public class OfferRequest
    {
        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(50, ErrorMessage = "El título no puede exceder los 50 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [StringLength(1500, ErrorMessage = "La descripción no puede exceder los 1500 caracteres.")]
        public string Description { get; set; }
        public int? MinSalary { get; set; }
        public int? MaxSalary { get; set; }

        [Required(ErrorMessage = "La modalidad de trabajo es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "JobOfferModeId debe ser mayor a cero.")]
        [DefaultValue(0)]
        public int JobOfferModeId { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "CityId debe ser mayor a cero.")]
        [DefaultValue(0)]
        public int CityId { get; set; }

        [Range(18, 80, ErrorMessage = "La edad mínima debe estar entre 18 y 80.")]
        public int? MinAge { get; set; }

        [Range(18, 80, ErrorMessage = "La edad máxima debe estar entre 18 y 80.")]
        public int? MaxAge { get; set; }

        [Range(1, 50, ErrorMessage = "Las cantidad de vancantes debe estar entre 1 y 20.")]
        public int? Vacancies { get; set; }

        [Required(ErrorMessage = "AvailabilityToTravel es obligatorio.")]
        public bool AvailabilityToTravel { get; set; }

        [Required(ErrorMessage = "AvailabilityChangeOfResidence es obligatorio.")]
        public bool AvailabilityChangeOfResidence { get; set; }

        [Required(ErrorMessage = "El tipo de estudio es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "StudyTypeId debe ser mayor a cero.")]
        [DefaultValue(0)]
        public int StudyTypeId { get; set; }

        [Required(ErrorMessage = "Las categorias son obligatorias.")]
        public List<int> Categories { get; set; }

        [Required(ErrorMessage = "Las skills son obligatorias.")]
        public List<int> Skills { get; set; }

    }
}

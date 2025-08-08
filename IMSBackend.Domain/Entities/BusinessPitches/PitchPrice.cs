using IMSBackend.Common.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace IMSBackend.Domain.Entities.BusinessPitches
{
    public class PitchPrice : BaseEntity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }

}

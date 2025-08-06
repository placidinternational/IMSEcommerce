using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace IMSBackend.Common.Common;
public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    [JsonIgnore]
    public Guid CreatedBy { get; set; }
    [JsonIgnore]
    public Guid? UpdatedBy { get; set; }
    [JsonIgnore]
    public Guid? DeletedBy { get; set; }
    public bool IsDeleted { get; set; }

    public BaseEntity()
    {
        DateCreated = DateTime.UtcNow;
        DateUpdated = DateTime.UtcNow;
        IsDeleted = false;
    }
}

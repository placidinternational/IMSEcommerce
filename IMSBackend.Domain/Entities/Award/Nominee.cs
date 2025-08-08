using IMSBackend.Common.Common;


namespace IMSBackend.Domain.Entities.Award
{
    public class Nominee : BaseEntity
    {
        public Account.Account Account { get; set; }
        public Guid AccountId { get; set; }
        public string CompanyName { get; set; }
        public string? Logo { get; set; }
        public string? Picture { get; set; }
        public string? Biography { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public string NomineeCode { get; set; }
        public bool IsActive { get; set; }
        
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();

    }

}

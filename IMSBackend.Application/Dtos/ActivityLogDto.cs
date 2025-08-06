using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos
{
    public class ActivityLogDto
    {
        public Guid Id { get; set; }
        public string? Activity { get; set; }
        public string? Narration { get; set; }
        public string? UserDetails { get; set; }
        public string? SystemDetails { get; set; }
        public string? Objects { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

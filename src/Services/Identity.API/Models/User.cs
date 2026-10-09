using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.API.Models
{
    public class User
    {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Email { get; set; } = string.Empty;
            public string PasswordHash { get; set; } = string.Empty;
            public Role Role { get; set; } = Role.Reader;
            public bool IsBanned { get; set; }
            public bool CanPost { get; set; }
            public bool IsVip { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
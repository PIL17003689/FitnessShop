﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ITS_System.Models
{
    public class GeneralIssue : IIssue
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        public IdentityUser RecordedBy { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}

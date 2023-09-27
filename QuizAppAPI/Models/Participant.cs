﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppAPI.Models
{
    public class Participant
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        public int Score { get; set; }
        public int TimeTaken { get; set; }
    }

    public class ParticipantResult
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int TimeTaken { get; set; }
    }
}

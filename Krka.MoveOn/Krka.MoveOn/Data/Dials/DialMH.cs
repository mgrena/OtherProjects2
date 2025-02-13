﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krka.MoveOn.Data.Dials
{
    [Table("dial_mhs")]
    public class DialMH
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("type_q")]
        public required int Type_q { get; set; }

        [Column(TypeName = "varchar"), StringLength(10)]
        public required string Number { get; set; }

        [Column(TypeName = "nvarchar"), StringLength(200)]
        public required string Name { get; set; }

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

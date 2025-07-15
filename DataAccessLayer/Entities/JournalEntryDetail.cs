#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entities;

public partial class JournalEntryDetail
{
    [Key]
    public int Id { get; set; }

    public Guid AccountId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Debit { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Credit { get; set; }

    public int JounalEntryHeaderId { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("JournalEntryDetails")]
    public virtual AccountsChart Account { get; set; }

    [ForeignKey("JounalEntryHeaderId")]
    [InverseProperty("JournalEntryDetails")]
    public virtual JournalEntryHeader JounalEntryHeader { get; set; }
}
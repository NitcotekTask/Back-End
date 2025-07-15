#nullable disable
namespace DataAccessLayer.Entities;

[Table("JournalEntryHeader")]
public partial class JournalEntryHeader
{
    [Key]
    public int Id { get; set; }

    public int? EntryNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime EntryDate { get; set; }

    [Required]
    [StringLength(1500)]
    public string Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [InverseProperty("JounalEntryHeader")]
    public virtual ICollection<JournalEntryDetail> JournalEntryDetails { get; set; } = new List<JournalEntryDetail>();
}
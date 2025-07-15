#nullable disable
namespace DataAccessLayer.Entities;

public partial class NitcotekContext : DbContext
{
    public NitcotekContext()
    {
    }

    public NitcotekContext(DbContextOptions<NitcotekContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountsChart> AccountsCharts { get; set; }

    public virtual DbSet<JournalEntryDetail> JournalEntryDetails { get; set; }

    public virtual DbSet<JournalEntryHeader> JournalEntryHeaders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountsChart>(entity =>
        {
            entity.HasKey(e => e.ID)
                .HasName("PK__Accounts__3214EC2748817F42")
                .HasFillFactor(90);

            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<JournalEntryDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Account).WithMany(p => p.JournalEntryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalEntryDetails_AccountsChart");

            entity.HasOne(d => d.JounalEntryHeader).WithMany(p => p.JournalEntryDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalEntryDetails_JournalEntryHeader");
        });

        modelBuilder.Entity<JournalEntryHeader>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasIndex(e => e.EntryNumber)
               .IsUnique()
               .HasDatabaseName("UQ_JournalEntryHeader_EntryNumber");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
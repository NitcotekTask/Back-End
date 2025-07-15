﻿#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entities;

[Table("AccountsChart")]
public partial class AccountsChart
{
    [Key]
    public Guid ID { get; set; }

    [Required]
    [StringLength(150)]
    public string NameAR { get; set; }

    [Required]
    [StringLength(150)]
    public string NameEN { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Number { get; set; }

    public short FK_Transaction_Type_ID { get; set; }

    public bool Allow_Entry { get; set; }

    public bool Is_Active { get; set; }

    public long User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Creation_Date { get; set; }

    public bool? Status { get; set; }

    public Guid? Parent_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Parent_Number { get; set; }

    public short Chart_Level_Depth { get; set; }

    public short? FK_Cost_Center_Type_ID { get; set; }

    public long Branch_ID { get; set; }

    public long Org_ID { get; set; }

    public Guid? FK_Work_Fields_ID { get; set; }

    public short? noOfChilds { get; set; }

    [InverseProperty("Account")]
    public virtual ICollection<JournalEntryDetail> JournalEntryDetails { get; set; } = new List<JournalEntryDetail>();
}
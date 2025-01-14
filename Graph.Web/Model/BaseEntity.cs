﻿using System.ComponentModel.DataAnnotations;

namespace Graph.Web.Model;

public class BaseEntity
{
    [Key]
    public string? Id { get; set; }

    public DateTime CreationDate { get; set; } = DateTime.Now;

    public DateTime? ModificationDate { get; set; }
}


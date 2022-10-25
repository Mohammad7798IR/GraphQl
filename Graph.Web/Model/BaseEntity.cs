using System.ComponentModel.DataAnnotations;

namespace Graph.Web.Model;

public class BaseEntity
{
    [Key]
    public string? Id { get; set; } = Guid.NewGuid().ToString();        

    public string CreationDate { get; set; } = DateTime.Now.ToString();

    public string? ModificationDate { get; set; }
}


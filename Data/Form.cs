using System.ComponentModel.DataAnnotations;

public class SearchModel
{
    [Required]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Search term should be between {2} and {1} characters long.")]
    public string Name { get; set; }
}

public class AddModel
{
    [Required]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Name should be between {2} and {1} characters long.")]
    public string Name { get; set; }

    [Required]
    [StringLength(1, ErrorMessage = "Enter a number between 1 and 5")]
    public double Rating { get; set; }

    [Required]
    public int People { get; set; }

    [Required]
    public string Category { get; set; }

    [Required]
    public string Price { get; set; }
}

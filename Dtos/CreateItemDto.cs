using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos 
{   
    public record CreateItemDto
    {   
        [Required]
        public required string Name { get; init; }
        [Required]
        [Range(1,1000)]
        public decimal Price { get; init; }
    }
}
using System;

namespace Catalog.Entities
{
   public class Item
   {
      public Guid Id {get; init; }
      public required string Name {get; init; }
      public decimal Price {get; init; }
      public DateTimeOffset CreatedDate {get; init; }
   }
}
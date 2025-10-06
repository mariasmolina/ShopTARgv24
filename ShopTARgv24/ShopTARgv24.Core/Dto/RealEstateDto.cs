﻿using Microsoft.AspNetCore.Http;
using ShopTARgv24.Core.Domain;

namespace ShopTARgv24.Core.Dto
{
    public class RealEstateDto
    {
        public Guid? Id { get; set; }
        public double? Area { get; set; }
        public string? Location { get; set; }
        public int? RoomNumber { get; set; }
        public string? BuildingType { get; set; }
        public List<IFormFile> Files { get; set; }
        public IEnumerable<FileToDatabase> Image { get; set; }
            = new List<FileToDatabase>();
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}

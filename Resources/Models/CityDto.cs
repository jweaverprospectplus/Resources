﻿namespace Resources.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<PointsOfInterestDto> PointsOfInterest { get; set; }
            = new List<PointsOfInterestDto>();

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

    }
}

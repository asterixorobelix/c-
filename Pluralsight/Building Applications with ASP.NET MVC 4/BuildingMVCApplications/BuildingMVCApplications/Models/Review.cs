using System;

namespace BuildingMVCApplications.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
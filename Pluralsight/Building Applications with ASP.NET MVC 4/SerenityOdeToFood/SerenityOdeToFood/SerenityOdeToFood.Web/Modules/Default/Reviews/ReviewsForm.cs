
namespace SerenityOdeToFood.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Reviews")]
    [BasedOnRow(typeof(Entities.ReviewsRow))]
    public class ReviewsForm
    {
        public String ReviewText { get; set; }
        public Int32 Rating { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
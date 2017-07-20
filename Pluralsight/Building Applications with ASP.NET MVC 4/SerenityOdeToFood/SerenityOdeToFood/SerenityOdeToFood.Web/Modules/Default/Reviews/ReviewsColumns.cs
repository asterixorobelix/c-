
namespace SerenityOdeToFood.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Reviews")]
    [BasedOnRow(typeof(Entities.ReviewsRow))]
    public class ReviewsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid ReviewId { get; set; }
        [EditLink]
        public String ReviewText { get; set; }
        public Int32 Rating { get; set; }
        public Guid RestaurantId { get; set; }
    }
}

namespace SerenityOdeToFood.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Restaurants")]
    [BasedOnRow(typeof(Entities.RestaurantsRow))]
    public class RestaurantsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid RestaurantId { get; set; }
        [EditLink]
        public String City { get; set; }
        public String Country { get; set; }
        public String RestaurantName { get; set; }
    }
}
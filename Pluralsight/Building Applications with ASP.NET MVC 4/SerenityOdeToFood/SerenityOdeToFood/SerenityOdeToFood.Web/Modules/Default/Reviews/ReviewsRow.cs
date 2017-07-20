
namespace SerenityOdeToFood.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Reviews]"), DisplayName("Reviews"), InstanceName("Reviews"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ReviewsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Review Id"), PrimaryKey]
        public Guid? ReviewId
        {
            get { return Fields.ReviewId[this]; }
            set { Fields.ReviewId[this] = value; }
        }

        [DisplayName("Review Text"), Size(-1), QuickSearch]
        public String ReviewText
        {
            get { return Fields.ReviewText[this]; }
            set { Fields.ReviewText[this] = value; }
        }

        [DisplayName("Rating"), NotNull]
        public Int32? Rating
        {
            get { return Fields.Rating[this]; }
            set { Fields.Rating[this] = value; }
        }

        [DisplayName("Restaurant"), NotNull, ForeignKey("[dbo].[Restaurants]", "RestaurantId"), LeftJoin("jRestaurant"), TextualField("RestaurantCity")]
        public Guid? RestaurantId
        {
            get { return Fields.RestaurantId[this]; }
            set { Fields.RestaurantId[this] = value; }
        }

        [DisplayName("Restaurant City"), Expression("jRestaurant.[City]")]
        public String RestaurantCity
        {
            get { return Fields.RestaurantCity[this]; }
            set { Fields.RestaurantCity[this] = value; }
        }

        [DisplayName("Restaurant Country"), Expression("jRestaurant.[Country]")]
        public String RestaurantCountry
        {
            get { return Fields.RestaurantCountry[this]; }
            set { Fields.RestaurantCountry[this] = value; }
        }

        [DisplayName("Restaurant Restaurant Name"), Expression("jRestaurant.[RestaurantName]")]
        public String RestaurantRestaurantName
        {
            get { return Fields.RestaurantRestaurantName[this]; }
            set { Fields.RestaurantRestaurantName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ReviewId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ReviewText; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ReviewsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField ReviewId;
            public StringField ReviewText;
            public Int32Field Rating;
            public GuidField RestaurantId;

            public StringField RestaurantCity;
            public StringField RestaurantCountry;
            public StringField RestaurantRestaurantName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Reviews";
            }
        }
    }
}

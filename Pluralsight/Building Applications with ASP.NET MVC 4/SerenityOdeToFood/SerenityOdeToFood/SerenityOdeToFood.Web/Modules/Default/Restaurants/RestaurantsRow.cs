
namespace SerenityOdeToFood.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Restaurants]"), DisplayName("Restaurants"), InstanceName("Restaurants"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RestaurantsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Restaurant Id"), PrimaryKey]
        public Guid? RestaurantId
        {
            get { return Fields.RestaurantId[this]; }
            set { Fields.RestaurantId[this] = value; }
        }

        [DisplayName("City"), Size(-1), QuickSearch]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        [DisplayName("Country"), Size(-1)]
        public String Country
        {
            get { return Fields.Country[this]; }
            set { Fields.Country[this] = value; }
        }

        [DisplayName("Restaurant Name"), Size(100)]
        public String RestaurantName
        {
            get { return Fields.RestaurantName[this]; }
            set { Fields.RestaurantName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RestaurantId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.City; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RestaurantsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField RestaurantId;
            public StringField City;
            public StringField Country;
            public StringField RestaurantName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Restaurants";
            }
        }
    }
}

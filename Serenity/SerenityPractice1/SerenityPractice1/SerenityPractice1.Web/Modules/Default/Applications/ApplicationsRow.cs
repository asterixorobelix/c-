
namespace SerenityPractice1.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Applications]"), DisplayName("Applications"), InstanceName("Applications"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ApplicationsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Application Id"), PrimaryKey]
        public Guid? ApplicationId
        {
            get { return Fields.ApplicationId[this]; }
            set { Fields.ApplicationId[this] = value; }
        }

        [DisplayName("Application Name"), Size(100), QuickSearch]
        public String ApplicationName
        {
            get { return Fields.ApplicationName[this]; }
            set { Fields.ApplicationName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ApplicationId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ApplicationName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ApplicationsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField ApplicationId;
            public StringField ApplicationName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Applications";
            }
        }
    }
}

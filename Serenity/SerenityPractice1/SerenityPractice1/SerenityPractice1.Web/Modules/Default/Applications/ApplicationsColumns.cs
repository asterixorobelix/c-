
namespace SerenityPractice1.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Applications")]
    [BasedOnRow(typeof(Entities.ApplicationsRow))]
    public class ApplicationsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Guid ApplicationId { get; set; }
        [EditLink]
        public String ApplicationName { get; set; }
    }
}
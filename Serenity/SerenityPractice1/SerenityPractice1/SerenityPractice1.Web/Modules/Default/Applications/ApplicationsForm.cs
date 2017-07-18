
namespace SerenityPractice1.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Applications")]
    [BasedOnRow(typeof(Entities.ApplicationsRow))]
    public class ApplicationsForm
    {
        public String ApplicationName { get; set; }
    }
}
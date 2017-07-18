namespace Practice.Data
{
    public class Application
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ApplicationId { get; set; }
        [MaxLength(100)]
        public string ApplicationName { get; set; }
    }
}
namespace GG.Data
{
    using GG.Core.Entities.Addresses;
    using GG.Core.Entities.Authors;
    using GG.Core.Entities.Books;
    using GG.Core.Entities.Borroweds;
    using GG.Core.Entities.Categories;
    using GG.Core.Entities.Libraries;
    using GG.Core.Entities.Publishers;
    using GG.Core.Entities.Users;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    /// <summary>
    /// Objects context
    /// </summary>
    public partial class GGDatabaseContext : DbContext
    {
        #region Ctor

        public GGDatabaseContext() : base("data source=PC\\SQLEXPRESS;initial catalog=GG;integrated security=True;")
        {

        }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #endregion

        #region Properties
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<AuthorBookMapping> AuthorBookMapping { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Borrowed> Borrowed { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryBookMapping> CategoryBookMapping { get; set; }
        public virtual DbSet<LibraryBookMapping> LibraryBookMapping { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }

        #endregion
    }
}

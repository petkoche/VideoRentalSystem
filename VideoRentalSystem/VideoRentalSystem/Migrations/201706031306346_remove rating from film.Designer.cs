// <auto-generated />
namespace VideoRentalSystem.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class removeratingfromfilm : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(removeratingfromfilm));
        
        string IMigrationMetadata.Id
        {
            get { return "201706031306346_remove rating from film"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}

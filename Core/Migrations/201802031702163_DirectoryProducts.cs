using System.Data.Entity.Migrations;

namespace Core.Migrations
{
    /// <summary>
    /// Миграция создаёт базу данных "Справочник продуктов" и добавляет в неё таблицы: "Продукты" и "Группы продуктов".
    /// </summary>
    public partial class DirectoryProducts : DbMigration
    {
        /// <summary>
        /// Применение миграции.
        /// </summary>
        public override void Up()
        {
            //Продукты.
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GroupProduct_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GroupProducts", t => t.GroupProduct_Id)
                .Index(t => t.GroupProduct_Id);
            
            //Группы продуктов.
            CreateTable(
                "dbo.GroupProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        /// <summary>
        /// Откат миграции.
        /// </summary>
        public override void Down()
        {
            DropForeignKey("dbo.Products", "GroupProduct_Id", "dbo.GroupProducts");
            DropIndex("dbo.Products", new[] { "GroupProduct_Id" });
            DropTable("dbo.GroupProducts");
            DropTable("dbo.Products");
        }
    }
}

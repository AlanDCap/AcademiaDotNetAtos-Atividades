using Microsoft.EntityFrameworkCore;
using AtosProjetoFinal.Models;

namespace AtosProjetoFinal.Data
{
    public class CharacterSheetContext : DbContext
    {
        public DbSet<Ancestry> Ancestries { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharArmor> CharArmors { get; set; }
        public DbSet<CharAttributes> CharAttributes { get; set; }
        public DbSet<CharItem> CharItems { get; set; }
        public DbSet<CharWeapon> CharWeapons { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ALITA; Initial Catalog=AtosProjetoFinalTeste; TrustServerCertificate=True; Integrated Security = True");
        }

    }
}

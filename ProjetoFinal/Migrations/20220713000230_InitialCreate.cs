using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtosProjetoFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ancestry",
                columns: table => new
                {
                    ancestryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ancestryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trait1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trait2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trait3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestry", x => x.ancestryID);
                });

            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    armorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    armorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    armorGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    armorBulk = table.Column<int>(type: "int", nullable: false),
                    armorProtectionValue = table.Column<int>(type: "int", nullable: false),
                    armorDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.armorID);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    classID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    level1_ability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level2_ability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level3_ability = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.classID);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    itemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemBulk = table.Column<int>(type: "int", nullable: false),
                    itemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.itemID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    roleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trait1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trait2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trait3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.roleID);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    weaponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weaponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weaponGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weapongDmgType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weaponRange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weaponDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.weaponID);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    characterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    characterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ancestryID = table.Column<int>(type: "int", nullable: false),
                    roleID = table.Column<int>(type: "int", nullable: false),
                    classID = table.Column<int>(type: "int", nullable: false),
                    expPoints = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    background = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.characterID);
                    table.ForeignKey(
                        name: "FK_Character_Ancestry_ancestryID",
                        column: x => x.ancestryID,
                        principalTable: "Ancestry",
                        principalColumn: "ancestryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Character_Class_classID",
                        column: x => x.classID,
                        principalTable: "Class",
                        principalColumn: "classID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Character_Role_roleID",
                        column: x => x.roleID,
                        principalTable: "Role",
                        principalColumn: "roleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharArmor",
                columns: table => new
                {
                    charArmorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    characterID = table.Column<int>(type: "int", nullable: false),
                    armorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharArmor", x => x.charArmorID);
                    table.ForeignKey(
                        name: "FK_CharArmor_Armor_armorID",
                        column: x => x.armorID,
                        principalTable: "Armor",
                        principalColumn: "armorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharArmor_Character_characterID",
                        column: x => x.characterID,
                        principalTable: "Character",
                        principalColumn: "characterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharAttibutes",
                columns: table => new
                {
                    charAttributesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    characterID = table.Column<int>(type: "int", nullable: false),
                    physique = table.Column<int>(type: "int", nullable: false),
                    dexterity = table.Column<int>(type: "int", nullable: false),
                    intelligence = table.Column<int>(type: "int", nullable: false),
                    perception = table.Column<int>(type: "int", nullable: false),
                    charisma = table.Column<int>(type: "int", nullable: false),
                    conviction = table.Column<int>(type: "int", nullable: false),
                    evasion = table.Column<int>(type: "int", nullable: false),
                    block = table.Column<int>(type: "int", nullable: false),
                    magic_def = table.Column<int>(type: "int", nullable: false),
                    stamina = table.Column<int>(type: "int", nullable: false),
                    spirit = table.Column<int>(type: "int", nullable: false),
                    reputation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharAttibutes", x => x.charAttributesID);
                    table.ForeignKey(
                        name: "FK_CharAttibutes_Character_characterID",
                        column: x => x.characterID,
                        principalTable: "Character",
                        principalColumn: "characterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharItem",
                columns: table => new
                {
                    charItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    characterID = table.Column<int>(type: "int", nullable: false),
                    itemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharItem", x => x.charItemID);
                    table.ForeignKey(
                        name: "FK_CharItem_Character_characterID",
                        column: x => x.characterID,
                        principalTable: "Character",
                        principalColumn: "characterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharItem_Item_itemID",
                        column: x => x.itemID,
                        principalTable: "Item",
                        principalColumn: "itemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharWeapon",
                columns: table => new
                {
                    charWeaponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    characterID = table.Column<int>(type: "int", nullable: false),
                    weaponID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharWeapon", x => x.charWeaponID);
                    table.ForeignKey(
                        name: "FK_CharWeapon_Character_characterID",
                        column: x => x.characterID,
                        principalTable: "Character",
                        principalColumn: "characterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharWeapon_Weapon_weaponID",
                        column: x => x.weaponID,
                        principalTable: "Weapon",
                        principalColumn: "weaponID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Character_ancestryID",
                table: "Character",
                column: "ancestryID");

            migrationBuilder.CreateIndex(
                name: "IX_Character_classID",
                table: "Character",
                column: "classID");

            migrationBuilder.CreateIndex(
                name: "IX_Character_roleID",
                table: "Character",
                column: "roleID");

            migrationBuilder.CreateIndex(
                name: "IX_CharArmor_armorID",
                table: "CharArmor",
                column: "armorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharArmor_characterID",
                table: "CharArmor",
                column: "characterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharAttibutes_characterID",
                table: "CharAttibutes",
                column: "characterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharItem_characterID",
                table: "CharItem",
                column: "characterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharItem_itemID",
                table: "CharItem",
                column: "itemID");

            migrationBuilder.CreateIndex(
                name: "IX_CharWeapon_characterID",
                table: "CharWeapon",
                column: "characterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharWeapon_weaponID",
                table: "CharWeapon",
                column: "weaponID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharArmor");

            migrationBuilder.DropTable(
                name: "CharAttibutes");

            migrationBuilder.DropTable(
                name: "CharItem");

            migrationBuilder.DropTable(
                name: "CharWeapon");

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "Ancestry");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}

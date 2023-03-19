using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroCivil.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resgistros",
                columns: table => new
                {
                    RegistroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monoparental = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resgistros", x => x.RegistroID);
                });

            migrationBuilder.InsertData(
                table: "Resgistros",
                columns: new[] { "RegistroID", "Apellido", "FechaNacimiento", "Monoparental", "Nombre", "NumeroIdentificacion", "Sexo" },
                values: new object[,]
                {
                    { 1, "García", new DateTime(1996, 1, 5, 13, 22, 0, 0, DateTimeKind.Unspecified), true, "Juan", "AN1256", "M" },
                    { 2, "Fernández", new DateTime(1995, 12, 3, 8, 45, 0, 0, DateTimeKind.Unspecified), true, "María", "AR1257", "F" },
                    { 3, "Martínez", new DateTime(1993, 7, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), false, "Pedro", "AS1258", "M" },
                    { 4, "Rodríguez", new DateTime(1994, 5, 11, 12, 15, 0, 0, DateTimeKind.Unspecified), true, "Elena", "IB1259", "F" },
                    { 5, "López", new DateTime(1998, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "Carlos", "CN1260", "M" },
                    { 6, "Gómez", new DateTime(1992, 2, 18, 16, 40, 0, 0, DateTimeKind.Unspecified), true, "Isabel", "CB1261", "F" },
                    { 7, "Hernández", new DateTime(1997, 11, 7, 19, 20, 0, 0, DateTimeKind.Unspecified), false, "Antonio", "CM1262", "M" },
                    { 8, "Díaz", new DateTime(1991, 8, 9, 14, 50, 0, 0, DateTimeKind.Unspecified), true, "Lucía", "CL1263", "F" },
                    { 9, "Pérez", new DateTime(1996, 4, 26, 9, 35, 0, 0, DateTimeKind.Unspecified), false, "Sergio", "CT1264", "M" },
                    { 10, "Sánchez", new DateTime(1999, 3, 14, 11, 55, 0, 0, DateTimeKind.Unspecified), false, "Ana", "VC1265", "F" },
                    { 11, "Ramírez", new DateTime(1993, 6, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), true, "Francisco", "CE1266", "M" },
                    { 12, "González", new DateTime(1995, 9, 17, 7, 25, 0, 0, DateTimeKind.Unspecified), false, "Laura", "CL1267", "F" },
                    { 13, "Fernández", new DateTime(1990, 12, 20, 14, 10, 0, 0, DateTimeKind.Unspecified), true, "Marta", "AS8564", "F" },
                    { 14, "García", new DateTime(1985, 6, 12, 9, 45, 0, 0, DateTimeKind.Unspecified), false, "Antonio", "GA7583", "M" },
                    { 15, "Martínez", new DateTime(1982, 11, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), true, "Isabel", "MD2487", "F" },
                    { 16, "Castillo", new DateTime(1998, 3, 6, 11, 20, 0, 0, DateTimeKind.Unspecified), false, "Pablo", "CT6589", "M" },
                    { 17, "Ibáñez", new DateTime(1993, 7, 15, 8, 15, 0, 0, DateTimeKind.Unspecified), false, "Sofía", "IB3654", "F" },
                    { 18, "Rivas", new DateTime(1991, 9, 2, 12, 55, 0, 0, DateTimeKind.Unspecified), false, "David", "RI9502", "M" },
                    { 19, "Pérez", new DateTime(1988, 4, 28, 19, 40, 0, 0, DateTimeKind.Unspecified), false, "Ainhoa", "PV1746", "F" },
                    { 20, "Vicente", new DateTime(1996, 11, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), true, "Carlos", "VC5341", "M" },
                    { 21, "Nieto", new DateTime(1989, 2, 22, 22, 10, 0, 0, DateTimeKind.Unspecified), true, "María", "NC6758", "F" },
                    { 22, "Expósito", new DateTime(1997, 5, 18, 5, 50, 0, 0, DateTimeKind.Unspecified), true, "José", "EX3297", "M" },
                    { 23, "Álvarez", new DateTime(1998, 1, 23, 11, 35, 0, 0, DateTimeKind.Unspecified), true, "María", "AS6234", "F" },
                    { 24, "Martínez", new DateTime(1999, 6, 12, 19, 15, 0, 0, DateTimeKind.Unspecified), true, "Pablo", "MD4189", "M" },
                    { 25, "Cabrera", new DateTime(1995, 8, 8, 8, 20, 0, 0, DateTimeKind.Unspecified), true, "Elena", "CM8215", "F" },
                    { 26, "Navarro", new DateTime(1996, 3, 28, 15, 10, 0, 0, DateTimeKind.Unspecified), true, "Francisco", "NC5328", "M" },
                    { 27, "Rivas", new DateTime(1997, 12, 5, 4, 45, 0, 0, DateTimeKind.Unspecified), true, "Sara", "RI7351", "F" },
                    { 28, "Díaz", new DateTime(1998, 2, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), true, "Manuel", "MD9462", "M" },
                    { 29, "Asturias", new DateTime(1999, 7, 28, 9, 55, 0, 0, DateTimeKind.Unspecified), true, "Laura", "AS2809", "F" },
                    { 30, "Aragón", new DateTime(1996, 9, 12, 13, 45, 0, 0, DateTimeKind.Unspecified), true, "Javier", "AR6792", "M" },
                    { 31, "Castillo", new DateTime(1997, 1, 10, 8, 15, 0, 0, DateTimeKind.Unspecified), false, "Lucía", "CL5421", "F" },
                    { 32, "Expósito", new DateTime(1998, 3, 9, 17, 25, 0, 0, DateTimeKind.Unspecified), false, "Miguel", "EX8374", "M" },
                    { 33, "Álvarez", new DateTime(1995, 11, 22, 10, 50, 0, 0, DateTimeKind.Unspecified), false, "Carmen", "AS3748", "F" },
                    { 34, "Martínez", new DateTime(1996, 4, 19, 12, 40, 0, 0, DateTimeKind.Unspecified), false, "David", "MD1765", "M" },
                    { 35, "Nicolás", new DateTime(1996, 8, 8, 13, 45, 0, 0, DateTimeKind.Unspecified), true, "Lucía", "NC3592", "F" },
                    { 36, "Andrés", new DateTime(1995, 1, 29, 6, 20, 0, 0, DateTimeKind.Unspecified), false, "Rubén", "AN3621", "M" },
                    { 37, "Cabañas", new DateTime(1997, 12, 11, 17, 55, 0, 0, DateTimeKind.Unspecified), false, "Sara", "CB3748", "F" },
                    { 38, "Arroyo", new DateTime(1996, 9, 16, 8, 30, 0, 0, DateTimeKind.Unspecified), false, "Adrián", "AR3810", "M" },
                    { 39, "Rivas", new DateTime(1998, 2, 3, 23, 5, 0, 0, DateTimeKind.Unspecified), true, "Ana", "RI3972", "F" },
                    { 40, "Astorga", new DateTime(1995, 6, 19, 11, 40, 0, 0, DateTimeKind.Unspecified), true, "Daniel", "AS4058", "M" },
                    { 41, "Clavijo", new DateTime(1997, 3, 27, 2, 15, 0, 0, DateTimeKind.Unspecified), false, "Eva", "CL4125", "F" },
                    { 42, "Ceballos", new DateTime(1996, 9, 4, 19, 50, 0, 0, DateTimeKind.Unspecified), true, "Javier", "CE4291", "M" }
                });

            migrationBuilder.InsertData(
                table: "Resgistros",
                columns: new[] { "RegistroID", "Apellido", "FechaNacimiento", "Monoparental", "Nombre", "NumeroIdentificacion", "Sexo" },
                values: new object[,]
                {
                    { 43, "Salas", new DateTime(1995, 1, 13, 10, 25, 0, 0, DateTimeKind.Unspecified), true, "Lucía", "SA4378", "F" },
                    { 44, "Cobos", new DateTime(1998, 7, 22, 1, 0, 0, 0, DateTimeKind.Unspecified), false, "Mario", "CB4443", "M" },
                    { 45, "Astorga", new DateTime(1996, 2, 10, 15, 10, 0, 0, DateTimeKind.Unspecified), false, "Sofía", "AS4523", "F" },
                    { 46, "Mancera", new DateTime(1994, 6, 23, 9, 30, 0, 0, DateTimeKind.Unspecified), true, "Carmen", "MC6512", "F" },
                    { 47, "Gálvez", new DateTime(1997, 11, 12, 11, 45, 0, 0, DateTimeKind.Unspecified), true, "Gabriel", "GA5487", "M" },
                    { 48, "Castaño", new DateTime(1999, 4, 4, 18, 20, 0, 0, DateTimeKind.Unspecified), false, "Teresa", "CT1349", "F" },
                    { 49, "Calvo", new DateTime(1996, 9, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), false, "Víctor", "CV6652", "M" },
                    { 50, "Pérez", new DateTime(1995, 12, 30, 5, 15, 0, 0, DateTimeKind.Unspecified), false, "Valeria", "PV2179", "F" },
                    { 51, "Rivas", new DateTime(1998, 7, 8, 16, 55, 0, 0, DateTimeKind.Unspecified), false, "Ignacio", "RI7721", "M" },
                    { 52, "Nava", new DateTime(1997, 3, 17, 14, 40, 0, 0, DateTimeKind.Unspecified), true, "Cristina", "NC1884", "F" },
                    { 53, "Andrade", new DateTime(1995, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "Noelia", "AN3558", "F" },
                    { 54, "Cáceres", new DateTime(1999, 9, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), false, "Manuel", "CM4736", "M" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resgistros");
        }
    }
}

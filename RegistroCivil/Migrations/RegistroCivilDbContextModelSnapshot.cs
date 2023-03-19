﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroCivil.Context;

#nullable disable

namespace RegistroCivil.Migrations
{
    [DbContext(typeof(RegistroCivilDbContext))]
    partial class RegistroCivilDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RegistroCivil.Models.Registro", b =>
                {
                    b.Property<int>("RegistroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistroID"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Monoparental")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroIdentificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("RegistroID");

                    b.ToTable("Resgistros");

                    b.HasData(
                        new
                        {
                            RegistroID = 1,
                            Apellido = "García",
                            FechaNacimiento = new DateTime(1996, 1, 5, 13, 22, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Juan",
                            NumeroIdentificacion = "AN1256",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 2,
                            Apellido = "Fernández",
                            FechaNacimiento = new DateTime(1995, 12, 3, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "María",
                            NumeroIdentificacion = "AR1257",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 3,
                            Apellido = "Martínez",
                            FechaNacimiento = new DateTime(1993, 7, 22, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Pedro",
                            NumeroIdentificacion = "AS1258",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 4,
                            Apellido = "Rodríguez",
                            FechaNacimiento = new DateTime(1994, 5, 11, 12, 15, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Elena",
                            NumeroIdentificacion = "IB1259",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 5,
                            Apellido = "López",
                            FechaNacimiento = new DateTime(1998, 9, 29, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Carlos",
                            NumeroIdentificacion = "CN1260",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 6,
                            Apellido = "Gómez",
                            FechaNacimiento = new DateTime(1992, 2, 18, 16, 40, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Isabel",
                            NumeroIdentificacion = "CB1261",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 7,
                            Apellido = "Hernández",
                            FechaNacimiento = new DateTime(1997, 11, 7, 19, 20, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Antonio",
                            NumeroIdentificacion = "CM1262",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 8,
                            Apellido = "Díaz",
                            FechaNacimiento = new DateTime(1991, 8, 9, 14, 50, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Lucía",
                            NumeroIdentificacion = "CL1263",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 9,
                            Apellido = "Pérez",
                            FechaNacimiento = new DateTime(1996, 4, 26, 9, 35, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Sergio",
                            NumeroIdentificacion = "CT1264",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 10,
                            Apellido = "Sánchez",
                            FechaNacimiento = new DateTime(1999, 3, 14, 11, 55, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Ana",
                            NumeroIdentificacion = "VC1265",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 11,
                            Apellido = "Ramírez",
                            FechaNacimiento = new DateTime(1993, 6, 2, 15, 10, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Francisco",
                            NumeroIdentificacion = "CE1266",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 12,
                            Apellido = "González",
                            FechaNacimiento = new DateTime(1995, 9, 17, 7, 25, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Laura",
                            NumeroIdentificacion = "CL1267",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 13,
                            Apellido = "Fernández",
                            FechaNacimiento = new DateTime(1990, 12, 20, 14, 10, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Marta",
                            NumeroIdentificacion = "AS8564",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 14,
                            Apellido = "García",
                            FechaNacimiento = new DateTime(1985, 6, 12, 9, 45, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Antonio",
                            NumeroIdentificacion = "GA7583",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 15,
                            Apellido = "Martínez",
                            FechaNacimiento = new DateTime(1982, 11, 25, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Isabel",
                            NumeroIdentificacion = "MD2487",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 16,
                            Apellido = "Castillo",
                            FechaNacimiento = new DateTime(1998, 3, 6, 11, 20, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Pablo",
                            NumeroIdentificacion = "CT6589",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 17,
                            Apellido = "Ibáñez",
                            FechaNacimiento = new DateTime(1993, 7, 15, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Sofía",
                            NumeroIdentificacion = "IB3654",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 18,
                            Apellido = "Rivas",
                            FechaNacimiento = new DateTime(1991, 9, 2, 12, 55, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "David",
                            NumeroIdentificacion = "RI9502",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 19,
                            Apellido = "Pérez",
                            FechaNacimiento = new DateTime(1988, 4, 28, 19, 40, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Ainhoa",
                            NumeroIdentificacion = "PV1746",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 20,
                            Apellido = "Vicente",
                            FechaNacimiento = new DateTime(1996, 11, 10, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Carlos",
                            NumeroIdentificacion = "VC5341",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 21,
                            Apellido = "Nieto",
                            FechaNacimiento = new DateTime(1989, 2, 22, 22, 10, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "María",
                            NumeroIdentificacion = "NC6758",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 22,
                            Apellido = "Expósito",
                            FechaNacimiento = new DateTime(1997, 5, 18, 5, 50, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "José",
                            NumeroIdentificacion = "EX3297",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 23,
                            Apellido = "Álvarez",
                            FechaNacimiento = new DateTime(1998, 1, 23, 11, 35, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "María",
                            NumeroIdentificacion = "AS6234",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 24,
                            Apellido = "Martínez",
                            FechaNacimiento = new DateTime(1999, 6, 12, 19, 15, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Pablo",
                            NumeroIdentificacion = "MD4189",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 25,
                            Apellido = "Cabrera",
                            FechaNacimiento = new DateTime(1995, 8, 8, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Elena",
                            NumeroIdentificacion = "CM8215",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 26,
                            Apellido = "Navarro",
                            FechaNacimiento = new DateTime(1996, 3, 28, 15, 10, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Francisco",
                            NumeroIdentificacion = "NC5328",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 27,
                            Apellido = "Rivas",
                            FechaNacimiento = new DateTime(1997, 12, 5, 4, 45, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Sara",
                            NumeroIdentificacion = "RI7351",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 28,
                            Apellido = "Díaz",
                            FechaNacimiento = new DateTime(1998, 2, 16, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Manuel",
                            NumeroIdentificacion = "MD9462",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 29,
                            Apellido = "Asturias",
                            FechaNacimiento = new DateTime(1999, 7, 28, 9, 55, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Laura",
                            NumeroIdentificacion = "AS2809",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 30,
                            Apellido = "Aragón",
                            FechaNacimiento = new DateTime(1996, 9, 12, 13, 45, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Javier",
                            NumeroIdentificacion = "AR6792",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 31,
                            Apellido = "Castillo",
                            FechaNacimiento = new DateTime(1997, 1, 10, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Lucía",
                            NumeroIdentificacion = "CL5421",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 32,
                            Apellido = "Expósito",
                            FechaNacimiento = new DateTime(1998, 3, 9, 17, 25, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Miguel",
                            NumeroIdentificacion = "EX8374",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 33,
                            Apellido = "Álvarez",
                            FechaNacimiento = new DateTime(1995, 11, 22, 10, 50, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Carmen",
                            NumeroIdentificacion = "AS3748",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 34,
                            Apellido = "Martínez",
                            FechaNacimiento = new DateTime(1996, 4, 19, 12, 40, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "David",
                            NumeroIdentificacion = "MD1765",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 35,
                            Apellido = "Nicolás",
                            FechaNacimiento = new DateTime(1996, 8, 8, 13, 45, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Lucía",
                            NumeroIdentificacion = "NC3592",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 36,
                            Apellido = "Andrés",
                            FechaNacimiento = new DateTime(1995, 1, 29, 6, 20, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Rubén",
                            NumeroIdentificacion = "AN3621",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 37,
                            Apellido = "Cabañas",
                            FechaNacimiento = new DateTime(1997, 12, 11, 17, 55, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Sara",
                            NumeroIdentificacion = "CB3748",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 38,
                            Apellido = "Arroyo",
                            FechaNacimiento = new DateTime(1996, 9, 16, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Adrián",
                            NumeroIdentificacion = "AR3810",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 39,
                            Apellido = "Rivas",
                            FechaNacimiento = new DateTime(1998, 2, 3, 23, 5, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Ana",
                            NumeroIdentificacion = "RI3972",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 40,
                            Apellido = "Astorga",
                            FechaNacimiento = new DateTime(1995, 6, 19, 11, 40, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Daniel",
                            NumeroIdentificacion = "AS4058",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 41,
                            Apellido = "Clavijo",
                            FechaNacimiento = new DateTime(1997, 3, 27, 2, 15, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Eva",
                            NumeroIdentificacion = "CL4125",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 42,
                            Apellido = "Ceballos",
                            FechaNacimiento = new DateTime(1996, 9, 4, 19, 50, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Javier",
                            NumeroIdentificacion = "CE4291",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 43,
                            Apellido = "Salas",
                            FechaNacimiento = new DateTime(1995, 1, 13, 10, 25, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Lucía",
                            NumeroIdentificacion = "SA4378",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 44,
                            Apellido = "Cobos",
                            FechaNacimiento = new DateTime(1998, 7, 22, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Mario",
                            NumeroIdentificacion = "CB4443",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 45,
                            Apellido = "Astorga",
                            FechaNacimiento = new DateTime(1996, 2, 10, 15, 10, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Sofía",
                            NumeroIdentificacion = "AS4523",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 46,
                            Apellido = "Mancera",
                            FechaNacimiento = new DateTime(1994, 6, 23, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Carmen",
                            NumeroIdentificacion = "MC6512",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 47,
                            Apellido = "Gálvez",
                            FechaNacimiento = new DateTime(1997, 11, 12, 11, 45, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Gabriel",
                            NumeroIdentificacion = "GA5487",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 48,
                            Apellido = "Castaño",
                            FechaNacimiento = new DateTime(1999, 4, 4, 18, 20, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Teresa",
                            NumeroIdentificacion = "CT1349",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 49,
                            Apellido = "Calvo",
                            FechaNacimiento = new DateTime(1996, 9, 19, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Víctor",
                            NumeroIdentificacion = "CV6652",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 50,
                            Apellido = "Pérez",
                            FechaNacimiento = new DateTime(1995, 12, 30, 5, 15, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Valeria",
                            NumeroIdentificacion = "PV2179",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 51,
                            Apellido = "Rivas",
                            FechaNacimiento = new DateTime(1998, 7, 8, 16, 55, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Ignacio",
                            NumeroIdentificacion = "RI7721",
                            Sexo = "M"
                        },
                        new
                        {
                            RegistroID = 52,
                            Apellido = "Nava",
                            FechaNacimiento = new DateTime(1997, 3, 17, 14, 40, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Cristina",
                            NumeroIdentificacion = "NC1884",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 53,
                            Apellido = "Andrade",
                            FechaNacimiento = new DateTime(1995, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = true,
                            Nombre = "Noelia",
                            NumeroIdentificacion = "AN3558",
                            Sexo = "F"
                        },
                        new
                        {
                            RegistroID = 54,
                            Apellido = "Cáceres",
                            FechaNacimiento = new DateTime(1999, 9, 11, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Monoparental = false,
                            Nombre = "Manuel",
                            NumeroIdentificacion = "CM4736",
                            Sexo = "M"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

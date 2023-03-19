using Microsoft.EntityFrameworkCore;

namespace RegistroCivil.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Registro> registros = new List<Registro>()
            {
                new Registro { RegistroID = 1, NumeroIdentificacion = "AN1256", Nombre = "Juan", Apellido = "García", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("05/01/1996 13:22:00"), Monoparental = true  },
                new Registro { RegistroID = 2, NumeroIdentificacion = "AR1257", Nombre = "María", Apellido = "Fernández", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("03/12/1995 08:45:00"), Monoparental = true  },
                new Registro { RegistroID = 3, NumeroIdentificacion = "AS1258", Nombre = "Pedro", Apellido = "Martínez", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("22/07/1993 17:30:00"), Monoparental = false  },
                new Registro { RegistroID = 4, NumeroIdentificacion = "IB1259", Nombre = "Elena", Apellido = "Rodríguez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("11/05/1994 12:15:00"), Monoparental = true  },
                new Registro { RegistroID = 5, NumeroIdentificacion = "CN1260", Nombre = "Carlos", Apellido = "López", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("29/09/1998 10:00:00"), Monoparental = true  },
                new Registro { RegistroID = 6, NumeroIdentificacion = "CB1261", Nombre = "Isabel", Apellido = "Gómez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("18/02/1992 16:40:00"), Monoparental = true  },
                new Registro { RegistroID = 7, NumeroIdentificacion = "CM1262", Nombre = "Antonio", Apellido = "Hernández", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("07/11/1997 19:20:00"), Monoparental = false  },
                new Registro { RegistroID = 8, NumeroIdentificacion = "CL1263", Nombre = "Lucía", Apellido = "Díaz", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("09/08/1991 14:50:00"), Monoparental = true  },
                new Registro { RegistroID = 9, NumeroIdentificacion = "CT1264", Nombre = "Sergio", Apellido = "Pérez", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("26/04/1996 09:35:00"), Monoparental = false  },
                new Registro { RegistroID = 10, NumeroIdentificacion = "VC1265", Nombre = "Ana", Apellido = "Sánchez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("14/03/1999 11:55:00"), Monoparental = false  },
                new Registro { RegistroID = 11, NumeroIdentificacion = "CE1266", Nombre = "Francisco", Apellido = "Ramírez", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("02/06/1993 15:10:00"), Monoparental = true  },
                new Registro { RegistroID = 12, NumeroIdentificacion = "CL1267", Nombre = "Laura", Apellido = "González", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("17/09/1995 07:25:00"), Monoparental = false  },
                new Registro { RegistroID = 13, NumeroIdentificacion = "AS8564", Nombre = "Marta", Apellido = "Fernández", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("20/12/1990 14:10:00"), Monoparental = true  },
                new Registro { RegistroID = 14, NumeroIdentificacion = "GA7583", Nombre = "Antonio", Apellido = "García", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("12/06/1985 09:45:00"), Monoparental = false  },
                new Registro { RegistroID = 15, NumeroIdentificacion = "MD2487", Nombre = "Isabel", Apellido = "Martínez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("25/11/1982 17:30:00"), Monoparental = true  },
                new Registro { RegistroID = 16, NumeroIdentificacion = "CT6589", Nombre = "Pablo", Apellido = "Castillo", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("06/03/1998 11:20:00"), Monoparental = false  },
                new Registro { RegistroID = 17, NumeroIdentificacion = "IB3654", Nombre = "Sofía", Apellido = "Ibáñez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("15/07/1993 08:15:00"), Monoparental = false  },
                new Registro { RegistroID = 18, NumeroIdentificacion = "RI9502", Nombre = "David", Apellido = "Rivas", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("02/09/1991 12:55:00"), Monoparental = false  },
                new Registro { RegistroID = 19, NumeroIdentificacion = "PV1746", Nombre = "Ainhoa", Apellido = "Pérez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("28/04/1988 19:40:00"), Monoparental = false  },
                new Registro { RegistroID = 20, NumeroIdentificacion = "VC5341", Nombre = "Carlos", Apellido = "Vicente", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("10/11/1996 15:00:00"), Monoparental = true  },
                new Registro { RegistroID = 21, NumeroIdentificacion = "NC6758", Nombre = "María", Apellido = "Nieto", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("22/02/1989 22:10:00"), Monoparental = true  },
                new Registro { RegistroID = 22, NumeroIdentificacion = "EX3297", Nombre = "José", Apellido = "Expósito", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("18/05/1997 05:50:00"), Monoparental = true  },
                new Registro { RegistroID = 23, NumeroIdentificacion = "AS6234", Nombre = "María", Apellido = "Álvarez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("23/01/1998 11:35:00"), Monoparental = true  },
                new Registro { RegistroID = 24, NumeroIdentificacion = "MD4189", Nombre = "Pablo", Apellido = "Martínez", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("12/06/1999 19:15:00"), Monoparental = true  },
                new Registro { RegistroID = 25, NumeroIdentificacion = "CM8215", Nombre = "Elena", Apellido = "Cabrera", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("08/08/1995 08:20:00"), Monoparental = true  },
                new Registro { RegistroID = 26, NumeroIdentificacion = "NC5328", Nombre = "Francisco", Apellido = "Navarro", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("28/03/1996 15:10:00"), Monoparental = true  },
                new Registro { RegistroID = 27, NumeroIdentificacion = "RI7351", Nombre = "Sara", Apellido = "Rivas", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("05/12/1997 04:45:00"), Monoparental = true  },
                new Registro { RegistroID = 28, NumeroIdentificacion = "MD9462", Nombre = "Manuel", Apellido = "Díaz", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("16/02/1998 16:30:00"), Monoparental = true  },
                new Registro { RegistroID = 29, NumeroIdentificacion = "AS2809", Nombre = "Laura", Apellido = "Asturias", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("28/07/1999 09:55:00"), Monoparental = true  },
                new Registro { RegistroID = 30, NumeroIdentificacion = "AR6792", Nombre = "Javier", Apellido = "Aragón", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("12/09/1996 13:45:00"), Monoparental = true  },
                new Registro { RegistroID = 31, NumeroIdentificacion = "CL5421", Nombre = "Lucía", Apellido = "Castillo", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("10/01/1997 08:15:00"), Monoparental = false  },
                new Registro { RegistroID = 32, NumeroIdentificacion = "EX8374", Nombre = "Miguel", Apellido = "Expósito", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("09/03/1998 17:25:00"), Monoparental = false  },
                new Registro { RegistroID = 33, NumeroIdentificacion = "AS3748", Nombre = "Carmen", Apellido = "Álvarez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("22/11/1995 10:50:00"), Monoparental = false  },
                new Registro { RegistroID = 34, NumeroIdentificacion = "MD1765", Nombre = "David", Apellido = "Martínez", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("19/04/1996 12:40:00"), Monoparental = false  },
                new Registro { RegistroID = 35, NumeroIdentificacion = "NC3592", Nombre = "Lucía", Apellido = "Nicolás", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("08/08/1996 13:45:00"), Monoparental = true  },
                new Registro { RegistroID = 36, NumeroIdentificacion = "AN3621", Nombre = "Rubén", Apellido = "Andrés", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("29/01/1995 06:20:00"), Monoparental = false  },
                new Registro { RegistroID = 37, NumeroIdentificacion = "CB3748", Nombre = "Sara", Apellido = "Cabañas", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("11/12/1997 17:55:00"), Monoparental = false  },
                new Registro { RegistroID = 38, NumeroIdentificacion = "AR3810", Nombre = "Adrián", Apellido = "Arroyo", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("16/09/1996 08:30:00"), Monoparental = false  },
                new Registro { RegistroID = 39, NumeroIdentificacion = "RI3972", Nombre = "Ana", Apellido = "Rivas", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("03/02/1998 23:05:00"), Monoparental = true  },
                new Registro { RegistroID = 40, NumeroIdentificacion = "AS4058", Nombre = "Daniel", Apellido = "Astorga", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("19/06/1995 11:40:00"), Monoparental = true  },
                new Registro { RegistroID = 41, NumeroIdentificacion = "CL4125", Nombre = "Eva", Apellido = "Clavijo", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("27/03/1997 02:15:00"), Monoparental = false  },
                new Registro { RegistroID = 42, NumeroIdentificacion = "CE4291", Nombre = "Javier", Apellido = "Ceballos", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("04/09/1996 19:50:00"), Monoparental = true  },
                new Registro { RegistroID = 43, NumeroIdentificacion = "SA4378", Nombre = "Lucía", Apellido = "Salas", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("13/01/1995 10:25:00"), Monoparental = true  },
                new Registro { RegistroID = 44, NumeroIdentificacion = "CB4443", Nombre = "Mario", Apellido = "Cobos", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("22/07/1998 01:00:00"), Monoparental = false  },
                new Registro { RegistroID = 45, NumeroIdentificacion = "AS4523", Nombre = "Sofía", Apellido = "Astorga", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("10/02/1996 15:10:00"), Monoparental = false  },
                new Registro { RegistroID = 46, NumeroIdentificacion = "MC6512", Nombre = "Carmen", Apellido = "Mancera", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("23/06/1994 09:30:00"), Monoparental = true  },
                new Registro { RegistroID = 47, NumeroIdentificacion = "GA5487", Nombre = "Gabriel", Apellido = "Gálvez", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("12/11/1997 11:45:00"), Monoparental = true  },
                new Registro { RegistroID = 48, NumeroIdentificacion = "CT1349", Nombre = "Teresa", Apellido = "Castaño", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("04/04/1999 18:20:00"), Monoparental = false  },
                new Registro { RegistroID = 49, NumeroIdentificacion = "CV6652", Nombre = "Víctor", Apellido = "Calvo", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("19/09/1996 22:00:00"), Monoparental = false  },
                new Registro { RegistroID = 50, NumeroIdentificacion = "PV2179", Nombre = "Valeria", Apellido = "Pérez", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("30/12/1995 05:15:00"), Monoparental = false  },
                new Registro { RegistroID = 51, NumeroIdentificacion = "RI7721", Nombre = "Ignacio", Apellido = "Rivas", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("08/07/1998 16:55:00"), Monoparental = false  },
                new Registro { RegistroID = 52, NumeroIdentificacion = "NC1884", Nombre = "Cristina", Apellido = "Nava", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("17/03/1997 14:40:00"), Monoparental = true  },
                new Registro { RegistroID = 53, NumeroIdentificacion = "AN3558", Nombre = "Noelia", Apellido = "Andrade", Sexo = 'F', FechaNacimiento = Convert.ToDateTime("27/05/1995 08:00:00"), Monoparental = true  },
                new Registro { RegistroID = 54, NumeroIdentificacion = "CM4736", Nombre = "Manuel", Apellido = "Cáceres", Sexo = 'M', FechaNacimiento = Convert.ToDateTime("11/09/1999 11:30:00"), Monoparental = false  },
                            };
            modelBuilder.Entity<Registro>().HasData(registros);
        }
    }
}

USE [master]
GO
/****** Object:  Database [Laboratorio]    Script Date: 14/10/2022 10:15:18 a. m. ******/
CREATE DATABASE [Laboratorio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Laboratorio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Laboratorio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Laboratorio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Laboratorio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Laboratorio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Laboratorio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Laboratorio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Laboratorio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Laboratorio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Laboratorio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Laboratorio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Laboratorio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Laboratorio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Laboratorio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Laboratorio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Laboratorio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Laboratorio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Laboratorio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Laboratorio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Laboratorio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Laboratorio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Laboratorio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Laboratorio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Laboratorio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Laboratorio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Laboratorio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Laboratorio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Laboratorio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Laboratorio] SET RECOVERY FULL 
GO
ALTER DATABASE [Laboratorio] SET  MULTI_USER 
GO
ALTER DATABASE [Laboratorio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Laboratorio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Laboratorio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Laboratorio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Laboratorio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Laboratorio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Laboratorio', N'ON'
GO
ALTER DATABASE [Laboratorio] SET QUERY_STORE = OFF
GO
USE [Laboratorio]
GO
/****** Object:  Table [dbo].[Atención_Nacional]    Script Date: 14/10/2022 10:15:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atención_Nacional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sucursal] [nchar](25) NULL,
	[Dirección] [nchar](25) NULL,
	[Teléfono] [nchar](10) NULL,
	[Email] [nchar](40) NULL,
 CONSTRAINT [PK_Atención_Nacional] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrega_Resultados]    Script Date: 14/10/2022 10:15:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrega_Resultados](
	[IdSucursal] [int] NULL,
	[Semana] [nchar](40) NULL,
	[FinDeSemana] [nchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examen]    Script Date: 14/10/2022 10:15:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen](
	[Id] [nchar](50) NOT NULL,
	[TipoExamen] [nchar](50) NULL,
	[Costo] [nchar](10) NULL,
 CONSTRAINT [PK_Examen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 14/10/2022 10:15:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nchar](10) NULL,
	[Contraseña] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro_examen]    Script Date: 14/10/2022 10:15:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro_examen](
	[NumeroOrden] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [nchar](20) NOT NULL,
	[Examen1] [nchar](50) NULL,
	[Costo_Ex1] [nchar](10) NULL,
	[Examen2] [nchar](50) NULL,
	[Costo_Ex2] [nchar](10) NULL,
	[Descuento] [nchar](10) NULL,
	[CostoFinal] [nchar](10) NULL,
 CONSTRAINT [PK_Registro_examen] PRIMARY KEY CLUSTERED 
(
	[NumeroOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro_paciente]    Script Date: 14/10/2022 10:15:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro_paciente](
	[NumIdentificación] [nchar](20) NOT NULL,
	[Nombres] [nchar](50) NULL,
	[TipoIdentificación] [nchar](30) NULL,
	[Género] [nchar](10) NULL,
	[FechaNacimiento] [nchar](15) NULL,
	[Edad] [int] NULL,
	[EstadoCivil] [nchar](15) NULL,
	[Dirección] [nchar](25) NULL,
	[Barrio] [nchar](20) NULL,
	[Teléfono] [nchar](10) NULL,
	[Ocupación] [nchar](15) NULL,
	[Escolaridad] [nchar](15) NULL,
	[EPS] [nchar](25) NULL,
	[Régimen] [nchar](15) NULL,
	[Email] [nchar](40) NULL,
	[Antecedentes] [nchar](20) NULL,
	[TelefonoEmergencia] [nchar](10) NULL,
 CONSTRAINT [PK_Registro_paciente] PRIMARY KEY CLUSTERED 
(
	[NumIdentificación] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Toma_de_muestras]    Script Date: 14/10/2022 10:15:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Toma_de_muestras](
	[IdSucursal] [int] NULL,
	[Semana] [nchar](50) NULL,
	[FinDeSemana] [nchar](30) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Atención_Nacional] ON 

INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (1, N'Cali                     ', N'Cr 44 N° 5B-57           ', N'5517128   ', N'sucursalcali@gmail.com                  ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (2, N'Apartadó                 ', N'Cr 100 # 88 21           ', N'8281931   ', N'sucursalapartadó@gmail.com              ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (5, N'Rionegro                 ', N'Cl 43 Av Galán No. 54    ', N'5314444   ', N'sucursalrionegro@gmail.com              ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (6, N'Envigado                 ', N'Cr 43A No. 36            ', N'5737822   ', N'sucursalenvigado@gmail.com              ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (7, N'Ibagué                   ', N'Cr 5 No. 31-72           ', N'2648791   ', N'sucursalibagué@gmail.com                ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (8, N'Bogotá                   ', N'Av Cr 19 # 104-37        ', N'2488986   ', N'sucursalbogotá@gmail.com                ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (9, N'Cúcuta                   ', N'Cl 15 N° 1E-62           ', N'5830132   ', N'sucursalcúcuta@gmail.com                ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (10, N'Bucaramanga              ', N'Cr 35A No. 48-75         ', N'6477870   ', N'sucursalbucaramanga@gmail.com           ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (11, N'Valledupar               ', N'Cl 16 N° 10-37           ', N'5745129   ', N'sucursalvalledupar@gmail.com            ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (12, N'Pasto                    ', N'25 # 20-45               ', N'7227558   ', N'sucursalpasto@gmail.com                 ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (13, N'Cartago                  ', N'Cl 14 N° 1-22N           ', N'2125353   ', N'sucursalcartago@gmail.com               ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (15, N'Villavicencio            ', N'Cr 32 N° 38-18           ', N'6626000   ', N'sucursalvillavicencio@gmail.com         ')
INSERT [dbo].[Atención_Nacional] ([Id], [Sucursal], [Dirección], [Teléfono], [Email]) VALUES (16, N'Neiva                    ', N'Cr 5 N° 21A-72           ', N'8710590   ', N'sucursalneiva @gmail.com                ')
SET IDENTITY_INSERT [dbo].[Atención_Nacional] OFF
GO
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (1, N'6:00 a.m - 5:00 p.m Jornada continua    ', N'12:00 a.m - 5:00 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (2, N'6:30 a.m - 5:00 p.m Jornada continua    ', N'1:00 p.m - 5:00 p.m           ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (5, N'7:00 a.m - 5:00 p.m Jornada continua    ', N'12:30 a.m - 5:00 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (6, N'6:00 a.m - 6:00 p.m Jornada continua    ', N'1:00 a.m - 6:00 p.m           ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (7, N'6:30 a.m - 6:00 p.m Jornada continua    ', N'12:00 a.m - 6:00 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (8, N'5:30 a.m - 6:00 p.m Jornada continua    ', N'12:00 a.m - 5:30 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (9, N'8:00 a.m - 5:00 p.m Jornada continua    ', N'1:00 a.m - 5:00 p.m           ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (10, N'7:30 a.m - 5:00 p.m Jornada continua    ', N'12:00 a.m - 6:00 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (11, N'8:00 a.m - 6:00 p.m Jornada continua    ', N'1:00 p.m - 5:00 p.m           ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (12, N'7:30 a.m - 6:00 p.m Jornada continua    ', N'12:00 a.m - 6:00 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (13, N'7:00 a.m - 5:00 p.m Jornada continua    ', N'1:00 p.m - 5:00 p.m           ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (15, N'8:00 a.m - 5:30 p.m Jornada continua    ', N'12:30 a.m - 5:00 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (16, N'7:30 a.m - 6:00 p.m Jornada continua    ', N'12:00 a.m - 6:00 p.m          ')
INSERT [dbo].[Entrega_Resultados] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (NULL, N'N/A                                     ', N'N/A                           ')
GO
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'1                                                 ', N'SARS CoV2 [COVID-19] Anticuerpos Ig G             ', N'117000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'10                                                ', N'Dimero D Automatizado                             ', N'248000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'11                                                ', N'Nitrógeno Ureico En Sangre (Bun)                  ', N'293000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'12                                                ', N'Gases Arteriales (En Reposo O En Ejercicio)       ', N'280000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'13                                                ', N'Deshidrogenasa Láctica                            ', N'193000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'14                                                ', N'Bilirrubinas Total Y Directa                      ', N'278000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'16                                                ', N'Transaminasa Glutámico-Pirúvica                   ', N'178000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'18                                                ', N'Transaminasa Glutámico Oxalacética                ', N'297000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'19                                                ', N'Troponina I Cuantitativa                          ', N'254000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'2                                                 ', N'SARS CoV2 [COVID-19] Anticuerpos Ig M             ', N'142000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'20                                                ', N'Electrocardiograma De Ritmo O De Superficie Sod   ', N'226000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'22                                                ', N'Imagenología en casos indicados                   ', N'294000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'23                                                ', N'Radiografía De Tórax                              ', N'261000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'24                                                ', N'Tomografía Computada De Tórax Simple              ', N'199000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'25                                                ', N'Ninguno                                           ', N'0         ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'26                                                ', NULL, N'0         ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'3                                                 ', N'SARS CoV2 [COVID-19] Antígeno                     ', N'135000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'4                                                 ', N'Influenza Antígeno                                ', N'290000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'5                                                 ', N'Adenovirus Antígeno                               ', N'153000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'6                                                 ', N'Virus Sincitial Respiratorio Antígeno             ', N'230000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'7                                                 ', N'Identificación Simultánea De Múltiples Patógenos  ', N'217000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'8                                                 ', N'Hemograma Completo (Hemograma IV)                 ', N'207000    ')
INSERT [dbo].[Examen] ([Id], [TipoExamen], [Costo]) VALUES (N'9                                                 ', N'Proteína C Reactiva Manual O Semiautomatizado     ', N'243000    ')
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([Id], [Usuario], [Contraseña]) VALUES (1, N'Usuario1  ', N'123456    ')
INSERT [dbo].[Login] ([Id], [Usuario], [Contraseña]) VALUES (2, N'Usuario2  ', N'2468      ')
INSERT [dbo].[Login] ([Id], [Usuario], [Contraseña]) VALUES (3, N'Usuario3  ', N'13579     ')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Registro_examen] ON 

INSERT [dbo].[Registro_examen] ([NumeroOrden], [IdPaciente], [Examen1], [Costo_Ex1], [Examen2], [Costo_Ex2], [Descuento], [CostoFinal]) VALUES (1, N'1244412             ', N'Nitrógeno Ureico En Sangre (Bun)                  ', N'293000    ', N'                                                  ', N'0         ', N'15        ', N'249050    ')
INSERT [dbo].[Registro_examen] ([NumeroOrden], [IdPaciente], [Examen1], [Costo_Ex1], [Examen2], [Costo_Ex2], [Descuento], [CostoFinal]) VALUES (2, N'                    ', N'                                                  ', N'          ', N'                                                  ', N'          ', N'          ', N'          ')
INSERT [dbo].[Registro_examen] ([NumeroOrden], [IdPaciente], [Examen1], [Costo_Ex1], [Examen2], [Costo_Ex2], [Descuento], [CostoFinal]) VALUES (3, N'                    ', N'                                                  ', N'          ', N'                                                  ', N'          ', N'          ', N'          ')
INSERT [dbo].[Registro_examen] ([NumeroOrden], [IdPaciente], [Examen1], [Costo_Ex1], [Examen2], [Costo_Ex2], [Descuento], [CostoFinal]) VALUES (4, N'1763464             ', N'Gases Arteriales (En Reposo O En Ejercicio)       ', N'280000    ', N'Transaminasa Glutámico Oxalacética                ', N'297000    ', N'15        ', N'490450    ')
SET IDENTITY_INSERT [dbo].[Registro_examen] OFF
GO
INSERT [dbo].[Registro_paciente] ([NumIdentificación], [Nombres], [TipoIdentificación], [Género], [FechaNacimiento], [Edad], [EstadoCivil], [Dirección], [Barrio], [Teléfono], [Ocupación], [Escolaridad], [EPS], [Régimen], [Email], [Antecedentes], [TelefonoEmergencia]) VALUES (N'                    ', N'CC                                                ', N'1937593                       ', N'          ', N'20/10/2004     ', 15, N'Soltero        ', N'cra 24 calle 32          ', N'San Javier          ', N'124125    ', N'Ninguna        ', N'Básica primaria', N'Sura                     ', N'Contributivo   ', N'email24@gmail.com                       ', N'Ninguno             ', N'33513623  ')
INSERT [dbo].[Registro_paciente] ([NumIdentificación], [Nombres], [TipoIdentificación], [Género], [FechaNacimiento], [Edad], [EstadoCivil], [Dirección], [Barrio], [Teléfono], [Ocupación], [Escolaridad], [EPS], [Régimen], [Email], [Antecedentes], [TelefonoEmergencia]) VALUES (N'0                   ', N'                                                  ', N'CC                            ', N'Masculino ', N'08/09/2001     ', 21, N'Separado       ', N'Cra 105 calle 27         ', N'Laureles            ', N'124235    ', N'Desempleado    ', N'Universitario  ', N'Sura                     ', N'Subsidiado     ', N'email.user@gmail.com                    ', N'Asma                ', N'12315362  ')
INSERT [dbo].[Registro_paciente] ([NumIdentificación], [Nombres], [TipoIdentificación], [Género], [FechaNacimiento], [Edad], [EstadoCivil], [Dirección], [Barrio], [Teléfono], [Ocupación], [Escolaridad], [EPS], [Régimen], [Email], [Antecedentes], [TelefonoEmergencia]) VALUES (N'12444               ', N'Nombre apellido                                   ', N'CC                            ', N'Masculino ', N'27/02/2001     ', 21, N'Separado       ', N'cra 23 calle32           ', N'Laureles            ', N'12524     ', N'ninguno        ', N'Maestría       ', N'Sura                     ', N'Contributivo   ', N'email@gmail.com                         ', N'Ninguno             ', N'1472      ')
INSERT [dbo].[Registro_paciente] ([NumIdentificación], [Nombres], [TipoIdentificación], [Género], [FechaNacimiento], [Edad], [EstadoCivil], [Dirección], [Barrio], [Teléfono], [Ocupación], [Escolaridad], [EPS], [Régimen], [Email], [Antecedentes], [TelefonoEmergencia]) VALUES (N'1244412             ', N'Nombre apellido                                   ', N'CC                            ', N'Masculino ', N'27/02/2001     ', 21, N'Separado       ', N'cra 23 calle32           ', N'Laureles            ', N'12524     ', N'Desempleado    ', N'Maestría       ', N'Sura                     ', N'Contributivo   ', N'email@gmail.com                         ', N'Ninguno             ', N'1472      ')
INSERT [dbo].[Registro_paciente] ([NumIdentificación], [Nombres], [TipoIdentificación], [Género], [FechaNacimiento], [Edad], [EstadoCivil], [Dirección], [Barrio], [Teléfono], [Ocupación], [Escolaridad], [EPS], [Régimen], [Email], [Antecedentes], [TelefonoEmergencia]) VALUES (N'12463245            ', N'Nombre1 Apellido1                                 ', N'CC                            ', N'Masculino ', N'02/06/2001     ', 21, N'Soltero        ', N'Cra 108 45A-60           ', N'San Javier          ', N'1234342   ', N'Ninguna        ', N'Bachiller      ', N'Nueva EPS                ', N'Subsidiado     ', N'Email1@gmail.com                        ', N'Ninguno             ', N'235263    ')
INSERT [dbo].[Registro_paciente] ([NumIdentificación], [Nombres], [TipoIdentificación], [Género], [FechaNacimiento], [Edad], [EstadoCivil], [Dirección], [Barrio], [Teléfono], [Ocupación], [Escolaridad], [EPS], [Régimen], [Email], [Antecedentes], [TelefonoEmergencia]) VALUES (N'1626135             ', N'nombre apellido                                   ', N'CC                            ', N'Femenino  ', N'21/06/2000     ', 22, N'Soltero        ', N'Cra 16 calle 36          ', N'San Antonio         ', N'13623223  ', N'Desempleada    ', N'Técnico        ', N'Sura                     ', N'Contributivo   ', N'Email3@gmail.com                        ', N'Ninguno             ', N'12563     ')
INSERT [dbo].[Registro_paciente] ([NumIdentificación], [Nombres], [TipoIdentificación], [Género], [FechaNacimiento], [Edad], [EstadoCivil], [Dirección], [Barrio], [Teléfono], [Ocupación], [Escolaridad], [EPS], [Régimen], [Email], [Antecedentes], [TelefonoEmergencia]) VALUES (N'1763464             ', N'nombre12 apellido                                 ', N'CC                            ', N'Masculino ', N'14/02/2001     ', 21, N'Soltero        ', N'Cr 185 #12-45            ', N'20 de julio         ', N'532353    ', N'ninguna        ', N'Técnico        ', N'Sura                     ', N'Contributivo   ', N'12@gmail.com                            ', N'Ninguno             ', N'2412312   ')
GO
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (1, N'6:00 a.m - 12:00 a.m y 2:00 p.m - 5:00 p.m        ', N'6:00 a.m - 1:00 p.m           ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (2, N'6:00 a.m - 11:00 a.m y 1:00 p.m - 5:00 p.m        ', N'No hay atención               ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (5, N'6:00 a.m - 11:00 a.m y 1:00 p.m - 5:00 p.m        ', N'No hay atención               ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (6, N'6:00 a.m - 11:00 a.m y 1:00 p.m - 5:00 p.m        ', N'No hay atención               ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (7, N'6:00 a.m - 12:00 a.m y 2:00 p.m - 5:00 p.m        ', N'7:00 a.m - 12:00 a.m          ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (8, N'6:00 a.m - 12:00 a.m y 2:00 p.m - 5:00 p.m        ', N'6:00 a.m - 1:00 p.m           ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (9, N'6:00 a.m - 11:00 a.m y 1:00 p.m - 5:00 p.m        ', N'No hay atención               ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (10, N'6:00 a.m - 12:00 a.m y 2:00 p.m - 5:00 p.m        ', N'7:00 a.m - 12:00 a.m          ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (11, N'6:00 a.m - 11:00 a.m y 1:00 p.m - 5:00 p.m        ', N'No hay atención               ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (12, N'6:00 a.m - 11:00 a.m y 1:00 p.m - 5:00 p.m        ', N'6:00 a.m - 1:00 p.m           ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (13, N'6:00 a.m - 12:00 a.m y 2:00 p.m - 5:00 p.m        ', N'7:00 a.m - 12:00 a.m          ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (15, N'6:00 a.m - 12:00 a.m y 2:00 p.m - 5:00 p.m        ', N'6:00 a.m - 1:00 p.m           ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (16, N'6:00 a.m - 11:00 a.m y 1:00 p.m - 5:00 p.m        ', N'No hay atención               ')
INSERT [dbo].[Toma_de_muestras] ([IdSucursal], [Semana], [FinDeSemana]) VALUES (NULL, N'N/A                                               ', N'N/A                           ')
GO
ALTER TABLE [dbo].[Entrega_Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Entrega_Resultados_Atención_Nacional] FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Atención_Nacional] ([Id])
GO
ALTER TABLE [dbo].[Entrega_Resultados] CHECK CONSTRAINT [FK_Entrega_Resultados_Atención_Nacional]
GO
ALTER TABLE [dbo].[Registro_examen]  WITH CHECK ADD  CONSTRAINT [FK_Registro_examen_Registro_paciente] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Registro_paciente] ([NumIdentificación])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registro_examen] CHECK CONSTRAINT [FK_Registro_examen_Registro_paciente]
GO
ALTER TABLE [dbo].[Toma_de_muestras]  WITH CHECK ADD  CONSTRAINT [FK_Toma_de_muestras_Atención_Nacional] FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Atención_Nacional] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Toma_de_muestras] CHECK CONSTRAINT [FK_Toma_de_muestras_Atención_Nacional]
GO
USE [master]
GO
ALTER DATABASE [Laboratorio] SET  READ_WRITE 
GO

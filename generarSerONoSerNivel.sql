CREATE DATABASE [SerONoSer]
USE [SerONoSer]
GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 16/12/2019 20:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[NumPregunta] [int] NOT NULL,
	[Enunciado] [nvarchar](100) NOT NULL,
	[Nivel] [int] NOT NULL,
 CONSTRAINT [PK_TPreguntas] PRIMARY KEY CLUSTERED 
(
	[NumPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RespNoValidas]    Script Date: 16/12/2019 20:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RespNoValidas](
	[NumPregunta] [int] NOT NULL,
	[NumRespuesta] [int] NOT NULL,
	[Explicacion] [nvarchar](100) NULL,
 CONSTRAINT [PK_TRespNoValidas] PRIMARY KEY CLUSTERED 
(
	[NumPregunta] ASC,
	[NumRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuestas]    Script Date: 16/12/2019 20:24:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuestas](
	[NumPregunta] [int] NOT NULL,
	[NumRespuesta] [int] NOT NULL,
	[PosibleRespuesta] [nvarchar](100) NOT NULL,
	[Valida] [bit] NOT NULL,
 CONSTRAINT [PK_TRespuestas] PRIMARY KEY CLUSTERED 
(
	[NumPregunta] ASC,
	[NumRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (10, N'Premios nobel de la Paz',3)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (21, N'GR que pasan por Navarra',3)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (32, N'Lugares y Provincias a la que pertenecen',2)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (43, N'Películas y países',4)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (58, N'Locuciones y frases latinas',2)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (65, N'Indica las palabras que estén bien escritas',1)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (80, N'Obras de Dalí',1)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (100, N'De la vida de Frida Kahlo',2)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (120, N'"Parejas" famosas',1)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (131, N'Parques naturales y lugar en que se encuentran',1)
INSERT [dbo].[Preguntas] ([NumPregunta], [Enunciado],[Nivel]) VALUES (142, N'Autoras y obras',1)
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (10, 6, N'No fue en 2005 sino en  1997')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (10, 8, N'En 1942 no se otorgó a nadie este premio, Henderson lo recibió en 1934')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (10, 9, N'1966 J. F. Kennedy murió en 1963 y nunca recibió el Premio Nobel')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (10, 10, N'Gabriel García Marquez recibió en 1982 el de literatura,  no este')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (21, 1, N'Es de Madrid')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (21, 3, N'Pasa por Galicia')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (21, 6, N'Pasa por Madrid')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (21, 9, N'No  existe')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (32, 1, N'Alba de Tormes es de Salamanca')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (32, 4, N'Escalona es de Toledo')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (32, 7, N'Estepona pertenece a Málaga')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (32, 8, N'Figueres es de Girona')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (43, 1, N'Syriana es EEUU')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (43, 5, N'Es de Canadá')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (43, 7, N'Gran Bretaña')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (43, 10, N'EEUU')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (58, 1, N'pienso luego existo')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (58, 5, N'de derecho y de hecho')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (58, 7, N'¿A dónde vas?')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (58, 10, N'en el mismo lugar')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (65, 1, N'rabia')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (65, 3, N'pivote')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (65, 6, N'estricto/a')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (65, 11, N'dragón')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (80, 1, N'Es de Picasso')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (80, 5, N'Es de Joan Miró')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (80, 6, N'Es de Frida Kahlo')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (80, 9, N'Es de la pintora francesa Berthe Morisot')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (100, 5, N'Erróneo: estaba muy orgulloso de la inteligencia de su hija')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (100, 7, N'Frida no tuvo hijos')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (100, 10, N'El nombre es "La casa azul"')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (100, 12, N'Al contrario, ambos tuvieron varios amantes')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (120, 5, N'Es Marco Antonio')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (120, 7, N'Es Malinche (Doña Marina) y Hernán Cortes')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (120, 10, N'Es Isabel I y Fernando II')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (120, 11, N'Es Diego Rivera')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (131, 4, N'Está en Lleida')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (131, 6, N'El nombre es: Cabañeros')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (131, 8, N'Es en Palma')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (131, 10, N'Está en Gomera')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (142, 4, N'El título es: Extraños en un tren')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (142, 5, N'La obra es: La función delta')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (142, 6, N'Su nombre es Isabel Allende')
INSERT [dbo].[RespNoValidas] ([NumPregunta], [NumRespuesta], [Explicacion]) VALUES (142, 7, N'Autora: Elizabeth Burgos')
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 1, N'1992 Rigoberta Menchú (Guatemala)', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 2, N'1993 Nelson Mandela y  F. Willem Klerk (Sudáfrica)', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 3, N'1989 Dalai Lama (Tíbet)', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 4, N'1979 Madre Teresa de Calcuta (India)', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 5, N'1964 Martin Luther King (EEUU)', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 6, N'2005 Campaña Internacional contra Minas Antipersonas', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 7, N'2003 Shirin Ebadi (Irán)', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 8, N'1942 Henderson, Arthur (Gran Bretaña)', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 9, N'1966 J. F. Kennedy (EEUU)', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 10, N'1998 Gabriel García Marquez', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 11, N'1999 Médicos Sin Fronteras', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (10, 12, N'1984 Desmond Tutu (Sudáfrica)', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 1, N'GR124 Senda Real', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 2, N'GR11 Senda Pirenaica', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 3, N'GR50 Rota de Medievo', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 4, N'GR12 Sendero de EuskalHerria', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 5, N'GR1 Sendero Histórico', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 6, N'GR88 Pontón de la Oliva - Cerezo de Abajo', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 7, N'GR21 Camino Ignaciano-Javier Loiola', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 8, N'GR20 Vuelta a Aralar-Aralarko Bira', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 9, N'GR220 Senda Navarra', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 10, N'GR9 Cañada Real de las Provincias', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 11, N'GR65 Camino de Santiago', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (21, 12, N'GR13 Cañada Real de los Roncaleses', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 1, N'Alba de Tormes: Valladolid', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 2, N'Antequera: Málaga', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 3, N'Calatayud: Zaragoza', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 4, N'Escalona: Cuenca', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 5, N'Ciudad Rodrigo: Salamanca', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 6, N'Daroca: Zaragoza', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 7, N'Estepona: Granada', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 8, N'Figueres: Barcelona', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 9, N'Frías: Burgos', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 10, N'Guadalupe: Cáceres', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 11, N'Puentearenas: Burgos', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (32, 12, N'Olite: Navarra', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 1, N'Syriana: Canadá', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 2, N'Transamerica: EEUU', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 3, N'La fiesta del chivo: España', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 4, N'Sophie Scholl: Alemania', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 5, N'Lie with me: EEUU', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 6, N'El castillo ambulante: Japón', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 7, N'Orgullo y prejuicio: España', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 8, N'Agua: Canadá-India', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 9, N'Man Thing: EEUU-Australia', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 10, N'Casanova: Gran Bretaña', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 11, N'La vida secreta de las palabras: España', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (43, 12, N'La pantera rosa: EEUU', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 1, N'cogito, ergo sum : coge o suma', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 2, N'corpus delicti: cuerpo del delito', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 3, N'a priori: antes', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 4, N'ex profeso: a propósito', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 5, N'jure e facto: jura y sal', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 6, N'alter ego: otro yo', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 7, N'Quo vadis: Personaje romano', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 8, N'habeas corpus: presencia personal', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 9, N'honoris causa: por sus meritos', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 10, N'in situ: en la ciudad', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 11, N'Inri: Jesús Nazareno Rey de los Judios', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (58, 12, N'plus ultra: más allá', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 1, N'ravia', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 2, N'estrobo', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 3, N'pibote', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 4, N'borda', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 5, N'poyo', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 6, N'extricto/a', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 7, N'ideología', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 8, N'subconsciencia', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 9, N'tolva', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 10, N'malla', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 11, N'dragon', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (65, 12, N'tobogán', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 1, N'Las Señoritas d''Avignon', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 2, N'El hombre invisible', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 3, N'El gran masturbador', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 4, N'Monumento imperial a la mujer niña', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 5, N'Naturaleza muerta del viejo zapato', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 6, N'Las dos Fridas', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 7, N'Desmaterialización de la nariz de Nerón', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 8, N'Leda atómica', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 9, N'Mujer frente al espejo', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 10, N'El torero alucinógeno', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 11, N'Palacio del viento', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (80, 12, N'La silla', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 1, N'Murió en 1954 con 47 años', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 2, N'Vivió en México y EEUU', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 3, N'Estuvo casada con Diego Rivera', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 4, N'Mi obra: la más completa biografía que podría jamás hacerse sobre mí misma', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 5, N'Su padre no la dejó estudiar como a sus hermanos', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 6, N'Sufrió un terrible accidente de autobús que la marcó para siempre', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 7, N'Su hija mayor también se dedicó a la pintura', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 8, N'Le gustaba vestirse de hombre', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 9, N'"La columna rota" es uno de sus cuadros', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 10, N'Su casa es conocida como "La casa amarilla"', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 11, N'Generalmente vestía como indígena, con ropas de muchos colores', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (100, 12, N'El matrimonio Kahlo-Rivera siempre se caracterizó por su "fidelidad" sexual', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 1, N'El Quijote y Sancho Panza', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 2, N'Virginia Woolf y Leonard Woolf', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 3, N'Marie Sklodowska y Pierre Curie', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 4, N'Simone de Beauvoir y Jean-Paul Sartre', 1)
GO
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 5, N'Cleopatra y Marco Polo', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 6, N'Juana "La Loca" y Fernando "El Hermoso"', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 7, N'Malinche y Pizarro', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 8, N'Popeye y Olivia', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 9, N'Dalí y Gala', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 10, N'Isabel II de Castilla y Fernando IV de Aragón', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 11, N'Frida Kahlo y Joaquín Rivera', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (120, 12, N'El Gordo y El Flaco', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 1, N'"Las Arribes del Duero" en Salamanca y Zamora', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 2, N'"Ordesa y Monte Perdido" en Huesca', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 3, N'"Somiedo" en Asturies', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 4, N'"AigüesTortes i Estany de Sant Maurici" en Girona', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 5, N'"Picos de Europa" en Asturies, Cantabria y León', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 6, N'"Las Cabañas" en Ciudad Real y Toledo', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 7, N'"Islas Atlánticas" en A Coruña y Pontevedra', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 8, N'"Caldera de Taburiente" en Tenerife', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 9, N'"Tablas de Daimiel" en Ciudad Real', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 10, N'"Garajonay" en Guadalajara', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 11, N'"Timanfaya" en Lanzarote', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (131, 12, N'"Sierra Nevada" en Granada', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 1, N'Gioconda Belli: La mujer habitada', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 2, N'Lucía Etxeberria: Beatriz y los cuerpos celestes', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 3, N'Virginia Wolf: Las olas', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 4, N'Patricia Highsmith: Amigos en un tren', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 5, N'Rosa Montero: La función delta', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 6, N'Elisa Allende: La casa de los espíritus', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 7, N'Rigoberta Menchú: Me llamo Rigoberta Menchú y así me nació la conciencia', 0)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 8, N'Amy Tan: La hija del curandero', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 9, N'Jean M. Auel: El clan del oso cavernario', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 10, N'Fátima Mernissi: Sueños en el umbral', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 11, N'Jane Bowles: Dos damas muy serias', 1)
INSERT [dbo].[Respuestas] ([NumPregunta], [NumRespuesta], [PosibleRespuesta], [Valida]) VALUES (142, 12, N'Susana Tamaro: Donde el corazoón te lleve', 1)
ALTER TABLE [dbo].[Respuestas] ADD  CONSTRAINT [DF_Respuestas_Valida]  DEFAULT ((1)) FOR [Valida]
GO
ALTER TABLE [dbo].[RespNoValidas]  WITH CHECK ADD  CONSTRAINT [FK_TRespNoValidas_TRespuestas] FOREIGN KEY([NumPregunta], [NumRespuesta])
REFERENCES [dbo].[Respuestas] ([NumPregunta], [NumRespuesta])
GO
ALTER TABLE [dbo].[RespNoValidas] CHECK CONSTRAINT [FK_TRespNoValidas_TRespuestas]
GO
ALTER TABLE [dbo].[Respuestas]  WITH CHECK ADD  CONSTRAINT [FK_Respuestas_Preguntas] FOREIGN KEY([NumPregunta])
REFERENCES [dbo].[Preguntas] ([NumPregunta])
GO
ALTER TABLE [dbo].[Respuestas] CHECK CONSTRAINT [FK_Respuestas_Preguntas]
GO

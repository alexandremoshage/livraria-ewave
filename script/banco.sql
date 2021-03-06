USE [Livraria]
GO
/****** Object:  Table [dbo].[Livro]    Script Date: 13/04/2020 02:04:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livro](
	[LivroId] [int] IDENTITY(1,1) NOT NULL,
	[Genero] [varchar](max) NULL,
	[Descricao] [varchar](max) NULL,
	[Publicacao] [date] NULL,
	[Titulo] [varchar](max) NULL,
	[Editora] [varchar](max) NULL,
	[Sinopse] [varchar](max) NULL,
	[Paginas] [int] NULL,
	[Autor] [varchar](max) NULL,
 CONSTRAINT [PK_Livro] PRIMARY KEY CLUSTERED 
(
	[LivroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Livro] ON 

INSERT [dbo].[Livro] ([LivroId], [Genero], [Descricao], [Publicacao], [Titulo], [Editora], [Sinopse], [Paginas], [Autor]) VALUES (2, N'asfasdfsdfd', N'asdfasdfasdfasfasdfasdf', CAST(N'1993-10-20' AS Date), N'asdfasdfasdf', N'asdfasdf', N'asdfasdfasdfasdfasdf', 12, N'asdfasdf')
INSERT [dbo].[Livro] ([LivroId], [Genero], [Descricao], [Publicacao], [Titulo], [Editora], [Sinopse], [Paginas], [Autor]) VALUES (3, N'Terror', N'testesasdfasdf', CAST(N'2020-04-13' AS Date), N'aaaaaaaaaaaaaaaa', N'teste', NULL, 21, N'teste alexandre')
SET IDENTITY_INSERT [dbo].[Livro] OFF

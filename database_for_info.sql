USE [Seafood]
GO
/****** Object:  Table [dbo].[Infos]    Script Date: 4/28/2017 3:59:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Infos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[About] [nvarchar](max) NULL,
	[MainImage] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
 CONSTRAINT [PK_Infos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Infos] ON 

INSERT [dbo].[Infos] ([Id], [About], [MainImage], [Title]) VALUES (1, N'<div id="lipsum"><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ultricies, libero eget porta viverra, magna sem lacinia mi, dapibus euismod ante ipsum in nisi. Mauris non libero diam. Pellentesque auctor lorem nec leo molestie sodales. Aliquam semper ante in turpis sagittis rhoncus. Morbi ut justo vitae dolor porttitor pretium. Ut in facilisis ipsum, sed facilisis leo. Quisque aliquet justo justo, ac tristique neque porta sed.</p><p>Praesent fringilla, nulla vitae sagittis mattis, orci nisl sodales odio, quis vulputate enim nibh eget eros. Ut in dolor non dui condimentum ullamcorper ut eget dui. Morbi id leo cursus, luctus nibh sit amet, vestibulum nunc. Sed ac lacus sit amet erat auctor volutpat. Fusce ac justo tristique, viverra augue eu, fringilla lacus. Duis dapibus ligula in velit pretium rhoncus. Donec sed massa in risus congue tincidunt. Donec viverra lorem mattis risus dignissim, id ultrices ligula maximus. Morbi sed elit non elit dictum eleifend. Donec nisl eros, sodales at nulla in, ornare sollicitudin risus. Vestibulum sollicitudin justo lacinia nisi finibus vestibulum. Nulla feugiat nisi eu orci ultrices luctus. Proin vel condimentum felis, et tincidunt ipsum. Praesent tristique lectus non iaculis pharetra. Proin a porttitor odio, vel imperdiet felis. Praesent eu elit facilisis, malesuada ipsum eget, ultrices massa.</p><p>Morbi tortor urna, tristique sed vulputate nec, molestie sed augue. Aenean tincidunt ultricies tortor, ut interdum purus commodo eget. In at neque posuere erat molestie tincidunt. Nulla quis velit vel ante ultrices pellentesque. Vivamus mattis, ligula at imperdiet dapibus, justo sem porta diam, sit amet semper massa tortor at risus. Aliquam eget leo a nunc varius mattis. Nullam vel neque ac mauris tincidunt volutpat.</p><p>Nam eleifend leo sit amet molestie maximus. Pellentesque et metus quis sem hendrerit convallis. Mauris condimentum lectus lectus, a consectetur tortor sagittis non. Curabitur tempus sapien vitae ornare bibendum. Suspendisse eleifend nibh nec est posuere, id pretium arcu gravida. Donec sodales tincidunt velit, ornare sagittis ante auctor eget. Phasellus in turpis convallis, lacinia sapien a, dapibus elit. Nulla feugiat suscipit mauris, non molestie lacus mattis nec. Integer viverra efficitur lectus sit amet auctor. Vestibulum accumsan dolor lacus, sed molestie purus aliquam quis. Curabitur fermentum turpis nec condimentum euismod.</p><p>Vivamus pulvinar id est id rutrum. Nunc ut blandit nunc. Vivamus ac metus eu nisl auctor commodo vel sit amet ante. Donec blandit hendrerit arcu vitae efficitur. Cras eget condimentum elit, nec viverra nisl. In convallis sapien ut est dictum, at viverra lorem consectetur. Sed eu sapien ac magna fringilla lobortis sit amet vel justo. Nunc varius euismod urna, at volutpat dui mattis non. Vivamus velit nunc, semper vel finibus non, aliquet id dui. Vestibulum consectetur dui non nisi ornare, in rutrum quam luctus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Curabitur turpis velit, imperdiet vitae lobortis sed, finibus id dui. Pellentesque dapibus magna sit amet mi lobortis, sit amet ultrices arcu lobortis. Aenean velit purus, scelerisque in feugiat vitae, faucibus et lacus.</p></div>', N'http://www.royalasarlikbeach.com/files/20140219-12300588032.jpg', N'The best restaurant in Seattle')
SET IDENTITY_INSERT [dbo].[Infos] OFF

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M150EBusinessApplikation.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"USE [M150EBusinessApplikationDB]
GO
SET IDENTITY_INSERT [dbo].[Champions] ON 
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (1, N'Aatrox', N'images\\icons\\Aatrox.png', N'Runeterra', N'Male', N'Melee', N'Manaless', 20)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (2, N'Ahri', N'images\\icons\\Ahri.png', N'Ionia', N'Female', N'Ranged', N'Mana', 45)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (3, N'Akali', N'images\\icons\\Akali.png', N'Ionia', N'Female', N'Melee', N'Energy', 25)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (4, N'Akshan', N'images\\icons\\Akshan.png', N'Shurima', N'Male', N'Ranged', N'Mana', 10)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (5, N'Alistar', N'images\\icons\\Alistar.png', N'Runeterra', N'Male', N'Melee', N'Mana', 15)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (6, N'Amumu', N'images\\icons\\Amumu.png', N'Shurima', N'Male', N'Melee', N'Mana', 20)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (7, N'Anivia', N'images\\icons\\Anivia.png', N'Freljord', N'Female', N'Ranged', N'Mana', 25)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (8, N'Annie', N'images\\icons\\Annie.png', N'Runeterra', N'Female', N'Ranged', N'Mana', 10)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (9, N'Aphelios', N'images\\icons\\Aphelios.png', N'Targon', N'Male', N'Ranged', N'Mana', 15)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (10, N'Ashe', N'images\\icons\\Ashe.png', N'Freljord', N'Female', N'Ranged', N'Mana', 10)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (11, N'Aurelion Sol', N'images\\icons\\AurelionSol.png', N'Runeterra', N'Male', N'Ranged', N'Mana', 30)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (12, N'Azir', N'images\\icons\\Azir.png', N'Shurima', N'Male', N'Ranged', N'Mana', 35)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (13, N'Bard', N'images\\icons\\Bard.png', N'Runeterra', N'Male', N'Ranged', N'Mana', 50)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (14, N'Blitzcrank', N'images\\icons\\Blitzcrank.png', N'Zaun', N'Other', N'Melee', N'Mana', 25)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (15, N'Brand', N'images\\icons\\Brand.png', N'Runeterra', N'Male', N'Ranged', N'Mana', 15)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (16, N'Braum', N'images\\icons\\Braum.png', N'Freljord', N'Male', N'Melee', N'Mana', 20)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (17, N'Caitlyn', N'images\\icons\\Caitlyn.png', N'Piltover', N'Female', N'Ranged', N'Mana', 25)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (18, N'Camille', N'images\\icons\\Camille.png', N'Piltover', N'Female', N'Melee', N'Mana', 30)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (19, N'Cassiopeia', N'images\\icons\\Cassiopeia.png', N'Noxus', N'Female', N'Ranged', N'Mana', 20)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (20, N'Cho''gath', N'images\\icons\\Chogath.png', N'The Void', N'Male', N'Ranged', N'Mana', 15)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (21, N'Corki', N'images\\icons\\Corki.png', N'Bandle City', N'Male', N'Ranged', N'Mana', 10)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (22, N'Darius', N'images\\icons\\Darius.png', N'Noxus', N'Male', N'Melee', N'Mana', 30)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (23, N'Diana', N'images\\icons\\Diana.png', N'Targon', N'Female', N'Melee', N'Mana', 30)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (24, N'Dr. Mundo', N'images\\icons\\DrMundo.png', N'Zaun', N'Male', N'Melee', N'Health costs', 20)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (25, N'Draven', N'images\\icons\\Draven.png', N'Noxus', N'Male', N'Ranged', N'Mana', 25)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (26, N'Ekko', N'images\\icons\\Ekko.png', N'Zaun', N'Male', N'Melee', N'Mana', 10)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (27, N'Elise', N'images\\icons\\Elise.png', N'Shadow Isles', N'Female', N'Ranged', N'Mana', 10)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (28, N'Evelynn', N'images\\icons\\Evelynn.png', N'Runeterra', N'Female', N'Melee', N'Mana', 45)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (29, N'Ezreal', N'images\\icons\\Ezreal.png', N'Piltover', N'Male', N'Ranged', N'Mana', 35)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (30, N'Fiddlesticks', N'images\\icons\\Fiddlesticks.png', N'Runeterra', N'Other', N'Ranged', N'Mana', 20)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (31, N'Fiora', N'images\\icons\\Fiora.png', N'Demacia', N'Female', N'Melee', N'Mana', 40)
GO
INSERT [dbo].[Champions] ([Id], [Name], [ImageUrl], [Region], [Gender], [CombatStyle], [Resource], [Price]) VALUES (32, N'Fizz', N'images\\icons\\Fizz.png', N'Runeterra', N'Male', N'Melee', N'Mana', 25)
GO
SET IDENTITY_INSERT [dbo].[Champions] OFF
GO
SET IDENTITY_INSERT [dbo].[Heads] ON 
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (1, NULL, NULL, N'Horns', 1)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (2, N'Black', NULL, NULL, 2)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (3, N'Black', NULL, NULL, 3)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (4, N'Brown', NULL, NULL, 4)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (5, N'Black', NULL, N'Horns', 5)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (6, NULL, N'Bandages', NULL, 6)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (7, NULL, NULL, N'Ice', 7)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (8, N'Red', NULL, NULL, 8)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (9, N'Black', NULL, NULL, 9)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (10, N'White', N'Hood', NULL, 10)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (11, N'Blue', NULL, N'Horns', 11)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (12, NULL, N'Mask', NULL, 12)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (13, N'White', N'Mask', NULL, 13)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (14, NULL, NULL, N'Metal', 14)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (15, NULL, NULL, N'Fire', 15)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (16, NULL, NULL, N'Bold', 16)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (17, N'Dark Blue', N'Cylinder', NULL, 17)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (18, N'White', NULL, NULL, 18)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (19, NULL, N'Helmet', NULL, 19)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (20, NULL, NULL, N'Spikes', 20)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (21, NULL, N'Helmet', NULL, 21)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (22, N'Black', NULL, NULL, 22)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (23, N'White', N'Hairband', NULL, 23)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (24, N'Black', NULL, NULL, 24)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (25, N'Brown', N'Hairband', NULL, 25)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (26, N'White', NULL, NULL, 26)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (27, NULL, NULL, N'Spider thingies', 27)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (28, N'Pink', NULL, NULL, 28)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (29, N'Blonde', N'Goggles', NULL, 29)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (30, NULL, N'Bandages', N'', 30)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (31, N'Black Red', NULL, NULL, 31)
GO
INSERT [dbo].[Heads] ([Id], [Haircolor], [Headgear], [Other], [ChampionId]) VALUES (32, NULL, NULL, N'Fish ears', 32)
GO
SET IDENTITY_INSERT [dbo].[Heads] OFF
GO");
            migrationBuilder.Sql($"USE [M150EBusinessApplikationDB]\r\nGO\r\nINSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'admin', N'Admin', N'ADMIN', NULL)\r\nGO\r\nINSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'user', N'User', N'USER', NULL)\r\nGO\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

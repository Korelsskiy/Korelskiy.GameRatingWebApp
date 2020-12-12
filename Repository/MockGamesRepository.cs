using Korelskiy.NextBlazor.Enums;
using Korelskiy.NextBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.NextBlazor.Repository
{
    public class MockGamesRepository
    {
        public List<Game> Games { get; set; }

        public MockGamesRepository()
        {
            Games = new List<Game>()
            {
                new Game()
                {
                    Title = "The Elder Scrolls 5: Skyrim",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2011, 11, 11),
                    MainDeveloper = "Bethesda Game Studios",
                    Country = Country.USA,
                    KirillsPoints = Formula.Extension(8.3f,11363),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Grand Theft Auto 5",
                    Genre = "Action/Adventure",
                    ReleaseDate = new DateTime(2013, 09, 17),
                    MainDeveloper = "Rockstar North",
                    Country = Country.GB,
                    KirillsPoints = Formula.Extension(7.8f, 6770),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Grand Theft Auto 4",
                    Genre = "Action/Adventure",
                    ReleaseDate = new DateTime(2008, 04, 29),
                    MainDeveloper = "Rockstar North",
                    Country = Country.GB,
                    KirillsPoints = Formula.Extension(7.6f, 3845),
                    Platform = Platform.PS3
                },
                new Game()
                {
                    Title = "Minecraft",
                    Genre = "Sandbox/Survival",
                    ReleaseDate = new DateTime(2011, 11, 18),
                    MainDeveloper = "Mojang",
                    Country = Country.Sweden,
                    KirillsPoints = Formula.Extension(7.9f, 5897),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Grand Theft Auto: San Andreas",
                    Genre = "Action/Adventure",
                    ReleaseDate = new DateTime(2004, 10, 26),
                    MainDeveloper = "Rockstar North",
                    Country = Country.GB,
                    KirillsPoints = Formula.Extension(8.9f, 3130),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Assassin's Creed II",
                    Genre = "Action/Adventure/Stels",
                    ReleaseDate = new DateTime(2009, 11, 17),
                    MainDeveloper = "Ubisoft Montreal",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(7.4f, 2249),
                    Platform = Platform.PC
                },
                 new Game()
                {
                    Title = "Mass Effect 2",
                    Genre = "Action/RPG/TPS",
                    ReleaseDate = new DateTime(2010, 01, 26),
                    MainDeveloper = "BioWare",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(8.9f, 5003),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Mafia II",
                    Genre = "Action/Adventure",
                    ReleaseDate = new DateTime(2010, 08, 27),
                    MainDeveloper = "2K Czech",
                    Country = Country.Czhech,
                    KirillsPoints = Formula.Extension(8.2f, 2079),
                    Platform = Platform.PC
                },

                new Game()
                {
                    Title = "Far Cry 3",
                    Genre = "FPS",
                    ReleaseDate = new DateTime(2012, 11, 29),
                    MainDeveloper = "Ubisoft Montreal",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(8.3f, 4144),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Call of Duty: Modern Warfare 2",
                    Genre = "FPS",
                    ReleaseDate = new DateTime(2009, 11, 10),
                    MainDeveloper = "Infinity Ward",
                    Country = Country.USA,
                    KirillsPoints = Formula.Extension(4.5f, 6978),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Need for Speed: Most Wanted",
                    Genre = "Racing",
                    ReleaseDate = new DateTime(2005, 11, 25),
                    MainDeveloper = "EA Black Box",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(8.7f, 956),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Battlefield 3",
                    Genre = "FPS",
                    ReleaseDate = new DateTime(2011, 10, 28),
                    MainDeveloper = "EA DICE",
                    Country = Country.Sweden,
                    KirillsPoints = Formula.Extension(7.6f, 5316),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Mass Effect",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2007, 11, 20),
                    MainDeveloper = "BioWare",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(8.6f, 3451),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Mass Effect 3",
                    Genre = "Action/RPG/TPS",
                    ReleaseDate = new DateTime(2012, 03, 06),
                    MainDeveloper = "BioWare",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(5.9f, 6786),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Fallout 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2008, 10, 30),
                    MainDeveloper = "Bethesda Game Studios",
                    Country = Country.USA,
                    KirillsPoints = Formula.Extension(7.8f, 4486),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Assassin's Creed",
                    Genre = "Action/Adventure/Stels",
                    ReleaseDate = new DateTime(2007, 11, 13),
                    MainDeveloper = "Ubisoft Montreal",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(7.6f, 1316),
                    Platform = Platform.Xbox360
                },
                new Game()
                {
                    Title = "Portal 2",
                    Genre = "Puzzle-Platform",
                    ReleaseDate = new DateTime(2011, 04, 19),
                    MainDeveloper = "Valve",
                    Country = Country.USA,
                    KirillsPoints = Formula.Extension(9.1f, 7534),
                    Platform = Platform.PC
                },
                new Game()
                {
                    Title = "Dragon Age: Origins",
                    Genre = "RPG",
                    ReleaseDate = new DateTime(2009, 11, 03),
                    MainDeveloper = "BioWare",
                    Country = Country.Canada,
                    KirillsPoints = Formula.Extension(8.7f, 4396),
                    Platform = Platform.PC
                }
            };
        }
    }

}

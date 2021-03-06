﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using CampionatFussball;

namespace Backend
{
    public static class Utilities
    {
        /// <summary>
        /// Gets the input file path.
        /// </summary>
        /// <value>
        /// The input file path.
        /// </value>
        public static string DataBaseFilePath
        {
            get
            {
                var process = Process.GetCurrentProcess();
                var full_path = process.MainModule.FileName;
                var application_folder = full_path.Replace(@"\Frontend.exe", "");

                return $@"{application_folder}\Utilities\Players.txt";
            }
        }

        /// <summary>
        /// Gets the output file path.
        /// </summary>
        /// <value>
        /// The output file path.
        /// </value>
        public static string OutputFilePath
        {
            get
            {
                var process = Process.GetCurrentProcess();
                var full_path = process.MainModule.FileName;

                var application_folder = full_path.Replace(@"\CampionatFussball.exe", "");

                return $@"{application_folder}\Utilities\Tournament.txt";
            }
        }

        /// <summary>
        /// Gets the players styles list.
        /// </summary>
        /// <value>
        /// The players styles list.
        /// </value>
        public static List<Enums.PlayerStyle> PlayersStylesList =>
            new List<Enums.PlayerStyle>
            {
                Enums.PlayerStyle.Attack,
                Enums.PlayerStyle.Defend,
                Enums.PlayerStyle.Polyvalent
            };

        /// <summary>
        /// Shuffles the specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="List">The list.</param>
        public static void Shuffle<T>(this List<T> List)
        {
            var rng = new Random();
            var n = List.Count;
            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                var value = List[k];
                List[k] = List[n];
                List[n] = value;
            }
        }
    }
}

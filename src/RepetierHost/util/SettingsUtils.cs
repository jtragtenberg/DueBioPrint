﻿using RepetierHost.model;
using System;

namespace RepetierHost.util
{
    public class SettingsUtils
    {
        private const string SLIC3R_FOLDER = "Slic3r";
        private const string SLICER_MONO_FOLDER = ".Slic3r";
        private const string ENVIROMENT = "HOME";

        public static string GetSlic3rDirectory()
        {
            BasicConfiguration b = BasicConfiguration.basicConf;
            string cdir = b.Slic3rConfigDir;
            if (cdir.Trim().Length == 0)
            {
                if (Main.IsMono)
                {
                    cdir = FileUtils.CreatePath(Environment.GetEnvironmentVariable(ENVIROMENT), SLICER_MONO_FOLDER);
                    return cdir;
                }
                else
                {
                    cdir = FileUtils.CreatePath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SLIC3R_FOLDER);
                }
            }
            return cdir;
        }
    }
}
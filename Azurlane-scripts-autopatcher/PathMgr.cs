﻿using System.IO;
using System.Reflection;

namespace Azurlane
{
    internal static class PathMgr
    {
        internal static string Environment(string path = null)
        {
            if (path != null && !Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path == null ? Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) : Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), path);
        }

        internal static string Lua(string name) => Path.Combine(Temp("Unity_Assets_Files"), $@"{name}\CAB-android");

        internal static string Lua(string name, string lua) => Path.Combine(Lua(name), lua);

        internal static string Temp(string path = null) => path != null ? Path.Combine(Environment("Temp"), path) : Environment("Temp");

        internal static string Thirdparty(string path = null) => path != null ? Path.Combine(Environment("Thirdparty"), path) : Environment("Thirdparty");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NKPB
{
    public class Profile
    {
        public ProfileType Type { get; set; }
        public string Name { get; set; }
        public string Directory { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
    public enum ProfileType
    {
        Default,
        Temporary
    }
    internal static class ProfileManager
    {
        private static string GetBaseDirectory(ProfileType profileType)
        {
            var path = "";
            if (profileType == ProfileType.Default)
            {
                path = @".\profiles\default";
            }
            else if (profileType == ProfileType.Temporary)
            {
                path = @".\profiles\temporary";
            }
            if (path == "")
            {
                throw new ArgumentException("");
            }

            Directory.CreateDirectory(path);

            return path;
        }

        private static string GetMemoFilePath()
        {
            return $@"{GetBaseDirectory(ProfileType.Default)}\memo.txt";
        }

        public static void SaveMemo(string text)
        {
            File.WriteAllText(GetMemoFilePath(), text);
        }
        public static string LoadMemo()
        {
            var filePath = GetMemoFilePath();
            if (File.Exists(filePath) == false)
            {
                return string.Empty;
            }
            return File.ReadAllText(filePath);
        }

        public static Profile CreateNewTemporaryProfile()
        {
            return CreateNewProfile(ProfileType.Temporary, DateTime.Now.Ticks.ToString());
        }
        public static Profile CreateNewProfile(ProfileType profileType, string name = "")
        {
            string baseDirectory = GetBaseDirectory(profileType);

            if (profileType == ProfileType.Temporary)
            {
                name = DateTime.Now.Ticks.ToString();
            }
            else if (profileType == ProfileType.Default && string.IsNullOrEmpty(name) == true)
            {
                throw new ArgumentException("ProfileTypeがDefaultの場合には、nameの指定が必須");
            }

            Directory.CreateDirectory($@"{baseDirectory}\{name}");
            return new Profile()
            {
                Name = name,
                Type = profileType,
                Directory = $@"{baseDirectory}\{name}"
            };
        }

        public static Profile GetProfile(string name)
        {
            var prifiles = GetProfiles(ProfileType.Default);
            var profile = prifiles.FirstOrDefault(i => i.Name == name);
            return profile;
        }
        public static List<Profile> GetProfiles(ProfileType profileType)
        {
            var profileList = new List<Profile>();

            foreach (var dir in Directory.GetDirectories(GetBaseDirectory(profileType)))
            {
                profileList.Add(new Profile()
                {
                    Type = profileType,
                    Directory = dir,
                    Name = dir.Split('\\').Last()
                });
            }

            return profileList;
        }

        public static bool RemoveProfile(Profile profile)
        {
            try
            {
                Directory.Delete(profile.Directory, true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void RemoveProfiles(ProfileType profileType)
        {
            foreach (var path in Directory.GetDirectories(GetBaseDirectory(profileType)))
            {
                try
                {
                    Directory.Delete(path, true);
                }
                catch { }
            }
        }
    }
}

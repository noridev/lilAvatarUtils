using System.Globalization;
using UnityEditor;
using UnityEngine;

namespace moe.noridev.avatarutils
{
    [FilePath("moe.noridev/avatar-utils.asset", FilePathAttribute.Location.PreferencesFolder)]
    internal class AvatarUtilsSettings : ScriptableSingleton<AvatarUtilsSettings>
    {
        [Tooltip("The language setting for lilAvatarUtils. The language file exists in `moe.noridev.avatar-utils/Editor/Localization`, and you can support other languages by creating a language file.")]
        public string language = CultureInfo.CurrentCulture.Name;

        internal void Save() => Save(true);
    }
}

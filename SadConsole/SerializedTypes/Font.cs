﻿using System.Runtime.Serialization;

namespace SadConsole.SerializedTypes
{
    [DataContract]
    public class FontSerialized
    {
        [DataMember]
        public string Name;

        public static implicit operator FontSerialized(Font font) => new FontSerialized() { Name = font.Name };

        public static implicit operator Font(FontSerialized font) => Global.Fonts.ContainsKey(font.Name) ? Global.Fonts[font.Name] : Global.DefaultFont;
    }
}

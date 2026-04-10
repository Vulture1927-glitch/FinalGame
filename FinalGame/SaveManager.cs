using MyClasses;
using System;
using System.Collections.Generic;
using System.Text;
using MyClasses;
using System.Text.Json;
namespace MyClasses
{
    internal class SaveManager
    {
        public static void Save(Character entity)
        {
            string path = @"C:\Users\isaac.stumm\source\repos\FinalGame\FinalGame\CharacterSavePoint.json";
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string convert = JsonSerializer.Serialize(entity, options);
            File.WriteAllText(path, convert);
        }
        public static Character Load(string path)
        {
            string hero = File.ReadAllText(path);
            Character loadedChar = JsonSerializer.Deserialize<Character>(hero);
            Console.WriteLine(loadedChar);
            return loadedChar;
        }
    }
}

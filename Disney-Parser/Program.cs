// See https://aka.ms/new-console-template for more information
using Disney_Parser;

new VoiceParser().Parse(Directory.GetCurrentDirectory() + "\\disney_voice_actors.csv");
new CharacterParser().Parse(Directory.GetCurrentDirectory() + "\\disney_characters.csv");
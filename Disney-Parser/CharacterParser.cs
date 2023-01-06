using System.Globalization;

namespace Disney_Parser
{
    internal class CharacterParser
    {
        private readonly DatabaseManager databaseManager;

        public CharacterParser()
        {
            databaseManager = new();
        }

        public void Parse(string path)
        {
            string fileContent = File.ReadAllText(path);
            string[] lines = fileContent.Split(' ');
            foreach (string line in lines.Skip(1))
            {
                string[] elements = line.Split(',');
                string title = elements[1];
                DateTime releaseDate = DateTime.ParseExact(elements[2], "MMMM dd, yyyy", CultureInfo.GetCultureInfo("en-US"));
                int heroId = GetHero(elements[3]);
                string villain = elements[4];
                string song = elements[5];

                string query = $"INSERT INTO movies VALUES('','{title}','{releaseDate.ToString("yyyy-MM-dd")}',{heroId}, '{villain}', '{song}')";
                databaseManager.ExecuteQuery(query);
            }
        }

        private int GetHero(string v)
        {
            string query = $"SELECT id FROM characters WHERE Hero LIKE '%{v}%'";
            return databaseManager.GetVoiceActorId(query);
        }
    }
}

namespace QuestConverter.Models
{
    public class InputSettings
    {
        public string InputFileName { get; set; }
        public KeyGenerationMode KeyGeneration { get; set; }

    }

    public enum KeyGenerationMode
    {
        IdBased = 0,
        NameBased = 1
    }
}
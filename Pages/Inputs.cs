namespace Inputs
{
    public class Input
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string UniqueStyles { get; set; } = null!;
        public string Value { get; set; } = null!;

        public Input(string name, string type, string uniqueStyles, string value)
        {
            Name = name;
            Type = type;
            UniqueStyles = uniqueStyles;
            Value = value;
        }
    }
    
}
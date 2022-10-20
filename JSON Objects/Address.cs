
namespace TextEngine.Objects
{
    internal sealed class Address
    {
        public string? StreetAddress { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? PostalCode { get; set; }

        public override string ToString()
        {
            return $"{StreetAddress ?? @"N/A"}, {City ?? @"N/A"}, {State ?? @"N/A"}, {PostalCode ?? @"N/A"}";
        }
    }
}

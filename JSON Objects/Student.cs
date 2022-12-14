using System.Text;

namespace TextEngine.Objects
{
    internal sealed class Student
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public bool IsEnrolled { get; set; }

        public int YearsEnrolled { get; set; }

        public Address? Address1 { get; set; }

        public Address? Address2 { get; set; }

        public List<PhoneNumber>? PhoneNumbers { get; set; }

        private StringBuilder sb = new StringBuilder();

        public override string ToString()
        {
            sb.Append($"Name: {LastName ?? "Not available"}, {FirstName ?? "Not available"}\n");
            sb.Append(IsEnrolled ? "Student is currently enrolled.\n" : "Student is not enrolled.\n");
            sb.Append($"Student enrolled for {YearsEnrolled} years\n");
            sb.Append($"Primary Address: {Address1?.ToString() ?? "No primary address"}\n");
            sb.Append($"Secondary Address: {Address2?.ToString() ?? "No secondary address"}\n");
            for (int i = 0; i < PhoneNumbers?.Count; i++)
            {
                sb.Append($"Phone Number {i + 1}: {PhoneNumbers[i].ToString()}");
            }
            return sb.ToString();
        }
    }
}

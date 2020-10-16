using System.Collections.Generic;

namespace Chuck.Sonarqube
{
    public static class CustomHelper
    {
        public static List<string> MandatoryFields { get; } = new List<string>
        {
            "First name",
            "Last name"
        };
    }
}

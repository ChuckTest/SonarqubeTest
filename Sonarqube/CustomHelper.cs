using System.Collections.Generic;
using System.Collections.Immutable;

namespace SonarqubeTest
{
    public class CustomHelper
    {
        public static readonly List<string> MandatoryFields = new List<string>
        {
            "First name",
            "Last name"
        };

        public static ImmutableList<string> MandatoryFields2 = ImmutableList.Create(
            "First name",
            "Last name"
        );
    }
}

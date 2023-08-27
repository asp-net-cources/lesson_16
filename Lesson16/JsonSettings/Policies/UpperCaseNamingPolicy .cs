using System.Text.Json;

namespace Lesson16.JsonSettings.Policies;

public class UpperCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name) {
        return name.ToUpper();
    }
}

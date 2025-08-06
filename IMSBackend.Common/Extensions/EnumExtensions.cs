using System.ComponentModel;
using System.Reflection;

namespace IMSBackend.Common.Extensions;
public static class EnumExtensions
{
    public static string GetEnumDescription(this Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());
        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();

        return attribute == null ? value.ToString() : attribute.Description;
    }
}

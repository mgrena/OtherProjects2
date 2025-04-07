using Servier.Pressure.Data.Lists;
using Servier.Pressure.Data.Models;
using System.Reflection;

namespace Servier.Pressure.Helpers;

public class WorkplaceTypeWrapper
{
    public WorkplaceTypeEnum Value { get; set; }
    public required string DisplayText { get; set; }
}
public class SpecializationWrapper
{
    public SpecializationEnum Value { get; set; }
    public required string DisplayText { get; set; }
}
public class MonotherapyWrapper
{
    public MonotherapyEnum Value { get; set; }
    public required string DisplayText { get; set; }
}
public class AnswerWrapper
{
    public AnswerEnum Value { get; set; }
    public required string DisplayText { get; set; }
}
public class EvaluationWrapper
{
    public EvaluationEnum Value { get; set; }
    public required string DisplayText { get; set; }
}
public class TerminationReasonWrapper
{
    public TerminationReasonEnum Value { get; set; }
    public required string DisplayText { get; set; }
}

public static class EnumExtensions
{
    public static T? GetAttribute<T>(this Enum value) where T : Attribute
    {
        return value.GetType()
            .GetField(value.ToString())?
            .GetCustomAttribute<T>();
    }
}

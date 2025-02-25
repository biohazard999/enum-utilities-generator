﻿namespace EnumUtilitiesGenerator
{
    internal class Constants
    {
        public const string GENERATEHELPER_FULL_NAME = "GenerateHelperAttribute";
        public const string GENERATEHELPER_NAME = "GenerateHelper";

        public const string GENERATEHELPER_ATTRIBUTE = @"// <auto-generated />
using System;

[AttributeUsage(AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
public sealed class GenerateHelperAttribute : Attribute
{
    public GenerateHelperAttribute(GenerateHelperOption generationOption)
    {
        GenerationOption = generationOption;
    }

    public GenerateHelperOption GenerationOption { get; }
}

/// <summary>
/// Define the behaviour of the generated Helper class. All members with a not empty <see cref=""System.ComponentModel.DescriptionAttribute""/> 
/// will be mapped 1:1 as long as each member has an unique description. Each option will treat members without a valid 
/// <see cref=""System.ComponentModel.DescriptionAttribute""/> differently.
/// </summary>
public enum GenerateHelperOption
{
    /// <summary>
    /// Members without description will return null.
    /// </summary>
    IgnoreEnumWithoutDescription = 1,

    /// <summary>
    /// Members without description will throw an exception when requested.
    /// </summary>
    ThrowForEnumWithoutDescription = 2,

    /// <summary>
    /// Members without description will be mapped as themselves, equivalent to using nameof() or .ToString().
    /// </summary>
    UseItselfWhenNoDescription = 3
}";

        public const string NAMESPACE_TEMPLATE = @"// <auto-generated />
using System;

namespace {namespaceValue}
{
{classTemplate}
}";

        public const string CLASS_TEMPLATE = @"    public static class {enumName}Helper
    {
{methodTemplate}
    }";

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using CppSharp.AST;
using CppSharp.AST.Extensions;
using OpenNISharp2.CppSharpUnsafeGenerator.Definitions;

namespace OpenNISharp2.CppSharpUnsafeGenerator.Processors
{
    internal class EnumerationProcessor
    {
        private readonly ASTProcessor _context;

        public EnumerationProcessor(ASTProcessor context)
        {
            _context = context;
        }

        public EnumerationProcessor()
        {
        }

        public void Process(TranslationUnit translationUnit)
        {
            foreach (var enumeration in translationUnit.Enums)
            {
                if (!enumeration.Type.IsPrimitiveType()) throw new NotSupportedException();

                var enumerationName = enumeration.Name;
                if (string.IsNullOrEmpty(enumerationName))
                    MakeConstantDefinition(enumeration);
                else
                    MakeEnumerationDefinition(enumeration, enumerationName);
            }
        }

        public EnumerationDefinition MakeEnumerationDefinition(Enumeration enumeration, string name)
        {
            name = string.IsNullOrEmpty(enumeration.Name) ? name : enumeration.Name;
            var result = new EnumerationDefinition {Name = name};
            if (_context.IsKnownUnitName(name)) return result;
            _context.AddUnit(result);

            result.TypeName = TypeHelper.GetTypeName(enumeration.Type);
            result.Content = enumeration.Comment?.BriefText;
            result.Items = enumeration.Items
                .Select(x =>
                    new EnumerationItem
                    {
                        Name = x.Name,
                        Value = ConvertValue(x.Value, enumeration.BuiltinType.Type).ToString(),
                        Content = x.Comment?.BriefText
                    })
                .ToArray();
            return result;
        }

        public IEnumerable<ConstantDefinition> MakeConstantDefinition(Enumeration enumeration)
        {
            var result = new List<ConstantDefinition>();
            foreach (var item in enumeration.Items)
            {
                var name = item.Name;
                if (_context.IsKnownUnitName(name)) continue;
                var constant = new ConstantDefinition
                {
                    TypeName = TypeHelper.GetTypeName(enumeration.Type),
                    Name = name,
                    Value = ConvertValue(item.Value, enumeration.BuiltinType.Type).ToString(),
                    Content = item.Comment?.BriefText
                };
                _context.AddUnit(constant);
                result.Add(constant);
            }
            return result;
        }

        private static object ConvertValue(ulong value, PrimitiveType primitiveType)
        {
            switch (primitiveType)
            {
                case PrimitiveType.Int:
                    return (int) value;
                case PrimitiveType.UInt:
                    return (uint) value;
                case PrimitiveType.Long:
                    return (long) value;
                case PrimitiveType.ULong:
                    return value;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
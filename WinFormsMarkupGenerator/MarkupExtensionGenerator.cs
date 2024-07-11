using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WinFormsMarkupGenerator
{
    public class MarkupExtensionGenerator
    {
        public static Dictionary<string, string> GenerateExtensions(Assembly assembly)
        {
            var controlTypes = assembly.GetTypes()
                .Where(t => typeof(Control).IsAssignableFrom(t) && !t.IsAbstract && t.IsPublic);

            var result = new Dictionary<string, string>();

            foreach (var controlType in controlTypes)
            {
                var extensionsCode = GenerateExtensionsForType(controlType);
                result[controlType.Name] = extensionsCode;
            }

            return result;
        }

        private static string GenerateExtensionsForType(Type controlType)
        {
            var sb = new StringBuilder();
            var usings = new HashSet<string>
            {
                "using System;",
                "using System.Drawing;",
                "using System.Windows.Forms;",
                "using System.Windows.Forms.Design;"
            };

            var typeName = controlType.Name;

            sb.AppendLine("namespace WinFormsMarkup");
            sb.AppendLine("{");

            sb.AppendLine($"    public static class {typeName}Extensions");
            sb.AppendLine("    {");

            var properties = controlType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanWrite && !p.Name.Equals("Site") && !p.Name.Equals("Container"));

            foreach (var property in properties)
            {
                if (IsIndexerProperty(property))
                {
                    continue;
                }
                GenerateExtensionMethod(controlType, property, sb, usings);
            }

            var events = controlType.GetEvents(BindingFlags.Public | BindingFlags.Instance);
            foreach (var evt in events)
            {
                GenerateEventExtensionMethod(controlType, evt, sb, usings);
            }

            // Add AddTo method for all controls
            sb.AppendLine($"        public static {typeName} AddTo(this {typeName} control, Control parent)");
            sb.AppendLine("        {");
            sb.AppendLine("            parent.Controls.Add(control);");
            sb.AppendLine("            return control;");
            sb.AppendLine("        }");
            sb.AppendLine();

            // Add AddControls method for container controls
            if (typeof(ContainerControl).IsAssignableFrom(controlType))
            {
                sb.AppendLine($"        public static {typeName} AddControls(this {typeName} control, params Control[] controls)");
                sb.AppendLine("        {");
                sb.AppendLine("            control.Controls.AddRange(controls);");
                sb.AppendLine("            return control;");
                sb.AppendLine("        }");
                sb.AppendLine();
            }

            // Add Assign method for all controls
            sb.AppendLine($"        public static {typeName} Assign(this {typeName} control, out {typeName} variable)");
            sb.AppendLine("        {");
            sb.AppendLine("            variable = control;");
            sb.AppendLine("            return control;");
            sb.AppendLine("        }");
            sb.AppendLine();

            sb.AppendLine("    }");
            sb.AppendLine("}");

            // Add usings at the top
            var usingsString = string.Join(Environment.NewLine, usings);
            return $"{usingsString}{Environment.NewLine}{sb}";
        }

        private static void GenerateExtensionMethod(Type controlType, PropertyInfo property, StringBuilder sb, HashSet<string> usings)
        {
            var typeName = controlType.Name;
            var propertyName = property.Name;
            var propertyType = property.PropertyType;

            AddUsingDirective(propertyType, usings);

            if (property.CanWrite && property.SetMethod != null && property.SetMethod.IsPublic)
            {
                if (propertyType == typeof(Size))
                {
                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, int width, int height)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = new Size(width, height);");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, Size size)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = size;");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                }
                else if (propertyType == typeof(Point))
                {
                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, int x, int y)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = new Point(x, y);");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, Point point)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = point;");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                }
                else if (propertyType == typeof(Color))
                {
                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, int red, int green, int blue)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = Color.FromArgb(red, green, blue);");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, int red, int green, int blue, int alpha)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = Color.FromArgb(alpha, red, green, blue);");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, Color color)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = color;");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                }
                else if (propertyType == typeof(Font))
                {
                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, string familyName, float emSize, FontStyle style = FontStyle.Regular)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = new Font(familyName, emSize, style);");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, Font font)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = font;");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                }
                else if (propertyType == typeof(Rectangle))
                {
                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, int x, int y, int width, int height)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = new Rectangle(x, y, width, height);");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, Point location, Size size)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = new Rectangle(location, size);");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();

                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, Rectangle rectangle)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = rectangle;");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                }
                else
                {
                    sb.AppendLine($"        public static {typeName} {propertyName}(this {typeName} control, {GetFriendlyTypeName(propertyType)} value)");
                    sb.AppendLine("        {");
                    sb.AppendLine($"            control.{propertyName} = value;");
                    sb.AppendLine("            return control;");
                    sb.AppendLine("        }");
                    sb.AppendLine();
                }
            }
        }

        private static void GenerateEventExtensionMethod(Type controlType, EventInfo evt, StringBuilder sb, HashSet<string> usings)
        {
            var typeName = controlType.Name;
            var eventName = evt.Name;
            var eventHandlerType = evt.EventHandlerType;

            AddUsingDirective(eventHandlerType, usings);

            sb.AppendLine($"        public static {typeName} On{eventName}(this {typeName} control, {GetFriendlyTypeName(eventHandlerType)} handler)");
            sb.AppendLine("        {");
            sb.AppendLine($"            control.{eventName} += handler;");
            sb.AppendLine("            return control;");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void AddUsingDirective(Type type, HashSet<string> usings)
        {
            if (type.IsGenericType)
            {
                foreach (var arg in type.GetGenericArguments())
                {
                    AddUsingDirective(arg, usings);
                }
            }
            if (!string.IsNullOrEmpty(type.Namespace))
            {
                usings.Add($"using {type.Namespace};");
            }
        }

        private static string GetFriendlyTypeName(Type type)
        {
            if (type.IsGenericType)
            {
                var genericTypeName = type.GetGenericTypeDefinition().Name;
                genericTypeName = genericTypeName.Substring(0, genericTypeName.IndexOf('`'));
                var genericArgs = string.Join(", ", type.GetGenericArguments().Select(GetFriendlyTypeName));
                return $"{genericTypeName}<{genericArgs}>";
            }
            return type.Name;
        }

        private static bool IsIndexerProperty(PropertyInfo property)
        {
            return property.GetIndexParameters().Length > 0;
        }
    }
}

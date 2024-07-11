# WinForms Markup

WinForms Markup is an experimental project designed to provide a modern, declarative, and fluent approach to building C# WinForms applications. This library enhances existing WinForms controls using extension methods, allowing developers to quickly construct complex user interfaces with chained calls.

## Features

- **Modern WinForms Development**: Write WinForms apps with a clean, fluent API.
- **Automatic Code Generation**: Includes pre-generated extension methods for controls in `System.Windows.Forms`.
- **Improved Readability**: Simplify your WinForms code for better readability and maintainability.
- **Strong Typing and IntelliSense**: Maintain C# strong typing and enjoy full IntelliSense support.
- **Support for Common WinForms Features**: Easily manage layout, event handling, and more.

## Installation

> To be added.

## Usage

Here is a simple example demonstrating how to use WinForms Markup to build a user interface:

```csharp
using System;
using System.Windows.Forms;
using WinFormsMarkup;

public class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(BuildMainForm());
    }

    private static Form BuildMainForm()
    {
        int clickCount = 0;
        return new Form()
            .Text("WinForms Markup")
            .Size(800, 600)
            .FormBorderStyle(FormBorderStyle.Sizable)
            .AddControls(
                new Label()
                    .Text("Hello, WinFormsMarkup!")
                    .Anchor(AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right)
                    .Location(10, 10)
                    .Size(780, 30)
                    .Assign(out var label),
                new Button()
                    .Text("Click Me!")
                    .Location((800 - 100) / 2, 40)
                    .Size(100, 30)
                    .OnClick((sender, e) => label.Text = $"Clicked {++clickCount} times")
                    .Assign(out var button)
            )
            .OnResize((sender, e) => button.Location = new Point(((Form)sender).ClientSize.Width / 2 - button.Width / 2, button.Location.Y))
            .Assign(out var mainForm);
    }
}
```

## Hot Reload

WinForms Markup supports hot reload, allowing you to make changes to your WinForms application while it is running. This feature is useful for quickly iterating on your UI design without restarting the application.

**Note**: Hot reload is currently experimental and only supports single-form applications.

To enable hot reload, use `HotReloadApplicationContext` instead of `ApplicationContext` when running your application:

```csharp
Application.Run(new HotReloadApplicationContext(BuildMainForm));

static Form BuildMainForm()
{
    // Build your form here
}
```

When you run your application, you can now make changes to your form-building function and see the updates reflected in the running application.

## Extension Methods

WinForms Markup includes pre-generated extension methods for common WinForms controls, such as:

- **Property Setting**: Methods for setting common control properties
- **Event Handling**: Methods for handling common events
- **Layout Management**: Methods for managing control layout
- **Control Addition**: Methods for adding controls to containers
- **Style Setting**: Methods for setting control appearance
- **Resource Management**: Simplified usage of icons and images

## Generating Additional Extensions

If you need to generate extension methods for custom controls or other assemblies, you can use the WinForms Markup Generator. The generator processes a .NET assembly and generates extension methods for all public classes that inherit from `Control`.

### Usage

To use the WinForms Markup Generator, run the executable with the input and output file arguments. The input file should be a .NET assembly, and the output directory will contain the generated C# source files.

```
wmgen.exe [input file].dll [output directory]
```

### Example

```
wmgen.exe MyWinFormsApp.dll GeneratedExtensions
```

This will generate C# source files with extension methods for each control found in `MyWinFormsApp.dll` and save them in the `GeneratedExtensions` directory.

## Contributing

Contributions are welcome! If you have any suggestions or improvements, feel free to submit a pull request or open an issue.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Disclaimer

This project is experimental and primarily aimed at exploring and improving the WinForms development experience. Use it with caution in production environments and thoroughly test its stability and compatibility.
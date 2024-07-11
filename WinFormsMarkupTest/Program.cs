using WinFormsMarkup;

namespace WinFormsMarkupTest;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();
        Application.Run(new HotReloadApplicationContext(BuildMainForm));
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
                    .Text("Hello, WinForms Markup!")
                    .Anchor(AnchorStyles.Top | AnchorStyles.Left)
                    .Location(10, 10)
                    .Size(780, 20)
                    .Assign(out var label),
                new Button()
                    .Text("Click Me!")
                    .Location((800 - 300) / 2, 40)
                    .Size(300, 30)
                    .OnClick((sender, e) => label.Text = $"Clicked {++clickCount} times!")
            );
    }
}
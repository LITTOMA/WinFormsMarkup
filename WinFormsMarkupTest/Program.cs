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
        Application.Run(MainForm);
    }

    static Form MainForm =>
        BuildMainForm();

    private static Form BuildMainForm() =>
        new Form()
            .Text("WinForms Markup")
            .Size(800, 600)
            .FormBorderStyle(FormBorderStyle.Sizable)
            .AddControls(
                new Label()
                    .Text("Hello, WinFormsMarkup!")
                    .Dock(DockStyle.Top),
                new Button()
                    .Text("Click Me!")
                    .Dock(DockStyle.Fill)
                    .OnClick((sender, e) => ((Button)sender).Text = "Clicked!")
            );
}
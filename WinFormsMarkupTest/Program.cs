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
            .Assign(out var form)
            .Text("WinForms Markup")
            .Size(800, 600)
            .FormBorderStyle(FormBorderStyle.FixedSingle)
            .AddControls(
                new Label()
                    .Assign(out var label)
                    .Text("Hello, WinForms Markup!")
                    .TextAlign(ContentAlignment.MiddleCenter)
                    .Anchor(AnchorStyles.Top | AnchorStyles.Left)
                    .Size(780, 20)
                    .Location((form.Width - label.Width) / 2, (form.Height - label.Height) / 2 - label.Height),
                new Button()
                    .Assign(out var button)
                    .Text("Click Me!")
                    .Size(300, 30)
                    .Location((form.Width - button.Width) / 2, label.Location.Y + label.Height + 8)
                    .OnClick((sender, e) => label.Text = $"Clicked {++clickCount} times!")
            );
    }
}
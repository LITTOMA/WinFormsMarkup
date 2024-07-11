#if DEBUG
[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(WinFormsMarkup.HotReloadService))]
#endif

namespace WinFormsMarkup;

#if DEBUG
public static class HotReloadService
{
    public static event Action<Type[]?>? UpdateApplicationEvent;

    internal static void ClearCache(Type[]? types) { }
    internal static void UpdateApplication(Type[]? types)
    {
        UpdateApplicationEvent?.Invoke(types);
    }
}

#endif


public class HotReloadApplicationContext : System.Windows.Forms.ApplicationContext
{
    private Func<Form> _mainFormBuilder;

    public HotReloadApplicationContext(Func<System.Windows.Forms.Form> mainFormBuilder) : base(mainFormBuilder())
    {
        this._mainFormBuilder = mainFormBuilder;

#if DEBUG
        HotReloadService.UpdateApplicationEvent += RebuildApp;
#endif
    }

    private void RebuildApp(Type[]? obj)
    {
        MainForm.Invoke(() =>
        {
            var newForm = _mainFormBuilder();
            MainForm
                .Text(newForm.Text)
                .Size(newForm.Size)
                .FormBorderStyle(newForm.FormBorderStyle)
                .StartPosition(newForm.StartPosition)
                .WindowState(newForm.WindowState)
                .MaximizeBox(newForm.MaximizeBox)
                .MinimizeBox(newForm.MinimizeBox)
                .ShowIcon(newForm.ShowIcon)
                .ShowInTaskbar(newForm.ShowInTaskbar)
                .Icon(newForm.Icon)
                .Font(newForm.Font)
                .BackColor(newForm.BackColor)
                .ForeColor(newForm.ForeColor)
                .Opacity(newForm.Opacity)
                .AcceptButton(newForm.AcceptButton)
                .CancelButton(newForm.CancelButton)
                .AutoScaleMode(newForm.AutoScaleMode)
                .AutoScaleDimensions(newForm.AutoScaleDimensions)
                .AutoScaleBaseSize(newForm.AutoScaleBaseSize)
                .AutoScroll(newForm.AutoScroll)
                .AutoScrollMargin(newForm.AutoScrollMargin)
                .AutoScrollMinSize(newForm.AutoScrollMinSize)
                .AutoScrollPosition(newForm.AutoScrollPosition)
                .AutoScrollOffset(newForm.AutoScrollOffset);

            MainForm.Controls.Clear();
            MainForm.Controls.AddRange(newForm.Controls.Cast<System.Windows.Forms.Control>().ToArray());

        });
    }

    public Form Build() => _mainFormBuilder();
}

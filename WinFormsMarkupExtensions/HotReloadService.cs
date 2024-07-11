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
            MainForm.Controls.Clear();
            MainForm.Controls.AddRange(_mainFormBuilder().Controls.Cast<System.Windows.Forms.Control>().ToArray());
        });
    }

    public Form Build() => _mainFormBuilder();
}

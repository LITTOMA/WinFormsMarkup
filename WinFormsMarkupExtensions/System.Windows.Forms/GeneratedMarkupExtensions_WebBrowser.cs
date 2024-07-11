using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.IO;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class WebBrowserExtensions
    {
        public static WebBrowser AllowNavigation(this WebBrowser control, Boolean value)
        {
            control.AllowNavigation = value;
            return control;
        }

        public static WebBrowser AllowWebBrowserDrop(this WebBrowser control, Boolean value)
        {
            control.AllowWebBrowserDrop = value;
            return control;
        }

        public static WebBrowser ScriptErrorsSuppressed(this WebBrowser control, Boolean value)
        {
            control.ScriptErrorsSuppressed = value;
            return control;
        }

        public static WebBrowser WebBrowserShortcutsEnabled(this WebBrowser control, Boolean value)
        {
            control.WebBrowserShortcutsEnabled = value;
            return control;
        }

        public static WebBrowser DocumentStream(this WebBrowser control, Stream value)
        {
            control.DocumentStream = value;
            return control;
        }

        public static WebBrowser DocumentText(this WebBrowser control, String value)
        {
            control.DocumentText = value;
            return control;
        }

        public static WebBrowser IsWebBrowserContextMenuEnabled(this WebBrowser control, Boolean value)
        {
            control.IsWebBrowserContextMenuEnabled = value;
            return control;
        }

        public static WebBrowser ObjectForScripting(this WebBrowser control, Object value)
        {
            control.ObjectForScripting = value;
            return control;
        }

        public static WebBrowser Padding(this WebBrowser control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static WebBrowser Url(this WebBrowser control, Uri value)
        {
            control.Url = value;
            return control;
        }

        public static WebBrowser ScrollBarsEnabled(this WebBrowser control, Boolean value)
        {
            control.ScrollBarsEnabled = value;
            return control;
        }

        public static WebBrowser BackColor(this WebBrowser control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static WebBrowser Font(this WebBrowser control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static WebBrowser ForeColor(this WebBrowser control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static WebBrowser ImeMode(this WebBrowser control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static WebBrowser AllowDrop(this WebBrowser control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static WebBrowser BackgroundImage(this WebBrowser control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static WebBrowser BackgroundImageLayout(this WebBrowser control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static WebBrowser Cursor(this WebBrowser control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static WebBrowser Enabled(this WebBrowser control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static WebBrowser RightToLeft(this WebBrowser control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static WebBrowser Text(this WebBrowser control, String value)
        {
            control.Text = value;
            return control;
        }

        public static WebBrowser UseWaitCursor(this WebBrowser control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static WebBrowser AccessibleDefaultActionDescription(this WebBrowser control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static WebBrowser AccessibleDescription(this WebBrowser control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static WebBrowser AccessibleName(this WebBrowser control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static WebBrowser AccessibleRole(this WebBrowser control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static WebBrowser Anchor(this WebBrowser control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static WebBrowser AutoSize(this WebBrowser control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static WebBrowser AutoScrollOffset(this WebBrowser control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static WebBrowser DataContext(this WebBrowser control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static WebBrowser BindingContext(this WebBrowser control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static WebBrowser Bounds(this WebBrowser control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static WebBrowser Capture(this WebBrowser control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static WebBrowser CausesValidation(this WebBrowser control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static WebBrowser ClientSize(this WebBrowser control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static WebBrowser ContextMenuStrip(this WebBrowser control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static WebBrowser Dock(this WebBrowser control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static WebBrowser Height(this WebBrowser control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static WebBrowser IsAccessible(this WebBrowser control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static WebBrowser Left(this WebBrowser control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static WebBrowser Location(this WebBrowser control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static WebBrowser Margin(this WebBrowser control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static WebBrowser MaximumSize(this WebBrowser control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static WebBrowser MinimumSize(this WebBrowser control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static WebBrowser Name(this WebBrowser control, String value)
        {
            control.Name = value;
            return control;
        }

        public static WebBrowser Parent(this WebBrowser control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static WebBrowser Region(this WebBrowser control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static WebBrowser Size(this WebBrowser control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static WebBrowser TabIndex(this WebBrowser control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static WebBrowser TabStop(this WebBrowser control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static WebBrowser Tag(this WebBrowser control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static WebBrowser Top(this WebBrowser control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static WebBrowser Visible(this WebBrowser control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static WebBrowser Width(this WebBrowser control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static WebBrowser WindowTarget(this WebBrowser control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static WebBrowser OnPaddingChanged(this WebBrowser control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static WebBrowser OnCanGoBackChanged(this WebBrowser control, EventHandler handler)
        {
            control.CanGoBackChanged += handler;
            return control;
        }

        public static WebBrowser OnCanGoForwardChanged(this WebBrowser control, EventHandler handler)
        {
            control.CanGoForwardChanged += handler;
            return control;
        }

        public static WebBrowser OnDocumentCompleted(this WebBrowser control, WebBrowserDocumentCompletedEventHandler handler)
        {
            control.DocumentCompleted += handler;
            return control;
        }

        public static WebBrowser OnDocumentTitleChanged(this WebBrowser control, EventHandler handler)
        {
            control.DocumentTitleChanged += handler;
            return control;
        }

        public static WebBrowser OnEncryptionLevelChanged(this WebBrowser control, EventHandler handler)
        {
            control.EncryptionLevelChanged += handler;
            return control;
        }

        public static WebBrowser OnFileDownload(this WebBrowser control, EventHandler handler)
        {
            control.FileDownload += handler;
            return control;
        }

        public static WebBrowser OnNavigated(this WebBrowser control, WebBrowserNavigatedEventHandler handler)
        {
            control.Navigated += handler;
            return control;
        }

        public static WebBrowser OnNavigating(this WebBrowser control, WebBrowserNavigatingEventHandler handler)
        {
            control.Navigating += handler;
            return control;
        }

        public static WebBrowser OnNewWindow(this WebBrowser control, CancelEventHandler handler)
        {
            control.NewWindow += handler;
            return control;
        }

        public static WebBrowser OnProgressChanged(this WebBrowser control, WebBrowserProgressChangedEventHandler handler)
        {
            control.ProgressChanged += handler;
            return control;
        }

        public static WebBrowser OnStatusTextChanged(this WebBrowser control, EventHandler handler)
        {
            control.StatusTextChanged += handler;
            return control;
        }

        public static WebBrowser OnBackgroundImageLayoutChanged(this WebBrowser control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static WebBrowser OnEnter(this WebBrowser control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static WebBrowser OnLeave(this WebBrowser control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static WebBrowser OnMouseCaptureChanged(this WebBrowser control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static WebBrowser OnMouseClick(this WebBrowser control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static WebBrowser OnMouseDoubleClick(this WebBrowser control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static WebBrowser OnBackColorChanged(this WebBrowser control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static WebBrowser OnBackgroundImageChanged(this WebBrowser control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static WebBrowser OnBindingContextChanged(this WebBrowser control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static WebBrowser OnCursorChanged(this WebBrowser control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static WebBrowser OnEnabledChanged(this WebBrowser control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static WebBrowser OnFontChanged(this WebBrowser control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static WebBrowser OnForeColorChanged(this WebBrowser control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static WebBrowser OnRightToLeftChanged(this WebBrowser control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static WebBrowser OnTextChanged(this WebBrowser control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static WebBrowser OnClick(this WebBrowser control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static WebBrowser OnDragDrop(this WebBrowser control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static WebBrowser OnDragEnter(this WebBrowser control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static WebBrowser OnDragOver(this WebBrowser control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static WebBrowser OnDragLeave(this WebBrowser control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static WebBrowser OnGiveFeedback(this WebBrowser control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static WebBrowser OnHelpRequested(this WebBrowser control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static WebBrowser OnPaint(this WebBrowser control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static WebBrowser OnQueryContinueDrag(this WebBrowser control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static WebBrowser OnQueryAccessibilityHelp(this WebBrowser control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static WebBrowser OnDoubleClick(this WebBrowser control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static WebBrowser OnImeModeChanged(this WebBrowser control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static WebBrowser OnKeyDown(this WebBrowser control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static WebBrowser OnKeyPress(this WebBrowser control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static WebBrowser OnKeyUp(this WebBrowser control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static WebBrowser OnLayout(this WebBrowser control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static WebBrowser OnMouseDown(this WebBrowser control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static WebBrowser OnMouseEnter(this WebBrowser control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static WebBrowser OnMouseLeave(this WebBrowser control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static WebBrowser OnMouseHover(this WebBrowser control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static WebBrowser OnMouseMove(this WebBrowser control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static WebBrowser OnMouseUp(this WebBrowser control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static WebBrowser OnMouseWheel(this WebBrowser control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static WebBrowser OnChangeUICues(this WebBrowser control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static WebBrowser OnStyleChanged(this WebBrowser control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static WebBrowser OnAutoSizeChanged(this WebBrowser control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static WebBrowser OnCausesValidationChanged(this WebBrowser control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static WebBrowser OnClientSizeChanged(this WebBrowser control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static WebBrowser OnContextMenuStripChanged(this WebBrowser control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static WebBrowser OnDockChanged(this WebBrowser control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static WebBrowser OnLocationChanged(this WebBrowser control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static WebBrowser OnMarginChanged(this WebBrowser control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static WebBrowser OnRegionChanged(this WebBrowser control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static WebBrowser OnSizeChanged(this WebBrowser control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static WebBrowser OnTabIndexChanged(this WebBrowser control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static WebBrowser OnTabStopChanged(this WebBrowser control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static WebBrowser OnVisibleChanged(this WebBrowser control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static WebBrowser OnControlAdded(this WebBrowser control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static WebBrowser OnControlRemoved(this WebBrowser control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static WebBrowser OnDataContextChanged(this WebBrowser control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static WebBrowser OnHandleCreated(this WebBrowser control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static WebBrowser OnHandleDestroyed(this WebBrowser control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static WebBrowser OnInvalidated(this WebBrowser control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static WebBrowser OnGotFocus(this WebBrowser control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static WebBrowser OnLostFocus(this WebBrowser control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static WebBrowser OnDpiChangedBeforeParent(this WebBrowser control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static WebBrowser OnDpiChangedAfterParent(this WebBrowser control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static WebBrowser OnMove(this WebBrowser control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static WebBrowser OnPreviewKeyDown(this WebBrowser control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static WebBrowser OnResize(this WebBrowser control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static WebBrowser OnSystemColorsChanged(this WebBrowser control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static WebBrowser OnValidating(this WebBrowser control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static WebBrowser OnValidated(this WebBrowser control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static WebBrowser OnParentChanged(this WebBrowser control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static WebBrowser OnDisposed(this WebBrowser control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static WebBrowser AddTo(this WebBrowser control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

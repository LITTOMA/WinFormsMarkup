using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Automation;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class LinkLabelExtensions
    {
        public static LinkLabel ActiveLinkColor(this LinkLabel control, int red, int green, int blue)
        {
            control.ActiveLinkColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static LinkLabel ActiveLinkColor(this LinkLabel control, int red, int green, int blue, int alpha)
        {
            control.ActiveLinkColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static LinkLabel ActiveLinkColor(this LinkLabel control, Color color)
        {
            control.ActiveLinkColor = color;
            return control;
        }

        public static LinkLabel DisabledLinkColor(this LinkLabel control, int red, int green, int blue)
        {
            control.DisabledLinkColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static LinkLabel DisabledLinkColor(this LinkLabel control, int red, int green, int blue, int alpha)
        {
            control.DisabledLinkColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static LinkLabel DisabledLinkColor(this LinkLabel control, Color color)
        {
            control.DisabledLinkColor = color;
            return control;
        }

        public static LinkLabel FlatStyle(this LinkLabel control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static LinkLabel LinkArea(this LinkLabel control, LinkArea value)
        {
            control.LinkArea = value;
            return control;
        }

        public static LinkLabel LinkBehavior(this LinkLabel control, LinkBehavior value)
        {
            control.LinkBehavior = value;
            return control;
        }

        public static LinkLabel LinkColor(this LinkLabel control, int red, int green, int blue)
        {
            control.LinkColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static LinkLabel LinkColor(this LinkLabel control, int red, int green, int blue, int alpha)
        {
            control.LinkColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static LinkLabel LinkColor(this LinkLabel control, Color color)
        {
            control.LinkColor = color;
            return control;
        }

        public static LinkLabel LinkVisited(this LinkLabel control, Boolean value)
        {
            control.LinkVisited = value;
            return control;
        }

        public static LinkLabel TabStop(this LinkLabel control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static LinkLabel Text(this LinkLabel control, String value)
        {
            control.Text = value;
            return control;
        }

        public static LinkLabel Padding(this LinkLabel control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static LinkLabel VisitedLinkColor(this LinkLabel control, int red, int green, int blue)
        {
            control.VisitedLinkColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static LinkLabel VisitedLinkColor(this LinkLabel control, int red, int green, int blue, int alpha)
        {
            control.VisitedLinkColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static LinkLabel VisitedLinkColor(this LinkLabel control, Color color)
        {
            control.VisitedLinkColor = color;
            return control;
        }

        public static LinkLabel UseCompatibleTextRendering(this LinkLabel control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static LinkLabel AutoSize(this LinkLabel control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static LinkLabel AutoEllipsis(this LinkLabel control, Boolean value)
        {
            control.AutoEllipsis = value;
            return control;
        }

        public static LinkLabel BackgroundImage(this LinkLabel control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static LinkLabel BackgroundImageLayout(this LinkLabel control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static LinkLabel BorderStyle(this LinkLabel control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static LinkLabel Image(this LinkLabel control, Image value)
        {
            control.Image = value;
            return control;
        }

        public static LinkLabel ImageIndex(this LinkLabel control, Int32 value)
        {
            control.ImageIndex = value;
            return control;
        }

        public static LinkLabel ImageKey(this LinkLabel control, String value)
        {
            control.ImageKey = value;
            return control;
        }

        public static LinkLabel ImageList(this LinkLabel control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static LinkLabel ImageAlign(this LinkLabel control, ContentAlignment value)
        {
            control.ImageAlign = value;
            return control;
        }

        public static LinkLabel LiveSetting(this LinkLabel control, AutomationLiveSetting value)
        {
            control.LiveSetting = value;
            return control;
        }

        public static LinkLabel ImeMode(this LinkLabel control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static LinkLabel TextAlign(this LinkLabel control, ContentAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static LinkLabel UseMnemonic(this LinkLabel control, Boolean value)
        {
            control.UseMnemonic = value;
            return control;
        }

        public static LinkLabel AccessibleDefaultActionDescription(this LinkLabel control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static LinkLabel AccessibleDescription(this LinkLabel control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static LinkLabel AccessibleName(this LinkLabel control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static LinkLabel AccessibleRole(this LinkLabel control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static LinkLabel AllowDrop(this LinkLabel control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static LinkLabel Anchor(this LinkLabel control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static LinkLabel AutoScrollOffset(this LinkLabel control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static LinkLabel AutoScrollOffset(this LinkLabel control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static LinkLabel DataContext(this LinkLabel control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static LinkLabel BackColor(this LinkLabel control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static LinkLabel BackColor(this LinkLabel control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static LinkLabel BackColor(this LinkLabel control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static LinkLabel BindingContext(this LinkLabel control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static LinkLabel Bounds(this LinkLabel control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static LinkLabel Bounds(this LinkLabel control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static LinkLabel Bounds(this LinkLabel control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static LinkLabel Capture(this LinkLabel control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static LinkLabel CausesValidation(this LinkLabel control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static LinkLabel ClientSize(this LinkLabel control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static LinkLabel ClientSize(this LinkLabel control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static LinkLabel ContextMenuStrip(this LinkLabel control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static LinkLabel Cursor(this LinkLabel control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static LinkLabel Dock(this LinkLabel control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static LinkLabel Enabled(this LinkLabel control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static LinkLabel Font(this LinkLabel control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static LinkLabel Font(this LinkLabel control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static LinkLabel ForeColor(this LinkLabel control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static LinkLabel ForeColor(this LinkLabel control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static LinkLabel ForeColor(this LinkLabel control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static LinkLabel Height(this LinkLabel control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static LinkLabel IsAccessible(this LinkLabel control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static LinkLabel Left(this LinkLabel control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static LinkLabel Location(this LinkLabel control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static LinkLabel Location(this LinkLabel control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static LinkLabel Margin(this LinkLabel control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static LinkLabel MaximumSize(this LinkLabel control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static LinkLabel MaximumSize(this LinkLabel control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static LinkLabel MinimumSize(this LinkLabel control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static LinkLabel MinimumSize(this LinkLabel control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static LinkLabel Name(this LinkLabel control, String value)
        {
            control.Name = value;
            return control;
        }

        public static LinkLabel Parent(this LinkLabel control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static LinkLabel Region(this LinkLabel control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static LinkLabel RightToLeft(this LinkLabel control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static LinkLabel Size(this LinkLabel control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static LinkLabel Size(this LinkLabel control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static LinkLabel TabIndex(this LinkLabel control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static LinkLabel Tag(this LinkLabel control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static LinkLabel Top(this LinkLabel control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static LinkLabel UseWaitCursor(this LinkLabel control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static LinkLabel Visible(this LinkLabel control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static LinkLabel Width(this LinkLabel control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static LinkLabel WindowTarget(this LinkLabel control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static LinkLabel OnTabStopChanged(this LinkLabel control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static LinkLabel OnLinkClicked(this LinkLabel control, LinkLabelLinkClickedEventHandler handler)
        {
            control.LinkClicked += handler;
            return control;
        }

        public static LinkLabel OnAutoSizeChanged(this LinkLabel control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static LinkLabel OnBackgroundImageChanged(this LinkLabel control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static LinkLabel OnBackgroundImageLayoutChanged(this LinkLabel control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static LinkLabel OnImeModeChanged(this LinkLabel control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static LinkLabel OnKeyUp(this LinkLabel control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static LinkLabel OnKeyDown(this LinkLabel control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static LinkLabel OnKeyPress(this LinkLabel control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static LinkLabel OnTextAlignChanged(this LinkLabel control, EventHandler handler)
        {
            control.TextAlignChanged += handler;
            return control;
        }

        public static LinkLabel OnBackColorChanged(this LinkLabel control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static LinkLabel OnBindingContextChanged(this LinkLabel control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static LinkLabel OnCausesValidationChanged(this LinkLabel control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static LinkLabel OnClientSizeChanged(this LinkLabel control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static LinkLabel OnContextMenuStripChanged(this LinkLabel control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static LinkLabel OnCursorChanged(this LinkLabel control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static LinkLabel OnDockChanged(this LinkLabel control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static LinkLabel OnEnabledChanged(this LinkLabel control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static LinkLabel OnFontChanged(this LinkLabel control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static LinkLabel OnForeColorChanged(this LinkLabel control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static LinkLabel OnLocationChanged(this LinkLabel control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static LinkLabel OnMarginChanged(this LinkLabel control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static LinkLabel OnRegionChanged(this LinkLabel control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static LinkLabel OnRightToLeftChanged(this LinkLabel control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static LinkLabel OnSizeChanged(this LinkLabel control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static LinkLabel OnTabIndexChanged(this LinkLabel control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static LinkLabel OnTextChanged(this LinkLabel control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static LinkLabel OnVisibleChanged(this LinkLabel control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static LinkLabel OnClick(this LinkLabel control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static LinkLabel OnControlAdded(this LinkLabel control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static LinkLabel OnControlRemoved(this LinkLabel control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static LinkLabel OnDataContextChanged(this LinkLabel control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static LinkLabel OnDragDrop(this LinkLabel control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static LinkLabel OnDragEnter(this LinkLabel control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static LinkLabel OnDragOver(this LinkLabel control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static LinkLabel OnDragLeave(this LinkLabel control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static LinkLabel OnGiveFeedback(this LinkLabel control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static LinkLabel OnHandleCreated(this LinkLabel control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static LinkLabel OnHandleDestroyed(this LinkLabel control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static LinkLabel OnHelpRequested(this LinkLabel control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static LinkLabel OnInvalidated(this LinkLabel control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static LinkLabel OnPaddingChanged(this LinkLabel control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static LinkLabel OnPaint(this LinkLabel control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static LinkLabel OnQueryContinueDrag(this LinkLabel control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static LinkLabel OnQueryAccessibilityHelp(this LinkLabel control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static LinkLabel OnDoubleClick(this LinkLabel control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static LinkLabel OnEnter(this LinkLabel control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static LinkLabel OnGotFocus(this LinkLabel control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static LinkLabel OnLayout(this LinkLabel control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static LinkLabel OnLeave(this LinkLabel control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static LinkLabel OnLostFocus(this LinkLabel control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static LinkLabel OnMouseClick(this LinkLabel control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static LinkLabel OnMouseDoubleClick(this LinkLabel control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static LinkLabel OnMouseCaptureChanged(this LinkLabel control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static LinkLabel OnMouseDown(this LinkLabel control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static LinkLabel OnMouseEnter(this LinkLabel control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static LinkLabel OnMouseLeave(this LinkLabel control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static LinkLabel OnDpiChangedBeforeParent(this LinkLabel control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static LinkLabel OnDpiChangedAfterParent(this LinkLabel control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static LinkLabel OnMouseHover(this LinkLabel control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static LinkLabel OnMouseMove(this LinkLabel control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static LinkLabel OnMouseUp(this LinkLabel control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static LinkLabel OnMouseWheel(this LinkLabel control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static LinkLabel OnMove(this LinkLabel control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static LinkLabel OnPreviewKeyDown(this LinkLabel control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static LinkLabel OnResize(this LinkLabel control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static LinkLabel OnChangeUICues(this LinkLabel control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static LinkLabel OnStyleChanged(this LinkLabel control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static LinkLabel OnSystemColorsChanged(this LinkLabel control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static LinkLabel OnValidating(this LinkLabel control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static LinkLabel OnValidated(this LinkLabel control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static LinkLabel OnParentChanged(this LinkLabel control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static LinkLabel OnDisposed(this LinkLabel control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static LinkLabel AddTo(this LinkLabel control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static LinkLabel Assign(this LinkLabel control, out LinkLabel variable)
        {
            variable = control;
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class WebBrowserBaseExtensions
    {
        public static WebBrowserBase BackColor(this WebBrowserBase control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static WebBrowserBase BackColor(this WebBrowserBase control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static WebBrowserBase BackColor(this WebBrowserBase control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static WebBrowserBase Font(this WebBrowserBase control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static WebBrowserBase Font(this WebBrowserBase control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static WebBrowserBase ForeColor(this WebBrowserBase control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static WebBrowserBase ForeColor(this WebBrowserBase control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static WebBrowserBase ForeColor(this WebBrowserBase control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static WebBrowserBase ImeMode(this WebBrowserBase control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static WebBrowserBase AllowDrop(this WebBrowserBase control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static WebBrowserBase BackgroundImage(this WebBrowserBase control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static WebBrowserBase BackgroundImageLayout(this WebBrowserBase control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static WebBrowserBase Cursor(this WebBrowserBase control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static WebBrowserBase Enabled(this WebBrowserBase control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static WebBrowserBase RightToLeft(this WebBrowserBase control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static WebBrowserBase Text(this WebBrowserBase control, String value)
        {
            control.Text = value;
            return control;
        }

        public static WebBrowserBase UseWaitCursor(this WebBrowserBase control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static WebBrowserBase AccessibleDefaultActionDescription(this WebBrowserBase control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static WebBrowserBase AccessibleDescription(this WebBrowserBase control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static WebBrowserBase AccessibleName(this WebBrowserBase control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static WebBrowserBase AccessibleRole(this WebBrowserBase control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static WebBrowserBase Anchor(this WebBrowserBase control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static WebBrowserBase AutoSize(this WebBrowserBase control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static WebBrowserBase AutoScrollOffset(this WebBrowserBase control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static WebBrowserBase AutoScrollOffset(this WebBrowserBase control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static WebBrowserBase DataContext(this WebBrowserBase control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static WebBrowserBase BindingContext(this WebBrowserBase control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static WebBrowserBase Bounds(this WebBrowserBase control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static WebBrowserBase Bounds(this WebBrowserBase control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static WebBrowserBase Bounds(this WebBrowserBase control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static WebBrowserBase Capture(this WebBrowserBase control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static WebBrowserBase CausesValidation(this WebBrowserBase control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static WebBrowserBase ClientSize(this WebBrowserBase control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static WebBrowserBase ClientSize(this WebBrowserBase control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static WebBrowserBase ContextMenuStrip(this WebBrowserBase control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static WebBrowserBase Dock(this WebBrowserBase control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static WebBrowserBase Height(this WebBrowserBase control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static WebBrowserBase IsAccessible(this WebBrowserBase control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static WebBrowserBase Left(this WebBrowserBase control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static WebBrowserBase Location(this WebBrowserBase control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static WebBrowserBase Location(this WebBrowserBase control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static WebBrowserBase Margin(this WebBrowserBase control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static WebBrowserBase MaximumSize(this WebBrowserBase control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static WebBrowserBase MaximumSize(this WebBrowserBase control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static WebBrowserBase MinimumSize(this WebBrowserBase control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static WebBrowserBase MinimumSize(this WebBrowserBase control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static WebBrowserBase Name(this WebBrowserBase control, String value)
        {
            control.Name = value;
            return control;
        }

        public static WebBrowserBase Parent(this WebBrowserBase control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static WebBrowserBase Region(this WebBrowserBase control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static WebBrowserBase Size(this WebBrowserBase control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static WebBrowserBase Size(this WebBrowserBase control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static WebBrowserBase TabIndex(this WebBrowserBase control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static WebBrowserBase TabStop(this WebBrowserBase control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static WebBrowserBase Tag(this WebBrowserBase control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static WebBrowserBase Top(this WebBrowserBase control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static WebBrowserBase Visible(this WebBrowserBase control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static WebBrowserBase Width(this WebBrowserBase control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static WebBrowserBase WindowTarget(this WebBrowserBase control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static WebBrowserBase Padding(this WebBrowserBase control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static WebBrowserBase OnBackgroundImageLayoutChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static WebBrowserBase OnEnter(this WebBrowserBase control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static WebBrowserBase OnLeave(this WebBrowserBase control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static WebBrowserBase OnMouseCaptureChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static WebBrowserBase OnMouseClick(this WebBrowserBase control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static WebBrowserBase OnMouseDoubleClick(this WebBrowserBase control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static WebBrowserBase OnBackColorChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static WebBrowserBase OnBackgroundImageChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static WebBrowserBase OnBindingContextChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static WebBrowserBase OnCursorChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static WebBrowserBase OnEnabledChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static WebBrowserBase OnFontChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static WebBrowserBase OnForeColorChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static WebBrowserBase OnRightToLeftChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static WebBrowserBase OnTextChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static WebBrowserBase OnClick(this WebBrowserBase control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static WebBrowserBase OnDragDrop(this WebBrowserBase control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static WebBrowserBase OnDragEnter(this WebBrowserBase control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static WebBrowserBase OnDragOver(this WebBrowserBase control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static WebBrowserBase OnDragLeave(this WebBrowserBase control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static WebBrowserBase OnGiveFeedback(this WebBrowserBase control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static WebBrowserBase OnHelpRequested(this WebBrowserBase control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static WebBrowserBase OnPaint(this WebBrowserBase control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static WebBrowserBase OnQueryContinueDrag(this WebBrowserBase control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static WebBrowserBase OnQueryAccessibilityHelp(this WebBrowserBase control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static WebBrowserBase OnDoubleClick(this WebBrowserBase control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static WebBrowserBase OnImeModeChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static WebBrowserBase OnKeyDown(this WebBrowserBase control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static WebBrowserBase OnKeyPress(this WebBrowserBase control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static WebBrowserBase OnKeyUp(this WebBrowserBase control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static WebBrowserBase OnLayout(this WebBrowserBase control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static WebBrowserBase OnMouseDown(this WebBrowserBase control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static WebBrowserBase OnMouseEnter(this WebBrowserBase control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static WebBrowserBase OnMouseLeave(this WebBrowserBase control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static WebBrowserBase OnMouseHover(this WebBrowserBase control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static WebBrowserBase OnMouseMove(this WebBrowserBase control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static WebBrowserBase OnMouseUp(this WebBrowserBase control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static WebBrowserBase OnMouseWheel(this WebBrowserBase control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static WebBrowserBase OnChangeUICues(this WebBrowserBase control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static WebBrowserBase OnStyleChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static WebBrowserBase OnAutoSizeChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static WebBrowserBase OnCausesValidationChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static WebBrowserBase OnClientSizeChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static WebBrowserBase OnContextMenuStripChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static WebBrowserBase OnDockChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static WebBrowserBase OnLocationChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static WebBrowserBase OnMarginChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static WebBrowserBase OnRegionChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static WebBrowserBase OnSizeChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static WebBrowserBase OnTabIndexChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static WebBrowserBase OnTabStopChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static WebBrowserBase OnVisibleChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static WebBrowserBase OnControlAdded(this WebBrowserBase control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static WebBrowserBase OnControlRemoved(this WebBrowserBase control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static WebBrowserBase OnDataContextChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static WebBrowserBase OnHandleCreated(this WebBrowserBase control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static WebBrowserBase OnHandleDestroyed(this WebBrowserBase control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static WebBrowserBase OnInvalidated(this WebBrowserBase control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static WebBrowserBase OnPaddingChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static WebBrowserBase OnGotFocus(this WebBrowserBase control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static WebBrowserBase OnLostFocus(this WebBrowserBase control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static WebBrowserBase OnDpiChangedBeforeParent(this WebBrowserBase control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static WebBrowserBase OnDpiChangedAfterParent(this WebBrowserBase control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static WebBrowserBase OnMove(this WebBrowserBase control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static WebBrowserBase OnPreviewKeyDown(this WebBrowserBase control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static WebBrowserBase OnResize(this WebBrowserBase control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static WebBrowserBase OnSystemColorsChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static WebBrowserBase OnValidating(this WebBrowserBase control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static WebBrowserBase OnValidated(this WebBrowserBase control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static WebBrowserBase OnParentChanged(this WebBrowserBase control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static WebBrowserBase OnDisposed(this WebBrowserBase control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static WebBrowserBase AddTo(this WebBrowserBase control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static WebBrowserBase Assign(this WebBrowserBase control, out WebBrowserBase variable)
        {
            variable = control;
            return control;
        }

    }
}

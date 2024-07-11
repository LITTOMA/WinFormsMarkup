using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class MdiClientExtensions
    {
        public static MdiClient BackgroundImage(this MdiClient control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static MdiClient BackgroundImageLayout(this MdiClient control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static MdiClient AccessibleDefaultActionDescription(this MdiClient control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static MdiClient AccessibleDescription(this MdiClient control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static MdiClient AccessibleName(this MdiClient control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static MdiClient AccessibleRole(this MdiClient control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static MdiClient AllowDrop(this MdiClient control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static MdiClient Anchor(this MdiClient control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static MdiClient AutoSize(this MdiClient control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static MdiClient AutoScrollOffset(this MdiClient control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static MdiClient AutoScrollOffset(this MdiClient control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static MdiClient DataContext(this MdiClient control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static MdiClient BackColor(this MdiClient control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MdiClient BackColor(this MdiClient control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MdiClient BackColor(this MdiClient control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static MdiClient BindingContext(this MdiClient control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static MdiClient Bounds(this MdiClient control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static MdiClient Bounds(this MdiClient control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static MdiClient Bounds(this MdiClient control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static MdiClient Capture(this MdiClient control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static MdiClient CausesValidation(this MdiClient control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static MdiClient ClientSize(this MdiClient control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static MdiClient ClientSize(this MdiClient control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static MdiClient ContextMenuStrip(this MdiClient control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static MdiClient Cursor(this MdiClient control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static MdiClient Dock(this MdiClient control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static MdiClient Enabled(this MdiClient control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static MdiClient Font(this MdiClient control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static MdiClient Font(this MdiClient control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static MdiClient ForeColor(this MdiClient control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MdiClient ForeColor(this MdiClient control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MdiClient ForeColor(this MdiClient control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static MdiClient Height(this MdiClient control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static MdiClient IsAccessible(this MdiClient control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static MdiClient Left(this MdiClient control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static MdiClient Location(this MdiClient control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static MdiClient Location(this MdiClient control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static MdiClient Margin(this MdiClient control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static MdiClient MaximumSize(this MdiClient control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static MdiClient MaximumSize(this MdiClient control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static MdiClient MinimumSize(this MdiClient control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static MdiClient MinimumSize(this MdiClient control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static MdiClient Name(this MdiClient control, String value)
        {
            control.Name = value;
            return control;
        }

        public static MdiClient Parent(this MdiClient control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static MdiClient Region(this MdiClient control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static MdiClient RightToLeft(this MdiClient control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static MdiClient Size(this MdiClient control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static MdiClient Size(this MdiClient control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static MdiClient TabIndex(this MdiClient control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static MdiClient TabStop(this MdiClient control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static MdiClient Tag(this MdiClient control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static MdiClient Text(this MdiClient control, String value)
        {
            control.Text = value;
            return control;
        }

        public static MdiClient Top(this MdiClient control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static MdiClient UseWaitCursor(this MdiClient control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static MdiClient Visible(this MdiClient control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static MdiClient Width(this MdiClient control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static MdiClient WindowTarget(this MdiClient control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static MdiClient Padding(this MdiClient control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static MdiClient ImeMode(this MdiClient control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static MdiClient OnAutoSizeChanged(this MdiClient control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static MdiClient OnBackColorChanged(this MdiClient control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static MdiClient OnBackgroundImageChanged(this MdiClient control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static MdiClient OnBackgroundImageLayoutChanged(this MdiClient control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static MdiClient OnBindingContextChanged(this MdiClient control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static MdiClient OnCausesValidationChanged(this MdiClient control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static MdiClient OnClientSizeChanged(this MdiClient control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static MdiClient OnContextMenuStripChanged(this MdiClient control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static MdiClient OnCursorChanged(this MdiClient control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static MdiClient OnDockChanged(this MdiClient control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static MdiClient OnEnabledChanged(this MdiClient control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static MdiClient OnFontChanged(this MdiClient control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static MdiClient OnForeColorChanged(this MdiClient control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static MdiClient OnLocationChanged(this MdiClient control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static MdiClient OnMarginChanged(this MdiClient control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static MdiClient OnRegionChanged(this MdiClient control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static MdiClient OnRightToLeftChanged(this MdiClient control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static MdiClient OnSizeChanged(this MdiClient control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static MdiClient OnTabIndexChanged(this MdiClient control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static MdiClient OnTabStopChanged(this MdiClient control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static MdiClient OnTextChanged(this MdiClient control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static MdiClient OnVisibleChanged(this MdiClient control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static MdiClient OnClick(this MdiClient control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static MdiClient OnControlAdded(this MdiClient control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static MdiClient OnControlRemoved(this MdiClient control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static MdiClient OnDataContextChanged(this MdiClient control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static MdiClient OnDragDrop(this MdiClient control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static MdiClient OnDragEnter(this MdiClient control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static MdiClient OnDragOver(this MdiClient control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static MdiClient OnDragLeave(this MdiClient control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static MdiClient OnGiveFeedback(this MdiClient control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static MdiClient OnHandleCreated(this MdiClient control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static MdiClient OnHandleDestroyed(this MdiClient control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static MdiClient OnHelpRequested(this MdiClient control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static MdiClient OnInvalidated(this MdiClient control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static MdiClient OnPaddingChanged(this MdiClient control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static MdiClient OnPaint(this MdiClient control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static MdiClient OnQueryContinueDrag(this MdiClient control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static MdiClient OnQueryAccessibilityHelp(this MdiClient control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static MdiClient OnDoubleClick(this MdiClient control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static MdiClient OnEnter(this MdiClient control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static MdiClient OnGotFocus(this MdiClient control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static MdiClient OnKeyDown(this MdiClient control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static MdiClient OnKeyPress(this MdiClient control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static MdiClient OnKeyUp(this MdiClient control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static MdiClient OnLayout(this MdiClient control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static MdiClient OnLeave(this MdiClient control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static MdiClient OnLostFocus(this MdiClient control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static MdiClient OnMouseClick(this MdiClient control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static MdiClient OnMouseDoubleClick(this MdiClient control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static MdiClient OnMouseCaptureChanged(this MdiClient control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static MdiClient OnMouseDown(this MdiClient control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static MdiClient OnMouseEnter(this MdiClient control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static MdiClient OnMouseLeave(this MdiClient control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static MdiClient OnDpiChangedBeforeParent(this MdiClient control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static MdiClient OnDpiChangedAfterParent(this MdiClient control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static MdiClient OnMouseHover(this MdiClient control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static MdiClient OnMouseMove(this MdiClient control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static MdiClient OnMouseUp(this MdiClient control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static MdiClient OnMouseWheel(this MdiClient control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static MdiClient OnMove(this MdiClient control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static MdiClient OnPreviewKeyDown(this MdiClient control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static MdiClient OnResize(this MdiClient control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static MdiClient OnChangeUICues(this MdiClient control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static MdiClient OnStyleChanged(this MdiClient control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static MdiClient OnSystemColorsChanged(this MdiClient control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static MdiClient OnValidating(this MdiClient control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static MdiClient OnValidated(this MdiClient control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static MdiClient OnParentChanged(this MdiClient control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static MdiClient OnImeModeChanged(this MdiClient control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static MdiClient OnDisposed(this MdiClient control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static MdiClient AddTo(this MdiClient control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static MdiClient Assign(this MdiClient control, out MdiClient variable)
        {
            variable = control;
            return control;
        }

    }
}

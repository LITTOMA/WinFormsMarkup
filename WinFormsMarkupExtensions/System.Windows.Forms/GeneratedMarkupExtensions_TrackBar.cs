using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class TrackBarExtensions
    {
        public static TrackBar AutoSize(this TrackBar control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static TrackBar BackgroundImage(this TrackBar control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static TrackBar BackgroundImageLayout(this TrackBar control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static TrackBar Font(this TrackBar control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static TrackBar Font(this TrackBar control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static TrackBar ForeColor(this TrackBar control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TrackBar ForeColor(this TrackBar control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static TrackBar ForeColor(this TrackBar control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static TrackBar ImeMode(this TrackBar control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static TrackBar LargeChange(this TrackBar control, Int32 value)
        {
            control.LargeChange = value;
            return control;
        }

        public static TrackBar Maximum(this TrackBar control, Int32 value)
        {
            control.Maximum = value;
            return control;
        }

        public static TrackBar Minimum(this TrackBar control, Int32 value)
        {
            control.Minimum = value;
            return control;
        }

        public static TrackBar Orientation(this TrackBar control, Orientation value)
        {
            control.Orientation = value;
            return control;
        }

        public static TrackBar Padding(this TrackBar control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static TrackBar RightToLeftLayout(this TrackBar control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static TrackBar SmallChange(this TrackBar control, Int32 value)
        {
            control.SmallChange = value;
            return control;
        }

        public static TrackBar Text(this TrackBar control, String value)
        {
            control.Text = value;
            return control;
        }

        public static TrackBar TickStyle(this TrackBar control, TickStyle value)
        {
            control.TickStyle = value;
            return control;
        }

        public static TrackBar TickFrequency(this TrackBar control, Int32 value)
        {
            control.TickFrequency = value;
            return control;
        }

        public static TrackBar Value(this TrackBar control, Int32 value)
        {
            control.Value = value;
            return control;
        }

        public static TrackBar AccessibleDefaultActionDescription(this TrackBar control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static TrackBar AccessibleDescription(this TrackBar control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static TrackBar AccessibleName(this TrackBar control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static TrackBar AccessibleRole(this TrackBar control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static TrackBar AllowDrop(this TrackBar control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static TrackBar Anchor(this TrackBar control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static TrackBar AutoScrollOffset(this TrackBar control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static TrackBar AutoScrollOffset(this TrackBar control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static TrackBar DataContext(this TrackBar control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static TrackBar BackColor(this TrackBar control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TrackBar BackColor(this TrackBar control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static TrackBar BackColor(this TrackBar control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static TrackBar BindingContext(this TrackBar control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static TrackBar Bounds(this TrackBar control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static TrackBar Bounds(this TrackBar control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static TrackBar Bounds(this TrackBar control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static TrackBar Capture(this TrackBar control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static TrackBar CausesValidation(this TrackBar control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static TrackBar ClientSize(this TrackBar control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static TrackBar ClientSize(this TrackBar control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static TrackBar ContextMenuStrip(this TrackBar control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static TrackBar Cursor(this TrackBar control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static TrackBar Dock(this TrackBar control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static TrackBar Enabled(this TrackBar control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static TrackBar Height(this TrackBar control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static TrackBar IsAccessible(this TrackBar control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static TrackBar Left(this TrackBar control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static TrackBar Location(this TrackBar control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static TrackBar Location(this TrackBar control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static TrackBar Margin(this TrackBar control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static TrackBar MaximumSize(this TrackBar control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static TrackBar MaximumSize(this TrackBar control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static TrackBar MinimumSize(this TrackBar control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static TrackBar MinimumSize(this TrackBar control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static TrackBar Name(this TrackBar control, String value)
        {
            control.Name = value;
            return control;
        }

        public static TrackBar Parent(this TrackBar control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static TrackBar Region(this TrackBar control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static TrackBar RightToLeft(this TrackBar control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static TrackBar Size(this TrackBar control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static TrackBar Size(this TrackBar control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static TrackBar TabIndex(this TrackBar control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static TrackBar TabStop(this TrackBar control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static TrackBar Tag(this TrackBar control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static TrackBar Top(this TrackBar control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static TrackBar UseWaitCursor(this TrackBar control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static TrackBar Visible(this TrackBar control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static TrackBar Width(this TrackBar control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static TrackBar WindowTarget(this TrackBar control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static TrackBar OnAutoSizeChanged(this TrackBar control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static TrackBar OnBackgroundImageChanged(this TrackBar control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static TrackBar OnBackgroundImageLayoutChanged(this TrackBar control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static TrackBar OnFontChanged(this TrackBar control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static TrackBar OnForeColorChanged(this TrackBar control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static TrackBar OnImeModeChanged(this TrackBar control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static TrackBar OnPaddingChanged(this TrackBar control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static TrackBar OnTextChanged(this TrackBar control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static TrackBar OnClick(this TrackBar control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static TrackBar OnDoubleClick(this TrackBar control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static TrackBar OnMouseClick(this TrackBar control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static TrackBar OnMouseDoubleClick(this TrackBar control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static TrackBar OnRightToLeftLayoutChanged(this TrackBar control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static TrackBar OnScroll(this TrackBar control, EventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static TrackBar OnPaint(this TrackBar control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static TrackBar OnValueChanged(this TrackBar control, EventHandler handler)
        {
            control.ValueChanged += handler;
            return control;
        }

        public static TrackBar OnBackColorChanged(this TrackBar control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static TrackBar OnBindingContextChanged(this TrackBar control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static TrackBar OnCausesValidationChanged(this TrackBar control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static TrackBar OnClientSizeChanged(this TrackBar control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static TrackBar OnContextMenuStripChanged(this TrackBar control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static TrackBar OnCursorChanged(this TrackBar control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static TrackBar OnDockChanged(this TrackBar control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static TrackBar OnEnabledChanged(this TrackBar control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static TrackBar OnLocationChanged(this TrackBar control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static TrackBar OnMarginChanged(this TrackBar control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static TrackBar OnRegionChanged(this TrackBar control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static TrackBar OnRightToLeftChanged(this TrackBar control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static TrackBar OnSizeChanged(this TrackBar control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static TrackBar OnTabIndexChanged(this TrackBar control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static TrackBar OnTabStopChanged(this TrackBar control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static TrackBar OnVisibleChanged(this TrackBar control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static TrackBar OnControlAdded(this TrackBar control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static TrackBar OnControlRemoved(this TrackBar control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static TrackBar OnDataContextChanged(this TrackBar control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static TrackBar OnDragDrop(this TrackBar control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static TrackBar OnDragEnter(this TrackBar control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static TrackBar OnDragOver(this TrackBar control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static TrackBar OnDragLeave(this TrackBar control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static TrackBar OnGiveFeedback(this TrackBar control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static TrackBar OnHandleCreated(this TrackBar control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static TrackBar OnHandleDestroyed(this TrackBar control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static TrackBar OnHelpRequested(this TrackBar control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static TrackBar OnInvalidated(this TrackBar control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static TrackBar OnQueryContinueDrag(this TrackBar control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static TrackBar OnQueryAccessibilityHelp(this TrackBar control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static TrackBar OnEnter(this TrackBar control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static TrackBar OnGotFocus(this TrackBar control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static TrackBar OnKeyDown(this TrackBar control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static TrackBar OnKeyPress(this TrackBar control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static TrackBar OnKeyUp(this TrackBar control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static TrackBar OnLayout(this TrackBar control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static TrackBar OnLeave(this TrackBar control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static TrackBar OnLostFocus(this TrackBar control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static TrackBar OnMouseCaptureChanged(this TrackBar control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static TrackBar OnMouseDown(this TrackBar control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static TrackBar OnMouseEnter(this TrackBar control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static TrackBar OnMouseLeave(this TrackBar control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static TrackBar OnDpiChangedBeforeParent(this TrackBar control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static TrackBar OnDpiChangedAfterParent(this TrackBar control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static TrackBar OnMouseHover(this TrackBar control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static TrackBar OnMouseMove(this TrackBar control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static TrackBar OnMouseUp(this TrackBar control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static TrackBar OnMouseWheel(this TrackBar control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static TrackBar OnMove(this TrackBar control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static TrackBar OnPreviewKeyDown(this TrackBar control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static TrackBar OnResize(this TrackBar control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static TrackBar OnChangeUICues(this TrackBar control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static TrackBar OnStyleChanged(this TrackBar control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static TrackBar OnSystemColorsChanged(this TrackBar control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static TrackBar OnValidating(this TrackBar control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static TrackBar OnValidated(this TrackBar control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static TrackBar OnParentChanged(this TrackBar control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static TrackBar OnDisposed(this TrackBar control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static TrackBar AddTo(this TrackBar control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static TrackBar Assign(this TrackBar control, out TrackBar variable)
        {
            variable = control;
            return control;
        }

    }
}

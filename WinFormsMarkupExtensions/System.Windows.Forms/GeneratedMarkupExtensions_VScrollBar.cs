using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class VScrollBarExtensions
    {
        public static VScrollBar RightToLeft(this VScrollBar control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static VScrollBar AutoSize(this VScrollBar control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static VScrollBar BackColor(this VScrollBar control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static VScrollBar BackColor(this VScrollBar control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static VScrollBar BackColor(this VScrollBar control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static VScrollBar BackgroundImage(this VScrollBar control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static VScrollBar BackgroundImageLayout(this VScrollBar control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static VScrollBar ForeColor(this VScrollBar control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static VScrollBar ForeColor(this VScrollBar control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static VScrollBar ForeColor(this VScrollBar control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static VScrollBar Font(this VScrollBar control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static VScrollBar Font(this VScrollBar control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static VScrollBar ImeMode(this VScrollBar control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static VScrollBar LargeChange(this VScrollBar control, Int32 value)
        {
            control.LargeChange = value;
            return control;
        }

        public static VScrollBar Maximum(this VScrollBar control, Int32 value)
        {
            control.Maximum = value;
            return control;
        }

        public static VScrollBar Minimum(this VScrollBar control, Int32 value)
        {
            control.Minimum = value;
            return control;
        }

        public static VScrollBar SmallChange(this VScrollBar control, Int32 value)
        {
            control.SmallChange = value;
            return control;
        }

        public static VScrollBar TabStop(this VScrollBar control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static VScrollBar Text(this VScrollBar control, String value)
        {
            control.Text = value;
            return control;
        }

        public static VScrollBar Value(this VScrollBar control, Int32 value)
        {
            control.Value = value;
            return control;
        }

        public static VScrollBar ScaleScrollBarForDpiChange(this VScrollBar control, Boolean value)
        {
            control.ScaleScrollBarForDpiChange = value;
            return control;
        }

        public static VScrollBar AccessibleDefaultActionDescription(this VScrollBar control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static VScrollBar AccessibleDescription(this VScrollBar control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static VScrollBar AccessibleName(this VScrollBar control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static VScrollBar AccessibleRole(this VScrollBar control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static VScrollBar AllowDrop(this VScrollBar control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static VScrollBar Anchor(this VScrollBar control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static VScrollBar AutoScrollOffset(this VScrollBar control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static VScrollBar AutoScrollOffset(this VScrollBar control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static VScrollBar DataContext(this VScrollBar control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static VScrollBar BindingContext(this VScrollBar control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static VScrollBar Bounds(this VScrollBar control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static VScrollBar Bounds(this VScrollBar control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static VScrollBar Bounds(this VScrollBar control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static VScrollBar Capture(this VScrollBar control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static VScrollBar CausesValidation(this VScrollBar control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static VScrollBar ClientSize(this VScrollBar control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static VScrollBar ClientSize(this VScrollBar control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static VScrollBar ContextMenuStrip(this VScrollBar control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static VScrollBar Cursor(this VScrollBar control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static VScrollBar Dock(this VScrollBar control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static VScrollBar Enabled(this VScrollBar control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static VScrollBar Height(this VScrollBar control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static VScrollBar IsAccessible(this VScrollBar control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static VScrollBar Left(this VScrollBar control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static VScrollBar Location(this VScrollBar control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static VScrollBar Location(this VScrollBar control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static VScrollBar Margin(this VScrollBar control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static VScrollBar MaximumSize(this VScrollBar control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static VScrollBar MaximumSize(this VScrollBar control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static VScrollBar MinimumSize(this VScrollBar control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static VScrollBar MinimumSize(this VScrollBar control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static VScrollBar Name(this VScrollBar control, String value)
        {
            control.Name = value;
            return control;
        }

        public static VScrollBar Parent(this VScrollBar control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static VScrollBar Region(this VScrollBar control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static VScrollBar Size(this VScrollBar control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static VScrollBar Size(this VScrollBar control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static VScrollBar TabIndex(this VScrollBar control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static VScrollBar Tag(this VScrollBar control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static VScrollBar Top(this VScrollBar control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static VScrollBar UseWaitCursor(this VScrollBar control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static VScrollBar Visible(this VScrollBar control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static VScrollBar Width(this VScrollBar control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static VScrollBar WindowTarget(this VScrollBar control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static VScrollBar Padding(this VScrollBar control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static VScrollBar OnRightToLeftChanged(this VScrollBar control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static VScrollBar OnAutoSizeChanged(this VScrollBar control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static VScrollBar OnBackColorChanged(this VScrollBar control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static VScrollBar OnBackgroundImageChanged(this VScrollBar control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static VScrollBar OnBackgroundImageLayoutChanged(this VScrollBar control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static VScrollBar OnForeColorChanged(this VScrollBar control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static VScrollBar OnFontChanged(this VScrollBar control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static VScrollBar OnImeModeChanged(this VScrollBar control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static VScrollBar OnTextChanged(this VScrollBar control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static VScrollBar OnClick(this VScrollBar control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static VScrollBar OnPaint(this VScrollBar control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static VScrollBar OnDoubleClick(this VScrollBar control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static VScrollBar OnMouseClick(this VScrollBar control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static VScrollBar OnMouseDoubleClick(this VScrollBar control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static VScrollBar OnMouseDown(this VScrollBar control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static VScrollBar OnMouseUp(this VScrollBar control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static VScrollBar OnMouseMove(this VScrollBar control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static VScrollBar OnScroll(this VScrollBar control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static VScrollBar OnValueChanged(this VScrollBar control, EventHandler handler)
        {
            control.ValueChanged += handler;
            return control;
        }

        public static VScrollBar OnBindingContextChanged(this VScrollBar control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static VScrollBar OnCausesValidationChanged(this VScrollBar control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static VScrollBar OnClientSizeChanged(this VScrollBar control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static VScrollBar OnContextMenuStripChanged(this VScrollBar control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static VScrollBar OnCursorChanged(this VScrollBar control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static VScrollBar OnDockChanged(this VScrollBar control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static VScrollBar OnEnabledChanged(this VScrollBar control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static VScrollBar OnLocationChanged(this VScrollBar control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static VScrollBar OnMarginChanged(this VScrollBar control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static VScrollBar OnRegionChanged(this VScrollBar control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static VScrollBar OnSizeChanged(this VScrollBar control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static VScrollBar OnTabIndexChanged(this VScrollBar control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static VScrollBar OnTabStopChanged(this VScrollBar control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static VScrollBar OnVisibleChanged(this VScrollBar control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static VScrollBar OnControlAdded(this VScrollBar control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static VScrollBar OnControlRemoved(this VScrollBar control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static VScrollBar OnDataContextChanged(this VScrollBar control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static VScrollBar OnDragDrop(this VScrollBar control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static VScrollBar OnDragEnter(this VScrollBar control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static VScrollBar OnDragOver(this VScrollBar control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static VScrollBar OnDragLeave(this VScrollBar control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static VScrollBar OnGiveFeedback(this VScrollBar control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static VScrollBar OnHandleCreated(this VScrollBar control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static VScrollBar OnHandleDestroyed(this VScrollBar control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static VScrollBar OnHelpRequested(this VScrollBar control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static VScrollBar OnInvalidated(this VScrollBar control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static VScrollBar OnPaddingChanged(this VScrollBar control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static VScrollBar OnQueryContinueDrag(this VScrollBar control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static VScrollBar OnQueryAccessibilityHelp(this VScrollBar control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static VScrollBar OnEnter(this VScrollBar control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static VScrollBar OnGotFocus(this VScrollBar control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static VScrollBar OnKeyDown(this VScrollBar control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static VScrollBar OnKeyPress(this VScrollBar control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static VScrollBar OnKeyUp(this VScrollBar control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static VScrollBar OnLayout(this VScrollBar control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static VScrollBar OnLeave(this VScrollBar control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static VScrollBar OnLostFocus(this VScrollBar control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static VScrollBar OnMouseCaptureChanged(this VScrollBar control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static VScrollBar OnMouseEnter(this VScrollBar control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static VScrollBar OnMouseLeave(this VScrollBar control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static VScrollBar OnDpiChangedBeforeParent(this VScrollBar control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static VScrollBar OnDpiChangedAfterParent(this VScrollBar control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static VScrollBar OnMouseHover(this VScrollBar control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static VScrollBar OnMouseWheel(this VScrollBar control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static VScrollBar OnMove(this VScrollBar control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static VScrollBar OnPreviewKeyDown(this VScrollBar control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static VScrollBar OnResize(this VScrollBar control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static VScrollBar OnChangeUICues(this VScrollBar control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static VScrollBar OnStyleChanged(this VScrollBar control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static VScrollBar OnSystemColorsChanged(this VScrollBar control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static VScrollBar OnValidating(this VScrollBar control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static VScrollBar OnValidated(this VScrollBar control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static VScrollBar OnParentChanged(this VScrollBar control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static VScrollBar OnDisposed(this VScrollBar control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static VScrollBar AddTo(this VScrollBar control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static VScrollBar Assign(this VScrollBar control, out VScrollBar variable)
        {
            variable = control;
            return control;
        }

    }
}

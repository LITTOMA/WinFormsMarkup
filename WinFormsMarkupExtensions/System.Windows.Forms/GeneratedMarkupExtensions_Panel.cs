using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class PanelExtensions
    {
        public static Panel AutoSize(this Panel control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static Panel AutoSizeMode(this Panel control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static Panel BorderStyle(this Panel control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static Panel TabStop(this Panel control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static Panel Text(this Panel control, String value)
        {
            control.Text = value;
            return control;
        }

        public static Panel AutoScroll(this Panel control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static Panel AutoScrollMargin(this Panel control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static Panel AutoScrollMargin(this Panel control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static Panel AutoScrollPosition(this Panel control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static Panel AutoScrollPosition(this Panel control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static Panel AutoScrollMinSize(this Panel control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static Panel AutoScrollMinSize(this Panel control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static Panel AccessibleDefaultActionDescription(this Panel control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static Panel AccessibleDescription(this Panel control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static Panel AccessibleName(this Panel control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static Panel AccessibleRole(this Panel control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static Panel AllowDrop(this Panel control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static Panel Anchor(this Panel control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static Panel AutoScrollOffset(this Panel control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static Panel AutoScrollOffset(this Panel control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static Panel DataContext(this Panel control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static Panel BackColor(this Panel control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Panel BackColor(this Panel control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Panel BackColor(this Panel control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static Panel BackgroundImage(this Panel control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static Panel BackgroundImageLayout(this Panel control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static Panel BindingContext(this Panel control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static Panel Bounds(this Panel control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static Panel Bounds(this Panel control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static Panel Bounds(this Panel control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static Panel Capture(this Panel control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static Panel CausesValidation(this Panel control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static Panel ClientSize(this Panel control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static Panel ClientSize(this Panel control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static Panel ContextMenuStrip(this Panel control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static Panel Cursor(this Panel control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static Panel Dock(this Panel control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static Panel Enabled(this Panel control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static Panel Font(this Panel control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static Panel Font(this Panel control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static Panel ForeColor(this Panel control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Panel ForeColor(this Panel control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Panel ForeColor(this Panel control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static Panel Height(this Panel control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static Panel IsAccessible(this Panel control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static Panel Left(this Panel control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static Panel Location(this Panel control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static Panel Location(this Panel control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static Panel Margin(this Panel control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static Panel MaximumSize(this Panel control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static Panel MaximumSize(this Panel control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static Panel MinimumSize(this Panel control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static Panel MinimumSize(this Panel control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static Panel Name(this Panel control, String value)
        {
            control.Name = value;
            return control;
        }

        public static Panel Parent(this Panel control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static Panel Region(this Panel control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static Panel RightToLeft(this Panel control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static Panel Size(this Panel control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static Panel Size(this Panel control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static Panel TabIndex(this Panel control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static Panel Tag(this Panel control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static Panel Top(this Panel control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static Panel UseWaitCursor(this Panel control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static Panel Visible(this Panel control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static Panel Width(this Panel control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static Panel WindowTarget(this Panel control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static Panel Padding(this Panel control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static Panel ImeMode(this Panel control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static Panel OnAutoSizeChanged(this Panel control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static Panel OnKeyUp(this Panel control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static Panel OnKeyDown(this Panel control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static Panel OnKeyPress(this Panel control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static Panel OnTextChanged(this Panel control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static Panel OnScroll(this Panel control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static Panel OnBackColorChanged(this Panel control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static Panel OnBackgroundImageChanged(this Panel control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static Panel OnBackgroundImageLayoutChanged(this Panel control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static Panel OnBindingContextChanged(this Panel control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static Panel OnCausesValidationChanged(this Panel control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static Panel OnClientSizeChanged(this Panel control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static Panel OnContextMenuStripChanged(this Panel control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static Panel OnCursorChanged(this Panel control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static Panel OnDockChanged(this Panel control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static Panel OnEnabledChanged(this Panel control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static Panel OnFontChanged(this Panel control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static Panel OnForeColorChanged(this Panel control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static Panel OnLocationChanged(this Panel control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static Panel OnMarginChanged(this Panel control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static Panel OnRegionChanged(this Panel control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static Panel OnRightToLeftChanged(this Panel control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static Panel OnSizeChanged(this Panel control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static Panel OnTabIndexChanged(this Panel control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static Panel OnTabStopChanged(this Panel control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static Panel OnVisibleChanged(this Panel control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static Panel OnClick(this Panel control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static Panel OnControlAdded(this Panel control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static Panel OnControlRemoved(this Panel control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static Panel OnDataContextChanged(this Panel control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static Panel OnDragDrop(this Panel control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static Panel OnDragEnter(this Panel control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static Panel OnDragOver(this Panel control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static Panel OnDragLeave(this Panel control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static Panel OnGiveFeedback(this Panel control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static Panel OnHandleCreated(this Panel control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static Panel OnHandleDestroyed(this Panel control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static Panel OnHelpRequested(this Panel control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static Panel OnInvalidated(this Panel control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static Panel OnPaddingChanged(this Panel control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static Panel OnPaint(this Panel control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static Panel OnQueryContinueDrag(this Panel control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static Panel OnQueryAccessibilityHelp(this Panel control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static Panel OnDoubleClick(this Panel control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static Panel OnEnter(this Panel control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static Panel OnGotFocus(this Panel control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static Panel OnLayout(this Panel control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static Panel OnLeave(this Panel control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static Panel OnLostFocus(this Panel control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static Panel OnMouseClick(this Panel control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static Panel OnMouseDoubleClick(this Panel control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static Panel OnMouseCaptureChanged(this Panel control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static Panel OnMouseDown(this Panel control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static Panel OnMouseEnter(this Panel control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static Panel OnMouseLeave(this Panel control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static Panel OnDpiChangedBeforeParent(this Panel control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static Panel OnDpiChangedAfterParent(this Panel control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static Panel OnMouseHover(this Panel control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static Panel OnMouseMove(this Panel control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static Panel OnMouseUp(this Panel control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static Panel OnMouseWheel(this Panel control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static Panel OnMove(this Panel control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static Panel OnPreviewKeyDown(this Panel control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static Panel OnResize(this Panel control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static Panel OnChangeUICues(this Panel control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static Panel OnStyleChanged(this Panel control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static Panel OnSystemColorsChanged(this Panel control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static Panel OnValidating(this Panel control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static Panel OnValidated(this Panel control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static Panel OnParentChanged(this Panel control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static Panel OnImeModeChanged(this Panel control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static Panel OnDisposed(this Panel control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static Panel AddTo(this Panel control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static Panel Assign(this Panel control, out Panel variable)
        {
            variable = control;
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class FlowLayoutPanelExtensions
    {
        public static FlowLayoutPanel FlowDirection(this FlowLayoutPanel control, FlowDirection value)
        {
            control.FlowDirection = value;
            return control;
        }

        public static FlowLayoutPanel WrapContents(this FlowLayoutPanel control, Boolean value)
        {
            control.WrapContents = value;
            return control;
        }

        public static FlowLayoutPanel AutoSize(this FlowLayoutPanel control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static FlowLayoutPanel AutoSizeMode(this FlowLayoutPanel control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static FlowLayoutPanel BorderStyle(this FlowLayoutPanel control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static FlowLayoutPanel TabStop(this FlowLayoutPanel control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static FlowLayoutPanel Text(this FlowLayoutPanel control, String value)
        {
            control.Text = value;
            return control;
        }

        public static FlowLayoutPanel AutoScroll(this FlowLayoutPanel control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static FlowLayoutPanel AutoScrollMargin(this FlowLayoutPanel control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static FlowLayoutPanel AutoScrollMargin(this FlowLayoutPanel control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static FlowLayoutPanel AutoScrollPosition(this FlowLayoutPanel control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static FlowLayoutPanel AutoScrollPosition(this FlowLayoutPanel control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static FlowLayoutPanel AutoScrollMinSize(this FlowLayoutPanel control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static FlowLayoutPanel AutoScrollMinSize(this FlowLayoutPanel control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static FlowLayoutPanel AccessibleDefaultActionDescription(this FlowLayoutPanel control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static FlowLayoutPanel AccessibleDescription(this FlowLayoutPanel control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static FlowLayoutPanel AccessibleName(this FlowLayoutPanel control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static FlowLayoutPanel AccessibleRole(this FlowLayoutPanel control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static FlowLayoutPanel AllowDrop(this FlowLayoutPanel control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static FlowLayoutPanel Anchor(this FlowLayoutPanel control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static FlowLayoutPanel AutoScrollOffset(this FlowLayoutPanel control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static FlowLayoutPanel AutoScrollOffset(this FlowLayoutPanel control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static FlowLayoutPanel DataContext(this FlowLayoutPanel control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static FlowLayoutPanel BackColor(this FlowLayoutPanel control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static FlowLayoutPanel BackColor(this FlowLayoutPanel control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static FlowLayoutPanel BackColor(this FlowLayoutPanel control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static FlowLayoutPanel BackgroundImage(this FlowLayoutPanel control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static FlowLayoutPanel BackgroundImageLayout(this FlowLayoutPanel control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static FlowLayoutPanel BindingContext(this FlowLayoutPanel control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static FlowLayoutPanel Bounds(this FlowLayoutPanel control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static FlowLayoutPanel Bounds(this FlowLayoutPanel control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static FlowLayoutPanel Bounds(this FlowLayoutPanel control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static FlowLayoutPanel Capture(this FlowLayoutPanel control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static FlowLayoutPanel CausesValidation(this FlowLayoutPanel control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static FlowLayoutPanel ClientSize(this FlowLayoutPanel control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static FlowLayoutPanel ClientSize(this FlowLayoutPanel control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static FlowLayoutPanel ContextMenuStrip(this FlowLayoutPanel control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static FlowLayoutPanel Cursor(this FlowLayoutPanel control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static FlowLayoutPanel Dock(this FlowLayoutPanel control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static FlowLayoutPanel Enabled(this FlowLayoutPanel control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static FlowLayoutPanel Font(this FlowLayoutPanel control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static FlowLayoutPanel Font(this FlowLayoutPanel control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static FlowLayoutPanel ForeColor(this FlowLayoutPanel control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static FlowLayoutPanel ForeColor(this FlowLayoutPanel control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static FlowLayoutPanel ForeColor(this FlowLayoutPanel control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static FlowLayoutPanel Height(this FlowLayoutPanel control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static FlowLayoutPanel IsAccessible(this FlowLayoutPanel control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static FlowLayoutPanel Left(this FlowLayoutPanel control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static FlowLayoutPanel Location(this FlowLayoutPanel control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static FlowLayoutPanel Location(this FlowLayoutPanel control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static FlowLayoutPanel Margin(this FlowLayoutPanel control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static FlowLayoutPanel MaximumSize(this FlowLayoutPanel control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static FlowLayoutPanel MaximumSize(this FlowLayoutPanel control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static FlowLayoutPanel MinimumSize(this FlowLayoutPanel control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static FlowLayoutPanel MinimumSize(this FlowLayoutPanel control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static FlowLayoutPanel Name(this FlowLayoutPanel control, String value)
        {
            control.Name = value;
            return control;
        }

        public static FlowLayoutPanel Parent(this FlowLayoutPanel control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static FlowLayoutPanel Region(this FlowLayoutPanel control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static FlowLayoutPanel RightToLeft(this FlowLayoutPanel control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static FlowLayoutPanel Size(this FlowLayoutPanel control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static FlowLayoutPanel Size(this FlowLayoutPanel control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static FlowLayoutPanel TabIndex(this FlowLayoutPanel control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static FlowLayoutPanel Tag(this FlowLayoutPanel control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static FlowLayoutPanel Top(this FlowLayoutPanel control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static FlowLayoutPanel UseWaitCursor(this FlowLayoutPanel control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static FlowLayoutPanel Visible(this FlowLayoutPanel control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static FlowLayoutPanel Width(this FlowLayoutPanel control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static FlowLayoutPanel WindowTarget(this FlowLayoutPanel control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static FlowLayoutPanel Padding(this FlowLayoutPanel control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static FlowLayoutPanel ImeMode(this FlowLayoutPanel control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static FlowLayoutPanel OnAutoSizeChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnKeyUp(this FlowLayoutPanel control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static FlowLayoutPanel OnKeyDown(this FlowLayoutPanel control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static FlowLayoutPanel OnKeyPress(this FlowLayoutPanel control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static FlowLayoutPanel OnTextChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnScroll(this FlowLayoutPanel control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static FlowLayoutPanel OnBackColorChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnBackgroundImageChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnBackgroundImageLayoutChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnBindingContextChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnCausesValidationChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnClientSizeChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnContextMenuStripChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnCursorChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnDockChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnEnabledChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnFontChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnForeColorChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnLocationChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnMarginChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnRegionChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnRightToLeftChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnSizeChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnTabIndexChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnTabStopChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnVisibleChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnClick(this FlowLayoutPanel control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static FlowLayoutPanel OnControlAdded(this FlowLayoutPanel control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static FlowLayoutPanel OnControlRemoved(this FlowLayoutPanel control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static FlowLayoutPanel OnDataContextChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnDragDrop(this FlowLayoutPanel control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static FlowLayoutPanel OnDragEnter(this FlowLayoutPanel control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static FlowLayoutPanel OnDragOver(this FlowLayoutPanel control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static FlowLayoutPanel OnDragLeave(this FlowLayoutPanel control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static FlowLayoutPanel OnGiveFeedback(this FlowLayoutPanel control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static FlowLayoutPanel OnHandleCreated(this FlowLayoutPanel control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static FlowLayoutPanel OnHandleDestroyed(this FlowLayoutPanel control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static FlowLayoutPanel OnHelpRequested(this FlowLayoutPanel control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static FlowLayoutPanel OnInvalidated(this FlowLayoutPanel control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static FlowLayoutPanel OnPaddingChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnPaint(this FlowLayoutPanel control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static FlowLayoutPanel OnQueryContinueDrag(this FlowLayoutPanel control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static FlowLayoutPanel OnQueryAccessibilityHelp(this FlowLayoutPanel control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static FlowLayoutPanel OnDoubleClick(this FlowLayoutPanel control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static FlowLayoutPanel OnEnter(this FlowLayoutPanel control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static FlowLayoutPanel OnGotFocus(this FlowLayoutPanel control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static FlowLayoutPanel OnLayout(this FlowLayoutPanel control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static FlowLayoutPanel OnLeave(this FlowLayoutPanel control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static FlowLayoutPanel OnLostFocus(this FlowLayoutPanel control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseClick(this FlowLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseDoubleClick(this FlowLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseCaptureChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseDown(this FlowLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseEnter(this FlowLayoutPanel control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseLeave(this FlowLayoutPanel control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static FlowLayoutPanel OnDpiChangedBeforeParent(this FlowLayoutPanel control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static FlowLayoutPanel OnDpiChangedAfterParent(this FlowLayoutPanel control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseHover(this FlowLayoutPanel control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseMove(this FlowLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseUp(this FlowLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static FlowLayoutPanel OnMouseWheel(this FlowLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static FlowLayoutPanel OnMove(this FlowLayoutPanel control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static FlowLayoutPanel OnPreviewKeyDown(this FlowLayoutPanel control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static FlowLayoutPanel OnResize(this FlowLayoutPanel control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static FlowLayoutPanel OnChangeUICues(this FlowLayoutPanel control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static FlowLayoutPanel OnStyleChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnSystemColorsChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnValidating(this FlowLayoutPanel control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static FlowLayoutPanel OnValidated(this FlowLayoutPanel control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static FlowLayoutPanel OnParentChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnImeModeChanged(this FlowLayoutPanel control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static FlowLayoutPanel OnDisposed(this FlowLayoutPanel control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static FlowLayoutPanel AddTo(this FlowLayoutPanel control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static FlowLayoutPanel Assign(this FlowLayoutPanel control, out FlowLayoutPanel variable)
        {
            variable = control;
            return control;
        }

    }
}

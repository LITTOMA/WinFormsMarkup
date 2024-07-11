using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class StatusStripExtensions
    {
        public static StatusStrip CanOverflow(this StatusStrip control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static StatusStrip Dock(this StatusStrip control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static StatusStrip GripStyle(this StatusStrip control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static StatusStrip LayoutStyle(this StatusStrip control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static StatusStrip Padding(this StatusStrip control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static StatusStrip ShowItemToolTips(this StatusStrip control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static StatusStrip SizingGrip(this StatusStrip control, Boolean value)
        {
            control.SizingGrip = value;
            return control;
        }

        public static StatusStrip Stretch(this StatusStrip control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static StatusStrip AutoSize(this StatusStrip control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static StatusStrip AutoScroll(this StatusStrip control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static StatusStrip AutoScrollMargin(this StatusStrip control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static StatusStrip AutoScrollMargin(this StatusStrip control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static StatusStrip AutoScrollMinSize(this StatusStrip control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static StatusStrip AutoScrollMinSize(this StatusStrip control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static StatusStrip AutoScrollPosition(this StatusStrip control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static StatusStrip AutoScrollPosition(this StatusStrip control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static StatusStrip AllowDrop(this StatusStrip control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static StatusStrip AllowItemReorder(this StatusStrip control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static StatusStrip AllowMerge(this StatusStrip control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static StatusStrip Anchor(this StatusStrip control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static StatusStrip BackColor(this StatusStrip control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static StatusStrip BackColor(this StatusStrip control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static StatusStrip BackColor(this StatusStrip control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static StatusStrip BindingContext(this StatusStrip control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static StatusStrip CausesValidation(this StatusStrip control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static StatusStrip Cursor(this StatusStrip control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static StatusStrip Font(this StatusStrip control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static StatusStrip Font(this StatusStrip control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static StatusStrip DefaultDropDownDirection(this StatusStrip control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static StatusStrip ForeColor(this StatusStrip control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static StatusStrip ForeColor(this StatusStrip control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static StatusStrip ForeColor(this StatusStrip control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static StatusStrip GripMargin(this StatusStrip control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static StatusStrip ImageScalingSize(this StatusStrip control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static StatusStrip ImageScalingSize(this StatusStrip control, Size size)
        {
            control.ImageScalingSize = size;
            return control;
        }

        public static StatusStrip ImageList(this StatusStrip control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static StatusStrip LayoutSettings(this StatusStrip control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static StatusStrip Renderer(this StatusStrip control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static StatusStrip RenderMode(this StatusStrip control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static StatusStrip TabStop(this StatusStrip control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static StatusStrip TextDirection(this StatusStrip control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static StatusStrip AccessibleDefaultActionDescription(this StatusStrip control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static StatusStrip AccessibleDescription(this StatusStrip control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static StatusStrip AccessibleName(this StatusStrip control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static StatusStrip AccessibleRole(this StatusStrip control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static StatusStrip AutoScrollOffset(this StatusStrip control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static StatusStrip AutoScrollOffset(this StatusStrip control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static StatusStrip DataContext(this StatusStrip control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static StatusStrip BackgroundImage(this StatusStrip control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static StatusStrip BackgroundImageLayout(this StatusStrip control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static StatusStrip Bounds(this StatusStrip control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static StatusStrip Bounds(this StatusStrip control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static StatusStrip Bounds(this StatusStrip control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static StatusStrip Capture(this StatusStrip control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static StatusStrip ClientSize(this StatusStrip control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static StatusStrip ClientSize(this StatusStrip control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static StatusStrip ContextMenuStrip(this StatusStrip control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static StatusStrip Enabled(this StatusStrip control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static StatusStrip Height(this StatusStrip control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static StatusStrip IsAccessible(this StatusStrip control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static StatusStrip Left(this StatusStrip control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static StatusStrip Location(this StatusStrip control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static StatusStrip Location(this StatusStrip control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static StatusStrip Margin(this StatusStrip control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static StatusStrip MaximumSize(this StatusStrip control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static StatusStrip MaximumSize(this StatusStrip control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static StatusStrip MinimumSize(this StatusStrip control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static StatusStrip MinimumSize(this StatusStrip control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static StatusStrip Name(this StatusStrip control, String value)
        {
            control.Name = value;
            return control;
        }

        public static StatusStrip Parent(this StatusStrip control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static StatusStrip Region(this StatusStrip control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static StatusStrip RightToLeft(this StatusStrip control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static StatusStrip Size(this StatusStrip control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static StatusStrip Size(this StatusStrip control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static StatusStrip TabIndex(this StatusStrip control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static StatusStrip Tag(this StatusStrip control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static StatusStrip Text(this StatusStrip control, String value)
        {
            control.Text = value;
            return control;
        }

        public static StatusStrip Top(this StatusStrip control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static StatusStrip UseWaitCursor(this StatusStrip control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static StatusStrip Visible(this StatusStrip control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static StatusStrip Width(this StatusStrip control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static StatusStrip WindowTarget(this StatusStrip control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static StatusStrip ImeMode(this StatusStrip control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static StatusStrip OnPaddingChanged(this StatusStrip control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static StatusStrip OnAutoSizeChanged(this StatusStrip control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static StatusStrip OnBeginDrag(this StatusStrip control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static StatusStrip OnCausesValidationChanged(this StatusStrip control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static StatusStrip OnControlAdded(this StatusStrip control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static StatusStrip OnCursorChanged(this StatusStrip control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static StatusStrip OnControlRemoved(this StatusStrip control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static StatusStrip OnEndDrag(this StatusStrip control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static StatusStrip OnForeColorChanged(this StatusStrip control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static StatusStrip OnItemAdded(this StatusStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static StatusStrip OnItemClicked(this StatusStrip control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static StatusStrip OnItemRemoved(this StatusStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static StatusStrip OnLayoutCompleted(this StatusStrip control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static StatusStrip OnLayoutStyleChanged(this StatusStrip control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static StatusStrip OnPaintGrip(this StatusStrip control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static StatusStrip OnRendererChanged(this StatusStrip control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static StatusStrip OnScroll(this StatusStrip control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static StatusStrip OnBackColorChanged(this StatusStrip control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static StatusStrip OnBackgroundImageChanged(this StatusStrip control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static StatusStrip OnBackgroundImageLayoutChanged(this StatusStrip control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static StatusStrip OnBindingContextChanged(this StatusStrip control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static StatusStrip OnClientSizeChanged(this StatusStrip control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static StatusStrip OnContextMenuStripChanged(this StatusStrip control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static StatusStrip OnDockChanged(this StatusStrip control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static StatusStrip OnEnabledChanged(this StatusStrip control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static StatusStrip OnFontChanged(this StatusStrip control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static StatusStrip OnLocationChanged(this StatusStrip control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static StatusStrip OnMarginChanged(this StatusStrip control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static StatusStrip OnRegionChanged(this StatusStrip control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static StatusStrip OnRightToLeftChanged(this StatusStrip control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static StatusStrip OnSizeChanged(this StatusStrip control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static StatusStrip OnTabIndexChanged(this StatusStrip control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static StatusStrip OnTabStopChanged(this StatusStrip control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static StatusStrip OnTextChanged(this StatusStrip control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static StatusStrip OnVisibleChanged(this StatusStrip control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static StatusStrip OnClick(this StatusStrip control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static StatusStrip OnDataContextChanged(this StatusStrip control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static StatusStrip OnDragDrop(this StatusStrip control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static StatusStrip OnDragEnter(this StatusStrip control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static StatusStrip OnDragOver(this StatusStrip control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static StatusStrip OnDragLeave(this StatusStrip control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static StatusStrip OnGiveFeedback(this StatusStrip control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static StatusStrip OnHandleCreated(this StatusStrip control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static StatusStrip OnHandleDestroyed(this StatusStrip control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static StatusStrip OnHelpRequested(this StatusStrip control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static StatusStrip OnInvalidated(this StatusStrip control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static StatusStrip OnPaint(this StatusStrip control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static StatusStrip OnQueryContinueDrag(this StatusStrip control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static StatusStrip OnQueryAccessibilityHelp(this StatusStrip control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static StatusStrip OnDoubleClick(this StatusStrip control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static StatusStrip OnEnter(this StatusStrip control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static StatusStrip OnGotFocus(this StatusStrip control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static StatusStrip OnKeyDown(this StatusStrip control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static StatusStrip OnKeyPress(this StatusStrip control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static StatusStrip OnKeyUp(this StatusStrip control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static StatusStrip OnLayout(this StatusStrip control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static StatusStrip OnLeave(this StatusStrip control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static StatusStrip OnLostFocus(this StatusStrip control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static StatusStrip OnMouseClick(this StatusStrip control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static StatusStrip OnMouseDoubleClick(this StatusStrip control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static StatusStrip OnMouseCaptureChanged(this StatusStrip control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static StatusStrip OnMouseDown(this StatusStrip control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static StatusStrip OnMouseEnter(this StatusStrip control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static StatusStrip OnMouseLeave(this StatusStrip control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static StatusStrip OnDpiChangedBeforeParent(this StatusStrip control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static StatusStrip OnDpiChangedAfterParent(this StatusStrip control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static StatusStrip OnMouseHover(this StatusStrip control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static StatusStrip OnMouseMove(this StatusStrip control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static StatusStrip OnMouseUp(this StatusStrip control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static StatusStrip OnMouseWheel(this StatusStrip control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static StatusStrip OnMove(this StatusStrip control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static StatusStrip OnPreviewKeyDown(this StatusStrip control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static StatusStrip OnResize(this StatusStrip control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static StatusStrip OnChangeUICues(this StatusStrip control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static StatusStrip OnStyleChanged(this StatusStrip control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static StatusStrip OnSystemColorsChanged(this StatusStrip control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static StatusStrip OnValidating(this StatusStrip control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static StatusStrip OnValidated(this StatusStrip control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static StatusStrip OnParentChanged(this StatusStrip control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static StatusStrip OnImeModeChanged(this StatusStrip control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static StatusStrip OnDisposed(this StatusStrip control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static StatusStrip AddTo(this StatusStrip control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static StatusStrip Assign(this StatusStrip control, out StatusStrip variable)
        {
            variable = control;
            return control;
        }

    }
}

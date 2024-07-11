using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class MenuStripExtensions
    {
        public static MenuStrip CanOverflow(this MenuStrip control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static MenuStrip GripStyle(this MenuStrip control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static MenuStrip ShowItemToolTips(this MenuStrip control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static MenuStrip Stretch(this MenuStrip control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static MenuStrip MdiWindowListItem(this MenuStrip control, ToolStripMenuItem value)
        {
            control.MdiWindowListItem = value;
            return control;
        }

        public static MenuStrip AutoSize(this MenuStrip control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static MenuStrip AutoScroll(this MenuStrip control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static MenuStrip AutoScrollMargin(this MenuStrip control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static MenuStrip AutoScrollMargin(this MenuStrip control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static MenuStrip AutoScrollMinSize(this MenuStrip control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static MenuStrip AutoScrollMinSize(this MenuStrip control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static MenuStrip AutoScrollPosition(this MenuStrip control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static MenuStrip AutoScrollPosition(this MenuStrip control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static MenuStrip AllowDrop(this MenuStrip control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static MenuStrip AllowItemReorder(this MenuStrip control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static MenuStrip AllowMerge(this MenuStrip control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static MenuStrip Anchor(this MenuStrip control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static MenuStrip BackColor(this MenuStrip control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MenuStrip BackColor(this MenuStrip control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MenuStrip BackColor(this MenuStrip control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static MenuStrip BindingContext(this MenuStrip control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static MenuStrip CausesValidation(this MenuStrip control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static MenuStrip Cursor(this MenuStrip control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static MenuStrip Font(this MenuStrip control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static MenuStrip Font(this MenuStrip control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static MenuStrip DefaultDropDownDirection(this MenuStrip control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static MenuStrip Dock(this MenuStrip control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static MenuStrip ForeColor(this MenuStrip control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MenuStrip ForeColor(this MenuStrip control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MenuStrip ForeColor(this MenuStrip control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static MenuStrip GripMargin(this MenuStrip control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static MenuStrip ImageScalingSize(this MenuStrip control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static MenuStrip ImageScalingSize(this MenuStrip control, Size size)
        {
            control.ImageScalingSize = size;
            return control;
        }

        public static MenuStrip ImageList(this MenuStrip control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static MenuStrip LayoutSettings(this MenuStrip control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static MenuStrip LayoutStyle(this MenuStrip control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static MenuStrip Renderer(this MenuStrip control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static MenuStrip RenderMode(this MenuStrip control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static MenuStrip TabStop(this MenuStrip control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static MenuStrip TextDirection(this MenuStrip control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static MenuStrip AccessibleDefaultActionDescription(this MenuStrip control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static MenuStrip AccessibleDescription(this MenuStrip control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static MenuStrip AccessibleName(this MenuStrip control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static MenuStrip AccessibleRole(this MenuStrip control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static MenuStrip AutoScrollOffset(this MenuStrip control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static MenuStrip AutoScrollOffset(this MenuStrip control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static MenuStrip DataContext(this MenuStrip control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static MenuStrip BackgroundImage(this MenuStrip control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static MenuStrip BackgroundImageLayout(this MenuStrip control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static MenuStrip Bounds(this MenuStrip control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static MenuStrip Bounds(this MenuStrip control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static MenuStrip Bounds(this MenuStrip control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static MenuStrip Capture(this MenuStrip control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static MenuStrip ClientSize(this MenuStrip control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static MenuStrip ClientSize(this MenuStrip control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static MenuStrip ContextMenuStrip(this MenuStrip control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static MenuStrip Enabled(this MenuStrip control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static MenuStrip Height(this MenuStrip control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static MenuStrip IsAccessible(this MenuStrip control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static MenuStrip Left(this MenuStrip control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static MenuStrip Location(this MenuStrip control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static MenuStrip Location(this MenuStrip control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static MenuStrip Margin(this MenuStrip control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static MenuStrip MaximumSize(this MenuStrip control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static MenuStrip MaximumSize(this MenuStrip control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static MenuStrip MinimumSize(this MenuStrip control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static MenuStrip MinimumSize(this MenuStrip control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static MenuStrip Name(this MenuStrip control, String value)
        {
            control.Name = value;
            return control;
        }

        public static MenuStrip Parent(this MenuStrip control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static MenuStrip Region(this MenuStrip control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static MenuStrip RightToLeft(this MenuStrip control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static MenuStrip Size(this MenuStrip control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static MenuStrip Size(this MenuStrip control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static MenuStrip TabIndex(this MenuStrip control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static MenuStrip Tag(this MenuStrip control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static MenuStrip Text(this MenuStrip control, String value)
        {
            control.Text = value;
            return control;
        }

        public static MenuStrip Top(this MenuStrip control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static MenuStrip UseWaitCursor(this MenuStrip control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static MenuStrip Visible(this MenuStrip control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static MenuStrip Width(this MenuStrip control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static MenuStrip WindowTarget(this MenuStrip control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static MenuStrip Padding(this MenuStrip control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static MenuStrip ImeMode(this MenuStrip control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static MenuStrip OnMenuActivate(this MenuStrip control, EventHandler handler)
        {
            control.MenuActivate += handler;
            return control;
        }

        public static MenuStrip OnMenuDeactivate(this MenuStrip control, EventHandler handler)
        {
            control.MenuDeactivate += handler;
            return control;
        }

        public static MenuStrip OnAutoSizeChanged(this MenuStrip control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static MenuStrip OnBeginDrag(this MenuStrip control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static MenuStrip OnCausesValidationChanged(this MenuStrip control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static MenuStrip OnControlAdded(this MenuStrip control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static MenuStrip OnCursorChanged(this MenuStrip control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static MenuStrip OnControlRemoved(this MenuStrip control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static MenuStrip OnEndDrag(this MenuStrip control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static MenuStrip OnForeColorChanged(this MenuStrip control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static MenuStrip OnItemAdded(this MenuStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static MenuStrip OnItemClicked(this MenuStrip control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static MenuStrip OnItemRemoved(this MenuStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static MenuStrip OnLayoutCompleted(this MenuStrip control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static MenuStrip OnLayoutStyleChanged(this MenuStrip control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static MenuStrip OnPaintGrip(this MenuStrip control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static MenuStrip OnRendererChanged(this MenuStrip control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static MenuStrip OnScroll(this MenuStrip control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static MenuStrip OnBackColorChanged(this MenuStrip control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static MenuStrip OnBackgroundImageChanged(this MenuStrip control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static MenuStrip OnBackgroundImageLayoutChanged(this MenuStrip control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static MenuStrip OnBindingContextChanged(this MenuStrip control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static MenuStrip OnClientSizeChanged(this MenuStrip control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static MenuStrip OnContextMenuStripChanged(this MenuStrip control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static MenuStrip OnDockChanged(this MenuStrip control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static MenuStrip OnEnabledChanged(this MenuStrip control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static MenuStrip OnFontChanged(this MenuStrip control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static MenuStrip OnLocationChanged(this MenuStrip control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static MenuStrip OnMarginChanged(this MenuStrip control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static MenuStrip OnRegionChanged(this MenuStrip control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static MenuStrip OnRightToLeftChanged(this MenuStrip control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static MenuStrip OnSizeChanged(this MenuStrip control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static MenuStrip OnTabIndexChanged(this MenuStrip control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static MenuStrip OnTabStopChanged(this MenuStrip control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static MenuStrip OnTextChanged(this MenuStrip control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static MenuStrip OnVisibleChanged(this MenuStrip control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static MenuStrip OnClick(this MenuStrip control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static MenuStrip OnDataContextChanged(this MenuStrip control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static MenuStrip OnDragDrop(this MenuStrip control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static MenuStrip OnDragEnter(this MenuStrip control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static MenuStrip OnDragOver(this MenuStrip control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static MenuStrip OnDragLeave(this MenuStrip control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static MenuStrip OnGiveFeedback(this MenuStrip control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static MenuStrip OnHandleCreated(this MenuStrip control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static MenuStrip OnHandleDestroyed(this MenuStrip control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static MenuStrip OnHelpRequested(this MenuStrip control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static MenuStrip OnInvalidated(this MenuStrip control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static MenuStrip OnPaddingChanged(this MenuStrip control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static MenuStrip OnPaint(this MenuStrip control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static MenuStrip OnQueryContinueDrag(this MenuStrip control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static MenuStrip OnQueryAccessibilityHelp(this MenuStrip control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static MenuStrip OnDoubleClick(this MenuStrip control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static MenuStrip OnEnter(this MenuStrip control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static MenuStrip OnGotFocus(this MenuStrip control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static MenuStrip OnKeyDown(this MenuStrip control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static MenuStrip OnKeyPress(this MenuStrip control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static MenuStrip OnKeyUp(this MenuStrip control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static MenuStrip OnLayout(this MenuStrip control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static MenuStrip OnLeave(this MenuStrip control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static MenuStrip OnLostFocus(this MenuStrip control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static MenuStrip OnMouseClick(this MenuStrip control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static MenuStrip OnMouseDoubleClick(this MenuStrip control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static MenuStrip OnMouseCaptureChanged(this MenuStrip control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static MenuStrip OnMouseDown(this MenuStrip control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static MenuStrip OnMouseEnter(this MenuStrip control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static MenuStrip OnMouseLeave(this MenuStrip control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static MenuStrip OnDpiChangedBeforeParent(this MenuStrip control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static MenuStrip OnDpiChangedAfterParent(this MenuStrip control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static MenuStrip OnMouseHover(this MenuStrip control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static MenuStrip OnMouseMove(this MenuStrip control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static MenuStrip OnMouseUp(this MenuStrip control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static MenuStrip OnMouseWheel(this MenuStrip control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static MenuStrip OnMove(this MenuStrip control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static MenuStrip OnPreviewKeyDown(this MenuStrip control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static MenuStrip OnResize(this MenuStrip control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static MenuStrip OnChangeUICues(this MenuStrip control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static MenuStrip OnStyleChanged(this MenuStrip control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static MenuStrip OnSystemColorsChanged(this MenuStrip control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static MenuStrip OnValidating(this MenuStrip control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static MenuStrip OnValidated(this MenuStrip control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static MenuStrip OnParentChanged(this MenuStrip control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static MenuStrip OnImeModeChanged(this MenuStrip control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static MenuStrip OnDisposed(this MenuStrip control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static MenuStrip AddTo(this MenuStrip control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static MenuStrip Assign(this MenuStrip control, out MenuStrip variable)
        {
            variable = control;
            return control;
        }

    }
}

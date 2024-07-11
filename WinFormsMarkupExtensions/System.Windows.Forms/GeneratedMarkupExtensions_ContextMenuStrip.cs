using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ContextMenuStripExtensions
    {
        public static ContextMenuStrip LayoutStyle(this ContextMenuStrip control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static ContextMenuStrip ShowImageMargin(this ContextMenuStrip control, Boolean value)
        {
            control.ShowImageMargin = value;
            return control;
        }

        public static ContextMenuStrip ShowCheckMargin(this ContextMenuStrip control, Boolean value)
        {
            control.ShowCheckMargin = value;
            return control;
        }

        public static ContextMenuStrip AllowItemReorder(this ContextMenuStrip control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static ContextMenuStrip AllowTransparency(this ContextMenuStrip control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static ContextMenuStrip Anchor(this ContextMenuStrip control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ContextMenuStrip AutoSize(this ContextMenuStrip control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ContextMenuStrip AutoClose(this ContextMenuStrip control, Boolean value)
        {
            control.AutoClose = value;
            return control;
        }

        public static ContextMenuStrip CanOverflow(this ContextMenuStrip control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static ContextMenuStrip ContextMenuStrip(this ContextMenuStrip control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ContextMenuStrip DefaultDropDownDirection(this ContextMenuStrip control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static ContextMenuStrip Dock(this ContextMenuStrip control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ContextMenuStrip DropShadowEnabled(this ContextMenuStrip control, Boolean value)
        {
            control.DropShadowEnabled = value;
            return control;
        }

        public static ContextMenuStrip Font(this ContextMenuStrip control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ContextMenuStrip Font(this ContextMenuStrip control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ContextMenuStrip GripMargin(this ContextMenuStrip control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static ContextMenuStrip GripStyle(this ContextMenuStrip control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static ContextMenuStrip Location(this ContextMenuStrip control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ContextMenuStrip Location(this ContextMenuStrip control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ContextMenuStrip Opacity(this ContextMenuStrip control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static ContextMenuStrip OwnerItem(this ContextMenuStrip control, ToolStripItem value)
        {
            control.OwnerItem = value;
            return control;
        }

        public static ContextMenuStrip Region(this ContextMenuStrip control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ContextMenuStrip RightToLeft(this ContextMenuStrip control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ContextMenuStrip Stretch(this ContextMenuStrip control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static ContextMenuStrip TextDirection(this ContextMenuStrip control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static ContextMenuStrip TopLevel(this ContextMenuStrip control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static ContextMenuStrip TabIndex(this ContextMenuStrip control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ContextMenuStrip Visible(this ContextMenuStrip control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ContextMenuStrip AutoScroll(this ContextMenuStrip control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ContextMenuStrip AutoScrollMargin(this ContextMenuStrip control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ContextMenuStrip AutoScrollMargin(this ContextMenuStrip control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static ContextMenuStrip AutoScrollMinSize(this ContextMenuStrip control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ContextMenuStrip AutoScrollMinSize(this ContextMenuStrip control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static ContextMenuStrip AutoScrollPosition(this ContextMenuStrip control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ContextMenuStrip AutoScrollPosition(this ContextMenuStrip control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static ContextMenuStrip AllowDrop(this ContextMenuStrip control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ContextMenuStrip AllowMerge(this ContextMenuStrip control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static ContextMenuStrip BackColor(this ContextMenuStrip control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ContextMenuStrip BackColor(this ContextMenuStrip control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ContextMenuStrip BackColor(this ContextMenuStrip control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ContextMenuStrip BindingContext(this ContextMenuStrip control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ContextMenuStrip CausesValidation(this ContextMenuStrip control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ContextMenuStrip Cursor(this ContextMenuStrip control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ContextMenuStrip ForeColor(this ContextMenuStrip control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ContextMenuStrip ForeColor(this ContextMenuStrip control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ContextMenuStrip ForeColor(this ContextMenuStrip control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ContextMenuStrip ImageScalingSize(this ContextMenuStrip control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static ContextMenuStrip ImageScalingSize(this ContextMenuStrip control, Size size)
        {
            control.ImageScalingSize = size;
            return control;
        }

        public static ContextMenuStrip ImageList(this ContextMenuStrip control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static ContextMenuStrip LayoutSettings(this ContextMenuStrip control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static ContextMenuStrip Renderer(this ContextMenuStrip control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static ContextMenuStrip RenderMode(this ContextMenuStrip control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static ContextMenuStrip ShowItemToolTips(this ContextMenuStrip control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static ContextMenuStrip TabStop(this ContextMenuStrip control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ContextMenuStrip AccessibleDefaultActionDescription(this ContextMenuStrip control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ContextMenuStrip AccessibleDescription(this ContextMenuStrip control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ContextMenuStrip AccessibleName(this ContextMenuStrip control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ContextMenuStrip AccessibleRole(this ContextMenuStrip control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ContextMenuStrip AutoScrollOffset(this ContextMenuStrip control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ContextMenuStrip AutoScrollOffset(this ContextMenuStrip control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ContextMenuStrip DataContext(this ContextMenuStrip control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ContextMenuStrip BackgroundImage(this ContextMenuStrip control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ContextMenuStrip BackgroundImageLayout(this ContextMenuStrip control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ContextMenuStrip Bounds(this ContextMenuStrip control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ContextMenuStrip Bounds(this ContextMenuStrip control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ContextMenuStrip Bounds(this ContextMenuStrip control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ContextMenuStrip Capture(this ContextMenuStrip control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ContextMenuStrip ClientSize(this ContextMenuStrip control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ContextMenuStrip ClientSize(this ContextMenuStrip control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ContextMenuStrip Enabled(this ContextMenuStrip control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ContextMenuStrip Height(this ContextMenuStrip control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ContextMenuStrip IsAccessible(this ContextMenuStrip control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ContextMenuStrip Left(this ContextMenuStrip control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ContextMenuStrip Margin(this ContextMenuStrip control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ContextMenuStrip MaximumSize(this ContextMenuStrip control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ContextMenuStrip MaximumSize(this ContextMenuStrip control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ContextMenuStrip MinimumSize(this ContextMenuStrip control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ContextMenuStrip MinimumSize(this ContextMenuStrip control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ContextMenuStrip Name(this ContextMenuStrip control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ContextMenuStrip Parent(this ContextMenuStrip control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ContextMenuStrip Size(this ContextMenuStrip control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ContextMenuStrip Size(this ContextMenuStrip control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ContextMenuStrip Tag(this ContextMenuStrip control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ContextMenuStrip Text(this ContextMenuStrip control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ContextMenuStrip Top(this ContextMenuStrip control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ContextMenuStrip UseWaitCursor(this ContextMenuStrip control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ContextMenuStrip Width(this ContextMenuStrip control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ContextMenuStrip WindowTarget(this ContextMenuStrip control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ContextMenuStrip Padding(this ContextMenuStrip control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ContextMenuStrip ImeMode(this ContextMenuStrip control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ContextMenuStrip OnBackgroundImageChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnBackgroundImageLayoutChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnBindingContextChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnChangeUICues(this ContextMenuStrip control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ContextMenuStrip OnContextMenuStripChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnDockChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnClosed(this ContextMenuStrip control, ToolStripDropDownClosedEventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static ContextMenuStrip OnClosing(this ContextMenuStrip control, ToolStripDropDownClosingEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static ContextMenuStrip OnEnter(this ContextMenuStrip control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ContextMenuStrip OnFontChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnForeColorChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnGiveFeedback(this ContextMenuStrip control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ContextMenuStrip OnHelpRequested(this ContextMenuStrip control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ContextMenuStrip OnImeModeChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnKeyDown(this ContextMenuStrip control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ContextMenuStrip OnKeyPress(this ContextMenuStrip control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ContextMenuStrip OnKeyUp(this ContextMenuStrip control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ContextMenuStrip OnLeave(this ContextMenuStrip control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ContextMenuStrip OnOpening(this ContextMenuStrip control, CancelEventHandler handler)
        {
            control.Opening += handler;
            return control;
        }

        public static ContextMenuStrip OnOpened(this ContextMenuStrip control, EventHandler handler)
        {
            control.Opened += handler;
            return control;
        }

        public static ContextMenuStrip OnRegionChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnScroll(this ContextMenuStrip control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ContextMenuStrip OnStyleChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnTabStopChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnTextChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnTabIndexChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnValidated(this ContextMenuStrip control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ContextMenuStrip OnValidating(this ContextMenuStrip control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ContextMenuStrip OnAutoSizeChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnBeginDrag(this ContextMenuStrip control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static ContextMenuStrip OnCausesValidationChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnControlAdded(this ContextMenuStrip control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ContextMenuStrip OnCursorChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnControlRemoved(this ContextMenuStrip control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ContextMenuStrip OnEndDrag(this ContextMenuStrip control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static ContextMenuStrip OnItemAdded(this ContextMenuStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static ContextMenuStrip OnItemClicked(this ContextMenuStrip control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static ContextMenuStrip OnItemRemoved(this ContextMenuStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static ContextMenuStrip OnLayoutCompleted(this ContextMenuStrip control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static ContextMenuStrip OnLayoutStyleChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnPaintGrip(this ContextMenuStrip control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static ContextMenuStrip OnRendererChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnBackColorChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnClientSizeChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnEnabledChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnLocationChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnMarginChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnRightToLeftChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnSizeChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnVisibleChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnClick(this ContextMenuStrip control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ContextMenuStrip OnDataContextChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnDragDrop(this ContextMenuStrip control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ContextMenuStrip OnDragEnter(this ContextMenuStrip control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ContextMenuStrip OnDragOver(this ContextMenuStrip control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ContextMenuStrip OnDragLeave(this ContextMenuStrip control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ContextMenuStrip OnHandleCreated(this ContextMenuStrip control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ContextMenuStrip OnHandleDestroyed(this ContextMenuStrip control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ContextMenuStrip OnInvalidated(this ContextMenuStrip control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ContextMenuStrip OnPaddingChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnPaint(this ContextMenuStrip control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ContextMenuStrip OnQueryContinueDrag(this ContextMenuStrip control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ContextMenuStrip OnQueryAccessibilityHelp(this ContextMenuStrip control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ContextMenuStrip OnDoubleClick(this ContextMenuStrip control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ContextMenuStrip OnGotFocus(this ContextMenuStrip control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ContextMenuStrip OnLayout(this ContextMenuStrip control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ContextMenuStrip OnLostFocus(this ContextMenuStrip control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseClick(this ContextMenuStrip control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseDoubleClick(this ContextMenuStrip control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseCaptureChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseDown(this ContextMenuStrip control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseEnter(this ContextMenuStrip control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseLeave(this ContextMenuStrip control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ContextMenuStrip OnDpiChangedBeforeParent(this ContextMenuStrip control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ContextMenuStrip OnDpiChangedAfterParent(this ContextMenuStrip control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseHover(this ContextMenuStrip control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseMove(this ContextMenuStrip control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseUp(this ContextMenuStrip control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ContextMenuStrip OnMouseWheel(this ContextMenuStrip control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ContextMenuStrip OnMove(this ContextMenuStrip control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ContextMenuStrip OnPreviewKeyDown(this ContextMenuStrip control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ContextMenuStrip OnResize(this ContextMenuStrip control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ContextMenuStrip OnSystemColorsChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnParentChanged(this ContextMenuStrip control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ContextMenuStrip OnDisposed(this ContextMenuStrip control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ContextMenuStrip AddTo(this ContextMenuStrip control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ContextMenuStrip Assign(this ContextMenuStrip control, out ContextMenuStrip variable)
        {
            variable = control;
            return control;
        }

    }
}

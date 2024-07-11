using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ToolStripDropDownExtensions
    {
        public static ToolStripDropDown AllowItemReorder(this ToolStripDropDown control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static ToolStripDropDown AllowTransparency(this ToolStripDropDown control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static ToolStripDropDown Anchor(this ToolStripDropDown control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ToolStripDropDown AutoSize(this ToolStripDropDown control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ToolStripDropDown AutoClose(this ToolStripDropDown control, Boolean value)
        {
            control.AutoClose = value;
            return control;
        }

        public static ToolStripDropDown CanOverflow(this ToolStripDropDown control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static ToolStripDropDown ContextMenuStrip(this ToolStripDropDown control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ToolStripDropDown DefaultDropDownDirection(this ToolStripDropDown control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static ToolStripDropDown Dock(this ToolStripDropDown control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ToolStripDropDown DropShadowEnabled(this ToolStripDropDown control, Boolean value)
        {
            control.DropShadowEnabled = value;
            return control;
        }

        public static ToolStripDropDown Font(this ToolStripDropDown control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ToolStripDropDown Font(this ToolStripDropDown control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ToolStripDropDown GripMargin(this ToolStripDropDown control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static ToolStripDropDown GripStyle(this ToolStripDropDown control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static ToolStripDropDown Location(this ToolStripDropDown control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ToolStripDropDown Location(this ToolStripDropDown control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ToolStripDropDown Opacity(this ToolStripDropDown control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static ToolStripDropDown OwnerItem(this ToolStripDropDown control, ToolStripItem value)
        {
            control.OwnerItem = value;
            return control;
        }

        public static ToolStripDropDown Region(this ToolStripDropDown control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ToolStripDropDown RightToLeft(this ToolStripDropDown control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ToolStripDropDown Stretch(this ToolStripDropDown control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static ToolStripDropDown TextDirection(this ToolStripDropDown control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static ToolStripDropDown TopLevel(this ToolStripDropDown control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static ToolStripDropDown TabIndex(this ToolStripDropDown control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ToolStripDropDown Visible(this ToolStripDropDown control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ToolStripDropDown AutoScroll(this ToolStripDropDown control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ToolStripDropDown AutoScrollMargin(this ToolStripDropDown control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ToolStripDropDown AutoScrollMargin(this ToolStripDropDown control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static ToolStripDropDown AutoScrollMinSize(this ToolStripDropDown control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDown AutoScrollMinSize(this ToolStripDropDown control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static ToolStripDropDown AutoScrollPosition(this ToolStripDropDown control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ToolStripDropDown AutoScrollPosition(this ToolStripDropDown control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static ToolStripDropDown AllowDrop(this ToolStripDropDown control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ToolStripDropDown AllowMerge(this ToolStripDropDown control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static ToolStripDropDown BackColor(this ToolStripDropDown control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripDropDown BackColor(this ToolStripDropDown control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ToolStripDropDown BackColor(this ToolStripDropDown control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ToolStripDropDown BindingContext(this ToolStripDropDown control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ToolStripDropDown CausesValidation(this ToolStripDropDown control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ToolStripDropDown Cursor(this ToolStripDropDown control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ToolStripDropDown ForeColor(this ToolStripDropDown control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripDropDown ForeColor(this ToolStripDropDown control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ToolStripDropDown ForeColor(this ToolStripDropDown control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ToolStripDropDown ImageScalingSize(this ToolStripDropDown control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDown ImageScalingSize(this ToolStripDropDown control, Size size)
        {
            control.ImageScalingSize = size;
            return control;
        }

        public static ToolStripDropDown ImageList(this ToolStripDropDown control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static ToolStripDropDown LayoutSettings(this ToolStripDropDown control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static ToolStripDropDown LayoutStyle(this ToolStripDropDown control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static ToolStripDropDown Renderer(this ToolStripDropDown control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static ToolStripDropDown RenderMode(this ToolStripDropDown control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static ToolStripDropDown ShowItemToolTips(this ToolStripDropDown control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static ToolStripDropDown TabStop(this ToolStripDropDown control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ToolStripDropDown AccessibleDefaultActionDescription(this ToolStripDropDown control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ToolStripDropDown AccessibleDescription(this ToolStripDropDown control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ToolStripDropDown AccessibleName(this ToolStripDropDown control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ToolStripDropDown AccessibleRole(this ToolStripDropDown control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ToolStripDropDown AutoScrollOffset(this ToolStripDropDown control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ToolStripDropDown AutoScrollOffset(this ToolStripDropDown control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ToolStripDropDown DataContext(this ToolStripDropDown control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ToolStripDropDown BackgroundImage(this ToolStripDropDown control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ToolStripDropDown BackgroundImageLayout(this ToolStripDropDown control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ToolStripDropDown Bounds(this ToolStripDropDown control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ToolStripDropDown Bounds(this ToolStripDropDown control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ToolStripDropDown Bounds(this ToolStripDropDown control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ToolStripDropDown Capture(this ToolStripDropDown control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ToolStripDropDown ClientSize(this ToolStripDropDown control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDown ClientSize(this ToolStripDropDown control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ToolStripDropDown Enabled(this ToolStripDropDown control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ToolStripDropDown Height(this ToolStripDropDown control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ToolStripDropDown IsAccessible(this ToolStripDropDown control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ToolStripDropDown Left(this ToolStripDropDown control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ToolStripDropDown Margin(this ToolStripDropDown control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ToolStripDropDown MaximumSize(this ToolStripDropDown control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDown MaximumSize(this ToolStripDropDown control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ToolStripDropDown MinimumSize(this ToolStripDropDown control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDown MinimumSize(this ToolStripDropDown control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ToolStripDropDown Name(this ToolStripDropDown control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ToolStripDropDown Parent(this ToolStripDropDown control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ToolStripDropDown Size(this ToolStripDropDown control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ToolStripDropDown Size(this ToolStripDropDown control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ToolStripDropDown Tag(this ToolStripDropDown control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ToolStripDropDown Text(this ToolStripDropDown control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ToolStripDropDown Top(this ToolStripDropDown control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ToolStripDropDown UseWaitCursor(this ToolStripDropDown control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ToolStripDropDown Width(this ToolStripDropDown control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ToolStripDropDown WindowTarget(this ToolStripDropDown control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ToolStripDropDown Padding(this ToolStripDropDown control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ToolStripDropDown ImeMode(this ToolStripDropDown control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ToolStripDropDown OnBackgroundImageChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnBackgroundImageLayoutChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnBindingContextChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnChangeUICues(this ToolStripDropDown control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ToolStripDropDown OnContextMenuStripChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnDockChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnClosed(this ToolStripDropDown control, ToolStripDropDownClosedEventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static ToolStripDropDown OnClosing(this ToolStripDropDown control, ToolStripDropDownClosingEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static ToolStripDropDown OnEnter(this ToolStripDropDown control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ToolStripDropDown OnFontChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnForeColorChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnGiveFeedback(this ToolStripDropDown control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ToolStripDropDown OnHelpRequested(this ToolStripDropDown control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ToolStripDropDown OnImeModeChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnKeyDown(this ToolStripDropDown control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ToolStripDropDown OnKeyPress(this ToolStripDropDown control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ToolStripDropDown OnKeyUp(this ToolStripDropDown control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ToolStripDropDown OnLeave(this ToolStripDropDown control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ToolStripDropDown OnOpening(this ToolStripDropDown control, CancelEventHandler handler)
        {
            control.Opening += handler;
            return control;
        }

        public static ToolStripDropDown OnOpened(this ToolStripDropDown control, EventHandler handler)
        {
            control.Opened += handler;
            return control;
        }

        public static ToolStripDropDown OnRegionChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnScroll(this ToolStripDropDown control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ToolStripDropDown OnStyleChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnTabStopChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnTextChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnTabIndexChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnValidated(this ToolStripDropDown control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ToolStripDropDown OnValidating(this ToolStripDropDown control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ToolStripDropDown OnAutoSizeChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnBeginDrag(this ToolStripDropDown control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static ToolStripDropDown OnCausesValidationChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnControlAdded(this ToolStripDropDown control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ToolStripDropDown OnCursorChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnControlRemoved(this ToolStripDropDown control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ToolStripDropDown OnEndDrag(this ToolStripDropDown control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static ToolStripDropDown OnItemAdded(this ToolStripDropDown control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static ToolStripDropDown OnItemClicked(this ToolStripDropDown control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static ToolStripDropDown OnItemRemoved(this ToolStripDropDown control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static ToolStripDropDown OnLayoutCompleted(this ToolStripDropDown control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static ToolStripDropDown OnLayoutStyleChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnPaintGrip(this ToolStripDropDown control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static ToolStripDropDown OnRendererChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnBackColorChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnClientSizeChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnEnabledChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnLocationChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnMarginChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnRightToLeftChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnSizeChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnVisibleChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnClick(this ToolStripDropDown control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ToolStripDropDown OnDataContextChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnDragDrop(this ToolStripDropDown control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ToolStripDropDown OnDragEnter(this ToolStripDropDown control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ToolStripDropDown OnDragOver(this ToolStripDropDown control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ToolStripDropDown OnDragLeave(this ToolStripDropDown control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ToolStripDropDown OnHandleCreated(this ToolStripDropDown control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ToolStripDropDown OnHandleDestroyed(this ToolStripDropDown control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ToolStripDropDown OnInvalidated(this ToolStripDropDown control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ToolStripDropDown OnPaddingChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnPaint(this ToolStripDropDown control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ToolStripDropDown OnQueryContinueDrag(this ToolStripDropDown control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ToolStripDropDown OnQueryAccessibilityHelp(this ToolStripDropDown control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ToolStripDropDown OnDoubleClick(this ToolStripDropDown control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ToolStripDropDown OnGotFocus(this ToolStripDropDown control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ToolStripDropDown OnLayout(this ToolStripDropDown control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ToolStripDropDown OnLostFocus(this ToolStripDropDown control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseClick(this ToolStripDropDown control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseDoubleClick(this ToolStripDropDown control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseCaptureChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseDown(this ToolStripDropDown control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseEnter(this ToolStripDropDown control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseLeave(this ToolStripDropDown control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ToolStripDropDown OnDpiChangedBeforeParent(this ToolStripDropDown control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ToolStripDropDown OnDpiChangedAfterParent(this ToolStripDropDown control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseHover(this ToolStripDropDown control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseMove(this ToolStripDropDown control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseUp(this ToolStripDropDown control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ToolStripDropDown OnMouseWheel(this ToolStripDropDown control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ToolStripDropDown OnMove(this ToolStripDropDown control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ToolStripDropDown OnPreviewKeyDown(this ToolStripDropDown control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ToolStripDropDown OnResize(this ToolStripDropDown control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ToolStripDropDown OnSystemColorsChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnParentChanged(this ToolStripDropDown control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ToolStripDropDown OnDisposed(this ToolStripDropDown control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ToolStripDropDown AddTo(this ToolStripDropDown control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ToolStripDropDown Assign(this ToolStripDropDown control, out ToolStripDropDown variable)
        {
            variable = control;
            return control;
        }

    }
}

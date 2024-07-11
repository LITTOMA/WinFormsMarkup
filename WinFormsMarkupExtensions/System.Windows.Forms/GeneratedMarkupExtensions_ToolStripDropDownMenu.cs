using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ToolStripDropDownMenuExtensions
    {
        public static ToolStripDropDownMenu LayoutStyle(this ToolStripDropDownMenu control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static ToolStripDropDownMenu ShowImageMargin(this ToolStripDropDownMenu control, Boolean value)
        {
            control.ShowImageMargin = value;
            return control;
        }

        public static ToolStripDropDownMenu ShowCheckMargin(this ToolStripDropDownMenu control, Boolean value)
        {
            control.ShowCheckMargin = value;
            return control;
        }

        public static ToolStripDropDownMenu AllowItemReorder(this ToolStripDropDownMenu control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static ToolStripDropDownMenu AllowTransparency(this ToolStripDropDownMenu control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static ToolStripDropDownMenu Anchor(this ToolStripDropDownMenu control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ToolStripDropDownMenu AutoSize(this ToolStripDropDownMenu control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ToolStripDropDownMenu AutoClose(this ToolStripDropDownMenu control, Boolean value)
        {
            control.AutoClose = value;
            return control;
        }

        public static ToolStripDropDownMenu CanOverflow(this ToolStripDropDownMenu control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static ToolStripDropDownMenu ContextMenuStrip(this ToolStripDropDownMenu control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ToolStripDropDownMenu DefaultDropDownDirection(this ToolStripDropDownMenu control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static ToolStripDropDownMenu Dock(this ToolStripDropDownMenu control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ToolStripDropDownMenu DropShadowEnabled(this ToolStripDropDownMenu control, Boolean value)
        {
            control.DropShadowEnabled = value;
            return control;
        }

        public static ToolStripDropDownMenu Font(this ToolStripDropDownMenu control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ToolStripDropDownMenu Font(this ToolStripDropDownMenu control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ToolStripDropDownMenu GripMargin(this ToolStripDropDownMenu control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static ToolStripDropDownMenu GripStyle(this ToolStripDropDownMenu control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static ToolStripDropDownMenu Location(this ToolStripDropDownMenu control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ToolStripDropDownMenu Location(this ToolStripDropDownMenu control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ToolStripDropDownMenu Opacity(this ToolStripDropDownMenu control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static ToolStripDropDownMenu OwnerItem(this ToolStripDropDownMenu control, ToolStripItem value)
        {
            control.OwnerItem = value;
            return control;
        }

        public static ToolStripDropDownMenu Region(this ToolStripDropDownMenu control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ToolStripDropDownMenu RightToLeft(this ToolStripDropDownMenu control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ToolStripDropDownMenu Stretch(this ToolStripDropDownMenu control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static ToolStripDropDownMenu TextDirection(this ToolStripDropDownMenu control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static ToolStripDropDownMenu TopLevel(this ToolStripDropDownMenu control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static ToolStripDropDownMenu TabIndex(this ToolStripDropDownMenu control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ToolStripDropDownMenu Visible(this ToolStripDropDownMenu control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ToolStripDropDownMenu AutoScroll(this ToolStripDropDownMenu control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollMargin(this ToolStripDropDownMenu control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollMargin(this ToolStripDropDownMenu control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollMinSize(this ToolStripDropDownMenu control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollMinSize(this ToolStripDropDownMenu control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollPosition(this ToolStripDropDownMenu control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollPosition(this ToolStripDropDownMenu control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static ToolStripDropDownMenu AllowDrop(this ToolStripDropDownMenu control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ToolStripDropDownMenu AllowMerge(this ToolStripDropDownMenu control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static ToolStripDropDownMenu BackColor(this ToolStripDropDownMenu control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripDropDownMenu BackColor(this ToolStripDropDownMenu control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ToolStripDropDownMenu BackColor(this ToolStripDropDownMenu control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ToolStripDropDownMenu BindingContext(this ToolStripDropDownMenu control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ToolStripDropDownMenu CausesValidation(this ToolStripDropDownMenu control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ToolStripDropDownMenu Cursor(this ToolStripDropDownMenu control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ToolStripDropDownMenu ForeColor(this ToolStripDropDownMenu control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripDropDownMenu ForeColor(this ToolStripDropDownMenu control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ToolStripDropDownMenu ForeColor(this ToolStripDropDownMenu control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ToolStripDropDownMenu ImageScalingSize(this ToolStripDropDownMenu control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDownMenu ImageScalingSize(this ToolStripDropDownMenu control, Size size)
        {
            control.ImageScalingSize = size;
            return control;
        }

        public static ToolStripDropDownMenu ImageList(this ToolStripDropDownMenu control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static ToolStripDropDownMenu LayoutSettings(this ToolStripDropDownMenu control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static ToolStripDropDownMenu Renderer(this ToolStripDropDownMenu control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static ToolStripDropDownMenu RenderMode(this ToolStripDropDownMenu control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static ToolStripDropDownMenu ShowItemToolTips(this ToolStripDropDownMenu control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static ToolStripDropDownMenu TabStop(this ToolStripDropDownMenu control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ToolStripDropDownMenu AccessibleDefaultActionDescription(this ToolStripDropDownMenu control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ToolStripDropDownMenu AccessibleDescription(this ToolStripDropDownMenu control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ToolStripDropDownMenu AccessibleName(this ToolStripDropDownMenu control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ToolStripDropDownMenu AccessibleRole(this ToolStripDropDownMenu control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollOffset(this ToolStripDropDownMenu control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ToolStripDropDownMenu AutoScrollOffset(this ToolStripDropDownMenu control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ToolStripDropDownMenu DataContext(this ToolStripDropDownMenu control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ToolStripDropDownMenu BackgroundImage(this ToolStripDropDownMenu control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ToolStripDropDownMenu BackgroundImageLayout(this ToolStripDropDownMenu control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ToolStripDropDownMenu Bounds(this ToolStripDropDownMenu control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ToolStripDropDownMenu Bounds(this ToolStripDropDownMenu control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ToolStripDropDownMenu Bounds(this ToolStripDropDownMenu control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ToolStripDropDownMenu Capture(this ToolStripDropDownMenu control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ToolStripDropDownMenu ClientSize(this ToolStripDropDownMenu control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDownMenu ClientSize(this ToolStripDropDownMenu control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ToolStripDropDownMenu Enabled(this ToolStripDropDownMenu control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ToolStripDropDownMenu Height(this ToolStripDropDownMenu control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ToolStripDropDownMenu IsAccessible(this ToolStripDropDownMenu control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ToolStripDropDownMenu Left(this ToolStripDropDownMenu control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ToolStripDropDownMenu Margin(this ToolStripDropDownMenu control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ToolStripDropDownMenu MaximumSize(this ToolStripDropDownMenu control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDownMenu MaximumSize(this ToolStripDropDownMenu control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ToolStripDropDownMenu MinimumSize(this ToolStripDropDownMenu control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ToolStripDropDownMenu MinimumSize(this ToolStripDropDownMenu control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ToolStripDropDownMenu Name(this ToolStripDropDownMenu control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ToolStripDropDownMenu Parent(this ToolStripDropDownMenu control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ToolStripDropDownMenu Size(this ToolStripDropDownMenu control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ToolStripDropDownMenu Size(this ToolStripDropDownMenu control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ToolStripDropDownMenu Tag(this ToolStripDropDownMenu control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ToolStripDropDownMenu Text(this ToolStripDropDownMenu control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ToolStripDropDownMenu Top(this ToolStripDropDownMenu control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ToolStripDropDownMenu UseWaitCursor(this ToolStripDropDownMenu control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ToolStripDropDownMenu Width(this ToolStripDropDownMenu control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ToolStripDropDownMenu WindowTarget(this ToolStripDropDownMenu control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ToolStripDropDownMenu Padding(this ToolStripDropDownMenu control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ToolStripDropDownMenu ImeMode(this ToolStripDropDownMenu control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ToolStripDropDownMenu OnBackgroundImageChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnBackgroundImageLayoutChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnBindingContextChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnChangeUICues(this ToolStripDropDownMenu control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnContextMenuStripChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDockChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnClosed(this ToolStripDropDownMenu control, ToolStripDropDownClosedEventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnClosing(this ToolStripDropDownMenu control, ToolStripDropDownClosingEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnEnter(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnFontChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnForeColorChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnGiveFeedback(this ToolStripDropDownMenu control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnHelpRequested(this ToolStripDropDownMenu control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnImeModeChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnKeyDown(this ToolStripDropDownMenu control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnKeyPress(this ToolStripDropDownMenu control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnKeyUp(this ToolStripDropDownMenu control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnLeave(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnOpening(this ToolStripDropDownMenu control, CancelEventHandler handler)
        {
            control.Opening += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnOpened(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Opened += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnRegionChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnScroll(this ToolStripDropDownMenu control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnStyleChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnTabStopChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnTextChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnTabIndexChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnValidated(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnValidating(this ToolStripDropDownMenu control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnAutoSizeChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnBeginDrag(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnCausesValidationChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnControlAdded(this ToolStripDropDownMenu control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnCursorChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnControlRemoved(this ToolStripDropDownMenu control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnEndDrag(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnItemAdded(this ToolStripDropDownMenu control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnItemClicked(this ToolStripDropDownMenu control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnItemRemoved(this ToolStripDropDownMenu control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnLayoutCompleted(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnLayoutStyleChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnPaintGrip(this ToolStripDropDownMenu control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnRendererChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnBackColorChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnClientSizeChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnEnabledChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnLocationChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMarginChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnRightToLeftChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnSizeChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnVisibleChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnClick(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDataContextChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDragDrop(this ToolStripDropDownMenu control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDragEnter(this ToolStripDropDownMenu control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDragOver(this ToolStripDropDownMenu control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDragLeave(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnHandleCreated(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnHandleDestroyed(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnInvalidated(this ToolStripDropDownMenu control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnPaddingChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnPaint(this ToolStripDropDownMenu control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnQueryContinueDrag(this ToolStripDropDownMenu control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnQueryAccessibilityHelp(this ToolStripDropDownMenu control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDoubleClick(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnGotFocus(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnLayout(this ToolStripDropDownMenu control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnLostFocus(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseClick(this ToolStripDropDownMenu control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseDoubleClick(this ToolStripDropDownMenu control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseCaptureChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseDown(this ToolStripDropDownMenu control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseEnter(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseLeave(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDpiChangedBeforeParent(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDpiChangedAfterParent(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseHover(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseMove(this ToolStripDropDownMenu control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseUp(this ToolStripDropDownMenu control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMouseWheel(this ToolStripDropDownMenu control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnMove(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnPreviewKeyDown(this ToolStripDropDownMenu control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnResize(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnSystemColorsChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnParentChanged(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ToolStripDropDownMenu OnDisposed(this ToolStripDropDownMenu control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ToolStripDropDownMenu AddTo(this ToolStripDropDownMenu control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ToolStripDropDownMenu Assign(this ToolStripDropDownMenu control, out ToolStripDropDownMenu variable)
        {
            variable = control;
            return control;
        }

    }
}

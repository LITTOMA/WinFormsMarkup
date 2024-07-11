using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class BindingNavigatorExtensions
    {
        public static BindingNavigator BindingSource(this BindingNavigator control, BindingSource value)
        {
            control.BindingSource = value;
            return control;
        }

        public static BindingNavigator MoveFirstItem(this BindingNavigator control, ToolStripItem value)
        {
            control.MoveFirstItem = value;
            return control;
        }

        public static BindingNavigator MovePreviousItem(this BindingNavigator control, ToolStripItem value)
        {
            control.MovePreviousItem = value;
            return control;
        }

        public static BindingNavigator MoveNextItem(this BindingNavigator control, ToolStripItem value)
        {
            control.MoveNextItem = value;
            return control;
        }

        public static BindingNavigator MoveLastItem(this BindingNavigator control, ToolStripItem value)
        {
            control.MoveLastItem = value;
            return control;
        }

        public static BindingNavigator AddNewItem(this BindingNavigator control, ToolStripItem value)
        {
            control.AddNewItem = value;
            return control;
        }

        public static BindingNavigator DeleteItem(this BindingNavigator control, ToolStripItem value)
        {
            control.DeleteItem = value;
            return control;
        }

        public static BindingNavigator PositionItem(this BindingNavigator control, ToolStripItem value)
        {
            control.PositionItem = value;
            return control;
        }

        public static BindingNavigator CountItem(this BindingNavigator control, ToolStripItem value)
        {
            control.CountItem = value;
            return control;
        }

        public static BindingNavigator CountItemFormat(this BindingNavigator control, String value)
        {
            control.CountItemFormat = value;
            return control;
        }

        public static BindingNavigator AutoSize(this BindingNavigator control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static BindingNavigator AutoScroll(this BindingNavigator control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static BindingNavigator AutoScrollMargin(this BindingNavigator control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static BindingNavigator AutoScrollMargin(this BindingNavigator control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static BindingNavigator AutoScrollMinSize(this BindingNavigator control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static BindingNavigator AutoScrollMinSize(this BindingNavigator control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static BindingNavigator AutoScrollPosition(this BindingNavigator control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static BindingNavigator AutoScrollPosition(this BindingNavigator control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static BindingNavigator AllowDrop(this BindingNavigator control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static BindingNavigator AllowItemReorder(this BindingNavigator control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static BindingNavigator AllowMerge(this BindingNavigator control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static BindingNavigator Anchor(this BindingNavigator control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static BindingNavigator BackColor(this BindingNavigator control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static BindingNavigator BackColor(this BindingNavigator control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static BindingNavigator BackColor(this BindingNavigator control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static BindingNavigator BindingContext(this BindingNavigator control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static BindingNavigator CanOverflow(this BindingNavigator control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static BindingNavigator CausesValidation(this BindingNavigator control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static BindingNavigator Cursor(this BindingNavigator control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static BindingNavigator Font(this BindingNavigator control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static BindingNavigator Font(this BindingNavigator control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static BindingNavigator DefaultDropDownDirection(this BindingNavigator control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static BindingNavigator Dock(this BindingNavigator control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static BindingNavigator ForeColor(this BindingNavigator control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static BindingNavigator ForeColor(this BindingNavigator control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static BindingNavigator ForeColor(this BindingNavigator control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static BindingNavigator GripStyle(this BindingNavigator control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static BindingNavigator GripMargin(this BindingNavigator control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static BindingNavigator ImageScalingSize(this BindingNavigator control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static BindingNavigator ImageScalingSize(this BindingNavigator control, Size size)
        {
            control.ImageScalingSize = size;
            return control;
        }

        public static BindingNavigator ImageList(this BindingNavigator control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static BindingNavigator LayoutSettings(this BindingNavigator control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static BindingNavigator LayoutStyle(this BindingNavigator control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static BindingNavigator Stretch(this BindingNavigator control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static BindingNavigator Renderer(this BindingNavigator control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static BindingNavigator RenderMode(this BindingNavigator control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static BindingNavigator ShowItemToolTips(this BindingNavigator control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static BindingNavigator TabStop(this BindingNavigator control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static BindingNavigator TextDirection(this BindingNavigator control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static BindingNavigator AccessibleDefaultActionDescription(this BindingNavigator control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static BindingNavigator AccessibleDescription(this BindingNavigator control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static BindingNavigator AccessibleName(this BindingNavigator control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static BindingNavigator AccessibleRole(this BindingNavigator control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static BindingNavigator AutoScrollOffset(this BindingNavigator control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static BindingNavigator AutoScrollOffset(this BindingNavigator control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static BindingNavigator DataContext(this BindingNavigator control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static BindingNavigator BackgroundImage(this BindingNavigator control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static BindingNavigator BackgroundImageLayout(this BindingNavigator control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static BindingNavigator Bounds(this BindingNavigator control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static BindingNavigator Bounds(this BindingNavigator control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static BindingNavigator Bounds(this BindingNavigator control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static BindingNavigator Capture(this BindingNavigator control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static BindingNavigator ClientSize(this BindingNavigator control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static BindingNavigator ClientSize(this BindingNavigator control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static BindingNavigator ContextMenuStrip(this BindingNavigator control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static BindingNavigator Enabled(this BindingNavigator control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static BindingNavigator Height(this BindingNavigator control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static BindingNavigator IsAccessible(this BindingNavigator control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static BindingNavigator Left(this BindingNavigator control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static BindingNavigator Location(this BindingNavigator control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static BindingNavigator Location(this BindingNavigator control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static BindingNavigator Margin(this BindingNavigator control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static BindingNavigator MaximumSize(this BindingNavigator control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static BindingNavigator MaximumSize(this BindingNavigator control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static BindingNavigator MinimumSize(this BindingNavigator control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static BindingNavigator MinimumSize(this BindingNavigator control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static BindingNavigator Name(this BindingNavigator control, String value)
        {
            control.Name = value;
            return control;
        }

        public static BindingNavigator Parent(this BindingNavigator control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static BindingNavigator Region(this BindingNavigator control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static BindingNavigator RightToLeft(this BindingNavigator control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static BindingNavigator Size(this BindingNavigator control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static BindingNavigator Size(this BindingNavigator control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static BindingNavigator TabIndex(this BindingNavigator control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static BindingNavigator Tag(this BindingNavigator control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static BindingNavigator Text(this BindingNavigator control, String value)
        {
            control.Text = value;
            return control;
        }

        public static BindingNavigator Top(this BindingNavigator control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static BindingNavigator UseWaitCursor(this BindingNavigator control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static BindingNavigator Visible(this BindingNavigator control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static BindingNavigator Width(this BindingNavigator control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static BindingNavigator WindowTarget(this BindingNavigator control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static BindingNavigator Padding(this BindingNavigator control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static BindingNavigator ImeMode(this BindingNavigator control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static BindingNavigator OnRefreshItems(this BindingNavigator control, EventHandler handler)
        {
            control.RefreshItems += handler;
            return control;
        }

        public static BindingNavigator OnAutoSizeChanged(this BindingNavigator control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static BindingNavigator OnBeginDrag(this BindingNavigator control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static BindingNavigator OnCausesValidationChanged(this BindingNavigator control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static BindingNavigator OnControlAdded(this BindingNavigator control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static BindingNavigator OnCursorChanged(this BindingNavigator control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static BindingNavigator OnControlRemoved(this BindingNavigator control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static BindingNavigator OnEndDrag(this BindingNavigator control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static BindingNavigator OnForeColorChanged(this BindingNavigator control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static BindingNavigator OnItemAdded(this BindingNavigator control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static BindingNavigator OnItemClicked(this BindingNavigator control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static BindingNavigator OnItemRemoved(this BindingNavigator control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static BindingNavigator OnLayoutCompleted(this BindingNavigator control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static BindingNavigator OnLayoutStyleChanged(this BindingNavigator control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static BindingNavigator OnPaintGrip(this BindingNavigator control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static BindingNavigator OnRendererChanged(this BindingNavigator control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static BindingNavigator OnScroll(this BindingNavigator control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static BindingNavigator OnBackColorChanged(this BindingNavigator control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static BindingNavigator OnBackgroundImageChanged(this BindingNavigator control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static BindingNavigator OnBackgroundImageLayoutChanged(this BindingNavigator control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static BindingNavigator OnBindingContextChanged(this BindingNavigator control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static BindingNavigator OnClientSizeChanged(this BindingNavigator control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static BindingNavigator OnContextMenuStripChanged(this BindingNavigator control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static BindingNavigator OnDockChanged(this BindingNavigator control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static BindingNavigator OnEnabledChanged(this BindingNavigator control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static BindingNavigator OnFontChanged(this BindingNavigator control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static BindingNavigator OnLocationChanged(this BindingNavigator control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static BindingNavigator OnMarginChanged(this BindingNavigator control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static BindingNavigator OnRegionChanged(this BindingNavigator control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static BindingNavigator OnRightToLeftChanged(this BindingNavigator control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static BindingNavigator OnSizeChanged(this BindingNavigator control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static BindingNavigator OnTabIndexChanged(this BindingNavigator control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static BindingNavigator OnTabStopChanged(this BindingNavigator control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static BindingNavigator OnTextChanged(this BindingNavigator control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static BindingNavigator OnVisibleChanged(this BindingNavigator control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static BindingNavigator OnClick(this BindingNavigator control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static BindingNavigator OnDataContextChanged(this BindingNavigator control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static BindingNavigator OnDragDrop(this BindingNavigator control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static BindingNavigator OnDragEnter(this BindingNavigator control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static BindingNavigator OnDragOver(this BindingNavigator control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static BindingNavigator OnDragLeave(this BindingNavigator control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static BindingNavigator OnGiveFeedback(this BindingNavigator control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static BindingNavigator OnHandleCreated(this BindingNavigator control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static BindingNavigator OnHandleDestroyed(this BindingNavigator control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static BindingNavigator OnHelpRequested(this BindingNavigator control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static BindingNavigator OnInvalidated(this BindingNavigator control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static BindingNavigator OnPaddingChanged(this BindingNavigator control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static BindingNavigator OnPaint(this BindingNavigator control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static BindingNavigator OnQueryContinueDrag(this BindingNavigator control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static BindingNavigator OnQueryAccessibilityHelp(this BindingNavigator control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static BindingNavigator OnDoubleClick(this BindingNavigator control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static BindingNavigator OnEnter(this BindingNavigator control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static BindingNavigator OnGotFocus(this BindingNavigator control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static BindingNavigator OnKeyDown(this BindingNavigator control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static BindingNavigator OnKeyPress(this BindingNavigator control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static BindingNavigator OnKeyUp(this BindingNavigator control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static BindingNavigator OnLayout(this BindingNavigator control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static BindingNavigator OnLeave(this BindingNavigator control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static BindingNavigator OnLostFocus(this BindingNavigator control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static BindingNavigator OnMouseClick(this BindingNavigator control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static BindingNavigator OnMouseDoubleClick(this BindingNavigator control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static BindingNavigator OnMouseCaptureChanged(this BindingNavigator control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static BindingNavigator OnMouseDown(this BindingNavigator control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static BindingNavigator OnMouseEnter(this BindingNavigator control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static BindingNavigator OnMouseLeave(this BindingNavigator control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static BindingNavigator OnDpiChangedBeforeParent(this BindingNavigator control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static BindingNavigator OnDpiChangedAfterParent(this BindingNavigator control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static BindingNavigator OnMouseHover(this BindingNavigator control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static BindingNavigator OnMouseMove(this BindingNavigator control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static BindingNavigator OnMouseUp(this BindingNavigator control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static BindingNavigator OnMouseWheel(this BindingNavigator control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static BindingNavigator OnMove(this BindingNavigator control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static BindingNavigator OnPreviewKeyDown(this BindingNavigator control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static BindingNavigator OnResize(this BindingNavigator control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static BindingNavigator OnChangeUICues(this BindingNavigator control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static BindingNavigator OnStyleChanged(this BindingNavigator control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static BindingNavigator OnSystemColorsChanged(this BindingNavigator control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static BindingNavigator OnValidating(this BindingNavigator control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static BindingNavigator OnValidated(this BindingNavigator control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static BindingNavigator OnParentChanged(this BindingNavigator control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static BindingNavigator OnImeModeChanged(this BindingNavigator control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static BindingNavigator OnDisposed(this BindingNavigator control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static BindingNavigator AddTo(this BindingNavigator control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static BindingNavigator Assign(this BindingNavigator control, out BindingNavigator variable)
        {
            variable = control;
            return control;
        }

    }
}

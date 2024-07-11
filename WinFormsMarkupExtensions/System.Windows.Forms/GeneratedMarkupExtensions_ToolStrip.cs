using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ToolStripExtensions
    {
        public static ToolStrip AutoSize(this ToolStrip control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ToolStrip AutoScroll(this ToolStrip control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ToolStrip AutoScrollMargin(this ToolStrip control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ToolStrip AutoScrollMinSize(this ToolStrip control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ToolStrip AutoScrollPosition(this ToolStrip control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ToolStrip AllowDrop(this ToolStrip control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ToolStrip AllowItemReorder(this ToolStrip control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static ToolStrip AllowMerge(this ToolStrip control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static ToolStrip Anchor(this ToolStrip control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ToolStrip BackColor(this ToolStrip control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStrip BindingContext(this ToolStrip control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ToolStrip CanOverflow(this ToolStrip control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static ToolStrip CausesValidation(this ToolStrip control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ToolStrip Cursor(this ToolStrip control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ToolStrip Font(this ToolStrip control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ToolStrip DefaultDropDownDirection(this ToolStrip control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static ToolStrip Dock(this ToolStrip control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ToolStrip ForeColor(this ToolStrip control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStrip GripStyle(this ToolStrip control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static ToolStrip GripMargin(this ToolStrip control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static ToolStrip ImageScalingSize(this ToolStrip control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static ToolStrip ImageList(this ToolStrip control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static ToolStrip LayoutSettings(this ToolStrip control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static ToolStrip LayoutStyle(this ToolStrip control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static ToolStrip Stretch(this ToolStrip control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static ToolStrip Renderer(this ToolStrip control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static ToolStrip RenderMode(this ToolStrip control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static ToolStrip ShowItemToolTips(this ToolStrip control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static ToolStrip TabStop(this ToolStrip control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ToolStrip TextDirection(this ToolStrip control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static ToolStrip AccessibleDefaultActionDescription(this ToolStrip control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ToolStrip AccessibleDescription(this ToolStrip control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ToolStrip AccessibleName(this ToolStrip control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ToolStrip AccessibleRole(this ToolStrip control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ToolStrip AutoScrollOffset(this ToolStrip control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ToolStrip DataContext(this ToolStrip control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ToolStrip BackgroundImage(this ToolStrip control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ToolStrip BackgroundImageLayout(this ToolStrip control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ToolStrip Bounds(this ToolStrip control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ToolStrip Capture(this ToolStrip control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ToolStrip ClientSize(this ToolStrip control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ToolStrip ContextMenuStrip(this ToolStrip control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ToolStrip Enabled(this ToolStrip control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ToolStrip Height(this ToolStrip control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ToolStrip IsAccessible(this ToolStrip control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ToolStrip Left(this ToolStrip control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ToolStrip Location(this ToolStrip control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ToolStrip Margin(this ToolStrip control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ToolStrip MaximumSize(this ToolStrip control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ToolStrip MinimumSize(this ToolStrip control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ToolStrip Name(this ToolStrip control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ToolStrip Parent(this ToolStrip control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ToolStrip Region(this ToolStrip control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ToolStrip RightToLeft(this ToolStrip control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ToolStrip Size(this ToolStrip control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ToolStrip TabIndex(this ToolStrip control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ToolStrip Tag(this ToolStrip control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ToolStrip Text(this ToolStrip control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ToolStrip Top(this ToolStrip control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ToolStrip UseWaitCursor(this ToolStrip control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ToolStrip Visible(this ToolStrip control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ToolStrip Width(this ToolStrip control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ToolStrip WindowTarget(this ToolStrip control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ToolStrip Padding(this ToolStrip control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ToolStrip ImeMode(this ToolStrip control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ToolStrip OnAutoSizeChanged(this ToolStrip control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ToolStrip OnBeginDrag(this ToolStrip control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static ToolStrip OnCausesValidationChanged(this ToolStrip control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ToolStrip OnControlAdded(this ToolStrip control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ToolStrip OnCursorChanged(this ToolStrip control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ToolStrip OnControlRemoved(this ToolStrip control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ToolStrip OnEndDrag(this ToolStrip control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static ToolStrip OnForeColorChanged(this ToolStrip control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ToolStrip OnItemAdded(this ToolStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static ToolStrip OnItemClicked(this ToolStrip control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static ToolStrip OnItemRemoved(this ToolStrip control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static ToolStrip OnLayoutCompleted(this ToolStrip control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static ToolStrip OnLayoutStyleChanged(this ToolStrip control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static ToolStrip OnPaintGrip(this ToolStrip control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static ToolStrip OnRendererChanged(this ToolStrip control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static ToolStrip OnScroll(this ToolStrip control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ToolStrip OnBackColorChanged(this ToolStrip control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ToolStrip OnBackgroundImageChanged(this ToolStrip control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ToolStrip OnBackgroundImageLayoutChanged(this ToolStrip control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ToolStrip OnBindingContextChanged(this ToolStrip control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ToolStrip OnClientSizeChanged(this ToolStrip control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ToolStrip OnContextMenuStripChanged(this ToolStrip control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ToolStrip OnDockChanged(this ToolStrip control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ToolStrip OnEnabledChanged(this ToolStrip control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ToolStrip OnFontChanged(this ToolStrip control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ToolStrip OnLocationChanged(this ToolStrip control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ToolStrip OnMarginChanged(this ToolStrip control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ToolStrip OnRegionChanged(this ToolStrip control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ToolStrip OnRightToLeftChanged(this ToolStrip control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ToolStrip OnSizeChanged(this ToolStrip control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ToolStrip OnTabIndexChanged(this ToolStrip control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ToolStrip OnTabStopChanged(this ToolStrip control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ToolStrip OnTextChanged(this ToolStrip control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ToolStrip OnVisibleChanged(this ToolStrip control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ToolStrip OnClick(this ToolStrip control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ToolStrip OnDataContextChanged(this ToolStrip control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ToolStrip OnDragDrop(this ToolStrip control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ToolStrip OnDragEnter(this ToolStrip control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ToolStrip OnDragOver(this ToolStrip control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ToolStrip OnDragLeave(this ToolStrip control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ToolStrip OnGiveFeedback(this ToolStrip control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ToolStrip OnHandleCreated(this ToolStrip control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ToolStrip OnHandleDestroyed(this ToolStrip control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ToolStrip OnHelpRequested(this ToolStrip control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ToolStrip OnInvalidated(this ToolStrip control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ToolStrip OnPaddingChanged(this ToolStrip control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ToolStrip OnPaint(this ToolStrip control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ToolStrip OnQueryContinueDrag(this ToolStrip control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ToolStrip OnQueryAccessibilityHelp(this ToolStrip control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ToolStrip OnDoubleClick(this ToolStrip control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ToolStrip OnEnter(this ToolStrip control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ToolStrip OnGotFocus(this ToolStrip control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ToolStrip OnKeyDown(this ToolStrip control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ToolStrip OnKeyPress(this ToolStrip control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ToolStrip OnKeyUp(this ToolStrip control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ToolStrip OnLayout(this ToolStrip control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ToolStrip OnLeave(this ToolStrip control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ToolStrip OnLostFocus(this ToolStrip control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ToolStrip OnMouseClick(this ToolStrip control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ToolStrip OnMouseDoubleClick(this ToolStrip control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ToolStrip OnMouseCaptureChanged(this ToolStrip control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ToolStrip OnMouseDown(this ToolStrip control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ToolStrip OnMouseEnter(this ToolStrip control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ToolStrip OnMouseLeave(this ToolStrip control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ToolStrip OnDpiChangedBeforeParent(this ToolStrip control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ToolStrip OnDpiChangedAfterParent(this ToolStrip control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ToolStrip OnMouseHover(this ToolStrip control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ToolStrip OnMouseMove(this ToolStrip control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ToolStrip OnMouseUp(this ToolStrip control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ToolStrip OnMouseWheel(this ToolStrip control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ToolStrip OnMove(this ToolStrip control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ToolStrip OnPreviewKeyDown(this ToolStrip control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ToolStrip OnResize(this ToolStrip control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ToolStrip OnChangeUICues(this ToolStrip control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ToolStrip OnStyleChanged(this ToolStrip control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ToolStrip OnSystemColorsChanged(this ToolStrip control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ToolStrip OnValidating(this ToolStrip control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ToolStrip OnValidated(this ToolStrip control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ToolStrip OnParentChanged(this ToolStrip control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ToolStrip OnImeModeChanged(this ToolStrip control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ToolStrip OnDisposed(this ToolStrip control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ToolStrip AddTo(this ToolStrip control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

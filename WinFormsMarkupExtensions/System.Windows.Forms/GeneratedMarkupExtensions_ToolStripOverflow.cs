using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ToolStripOverflowExtensions
    {
        public static ToolStripOverflow AllowItemReorder(this ToolStripOverflow control, Boolean value)
        {
            control.AllowItemReorder = value;
            return control;
        }

        public static ToolStripOverflow AllowTransparency(this ToolStripOverflow control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static ToolStripOverflow Anchor(this ToolStripOverflow control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ToolStripOverflow AutoSize(this ToolStripOverflow control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ToolStripOverflow AutoClose(this ToolStripOverflow control, Boolean value)
        {
            control.AutoClose = value;
            return control;
        }

        public static ToolStripOverflow CanOverflow(this ToolStripOverflow control, Boolean value)
        {
            control.CanOverflow = value;
            return control;
        }

        public static ToolStripOverflow ContextMenuStrip(this ToolStripOverflow control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ToolStripOverflow DefaultDropDownDirection(this ToolStripOverflow control, ToolStripDropDownDirection value)
        {
            control.DefaultDropDownDirection = value;
            return control;
        }

        public static ToolStripOverflow Dock(this ToolStripOverflow control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ToolStripOverflow DropShadowEnabled(this ToolStripOverflow control, Boolean value)
        {
            control.DropShadowEnabled = value;
            return control;
        }

        public static ToolStripOverflow Font(this ToolStripOverflow control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ToolStripOverflow GripMargin(this ToolStripOverflow control, Padding value)
        {
            control.GripMargin = value;
            return control;
        }

        public static ToolStripOverflow GripStyle(this ToolStripOverflow control, ToolStripGripStyle value)
        {
            control.GripStyle = value;
            return control;
        }

        public static ToolStripOverflow Location(this ToolStripOverflow control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ToolStripOverflow Opacity(this ToolStripOverflow control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static ToolStripOverflow OwnerItem(this ToolStripOverflow control, ToolStripItem value)
        {
            control.OwnerItem = value;
            return control;
        }

        public static ToolStripOverflow Region(this ToolStripOverflow control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ToolStripOverflow RightToLeft(this ToolStripOverflow control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ToolStripOverflow Stretch(this ToolStripOverflow control, Boolean value)
        {
            control.Stretch = value;
            return control;
        }

        public static ToolStripOverflow TextDirection(this ToolStripOverflow control, ToolStripTextDirection value)
        {
            control.TextDirection = value;
            return control;
        }

        public static ToolStripOverflow TopLevel(this ToolStripOverflow control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static ToolStripOverflow TabIndex(this ToolStripOverflow control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ToolStripOverflow Visible(this ToolStripOverflow control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ToolStripOverflow AutoScroll(this ToolStripOverflow control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ToolStripOverflow AutoScrollMargin(this ToolStripOverflow control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ToolStripOverflow AutoScrollMinSize(this ToolStripOverflow control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ToolStripOverflow AutoScrollPosition(this ToolStripOverflow control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ToolStripOverflow AllowDrop(this ToolStripOverflow control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ToolStripOverflow AllowMerge(this ToolStripOverflow control, Boolean value)
        {
            control.AllowMerge = value;
            return control;
        }

        public static ToolStripOverflow BackColor(this ToolStripOverflow control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripOverflow BindingContext(this ToolStripOverflow control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ToolStripOverflow CausesValidation(this ToolStripOverflow control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ToolStripOverflow Cursor(this ToolStripOverflow control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ToolStripOverflow ForeColor(this ToolStripOverflow control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripOverflow ImageScalingSize(this ToolStripOverflow control, int width, int height)
        {
            control.ImageScalingSize = new Size(width, height);
            return control;
        }

        public static ToolStripOverflow ImageList(this ToolStripOverflow control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static ToolStripOverflow LayoutSettings(this ToolStripOverflow control, LayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static ToolStripOverflow LayoutStyle(this ToolStripOverflow control, ToolStripLayoutStyle value)
        {
            control.LayoutStyle = value;
            return control;
        }

        public static ToolStripOverflow Renderer(this ToolStripOverflow control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static ToolStripOverflow RenderMode(this ToolStripOverflow control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static ToolStripOverflow ShowItemToolTips(this ToolStripOverflow control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static ToolStripOverflow TabStop(this ToolStripOverflow control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ToolStripOverflow AccessibleDefaultActionDescription(this ToolStripOverflow control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ToolStripOverflow AccessibleDescription(this ToolStripOverflow control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ToolStripOverflow AccessibleName(this ToolStripOverflow control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ToolStripOverflow AccessibleRole(this ToolStripOverflow control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ToolStripOverflow AutoScrollOffset(this ToolStripOverflow control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ToolStripOverflow DataContext(this ToolStripOverflow control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ToolStripOverflow BackgroundImage(this ToolStripOverflow control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ToolStripOverflow BackgroundImageLayout(this ToolStripOverflow control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ToolStripOverflow Bounds(this ToolStripOverflow control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ToolStripOverflow Capture(this ToolStripOverflow control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ToolStripOverflow ClientSize(this ToolStripOverflow control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ToolStripOverflow Enabled(this ToolStripOverflow control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ToolStripOverflow Height(this ToolStripOverflow control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ToolStripOverflow IsAccessible(this ToolStripOverflow control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ToolStripOverflow Left(this ToolStripOverflow control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ToolStripOverflow Margin(this ToolStripOverflow control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ToolStripOverflow MaximumSize(this ToolStripOverflow control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ToolStripOverflow MinimumSize(this ToolStripOverflow control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ToolStripOverflow Name(this ToolStripOverflow control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ToolStripOverflow Parent(this ToolStripOverflow control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ToolStripOverflow Size(this ToolStripOverflow control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ToolStripOverflow Tag(this ToolStripOverflow control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ToolStripOverflow Text(this ToolStripOverflow control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ToolStripOverflow Top(this ToolStripOverflow control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ToolStripOverflow UseWaitCursor(this ToolStripOverflow control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ToolStripOverflow Width(this ToolStripOverflow control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ToolStripOverflow WindowTarget(this ToolStripOverflow control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ToolStripOverflow Padding(this ToolStripOverflow control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ToolStripOverflow ImeMode(this ToolStripOverflow control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ToolStripOverflow OnBackgroundImageChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnBackgroundImageLayoutChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnBindingContextChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnChangeUICues(this ToolStripOverflow control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ToolStripOverflow OnContextMenuStripChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnDockChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnClosed(this ToolStripOverflow control, ToolStripDropDownClosedEventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static ToolStripOverflow OnClosing(this ToolStripOverflow control, ToolStripDropDownClosingEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static ToolStripOverflow OnEnter(this ToolStripOverflow control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ToolStripOverflow OnFontChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnForeColorChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnGiveFeedback(this ToolStripOverflow control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ToolStripOverflow OnHelpRequested(this ToolStripOverflow control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ToolStripOverflow OnImeModeChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnKeyDown(this ToolStripOverflow control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ToolStripOverflow OnKeyPress(this ToolStripOverflow control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ToolStripOverflow OnKeyUp(this ToolStripOverflow control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ToolStripOverflow OnLeave(this ToolStripOverflow control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ToolStripOverflow OnOpening(this ToolStripOverflow control, CancelEventHandler handler)
        {
            control.Opening += handler;
            return control;
        }

        public static ToolStripOverflow OnOpened(this ToolStripOverflow control, EventHandler handler)
        {
            control.Opened += handler;
            return control;
        }

        public static ToolStripOverflow OnRegionChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnScroll(this ToolStripOverflow control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ToolStripOverflow OnStyleChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnTabStopChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnTextChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnTabIndexChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnValidated(this ToolStripOverflow control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ToolStripOverflow OnValidating(this ToolStripOverflow control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ToolStripOverflow OnAutoSizeChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnBeginDrag(this ToolStripOverflow control, EventHandler handler)
        {
            control.BeginDrag += handler;
            return control;
        }

        public static ToolStripOverflow OnCausesValidationChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnControlAdded(this ToolStripOverflow control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ToolStripOverflow OnCursorChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnControlRemoved(this ToolStripOverflow control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ToolStripOverflow OnEndDrag(this ToolStripOverflow control, EventHandler handler)
        {
            control.EndDrag += handler;
            return control;
        }

        public static ToolStripOverflow OnItemAdded(this ToolStripOverflow control, ToolStripItemEventHandler handler)
        {
            control.ItemAdded += handler;
            return control;
        }

        public static ToolStripOverflow OnItemClicked(this ToolStripOverflow control, ToolStripItemClickedEventHandler handler)
        {
            control.ItemClicked += handler;
            return control;
        }

        public static ToolStripOverflow OnItemRemoved(this ToolStripOverflow control, ToolStripItemEventHandler handler)
        {
            control.ItemRemoved += handler;
            return control;
        }

        public static ToolStripOverflow OnLayoutCompleted(this ToolStripOverflow control, EventHandler handler)
        {
            control.LayoutCompleted += handler;
            return control;
        }

        public static ToolStripOverflow OnLayoutStyleChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.LayoutStyleChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnPaintGrip(this ToolStripOverflow control, PaintEventHandler handler)
        {
            control.PaintGrip += handler;
            return control;
        }

        public static ToolStripOverflow OnRendererChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnBackColorChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnClientSizeChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnEnabledChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnLocationChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnMarginChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnRightToLeftChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnSizeChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnVisibleChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnClick(this ToolStripOverflow control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ToolStripOverflow OnDataContextChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnDragDrop(this ToolStripOverflow control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ToolStripOverflow OnDragEnter(this ToolStripOverflow control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ToolStripOverflow OnDragOver(this ToolStripOverflow control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ToolStripOverflow OnDragLeave(this ToolStripOverflow control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ToolStripOverflow OnHandleCreated(this ToolStripOverflow control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ToolStripOverflow OnHandleDestroyed(this ToolStripOverflow control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ToolStripOverflow OnInvalidated(this ToolStripOverflow control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ToolStripOverflow OnPaddingChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnPaint(this ToolStripOverflow control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ToolStripOverflow OnQueryContinueDrag(this ToolStripOverflow control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ToolStripOverflow OnQueryAccessibilityHelp(this ToolStripOverflow control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ToolStripOverflow OnDoubleClick(this ToolStripOverflow control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ToolStripOverflow OnGotFocus(this ToolStripOverflow control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ToolStripOverflow OnLayout(this ToolStripOverflow control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ToolStripOverflow OnLostFocus(this ToolStripOverflow control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseClick(this ToolStripOverflow control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseDoubleClick(this ToolStripOverflow control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseCaptureChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseDown(this ToolStripOverflow control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseEnter(this ToolStripOverflow control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseLeave(this ToolStripOverflow control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ToolStripOverflow OnDpiChangedBeforeParent(this ToolStripOverflow control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ToolStripOverflow OnDpiChangedAfterParent(this ToolStripOverflow control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseHover(this ToolStripOverflow control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseMove(this ToolStripOverflow control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseUp(this ToolStripOverflow control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ToolStripOverflow OnMouseWheel(this ToolStripOverflow control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ToolStripOverflow OnMove(this ToolStripOverflow control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ToolStripOverflow OnPreviewKeyDown(this ToolStripOverflow control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ToolStripOverflow OnResize(this ToolStripOverflow control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ToolStripOverflow OnSystemColorsChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnParentChanged(this ToolStripOverflow control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ToolStripOverflow OnDisposed(this ToolStripOverflow control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ToolStripOverflow AddTo(this ToolStripOverflow control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

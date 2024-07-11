using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ToolStripContentPanelExtensions
    {
        public static ToolStripContentPanel AutoSizeMode(this ToolStripContentPanel control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static ToolStripContentPanel Anchor(this ToolStripContentPanel control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ToolStripContentPanel AutoScroll(this ToolStripContentPanel control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ToolStripContentPanel AutoScrollMargin(this ToolStripContentPanel control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ToolStripContentPanel AutoScrollMinSize(this ToolStripContentPanel control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ToolStripContentPanel AutoSize(this ToolStripContentPanel control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ToolStripContentPanel BackColor(this ToolStripContentPanel control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripContentPanel CausesValidation(this ToolStripContentPanel control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ToolStripContentPanel Dock(this ToolStripContentPanel control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ToolStripContentPanel Location(this ToolStripContentPanel control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ToolStripContentPanel MinimumSize(this ToolStripContentPanel control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ToolStripContentPanel MaximumSize(this ToolStripContentPanel control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ToolStripContentPanel Name(this ToolStripContentPanel control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ToolStripContentPanel TabIndex(this ToolStripContentPanel control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ToolStripContentPanel TabStop(this ToolStripContentPanel control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ToolStripContentPanel Renderer(this ToolStripContentPanel control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static ToolStripContentPanel RenderMode(this ToolStripContentPanel control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static ToolStripContentPanel BorderStyle(this ToolStripContentPanel control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static ToolStripContentPanel Text(this ToolStripContentPanel control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ToolStripContentPanel AutoScrollPosition(this ToolStripContentPanel control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ToolStripContentPanel AccessibleDefaultActionDescription(this ToolStripContentPanel control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ToolStripContentPanel AccessibleDescription(this ToolStripContentPanel control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ToolStripContentPanel AccessibleName(this ToolStripContentPanel control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ToolStripContentPanel AccessibleRole(this ToolStripContentPanel control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ToolStripContentPanel AllowDrop(this ToolStripContentPanel control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ToolStripContentPanel AutoScrollOffset(this ToolStripContentPanel control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ToolStripContentPanel DataContext(this ToolStripContentPanel control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ToolStripContentPanel BackgroundImage(this ToolStripContentPanel control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ToolStripContentPanel BackgroundImageLayout(this ToolStripContentPanel control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ToolStripContentPanel BindingContext(this ToolStripContentPanel control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ToolStripContentPanel Bounds(this ToolStripContentPanel control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ToolStripContentPanel Capture(this ToolStripContentPanel control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ToolStripContentPanel ClientSize(this ToolStripContentPanel control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ToolStripContentPanel ContextMenuStrip(this ToolStripContentPanel control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ToolStripContentPanel Cursor(this ToolStripContentPanel control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ToolStripContentPanel Enabled(this ToolStripContentPanel control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ToolStripContentPanel Font(this ToolStripContentPanel control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ToolStripContentPanel ForeColor(this ToolStripContentPanel control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripContentPanel Height(this ToolStripContentPanel control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ToolStripContentPanel IsAccessible(this ToolStripContentPanel control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ToolStripContentPanel Left(this ToolStripContentPanel control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ToolStripContentPanel Margin(this ToolStripContentPanel control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ToolStripContentPanel Parent(this ToolStripContentPanel control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ToolStripContentPanel Region(this ToolStripContentPanel control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ToolStripContentPanel RightToLeft(this ToolStripContentPanel control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ToolStripContentPanel Size(this ToolStripContentPanel control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ToolStripContentPanel Tag(this ToolStripContentPanel control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ToolStripContentPanel Top(this ToolStripContentPanel control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ToolStripContentPanel UseWaitCursor(this ToolStripContentPanel control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ToolStripContentPanel Visible(this ToolStripContentPanel control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ToolStripContentPanel Width(this ToolStripContentPanel control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ToolStripContentPanel WindowTarget(this ToolStripContentPanel control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ToolStripContentPanel Padding(this ToolStripContentPanel control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ToolStripContentPanel ImeMode(this ToolStripContentPanel control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ToolStripContentPanel OnAutoSizeChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnCausesValidationChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnDockChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnLoad(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Load += handler;
            return control;
        }

        public static ToolStripContentPanel OnLocationChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnTabIndexChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnTabStopChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnRendererChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnKeyUp(this ToolStripContentPanel control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ToolStripContentPanel OnKeyDown(this ToolStripContentPanel control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ToolStripContentPanel OnKeyPress(this ToolStripContentPanel control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ToolStripContentPanel OnTextChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnScroll(this ToolStripContentPanel control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ToolStripContentPanel OnBackColorChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnBackgroundImageChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnBackgroundImageLayoutChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnBindingContextChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnClientSizeChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnContextMenuStripChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnCursorChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnEnabledChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnFontChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnForeColorChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnMarginChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnRegionChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnRightToLeftChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnSizeChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnVisibleChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnClick(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ToolStripContentPanel OnControlAdded(this ToolStripContentPanel control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ToolStripContentPanel OnControlRemoved(this ToolStripContentPanel control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ToolStripContentPanel OnDataContextChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnDragDrop(this ToolStripContentPanel control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ToolStripContentPanel OnDragEnter(this ToolStripContentPanel control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ToolStripContentPanel OnDragOver(this ToolStripContentPanel control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ToolStripContentPanel OnDragLeave(this ToolStripContentPanel control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ToolStripContentPanel OnGiveFeedback(this ToolStripContentPanel control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ToolStripContentPanel OnHandleCreated(this ToolStripContentPanel control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ToolStripContentPanel OnHandleDestroyed(this ToolStripContentPanel control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ToolStripContentPanel OnHelpRequested(this ToolStripContentPanel control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ToolStripContentPanel OnInvalidated(this ToolStripContentPanel control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ToolStripContentPanel OnPaddingChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnPaint(this ToolStripContentPanel control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ToolStripContentPanel OnQueryContinueDrag(this ToolStripContentPanel control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ToolStripContentPanel OnQueryAccessibilityHelp(this ToolStripContentPanel control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ToolStripContentPanel OnDoubleClick(this ToolStripContentPanel control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ToolStripContentPanel OnEnter(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ToolStripContentPanel OnGotFocus(this ToolStripContentPanel control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ToolStripContentPanel OnLayout(this ToolStripContentPanel control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ToolStripContentPanel OnLeave(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ToolStripContentPanel OnLostFocus(this ToolStripContentPanel control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseClick(this ToolStripContentPanel control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseDoubleClick(this ToolStripContentPanel control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseCaptureChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseDown(this ToolStripContentPanel control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseEnter(this ToolStripContentPanel control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseLeave(this ToolStripContentPanel control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ToolStripContentPanel OnDpiChangedBeforeParent(this ToolStripContentPanel control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ToolStripContentPanel OnDpiChangedAfterParent(this ToolStripContentPanel control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseHover(this ToolStripContentPanel control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseMove(this ToolStripContentPanel control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseUp(this ToolStripContentPanel control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ToolStripContentPanel OnMouseWheel(this ToolStripContentPanel control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ToolStripContentPanel OnMove(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ToolStripContentPanel OnPreviewKeyDown(this ToolStripContentPanel control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ToolStripContentPanel OnResize(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ToolStripContentPanel OnChangeUICues(this ToolStripContentPanel control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ToolStripContentPanel OnStyleChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnSystemColorsChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnValidating(this ToolStripContentPanel control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ToolStripContentPanel OnValidated(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ToolStripContentPanel OnParentChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnImeModeChanged(this ToolStripContentPanel control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ToolStripContentPanel OnDisposed(this ToolStripContentPanel control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ToolStripContentPanel AddTo(this ToolStripContentPanel control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

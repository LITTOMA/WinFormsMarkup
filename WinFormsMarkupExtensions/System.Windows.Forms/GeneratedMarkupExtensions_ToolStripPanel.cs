using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ToolStripPanelExtensions
    {
        public static ToolStripPanel AllowDrop(this ToolStripPanel control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ToolStripPanel AutoScroll(this ToolStripPanel control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ToolStripPanel AutoScrollMargin(this ToolStripPanel control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ToolStripPanel AutoScrollMinSize(this ToolStripPanel control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ToolStripPanel AutoSize(this ToolStripPanel control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ToolStripPanel RowMargin(this ToolStripPanel control, Padding value)
        {
            control.RowMargin = value;
            return control;
        }

        public static ToolStripPanel Dock(this ToolStripPanel control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ToolStripPanel Locked(this ToolStripPanel control, Boolean value)
        {
            control.Locked = value;
            return control;
        }

        public static ToolStripPanel Orientation(this ToolStripPanel control, Orientation value)
        {
            control.Orientation = value;
            return control;
        }

        public static ToolStripPanel Renderer(this ToolStripPanel control, ToolStripRenderer value)
        {
            control.Renderer = value;
            return control;
        }

        public static ToolStripPanel RenderMode(this ToolStripPanel control, ToolStripRenderMode value)
        {
            control.RenderMode = value;
            return control;
        }

        public static ToolStripPanel TabIndex(this ToolStripPanel control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ToolStripPanel TabStop(this ToolStripPanel control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ToolStripPanel Text(this ToolStripPanel control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ToolStripPanel AutoScaleDimensions(this ToolStripPanel control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static ToolStripPanel AutoScaleMode(this ToolStripPanel control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static ToolStripPanel AutoValidate(this ToolStripPanel control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static ToolStripPanel BindingContext(this ToolStripPanel control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ToolStripPanel ActiveControl(this ToolStripPanel control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static ToolStripPanel AutoScrollPosition(this ToolStripPanel control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ToolStripPanel AccessibleDefaultActionDescription(this ToolStripPanel control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ToolStripPanel AccessibleDescription(this ToolStripPanel control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ToolStripPanel AccessibleName(this ToolStripPanel control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ToolStripPanel AccessibleRole(this ToolStripPanel control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ToolStripPanel Anchor(this ToolStripPanel control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ToolStripPanel AutoScrollOffset(this ToolStripPanel control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ToolStripPanel DataContext(this ToolStripPanel control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ToolStripPanel BackColor(this ToolStripPanel control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripPanel BackgroundImage(this ToolStripPanel control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ToolStripPanel BackgroundImageLayout(this ToolStripPanel control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ToolStripPanel Bounds(this ToolStripPanel control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ToolStripPanel Capture(this ToolStripPanel control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ToolStripPanel CausesValidation(this ToolStripPanel control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ToolStripPanel ClientSize(this ToolStripPanel control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ToolStripPanel ContextMenuStrip(this ToolStripPanel control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ToolStripPanel Cursor(this ToolStripPanel control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ToolStripPanel Enabled(this ToolStripPanel control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ToolStripPanel Font(this ToolStripPanel control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ToolStripPanel ForeColor(this ToolStripPanel control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripPanel Height(this ToolStripPanel control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ToolStripPanel IsAccessible(this ToolStripPanel control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ToolStripPanel Left(this ToolStripPanel control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ToolStripPanel Location(this ToolStripPanel control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ToolStripPanel Margin(this ToolStripPanel control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ToolStripPanel MaximumSize(this ToolStripPanel control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ToolStripPanel MinimumSize(this ToolStripPanel control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ToolStripPanel Name(this ToolStripPanel control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ToolStripPanel Parent(this ToolStripPanel control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ToolStripPanel Region(this ToolStripPanel control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ToolStripPanel RightToLeft(this ToolStripPanel control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ToolStripPanel Size(this ToolStripPanel control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ToolStripPanel Tag(this ToolStripPanel control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ToolStripPanel Top(this ToolStripPanel control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ToolStripPanel UseWaitCursor(this ToolStripPanel control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ToolStripPanel Visible(this ToolStripPanel control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ToolStripPanel Width(this ToolStripPanel control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ToolStripPanel WindowTarget(this ToolStripPanel control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ToolStripPanel Padding(this ToolStripPanel control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ToolStripPanel ImeMode(this ToolStripPanel control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ToolStripPanel OnAutoSizeChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ToolStripPanel OnRendererChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.RendererChanged += handler;
            return control;
        }

        public static ToolStripPanel OnTabIndexChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ToolStripPanel OnTabStopChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ToolStripPanel OnTextChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ToolStripPanel OnAutoValidateChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static ToolStripPanel OnScroll(this ToolStripPanel control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ToolStripPanel OnBackColorChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ToolStripPanel OnBackgroundImageChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ToolStripPanel OnBackgroundImageLayoutChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ToolStripPanel OnBindingContextChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ToolStripPanel OnCausesValidationChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ToolStripPanel OnClientSizeChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ToolStripPanel OnContextMenuStripChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ToolStripPanel OnCursorChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ToolStripPanel OnDockChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ToolStripPanel OnEnabledChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ToolStripPanel OnFontChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ToolStripPanel OnForeColorChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ToolStripPanel OnLocationChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ToolStripPanel OnMarginChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ToolStripPanel OnRegionChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ToolStripPanel OnRightToLeftChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ToolStripPanel OnSizeChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ToolStripPanel OnVisibleChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ToolStripPanel OnClick(this ToolStripPanel control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ToolStripPanel OnControlAdded(this ToolStripPanel control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ToolStripPanel OnControlRemoved(this ToolStripPanel control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ToolStripPanel OnDataContextChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ToolStripPanel OnDragDrop(this ToolStripPanel control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ToolStripPanel OnDragEnter(this ToolStripPanel control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ToolStripPanel OnDragOver(this ToolStripPanel control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ToolStripPanel OnDragLeave(this ToolStripPanel control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ToolStripPanel OnGiveFeedback(this ToolStripPanel control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ToolStripPanel OnHandleCreated(this ToolStripPanel control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ToolStripPanel OnHandleDestroyed(this ToolStripPanel control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ToolStripPanel OnHelpRequested(this ToolStripPanel control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ToolStripPanel OnInvalidated(this ToolStripPanel control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ToolStripPanel OnPaddingChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ToolStripPanel OnPaint(this ToolStripPanel control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ToolStripPanel OnQueryContinueDrag(this ToolStripPanel control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ToolStripPanel OnQueryAccessibilityHelp(this ToolStripPanel control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ToolStripPanel OnDoubleClick(this ToolStripPanel control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ToolStripPanel OnEnter(this ToolStripPanel control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ToolStripPanel OnGotFocus(this ToolStripPanel control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ToolStripPanel OnKeyDown(this ToolStripPanel control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ToolStripPanel OnKeyPress(this ToolStripPanel control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ToolStripPanel OnKeyUp(this ToolStripPanel control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ToolStripPanel OnLayout(this ToolStripPanel control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ToolStripPanel OnLeave(this ToolStripPanel control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ToolStripPanel OnLostFocus(this ToolStripPanel control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ToolStripPanel OnMouseClick(this ToolStripPanel control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ToolStripPanel OnMouseDoubleClick(this ToolStripPanel control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ToolStripPanel OnMouseCaptureChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ToolStripPanel OnMouseDown(this ToolStripPanel control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ToolStripPanel OnMouseEnter(this ToolStripPanel control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ToolStripPanel OnMouseLeave(this ToolStripPanel control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ToolStripPanel OnDpiChangedBeforeParent(this ToolStripPanel control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ToolStripPanel OnDpiChangedAfterParent(this ToolStripPanel control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ToolStripPanel OnMouseHover(this ToolStripPanel control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ToolStripPanel OnMouseMove(this ToolStripPanel control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ToolStripPanel OnMouseUp(this ToolStripPanel control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ToolStripPanel OnMouseWheel(this ToolStripPanel control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ToolStripPanel OnMove(this ToolStripPanel control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ToolStripPanel OnPreviewKeyDown(this ToolStripPanel control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ToolStripPanel OnResize(this ToolStripPanel control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ToolStripPanel OnChangeUICues(this ToolStripPanel control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ToolStripPanel OnStyleChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ToolStripPanel OnSystemColorsChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ToolStripPanel OnValidating(this ToolStripPanel control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ToolStripPanel OnValidated(this ToolStripPanel control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ToolStripPanel OnParentChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ToolStripPanel OnImeModeChanged(this ToolStripPanel control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ToolStripPanel OnDisposed(this ToolStripPanel control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ToolStripPanel AddTo(this ToolStripPanel control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ToolStripPanel AddControls(this ToolStripPanel control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

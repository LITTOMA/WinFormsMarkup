using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ToolStripContainerExtensions
    {
        public static ToolStripContainer AutoScroll(this ToolStripContainer control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ToolStripContainer AutoScrollMargin(this ToolStripContainer control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ToolStripContainer AutoScrollMinSize(this ToolStripContainer control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ToolStripContainer BackColor(this ToolStripContainer control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripContainer BackgroundImage(this ToolStripContainer control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ToolStripContainer BackgroundImageLayout(this ToolStripContainer control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ToolStripContainer BottomToolStripPanelVisible(this ToolStripContainer control, Boolean value)
        {
            control.BottomToolStripPanelVisible = value;
            return control;
        }

        public static ToolStripContainer CausesValidation(this ToolStripContainer control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ToolStripContainer ContextMenuStrip(this ToolStripContainer control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ToolStripContainer Cursor(this ToolStripContainer control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ToolStripContainer ForeColor(this ToolStripContainer control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ToolStripContainer LeftToolStripPanelVisible(this ToolStripContainer control, Boolean value)
        {
            control.LeftToolStripPanelVisible = value;
            return control;
        }

        public static ToolStripContainer RightToolStripPanelVisible(this ToolStripContainer control, Boolean value)
        {
            control.RightToolStripPanelVisible = value;
            return control;
        }

        public static ToolStripContainer TopToolStripPanelVisible(this ToolStripContainer control, Boolean value)
        {
            control.TopToolStripPanelVisible = value;
            return control;
        }

        public static ToolStripContainer AutoScaleDimensions(this ToolStripContainer control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static ToolStripContainer AutoScaleMode(this ToolStripContainer control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static ToolStripContainer AutoValidate(this ToolStripContainer control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static ToolStripContainer BindingContext(this ToolStripContainer control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ToolStripContainer ActiveControl(this ToolStripContainer control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static ToolStripContainer AutoScrollPosition(this ToolStripContainer control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ToolStripContainer AccessibleDefaultActionDescription(this ToolStripContainer control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ToolStripContainer AccessibleDescription(this ToolStripContainer control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ToolStripContainer AccessibleName(this ToolStripContainer control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ToolStripContainer AccessibleRole(this ToolStripContainer control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ToolStripContainer AllowDrop(this ToolStripContainer control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ToolStripContainer Anchor(this ToolStripContainer control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ToolStripContainer AutoSize(this ToolStripContainer control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ToolStripContainer AutoScrollOffset(this ToolStripContainer control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ToolStripContainer DataContext(this ToolStripContainer control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ToolStripContainer Bounds(this ToolStripContainer control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ToolStripContainer Capture(this ToolStripContainer control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ToolStripContainer ClientSize(this ToolStripContainer control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ToolStripContainer Dock(this ToolStripContainer control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ToolStripContainer Enabled(this ToolStripContainer control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ToolStripContainer Font(this ToolStripContainer control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ToolStripContainer Height(this ToolStripContainer control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ToolStripContainer IsAccessible(this ToolStripContainer control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ToolStripContainer Left(this ToolStripContainer control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ToolStripContainer Location(this ToolStripContainer control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ToolStripContainer Margin(this ToolStripContainer control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ToolStripContainer MaximumSize(this ToolStripContainer control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ToolStripContainer MinimumSize(this ToolStripContainer control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ToolStripContainer Name(this ToolStripContainer control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ToolStripContainer Parent(this ToolStripContainer control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ToolStripContainer Region(this ToolStripContainer control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ToolStripContainer RightToLeft(this ToolStripContainer control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ToolStripContainer Size(this ToolStripContainer control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ToolStripContainer TabIndex(this ToolStripContainer control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ToolStripContainer TabStop(this ToolStripContainer control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ToolStripContainer Tag(this ToolStripContainer control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ToolStripContainer Text(this ToolStripContainer control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ToolStripContainer Top(this ToolStripContainer control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ToolStripContainer UseWaitCursor(this ToolStripContainer control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ToolStripContainer Visible(this ToolStripContainer control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ToolStripContainer Width(this ToolStripContainer control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ToolStripContainer WindowTarget(this ToolStripContainer control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ToolStripContainer Padding(this ToolStripContainer control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ToolStripContainer ImeMode(this ToolStripContainer control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ToolStripContainer OnBackColorChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ToolStripContainer OnBackgroundImageChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ToolStripContainer OnBackgroundImageLayoutChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ToolStripContainer OnCausesValidationChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ToolStripContainer OnContextMenuStripChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ToolStripContainer OnCursorChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ToolStripContainer OnForeColorChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ToolStripContainer OnAutoValidateChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static ToolStripContainer OnScroll(this ToolStripContainer control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ToolStripContainer OnAutoSizeChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ToolStripContainer OnBindingContextChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ToolStripContainer OnClientSizeChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ToolStripContainer OnDockChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ToolStripContainer OnEnabledChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ToolStripContainer OnFontChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ToolStripContainer OnLocationChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ToolStripContainer OnMarginChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ToolStripContainer OnRegionChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ToolStripContainer OnRightToLeftChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ToolStripContainer OnSizeChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ToolStripContainer OnTabIndexChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ToolStripContainer OnTabStopChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ToolStripContainer OnTextChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ToolStripContainer OnVisibleChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ToolStripContainer OnClick(this ToolStripContainer control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ToolStripContainer OnControlAdded(this ToolStripContainer control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ToolStripContainer OnControlRemoved(this ToolStripContainer control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ToolStripContainer OnDataContextChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ToolStripContainer OnDragDrop(this ToolStripContainer control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ToolStripContainer OnDragEnter(this ToolStripContainer control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ToolStripContainer OnDragOver(this ToolStripContainer control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ToolStripContainer OnDragLeave(this ToolStripContainer control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ToolStripContainer OnGiveFeedback(this ToolStripContainer control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ToolStripContainer OnHandleCreated(this ToolStripContainer control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ToolStripContainer OnHandleDestroyed(this ToolStripContainer control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ToolStripContainer OnHelpRequested(this ToolStripContainer control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ToolStripContainer OnInvalidated(this ToolStripContainer control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ToolStripContainer OnPaddingChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ToolStripContainer OnPaint(this ToolStripContainer control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ToolStripContainer OnQueryContinueDrag(this ToolStripContainer control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ToolStripContainer OnQueryAccessibilityHelp(this ToolStripContainer control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ToolStripContainer OnDoubleClick(this ToolStripContainer control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ToolStripContainer OnEnter(this ToolStripContainer control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ToolStripContainer OnGotFocus(this ToolStripContainer control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ToolStripContainer OnKeyDown(this ToolStripContainer control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ToolStripContainer OnKeyPress(this ToolStripContainer control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ToolStripContainer OnKeyUp(this ToolStripContainer control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ToolStripContainer OnLayout(this ToolStripContainer control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ToolStripContainer OnLeave(this ToolStripContainer control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ToolStripContainer OnLostFocus(this ToolStripContainer control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ToolStripContainer OnMouseClick(this ToolStripContainer control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ToolStripContainer OnMouseDoubleClick(this ToolStripContainer control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ToolStripContainer OnMouseCaptureChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ToolStripContainer OnMouseDown(this ToolStripContainer control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ToolStripContainer OnMouseEnter(this ToolStripContainer control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ToolStripContainer OnMouseLeave(this ToolStripContainer control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ToolStripContainer OnDpiChangedBeforeParent(this ToolStripContainer control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ToolStripContainer OnDpiChangedAfterParent(this ToolStripContainer control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ToolStripContainer OnMouseHover(this ToolStripContainer control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ToolStripContainer OnMouseMove(this ToolStripContainer control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ToolStripContainer OnMouseUp(this ToolStripContainer control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ToolStripContainer OnMouseWheel(this ToolStripContainer control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ToolStripContainer OnMove(this ToolStripContainer control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ToolStripContainer OnPreviewKeyDown(this ToolStripContainer control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ToolStripContainer OnResize(this ToolStripContainer control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ToolStripContainer OnChangeUICues(this ToolStripContainer control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ToolStripContainer OnStyleChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ToolStripContainer OnSystemColorsChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ToolStripContainer OnValidating(this ToolStripContainer control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ToolStripContainer OnValidated(this ToolStripContainer control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ToolStripContainer OnParentChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ToolStripContainer OnImeModeChanged(this ToolStripContainer control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ToolStripContainer OnDisposed(this ToolStripContainer control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ToolStripContainer AddTo(this ToolStripContainer control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ToolStripContainer AddControls(this ToolStripContainer control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

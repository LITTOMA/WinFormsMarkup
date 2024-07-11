using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class SplitContainerExtensions
    {
        public static SplitContainer AutoScroll(this SplitContainer control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static SplitContainer AutoScrollOffset(this SplitContainer control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static SplitContainer AutoScrollMinSize(this SplitContainer control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static SplitContainer AutoScrollMargin(this SplitContainer control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static SplitContainer AutoScrollPosition(this SplitContainer control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static SplitContainer AutoSize(this SplitContainer control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static SplitContainer BackgroundImage(this SplitContainer control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static SplitContainer BackgroundImageLayout(this SplitContainer control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static SplitContainer BindingContext(this SplitContainer control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static SplitContainer BorderStyle(this SplitContainer control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static SplitContainer Dock(this SplitContainer control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static SplitContainer FixedPanel(this SplitContainer control, FixedPanel value)
        {
            control.FixedPanel = value;
            return control;
        }

        public static SplitContainer IsSplitterFixed(this SplitContainer control, Boolean value)
        {
            control.IsSplitterFixed = value;
            return control;
        }

        public static SplitContainer Orientation(this SplitContainer control, Orientation value)
        {
            control.Orientation = value;
            return control;
        }

        public static SplitContainer Padding(this SplitContainer control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static SplitContainer Panel1Collapsed(this SplitContainer control, Boolean value)
        {
            control.Panel1Collapsed = value;
            return control;
        }

        public static SplitContainer Panel2Collapsed(this SplitContainer control, Boolean value)
        {
            control.Panel2Collapsed = value;
            return control;
        }

        public static SplitContainer Panel1MinSize(this SplitContainer control, Int32 value)
        {
            control.Panel1MinSize = value;
            return control;
        }

        public static SplitContainer Panel2MinSize(this SplitContainer control, Int32 value)
        {
            control.Panel2MinSize = value;
            return control;
        }

        public static SplitContainer SplitterDistance(this SplitContainer control, Int32 value)
        {
            control.SplitterDistance = value;
            return control;
        }

        public static SplitContainer SplitterIncrement(this SplitContainer control, Int32 value)
        {
            control.SplitterIncrement = value;
            return control;
        }

        public static SplitContainer SplitterWidth(this SplitContainer control, Int32 value)
        {
            control.SplitterWidth = value;
            return control;
        }

        public static SplitContainer TabStop(this SplitContainer control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static SplitContainer Text(this SplitContainer control, String value)
        {
            control.Text = value;
            return control;
        }

        public static SplitContainer AutoScaleDimensions(this SplitContainer control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static SplitContainer AutoScaleMode(this SplitContainer control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static SplitContainer AutoValidate(this SplitContainer control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static SplitContainer ActiveControl(this SplitContainer control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static SplitContainer AccessibleDefaultActionDescription(this SplitContainer control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static SplitContainer AccessibleDescription(this SplitContainer control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static SplitContainer AccessibleName(this SplitContainer control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static SplitContainer AccessibleRole(this SplitContainer control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static SplitContainer AllowDrop(this SplitContainer control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static SplitContainer Anchor(this SplitContainer control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static SplitContainer DataContext(this SplitContainer control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static SplitContainer BackColor(this SplitContainer control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static SplitContainer Bounds(this SplitContainer control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static SplitContainer Capture(this SplitContainer control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static SplitContainer CausesValidation(this SplitContainer control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static SplitContainer ClientSize(this SplitContainer control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static SplitContainer ContextMenuStrip(this SplitContainer control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static SplitContainer Cursor(this SplitContainer control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static SplitContainer Enabled(this SplitContainer control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static SplitContainer Font(this SplitContainer control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static SplitContainer ForeColor(this SplitContainer control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static SplitContainer Height(this SplitContainer control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static SplitContainer IsAccessible(this SplitContainer control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static SplitContainer Left(this SplitContainer control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static SplitContainer Location(this SplitContainer control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static SplitContainer Margin(this SplitContainer control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static SplitContainer MaximumSize(this SplitContainer control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static SplitContainer MinimumSize(this SplitContainer control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static SplitContainer Name(this SplitContainer control, String value)
        {
            control.Name = value;
            return control;
        }

        public static SplitContainer Parent(this SplitContainer control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static SplitContainer Region(this SplitContainer control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static SplitContainer RightToLeft(this SplitContainer control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static SplitContainer Size(this SplitContainer control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static SplitContainer TabIndex(this SplitContainer control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static SplitContainer Tag(this SplitContainer control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static SplitContainer Top(this SplitContainer control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static SplitContainer UseWaitCursor(this SplitContainer control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static SplitContainer Visible(this SplitContainer control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static SplitContainer Width(this SplitContainer control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static SplitContainer WindowTarget(this SplitContainer control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static SplitContainer ImeMode(this SplitContainer control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static SplitContainer OnAutoSizeChanged(this SplitContainer control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static SplitContainer OnControlAdded(this SplitContainer control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static SplitContainer OnControlRemoved(this SplitContainer control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static SplitContainer OnPaddingChanged(this SplitContainer control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static SplitContainer OnBackgroundImageChanged(this SplitContainer control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static SplitContainer OnBackgroundImageLayoutChanged(this SplitContainer control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static SplitContainer OnSplitterMoving(this SplitContainer control, SplitterCancelEventHandler handler)
        {
            control.SplitterMoving += handler;
            return control;
        }

        public static SplitContainer OnSplitterMoved(this SplitContainer control, SplitterEventHandler handler)
        {
            control.SplitterMoved += handler;
            return control;
        }

        public static SplitContainer OnTextChanged(this SplitContainer control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static SplitContainer OnAutoValidateChanged(this SplitContainer control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static SplitContainer OnScroll(this SplitContainer control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static SplitContainer OnBackColorChanged(this SplitContainer control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static SplitContainer OnBindingContextChanged(this SplitContainer control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static SplitContainer OnCausesValidationChanged(this SplitContainer control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static SplitContainer OnClientSizeChanged(this SplitContainer control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static SplitContainer OnContextMenuStripChanged(this SplitContainer control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static SplitContainer OnCursorChanged(this SplitContainer control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static SplitContainer OnDockChanged(this SplitContainer control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static SplitContainer OnEnabledChanged(this SplitContainer control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static SplitContainer OnFontChanged(this SplitContainer control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static SplitContainer OnForeColorChanged(this SplitContainer control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static SplitContainer OnLocationChanged(this SplitContainer control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static SplitContainer OnMarginChanged(this SplitContainer control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static SplitContainer OnRegionChanged(this SplitContainer control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static SplitContainer OnRightToLeftChanged(this SplitContainer control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static SplitContainer OnSizeChanged(this SplitContainer control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static SplitContainer OnTabIndexChanged(this SplitContainer control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static SplitContainer OnTabStopChanged(this SplitContainer control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static SplitContainer OnVisibleChanged(this SplitContainer control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static SplitContainer OnClick(this SplitContainer control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static SplitContainer OnDataContextChanged(this SplitContainer control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static SplitContainer OnDragDrop(this SplitContainer control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static SplitContainer OnDragEnter(this SplitContainer control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static SplitContainer OnDragOver(this SplitContainer control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static SplitContainer OnDragLeave(this SplitContainer control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static SplitContainer OnGiveFeedback(this SplitContainer control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static SplitContainer OnHandleCreated(this SplitContainer control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static SplitContainer OnHandleDestroyed(this SplitContainer control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static SplitContainer OnHelpRequested(this SplitContainer control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static SplitContainer OnInvalidated(this SplitContainer control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static SplitContainer OnPaint(this SplitContainer control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static SplitContainer OnQueryContinueDrag(this SplitContainer control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static SplitContainer OnQueryAccessibilityHelp(this SplitContainer control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static SplitContainer OnDoubleClick(this SplitContainer control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static SplitContainer OnEnter(this SplitContainer control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static SplitContainer OnGotFocus(this SplitContainer control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static SplitContainer OnKeyDown(this SplitContainer control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static SplitContainer OnKeyPress(this SplitContainer control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static SplitContainer OnKeyUp(this SplitContainer control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static SplitContainer OnLayout(this SplitContainer control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static SplitContainer OnLeave(this SplitContainer control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static SplitContainer OnLostFocus(this SplitContainer control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static SplitContainer OnMouseClick(this SplitContainer control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static SplitContainer OnMouseDoubleClick(this SplitContainer control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static SplitContainer OnMouseCaptureChanged(this SplitContainer control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static SplitContainer OnMouseDown(this SplitContainer control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static SplitContainer OnMouseEnter(this SplitContainer control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static SplitContainer OnMouseLeave(this SplitContainer control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static SplitContainer OnDpiChangedBeforeParent(this SplitContainer control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static SplitContainer OnDpiChangedAfterParent(this SplitContainer control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static SplitContainer OnMouseHover(this SplitContainer control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static SplitContainer OnMouseMove(this SplitContainer control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static SplitContainer OnMouseUp(this SplitContainer control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static SplitContainer OnMouseWheel(this SplitContainer control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static SplitContainer OnMove(this SplitContainer control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static SplitContainer OnPreviewKeyDown(this SplitContainer control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static SplitContainer OnResize(this SplitContainer control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static SplitContainer OnChangeUICues(this SplitContainer control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static SplitContainer OnStyleChanged(this SplitContainer control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static SplitContainer OnSystemColorsChanged(this SplitContainer control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static SplitContainer OnValidating(this SplitContainer control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static SplitContainer OnValidated(this SplitContainer control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static SplitContainer OnParentChanged(this SplitContainer control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static SplitContainer OnImeModeChanged(this SplitContainer control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static SplitContainer OnDisposed(this SplitContainer control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static SplitContainer AddTo(this SplitContainer control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static SplitContainer AddControls(this SplitContainer control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

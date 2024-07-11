using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ScrollableControlExtensions
    {
        public static ScrollableControl AutoScroll(this ScrollableControl control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ScrollableControl AutoScrollMargin(this ScrollableControl control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ScrollableControl AutoScrollMargin(this ScrollableControl control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static ScrollableControl AutoScrollPosition(this ScrollableControl control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ScrollableControl AutoScrollPosition(this ScrollableControl control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static ScrollableControl AutoScrollMinSize(this ScrollableControl control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ScrollableControl AutoScrollMinSize(this ScrollableControl control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static ScrollableControl AccessibleDefaultActionDescription(this ScrollableControl control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ScrollableControl AccessibleDescription(this ScrollableControl control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ScrollableControl AccessibleName(this ScrollableControl control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ScrollableControl AccessibleRole(this ScrollableControl control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ScrollableControl AllowDrop(this ScrollableControl control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ScrollableControl Anchor(this ScrollableControl control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ScrollableControl AutoSize(this ScrollableControl control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ScrollableControl AutoScrollOffset(this ScrollableControl control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ScrollableControl AutoScrollOffset(this ScrollableControl control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ScrollableControl DataContext(this ScrollableControl control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ScrollableControl BackColor(this ScrollableControl control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ScrollableControl BackColor(this ScrollableControl control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ScrollableControl BackColor(this ScrollableControl control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ScrollableControl BackgroundImage(this ScrollableControl control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ScrollableControl BackgroundImageLayout(this ScrollableControl control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ScrollableControl BindingContext(this ScrollableControl control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ScrollableControl Bounds(this ScrollableControl control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ScrollableControl Bounds(this ScrollableControl control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ScrollableControl Bounds(this ScrollableControl control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ScrollableControl Capture(this ScrollableControl control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ScrollableControl CausesValidation(this ScrollableControl control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ScrollableControl ClientSize(this ScrollableControl control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ScrollableControl ClientSize(this ScrollableControl control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ScrollableControl ContextMenuStrip(this ScrollableControl control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ScrollableControl Cursor(this ScrollableControl control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ScrollableControl Dock(this ScrollableControl control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ScrollableControl Enabled(this ScrollableControl control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ScrollableControl Font(this ScrollableControl control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ScrollableControl Font(this ScrollableControl control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ScrollableControl ForeColor(this ScrollableControl control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ScrollableControl ForeColor(this ScrollableControl control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ScrollableControl ForeColor(this ScrollableControl control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ScrollableControl Height(this ScrollableControl control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ScrollableControl IsAccessible(this ScrollableControl control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ScrollableControl Left(this ScrollableControl control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ScrollableControl Location(this ScrollableControl control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ScrollableControl Location(this ScrollableControl control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ScrollableControl Margin(this ScrollableControl control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ScrollableControl MaximumSize(this ScrollableControl control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ScrollableControl MaximumSize(this ScrollableControl control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ScrollableControl MinimumSize(this ScrollableControl control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ScrollableControl MinimumSize(this ScrollableControl control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ScrollableControl Name(this ScrollableControl control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ScrollableControl Parent(this ScrollableControl control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ScrollableControl Region(this ScrollableControl control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ScrollableControl RightToLeft(this ScrollableControl control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ScrollableControl Size(this ScrollableControl control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ScrollableControl Size(this ScrollableControl control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ScrollableControl TabIndex(this ScrollableControl control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ScrollableControl TabStop(this ScrollableControl control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ScrollableControl Tag(this ScrollableControl control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ScrollableControl Text(this ScrollableControl control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ScrollableControl Top(this ScrollableControl control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ScrollableControl UseWaitCursor(this ScrollableControl control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ScrollableControl Visible(this ScrollableControl control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ScrollableControl Width(this ScrollableControl control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ScrollableControl WindowTarget(this ScrollableControl control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ScrollableControl Padding(this ScrollableControl control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ScrollableControl ImeMode(this ScrollableControl control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ScrollableControl OnScroll(this ScrollableControl control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ScrollableControl OnAutoSizeChanged(this ScrollableControl control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ScrollableControl OnBackColorChanged(this ScrollableControl control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ScrollableControl OnBackgroundImageChanged(this ScrollableControl control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ScrollableControl OnBackgroundImageLayoutChanged(this ScrollableControl control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ScrollableControl OnBindingContextChanged(this ScrollableControl control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ScrollableControl OnCausesValidationChanged(this ScrollableControl control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ScrollableControl OnClientSizeChanged(this ScrollableControl control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ScrollableControl OnContextMenuStripChanged(this ScrollableControl control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ScrollableControl OnCursorChanged(this ScrollableControl control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ScrollableControl OnDockChanged(this ScrollableControl control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ScrollableControl OnEnabledChanged(this ScrollableControl control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ScrollableControl OnFontChanged(this ScrollableControl control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ScrollableControl OnForeColorChanged(this ScrollableControl control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ScrollableControl OnLocationChanged(this ScrollableControl control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ScrollableControl OnMarginChanged(this ScrollableControl control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ScrollableControl OnRegionChanged(this ScrollableControl control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ScrollableControl OnRightToLeftChanged(this ScrollableControl control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ScrollableControl OnSizeChanged(this ScrollableControl control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ScrollableControl OnTabIndexChanged(this ScrollableControl control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ScrollableControl OnTabStopChanged(this ScrollableControl control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ScrollableControl OnTextChanged(this ScrollableControl control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ScrollableControl OnVisibleChanged(this ScrollableControl control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ScrollableControl OnClick(this ScrollableControl control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ScrollableControl OnControlAdded(this ScrollableControl control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ScrollableControl OnControlRemoved(this ScrollableControl control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ScrollableControl OnDataContextChanged(this ScrollableControl control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ScrollableControl OnDragDrop(this ScrollableControl control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ScrollableControl OnDragEnter(this ScrollableControl control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ScrollableControl OnDragOver(this ScrollableControl control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ScrollableControl OnDragLeave(this ScrollableControl control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ScrollableControl OnGiveFeedback(this ScrollableControl control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ScrollableControl OnHandleCreated(this ScrollableControl control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ScrollableControl OnHandleDestroyed(this ScrollableControl control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ScrollableControl OnHelpRequested(this ScrollableControl control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ScrollableControl OnInvalidated(this ScrollableControl control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ScrollableControl OnPaddingChanged(this ScrollableControl control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ScrollableControl OnPaint(this ScrollableControl control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ScrollableControl OnQueryContinueDrag(this ScrollableControl control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ScrollableControl OnQueryAccessibilityHelp(this ScrollableControl control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ScrollableControl OnDoubleClick(this ScrollableControl control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ScrollableControl OnEnter(this ScrollableControl control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ScrollableControl OnGotFocus(this ScrollableControl control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ScrollableControl OnKeyDown(this ScrollableControl control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ScrollableControl OnKeyPress(this ScrollableControl control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ScrollableControl OnKeyUp(this ScrollableControl control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ScrollableControl OnLayout(this ScrollableControl control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ScrollableControl OnLeave(this ScrollableControl control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ScrollableControl OnLostFocus(this ScrollableControl control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ScrollableControl OnMouseClick(this ScrollableControl control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ScrollableControl OnMouseDoubleClick(this ScrollableControl control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ScrollableControl OnMouseCaptureChanged(this ScrollableControl control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ScrollableControl OnMouseDown(this ScrollableControl control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ScrollableControl OnMouseEnter(this ScrollableControl control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ScrollableControl OnMouseLeave(this ScrollableControl control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ScrollableControl OnDpiChangedBeforeParent(this ScrollableControl control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ScrollableControl OnDpiChangedAfterParent(this ScrollableControl control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ScrollableControl OnMouseHover(this ScrollableControl control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ScrollableControl OnMouseMove(this ScrollableControl control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ScrollableControl OnMouseUp(this ScrollableControl control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ScrollableControl OnMouseWheel(this ScrollableControl control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ScrollableControl OnMove(this ScrollableControl control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ScrollableControl OnPreviewKeyDown(this ScrollableControl control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ScrollableControl OnResize(this ScrollableControl control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ScrollableControl OnChangeUICues(this ScrollableControl control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ScrollableControl OnStyleChanged(this ScrollableControl control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ScrollableControl OnSystemColorsChanged(this ScrollableControl control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ScrollableControl OnValidating(this ScrollableControl control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ScrollableControl OnValidated(this ScrollableControl control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ScrollableControl OnParentChanged(this ScrollableControl control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ScrollableControl OnImeModeChanged(this ScrollableControl control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ScrollableControl OnDisposed(this ScrollableControl control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ScrollableControl AddTo(this ScrollableControl control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ScrollableControl Assign(this ScrollableControl control, out ScrollableControl variable)
        {
            variable = control;
            return control;
        }

    }
}

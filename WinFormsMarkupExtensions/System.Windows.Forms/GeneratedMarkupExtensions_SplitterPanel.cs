using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class SplitterPanelExtensions
    {
        public static SplitterPanel AutoSize(this SplitterPanel control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static SplitterPanel AutoSizeMode(this SplitterPanel control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static SplitterPanel Anchor(this SplitterPanel control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static SplitterPanel BorderStyle(this SplitterPanel control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static SplitterPanel Dock(this SplitterPanel control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static SplitterPanel Height(this SplitterPanel control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static SplitterPanel Location(this SplitterPanel control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static SplitterPanel MinimumSize(this SplitterPanel control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static SplitterPanel MaximumSize(this SplitterPanel control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static SplitterPanel Name(this SplitterPanel control, String value)
        {
            control.Name = value;
            return control;
        }

        public static SplitterPanel Parent(this SplitterPanel control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static SplitterPanel Size(this SplitterPanel control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static SplitterPanel TabIndex(this SplitterPanel control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static SplitterPanel TabStop(this SplitterPanel control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static SplitterPanel Visible(this SplitterPanel control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static SplitterPanel Width(this SplitterPanel control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static SplitterPanel Text(this SplitterPanel control, String value)
        {
            control.Text = value;
            return control;
        }

        public static SplitterPanel AutoScroll(this SplitterPanel control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static SplitterPanel AutoScrollMargin(this SplitterPanel control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static SplitterPanel AutoScrollPosition(this SplitterPanel control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static SplitterPanel AutoScrollMinSize(this SplitterPanel control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static SplitterPanel AccessibleDefaultActionDescription(this SplitterPanel control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static SplitterPanel AccessibleDescription(this SplitterPanel control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static SplitterPanel AccessibleName(this SplitterPanel control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static SplitterPanel AccessibleRole(this SplitterPanel control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static SplitterPanel AllowDrop(this SplitterPanel control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static SplitterPanel AutoScrollOffset(this SplitterPanel control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static SplitterPanel DataContext(this SplitterPanel control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static SplitterPanel BackColor(this SplitterPanel control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static SplitterPanel BackgroundImage(this SplitterPanel control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static SplitterPanel BackgroundImageLayout(this SplitterPanel control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static SplitterPanel BindingContext(this SplitterPanel control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static SplitterPanel Bounds(this SplitterPanel control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static SplitterPanel Capture(this SplitterPanel control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static SplitterPanel CausesValidation(this SplitterPanel control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static SplitterPanel ClientSize(this SplitterPanel control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static SplitterPanel ContextMenuStrip(this SplitterPanel control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static SplitterPanel Cursor(this SplitterPanel control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static SplitterPanel Enabled(this SplitterPanel control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static SplitterPanel Font(this SplitterPanel control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static SplitterPanel ForeColor(this SplitterPanel control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static SplitterPanel IsAccessible(this SplitterPanel control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static SplitterPanel Left(this SplitterPanel control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static SplitterPanel Margin(this SplitterPanel control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static SplitterPanel Region(this SplitterPanel control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static SplitterPanel RightToLeft(this SplitterPanel control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static SplitterPanel Tag(this SplitterPanel control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static SplitterPanel Top(this SplitterPanel control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static SplitterPanel UseWaitCursor(this SplitterPanel control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static SplitterPanel WindowTarget(this SplitterPanel control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static SplitterPanel Padding(this SplitterPanel control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static SplitterPanel ImeMode(this SplitterPanel control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static SplitterPanel OnAutoSizeChanged(this SplitterPanel control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static SplitterPanel OnVisibleChanged(this SplitterPanel control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static SplitterPanel OnDockChanged(this SplitterPanel control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static SplitterPanel OnLocationChanged(this SplitterPanel control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static SplitterPanel OnTabIndexChanged(this SplitterPanel control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static SplitterPanel OnTabStopChanged(this SplitterPanel control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static SplitterPanel OnKeyUp(this SplitterPanel control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static SplitterPanel OnKeyDown(this SplitterPanel control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static SplitterPanel OnKeyPress(this SplitterPanel control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static SplitterPanel OnTextChanged(this SplitterPanel control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static SplitterPanel OnScroll(this SplitterPanel control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static SplitterPanel OnBackColorChanged(this SplitterPanel control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static SplitterPanel OnBackgroundImageChanged(this SplitterPanel control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static SplitterPanel OnBackgroundImageLayoutChanged(this SplitterPanel control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static SplitterPanel OnBindingContextChanged(this SplitterPanel control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static SplitterPanel OnCausesValidationChanged(this SplitterPanel control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static SplitterPanel OnClientSizeChanged(this SplitterPanel control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static SplitterPanel OnContextMenuStripChanged(this SplitterPanel control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static SplitterPanel OnCursorChanged(this SplitterPanel control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static SplitterPanel OnEnabledChanged(this SplitterPanel control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static SplitterPanel OnFontChanged(this SplitterPanel control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static SplitterPanel OnForeColorChanged(this SplitterPanel control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static SplitterPanel OnMarginChanged(this SplitterPanel control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static SplitterPanel OnRegionChanged(this SplitterPanel control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static SplitterPanel OnRightToLeftChanged(this SplitterPanel control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static SplitterPanel OnSizeChanged(this SplitterPanel control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static SplitterPanel OnClick(this SplitterPanel control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static SplitterPanel OnControlAdded(this SplitterPanel control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static SplitterPanel OnControlRemoved(this SplitterPanel control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static SplitterPanel OnDataContextChanged(this SplitterPanel control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static SplitterPanel OnDragDrop(this SplitterPanel control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static SplitterPanel OnDragEnter(this SplitterPanel control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static SplitterPanel OnDragOver(this SplitterPanel control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static SplitterPanel OnDragLeave(this SplitterPanel control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static SplitterPanel OnGiveFeedback(this SplitterPanel control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static SplitterPanel OnHandleCreated(this SplitterPanel control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static SplitterPanel OnHandleDestroyed(this SplitterPanel control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static SplitterPanel OnHelpRequested(this SplitterPanel control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static SplitterPanel OnInvalidated(this SplitterPanel control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static SplitterPanel OnPaddingChanged(this SplitterPanel control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static SplitterPanel OnPaint(this SplitterPanel control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static SplitterPanel OnQueryContinueDrag(this SplitterPanel control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static SplitterPanel OnQueryAccessibilityHelp(this SplitterPanel control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static SplitterPanel OnDoubleClick(this SplitterPanel control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static SplitterPanel OnEnter(this SplitterPanel control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static SplitterPanel OnGotFocus(this SplitterPanel control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static SplitterPanel OnLayout(this SplitterPanel control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static SplitterPanel OnLeave(this SplitterPanel control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static SplitterPanel OnLostFocus(this SplitterPanel control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static SplitterPanel OnMouseClick(this SplitterPanel control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static SplitterPanel OnMouseDoubleClick(this SplitterPanel control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static SplitterPanel OnMouseCaptureChanged(this SplitterPanel control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static SplitterPanel OnMouseDown(this SplitterPanel control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static SplitterPanel OnMouseEnter(this SplitterPanel control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static SplitterPanel OnMouseLeave(this SplitterPanel control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static SplitterPanel OnDpiChangedBeforeParent(this SplitterPanel control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static SplitterPanel OnDpiChangedAfterParent(this SplitterPanel control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static SplitterPanel OnMouseHover(this SplitterPanel control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static SplitterPanel OnMouseMove(this SplitterPanel control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static SplitterPanel OnMouseUp(this SplitterPanel control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static SplitterPanel OnMouseWheel(this SplitterPanel control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static SplitterPanel OnMove(this SplitterPanel control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static SplitterPanel OnPreviewKeyDown(this SplitterPanel control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static SplitterPanel OnResize(this SplitterPanel control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static SplitterPanel OnChangeUICues(this SplitterPanel control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static SplitterPanel OnStyleChanged(this SplitterPanel control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static SplitterPanel OnSystemColorsChanged(this SplitterPanel control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static SplitterPanel OnValidating(this SplitterPanel control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static SplitterPanel OnValidated(this SplitterPanel control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static SplitterPanel OnParentChanged(this SplitterPanel control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static SplitterPanel OnImeModeChanged(this SplitterPanel control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static SplitterPanel OnDisposed(this SplitterPanel control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static SplitterPanel AddTo(this SplitterPanel control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

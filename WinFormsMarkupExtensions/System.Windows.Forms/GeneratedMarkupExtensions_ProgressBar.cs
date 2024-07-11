using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ProgressBarExtensions
    {
        public static ProgressBar AllowDrop(this ProgressBar control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ProgressBar BackgroundImage(this ProgressBar control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ProgressBar Style(this ProgressBar control, ProgressBarStyle value)
        {
            control.Style = value;
            return control;
        }

        public static ProgressBar BackgroundImageLayout(this ProgressBar control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ProgressBar CausesValidation(this ProgressBar control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ProgressBar Font(this ProgressBar control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ProgressBar Font(this ProgressBar control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ProgressBar ImeMode(this ProgressBar control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ProgressBar MarqueeAnimationSpeed(this ProgressBar control, Int32 value)
        {
            control.MarqueeAnimationSpeed = value;
            return control;
        }

        public static ProgressBar Maximum(this ProgressBar control, Int32 value)
        {
            control.Maximum = value;
            return control;
        }

        public static ProgressBar Minimum(this ProgressBar control, Int32 value)
        {
            control.Minimum = value;
            return control;
        }

        public static ProgressBar Padding(this ProgressBar control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ProgressBar RightToLeftLayout(this ProgressBar control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static ProgressBar Step(this ProgressBar control, Int32 value)
        {
            control.Step = value;
            return control;
        }

        public static ProgressBar TabStop(this ProgressBar control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ProgressBar Text(this ProgressBar control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ProgressBar Value(this ProgressBar control, Int32 value)
        {
            control.Value = value;
            return control;
        }

        public static ProgressBar AccessibleDefaultActionDescription(this ProgressBar control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ProgressBar AccessibleDescription(this ProgressBar control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ProgressBar AccessibleName(this ProgressBar control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ProgressBar AccessibleRole(this ProgressBar control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ProgressBar Anchor(this ProgressBar control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ProgressBar AutoSize(this ProgressBar control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ProgressBar AutoScrollOffset(this ProgressBar control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ProgressBar AutoScrollOffset(this ProgressBar control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ProgressBar DataContext(this ProgressBar control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ProgressBar BackColor(this ProgressBar control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ProgressBar BackColor(this ProgressBar control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ProgressBar BackColor(this ProgressBar control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ProgressBar BindingContext(this ProgressBar control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ProgressBar Bounds(this ProgressBar control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ProgressBar Bounds(this ProgressBar control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ProgressBar Bounds(this ProgressBar control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ProgressBar Capture(this ProgressBar control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ProgressBar ClientSize(this ProgressBar control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ProgressBar ClientSize(this ProgressBar control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ProgressBar ContextMenuStrip(this ProgressBar control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ProgressBar Cursor(this ProgressBar control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ProgressBar Dock(this ProgressBar control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ProgressBar Enabled(this ProgressBar control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ProgressBar ForeColor(this ProgressBar control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ProgressBar ForeColor(this ProgressBar control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ProgressBar ForeColor(this ProgressBar control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ProgressBar Height(this ProgressBar control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ProgressBar IsAccessible(this ProgressBar control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ProgressBar Left(this ProgressBar control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ProgressBar Location(this ProgressBar control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ProgressBar Location(this ProgressBar control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ProgressBar Margin(this ProgressBar control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ProgressBar MaximumSize(this ProgressBar control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ProgressBar MaximumSize(this ProgressBar control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ProgressBar MinimumSize(this ProgressBar control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ProgressBar MinimumSize(this ProgressBar control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ProgressBar Name(this ProgressBar control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ProgressBar Parent(this ProgressBar control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ProgressBar Region(this ProgressBar control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ProgressBar RightToLeft(this ProgressBar control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ProgressBar Size(this ProgressBar control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ProgressBar Size(this ProgressBar control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ProgressBar TabIndex(this ProgressBar control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ProgressBar Tag(this ProgressBar control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ProgressBar Top(this ProgressBar control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ProgressBar UseWaitCursor(this ProgressBar control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ProgressBar Visible(this ProgressBar control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ProgressBar Width(this ProgressBar control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ProgressBar WindowTarget(this ProgressBar control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ProgressBar OnBackgroundImageChanged(this ProgressBar control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ProgressBar OnBackgroundImageLayoutChanged(this ProgressBar control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ProgressBar OnCausesValidationChanged(this ProgressBar control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ProgressBar OnFontChanged(this ProgressBar control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ProgressBar OnImeModeChanged(this ProgressBar control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ProgressBar OnPaddingChanged(this ProgressBar control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ProgressBar OnRightToLeftLayoutChanged(this ProgressBar control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static ProgressBar OnTabStopChanged(this ProgressBar control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ProgressBar OnTextChanged(this ProgressBar control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ProgressBar OnDoubleClick(this ProgressBar control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ProgressBar OnMouseDoubleClick(this ProgressBar control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ProgressBar OnKeyUp(this ProgressBar control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ProgressBar OnKeyDown(this ProgressBar control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ProgressBar OnKeyPress(this ProgressBar control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ProgressBar OnEnter(this ProgressBar control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ProgressBar OnLeave(this ProgressBar control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ProgressBar OnPaint(this ProgressBar control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ProgressBar OnAutoSizeChanged(this ProgressBar control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ProgressBar OnBackColorChanged(this ProgressBar control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ProgressBar OnBindingContextChanged(this ProgressBar control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ProgressBar OnClientSizeChanged(this ProgressBar control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ProgressBar OnContextMenuStripChanged(this ProgressBar control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ProgressBar OnCursorChanged(this ProgressBar control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ProgressBar OnDockChanged(this ProgressBar control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ProgressBar OnEnabledChanged(this ProgressBar control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ProgressBar OnForeColorChanged(this ProgressBar control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ProgressBar OnLocationChanged(this ProgressBar control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ProgressBar OnMarginChanged(this ProgressBar control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ProgressBar OnRegionChanged(this ProgressBar control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ProgressBar OnRightToLeftChanged(this ProgressBar control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ProgressBar OnSizeChanged(this ProgressBar control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ProgressBar OnTabIndexChanged(this ProgressBar control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ProgressBar OnVisibleChanged(this ProgressBar control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ProgressBar OnClick(this ProgressBar control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ProgressBar OnControlAdded(this ProgressBar control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ProgressBar OnControlRemoved(this ProgressBar control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ProgressBar OnDataContextChanged(this ProgressBar control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ProgressBar OnDragDrop(this ProgressBar control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ProgressBar OnDragEnter(this ProgressBar control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ProgressBar OnDragOver(this ProgressBar control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ProgressBar OnDragLeave(this ProgressBar control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ProgressBar OnGiveFeedback(this ProgressBar control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ProgressBar OnHandleCreated(this ProgressBar control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ProgressBar OnHandleDestroyed(this ProgressBar control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ProgressBar OnHelpRequested(this ProgressBar control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ProgressBar OnInvalidated(this ProgressBar control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ProgressBar OnQueryContinueDrag(this ProgressBar control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ProgressBar OnQueryAccessibilityHelp(this ProgressBar control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ProgressBar OnGotFocus(this ProgressBar control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ProgressBar OnLayout(this ProgressBar control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ProgressBar OnLostFocus(this ProgressBar control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ProgressBar OnMouseClick(this ProgressBar control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ProgressBar OnMouseCaptureChanged(this ProgressBar control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ProgressBar OnMouseDown(this ProgressBar control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ProgressBar OnMouseEnter(this ProgressBar control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ProgressBar OnMouseLeave(this ProgressBar control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ProgressBar OnDpiChangedBeforeParent(this ProgressBar control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ProgressBar OnDpiChangedAfterParent(this ProgressBar control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ProgressBar OnMouseHover(this ProgressBar control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ProgressBar OnMouseMove(this ProgressBar control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ProgressBar OnMouseUp(this ProgressBar control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ProgressBar OnMouseWheel(this ProgressBar control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ProgressBar OnMove(this ProgressBar control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ProgressBar OnPreviewKeyDown(this ProgressBar control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ProgressBar OnResize(this ProgressBar control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ProgressBar OnChangeUICues(this ProgressBar control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ProgressBar OnStyleChanged(this ProgressBar control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ProgressBar OnSystemColorsChanged(this ProgressBar control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ProgressBar OnValidating(this ProgressBar control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ProgressBar OnValidated(this ProgressBar control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ProgressBar OnParentChanged(this ProgressBar control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ProgressBar OnDisposed(this ProgressBar control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ProgressBar AddTo(this ProgressBar control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ProgressBar Assign(this ProgressBar control, out ProgressBar variable)
        {
            variable = control;
            return control;
        }

    }
}

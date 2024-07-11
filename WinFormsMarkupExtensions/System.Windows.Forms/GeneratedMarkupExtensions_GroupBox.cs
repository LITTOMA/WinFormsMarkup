using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class GroupBoxExtensions
    {
        public static GroupBox AllowDrop(this GroupBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static GroupBox AutoSize(this GroupBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static GroupBox AutoSizeMode(this GroupBox control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static GroupBox FlatStyle(this GroupBox control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static GroupBox TabStop(this GroupBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static GroupBox Text(this GroupBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static GroupBox UseCompatibleTextRendering(this GroupBox control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static GroupBox AccessibleDefaultActionDescription(this GroupBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static GroupBox AccessibleDescription(this GroupBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static GroupBox AccessibleName(this GroupBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static GroupBox AccessibleRole(this GroupBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static GroupBox Anchor(this GroupBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static GroupBox AutoScrollOffset(this GroupBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static GroupBox AutoScrollOffset(this GroupBox control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static GroupBox DataContext(this GroupBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static GroupBox BackColor(this GroupBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static GroupBox BackColor(this GroupBox control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static GroupBox BackColor(this GroupBox control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static GroupBox BackgroundImage(this GroupBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static GroupBox BackgroundImageLayout(this GroupBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static GroupBox BindingContext(this GroupBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static GroupBox Bounds(this GroupBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static GroupBox Bounds(this GroupBox control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static GroupBox Bounds(this GroupBox control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static GroupBox Capture(this GroupBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static GroupBox CausesValidation(this GroupBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static GroupBox ClientSize(this GroupBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static GroupBox ClientSize(this GroupBox control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static GroupBox ContextMenuStrip(this GroupBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static GroupBox Cursor(this GroupBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static GroupBox Dock(this GroupBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static GroupBox Enabled(this GroupBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static GroupBox Font(this GroupBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static GroupBox Font(this GroupBox control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static GroupBox ForeColor(this GroupBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static GroupBox ForeColor(this GroupBox control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static GroupBox ForeColor(this GroupBox control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static GroupBox Height(this GroupBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static GroupBox IsAccessible(this GroupBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static GroupBox Left(this GroupBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static GroupBox Location(this GroupBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static GroupBox Location(this GroupBox control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static GroupBox Margin(this GroupBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static GroupBox MaximumSize(this GroupBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static GroupBox MaximumSize(this GroupBox control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static GroupBox MinimumSize(this GroupBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static GroupBox MinimumSize(this GroupBox control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static GroupBox Name(this GroupBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static GroupBox Parent(this GroupBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static GroupBox Region(this GroupBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static GroupBox RightToLeft(this GroupBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static GroupBox Size(this GroupBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static GroupBox Size(this GroupBox control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static GroupBox TabIndex(this GroupBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static GroupBox Tag(this GroupBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static GroupBox Top(this GroupBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static GroupBox UseWaitCursor(this GroupBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static GroupBox Visible(this GroupBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static GroupBox Width(this GroupBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static GroupBox WindowTarget(this GroupBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static GroupBox Padding(this GroupBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static GroupBox ImeMode(this GroupBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static GroupBox OnAutoSizeChanged(this GroupBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static GroupBox OnTabStopChanged(this GroupBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static GroupBox OnClick(this GroupBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static GroupBox OnMouseClick(this GroupBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static GroupBox OnDoubleClick(this GroupBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static GroupBox OnMouseDoubleClick(this GroupBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static GroupBox OnKeyUp(this GroupBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static GroupBox OnKeyDown(this GroupBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static GroupBox OnKeyPress(this GroupBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static GroupBox OnMouseDown(this GroupBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static GroupBox OnMouseUp(this GroupBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static GroupBox OnMouseMove(this GroupBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static GroupBox OnMouseEnter(this GroupBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static GroupBox OnMouseLeave(this GroupBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static GroupBox OnBackColorChanged(this GroupBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static GroupBox OnBackgroundImageChanged(this GroupBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static GroupBox OnBackgroundImageLayoutChanged(this GroupBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static GroupBox OnBindingContextChanged(this GroupBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static GroupBox OnCausesValidationChanged(this GroupBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static GroupBox OnClientSizeChanged(this GroupBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static GroupBox OnContextMenuStripChanged(this GroupBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static GroupBox OnCursorChanged(this GroupBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static GroupBox OnDockChanged(this GroupBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static GroupBox OnEnabledChanged(this GroupBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static GroupBox OnFontChanged(this GroupBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static GroupBox OnForeColorChanged(this GroupBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static GroupBox OnLocationChanged(this GroupBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static GroupBox OnMarginChanged(this GroupBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static GroupBox OnRegionChanged(this GroupBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static GroupBox OnRightToLeftChanged(this GroupBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static GroupBox OnSizeChanged(this GroupBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static GroupBox OnTabIndexChanged(this GroupBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static GroupBox OnTextChanged(this GroupBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static GroupBox OnVisibleChanged(this GroupBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static GroupBox OnControlAdded(this GroupBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static GroupBox OnControlRemoved(this GroupBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static GroupBox OnDataContextChanged(this GroupBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static GroupBox OnDragDrop(this GroupBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static GroupBox OnDragEnter(this GroupBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static GroupBox OnDragOver(this GroupBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static GroupBox OnDragLeave(this GroupBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static GroupBox OnGiveFeedback(this GroupBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static GroupBox OnHandleCreated(this GroupBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static GroupBox OnHandleDestroyed(this GroupBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static GroupBox OnHelpRequested(this GroupBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static GroupBox OnInvalidated(this GroupBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static GroupBox OnPaddingChanged(this GroupBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static GroupBox OnPaint(this GroupBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static GroupBox OnQueryContinueDrag(this GroupBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static GroupBox OnQueryAccessibilityHelp(this GroupBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static GroupBox OnEnter(this GroupBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static GroupBox OnGotFocus(this GroupBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static GroupBox OnLayout(this GroupBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static GroupBox OnLeave(this GroupBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static GroupBox OnLostFocus(this GroupBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static GroupBox OnMouseCaptureChanged(this GroupBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static GroupBox OnDpiChangedBeforeParent(this GroupBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static GroupBox OnDpiChangedAfterParent(this GroupBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static GroupBox OnMouseHover(this GroupBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static GroupBox OnMouseWheel(this GroupBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static GroupBox OnMove(this GroupBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static GroupBox OnPreviewKeyDown(this GroupBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static GroupBox OnResize(this GroupBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static GroupBox OnChangeUICues(this GroupBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static GroupBox OnStyleChanged(this GroupBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static GroupBox OnSystemColorsChanged(this GroupBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static GroupBox OnValidating(this GroupBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static GroupBox OnValidated(this GroupBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static GroupBox OnParentChanged(this GroupBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static GroupBox OnImeModeChanged(this GroupBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static GroupBox OnDisposed(this GroupBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static GroupBox AddTo(this GroupBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static GroupBox Assign(this GroupBox control, out GroupBox variable)
        {
            variable = control;
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ControlExtensions
    {
        public static Control AccessibleDefaultActionDescription(this Control control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static Control AccessibleDescription(this Control control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static Control AccessibleName(this Control control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static Control AccessibleRole(this Control control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static Control AllowDrop(this Control control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static Control Anchor(this Control control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static Control AutoSize(this Control control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static Control AutoScrollOffset(this Control control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static Control AutoScrollOffset(this Control control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static Control DataContext(this Control control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static Control BackColor(this Control control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Control BackColor(this Control control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Control BackColor(this Control control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static Control BackgroundImage(this Control control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static Control BackgroundImageLayout(this Control control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static Control BindingContext(this Control control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static Control Bounds(this Control control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static Control Bounds(this Control control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static Control Bounds(this Control control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static Control Capture(this Control control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static Control CausesValidation(this Control control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static Control ClientSize(this Control control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static Control ClientSize(this Control control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static Control ContextMenuStrip(this Control control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static Control Cursor(this Control control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static Control Dock(this Control control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static Control Enabled(this Control control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static Control Font(this Control control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static Control Font(this Control control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static Control ForeColor(this Control control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Control ForeColor(this Control control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Control ForeColor(this Control control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static Control Height(this Control control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static Control IsAccessible(this Control control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static Control Left(this Control control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static Control Location(this Control control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static Control Location(this Control control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static Control Margin(this Control control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static Control MaximumSize(this Control control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static Control MaximumSize(this Control control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static Control MinimumSize(this Control control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static Control MinimumSize(this Control control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static Control Name(this Control control, String value)
        {
            control.Name = value;
            return control;
        }

        public static Control Parent(this Control control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static Control Region(this Control control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static Control RightToLeft(this Control control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static Control Size(this Control control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static Control Size(this Control control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static Control TabIndex(this Control control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static Control TabStop(this Control control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static Control Tag(this Control control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static Control Text(this Control control, String value)
        {
            control.Text = value;
            return control;
        }

        public static Control Top(this Control control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static Control UseWaitCursor(this Control control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static Control Visible(this Control control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static Control Width(this Control control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static Control WindowTarget(this Control control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static Control Padding(this Control control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static Control ImeMode(this Control control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static Control OnAutoSizeChanged(this Control control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static Control OnBackColorChanged(this Control control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static Control OnBackgroundImageChanged(this Control control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static Control OnBackgroundImageLayoutChanged(this Control control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static Control OnBindingContextChanged(this Control control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static Control OnCausesValidationChanged(this Control control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static Control OnClientSizeChanged(this Control control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static Control OnContextMenuStripChanged(this Control control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static Control OnCursorChanged(this Control control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static Control OnDockChanged(this Control control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static Control OnEnabledChanged(this Control control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static Control OnFontChanged(this Control control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static Control OnForeColorChanged(this Control control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static Control OnLocationChanged(this Control control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static Control OnMarginChanged(this Control control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static Control OnRegionChanged(this Control control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static Control OnRightToLeftChanged(this Control control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static Control OnSizeChanged(this Control control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static Control OnTabIndexChanged(this Control control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static Control OnTabStopChanged(this Control control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static Control OnTextChanged(this Control control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static Control OnVisibleChanged(this Control control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static Control OnClick(this Control control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static Control OnControlAdded(this Control control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static Control OnControlRemoved(this Control control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static Control OnDataContextChanged(this Control control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static Control OnDragDrop(this Control control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static Control OnDragEnter(this Control control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static Control OnDragOver(this Control control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static Control OnDragLeave(this Control control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static Control OnGiveFeedback(this Control control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static Control OnHandleCreated(this Control control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static Control OnHandleDestroyed(this Control control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static Control OnHelpRequested(this Control control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static Control OnInvalidated(this Control control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static Control OnPaddingChanged(this Control control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static Control OnPaint(this Control control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static Control OnQueryContinueDrag(this Control control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static Control OnQueryAccessibilityHelp(this Control control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static Control OnDoubleClick(this Control control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static Control OnEnter(this Control control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static Control OnGotFocus(this Control control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static Control OnKeyDown(this Control control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static Control OnKeyPress(this Control control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static Control OnKeyUp(this Control control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static Control OnLayout(this Control control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static Control OnLeave(this Control control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static Control OnLostFocus(this Control control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static Control OnMouseClick(this Control control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static Control OnMouseDoubleClick(this Control control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static Control OnMouseCaptureChanged(this Control control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static Control OnMouseDown(this Control control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static Control OnMouseEnter(this Control control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static Control OnMouseLeave(this Control control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static Control OnDpiChangedBeforeParent(this Control control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static Control OnDpiChangedAfterParent(this Control control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static Control OnMouseHover(this Control control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static Control OnMouseMove(this Control control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static Control OnMouseUp(this Control control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static Control OnMouseWheel(this Control control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static Control OnMove(this Control control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static Control OnPreviewKeyDown(this Control control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static Control OnResize(this Control control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static Control OnChangeUICues(this Control control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static Control OnStyleChanged(this Control control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static Control OnSystemColorsChanged(this Control control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static Control OnValidating(this Control control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static Control OnValidated(this Control control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static Control OnParentChanged(this Control control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static Control OnImeModeChanged(this Control control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static Control OnDisposed(this Control control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static Control AddTo(this Control control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static Control Assign(this Control control, out Control variable)
        {
            variable = control;
            return control;
        }

    }
}

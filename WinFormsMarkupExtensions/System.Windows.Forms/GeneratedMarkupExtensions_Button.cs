using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Input;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ButtonExtensions
    {
        public static Button AutoSizeMode(this Button control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static Button DialogResult(this Button control, DialogResult value)
        {
            control.DialogResult = value;
            return control;
        }

        public static Button AutoEllipsis(this Button control, Boolean value)
        {
            control.AutoEllipsis = value;
            return control;
        }

        public static Button AutoSize(this Button control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static Button BackColor(this Button control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Button BackColor(this Button control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Button BackColor(this Button control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static Button Command(this Button control, ICommand value)
        {
            control.Command = value;
            return control;
        }

        public static Button CommandParameter(this Button control, Object value)
        {
            control.CommandParameter = value;
            return control;
        }

        public static Button FlatStyle(this Button control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static Button Image(this Button control, Image value)
        {
            control.Image = value;
            return control;
        }

        public static Button ImageAlign(this Button control, ContentAlignment value)
        {
            control.ImageAlign = value;
            return control;
        }

        public static Button ImageIndex(this Button control, Int32 value)
        {
            control.ImageIndex = value;
            return control;
        }

        public static Button ImageKey(this Button control, String value)
        {
            control.ImageKey = value;
            return control;
        }

        public static Button ImageList(this Button control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static Button ImeMode(this Button control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static Button Text(this Button control, String value)
        {
            control.Text = value;
            return control;
        }

        public static Button TextAlign(this Button control, ContentAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static Button TextImageRelation(this Button control, TextImageRelation value)
        {
            control.TextImageRelation = value;
            return control;
        }

        public static Button UseMnemonic(this Button control, Boolean value)
        {
            control.UseMnemonic = value;
            return control;
        }

        public static Button UseCompatibleTextRendering(this Button control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static Button UseVisualStyleBackColor(this Button control, Boolean value)
        {
            control.UseVisualStyleBackColor = value;
            return control;
        }

        public static Button AccessibleDefaultActionDescription(this Button control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static Button AccessibleDescription(this Button control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static Button AccessibleName(this Button control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static Button AccessibleRole(this Button control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static Button AllowDrop(this Button control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static Button Anchor(this Button control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static Button AutoScrollOffset(this Button control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static Button AutoScrollOffset(this Button control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static Button DataContext(this Button control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static Button BackgroundImage(this Button control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static Button BackgroundImageLayout(this Button control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static Button BindingContext(this Button control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static Button Bounds(this Button control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static Button Bounds(this Button control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static Button Bounds(this Button control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static Button Capture(this Button control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static Button CausesValidation(this Button control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static Button ClientSize(this Button control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static Button ClientSize(this Button control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static Button ContextMenuStrip(this Button control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static Button Cursor(this Button control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static Button Dock(this Button control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static Button Enabled(this Button control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static Button Font(this Button control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static Button Font(this Button control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static Button ForeColor(this Button control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Button ForeColor(this Button control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Button ForeColor(this Button control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static Button Height(this Button control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static Button IsAccessible(this Button control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static Button Left(this Button control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static Button Location(this Button control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static Button Location(this Button control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static Button Margin(this Button control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static Button MaximumSize(this Button control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static Button MaximumSize(this Button control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static Button MinimumSize(this Button control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static Button MinimumSize(this Button control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static Button Name(this Button control, String value)
        {
            control.Name = value;
            return control;
        }

        public static Button Parent(this Button control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static Button Region(this Button control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static Button RightToLeft(this Button control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static Button Size(this Button control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static Button Size(this Button control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static Button TabIndex(this Button control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static Button TabStop(this Button control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static Button Tag(this Button control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static Button Top(this Button control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static Button UseWaitCursor(this Button control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static Button Visible(this Button control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static Button Width(this Button control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static Button WindowTarget(this Button control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static Button Padding(this Button control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static Button OnDoubleClick(this Button control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static Button OnMouseDoubleClick(this Button control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static Button OnAutoSizeChanged(this Button control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static Button OnCommandCanExecuteChanged(this Button control, EventHandler handler)
        {
            control.CommandCanExecuteChanged += handler;
            return control;
        }

        public static Button OnCommandChanged(this Button control, EventHandler handler)
        {
            control.CommandChanged += handler;
            return control;
        }

        public static Button OnCommandParameterChanged(this Button control, EventHandler handler)
        {
            control.CommandParameterChanged += handler;
            return control;
        }

        public static Button OnImeModeChanged(this Button control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static Button OnBackColorChanged(this Button control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static Button OnBackgroundImageChanged(this Button control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static Button OnBackgroundImageLayoutChanged(this Button control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static Button OnBindingContextChanged(this Button control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static Button OnCausesValidationChanged(this Button control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static Button OnClientSizeChanged(this Button control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static Button OnContextMenuStripChanged(this Button control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static Button OnCursorChanged(this Button control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static Button OnDockChanged(this Button control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static Button OnEnabledChanged(this Button control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static Button OnFontChanged(this Button control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static Button OnForeColorChanged(this Button control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static Button OnLocationChanged(this Button control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static Button OnMarginChanged(this Button control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static Button OnRegionChanged(this Button control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static Button OnRightToLeftChanged(this Button control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static Button OnSizeChanged(this Button control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static Button OnTabIndexChanged(this Button control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static Button OnTabStopChanged(this Button control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static Button OnTextChanged(this Button control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static Button OnVisibleChanged(this Button control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static Button OnClick(this Button control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static Button OnControlAdded(this Button control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static Button OnControlRemoved(this Button control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static Button OnDataContextChanged(this Button control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static Button OnDragDrop(this Button control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static Button OnDragEnter(this Button control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static Button OnDragOver(this Button control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static Button OnDragLeave(this Button control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static Button OnGiveFeedback(this Button control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static Button OnHandleCreated(this Button control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static Button OnHandleDestroyed(this Button control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static Button OnHelpRequested(this Button control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static Button OnInvalidated(this Button control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static Button OnPaddingChanged(this Button control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static Button OnPaint(this Button control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static Button OnQueryContinueDrag(this Button control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static Button OnQueryAccessibilityHelp(this Button control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static Button OnEnter(this Button control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static Button OnGotFocus(this Button control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static Button OnKeyDown(this Button control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static Button OnKeyPress(this Button control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static Button OnKeyUp(this Button control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static Button OnLayout(this Button control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static Button OnLeave(this Button control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static Button OnLostFocus(this Button control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static Button OnMouseClick(this Button control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static Button OnMouseCaptureChanged(this Button control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static Button OnMouseDown(this Button control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static Button OnMouseEnter(this Button control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static Button OnMouseLeave(this Button control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static Button OnDpiChangedBeforeParent(this Button control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static Button OnDpiChangedAfterParent(this Button control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static Button OnMouseHover(this Button control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static Button OnMouseMove(this Button control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static Button OnMouseUp(this Button control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static Button OnMouseWheel(this Button control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static Button OnMove(this Button control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static Button OnPreviewKeyDown(this Button control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static Button OnResize(this Button control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static Button OnChangeUICues(this Button control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static Button OnStyleChanged(this Button control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static Button OnSystemColorsChanged(this Button control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static Button OnValidating(this Button control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static Button OnValidated(this Button control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static Button OnParentChanged(this Button control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static Button OnDisposed(this Button control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static Button AddTo(this Button control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static Button Assign(this Button control, out Button variable)
        {
            variable = control;
            return control;
        }

    }
}

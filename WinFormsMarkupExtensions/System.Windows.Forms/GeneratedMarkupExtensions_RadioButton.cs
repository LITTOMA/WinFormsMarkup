using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Input;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class RadioButtonExtensions
    {
        public static RadioButton AutoCheck(this RadioButton control, Boolean value)
        {
            control.AutoCheck = value;
            return control;
        }

        public static RadioButton Appearance(this RadioButton control, Appearance value)
        {
            control.Appearance = value;
            return control;
        }

        public static RadioButton CheckAlign(this RadioButton control, ContentAlignment value)
        {
            control.CheckAlign = value;
            return control;
        }

        public static RadioButton Checked(this RadioButton control, Boolean value)
        {
            control.Checked = value;
            return control;
        }

        public static RadioButton TabStop(this RadioButton control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static RadioButton TextAlign(this RadioButton control, ContentAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static RadioButton AutoEllipsis(this RadioButton control, Boolean value)
        {
            control.AutoEllipsis = value;
            return control;
        }

        public static RadioButton AutoSize(this RadioButton control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static RadioButton BackColor(this RadioButton control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static RadioButton BackColor(this RadioButton control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static RadioButton BackColor(this RadioButton control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static RadioButton Command(this RadioButton control, ICommand value)
        {
            control.Command = value;
            return control;
        }

        public static RadioButton CommandParameter(this RadioButton control, Object value)
        {
            control.CommandParameter = value;
            return control;
        }

        public static RadioButton FlatStyle(this RadioButton control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static RadioButton Image(this RadioButton control, Image value)
        {
            control.Image = value;
            return control;
        }

        public static RadioButton ImageAlign(this RadioButton control, ContentAlignment value)
        {
            control.ImageAlign = value;
            return control;
        }

        public static RadioButton ImageIndex(this RadioButton control, Int32 value)
        {
            control.ImageIndex = value;
            return control;
        }

        public static RadioButton ImageKey(this RadioButton control, String value)
        {
            control.ImageKey = value;
            return control;
        }

        public static RadioButton ImageList(this RadioButton control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static RadioButton ImeMode(this RadioButton control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static RadioButton Text(this RadioButton control, String value)
        {
            control.Text = value;
            return control;
        }

        public static RadioButton TextImageRelation(this RadioButton control, TextImageRelation value)
        {
            control.TextImageRelation = value;
            return control;
        }

        public static RadioButton UseMnemonic(this RadioButton control, Boolean value)
        {
            control.UseMnemonic = value;
            return control;
        }

        public static RadioButton UseCompatibleTextRendering(this RadioButton control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static RadioButton UseVisualStyleBackColor(this RadioButton control, Boolean value)
        {
            control.UseVisualStyleBackColor = value;
            return control;
        }

        public static RadioButton AccessibleDefaultActionDescription(this RadioButton control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static RadioButton AccessibleDescription(this RadioButton control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static RadioButton AccessibleName(this RadioButton control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static RadioButton AccessibleRole(this RadioButton control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static RadioButton AllowDrop(this RadioButton control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static RadioButton Anchor(this RadioButton control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static RadioButton AutoScrollOffset(this RadioButton control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static RadioButton AutoScrollOffset(this RadioButton control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static RadioButton DataContext(this RadioButton control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static RadioButton BackgroundImage(this RadioButton control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static RadioButton BackgroundImageLayout(this RadioButton control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static RadioButton BindingContext(this RadioButton control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static RadioButton Bounds(this RadioButton control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static RadioButton Bounds(this RadioButton control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static RadioButton Bounds(this RadioButton control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static RadioButton Capture(this RadioButton control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static RadioButton CausesValidation(this RadioButton control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static RadioButton ClientSize(this RadioButton control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static RadioButton ClientSize(this RadioButton control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static RadioButton ContextMenuStrip(this RadioButton control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static RadioButton Cursor(this RadioButton control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static RadioButton Dock(this RadioButton control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static RadioButton Enabled(this RadioButton control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static RadioButton Font(this RadioButton control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static RadioButton Font(this RadioButton control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static RadioButton ForeColor(this RadioButton control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static RadioButton ForeColor(this RadioButton control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static RadioButton ForeColor(this RadioButton control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static RadioButton Height(this RadioButton control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static RadioButton IsAccessible(this RadioButton control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static RadioButton Left(this RadioButton control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static RadioButton Location(this RadioButton control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static RadioButton Location(this RadioButton control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static RadioButton Margin(this RadioButton control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static RadioButton MaximumSize(this RadioButton control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static RadioButton MaximumSize(this RadioButton control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static RadioButton MinimumSize(this RadioButton control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static RadioButton MinimumSize(this RadioButton control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static RadioButton Name(this RadioButton control, String value)
        {
            control.Name = value;
            return control;
        }

        public static RadioButton Parent(this RadioButton control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static RadioButton Region(this RadioButton control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static RadioButton RightToLeft(this RadioButton control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static RadioButton Size(this RadioButton control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static RadioButton Size(this RadioButton control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static RadioButton TabIndex(this RadioButton control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static RadioButton Tag(this RadioButton control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static RadioButton Top(this RadioButton control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static RadioButton UseWaitCursor(this RadioButton control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static RadioButton Visible(this RadioButton control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static RadioButton Width(this RadioButton control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static RadioButton WindowTarget(this RadioButton control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static RadioButton Padding(this RadioButton control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static RadioButton OnAppearanceChanged(this RadioButton control, EventHandler handler)
        {
            control.AppearanceChanged += handler;
            return control;
        }

        public static RadioButton OnDoubleClick(this RadioButton control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static RadioButton OnMouseDoubleClick(this RadioButton control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static RadioButton OnCheckedChanged(this RadioButton control, EventHandler handler)
        {
            control.CheckedChanged += handler;
            return control;
        }

        public static RadioButton OnAutoSizeChanged(this RadioButton control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static RadioButton OnCommandCanExecuteChanged(this RadioButton control, EventHandler handler)
        {
            control.CommandCanExecuteChanged += handler;
            return control;
        }

        public static RadioButton OnCommandChanged(this RadioButton control, EventHandler handler)
        {
            control.CommandChanged += handler;
            return control;
        }

        public static RadioButton OnCommandParameterChanged(this RadioButton control, EventHandler handler)
        {
            control.CommandParameterChanged += handler;
            return control;
        }

        public static RadioButton OnImeModeChanged(this RadioButton control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static RadioButton OnBackColorChanged(this RadioButton control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static RadioButton OnBackgroundImageChanged(this RadioButton control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static RadioButton OnBackgroundImageLayoutChanged(this RadioButton control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static RadioButton OnBindingContextChanged(this RadioButton control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static RadioButton OnCausesValidationChanged(this RadioButton control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static RadioButton OnClientSizeChanged(this RadioButton control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static RadioButton OnContextMenuStripChanged(this RadioButton control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static RadioButton OnCursorChanged(this RadioButton control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static RadioButton OnDockChanged(this RadioButton control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static RadioButton OnEnabledChanged(this RadioButton control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static RadioButton OnFontChanged(this RadioButton control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static RadioButton OnForeColorChanged(this RadioButton control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static RadioButton OnLocationChanged(this RadioButton control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static RadioButton OnMarginChanged(this RadioButton control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static RadioButton OnRegionChanged(this RadioButton control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static RadioButton OnRightToLeftChanged(this RadioButton control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static RadioButton OnSizeChanged(this RadioButton control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static RadioButton OnTabIndexChanged(this RadioButton control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static RadioButton OnTabStopChanged(this RadioButton control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static RadioButton OnTextChanged(this RadioButton control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static RadioButton OnVisibleChanged(this RadioButton control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static RadioButton OnClick(this RadioButton control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static RadioButton OnControlAdded(this RadioButton control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static RadioButton OnControlRemoved(this RadioButton control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static RadioButton OnDataContextChanged(this RadioButton control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static RadioButton OnDragDrop(this RadioButton control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static RadioButton OnDragEnter(this RadioButton control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static RadioButton OnDragOver(this RadioButton control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static RadioButton OnDragLeave(this RadioButton control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static RadioButton OnGiveFeedback(this RadioButton control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static RadioButton OnHandleCreated(this RadioButton control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static RadioButton OnHandleDestroyed(this RadioButton control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static RadioButton OnHelpRequested(this RadioButton control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static RadioButton OnInvalidated(this RadioButton control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static RadioButton OnPaddingChanged(this RadioButton control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static RadioButton OnPaint(this RadioButton control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static RadioButton OnQueryContinueDrag(this RadioButton control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static RadioButton OnQueryAccessibilityHelp(this RadioButton control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static RadioButton OnEnter(this RadioButton control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static RadioButton OnGotFocus(this RadioButton control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static RadioButton OnKeyDown(this RadioButton control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static RadioButton OnKeyPress(this RadioButton control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static RadioButton OnKeyUp(this RadioButton control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static RadioButton OnLayout(this RadioButton control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static RadioButton OnLeave(this RadioButton control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static RadioButton OnLostFocus(this RadioButton control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static RadioButton OnMouseClick(this RadioButton control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static RadioButton OnMouseCaptureChanged(this RadioButton control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static RadioButton OnMouseDown(this RadioButton control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static RadioButton OnMouseEnter(this RadioButton control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static RadioButton OnMouseLeave(this RadioButton control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static RadioButton OnDpiChangedBeforeParent(this RadioButton control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static RadioButton OnDpiChangedAfterParent(this RadioButton control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static RadioButton OnMouseHover(this RadioButton control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static RadioButton OnMouseMove(this RadioButton control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static RadioButton OnMouseUp(this RadioButton control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static RadioButton OnMouseWheel(this RadioButton control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static RadioButton OnMove(this RadioButton control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static RadioButton OnPreviewKeyDown(this RadioButton control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static RadioButton OnResize(this RadioButton control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static RadioButton OnChangeUICues(this RadioButton control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static RadioButton OnStyleChanged(this RadioButton control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static RadioButton OnSystemColorsChanged(this RadioButton control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static RadioButton OnValidating(this RadioButton control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static RadioButton OnValidated(this RadioButton control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static RadioButton OnParentChanged(this RadioButton control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static RadioButton OnDisposed(this RadioButton control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static RadioButton AddTo(this RadioButton control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static RadioButton Assign(this RadioButton control, out RadioButton variable)
        {
            variable = control;
            return control;
        }

    }
}

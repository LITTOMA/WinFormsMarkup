using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Input;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class CheckBoxExtensions
    {
        public static CheckBox Appearance(this CheckBox control, Appearance value)
        {
            control.Appearance = value;
            return control;
        }

        public static CheckBox AutoCheck(this CheckBox control, Boolean value)
        {
            control.AutoCheck = value;
            return control;
        }

        public static CheckBox CheckAlign(this CheckBox control, ContentAlignment value)
        {
            control.CheckAlign = value;
            return control;
        }

        public static CheckBox Checked(this CheckBox control, Boolean value)
        {
            control.Checked = value;
            return control;
        }

        public static CheckBox CheckState(this CheckBox control, CheckState value)
        {
            control.CheckState = value;
            return control;
        }

        public static CheckBox TextAlign(this CheckBox control, ContentAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static CheckBox ThreeState(this CheckBox control, Boolean value)
        {
            control.ThreeState = value;
            return control;
        }

        public static CheckBox AutoEllipsis(this CheckBox control, Boolean value)
        {
            control.AutoEllipsis = value;
            return control;
        }

        public static CheckBox AutoSize(this CheckBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static CheckBox BackColor(this CheckBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static CheckBox BackColor(this CheckBox control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static CheckBox BackColor(this CheckBox control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static CheckBox Command(this CheckBox control, ICommand value)
        {
            control.Command = value;
            return control;
        }

        public static CheckBox CommandParameter(this CheckBox control, Object value)
        {
            control.CommandParameter = value;
            return control;
        }

        public static CheckBox FlatStyle(this CheckBox control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static CheckBox Image(this CheckBox control, Image value)
        {
            control.Image = value;
            return control;
        }

        public static CheckBox ImageAlign(this CheckBox control, ContentAlignment value)
        {
            control.ImageAlign = value;
            return control;
        }

        public static CheckBox ImageIndex(this CheckBox control, Int32 value)
        {
            control.ImageIndex = value;
            return control;
        }

        public static CheckBox ImageKey(this CheckBox control, String value)
        {
            control.ImageKey = value;
            return control;
        }

        public static CheckBox ImageList(this CheckBox control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static CheckBox ImeMode(this CheckBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static CheckBox Text(this CheckBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static CheckBox TextImageRelation(this CheckBox control, TextImageRelation value)
        {
            control.TextImageRelation = value;
            return control;
        }

        public static CheckBox UseMnemonic(this CheckBox control, Boolean value)
        {
            control.UseMnemonic = value;
            return control;
        }

        public static CheckBox UseCompatibleTextRendering(this CheckBox control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static CheckBox UseVisualStyleBackColor(this CheckBox control, Boolean value)
        {
            control.UseVisualStyleBackColor = value;
            return control;
        }

        public static CheckBox AccessibleDefaultActionDescription(this CheckBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static CheckBox AccessibleDescription(this CheckBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static CheckBox AccessibleName(this CheckBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static CheckBox AccessibleRole(this CheckBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static CheckBox AllowDrop(this CheckBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static CheckBox Anchor(this CheckBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static CheckBox AutoScrollOffset(this CheckBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static CheckBox AutoScrollOffset(this CheckBox control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static CheckBox DataContext(this CheckBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static CheckBox BackgroundImage(this CheckBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static CheckBox BackgroundImageLayout(this CheckBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static CheckBox BindingContext(this CheckBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static CheckBox Bounds(this CheckBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static CheckBox Bounds(this CheckBox control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static CheckBox Bounds(this CheckBox control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static CheckBox Capture(this CheckBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static CheckBox CausesValidation(this CheckBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static CheckBox ClientSize(this CheckBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static CheckBox ClientSize(this CheckBox control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static CheckBox ContextMenuStrip(this CheckBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static CheckBox Cursor(this CheckBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static CheckBox Dock(this CheckBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static CheckBox Enabled(this CheckBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static CheckBox Font(this CheckBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static CheckBox Font(this CheckBox control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static CheckBox ForeColor(this CheckBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static CheckBox ForeColor(this CheckBox control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static CheckBox ForeColor(this CheckBox control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static CheckBox Height(this CheckBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static CheckBox IsAccessible(this CheckBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static CheckBox Left(this CheckBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static CheckBox Location(this CheckBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static CheckBox Location(this CheckBox control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static CheckBox Margin(this CheckBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static CheckBox MaximumSize(this CheckBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static CheckBox MaximumSize(this CheckBox control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static CheckBox MinimumSize(this CheckBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static CheckBox MinimumSize(this CheckBox control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static CheckBox Name(this CheckBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static CheckBox Parent(this CheckBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static CheckBox Region(this CheckBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static CheckBox RightToLeft(this CheckBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static CheckBox Size(this CheckBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static CheckBox Size(this CheckBox control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static CheckBox TabIndex(this CheckBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static CheckBox TabStop(this CheckBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static CheckBox Tag(this CheckBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static CheckBox Top(this CheckBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static CheckBox UseWaitCursor(this CheckBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static CheckBox Visible(this CheckBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static CheckBox Width(this CheckBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static CheckBox WindowTarget(this CheckBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static CheckBox Padding(this CheckBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static CheckBox OnAppearanceChanged(this CheckBox control, EventHandler handler)
        {
            control.AppearanceChanged += handler;
            return control;
        }

        public static CheckBox OnDoubleClick(this CheckBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static CheckBox OnMouseDoubleClick(this CheckBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static CheckBox OnCheckedChanged(this CheckBox control, EventHandler handler)
        {
            control.CheckedChanged += handler;
            return control;
        }

        public static CheckBox OnCheckStateChanged(this CheckBox control, EventHandler handler)
        {
            control.CheckStateChanged += handler;
            return control;
        }

        public static CheckBox OnAutoSizeChanged(this CheckBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static CheckBox OnCommandCanExecuteChanged(this CheckBox control, EventHandler handler)
        {
            control.CommandCanExecuteChanged += handler;
            return control;
        }

        public static CheckBox OnCommandChanged(this CheckBox control, EventHandler handler)
        {
            control.CommandChanged += handler;
            return control;
        }

        public static CheckBox OnCommandParameterChanged(this CheckBox control, EventHandler handler)
        {
            control.CommandParameterChanged += handler;
            return control;
        }

        public static CheckBox OnImeModeChanged(this CheckBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static CheckBox OnBackColorChanged(this CheckBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static CheckBox OnBackgroundImageChanged(this CheckBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static CheckBox OnBackgroundImageLayoutChanged(this CheckBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static CheckBox OnBindingContextChanged(this CheckBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static CheckBox OnCausesValidationChanged(this CheckBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static CheckBox OnClientSizeChanged(this CheckBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static CheckBox OnContextMenuStripChanged(this CheckBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static CheckBox OnCursorChanged(this CheckBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static CheckBox OnDockChanged(this CheckBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static CheckBox OnEnabledChanged(this CheckBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static CheckBox OnFontChanged(this CheckBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static CheckBox OnForeColorChanged(this CheckBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static CheckBox OnLocationChanged(this CheckBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static CheckBox OnMarginChanged(this CheckBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static CheckBox OnRegionChanged(this CheckBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static CheckBox OnRightToLeftChanged(this CheckBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static CheckBox OnSizeChanged(this CheckBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static CheckBox OnTabIndexChanged(this CheckBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static CheckBox OnTabStopChanged(this CheckBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static CheckBox OnTextChanged(this CheckBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static CheckBox OnVisibleChanged(this CheckBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static CheckBox OnClick(this CheckBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static CheckBox OnControlAdded(this CheckBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static CheckBox OnControlRemoved(this CheckBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static CheckBox OnDataContextChanged(this CheckBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static CheckBox OnDragDrop(this CheckBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static CheckBox OnDragEnter(this CheckBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static CheckBox OnDragOver(this CheckBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static CheckBox OnDragLeave(this CheckBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static CheckBox OnGiveFeedback(this CheckBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static CheckBox OnHandleCreated(this CheckBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static CheckBox OnHandleDestroyed(this CheckBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static CheckBox OnHelpRequested(this CheckBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static CheckBox OnInvalidated(this CheckBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static CheckBox OnPaddingChanged(this CheckBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static CheckBox OnPaint(this CheckBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static CheckBox OnQueryContinueDrag(this CheckBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static CheckBox OnQueryAccessibilityHelp(this CheckBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static CheckBox OnEnter(this CheckBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static CheckBox OnGotFocus(this CheckBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static CheckBox OnKeyDown(this CheckBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static CheckBox OnKeyPress(this CheckBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static CheckBox OnKeyUp(this CheckBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static CheckBox OnLayout(this CheckBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static CheckBox OnLeave(this CheckBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static CheckBox OnLostFocus(this CheckBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static CheckBox OnMouseClick(this CheckBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static CheckBox OnMouseCaptureChanged(this CheckBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static CheckBox OnMouseDown(this CheckBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static CheckBox OnMouseEnter(this CheckBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static CheckBox OnMouseLeave(this CheckBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static CheckBox OnDpiChangedBeforeParent(this CheckBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static CheckBox OnDpiChangedAfterParent(this CheckBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static CheckBox OnMouseHover(this CheckBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static CheckBox OnMouseMove(this CheckBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static CheckBox OnMouseUp(this CheckBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static CheckBox OnMouseWheel(this CheckBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static CheckBox OnMove(this CheckBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static CheckBox OnPreviewKeyDown(this CheckBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static CheckBox OnResize(this CheckBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static CheckBox OnChangeUICues(this CheckBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static CheckBox OnStyleChanged(this CheckBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static CheckBox OnSystemColorsChanged(this CheckBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static CheckBox OnValidating(this CheckBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static CheckBox OnValidated(this CheckBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static CheckBox OnParentChanged(this CheckBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static CheckBox OnDisposed(this CheckBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static CheckBox AddTo(this CheckBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static CheckBox Assign(this CheckBox control, out CheckBox variable)
        {
            variable = control;
            return control;
        }

    }
}

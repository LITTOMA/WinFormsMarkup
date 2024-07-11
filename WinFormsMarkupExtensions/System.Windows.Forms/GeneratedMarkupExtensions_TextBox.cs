using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class TextBoxExtensions
    {
        public static TextBox AcceptsReturn(this TextBox control, Boolean value)
        {
            control.AcceptsReturn = value;
            return control;
        }

        public static TextBox AutoCompleteMode(this TextBox control, AutoCompleteMode value)
        {
            control.AutoCompleteMode = value;
            return control;
        }

        public static TextBox AutoCompleteSource(this TextBox control, AutoCompleteSource value)
        {
            control.AutoCompleteSource = value;
            return control;
        }

        public static TextBox AutoCompleteCustomSource(this TextBox control, AutoCompleteStringCollection value)
        {
            control.AutoCompleteCustomSource = value;
            return control;
        }

        public static TextBox CharacterCasing(this TextBox control, CharacterCasing value)
        {
            control.CharacterCasing = value;
            return control;
        }

        public static TextBox Multiline(this TextBox control, Boolean value)
        {
            control.Multiline = value;
            return control;
        }

        public static TextBox PasswordChar(this TextBox control, Char value)
        {
            control.PasswordChar = value;
            return control;
        }

        public static TextBox ScrollBars(this TextBox control, ScrollBars value)
        {
            control.ScrollBars = value;
            return control;
        }

        public static TextBox Text(this TextBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static TextBox TextAlign(this TextBox control, HorizontalAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static TextBox UseSystemPasswordChar(this TextBox control, Boolean value)
        {
            control.UseSystemPasswordChar = value;
            return control;
        }

        public static TextBox PlaceholderText(this TextBox control, String value)
        {
            control.PlaceholderText = value;
            return control;
        }

        public static TextBox AcceptsTab(this TextBox control, Boolean value)
        {
            control.AcceptsTab = value;
            return control;
        }

        public static TextBox ShortcutsEnabled(this TextBox control, Boolean value)
        {
            control.ShortcutsEnabled = value;
            return control;
        }

        public static TextBox AutoSize(this TextBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static TextBox BackColor(this TextBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TextBox BackColor(this TextBox control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static TextBox BackColor(this TextBox control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static TextBox BackgroundImage(this TextBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static TextBox BackgroundImageLayout(this TextBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static TextBox BorderStyle(this TextBox control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static TextBox ForeColor(this TextBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TextBox ForeColor(this TextBox control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static TextBox ForeColor(this TextBox control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static TextBox HideSelection(this TextBox control, Boolean value)
        {
            control.HideSelection = value;
            return control;
        }

        public static TextBox Lines(this TextBox control, String[] value)
        {
            control.Lines = value;
            return control;
        }

        public static TextBox MaxLength(this TextBox control, Int32 value)
        {
            control.MaxLength = value;
            return control;
        }

        public static TextBox Modified(this TextBox control, Boolean value)
        {
            control.Modified = value;
            return control;
        }

        public static TextBox Padding(this TextBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static TextBox ReadOnly(this TextBox control, Boolean value)
        {
            control.ReadOnly = value;
            return control;
        }

        public static TextBox SelectedText(this TextBox control, String value)
        {
            control.SelectedText = value;
            return control;
        }

        public static TextBox SelectionLength(this TextBox control, Int32 value)
        {
            control.SelectionLength = value;
            return control;
        }

        public static TextBox SelectionStart(this TextBox control, Int32 value)
        {
            control.SelectionStart = value;
            return control;
        }

        public static TextBox WordWrap(this TextBox control, Boolean value)
        {
            control.WordWrap = value;
            return control;
        }

        public static TextBox AccessibleDefaultActionDescription(this TextBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static TextBox AccessibleDescription(this TextBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static TextBox AccessibleName(this TextBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static TextBox AccessibleRole(this TextBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static TextBox AllowDrop(this TextBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static TextBox Anchor(this TextBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static TextBox AutoScrollOffset(this TextBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static TextBox AutoScrollOffset(this TextBox control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static TextBox DataContext(this TextBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static TextBox BindingContext(this TextBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static TextBox Bounds(this TextBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static TextBox Bounds(this TextBox control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static TextBox Bounds(this TextBox control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static TextBox Capture(this TextBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static TextBox CausesValidation(this TextBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static TextBox ClientSize(this TextBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static TextBox ClientSize(this TextBox control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static TextBox ContextMenuStrip(this TextBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static TextBox Cursor(this TextBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static TextBox Dock(this TextBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static TextBox Enabled(this TextBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static TextBox Font(this TextBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static TextBox Font(this TextBox control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static TextBox Height(this TextBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static TextBox IsAccessible(this TextBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static TextBox Left(this TextBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static TextBox Location(this TextBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static TextBox Location(this TextBox control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static TextBox Margin(this TextBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static TextBox MaximumSize(this TextBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static TextBox MaximumSize(this TextBox control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static TextBox MinimumSize(this TextBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static TextBox MinimumSize(this TextBox control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static TextBox Name(this TextBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static TextBox Parent(this TextBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static TextBox Region(this TextBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static TextBox RightToLeft(this TextBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static TextBox Size(this TextBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static TextBox Size(this TextBox control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static TextBox TabIndex(this TextBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static TextBox TabStop(this TextBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static TextBox Tag(this TextBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static TextBox Top(this TextBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static TextBox UseWaitCursor(this TextBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static TextBox Visible(this TextBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static TextBox Width(this TextBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static TextBox WindowTarget(this TextBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static TextBox ImeMode(this TextBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static TextBox OnTextAlignChanged(this TextBox control, EventHandler handler)
        {
            control.TextAlignChanged += handler;
            return control;
        }

        public static TextBox OnAcceptsTabChanged(this TextBox control, EventHandler handler)
        {
            control.AcceptsTabChanged += handler;
            return control;
        }

        public static TextBox OnAutoSizeChanged(this TextBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static TextBox OnBackgroundImageChanged(this TextBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static TextBox OnBackgroundImageLayoutChanged(this TextBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static TextBox OnBorderStyleChanged(this TextBox control, EventHandler handler)
        {
            control.BorderStyleChanged += handler;
            return control;
        }

        public static TextBox OnClick(this TextBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static TextBox OnMouseClick(this TextBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static TextBox OnHideSelectionChanged(this TextBox control, EventHandler handler)
        {
            control.HideSelectionChanged += handler;
            return control;
        }

        public static TextBox OnModifiedChanged(this TextBox control, EventHandler handler)
        {
            control.ModifiedChanged += handler;
            return control;
        }

        public static TextBox OnMultilineChanged(this TextBox control, EventHandler handler)
        {
            control.MultilineChanged += handler;
            return control;
        }

        public static TextBox OnPaddingChanged(this TextBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static TextBox OnReadOnlyChanged(this TextBox control, EventHandler handler)
        {
            control.ReadOnlyChanged += handler;
            return control;
        }

        public static TextBox OnPaint(this TextBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static TextBox OnBackColorChanged(this TextBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static TextBox OnBindingContextChanged(this TextBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static TextBox OnCausesValidationChanged(this TextBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static TextBox OnClientSizeChanged(this TextBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static TextBox OnContextMenuStripChanged(this TextBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static TextBox OnCursorChanged(this TextBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static TextBox OnDockChanged(this TextBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static TextBox OnEnabledChanged(this TextBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static TextBox OnFontChanged(this TextBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static TextBox OnForeColorChanged(this TextBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static TextBox OnLocationChanged(this TextBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static TextBox OnMarginChanged(this TextBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static TextBox OnRegionChanged(this TextBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static TextBox OnRightToLeftChanged(this TextBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static TextBox OnSizeChanged(this TextBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static TextBox OnTabIndexChanged(this TextBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static TextBox OnTabStopChanged(this TextBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static TextBox OnTextChanged(this TextBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static TextBox OnVisibleChanged(this TextBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static TextBox OnControlAdded(this TextBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static TextBox OnControlRemoved(this TextBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static TextBox OnDataContextChanged(this TextBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static TextBox OnDragDrop(this TextBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static TextBox OnDragEnter(this TextBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static TextBox OnDragOver(this TextBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static TextBox OnDragLeave(this TextBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static TextBox OnGiveFeedback(this TextBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static TextBox OnHandleCreated(this TextBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static TextBox OnHandleDestroyed(this TextBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static TextBox OnHelpRequested(this TextBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static TextBox OnInvalidated(this TextBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static TextBox OnQueryContinueDrag(this TextBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static TextBox OnQueryAccessibilityHelp(this TextBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static TextBox OnDoubleClick(this TextBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static TextBox OnEnter(this TextBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static TextBox OnGotFocus(this TextBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static TextBox OnKeyDown(this TextBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static TextBox OnKeyPress(this TextBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static TextBox OnKeyUp(this TextBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static TextBox OnLayout(this TextBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static TextBox OnLeave(this TextBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static TextBox OnLostFocus(this TextBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static TextBox OnMouseDoubleClick(this TextBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static TextBox OnMouseCaptureChanged(this TextBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static TextBox OnMouseDown(this TextBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static TextBox OnMouseEnter(this TextBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static TextBox OnMouseLeave(this TextBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static TextBox OnDpiChangedBeforeParent(this TextBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static TextBox OnDpiChangedAfterParent(this TextBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static TextBox OnMouseHover(this TextBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static TextBox OnMouseMove(this TextBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static TextBox OnMouseUp(this TextBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static TextBox OnMouseWheel(this TextBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static TextBox OnMove(this TextBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static TextBox OnPreviewKeyDown(this TextBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static TextBox OnResize(this TextBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static TextBox OnChangeUICues(this TextBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static TextBox OnStyleChanged(this TextBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static TextBox OnSystemColorsChanged(this TextBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static TextBox OnValidating(this TextBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static TextBox OnValidated(this TextBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static TextBox OnParentChanged(this TextBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static TextBox OnImeModeChanged(this TextBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static TextBox OnDisposed(this TextBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static TextBox AddTo(this TextBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static TextBox Assign(this TextBox control, out TextBox variable)
        {
            variable = control;
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class DataGridViewTextBoxEditingControlExtensions
    {
        public static DataGridViewTextBoxEditingControl EditingControlDataGridView(this DataGridViewTextBoxEditingControl control, DataGridView value)
        {
            control.EditingControlDataGridView = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl EditingControlFormattedValue(this DataGridViewTextBoxEditingControl control, Object value)
        {
            control.EditingControlFormattedValue = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl EditingControlRowIndex(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.EditingControlRowIndex = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl EditingControlValueChanged(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.EditingControlValueChanged = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AcceptsReturn(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.AcceptsReturn = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AutoCompleteMode(this DataGridViewTextBoxEditingControl control, AutoCompleteMode value)
        {
            control.AutoCompleteMode = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AutoCompleteSource(this DataGridViewTextBoxEditingControl control, AutoCompleteSource value)
        {
            control.AutoCompleteSource = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AutoCompleteCustomSource(this DataGridViewTextBoxEditingControl control, AutoCompleteStringCollection value)
        {
            control.AutoCompleteCustomSource = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl CharacterCasing(this DataGridViewTextBoxEditingControl control, CharacterCasing value)
        {
            control.CharacterCasing = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Multiline(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.Multiline = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl PasswordChar(this DataGridViewTextBoxEditingControl control, Char value)
        {
            control.PasswordChar = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl ScrollBars(this DataGridViewTextBoxEditingControl control, ScrollBars value)
        {
            control.ScrollBars = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Text(this DataGridViewTextBoxEditingControl control, String value)
        {
            control.Text = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl TextAlign(this DataGridViewTextBoxEditingControl control, HorizontalAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl UseSystemPasswordChar(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.UseSystemPasswordChar = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl PlaceholderText(this DataGridViewTextBoxEditingControl control, String value)
        {
            control.PlaceholderText = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AcceptsTab(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.AcceptsTab = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl ShortcutsEnabled(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.ShortcutsEnabled = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AutoSize(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl BackColor(this DataGridViewTextBoxEditingControl control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridViewTextBoxEditingControl BackColor(this DataGridViewTextBoxEditingControl control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static DataGridViewTextBoxEditingControl BackColor(this DataGridViewTextBoxEditingControl control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static DataGridViewTextBoxEditingControl BackgroundImage(this DataGridViewTextBoxEditingControl control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl BackgroundImageLayout(this DataGridViewTextBoxEditingControl control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl BorderStyle(this DataGridViewTextBoxEditingControl control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl ForeColor(this DataGridViewTextBoxEditingControl control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridViewTextBoxEditingControl ForeColor(this DataGridViewTextBoxEditingControl control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static DataGridViewTextBoxEditingControl ForeColor(this DataGridViewTextBoxEditingControl control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static DataGridViewTextBoxEditingControl HideSelection(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.HideSelection = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Lines(this DataGridViewTextBoxEditingControl control, String[] value)
        {
            control.Lines = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl MaxLength(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.MaxLength = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Modified(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.Modified = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Padding(this DataGridViewTextBoxEditingControl control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl ReadOnly(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.ReadOnly = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl SelectedText(this DataGridViewTextBoxEditingControl control, String value)
        {
            control.SelectedText = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl SelectionLength(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.SelectionLength = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl SelectionStart(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.SelectionStart = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl WordWrap(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.WordWrap = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AccessibleDefaultActionDescription(this DataGridViewTextBoxEditingControl control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AccessibleDescription(this DataGridViewTextBoxEditingControl control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AccessibleName(this DataGridViewTextBoxEditingControl control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AccessibleRole(this DataGridViewTextBoxEditingControl control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AllowDrop(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Anchor(this DataGridViewTextBoxEditingControl control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AutoScrollOffset(this DataGridViewTextBoxEditingControl control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static DataGridViewTextBoxEditingControl AutoScrollOffset(this DataGridViewTextBoxEditingControl control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static DataGridViewTextBoxEditingControl DataContext(this DataGridViewTextBoxEditingControl control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl BindingContext(this DataGridViewTextBoxEditingControl control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Bounds(this DataGridViewTextBoxEditingControl control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static DataGridViewTextBoxEditingControl Bounds(this DataGridViewTextBoxEditingControl control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static DataGridViewTextBoxEditingControl Bounds(this DataGridViewTextBoxEditingControl control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Capture(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl CausesValidation(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl ClientSize(this DataGridViewTextBoxEditingControl control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static DataGridViewTextBoxEditingControl ClientSize(this DataGridViewTextBoxEditingControl control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static DataGridViewTextBoxEditingControl ContextMenuStrip(this DataGridViewTextBoxEditingControl control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Cursor(this DataGridViewTextBoxEditingControl control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Dock(this DataGridViewTextBoxEditingControl control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Enabled(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Font(this DataGridViewTextBoxEditingControl control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static DataGridViewTextBoxEditingControl Font(this DataGridViewTextBoxEditingControl control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Height(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl IsAccessible(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Left(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Location(this DataGridViewTextBoxEditingControl control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static DataGridViewTextBoxEditingControl Location(this DataGridViewTextBoxEditingControl control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Margin(this DataGridViewTextBoxEditingControl control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl MaximumSize(this DataGridViewTextBoxEditingControl control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static DataGridViewTextBoxEditingControl MaximumSize(this DataGridViewTextBoxEditingControl control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static DataGridViewTextBoxEditingControl MinimumSize(this DataGridViewTextBoxEditingControl control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static DataGridViewTextBoxEditingControl MinimumSize(this DataGridViewTextBoxEditingControl control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Name(this DataGridViewTextBoxEditingControl control, String value)
        {
            control.Name = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Parent(this DataGridViewTextBoxEditingControl control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Region(this DataGridViewTextBoxEditingControl control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl RightToLeft(this DataGridViewTextBoxEditingControl control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Size(this DataGridViewTextBoxEditingControl control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static DataGridViewTextBoxEditingControl Size(this DataGridViewTextBoxEditingControl control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static DataGridViewTextBoxEditingControl TabIndex(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl TabStop(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Tag(this DataGridViewTextBoxEditingControl control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Top(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl UseWaitCursor(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Visible(this DataGridViewTextBoxEditingControl control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl Width(this DataGridViewTextBoxEditingControl control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl WindowTarget(this DataGridViewTextBoxEditingControl control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl ImeMode(this DataGridViewTextBoxEditingControl control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnTextAlignChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.TextAlignChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnAcceptsTabChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.AcceptsTabChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnAutoSizeChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnBackgroundImageChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnBackgroundImageLayoutChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnBorderStyleChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.BorderStyleChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnClick(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseClick(this DataGridViewTextBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnHideSelectionChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.HideSelectionChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnModifiedChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.ModifiedChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMultilineChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.MultilineChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnPaddingChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnReadOnlyChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.ReadOnlyChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnPaint(this DataGridViewTextBoxEditingControl control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnBackColorChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnBindingContextChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnCausesValidationChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnClientSizeChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnContextMenuStripChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnCursorChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDockChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnEnabledChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnFontChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnForeColorChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnLocationChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMarginChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnRegionChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnRightToLeftChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnSizeChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnTabIndexChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnTabStopChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnTextChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnVisibleChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnControlAdded(this DataGridViewTextBoxEditingControl control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnControlRemoved(this DataGridViewTextBoxEditingControl control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDataContextChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDragDrop(this DataGridViewTextBoxEditingControl control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDragEnter(this DataGridViewTextBoxEditingControl control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDragOver(this DataGridViewTextBoxEditingControl control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDragLeave(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnGiveFeedback(this DataGridViewTextBoxEditingControl control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnHandleCreated(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnHandleDestroyed(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnHelpRequested(this DataGridViewTextBoxEditingControl control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnInvalidated(this DataGridViewTextBoxEditingControl control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnQueryContinueDrag(this DataGridViewTextBoxEditingControl control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnQueryAccessibilityHelp(this DataGridViewTextBoxEditingControl control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDoubleClick(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnEnter(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnGotFocus(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnKeyDown(this DataGridViewTextBoxEditingControl control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnKeyPress(this DataGridViewTextBoxEditingControl control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnKeyUp(this DataGridViewTextBoxEditingControl control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnLayout(this DataGridViewTextBoxEditingControl control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnLeave(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnLostFocus(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseDoubleClick(this DataGridViewTextBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseCaptureChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseDown(this DataGridViewTextBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseEnter(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseLeave(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDpiChangedBeforeParent(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDpiChangedAfterParent(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseHover(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseMove(this DataGridViewTextBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseUp(this DataGridViewTextBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMouseWheel(this DataGridViewTextBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnMove(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnPreviewKeyDown(this DataGridViewTextBoxEditingControl control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnResize(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnChangeUICues(this DataGridViewTextBoxEditingControl control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnStyleChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnSystemColorsChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnValidating(this DataGridViewTextBoxEditingControl control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnValidated(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnParentChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnImeModeChanged(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl OnDisposed(this DataGridViewTextBoxEditingControl control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static DataGridViewTextBoxEditingControl AddTo(this DataGridViewTextBoxEditingControl control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static DataGridViewTextBoxEditingControl Assign(this DataGridViewTextBoxEditingControl control, out DataGridViewTextBoxEditingControl variable)
        {
            variable = control;
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class DataGridViewComboBoxEditingControlExtensions
    {
        public static DataGridViewComboBoxEditingControl EditingControlDataGridView(this DataGridViewComboBoxEditingControl control, DataGridView value)
        {
            control.EditingControlDataGridView = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl EditingControlFormattedValue(this DataGridViewComboBoxEditingControl control, Object value)
        {
            control.EditingControlFormattedValue = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl EditingControlRowIndex(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.EditingControlRowIndex = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl EditingControlValueChanged(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.EditingControlValueChanged = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AutoCompleteMode(this DataGridViewComboBoxEditingControl control, AutoCompleteMode value)
        {
            control.AutoCompleteMode = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AutoCompleteSource(this DataGridViewComboBoxEditingControl control, AutoCompleteSource value)
        {
            control.AutoCompleteSource = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AutoCompleteCustomSource(this DataGridViewComboBoxEditingControl control, AutoCompleteStringCollection value)
        {
            control.AutoCompleteCustomSource = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl BackColor(this DataGridViewComboBoxEditingControl control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridViewComboBoxEditingControl BackgroundImage(this DataGridViewComboBoxEditingControl control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl BackgroundImageLayout(this DataGridViewComboBoxEditingControl control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl DataSource(this DataGridViewComboBoxEditingControl control, Object value)
        {
            control.DataSource = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl DrawMode(this DataGridViewComboBoxEditingControl control, DrawMode value)
        {
            control.DrawMode = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl DropDownWidth(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.DropDownWidth = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl DropDownHeight(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.DropDownHeight = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl DroppedDown(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.DroppedDown = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl FlatStyle(this DataGridViewComboBoxEditingControl control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl ForeColor(this DataGridViewComboBoxEditingControl control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridViewComboBoxEditingControl IntegralHeight(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.IntegralHeight = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl ItemHeight(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.ItemHeight = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl MaxDropDownItems(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.MaxDropDownItems = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl MaximumSize(this DataGridViewComboBoxEditingControl control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static DataGridViewComboBoxEditingControl MinimumSize(this DataGridViewComboBoxEditingControl control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static DataGridViewComboBoxEditingControl MaxLength(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.MaxLength = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Padding(this DataGridViewComboBoxEditingControl control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl SelectedIndex(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.SelectedIndex = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl SelectedItem(this DataGridViewComboBoxEditingControl control, Object value)
        {
            control.SelectedItem = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl SelectedText(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.SelectedText = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl SelectionLength(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.SelectionLength = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl SelectionStart(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.SelectionStart = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Sorted(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.Sorted = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl DropDownStyle(this DataGridViewComboBoxEditingControl control, ComboBoxStyle value)
        {
            control.DropDownStyle = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Text(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.Text = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl DisplayMember(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.DisplayMember = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl FormatInfo(this DataGridViewComboBoxEditingControl control, IFormatProvider value)
        {
            control.FormatInfo = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl FormatString(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.FormatString = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl FormattingEnabled(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.FormattingEnabled = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl ValueMember(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.ValueMember = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl SelectedValue(this DataGridViewComboBoxEditingControl control, Object value)
        {
            control.SelectedValue = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AccessibleDefaultActionDescription(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AccessibleDescription(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AccessibleName(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AccessibleRole(this DataGridViewComboBoxEditingControl control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AllowDrop(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Anchor(this DataGridViewComboBoxEditingControl control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AutoSize(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AutoScrollOffset(this DataGridViewComboBoxEditingControl control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static DataGridViewComboBoxEditingControl DataContext(this DataGridViewComboBoxEditingControl control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl BindingContext(this DataGridViewComboBoxEditingControl control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Bounds(this DataGridViewComboBoxEditingControl control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static DataGridViewComboBoxEditingControl Capture(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl CausesValidation(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl ClientSize(this DataGridViewComboBoxEditingControl control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static DataGridViewComboBoxEditingControl ContextMenuStrip(this DataGridViewComboBoxEditingControl control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Cursor(this DataGridViewComboBoxEditingControl control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Dock(this DataGridViewComboBoxEditingControl control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Enabled(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Font(this DataGridViewComboBoxEditingControl control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static DataGridViewComboBoxEditingControl Height(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl IsAccessible(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Left(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Location(this DataGridViewComboBoxEditingControl control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static DataGridViewComboBoxEditingControl Margin(this DataGridViewComboBoxEditingControl control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Name(this DataGridViewComboBoxEditingControl control, String value)
        {
            control.Name = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Parent(this DataGridViewComboBoxEditingControl control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Region(this DataGridViewComboBoxEditingControl control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl RightToLeft(this DataGridViewComboBoxEditingControl control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Size(this DataGridViewComboBoxEditingControl control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static DataGridViewComboBoxEditingControl TabIndex(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl TabStop(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Tag(this DataGridViewComboBoxEditingControl control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Top(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl UseWaitCursor(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Visible(this DataGridViewComboBoxEditingControl control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl Width(this DataGridViewComboBoxEditingControl control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl WindowTarget(this DataGridViewComboBoxEditingControl control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl ImeMode(this DataGridViewComboBoxEditingControl control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnBackgroundImageChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnBackgroundImageLayoutChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnPaddingChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDoubleClick(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDrawItem(this DataGridViewComboBoxEditingControl control, DrawItemEventHandler handler)
        {
            control.DrawItem += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDropDown(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DropDown += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMeasureItem(this DataGridViewComboBoxEditingControl control, MeasureItemEventHandler handler)
        {
            control.MeasureItem += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnSelectedIndexChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.SelectedIndexChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnSelectionChangeCommitted(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.SelectionChangeCommitted += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDropDownStyleChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DropDownStyleChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnPaint(this DataGridViewComboBoxEditingControl control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnTextUpdate(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.TextUpdate += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDropDownClosed(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DropDownClosed += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDataSourceChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DataSourceChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDisplayMemberChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DisplayMemberChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnFormat(this DataGridViewComboBoxEditingControl control, ListControlConvertEventHandler handler)
        {
            control.Format += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnFormatInfoChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.FormatInfoChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnFormatStringChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.FormatStringChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnFormattingEnabledChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.FormattingEnabledChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnValueMemberChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.ValueMemberChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnSelectedValueChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.SelectedValueChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnAutoSizeChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnBackColorChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnBindingContextChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnCausesValidationChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnClientSizeChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnContextMenuStripChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnCursorChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDockChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnEnabledChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnFontChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnForeColorChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnLocationChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMarginChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnRegionChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnRightToLeftChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnSizeChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnTabIndexChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnTabStopChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnTextChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnVisibleChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnClick(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnControlAdded(this DataGridViewComboBoxEditingControl control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnControlRemoved(this DataGridViewComboBoxEditingControl control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDataContextChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDragDrop(this DataGridViewComboBoxEditingControl control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDragEnter(this DataGridViewComboBoxEditingControl control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDragOver(this DataGridViewComboBoxEditingControl control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDragLeave(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnGiveFeedback(this DataGridViewComboBoxEditingControl control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnHandleCreated(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnHandleDestroyed(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnHelpRequested(this DataGridViewComboBoxEditingControl control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnInvalidated(this DataGridViewComboBoxEditingControl control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnQueryContinueDrag(this DataGridViewComboBoxEditingControl control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnQueryAccessibilityHelp(this DataGridViewComboBoxEditingControl control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnEnter(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnGotFocus(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnKeyDown(this DataGridViewComboBoxEditingControl control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnKeyPress(this DataGridViewComboBoxEditingControl control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnKeyUp(this DataGridViewComboBoxEditingControl control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnLayout(this DataGridViewComboBoxEditingControl control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnLeave(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnLostFocus(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseClick(this DataGridViewComboBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseDoubleClick(this DataGridViewComboBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseCaptureChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseDown(this DataGridViewComboBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseEnter(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseLeave(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDpiChangedBeforeParent(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDpiChangedAfterParent(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseHover(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseMove(this DataGridViewComboBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseUp(this DataGridViewComboBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMouseWheel(this DataGridViewComboBoxEditingControl control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnMove(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnPreviewKeyDown(this DataGridViewComboBoxEditingControl control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnResize(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnChangeUICues(this DataGridViewComboBoxEditingControl control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnStyleChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnSystemColorsChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnValidating(this DataGridViewComboBoxEditingControl control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnValidated(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnParentChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnImeModeChanged(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl OnDisposed(this DataGridViewComboBoxEditingControl control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static DataGridViewComboBoxEditingControl AddTo(this DataGridViewComboBoxEditingControl control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

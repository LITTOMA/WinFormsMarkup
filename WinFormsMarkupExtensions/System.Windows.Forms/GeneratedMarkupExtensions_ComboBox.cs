using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ComboBoxExtensions
    {
        public static ComboBox AutoCompleteMode(this ComboBox control, AutoCompleteMode value)
        {
            control.AutoCompleteMode = value;
            return control;
        }

        public static ComboBox AutoCompleteSource(this ComboBox control, AutoCompleteSource value)
        {
            control.AutoCompleteSource = value;
            return control;
        }

        public static ComboBox AutoCompleteCustomSource(this ComboBox control, AutoCompleteStringCollection value)
        {
            control.AutoCompleteCustomSource = value;
            return control;
        }

        public static ComboBox BackColor(this ComboBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ComboBox BackgroundImage(this ComboBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ComboBox BackgroundImageLayout(this ComboBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ComboBox DataSource(this ComboBox control, Object value)
        {
            control.DataSource = value;
            return control;
        }

        public static ComboBox DrawMode(this ComboBox control, DrawMode value)
        {
            control.DrawMode = value;
            return control;
        }

        public static ComboBox DropDownWidth(this ComboBox control, Int32 value)
        {
            control.DropDownWidth = value;
            return control;
        }

        public static ComboBox DropDownHeight(this ComboBox control, Int32 value)
        {
            control.DropDownHeight = value;
            return control;
        }

        public static ComboBox DroppedDown(this ComboBox control, Boolean value)
        {
            control.DroppedDown = value;
            return control;
        }

        public static ComboBox FlatStyle(this ComboBox control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static ComboBox ForeColor(this ComboBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ComboBox IntegralHeight(this ComboBox control, Boolean value)
        {
            control.IntegralHeight = value;
            return control;
        }

        public static ComboBox ItemHeight(this ComboBox control, Int32 value)
        {
            control.ItemHeight = value;
            return control;
        }

        public static ComboBox MaxDropDownItems(this ComboBox control, Int32 value)
        {
            control.MaxDropDownItems = value;
            return control;
        }

        public static ComboBox MaximumSize(this ComboBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ComboBox MinimumSize(this ComboBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ComboBox MaxLength(this ComboBox control, Int32 value)
        {
            control.MaxLength = value;
            return control;
        }

        public static ComboBox Padding(this ComboBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ComboBox SelectedIndex(this ComboBox control, Int32 value)
        {
            control.SelectedIndex = value;
            return control;
        }

        public static ComboBox SelectedItem(this ComboBox control, Object value)
        {
            control.SelectedItem = value;
            return control;
        }

        public static ComboBox SelectedText(this ComboBox control, String value)
        {
            control.SelectedText = value;
            return control;
        }

        public static ComboBox SelectionLength(this ComboBox control, Int32 value)
        {
            control.SelectionLength = value;
            return control;
        }

        public static ComboBox SelectionStart(this ComboBox control, Int32 value)
        {
            control.SelectionStart = value;
            return control;
        }

        public static ComboBox Sorted(this ComboBox control, Boolean value)
        {
            control.Sorted = value;
            return control;
        }

        public static ComboBox DropDownStyle(this ComboBox control, ComboBoxStyle value)
        {
            control.DropDownStyle = value;
            return control;
        }

        public static ComboBox Text(this ComboBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ComboBox DisplayMember(this ComboBox control, String value)
        {
            control.DisplayMember = value;
            return control;
        }

        public static ComboBox FormatInfo(this ComboBox control, IFormatProvider value)
        {
            control.FormatInfo = value;
            return control;
        }

        public static ComboBox FormatString(this ComboBox control, String value)
        {
            control.FormatString = value;
            return control;
        }

        public static ComboBox FormattingEnabled(this ComboBox control, Boolean value)
        {
            control.FormattingEnabled = value;
            return control;
        }

        public static ComboBox ValueMember(this ComboBox control, String value)
        {
            control.ValueMember = value;
            return control;
        }

        public static ComboBox SelectedValue(this ComboBox control, Object value)
        {
            control.SelectedValue = value;
            return control;
        }

        public static ComboBox AccessibleDefaultActionDescription(this ComboBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ComboBox AccessibleDescription(this ComboBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ComboBox AccessibleName(this ComboBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ComboBox AccessibleRole(this ComboBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ComboBox AllowDrop(this ComboBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ComboBox Anchor(this ComboBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ComboBox AutoSize(this ComboBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ComboBox AutoScrollOffset(this ComboBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ComboBox DataContext(this ComboBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ComboBox BindingContext(this ComboBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ComboBox Bounds(this ComboBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ComboBox Capture(this ComboBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ComboBox CausesValidation(this ComboBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ComboBox ClientSize(this ComboBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ComboBox ContextMenuStrip(this ComboBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ComboBox Cursor(this ComboBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ComboBox Dock(this ComboBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ComboBox Enabled(this ComboBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ComboBox Font(this ComboBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ComboBox Height(this ComboBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ComboBox IsAccessible(this ComboBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ComboBox Left(this ComboBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ComboBox Location(this ComboBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ComboBox Margin(this ComboBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ComboBox Name(this ComboBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ComboBox Parent(this ComboBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ComboBox Region(this ComboBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ComboBox RightToLeft(this ComboBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ComboBox Size(this ComboBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ComboBox TabIndex(this ComboBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ComboBox TabStop(this ComboBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ComboBox Tag(this ComboBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ComboBox Top(this ComboBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ComboBox UseWaitCursor(this ComboBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ComboBox Visible(this ComboBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ComboBox Width(this ComboBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ComboBox WindowTarget(this ComboBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ComboBox ImeMode(this ComboBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ComboBox OnBackgroundImageChanged(this ComboBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ComboBox OnBackgroundImageLayoutChanged(this ComboBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ComboBox OnPaddingChanged(this ComboBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ComboBox OnDoubleClick(this ComboBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ComboBox OnDrawItem(this ComboBox control, DrawItemEventHandler handler)
        {
            control.DrawItem += handler;
            return control;
        }

        public static ComboBox OnDropDown(this ComboBox control, EventHandler handler)
        {
            control.DropDown += handler;
            return control;
        }

        public static ComboBox OnMeasureItem(this ComboBox control, MeasureItemEventHandler handler)
        {
            control.MeasureItem += handler;
            return control;
        }

        public static ComboBox OnSelectedIndexChanged(this ComboBox control, EventHandler handler)
        {
            control.SelectedIndexChanged += handler;
            return control;
        }

        public static ComboBox OnSelectionChangeCommitted(this ComboBox control, EventHandler handler)
        {
            control.SelectionChangeCommitted += handler;
            return control;
        }

        public static ComboBox OnDropDownStyleChanged(this ComboBox control, EventHandler handler)
        {
            control.DropDownStyleChanged += handler;
            return control;
        }

        public static ComboBox OnPaint(this ComboBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ComboBox OnTextUpdate(this ComboBox control, EventHandler handler)
        {
            control.TextUpdate += handler;
            return control;
        }

        public static ComboBox OnDropDownClosed(this ComboBox control, EventHandler handler)
        {
            control.DropDownClosed += handler;
            return control;
        }

        public static ComboBox OnDataSourceChanged(this ComboBox control, EventHandler handler)
        {
            control.DataSourceChanged += handler;
            return control;
        }

        public static ComboBox OnDisplayMemberChanged(this ComboBox control, EventHandler handler)
        {
            control.DisplayMemberChanged += handler;
            return control;
        }

        public static ComboBox OnFormat(this ComboBox control, ListControlConvertEventHandler handler)
        {
            control.Format += handler;
            return control;
        }

        public static ComboBox OnFormatInfoChanged(this ComboBox control, EventHandler handler)
        {
            control.FormatInfoChanged += handler;
            return control;
        }

        public static ComboBox OnFormatStringChanged(this ComboBox control, EventHandler handler)
        {
            control.FormatStringChanged += handler;
            return control;
        }

        public static ComboBox OnFormattingEnabledChanged(this ComboBox control, EventHandler handler)
        {
            control.FormattingEnabledChanged += handler;
            return control;
        }

        public static ComboBox OnValueMemberChanged(this ComboBox control, EventHandler handler)
        {
            control.ValueMemberChanged += handler;
            return control;
        }

        public static ComboBox OnSelectedValueChanged(this ComboBox control, EventHandler handler)
        {
            control.SelectedValueChanged += handler;
            return control;
        }

        public static ComboBox OnAutoSizeChanged(this ComboBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ComboBox OnBackColorChanged(this ComboBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ComboBox OnBindingContextChanged(this ComboBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ComboBox OnCausesValidationChanged(this ComboBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ComboBox OnClientSizeChanged(this ComboBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ComboBox OnContextMenuStripChanged(this ComboBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ComboBox OnCursorChanged(this ComboBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ComboBox OnDockChanged(this ComboBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ComboBox OnEnabledChanged(this ComboBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ComboBox OnFontChanged(this ComboBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ComboBox OnForeColorChanged(this ComboBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ComboBox OnLocationChanged(this ComboBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ComboBox OnMarginChanged(this ComboBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ComboBox OnRegionChanged(this ComboBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ComboBox OnRightToLeftChanged(this ComboBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ComboBox OnSizeChanged(this ComboBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ComboBox OnTabIndexChanged(this ComboBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ComboBox OnTabStopChanged(this ComboBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ComboBox OnTextChanged(this ComboBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ComboBox OnVisibleChanged(this ComboBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ComboBox OnClick(this ComboBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ComboBox OnControlAdded(this ComboBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ComboBox OnControlRemoved(this ComboBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ComboBox OnDataContextChanged(this ComboBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ComboBox OnDragDrop(this ComboBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ComboBox OnDragEnter(this ComboBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ComboBox OnDragOver(this ComboBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ComboBox OnDragLeave(this ComboBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ComboBox OnGiveFeedback(this ComboBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ComboBox OnHandleCreated(this ComboBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ComboBox OnHandleDestroyed(this ComboBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ComboBox OnHelpRequested(this ComboBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ComboBox OnInvalidated(this ComboBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ComboBox OnQueryContinueDrag(this ComboBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ComboBox OnQueryAccessibilityHelp(this ComboBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ComboBox OnEnter(this ComboBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ComboBox OnGotFocus(this ComboBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ComboBox OnKeyDown(this ComboBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ComboBox OnKeyPress(this ComboBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ComboBox OnKeyUp(this ComboBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ComboBox OnLayout(this ComboBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ComboBox OnLeave(this ComboBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ComboBox OnLostFocus(this ComboBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ComboBox OnMouseClick(this ComboBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ComboBox OnMouseDoubleClick(this ComboBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ComboBox OnMouseCaptureChanged(this ComboBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ComboBox OnMouseDown(this ComboBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ComboBox OnMouseEnter(this ComboBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ComboBox OnMouseLeave(this ComboBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ComboBox OnDpiChangedBeforeParent(this ComboBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ComboBox OnDpiChangedAfterParent(this ComboBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ComboBox OnMouseHover(this ComboBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ComboBox OnMouseMove(this ComboBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ComboBox OnMouseUp(this ComboBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ComboBox OnMouseWheel(this ComboBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ComboBox OnMove(this ComboBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ComboBox OnPreviewKeyDown(this ComboBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ComboBox OnResize(this ComboBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ComboBox OnChangeUICues(this ComboBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ComboBox OnStyleChanged(this ComboBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ComboBox OnSystemColorsChanged(this ComboBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ComboBox OnValidating(this ComboBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ComboBox OnValidated(this ComboBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ComboBox OnParentChanged(this ComboBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ComboBox OnImeModeChanged(this ComboBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ComboBox OnDisposed(this ComboBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ComboBox AddTo(this ComboBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class CheckedListBoxExtensions
    {
        public static CheckedListBox CheckOnClick(this CheckedListBox control, Boolean value)
        {
            control.CheckOnClick = value;
            return control;
        }

        public static CheckedListBox DataSource(this CheckedListBox control, Object value)
        {
            control.DataSource = value;
            return control;
        }

        public static CheckedListBox DisplayMember(this CheckedListBox control, String value)
        {
            control.DisplayMember = value;
            return control;
        }

        public static CheckedListBox DrawMode(this CheckedListBox control, DrawMode value)
        {
            control.DrawMode = value;
            return control;
        }

        public static CheckedListBox ItemHeight(this CheckedListBox control, Int32 value)
        {
            control.ItemHeight = value;
            return control;
        }

        public static CheckedListBox SelectionMode(this CheckedListBox control, SelectionMode value)
        {
            control.SelectionMode = value;
            return control;
        }

        public static CheckedListBox ThreeDCheckBoxes(this CheckedListBox control, Boolean value)
        {
            control.ThreeDCheckBoxes = value;
            return control;
        }

        public static CheckedListBox UseCompatibleTextRendering(this CheckedListBox control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static CheckedListBox ValueMember(this CheckedListBox control, String value)
        {
            control.ValueMember = value;
            return control;
        }

        public static CheckedListBox Padding(this CheckedListBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static CheckedListBox BackColor(this CheckedListBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static CheckedListBox BackColor(this CheckedListBox control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static CheckedListBox BackColor(this CheckedListBox control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static CheckedListBox BackgroundImage(this CheckedListBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static CheckedListBox BackgroundImageLayout(this CheckedListBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static CheckedListBox BorderStyle(this CheckedListBox control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static CheckedListBox ColumnWidth(this CheckedListBox control, Int32 value)
        {
            control.ColumnWidth = value;
            return control;
        }

        public static CheckedListBox UseCustomTabOffsets(this CheckedListBox control, Boolean value)
        {
            control.UseCustomTabOffsets = value;
            return control;
        }

        public static CheckedListBox Font(this CheckedListBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static CheckedListBox Font(this CheckedListBox control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static CheckedListBox ForeColor(this CheckedListBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static CheckedListBox ForeColor(this CheckedListBox control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static CheckedListBox ForeColor(this CheckedListBox control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static CheckedListBox HorizontalExtent(this CheckedListBox control, Int32 value)
        {
            control.HorizontalExtent = value;
            return control;
        }

        public static CheckedListBox HorizontalScrollbar(this CheckedListBox control, Boolean value)
        {
            control.HorizontalScrollbar = value;
            return control;
        }

        public static CheckedListBox IntegralHeight(this CheckedListBox control, Boolean value)
        {
            control.IntegralHeight = value;
            return control;
        }

        public static CheckedListBox MultiColumn(this CheckedListBox control, Boolean value)
        {
            control.MultiColumn = value;
            return control;
        }

        public static CheckedListBox ScrollAlwaysVisible(this CheckedListBox control, Boolean value)
        {
            control.ScrollAlwaysVisible = value;
            return control;
        }

        public static CheckedListBox SelectedIndex(this CheckedListBox control, Int32 value)
        {
            control.SelectedIndex = value;
            return control;
        }

        public static CheckedListBox SelectedItem(this CheckedListBox control, Object value)
        {
            control.SelectedItem = value;
            return control;
        }

        public static CheckedListBox Sorted(this CheckedListBox control, Boolean value)
        {
            control.Sorted = value;
            return control;
        }

        public static CheckedListBox Text(this CheckedListBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static CheckedListBox TopIndex(this CheckedListBox control, Int32 value)
        {
            control.TopIndex = value;
            return control;
        }

        public static CheckedListBox UseTabStops(this CheckedListBox control, Boolean value)
        {
            control.UseTabStops = value;
            return control;
        }

        public static CheckedListBox FormatInfo(this CheckedListBox control, IFormatProvider value)
        {
            control.FormatInfo = value;
            return control;
        }

        public static CheckedListBox FormatString(this CheckedListBox control, String value)
        {
            control.FormatString = value;
            return control;
        }

        public static CheckedListBox FormattingEnabled(this CheckedListBox control, Boolean value)
        {
            control.FormattingEnabled = value;
            return control;
        }

        public static CheckedListBox SelectedValue(this CheckedListBox control, Object value)
        {
            control.SelectedValue = value;
            return control;
        }

        public static CheckedListBox AccessibleDefaultActionDescription(this CheckedListBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static CheckedListBox AccessibleDescription(this CheckedListBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static CheckedListBox AccessibleName(this CheckedListBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static CheckedListBox AccessibleRole(this CheckedListBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static CheckedListBox AllowDrop(this CheckedListBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static CheckedListBox Anchor(this CheckedListBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static CheckedListBox AutoSize(this CheckedListBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static CheckedListBox AutoScrollOffset(this CheckedListBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static CheckedListBox AutoScrollOffset(this CheckedListBox control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static CheckedListBox DataContext(this CheckedListBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static CheckedListBox BindingContext(this CheckedListBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static CheckedListBox Bounds(this CheckedListBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static CheckedListBox Bounds(this CheckedListBox control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static CheckedListBox Bounds(this CheckedListBox control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static CheckedListBox Capture(this CheckedListBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static CheckedListBox CausesValidation(this CheckedListBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static CheckedListBox ClientSize(this CheckedListBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static CheckedListBox ClientSize(this CheckedListBox control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static CheckedListBox ContextMenuStrip(this CheckedListBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static CheckedListBox Cursor(this CheckedListBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static CheckedListBox Dock(this CheckedListBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static CheckedListBox Enabled(this CheckedListBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static CheckedListBox Height(this CheckedListBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static CheckedListBox IsAccessible(this CheckedListBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static CheckedListBox Left(this CheckedListBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static CheckedListBox Location(this CheckedListBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static CheckedListBox Location(this CheckedListBox control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static CheckedListBox Margin(this CheckedListBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static CheckedListBox MaximumSize(this CheckedListBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static CheckedListBox MaximumSize(this CheckedListBox control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static CheckedListBox MinimumSize(this CheckedListBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static CheckedListBox MinimumSize(this CheckedListBox control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static CheckedListBox Name(this CheckedListBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static CheckedListBox Parent(this CheckedListBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static CheckedListBox Region(this CheckedListBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static CheckedListBox RightToLeft(this CheckedListBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static CheckedListBox Size(this CheckedListBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static CheckedListBox Size(this CheckedListBox control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static CheckedListBox TabIndex(this CheckedListBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static CheckedListBox TabStop(this CheckedListBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static CheckedListBox Tag(this CheckedListBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static CheckedListBox Top(this CheckedListBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static CheckedListBox UseWaitCursor(this CheckedListBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static CheckedListBox Visible(this CheckedListBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static CheckedListBox Width(this CheckedListBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static CheckedListBox WindowTarget(this CheckedListBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static CheckedListBox ImeMode(this CheckedListBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static CheckedListBox OnDataSourceChanged(this CheckedListBox control, EventHandler handler)
        {
            control.DataSourceChanged += handler;
            return control;
        }

        public static CheckedListBox OnDisplayMemberChanged(this CheckedListBox control, EventHandler handler)
        {
            control.DisplayMemberChanged += handler;
            return control;
        }

        public static CheckedListBox OnItemCheck(this CheckedListBox control, ItemCheckEventHandler handler)
        {
            control.ItemCheck += handler;
            return control;
        }

        public static CheckedListBox OnClick(this CheckedListBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static CheckedListBox OnMouseClick(this CheckedListBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static CheckedListBox OnDrawItem(this CheckedListBox control, DrawItemEventHandler handler)
        {
            control.DrawItem += handler;
            return control;
        }

        public static CheckedListBox OnMeasureItem(this CheckedListBox control, MeasureItemEventHandler handler)
        {
            control.MeasureItem += handler;
            return control;
        }

        public static CheckedListBox OnValueMemberChanged(this CheckedListBox control, EventHandler handler)
        {
            control.ValueMemberChanged += handler;
            return control;
        }

        public static CheckedListBox OnBackgroundImageChanged(this CheckedListBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static CheckedListBox OnBackgroundImageLayoutChanged(this CheckedListBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static CheckedListBox OnTextChanged(this CheckedListBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static CheckedListBox OnPaddingChanged(this CheckedListBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static CheckedListBox OnPaint(this CheckedListBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static CheckedListBox OnSelectedIndexChanged(this CheckedListBox control, EventHandler handler)
        {
            control.SelectedIndexChanged += handler;
            return control;
        }

        public static CheckedListBox OnFormat(this CheckedListBox control, ListControlConvertEventHandler handler)
        {
            control.Format += handler;
            return control;
        }

        public static CheckedListBox OnFormatInfoChanged(this CheckedListBox control, EventHandler handler)
        {
            control.FormatInfoChanged += handler;
            return control;
        }

        public static CheckedListBox OnFormatStringChanged(this CheckedListBox control, EventHandler handler)
        {
            control.FormatStringChanged += handler;
            return control;
        }

        public static CheckedListBox OnFormattingEnabledChanged(this CheckedListBox control, EventHandler handler)
        {
            control.FormattingEnabledChanged += handler;
            return control;
        }

        public static CheckedListBox OnSelectedValueChanged(this CheckedListBox control, EventHandler handler)
        {
            control.SelectedValueChanged += handler;
            return control;
        }

        public static CheckedListBox OnAutoSizeChanged(this CheckedListBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static CheckedListBox OnBackColorChanged(this CheckedListBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static CheckedListBox OnBindingContextChanged(this CheckedListBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static CheckedListBox OnCausesValidationChanged(this CheckedListBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static CheckedListBox OnClientSizeChanged(this CheckedListBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static CheckedListBox OnContextMenuStripChanged(this CheckedListBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static CheckedListBox OnCursorChanged(this CheckedListBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static CheckedListBox OnDockChanged(this CheckedListBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static CheckedListBox OnEnabledChanged(this CheckedListBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static CheckedListBox OnFontChanged(this CheckedListBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static CheckedListBox OnForeColorChanged(this CheckedListBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static CheckedListBox OnLocationChanged(this CheckedListBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static CheckedListBox OnMarginChanged(this CheckedListBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static CheckedListBox OnRegionChanged(this CheckedListBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static CheckedListBox OnRightToLeftChanged(this CheckedListBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static CheckedListBox OnSizeChanged(this CheckedListBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static CheckedListBox OnTabIndexChanged(this CheckedListBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static CheckedListBox OnTabStopChanged(this CheckedListBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static CheckedListBox OnVisibleChanged(this CheckedListBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static CheckedListBox OnControlAdded(this CheckedListBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static CheckedListBox OnControlRemoved(this CheckedListBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static CheckedListBox OnDataContextChanged(this CheckedListBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static CheckedListBox OnDragDrop(this CheckedListBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static CheckedListBox OnDragEnter(this CheckedListBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static CheckedListBox OnDragOver(this CheckedListBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static CheckedListBox OnDragLeave(this CheckedListBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static CheckedListBox OnGiveFeedback(this CheckedListBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static CheckedListBox OnHandleCreated(this CheckedListBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static CheckedListBox OnHandleDestroyed(this CheckedListBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static CheckedListBox OnHelpRequested(this CheckedListBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static CheckedListBox OnInvalidated(this CheckedListBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static CheckedListBox OnQueryContinueDrag(this CheckedListBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static CheckedListBox OnQueryAccessibilityHelp(this CheckedListBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static CheckedListBox OnDoubleClick(this CheckedListBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static CheckedListBox OnEnter(this CheckedListBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static CheckedListBox OnGotFocus(this CheckedListBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static CheckedListBox OnKeyDown(this CheckedListBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static CheckedListBox OnKeyPress(this CheckedListBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static CheckedListBox OnKeyUp(this CheckedListBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static CheckedListBox OnLayout(this CheckedListBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static CheckedListBox OnLeave(this CheckedListBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static CheckedListBox OnLostFocus(this CheckedListBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static CheckedListBox OnMouseDoubleClick(this CheckedListBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static CheckedListBox OnMouseCaptureChanged(this CheckedListBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static CheckedListBox OnMouseDown(this CheckedListBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static CheckedListBox OnMouseEnter(this CheckedListBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static CheckedListBox OnMouseLeave(this CheckedListBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static CheckedListBox OnDpiChangedBeforeParent(this CheckedListBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static CheckedListBox OnDpiChangedAfterParent(this CheckedListBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static CheckedListBox OnMouseHover(this CheckedListBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static CheckedListBox OnMouseMove(this CheckedListBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static CheckedListBox OnMouseUp(this CheckedListBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static CheckedListBox OnMouseWheel(this CheckedListBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static CheckedListBox OnMove(this CheckedListBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static CheckedListBox OnPreviewKeyDown(this CheckedListBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static CheckedListBox OnResize(this CheckedListBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static CheckedListBox OnChangeUICues(this CheckedListBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static CheckedListBox OnStyleChanged(this CheckedListBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static CheckedListBox OnSystemColorsChanged(this CheckedListBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static CheckedListBox OnValidating(this CheckedListBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static CheckedListBox OnValidated(this CheckedListBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static CheckedListBox OnParentChanged(this CheckedListBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static CheckedListBox OnImeModeChanged(this CheckedListBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static CheckedListBox OnDisposed(this CheckedListBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static CheckedListBox AddTo(this CheckedListBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static CheckedListBox Assign(this CheckedListBox control, out CheckedListBox variable)
        {
            variable = control;
            return control;
        }

    }
}

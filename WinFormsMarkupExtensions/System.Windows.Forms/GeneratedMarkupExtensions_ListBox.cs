using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ListBoxExtensions
    {
        public static ListBox BackColor(this ListBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ListBox BackColor(this ListBox control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ListBox BackColor(this ListBox control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ListBox BackgroundImage(this ListBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ListBox BackgroundImageLayout(this ListBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ListBox BorderStyle(this ListBox control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static ListBox ColumnWidth(this ListBox control, Int32 value)
        {
            control.ColumnWidth = value;
            return control;
        }

        public static ListBox UseCustomTabOffsets(this ListBox control, Boolean value)
        {
            control.UseCustomTabOffsets = value;
            return control;
        }

        public static ListBox DrawMode(this ListBox control, DrawMode value)
        {
            control.DrawMode = value;
            return control;
        }

        public static ListBox Font(this ListBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ListBox Font(this ListBox control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ListBox ForeColor(this ListBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ListBox ForeColor(this ListBox control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ListBox ForeColor(this ListBox control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ListBox HorizontalExtent(this ListBox control, Int32 value)
        {
            control.HorizontalExtent = value;
            return control;
        }

        public static ListBox HorizontalScrollbar(this ListBox control, Boolean value)
        {
            control.HorizontalScrollbar = value;
            return control;
        }

        public static ListBox IntegralHeight(this ListBox control, Boolean value)
        {
            control.IntegralHeight = value;
            return control;
        }

        public static ListBox ItemHeight(this ListBox control, Int32 value)
        {
            control.ItemHeight = value;
            return control;
        }

        public static ListBox MultiColumn(this ListBox control, Boolean value)
        {
            control.MultiColumn = value;
            return control;
        }

        public static ListBox ScrollAlwaysVisible(this ListBox control, Boolean value)
        {
            control.ScrollAlwaysVisible = value;
            return control;
        }

        public static ListBox SelectedIndex(this ListBox control, Int32 value)
        {
            control.SelectedIndex = value;
            return control;
        }

        public static ListBox SelectedItem(this ListBox control, Object value)
        {
            control.SelectedItem = value;
            return control;
        }

        public static ListBox SelectionMode(this ListBox control, SelectionMode value)
        {
            control.SelectionMode = value;
            return control;
        }

        public static ListBox Sorted(this ListBox control, Boolean value)
        {
            control.Sorted = value;
            return control;
        }

        public static ListBox Text(this ListBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ListBox TopIndex(this ListBox control, Int32 value)
        {
            control.TopIndex = value;
            return control;
        }

        public static ListBox UseTabStops(this ListBox control, Boolean value)
        {
            control.UseTabStops = value;
            return control;
        }

        public static ListBox Padding(this ListBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ListBox DataSource(this ListBox control, Object value)
        {
            control.DataSource = value;
            return control;
        }

        public static ListBox DisplayMember(this ListBox control, String value)
        {
            control.DisplayMember = value;
            return control;
        }

        public static ListBox FormatInfo(this ListBox control, IFormatProvider value)
        {
            control.FormatInfo = value;
            return control;
        }

        public static ListBox FormatString(this ListBox control, String value)
        {
            control.FormatString = value;
            return control;
        }

        public static ListBox FormattingEnabled(this ListBox control, Boolean value)
        {
            control.FormattingEnabled = value;
            return control;
        }

        public static ListBox ValueMember(this ListBox control, String value)
        {
            control.ValueMember = value;
            return control;
        }

        public static ListBox SelectedValue(this ListBox control, Object value)
        {
            control.SelectedValue = value;
            return control;
        }

        public static ListBox AccessibleDefaultActionDescription(this ListBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ListBox AccessibleDescription(this ListBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ListBox AccessibleName(this ListBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ListBox AccessibleRole(this ListBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ListBox AllowDrop(this ListBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ListBox Anchor(this ListBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ListBox AutoSize(this ListBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ListBox AutoScrollOffset(this ListBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ListBox AutoScrollOffset(this ListBox control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ListBox DataContext(this ListBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ListBox BindingContext(this ListBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ListBox Bounds(this ListBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ListBox Bounds(this ListBox control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ListBox Bounds(this ListBox control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ListBox Capture(this ListBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ListBox CausesValidation(this ListBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ListBox ClientSize(this ListBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ListBox ClientSize(this ListBox control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ListBox ContextMenuStrip(this ListBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ListBox Cursor(this ListBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ListBox Dock(this ListBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ListBox Enabled(this ListBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ListBox Height(this ListBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ListBox IsAccessible(this ListBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ListBox Left(this ListBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ListBox Location(this ListBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ListBox Location(this ListBox control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ListBox Margin(this ListBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ListBox MaximumSize(this ListBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ListBox MaximumSize(this ListBox control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ListBox MinimumSize(this ListBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ListBox MinimumSize(this ListBox control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ListBox Name(this ListBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ListBox Parent(this ListBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ListBox Region(this ListBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ListBox RightToLeft(this ListBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ListBox Size(this ListBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ListBox Size(this ListBox control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ListBox TabIndex(this ListBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ListBox TabStop(this ListBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ListBox Tag(this ListBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ListBox Top(this ListBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ListBox UseWaitCursor(this ListBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ListBox Visible(this ListBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ListBox Width(this ListBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ListBox WindowTarget(this ListBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ListBox ImeMode(this ListBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ListBox OnBackgroundImageChanged(this ListBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ListBox OnBackgroundImageLayoutChanged(this ListBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ListBox OnTextChanged(this ListBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ListBox OnClick(this ListBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ListBox OnMouseClick(this ListBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ListBox OnPaddingChanged(this ListBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ListBox OnPaint(this ListBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ListBox OnDrawItem(this ListBox control, DrawItemEventHandler handler)
        {
            control.DrawItem += handler;
            return control;
        }

        public static ListBox OnMeasureItem(this ListBox control, MeasureItemEventHandler handler)
        {
            control.MeasureItem += handler;
            return control;
        }

        public static ListBox OnSelectedIndexChanged(this ListBox control, EventHandler handler)
        {
            control.SelectedIndexChanged += handler;
            return control;
        }

        public static ListBox OnDataSourceChanged(this ListBox control, EventHandler handler)
        {
            control.DataSourceChanged += handler;
            return control;
        }

        public static ListBox OnDisplayMemberChanged(this ListBox control, EventHandler handler)
        {
            control.DisplayMemberChanged += handler;
            return control;
        }

        public static ListBox OnFormat(this ListBox control, ListControlConvertEventHandler handler)
        {
            control.Format += handler;
            return control;
        }

        public static ListBox OnFormatInfoChanged(this ListBox control, EventHandler handler)
        {
            control.FormatInfoChanged += handler;
            return control;
        }

        public static ListBox OnFormatStringChanged(this ListBox control, EventHandler handler)
        {
            control.FormatStringChanged += handler;
            return control;
        }

        public static ListBox OnFormattingEnabledChanged(this ListBox control, EventHandler handler)
        {
            control.FormattingEnabledChanged += handler;
            return control;
        }

        public static ListBox OnValueMemberChanged(this ListBox control, EventHandler handler)
        {
            control.ValueMemberChanged += handler;
            return control;
        }

        public static ListBox OnSelectedValueChanged(this ListBox control, EventHandler handler)
        {
            control.SelectedValueChanged += handler;
            return control;
        }

        public static ListBox OnAutoSizeChanged(this ListBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ListBox OnBackColorChanged(this ListBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ListBox OnBindingContextChanged(this ListBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ListBox OnCausesValidationChanged(this ListBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ListBox OnClientSizeChanged(this ListBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ListBox OnContextMenuStripChanged(this ListBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ListBox OnCursorChanged(this ListBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ListBox OnDockChanged(this ListBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ListBox OnEnabledChanged(this ListBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ListBox OnFontChanged(this ListBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ListBox OnForeColorChanged(this ListBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ListBox OnLocationChanged(this ListBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ListBox OnMarginChanged(this ListBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ListBox OnRegionChanged(this ListBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ListBox OnRightToLeftChanged(this ListBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ListBox OnSizeChanged(this ListBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ListBox OnTabIndexChanged(this ListBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ListBox OnTabStopChanged(this ListBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ListBox OnVisibleChanged(this ListBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ListBox OnControlAdded(this ListBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ListBox OnControlRemoved(this ListBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ListBox OnDataContextChanged(this ListBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ListBox OnDragDrop(this ListBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ListBox OnDragEnter(this ListBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ListBox OnDragOver(this ListBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ListBox OnDragLeave(this ListBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ListBox OnGiveFeedback(this ListBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ListBox OnHandleCreated(this ListBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ListBox OnHandleDestroyed(this ListBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ListBox OnHelpRequested(this ListBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ListBox OnInvalidated(this ListBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ListBox OnQueryContinueDrag(this ListBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ListBox OnQueryAccessibilityHelp(this ListBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ListBox OnDoubleClick(this ListBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ListBox OnEnter(this ListBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ListBox OnGotFocus(this ListBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ListBox OnKeyDown(this ListBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ListBox OnKeyPress(this ListBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ListBox OnKeyUp(this ListBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ListBox OnLayout(this ListBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ListBox OnLeave(this ListBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ListBox OnLostFocus(this ListBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ListBox OnMouseDoubleClick(this ListBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ListBox OnMouseCaptureChanged(this ListBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ListBox OnMouseDown(this ListBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ListBox OnMouseEnter(this ListBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ListBox OnMouseLeave(this ListBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ListBox OnDpiChangedBeforeParent(this ListBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ListBox OnDpiChangedAfterParent(this ListBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ListBox OnMouseHover(this ListBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ListBox OnMouseMove(this ListBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ListBox OnMouseUp(this ListBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ListBox OnMouseWheel(this ListBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ListBox OnMove(this ListBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ListBox OnPreviewKeyDown(this ListBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ListBox OnResize(this ListBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ListBox OnChangeUICues(this ListBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ListBox OnStyleChanged(this ListBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ListBox OnSystemColorsChanged(this ListBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ListBox OnValidating(this ListBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ListBox OnValidated(this ListBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ListBox OnParentChanged(this ListBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ListBox OnImeModeChanged(this ListBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ListBox OnDisposed(this ListBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ListBox AddTo(this ListBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ListBox Assign(this ListBox control, out ListBox variable)
        {
            variable = control;
            return control;
        }

    }
}

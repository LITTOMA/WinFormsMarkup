using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class DateTimePickerExtensions
    {
        public static DateTimePicker BackColor(this DateTimePicker control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DateTimePicker BackgroundImage(this DateTimePicker control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static DateTimePicker BackgroundImageLayout(this DateTimePicker control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static DateTimePicker CalendarForeColor(this DateTimePicker control, int red, int green, int blue)
        {
            control.CalendarForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DateTimePicker CalendarFont(this DateTimePicker control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.CalendarFont = new Font(familyName, emSize, style);
            return control;
        }

        public static DateTimePicker CalendarTitleBackColor(this DateTimePicker control, int red, int green, int blue)
        {
            control.CalendarTitleBackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DateTimePicker CalendarTitleForeColor(this DateTimePicker control, int red, int green, int blue)
        {
            control.CalendarTitleForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DateTimePicker CalendarTrailingForeColor(this DateTimePicker control, int red, int green, int blue)
        {
            control.CalendarTrailingForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DateTimePicker CalendarMonthBackground(this DateTimePicker control, int red, int green, int blue)
        {
            control.CalendarMonthBackground = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DateTimePicker Checked(this DateTimePicker control, Boolean value)
        {
            control.Checked = value;
            return control;
        }

        public static DateTimePicker CustomFormat(this DateTimePicker control, String value)
        {
            control.CustomFormat = value;
            return control;
        }

        public static DateTimePicker DropDownAlign(this DateTimePicker control, LeftRightAlignment value)
        {
            control.DropDownAlign = value;
            return control;
        }

        public static DateTimePicker ForeColor(this DateTimePicker control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DateTimePicker Format(this DateTimePicker control, DateTimePickerFormat value)
        {
            control.Format = value;
            return control;
        }

        public static DateTimePicker MaxDate(this DateTimePicker control, DateTime value)
        {
            control.MaxDate = value;
            return control;
        }

        public static DateTimePicker MinDate(this DateTimePicker control, DateTime value)
        {
            control.MinDate = value;
            return control;
        }

        public static DateTimePicker Padding(this DateTimePicker control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static DateTimePicker RightToLeftLayout(this DateTimePicker control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static DateTimePicker ShowCheckBox(this DateTimePicker control, Boolean value)
        {
            control.ShowCheckBox = value;
            return control;
        }

        public static DateTimePicker ShowUpDown(this DateTimePicker control, Boolean value)
        {
            control.ShowUpDown = value;
            return control;
        }

        public static DateTimePicker Text(this DateTimePicker control, String value)
        {
            control.Text = value;
            return control;
        }

        public static DateTimePicker Value(this DateTimePicker control, DateTime value)
        {
            control.Value = value;
            return control;
        }

        public static DateTimePicker AccessibleDefaultActionDescription(this DateTimePicker control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static DateTimePicker AccessibleDescription(this DateTimePicker control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static DateTimePicker AccessibleName(this DateTimePicker control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static DateTimePicker AccessibleRole(this DateTimePicker control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static DateTimePicker AllowDrop(this DateTimePicker control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static DateTimePicker Anchor(this DateTimePicker control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static DateTimePicker AutoSize(this DateTimePicker control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static DateTimePicker AutoScrollOffset(this DateTimePicker control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static DateTimePicker DataContext(this DateTimePicker control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static DateTimePicker BindingContext(this DateTimePicker control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static DateTimePicker Bounds(this DateTimePicker control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static DateTimePicker Capture(this DateTimePicker control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static DateTimePicker CausesValidation(this DateTimePicker control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static DateTimePicker ClientSize(this DateTimePicker control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static DateTimePicker ContextMenuStrip(this DateTimePicker control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static DateTimePicker Cursor(this DateTimePicker control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static DateTimePicker Dock(this DateTimePicker control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static DateTimePicker Enabled(this DateTimePicker control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static DateTimePicker Font(this DateTimePicker control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static DateTimePicker Height(this DateTimePicker control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static DateTimePicker IsAccessible(this DateTimePicker control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static DateTimePicker Left(this DateTimePicker control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static DateTimePicker Location(this DateTimePicker control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static DateTimePicker Margin(this DateTimePicker control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static DateTimePicker MaximumSize(this DateTimePicker control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static DateTimePicker MinimumSize(this DateTimePicker control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static DateTimePicker Name(this DateTimePicker control, String value)
        {
            control.Name = value;
            return control;
        }

        public static DateTimePicker Parent(this DateTimePicker control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static DateTimePicker Region(this DateTimePicker control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static DateTimePicker RightToLeft(this DateTimePicker control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static DateTimePicker Size(this DateTimePicker control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static DateTimePicker TabIndex(this DateTimePicker control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static DateTimePicker TabStop(this DateTimePicker control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static DateTimePicker Tag(this DateTimePicker control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static DateTimePicker Top(this DateTimePicker control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static DateTimePicker UseWaitCursor(this DateTimePicker control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static DateTimePicker Visible(this DateTimePicker control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static DateTimePicker Width(this DateTimePicker control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static DateTimePicker WindowTarget(this DateTimePicker control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static DateTimePicker ImeMode(this DateTimePicker control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static DateTimePicker OnBackColorChanged(this DateTimePicker control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static DateTimePicker OnBackgroundImageChanged(this DateTimePicker control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static DateTimePicker OnBackgroundImageLayoutChanged(this DateTimePicker control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static DateTimePicker OnClick(this DateTimePicker control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static DateTimePicker OnDoubleClick(this DateTimePicker control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static DateTimePicker OnForeColorChanged(this DateTimePicker control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static DateTimePicker OnFormatChanged(this DateTimePicker control, EventHandler handler)
        {
            control.FormatChanged += handler;
            return control;
        }

        public static DateTimePicker OnPaint(this DateTimePicker control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static DateTimePicker OnMouseClick(this DateTimePicker control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static DateTimePicker OnMouseDoubleClick(this DateTimePicker control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static DateTimePicker OnPaddingChanged(this DateTimePicker control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static DateTimePicker OnTextChanged(this DateTimePicker control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static DateTimePicker OnCloseUp(this DateTimePicker control, EventHandler handler)
        {
            control.CloseUp += handler;
            return control;
        }

        public static DateTimePicker OnRightToLeftLayoutChanged(this DateTimePicker control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static DateTimePicker OnValueChanged(this DateTimePicker control, EventHandler handler)
        {
            control.ValueChanged += handler;
            return control;
        }

        public static DateTimePicker OnDropDown(this DateTimePicker control, EventHandler handler)
        {
            control.DropDown += handler;
            return control;
        }

        public static DateTimePicker OnAutoSizeChanged(this DateTimePicker control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static DateTimePicker OnBindingContextChanged(this DateTimePicker control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static DateTimePicker OnCausesValidationChanged(this DateTimePicker control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static DateTimePicker OnClientSizeChanged(this DateTimePicker control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static DateTimePicker OnContextMenuStripChanged(this DateTimePicker control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static DateTimePicker OnCursorChanged(this DateTimePicker control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static DateTimePicker OnDockChanged(this DateTimePicker control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static DateTimePicker OnEnabledChanged(this DateTimePicker control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static DateTimePicker OnFontChanged(this DateTimePicker control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static DateTimePicker OnLocationChanged(this DateTimePicker control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static DateTimePicker OnMarginChanged(this DateTimePicker control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static DateTimePicker OnRegionChanged(this DateTimePicker control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static DateTimePicker OnRightToLeftChanged(this DateTimePicker control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static DateTimePicker OnSizeChanged(this DateTimePicker control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static DateTimePicker OnTabIndexChanged(this DateTimePicker control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static DateTimePicker OnTabStopChanged(this DateTimePicker control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static DateTimePicker OnVisibleChanged(this DateTimePicker control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static DateTimePicker OnControlAdded(this DateTimePicker control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static DateTimePicker OnControlRemoved(this DateTimePicker control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static DateTimePicker OnDataContextChanged(this DateTimePicker control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static DateTimePicker OnDragDrop(this DateTimePicker control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static DateTimePicker OnDragEnter(this DateTimePicker control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static DateTimePicker OnDragOver(this DateTimePicker control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static DateTimePicker OnDragLeave(this DateTimePicker control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static DateTimePicker OnGiveFeedback(this DateTimePicker control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static DateTimePicker OnHandleCreated(this DateTimePicker control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static DateTimePicker OnHandleDestroyed(this DateTimePicker control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static DateTimePicker OnHelpRequested(this DateTimePicker control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static DateTimePicker OnInvalidated(this DateTimePicker control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static DateTimePicker OnQueryContinueDrag(this DateTimePicker control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static DateTimePicker OnQueryAccessibilityHelp(this DateTimePicker control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static DateTimePicker OnEnter(this DateTimePicker control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static DateTimePicker OnGotFocus(this DateTimePicker control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static DateTimePicker OnKeyDown(this DateTimePicker control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static DateTimePicker OnKeyPress(this DateTimePicker control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static DateTimePicker OnKeyUp(this DateTimePicker control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static DateTimePicker OnLayout(this DateTimePicker control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static DateTimePicker OnLeave(this DateTimePicker control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static DateTimePicker OnLostFocus(this DateTimePicker control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static DateTimePicker OnMouseCaptureChanged(this DateTimePicker control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static DateTimePicker OnMouseDown(this DateTimePicker control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static DateTimePicker OnMouseEnter(this DateTimePicker control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static DateTimePicker OnMouseLeave(this DateTimePicker control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static DateTimePicker OnDpiChangedBeforeParent(this DateTimePicker control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static DateTimePicker OnDpiChangedAfterParent(this DateTimePicker control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static DateTimePicker OnMouseHover(this DateTimePicker control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static DateTimePicker OnMouseMove(this DateTimePicker control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static DateTimePicker OnMouseUp(this DateTimePicker control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static DateTimePicker OnMouseWheel(this DateTimePicker control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static DateTimePicker OnMove(this DateTimePicker control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static DateTimePicker OnPreviewKeyDown(this DateTimePicker control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static DateTimePicker OnResize(this DateTimePicker control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static DateTimePicker OnChangeUICues(this DateTimePicker control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static DateTimePicker OnStyleChanged(this DateTimePicker control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static DateTimePicker OnSystemColorsChanged(this DateTimePicker control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static DateTimePicker OnValidating(this DateTimePicker control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static DateTimePicker OnValidated(this DateTimePicker control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static DateTimePicker OnParentChanged(this DateTimePicker control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static DateTimePicker OnImeModeChanged(this DateTimePicker control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static DateTimePicker OnDisposed(this DateTimePicker control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static DateTimePicker AddTo(this DateTimePicker control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

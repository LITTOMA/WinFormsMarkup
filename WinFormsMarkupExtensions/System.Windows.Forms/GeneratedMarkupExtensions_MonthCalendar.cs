using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class MonthCalendarExtensions
    {
        public static MonthCalendar AnnuallyBoldedDates(this MonthCalendar control, DateTime[] value)
        {
            control.AnnuallyBoldedDates = value;
            return control;
        }

        public static MonthCalendar BackColor(this MonthCalendar control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MonthCalendar BackColor(this MonthCalendar control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MonthCalendar BackColor(this MonthCalendar control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static MonthCalendar BackgroundImage(this MonthCalendar control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static MonthCalendar BackgroundImageLayout(this MonthCalendar control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static MonthCalendar BoldedDates(this MonthCalendar control, DateTime[] value)
        {
            control.BoldedDates = value;
            return control;
        }

        public static MonthCalendar CalendarDimensions(this MonthCalendar control, int width, int height)
        {
            control.CalendarDimensions = new Size(width, height);
            return control;
        }

        public static MonthCalendar CalendarDimensions(this MonthCalendar control, Size size)
        {
            control.CalendarDimensions = size;
            return control;
        }

        public static MonthCalendar FirstDayOfWeek(this MonthCalendar control, Day value)
        {
            control.FirstDayOfWeek = value;
            return control;
        }

        public static MonthCalendar ForeColor(this MonthCalendar control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MonthCalendar ForeColor(this MonthCalendar control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MonthCalendar ForeColor(this MonthCalendar control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static MonthCalendar ImeMode(this MonthCalendar control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static MonthCalendar MaxDate(this MonthCalendar control, DateTime value)
        {
            control.MaxDate = value;
            return control;
        }

        public static MonthCalendar MaxSelectionCount(this MonthCalendar control, Int32 value)
        {
            control.MaxSelectionCount = value;
            return control;
        }

        public static MonthCalendar MinDate(this MonthCalendar control, DateTime value)
        {
            control.MinDate = value;
            return control;
        }

        public static MonthCalendar MonthlyBoldedDates(this MonthCalendar control, DateTime[] value)
        {
            control.MonthlyBoldedDates = value;
            return control;
        }

        public static MonthCalendar Padding(this MonthCalendar control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static MonthCalendar RightToLeftLayout(this MonthCalendar control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static MonthCalendar ScrollChange(this MonthCalendar control, Int32 value)
        {
            control.ScrollChange = value;
            return control;
        }

        public static MonthCalendar SelectionEnd(this MonthCalendar control, DateTime value)
        {
            control.SelectionEnd = value;
            return control;
        }

        public static MonthCalendar SelectionStart(this MonthCalendar control, DateTime value)
        {
            control.SelectionStart = value;
            return control;
        }

        public static MonthCalendar SelectionRange(this MonthCalendar control, SelectionRange value)
        {
            control.SelectionRange = value;
            return control;
        }

        public static MonthCalendar ShowToday(this MonthCalendar control, Boolean value)
        {
            control.ShowToday = value;
            return control;
        }

        public static MonthCalendar ShowTodayCircle(this MonthCalendar control, Boolean value)
        {
            control.ShowTodayCircle = value;
            return control;
        }

        public static MonthCalendar ShowWeekNumbers(this MonthCalendar control, Boolean value)
        {
            control.ShowWeekNumbers = value;
            return control;
        }

        public static MonthCalendar Size(this MonthCalendar control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static MonthCalendar Size(this MonthCalendar control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static MonthCalendar Text(this MonthCalendar control, String value)
        {
            control.Text = value;
            return control;
        }

        public static MonthCalendar TodayDate(this MonthCalendar control, DateTime value)
        {
            control.TodayDate = value;
            return control;
        }

        public static MonthCalendar TitleBackColor(this MonthCalendar control, int red, int green, int blue)
        {
            control.TitleBackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MonthCalendar TitleBackColor(this MonthCalendar control, int red, int green, int blue, int alpha)
        {
            control.TitleBackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MonthCalendar TitleBackColor(this MonthCalendar control, Color color)
        {
            control.TitleBackColor = color;
            return control;
        }

        public static MonthCalendar TitleForeColor(this MonthCalendar control, int red, int green, int blue)
        {
            control.TitleForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MonthCalendar TitleForeColor(this MonthCalendar control, int red, int green, int blue, int alpha)
        {
            control.TitleForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MonthCalendar TitleForeColor(this MonthCalendar control, Color color)
        {
            control.TitleForeColor = color;
            return control;
        }

        public static MonthCalendar TrailingForeColor(this MonthCalendar control, int red, int green, int blue)
        {
            control.TrailingForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MonthCalendar TrailingForeColor(this MonthCalendar control, int red, int green, int blue, int alpha)
        {
            control.TrailingForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static MonthCalendar TrailingForeColor(this MonthCalendar control, Color color)
        {
            control.TrailingForeColor = color;
            return control;
        }

        public static MonthCalendar AccessibleDefaultActionDescription(this MonthCalendar control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static MonthCalendar AccessibleDescription(this MonthCalendar control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static MonthCalendar AccessibleName(this MonthCalendar control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static MonthCalendar AccessibleRole(this MonthCalendar control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static MonthCalendar AllowDrop(this MonthCalendar control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static MonthCalendar Anchor(this MonthCalendar control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static MonthCalendar AutoSize(this MonthCalendar control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static MonthCalendar AutoScrollOffset(this MonthCalendar control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static MonthCalendar AutoScrollOffset(this MonthCalendar control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static MonthCalendar DataContext(this MonthCalendar control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static MonthCalendar BindingContext(this MonthCalendar control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static MonthCalendar Bounds(this MonthCalendar control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static MonthCalendar Bounds(this MonthCalendar control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static MonthCalendar Bounds(this MonthCalendar control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static MonthCalendar Capture(this MonthCalendar control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static MonthCalendar CausesValidation(this MonthCalendar control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static MonthCalendar ClientSize(this MonthCalendar control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static MonthCalendar ClientSize(this MonthCalendar control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static MonthCalendar ContextMenuStrip(this MonthCalendar control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static MonthCalendar Cursor(this MonthCalendar control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static MonthCalendar Dock(this MonthCalendar control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static MonthCalendar Enabled(this MonthCalendar control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static MonthCalendar Font(this MonthCalendar control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static MonthCalendar Font(this MonthCalendar control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static MonthCalendar Height(this MonthCalendar control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static MonthCalendar IsAccessible(this MonthCalendar control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static MonthCalendar Left(this MonthCalendar control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static MonthCalendar Location(this MonthCalendar control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static MonthCalendar Location(this MonthCalendar control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static MonthCalendar Margin(this MonthCalendar control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static MonthCalendar MaximumSize(this MonthCalendar control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static MonthCalendar MaximumSize(this MonthCalendar control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static MonthCalendar MinimumSize(this MonthCalendar control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static MonthCalendar MinimumSize(this MonthCalendar control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static MonthCalendar Name(this MonthCalendar control, String value)
        {
            control.Name = value;
            return control;
        }

        public static MonthCalendar Parent(this MonthCalendar control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static MonthCalendar Region(this MonthCalendar control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static MonthCalendar RightToLeft(this MonthCalendar control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static MonthCalendar TabIndex(this MonthCalendar control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static MonthCalendar TabStop(this MonthCalendar control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static MonthCalendar Tag(this MonthCalendar control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static MonthCalendar Top(this MonthCalendar control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static MonthCalendar UseWaitCursor(this MonthCalendar control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static MonthCalendar Visible(this MonthCalendar control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static MonthCalendar Width(this MonthCalendar control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static MonthCalendar WindowTarget(this MonthCalendar control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static MonthCalendar OnBackgroundImageChanged(this MonthCalendar control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static MonthCalendar OnBackgroundImageLayoutChanged(this MonthCalendar control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static MonthCalendar OnImeModeChanged(this MonthCalendar control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static MonthCalendar OnPaddingChanged(this MonthCalendar control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static MonthCalendar OnTextChanged(this MonthCalendar control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static MonthCalendar OnClick(this MonthCalendar control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static MonthCalendar OnDateChanged(this MonthCalendar control, DateRangeEventHandler handler)
        {
            control.DateChanged += handler;
            return control;
        }

        public static MonthCalendar OnDateSelected(this MonthCalendar control, DateRangeEventHandler handler)
        {
            control.DateSelected += handler;
            return control;
        }

        public static MonthCalendar OnDoubleClick(this MonthCalendar control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static MonthCalendar OnMouseClick(this MonthCalendar control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static MonthCalendar OnMouseDoubleClick(this MonthCalendar control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static MonthCalendar OnPaint(this MonthCalendar control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static MonthCalendar OnRightToLeftLayoutChanged(this MonthCalendar control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static MonthCalendar OnAutoSizeChanged(this MonthCalendar control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static MonthCalendar OnBackColorChanged(this MonthCalendar control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static MonthCalendar OnBindingContextChanged(this MonthCalendar control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static MonthCalendar OnCausesValidationChanged(this MonthCalendar control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static MonthCalendar OnClientSizeChanged(this MonthCalendar control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static MonthCalendar OnContextMenuStripChanged(this MonthCalendar control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static MonthCalendar OnCursorChanged(this MonthCalendar control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static MonthCalendar OnDockChanged(this MonthCalendar control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static MonthCalendar OnEnabledChanged(this MonthCalendar control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static MonthCalendar OnFontChanged(this MonthCalendar control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static MonthCalendar OnForeColorChanged(this MonthCalendar control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static MonthCalendar OnLocationChanged(this MonthCalendar control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static MonthCalendar OnMarginChanged(this MonthCalendar control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static MonthCalendar OnRegionChanged(this MonthCalendar control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static MonthCalendar OnRightToLeftChanged(this MonthCalendar control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static MonthCalendar OnSizeChanged(this MonthCalendar control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static MonthCalendar OnTabIndexChanged(this MonthCalendar control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static MonthCalendar OnTabStopChanged(this MonthCalendar control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static MonthCalendar OnVisibleChanged(this MonthCalendar control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static MonthCalendar OnControlAdded(this MonthCalendar control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static MonthCalendar OnControlRemoved(this MonthCalendar control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static MonthCalendar OnDataContextChanged(this MonthCalendar control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static MonthCalendar OnDragDrop(this MonthCalendar control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static MonthCalendar OnDragEnter(this MonthCalendar control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static MonthCalendar OnDragOver(this MonthCalendar control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static MonthCalendar OnDragLeave(this MonthCalendar control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static MonthCalendar OnGiveFeedback(this MonthCalendar control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static MonthCalendar OnHandleCreated(this MonthCalendar control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static MonthCalendar OnHandleDestroyed(this MonthCalendar control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static MonthCalendar OnHelpRequested(this MonthCalendar control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static MonthCalendar OnInvalidated(this MonthCalendar control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static MonthCalendar OnQueryContinueDrag(this MonthCalendar control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static MonthCalendar OnQueryAccessibilityHelp(this MonthCalendar control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static MonthCalendar OnEnter(this MonthCalendar control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static MonthCalendar OnGotFocus(this MonthCalendar control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static MonthCalendar OnKeyDown(this MonthCalendar control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static MonthCalendar OnKeyPress(this MonthCalendar control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static MonthCalendar OnKeyUp(this MonthCalendar control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static MonthCalendar OnLayout(this MonthCalendar control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static MonthCalendar OnLeave(this MonthCalendar control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static MonthCalendar OnLostFocus(this MonthCalendar control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static MonthCalendar OnMouseCaptureChanged(this MonthCalendar control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static MonthCalendar OnMouseDown(this MonthCalendar control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static MonthCalendar OnMouseEnter(this MonthCalendar control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static MonthCalendar OnMouseLeave(this MonthCalendar control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static MonthCalendar OnDpiChangedBeforeParent(this MonthCalendar control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static MonthCalendar OnDpiChangedAfterParent(this MonthCalendar control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static MonthCalendar OnMouseHover(this MonthCalendar control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static MonthCalendar OnMouseMove(this MonthCalendar control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static MonthCalendar OnMouseUp(this MonthCalendar control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static MonthCalendar OnMouseWheel(this MonthCalendar control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static MonthCalendar OnMove(this MonthCalendar control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static MonthCalendar OnPreviewKeyDown(this MonthCalendar control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static MonthCalendar OnResize(this MonthCalendar control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static MonthCalendar OnChangeUICues(this MonthCalendar control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static MonthCalendar OnStyleChanged(this MonthCalendar control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static MonthCalendar OnSystemColorsChanged(this MonthCalendar control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static MonthCalendar OnValidating(this MonthCalendar control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static MonthCalendar OnValidated(this MonthCalendar control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static MonthCalendar OnParentChanged(this MonthCalendar control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static MonthCalendar OnDisposed(this MonthCalendar control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static MonthCalendar AddTo(this MonthCalendar control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static MonthCalendar Assign(this MonthCalendar control, out MonthCalendar variable)
        {
            variable = control;
            return control;
        }

    }
}

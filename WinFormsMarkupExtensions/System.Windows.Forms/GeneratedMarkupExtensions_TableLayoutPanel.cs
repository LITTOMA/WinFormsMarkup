using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class TableLayoutPanelExtensions
    {
        public static TableLayoutPanel LayoutSettings(this TableLayoutPanel control, TableLayoutSettings value)
        {
            control.LayoutSettings = value;
            return control;
        }

        public static TableLayoutPanel BorderStyle(this TableLayoutPanel control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static TableLayoutPanel CellBorderStyle(this TableLayoutPanel control, TableLayoutPanelCellBorderStyle value)
        {
            control.CellBorderStyle = value;
            return control;
        }

        public static TableLayoutPanel ColumnCount(this TableLayoutPanel control, Int32 value)
        {
            control.ColumnCount = value;
            return control;
        }

        public static TableLayoutPanel GrowStyle(this TableLayoutPanel control, TableLayoutPanelGrowStyle value)
        {
            control.GrowStyle = value;
            return control;
        }

        public static TableLayoutPanel RowCount(this TableLayoutPanel control, Int32 value)
        {
            control.RowCount = value;
            return control;
        }

        public static TableLayoutPanel AutoSize(this TableLayoutPanel control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static TableLayoutPanel AutoSizeMode(this TableLayoutPanel control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static TableLayoutPanel TabStop(this TableLayoutPanel control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static TableLayoutPanel Text(this TableLayoutPanel control, String value)
        {
            control.Text = value;
            return control;
        }

        public static TableLayoutPanel AutoScroll(this TableLayoutPanel control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static TableLayoutPanel AutoScrollMargin(this TableLayoutPanel control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static TableLayoutPanel AutoScrollMargin(this TableLayoutPanel control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static TableLayoutPanel AutoScrollPosition(this TableLayoutPanel control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static TableLayoutPanel AutoScrollPosition(this TableLayoutPanel control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static TableLayoutPanel AutoScrollMinSize(this TableLayoutPanel control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static TableLayoutPanel AutoScrollMinSize(this TableLayoutPanel control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static TableLayoutPanel AccessibleDefaultActionDescription(this TableLayoutPanel control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static TableLayoutPanel AccessibleDescription(this TableLayoutPanel control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static TableLayoutPanel AccessibleName(this TableLayoutPanel control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static TableLayoutPanel AccessibleRole(this TableLayoutPanel control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static TableLayoutPanel AllowDrop(this TableLayoutPanel control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static TableLayoutPanel Anchor(this TableLayoutPanel control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static TableLayoutPanel AutoScrollOffset(this TableLayoutPanel control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static TableLayoutPanel AutoScrollOffset(this TableLayoutPanel control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static TableLayoutPanel DataContext(this TableLayoutPanel control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static TableLayoutPanel BackColor(this TableLayoutPanel control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TableLayoutPanel BackColor(this TableLayoutPanel control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static TableLayoutPanel BackColor(this TableLayoutPanel control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static TableLayoutPanel BackgroundImage(this TableLayoutPanel control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static TableLayoutPanel BackgroundImageLayout(this TableLayoutPanel control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static TableLayoutPanel BindingContext(this TableLayoutPanel control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static TableLayoutPanel Bounds(this TableLayoutPanel control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static TableLayoutPanel Bounds(this TableLayoutPanel control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static TableLayoutPanel Bounds(this TableLayoutPanel control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static TableLayoutPanel Capture(this TableLayoutPanel control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static TableLayoutPanel CausesValidation(this TableLayoutPanel control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static TableLayoutPanel ClientSize(this TableLayoutPanel control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static TableLayoutPanel ClientSize(this TableLayoutPanel control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static TableLayoutPanel ContextMenuStrip(this TableLayoutPanel control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static TableLayoutPanel Cursor(this TableLayoutPanel control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static TableLayoutPanel Dock(this TableLayoutPanel control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static TableLayoutPanel Enabled(this TableLayoutPanel control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static TableLayoutPanel Font(this TableLayoutPanel control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static TableLayoutPanel Font(this TableLayoutPanel control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static TableLayoutPanel ForeColor(this TableLayoutPanel control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TableLayoutPanel ForeColor(this TableLayoutPanel control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static TableLayoutPanel ForeColor(this TableLayoutPanel control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static TableLayoutPanel Height(this TableLayoutPanel control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static TableLayoutPanel IsAccessible(this TableLayoutPanel control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static TableLayoutPanel Left(this TableLayoutPanel control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static TableLayoutPanel Location(this TableLayoutPanel control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static TableLayoutPanel Location(this TableLayoutPanel control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static TableLayoutPanel Margin(this TableLayoutPanel control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static TableLayoutPanel MaximumSize(this TableLayoutPanel control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static TableLayoutPanel MaximumSize(this TableLayoutPanel control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static TableLayoutPanel MinimumSize(this TableLayoutPanel control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static TableLayoutPanel MinimumSize(this TableLayoutPanel control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static TableLayoutPanel Name(this TableLayoutPanel control, String value)
        {
            control.Name = value;
            return control;
        }

        public static TableLayoutPanel Parent(this TableLayoutPanel control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static TableLayoutPanel Region(this TableLayoutPanel control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static TableLayoutPanel RightToLeft(this TableLayoutPanel control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static TableLayoutPanel Size(this TableLayoutPanel control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static TableLayoutPanel Size(this TableLayoutPanel control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static TableLayoutPanel TabIndex(this TableLayoutPanel control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static TableLayoutPanel Tag(this TableLayoutPanel control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static TableLayoutPanel Top(this TableLayoutPanel control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static TableLayoutPanel UseWaitCursor(this TableLayoutPanel control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static TableLayoutPanel Visible(this TableLayoutPanel control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static TableLayoutPanel Width(this TableLayoutPanel control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static TableLayoutPanel WindowTarget(this TableLayoutPanel control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static TableLayoutPanel Padding(this TableLayoutPanel control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static TableLayoutPanel ImeMode(this TableLayoutPanel control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static TableLayoutPanel OnCellPaint(this TableLayoutPanel control, TableLayoutCellPaintEventHandler handler)
        {
            control.CellPaint += handler;
            return control;
        }

        public static TableLayoutPanel OnAutoSizeChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnKeyUp(this TableLayoutPanel control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static TableLayoutPanel OnKeyDown(this TableLayoutPanel control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static TableLayoutPanel OnKeyPress(this TableLayoutPanel control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static TableLayoutPanel OnTextChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnScroll(this TableLayoutPanel control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static TableLayoutPanel OnBackColorChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnBackgroundImageChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnBackgroundImageLayoutChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnBindingContextChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnCausesValidationChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnClientSizeChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnContextMenuStripChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnCursorChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnDockChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnEnabledChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnFontChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnForeColorChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnLocationChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnMarginChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnRegionChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnRightToLeftChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnSizeChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnTabIndexChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnTabStopChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnVisibleChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnClick(this TableLayoutPanel control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static TableLayoutPanel OnControlAdded(this TableLayoutPanel control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static TableLayoutPanel OnControlRemoved(this TableLayoutPanel control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static TableLayoutPanel OnDataContextChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnDragDrop(this TableLayoutPanel control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static TableLayoutPanel OnDragEnter(this TableLayoutPanel control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static TableLayoutPanel OnDragOver(this TableLayoutPanel control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static TableLayoutPanel OnDragLeave(this TableLayoutPanel control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static TableLayoutPanel OnGiveFeedback(this TableLayoutPanel control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static TableLayoutPanel OnHandleCreated(this TableLayoutPanel control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static TableLayoutPanel OnHandleDestroyed(this TableLayoutPanel control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static TableLayoutPanel OnHelpRequested(this TableLayoutPanel control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static TableLayoutPanel OnInvalidated(this TableLayoutPanel control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static TableLayoutPanel OnPaddingChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnPaint(this TableLayoutPanel control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static TableLayoutPanel OnQueryContinueDrag(this TableLayoutPanel control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static TableLayoutPanel OnQueryAccessibilityHelp(this TableLayoutPanel control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static TableLayoutPanel OnDoubleClick(this TableLayoutPanel control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static TableLayoutPanel OnEnter(this TableLayoutPanel control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static TableLayoutPanel OnGotFocus(this TableLayoutPanel control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static TableLayoutPanel OnLayout(this TableLayoutPanel control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static TableLayoutPanel OnLeave(this TableLayoutPanel control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static TableLayoutPanel OnLostFocus(this TableLayoutPanel control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseClick(this TableLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseDoubleClick(this TableLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseCaptureChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseDown(this TableLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseEnter(this TableLayoutPanel control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseLeave(this TableLayoutPanel control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static TableLayoutPanel OnDpiChangedBeforeParent(this TableLayoutPanel control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static TableLayoutPanel OnDpiChangedAfterParent(this TableLayoutPanel control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseHover(this TableLayoutPanel control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseMove(this TableLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseUp(this TableLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static TableLayoutPanel OnMouseWheel(this TableLayoutPanel control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static TableLayoutPanel OnMove(this TableLayoutPanel control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static TableLayoutPanel OnPreviewKeyDown(this TableLayoutPanel control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static TableLayoutPanel OnResize(this TableLayoutPanel control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static TableLayoutPanel OnChangeUICues(this TableLayoutPanel control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static TableLayoutPanel OnStyleChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnSystemColorsChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnValidating(this TableLayoutPanel control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static TableLayoutPanel OnValidated(this TableLayoutPanel control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static TableLayoutPanel OnParentChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnImeModeChanged(this TableLayoutPanel control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static TableLayoutPanel OnDisposed(this TableLayoutPanel control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static TableLayoutPanel AddTo(this TableLayoutPanel control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static TableLayoutPanel Assign(this TableLayoutPanel control, out TableLayoutPanel variable)
        {
            variable = control;
            return control;
        }

    }
}

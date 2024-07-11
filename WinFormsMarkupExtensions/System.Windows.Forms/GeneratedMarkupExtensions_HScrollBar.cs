using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class HScrollBarExtensions
    {
        public static HScrollBar AutoSize(this HScrollBar control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static HScrollBar BackColor(this HScrollBar control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static HScrollBar BackgroundImage(this HScrollBar control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static HScrollBar BackgroundImageLayout(this HScrollBar control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static HScrollBar ForeColor(this HScrollBar control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static HScrollBar Font(this HScrollBar control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static HScrollBar ImeMode(this HScrollBar control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static HScrollBar LargeChange(this HScrollBar control, Int32 value)
        {
            control.LargeChange = value;
            return control;
        }

        public static HScrollBar Maximum(this HScrollBar control, Int32 value)
        {
            control.Maximum = value;
            return control;
        }

        public static HScrollBar Minimum(this HScrollBar control, Int32 value)
        {
            control.Minimum = value;
            return control;
        }

        public static HScrollBar SmallChange(this HScrollBar control, Int32 value)
        {
            control.SmallChange = value;
            return control;
        }

        public static HScrollBar TabStop(this HScrollBar control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static HScrollBar Text(this HScrollBar control, String value)
        {
            control.Text = value;
            return control;
        }

        public static HScrollBar Value(this HScrollBar control, Int32 value)
        {
            control.Value = value;
            return control;
        }

        public static HScrollBar ScaleScrollBarForDpiChange(this HScrollBar control, Boolean value)
        {
            control.ScaleScrollBarForDpiChange = value;
            return control;
        }

        public static HScrollBar AccessibleDefaultActionDescription(this HScrollBar control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static HScrollBar AccessibleDescription(this HScrollBar control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static HScrollBar AccessibleName(this HScrollBar control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static HScrollBar AccessibleRole(this HScrollBar control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static HScrollBar AllowDrop(this HScrollBar control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static HScrollBar Anchor(this HScrollBar control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static HScrollBar AutoScrollOffset(this HScrollBar control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static HScrollBar DataContext(this HScrollBar control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static HScrollBar BindingContext(this HScrollBar control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static HScrollBar Bounds(this HScrollBar control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static HScrollBar Capture(this HScrollBar control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static HScrollBar CausesValidation(this HScrollBar control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static HScrollBar ClientSize(this HScrollBar control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static HScrollBar ContextMenuStrip(this HScrollBar control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static HScrollBar Cursor(this HScrollBar control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static HScrollBar Dock(this HScrollBar control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static HScrollBar Enabled(this HScrollBar control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static HScrollBar Height(this HScrollBar control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static HScrollBar IsAccessible(this HScrollBar control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static HScrollBar Left(this HScrollBar control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static HScrollBar Location(this HScrollBar control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static HScrollBar Margin(this HScrollBar control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static HScrollBar MaximumSize(this HScrollBar control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static HScrollBar MinimumSize(this HScrollBar control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static HScrollBar Name(this HScrollBar control, String value)
        {
            control.Name = value;
            return control;
        }

        public static HScrollBar Parent(this HScrollBar control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static HScrollBar Region(this HScrollBar control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static HScrollBar RightToLeft(this HScrollBar control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static HScrollBar Size(this HScrollBar control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static HScrollBar TabIndex(this HScrollBar control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static HScrollBar Tag(this HScrollBar control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static HScrollBar Top(this HScrollBar control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static HScrollBar UseWaitCursor(this HScrollBar control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static HScrollBar Visible(this HScrollBar control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static HScrollBar Width(this HScrollBar control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static HScrollBar WindowTarget(this HScrollBar control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static HScrollBar Padding(this HScrollBar control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static HScrollBar OnAutoSizeChanged(this HScrollBar control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static HScrollBar OnBackColorChanged(this HScrollBar control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static HScrollBar OnBackgroundImageChanged(this HScrollBar control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static HScrollBar OnBackgroundImageLayoutChanged(this HScrollBar control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static HScrollBar OnForeColorChanged(this HScrollBar control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static HScrollBar OnFontChanged(this HScrollBar control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static HScrollBar OnImeModeChanged(this HScrollBar control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static HScrollBar OnTextChanged(this HScrollBar control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static HScrollBar OnClick(this HScrollBar control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static HScrollBar OnPaint(this HScrollBar control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static HScrollBar OnDoubleClick(this HScrollBar control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static HScrollBar OnMouseClick(this HScrollBar control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static HScrollBar OnMouseDoubleClick(this HScrollBar control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static HScrollBar OnMouseDown(this HScrollBar control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static HScrollBar OnMouseUp(this HScrollBar control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static HScrollBar OnMouseMove(this HScrollBar control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static HScrollBar OnScroll(this HScrollBar control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static HScrollBar OnValueChanged(this HScrollBar control, EventHandler handler)
        {
            control.ValueChanged += handler;
            return control;
        }

        public static HScrollBar OnBindingContextChanged(this HScrollBar control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static HScrollBar OnCausesValidationChanged(this HScrollBar control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static HScrollBar OnClientSizeChanged(this HScrollBar control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static HScrollBar OnContextMenuStripChanged(this HScrollBar control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static HScrollBar OnCursorChanged(this HScrollBar control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static HScrollBar OnDockChanged(this HScrollBar control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static HScrollBar OnEnabledChanged(this HScrollBar control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static HScrollBar OnLocationChanged(this HScrollBar control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static HScrollBar OnMarginChanged(this HScrollBar control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static HScrollBar OnRegionChanged(this HScrollBar control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static HScrollBar OnRightToLeftChanged(this HScrollBar control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static HScrollBar OnSizeChanged(this HScrollBar control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static HScrollBar OnTabIndexChanged(this HScrollBar control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static HScrollBar OnTabStopChanged(this HScrollBar control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static HScrollBar OnVisibleChanged(this HScrollBar control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static HScrollBar OnControlAdded(this HScrollBar control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static HScrollBar OnControlRemoved(this HScrollBar control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static HScrollBar OnDataContextChanged(this HScrollBar control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static HScrollBar OnDragDrop(this HScrollBar control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static HScrollBar OnDragEnter(this HScrollBar control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static HScrollBar OnDragOver(this HScrollBar control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static HScrollBar OnDragLeave(this HScrollBar control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static HScrollBar OnGiveFeedback(this HScrollBar control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static HScrollBar OnHandleCreated(this HScrollBar control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static HScrollBar OnHandleDestroyed(this HScrollBar control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static HScrollBar OnHelpRequested(this HScrollBar control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static HScrollBar OnInvalidated(this HScrollBar control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static HScrollBar OnPaddingChanged(this HScrollBar control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static HScrollBar OnQueryContinueDrag(this HScrollBar control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static HScrollBar OnQueryAccessibilityHelp(this HScrollBar control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static HScrollBar OnEnter(this HScrollBar control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static HScrollBar OnGotFocus(this HScrollBar control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static HScrollBar OnKeyDown(this HScrollBar control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static HScrollBar OnKeyPress(this HScrollBar control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static HScrollBar OnKeyUp(this HScrollBar control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static HScrollBar OnLayout(this HScrollBar control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static HScrollBar OnLeave(this HScrollBar control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static HScrollBar OnLostFocus(this HScrollBar control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static HScrollBar OnMouseCaptureChanged(this HScrollBar control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static HScrollBar OnMouseEnter(this HScrollBar control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static HScrollBar OnMouseLeave(this HScrollBar control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static HScrollBar OnDpiChangedBeforeParent(this HScrollBar control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static HScrollBar OnDpiChangedAfterParent(this HScrollBar control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static HScrollBar OnMouseHover(this HScrollBar control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static HScrollBar OnMouseWheel(this HScrollBar control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static HScrollBar OnMove(this HScrollBar control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static HScrollBar OnPreviewKeyDown(this HScrollBar control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static HScrollBar OnResize(this HScrollBar control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static HScrollBar OnChangeUICues(this HScrollBar control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static HScrollBar OnStyleChanged(this HScrollBar control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static HScrollBar OnSystemColorsChanged(this HScrollBar control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static HScrollBar OnValidating(this HScrollBar control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static HScrollBar OnValidated(this HScrollBar control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static HScrollBar OnParentChanged(this HScrollBar control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static HScrollBar OnDisposed(this HScrollBar control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static HScrollBar AddTo(this HScrollBar control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

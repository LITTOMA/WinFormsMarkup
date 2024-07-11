using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class SplitterExtensions
    {
        public static Splitter Anchor(this Splitter control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static Splitter AllowDrop(this Splitter control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static Splitter ForeColor(this Splitter control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Splitter BackgroundImage(this Splitter control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static Splitter BackgroundImageLayout(this Splitter control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static Splitter Font(this Splitter control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static Splitter BorderStyle(this Splitter control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static Splitter Dock(this Splitter control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static Splitter ImeMode(this Splitter control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static Splitter MinExtra(this Splitter control, Int32 value)
        {
            control.MinExtra = value;
            return control;
        }

        public static Splitter MinSize(this Splitter control, Int32 value)
        {
            control.MinSize = value;
            return control;
        }

        public static Splitter SplitPosition(this Splitter control, Int32 value)
        {
            control.SplitPosition = value;
            return control;
        }

        public static Splitter TabStop(this Splitter control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static Splitter Text(this Splitter control, String value)
        {
            control.Text = value;
            return control;
        }

        public static Splitter AccessibleDefaultActionDescription(this Splitter control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static Splitter AccessibleDescription(this Splitter control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static Splitter AccessibleName(this Splitter control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static Splitter AccessibleRole(this Splitter control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static Splitter AutoSize(this Splitter control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static Splitter AutoScrollOffset(this Splitter control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static Splitter DataContext(this Splitter control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static Splitter BackColor(this Splitter control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Splitter BindingContext(this Splitter control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static Splitter Bounds(this Splitter control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static Splitter Capture(this Splitter control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static Splitter CausesValidation(this Splitter control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static Splitter ClientSize(this Splitter control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static Splitter ContextMenuStrip(this Splitter control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static Splitter Cursor(this Splitter control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static Splitter Enabled(this Splitter control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static Splitter Height(this Splitter control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static Splitter IsAccessible(this Splitter control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static Splitter Left(this Splitter control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static Splitter Location(this Splitter control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static Splitter Margin(this Splitter control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static Splitter MaximumSize(this Splitter control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static Splitter MinimumSize(this Splitter control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static Splitter Name(this Splitter control, String value)
        {
            control.Name = value;
            return control;
        }

        public static Splitter Parent(this Splitter control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static Splitter Region(this Splitter control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static Splitter RightToLeft(this Splitter control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static Splitter Size(this Splitter control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static Splitter TabIndex(this Splitter control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static Splitter Tag(this Splitter control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static Splitter Top(this Splitter control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static Splitter UseWaitCursor(this Splitter control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static Splitter Visible(this Splitter control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static Splitter Width(this Splitter control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static Splitter WindowTarget(this Splitter control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static Splitter Padding(this Splitter control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static Splitter OnForeColorChanged(this Splitter control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static Splitter OnBackgroundImageChanged(this Splitter control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static Splitter OnBackgroundImageLayoutChanged(this Splitter control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static Splitter OnFontChanged(this Splitter control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static Splitter OnImeModeChanged(this Splitter control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static Splitter OnTabStopChanged(this Splitter control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static Splitter OnTextChanged(this Splitter control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static Splitter OnEnter(this Splitter control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static Splitter OnKeyUp(this Splitter control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static Splitter OnKeyDown(this Splitter control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static Splitter OnKeyPress(this Splitter control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static Splitter OnLeave(this Splitter control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static Splitter OnSplitterMoving(this Splitter control, SplitterEventHandler handler)
        {
            control.SplitterMoving += handler;
            return control;
        }

        public static Splitter OnSplitterMoved(this Splitter control, SplitterEventHandler handler)
        {
            control.SplitterMoved += handler;
            return control;
        }

        public static Splitter OnAutoSizeChanged(this Splitter control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static Splitter OnBackColorChanged(this Splitter control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static Splitter OnBindingContextChanged(this Splitter control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static Splitter OnCausesValidationChanged(this Splitter control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static Splitter OnClientSizeChanged(this Splitter control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static Splitter OnContextMenuStripChanged(this Splitter control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static Splitter OnCursorChanged(this Splitter control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static Splitter OnDockChanged(this Splitter control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static Splitter OnEnabledChanged(this Splitter control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static Splitter OnLocationChanged(this Splitter control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static Splitter OnMarginChanged(this Splitter control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static Splitter OnRegionChanged(this Splitter control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static Splitter OnRightToLeftChanged(this Splitter control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static Splitter OnSizeChanged(this Splitter control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static Splitter OnTabIndexChanged(this Splitter control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static Splitter OnVisibleChanged(this Splitter control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static Splitter OnClick(this Splitter control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static Splitter OnControlAdded(this Splitter control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static Splitter OnControlRemoved(this Splitter control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static Splitter OnDataContextChanged(this Splitter control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static Splitter OnDragDrop(this Splitter control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static Splitter OnDragEnter(this Splitter control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static Splitter OnDragOver(this Splitter control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static Splitter OnDragLeave(this Splitter control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static Splitter OnGiveFeedback(this Splitter control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static Splitter OnHandleCreated(this Splitter control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static Splitter OnHandleDestroyed(this Splitter control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static Splitter OnHelpRequested(this Splitter control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static Splitter OnInvalidated(this Splitter control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static Splitter OnPaddingChanged(this Splitter control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static Splitter OnPaint(this Splitter control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static Splitter OnQueryContinueDrag(this Splitter control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static Splitter OnQueryAccessibilityHelp(this Splitter control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static Splitter OnDoubleClick(this Splitter control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static Splitter OnGotFocus(this Splitter control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static Splitter OnLayout(this Splitter control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static Splitter OnLostFocus(this Splitter control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static Splitter OnMouseClick(this Splitter control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static Splitter OnMouseDoubleClick(this Splitter control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static Splitter OnMouseCaptureChanged(this Splitter control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static Splitter OnMouseDown(this Splitter control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static Splitter OnMouseEnter(this Splitter control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static Splitter OnMouseLeave(this Splitter control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static Splitter OnDpiChangedBeforeParent(this Splitter control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static Splitter OnDpiChangedAfterParent(this Splitter control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static Splitter OnMouseHover(this Splitter control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static Splitter OnMouseMove(this Splitter control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static Splitter OnMouseUp(this Splitter control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static Splitter OnMouseWheel(this Splitter control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static Splitter OnMove(this Splitter control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static Splitter OnPreviewKeyDown(this Splitter control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static Splitter OnResize(this Splitter control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static Splitter OnChangeUICues(this Splitter control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static Splitter OnStyleChanged(this Splitter control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static Splitter OnSystemColorsChanged(this Splitter control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static Splitter OnValidating(this Splitter control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static Splitter OnValidated(this Splitter control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static Splitter OnParentChanged(this Splitter control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static Splitter OnDisposed(this Splitter control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static Splitter AddTo(this Splitter control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

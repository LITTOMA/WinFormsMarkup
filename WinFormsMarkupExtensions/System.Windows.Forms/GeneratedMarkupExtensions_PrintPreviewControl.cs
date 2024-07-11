using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Printing;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class PrintPreviewControlExtensions
    {
        public static PrintPreviewControl UseAntiAlias(this PrintPreviewControl control, Boolean value)
        {
            control.UseAntiAlias = value;
            return control;
        }

        public static PrintPreviewControl AutoZoom(this PrintPreviewControl control, Boolean value)
        {
            control.AutoZoom = value;
            return control;
        }

        public static PrintPreviewControl Zoom(this PrintPreviewControl control, Double value)
        {
            control.Zoom = value;
            return control;
        }

        public static PrintPreviewControl Document(this PrintPreviewControl control, PrintDocument value)
        {
            control.Document = value;
            return control;
        }

        public static PrintPreviewControl Rows(this PrintPreviewControl control, Int32 value)
        {
            control.Rows = value;
            return control;
        }

        public static PrintPreviewControl Columns(this PrintPreviewControl control, Int32 value)
        {
            control.Columns = value;
            return control;
        }

        public static PrintPreviewControl StartPage(this PrintPreviewControl control, Int32 value)
        {
            control.StartPage = value;
            return control;
        }

        public static PrintPreviewControl RightToLeft(this PrintPreviewControl control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static PrintPreviewControl Text(this PrintPreviewControl control, String value)
        {
            control.Text = value;
            return control;
        }

        public static PrintPreviewControl TabStop(this PrintPreviewControl control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static PrintPreviewControl AccessibleDefaultActionDescription(this PrintPreviewControl control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static PrintPreviewControl AccessibleDescription(this PrintPreviewControl control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static PrintPreviewControl AccessibleName(this PrintPreviewControl control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static PrintPreviewControl AccessibleRole(this PrintPreviewControl control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static PrintPreviewControl AllowDrop(this PrintPreviewControl control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static PrintPreviewControl Anchor(this PrintPreviewControl control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static PrintPreviewControl AutoSize(this PrintPreviewControl control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static PrintPreviewControl AutoScrollOffset(this PrintPreviewControl control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static PrintPreviewControl DataContext(this PrintPreviewControl control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static PrintPreviewControl BackColor(this PrintPreviewControl control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PrintPreviewControl BackgroundImage(this PrintPreviewControl control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static PrintPreviewControl BackgroundImageLayout(this PrintPreviewControl control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static PrintPreviewControl BindingContext(this PrintPreviewControl control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static PrintPreviewControl Bounds(this PrintPreviewControl control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static PrintPreviewControl Capture(this PrintPreviewControl control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static PrintPreviewControl CausesValidation(this PrintPreviewControl control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static PrintPreviewControl ClientSize(this PrintPreviewControl control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewControl ContextMenuStrip(this PrintPreviewControl control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static PrintPreviewControl Cursor(this PrintPreviewControl control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static PrintPreviewControl Dock(this PrintPreviewControl control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static PrintPreviewControl Enabled(this PrintPreviewControl control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static PrintPreviewControl Font(this PrintPreviewControl control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static PrintPreviewControl ForeColor(this PrintPreviewControl control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PrintPreviewControl Height(this PrintPreviewControl control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static PrintPreviewControl IsAccessible(this PrintPreviewControl control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static PrintPreviewControl Left(this PrintPreviewControl control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static PrintPreviewControl Location(this PrintPreviewControl control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static PrintPreviewControl Margin(this PrintPreviewControl control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static PrintPreviewControl MaximumSize(this PrintPreviewControl control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewControl MinimumSize(this PrintPreviewControl control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewControl Name(this PrintPreviewControl control, String value)
        {
            control.Name = value;
            return control;
        }

        public static PrintPreviewControl Parent(this PrintPreviewControl control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static PrintPreviewControl Region(this PrintPreviewControl control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static PrintPreviewControl Size(this PrintPreviewControl control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static PrintPreviewControl TabIndex(this PrintPreviewControl control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static PrintPreviewControl Tag(this PrintPreviewControl control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static PrintPreviewControl Top(this PrintPreviewControl control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static PrintPreviewControl UseWaitCursor(this PrintPreviewControl control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static PrintPreviewControl Visible(this PrintPreviewControl control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static PrintPreviewControl Width(this PrintPreviewControl control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static PrintPreviewControl WindowTarget(this PrintPreviewControl control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static PrintPreviewControl Padding(this PrintPreviewControl control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static PrintPreviewControl ImeMode(this PrintPreviewControl control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static PrintPreviewControl OnStartPageChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.StartPageChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnTextChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnAutoSizeChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnBackColorChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnBackgroundImageChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnBackgroundImageLayoutChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnBindingContextChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnCausesValidationChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnClientSizeChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnContextMenuStripChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnCursorChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnDockChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnEnabledChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnFontChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnForeColorChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnLocationChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnMarginChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnRegionChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnRightToLeftChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnSizeChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnTabIndexChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnTabStopChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnVisibleChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnClick(this PrintPreviewControl control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static PrintPreviewControl OnControlAdded(this PrintPreviewControl control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static PrintPreviewControl OnControlRemoved(this PrintPreviewControl control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static PrintPreviewControl OnDataContextChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnDragDrop(this PrintPreviewControl control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static PrintPreviewControl OnDragEnter(this PrintPreviewControl control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static PrintPreviewControl OnDragOver(this PrintPreviewControl control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static PrintPreviewControl OnDragLeave(this PrintPreviewControl control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static PrintPreviewControl OnGiveFeedback(this PrintPreviewControl control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static PrintPreviewControl OnHandleCreated(this PrintPreviewControl control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static PrintPreviewControl OnHandleDestroyed(this PrintPreviewControl control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static PrintPreviewControl OnHelpRequested(this PrintPreviewControl control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static PrintPreviewControl OnInvalidated(this PrintPreviewControl control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static PrintPreviewControl OnPaddingChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnPaint(this PrintPreviewControl control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static PrintPreviewControl OnQueryContinueDrag(this PrintPreviewControl control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static PrintPreviewControl OnQueryAccessibilityHelp(this PrintPreviewControl control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static PrintPreviewControl OnDoubleClick(this PrintPreviewControl control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static PrintPreviewControl OnEnter(this PrintPreviewControl control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static PrintPreviewControl OnGotFocus(this PrintPreviewControl control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static PrintPreviewControl OnKeyDown(this PrintPreviewControl control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static PrintPreviewControl OnKeyPress(this PrintPreviewControl control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static PrintPreviewControl OnKeyUp(this PrintPreviewControl control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static PrintPreviewControl OnLayout(this PrintPreviewControl control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static PrintPreviewControl OnLeave(this PrintPreviewControl control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static PrintPreviewControl OnLostFocus(this PrintPreviewControl control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseClick(this PrintPreviewControl control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseDoubleClick(this PrintPreviewControl control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseCaptureChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseDown(this PrintPreviewControl control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseEnter(this PrintPreviewControl control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseLeave(this PrintPreviewControl control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static PrintPreviewControl OnDpiChangedBeforeParent(this PrintPreviewControl control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static PrintPreviewControl OnDpiChangedAfterParent(this PrintPreviewControl control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseHover(this PrintPreviewControl control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseMove(this PrintPreviewControl control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseUp(this PrintPreviewControl control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static PrintPreviewControl OnMouseWheel(this PrintPreviewControl control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static PrintPreviewControl OnMove(this PrintPreviewControl control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static PrintPreviewControl OnPreviewKeyDown(this PrintPreviewControl control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static PrintPreviewControl OnResize(this PrintPreviewControl control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static PrintPreviewControl OnChangeUICues(this PrintPreviewControl control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static PrintPreviewControl OnStyleChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnSystemColorsChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnValidating(this PrintPreviewControl control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static PrintPreviewControl OnValidated(this PrintPreviewControl control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static PrintPreviewControl OnParentChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnImeModeChanged(this PrintPreviewControl control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static PrintPreviewControl OnDisposed(this PrintPreviewControl control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static PrintPreviewControl AddTo(this PrintPreviewControl control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

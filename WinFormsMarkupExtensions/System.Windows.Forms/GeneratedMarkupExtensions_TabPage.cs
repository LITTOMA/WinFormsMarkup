using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class TabPageExtensions
    {
        public static TabPage AutoSizeMode(this TabPage control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static TabPage AutoSize(this TabPage control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static TabPage BackColor(this TabPage control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TabPage ImageIndex(this TabPage control, Int32 value)
        {
            control.ImageIndex = value;
            return control;
        }

        public static TabPage ImageKey(this TabPage control, String value)
        {
            control.ImageKey = value;
            return control;
        }

        public static TabPage Anchor(this TabPage control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static TabPage Dock(this TabPage control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static TabPage Enabled(this TabPage control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static TabPage UseVisualStyleBackColor(this TabPage control, Boolean value)
        {
            control.UseVisualStyleBackColor = value;
            return control;
        }

        public static TabPage Location(this TabPage control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static TabPage MaximumSize(this TabPage control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static TabPage MinimumSize(this TabPage control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static TabPage TabIndex(this TabPage control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static TabPage TabStop(this TabPage control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static TabPage Text(this TabPage control, String value)
        {
            control.Text = value;
            return control;
        }

        public static TabPage ToolTipText(this TabPage control, String value)
        {
            control.ToolTipText = value;
            return control;
        }

        public static TabPage Visible(this TabPage control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static TabPage BorderStyle(this TabPage control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static TabPage AutoScroll(this TabPage control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static TabPage AutoScrollMargin(this TabPage control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static TabPage AutoScrollPosition(this TabPage control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static TabPage AutoScrollMinSize(this TabPage control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static TabPage AccessibleDefaultActionDescription(this TabPage control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static TabPage AccessibleDescription(this TabPage control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static TabPage AccessibleName(this TabPage control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static TabPage AccessibleRole(this TabPage control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static TabPage AllowDrop(this TabPage control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static TabPage AutoScrollOffset(this TabPage control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static TabPage DataContext(this TabPage control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static TabPage BackgroundImage(this TabPage control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static TabPage BackgroundImageLayout(this TabPage control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static TabPage BindingContext(this TabPage control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static TabPage Bounds(this TabPage control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static TabPage Capture(this TabPage control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static TabPage CausesValidation(this TabPage control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static TabPage ClientSize(this TabPage control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static TabPage ContextMenuStrip(this TabPage control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static TabPage Cursor(this TabPage control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static TabPage Font(this TabPage control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static TabPage ForeColor(this TabPage control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TabPage Height(this TabPage control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static TabPage IsAccessible(this TabPage control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static TabPage Left(this TabPage control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static TabPage Margin(this TabPage control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static TabPage Name(this TabPage control, String value)
        {
            control.Name = value;
            return control;
        }

        public static TabPage Parent(this TabPage control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static TabPage Region(this TabPage control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static TabPage RightToLeft(this TabPage control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static TabPage Size(this TabPage control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static TabPage Tag(this TabPage control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static TabPage Top(this TabPage control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static TabPage UseWaitCursor(this TabPage control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static TabPage Width(this TabPage control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static TabPage WindowTarget(this TabPage control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static TabPage Padding(this TabPage control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static TabPage ImeMode(this TabPage control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static TabPage OnAutoSizeChanged(this TabPage control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static TabPage OnDockChanged(this TabPage control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static TabPage OnEnabledChanged(this TabPage control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static TabPage OnLocationChanged(this TabPage control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static TabPage OnTabIndexChanged(this TabPage control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static TabPage OnTabStopChanged(this TabPage control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static TabPage OnTextChanged(this TabPage control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static TabPage OnVisibleChanged(this TabPage control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static TabPage OnKeyUp(this TabPage control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static TabPage OnKeyDown(this TabPage control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static TabPage OnKeyPress(this TabPage control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static TabPage OnScroll(this TabPage control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static TabPage OnBackColorChanged(this TabPage control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static TabPage OnBackgroundImageChanged(this TabPage control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static TabPage OnBackgroundImageLayoutChanged(this TabPage control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static TabPage OnBindingContextChanged(this TabPage control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static TabPage OnCausesValidationChanged(this TabPage control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static TabPage OnClientSizeChanged(this TabPage control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static TabPage OnContextMenuStripChanged(this TabPage control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static TabPage OnCursorChanged(this TabPage control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static TabPage OnFontChanged(this TabPage control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static TabPage OnForeColorChanged(this TabPage control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static TabPage OnMarginChanged(this TabPage control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static TabPage OnRegionChanged(this TabPage control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static TabPage OnRightToLeftChanged(this TabPage control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static TabPage OnSizeChanged(this TabPage control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static TabPage OnClick(this TabPage control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static TabPage OnControlAdded(this TabPage control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static TabPage OnControlRemoved(this TabPage control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static TabPage OnDataContextChanged(this TabPage control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static TabPage OnDragDrop(this TabPage control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static TabPage OnDragEnter(this TabPage control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static TabPage OnDragOver(this TabPage control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static TabPage OnDragLeave(this TabPage control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static TabPage OnGiveFeedback(this TabPage control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static TabPage OnHandleCreated(this TabPage control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static TabPage OnHandleDestroyed(this TabPage control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static TabPage OnHelpRequested(this TabPage control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static TabPage OnInvalidated(this TabPage control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static TabPage OnPaddingChanged(this TabPage control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static TabPage OnPaint(this TabPage control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static TabPage OnQueryContinueDrag(this TabPage control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static TabPage OnQueryAccessibilityHelp(this TabPage control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static TabPage OnDoubleClick(this TabPage control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static TabPage OnEnter(this TabPage control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static TabPage OnGotFocus(this TabPage control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static TabPage OnLayout(this TabPage control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static TabPage OnLeave(this TabPage control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static TabPage OnLostFocus(this TabPage control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static TabPage OnMouseClick(this TabPage control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static TabPage OnMouseDoubleClick(this TabPage control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static TabPage OnMouseCaptureChanged(this TabPage control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static TabPage OnMouseDown(this TabPage control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static TabPage OnMouseEnter(this TabPage control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static TabPage OnMouseLeave(this TabPage control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static TabPage OnDpiChangedBeforeParent(this TabPage control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static TabPage OnDpiChangedAfterParent(this TabPage control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static TabPage OnMouseHover(this TabPage control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static TabPage OnMouseMove(this TabPage control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static TabPage OnMouseUp(this TabPage control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static TabPage OnMouseWheel(this TabPage control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static TabPage OnMove(this TabPage control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static TabPage OnPreviewKeyDown(this TabPage control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static TabPage OnResize(this TabPage control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static TabPage OnChangeUICues(this TabPage control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static TabPage OnStyleChanged(this TabPage control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static TabPage OnSystemColorsChanged(this TabPage control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static TabPage OnValidating(this TabPage control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static TabPage OnValidated(this TabPage control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static TabPage OnParentChanged(this TabPage control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static TabPage OnImeModeChanged(this TabPage control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static TabPage OnDisposed(this TabPage control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static TabPage AddTo(this TabPage control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

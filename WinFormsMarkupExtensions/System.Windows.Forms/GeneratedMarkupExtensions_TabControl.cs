using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class TabControlExtensions
    {
        public static TabControl Alignment(this TabControl control, TabAlignment value)
        {
            control.Alignment = value;
            return control;
        }

        public static TabControl Appearance(this TabControl control, TabAppearance value)
        {
            control.Appearance = value;
            return control;
        }

        public static TabControl BackColor(this TabControl control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TabControl BackgroundImage(this TabControl control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static TabControl BackgroundImageLayout(this TabControl control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static TabControl ForeColor(this TabControl control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TabControl DrawMode(this TabControl control, TabDrawMode value)
        {
            control.DrawMode = value;
            return control;
        }

        public static TabControl HotTrack(this TabControl control, Boolean value)
        {
            control.HotTrack = value;
            return control;
        }

        public static TabControl ImageList(this TabControl control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static TabControl ItemSize(this TabControl control, int width, int height)
        {
            control.ItemSize = new Size(width, height);
            return control;
        }

        public static TabControl Multiline(this TabControl control, Boolean value)
        {
            control.Multiline = value;
            return control;
        }

        public static TabControl Padding(this TabControl control, int x, int y)
        {
            control.Padding = new Point(x, y);
            return control;
        }

        public static TabControl RightToLeftLayout(this TabControl control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static TabControl SelectedIndex(this TabControl control, Int32 value)
        {
            control.SelectedIndex = value;
            return control;
        }

        public static TabControl SelectedTab(this TabControl control, TabPage value)
        {
            control.SelectedTab = value;
            return control;
        }

        public static TabControl SizeMode(this TabControl control, TabSizeMode value)
        {
            control.SizeMode = value;
            return control;
        }

        public static TabControl ShowToolTips(this TabControl control, Boolean value)
        {
            control.ShowToolTips = value;
            return control;
        }

        public static TabControl Text(this TabControl control, String value)
        {
            control.Text = value;
            return control;
        }

        public static TabControl AccessibleDefaultActionDescription(this TabControl control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static TabControl AccessibleDescription(this TabControl control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static TabControl AccessibleName(this TabControl control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static TabControl AccessibleRole(this TabControl control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static TabControl AllowDrop(this TabControl control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static TabControl Anchor(this TabControl control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static TabControl AutoSize(this TabControl control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static TabControl AutoScrollOffset(this TabControl control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static TabControl DataContext(this TabControl control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static TabControl BindingContext(this TabControl control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static TabControl Bounds(this TabControl control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static TabControl Capture(this TabControl control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static TabControl CausesValidation(this TabControl control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static TabControl ClientSize(this TabControl control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static TabControl ContextMenuStrip(this TabControl control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static TabControl Cursor(this TabControl control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static TabControl Dock(this TabControl control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static TabControl Enabled(this TabControl control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static TabControl Font(this TabControl control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static TabControl Height(this TabControl control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static TabControl IsAccessible(this TabControl control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static TabControl Left(this TabControl control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static TabControl Location(this TabControl control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static TabControl Margin(this TabControl control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static TabControl MaximumSize(this TabControl control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static TabControl MinimumSize(this TabControl control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static TabControl Name(this TabControl control, String value)
        {
            control.Name = value;
            return control;
        }

        public static TabControl Parent(this TabControl control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static TabControl Region(this TabControl control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static TabControl RightToLeft(this TabControl control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static TabControl Size(this TabControl control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static TabControl TabIndex(this TabControl control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static TabControl TabStop(this TabControl control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static TabControl Tag(this TabControl control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static TabControl Top(this TabControl control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static TabControl UseWaitCursor(this TabControl control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static TabControl Visible(this TabControl control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static TabControl Width(this TabControl control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static TabControl WindowTarget(this TabControl control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static TabControl ImeMode(this TabControl control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static TabControl OnBackColorChanged(this TabControl control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static TabControl OnBackgroundImageChanged(this TabControl control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static TabControl OnBackgroundImageLayoutChanged(this TabControl control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static TabControl OnForeColorChanged(this TabControl control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static TabControl OnTextChanged(this TabControl control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static TabControl OnDrawItem(this TabControl control, DrawItemEventHandler handler)
        {
            control.DrawItem += handler;
            return control;
        }

        public static TabControl OnRightToLeftLayoutChanged(this TabControl control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static TabControl OnSelectedIndexChanged(this TabControl control, EventHandler handler)
        {
            control.SelectedIndexChanged += handler;
            return control;
        }

        public static TabControl OnSelecting(this TabControl control, TabControlCancelEventHandler handler)
        {
            control.Selecting += handler;
            return control;
        }

        public static TabControl OnSelected(this TabControl control, TabControlEventHandler handler)
        {
            control.Selected += handler;
            return control;
        }

        public static TabControl OnDeselecting(this TabControl control, TabControlCancelEventHandler handler)
        {
            control.Deselecting += handler;
            return control;
        }

        public static TabControl OnDeselected(this TabControl control, TabControlEventHandler handler)
        {
            control.Deselected += handler;
            return control;
        }

        public static TabControl OnPaint(this TabControl control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static TabControl OnAutoSizeChanged(this TabControl control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static TabControl OnBindingContextChanged(this TabControl control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static TabControl OnCausesValidationChanged(this TabControl control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static TabControl OnClientSizeChanged(this TabControl control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static TabControl OnContextMenuStripChanged(this TabControl control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static TabControl OnCursorChanged(this TabControl control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static TabControl OnDockChanged(this TabControl control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static TabControl OnEnabledChanged(this TabControl control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static TabControl OnFontChanged(this TabControl control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static TabControl OnLocationChanged(this TabControl control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static TabControl OnMarginChanged(this TabControl control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static TabControl OnRegionChanged(this TabControl control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static TabControl OnRightToLeftChanged(this TabControl control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static TabControl OnSizeChanged(this TabControl control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static TabControl OnTabIndexChanged(this TabControl control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static TabControl OnTabStopChanged(this TabControl control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static TabControl OnVisibleChanged(this TabControl control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static TabControl OnClick(this TabControl control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static TabControl OnControlAdded(this TabControl control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static TabControl OnControlRemoved(this TabControl control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static TabControl OnDataContextChanged(this TabControl control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static TabControl OnDragDrop(this TabControl control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static TabControl OnDragEnter(this TabControl control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static TabControl OnDragOver(this TabControl control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static TabControl OnDragLeave(this TabControl control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static TabControl OnGiveFeedback(this TabControl control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static TabControl OnHandleCreated(this TabControl control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static TabControl OnHandleDestroyed(this TabControl control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static TabControl OnHelpRequested(this TabControl control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static TabControl OnInvalidated(this TabControl control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static TabControl OnPaddingChanged(this TabControl control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static TabControl OnQueryContinueDrag(this TabControl control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static TabControl OnQueryAccessibilityHelp(this TabControl control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static TabControl OnDoubleClick(this TabControl control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static TabControl OnEnter(this TabControl control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static TabControl OnGotFocus(this TabControl control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static TabControl OnKeyDown(this TabControl control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static TabControl OnKeyPress(this TabControl control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static TabControl OnKeyUp(this TabControl control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static TabControl OnLayout(this TabControl control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static TabControl OnLeave(this TabControl control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static TabControl OnLostFocus(this TabControl control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static TabControl OnMouseClick(this TabControl control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static TabControl OnMouseDoubleClick(this TabControl control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static TabControl OnMouseCaptureChanged(this TabControl control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static TabControl OnMouseDown(this TabControl control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static TabControl OnMouseEnter(this TabControl control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static TabControl OnMouseLeave(this TabControl control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static TabControl OnDpiChangedBeforeParent(this TabControl control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static TabControl OnDpiChangedAfterParent(this TabControl control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static TabControl OnMouseHover(this TabControl control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static TabControl OnMouseMove(this TabControl control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static TabControl OnMouseUp(this TabControl control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static TabControl OnMouseWheel(this TabControl control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static TabControl OnMove(this TabControl control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static TabControl OnPreviewKeyDown(this TabControl control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static TabControl OnResize(this TabControl control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static TabControl OnChangeUICues(this TabControl control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static TabControl OnStyleChanged(this TabControl control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static TabControl OnSystemColorsChanged(this TabControl control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static TabControl OnValidating(this TabControl control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static TabControl OnValidated(this TabControl control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static TabControl OnParentChanged(this TabControl control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static TabControl OnImeModeChanged(this TabControl control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static TabControl OnDisposed(this TabControl control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static TabControl AddTo(this TabControl control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

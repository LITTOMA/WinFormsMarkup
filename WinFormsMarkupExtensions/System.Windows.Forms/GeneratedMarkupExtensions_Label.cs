using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Automation;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class LabelExtensions
    {
        public static Label AutoSize(this Label control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static Label AutoEllipsis(this Label control, Boolean value)
        {
            control.AutoEllipsis = value;
            return control;
        }

        public static Label BackgroundImage(this Label control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static Label BackgroundImageLayout(this Label control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static Label BorderStyle(this Label control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static Label FlatStyle(this Label control, FlatStyle value)
        {
            control.FlatStyle = value;
            return control;
        }

        public static Label Image(this Label control, Image value)
        {
            control.Image = value;
            return control;
        }

        public static Label ImageIndex(this Label control, Int32 value)
        {
            control.ImageIndex = value;
            return control;
        }

        public static Label ImageKey(this Label control, String value)
        {
            control.ImageKey = value;
            return control;
        }

        public static Label ImageList(this Label control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static Label ImageAlign(this Label control, ContentAlignment value)
        {
            control.ImageAlign = value;
            return control;
        }

        public static Label LiveSetting(this Label control, AutomationLiveSetting value)
        {
            control.LiveSetting = value;
            return control;
        }

        public static Label ImeMode(this Label control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static Label TabStop(this Label control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static Label TextAlign(this Label control, ContentAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static Label Text(this Label control, String value)
        {
            control.Text = value;
            return control;
        }

        public static Label UseCompatibleTextRendering(this Label control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static Label UseMnemonic(this Label control, Boolean value)
        {
            control.UseMnemonic = value;
            return control;
        }

        public static Label AccessibleDefaultActionDescription(this Label control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static Label AccessibleDescription(this Label control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static Label AccessibleName(this Label control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static Label AccessibleRole(this Label control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static Label AllowDrop(this Label control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static Label Anchor(this Label control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static Label AutoScrollOffset(this Label control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static Label DataContext(this Label control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static Label BackColor(this Label control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Label BindingContext(this Label control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static Label Bounds(this Label control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static Label Capture(this Label control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static Label CausesValidation(this Label control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static Label ClientSize(this Label control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static Label ContextMenuStrip(this Label control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static Label Cursor(this Label control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static Label Dock(this Label control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static Label Enabled(this Label control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static Label Font(this Label control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static Label ForeColor(this Label control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Label Height(this Label control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static Label IsAccessible(this Label control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static Label Left(this Label control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static Label Location(this Label control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static Label Margin(this Label control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static Label MaximumSize(this Label control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static Label MinimumSize(this Label control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static Label Name(this Label control, String value)
        {
            control.Name = value;
            return control;
        }

        public static Label Parent(this Label control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static Label Region(this Label control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static Label RightToLeft(this Label control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static Label Size(this Label control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static Label TabIndex(this Label control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static Label Tag(this Label control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static Label Top(this Label control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static Label UseWaitCursor(this Label control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static Label Visible(this Label control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static Label Width(this Label control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static Label WindowTarget(this Label control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static Label Padding(this Label control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static Label OnAutoSizeChanged(this Label control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static Label OnBackgroundImageChanged(this Label control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static Label OnBackgroundImageLayoutChanged(this Label control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static Label OnImeModeChanged(this Label control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static Label OnKeyUp(this Label control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static Label OnKeyDown(this Label control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static Label OnKeyPress(this Label control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static Label OnTabStopChanged(this Label control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static Label OnTextAlignChanged(this Label control, EventHandler handler)
        {
            control.TextAlignChanged += handler;
            return control;
        }

        public static Label OnBackColorChanged(this Label control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static Label OnBindingContextChanged(this Label control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static Label OnCausesValidationChanged(this Label control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static Label OnClientSizeChanged(this Label control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static Label OnContextMenuStripChanged(this Label control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static Label OnCursorChanged(this Label control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static Label OnDockChanged(this Label control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static Label OnEnabledChanged(this Label control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static Label OnFontChanged(this Label control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static Label OnForeColorChanged(this Label control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static Label OnLocationChanged(this Label control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static Label OnMarginChanged(this Label control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static Label OnRegionChanged(this Label control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static Label OnRightToLeftChanged(this Label control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static Label OnSizeChanged(this Label control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static Label OnTabIndexChanged(this Label control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static Label OnTextChanged(this Label control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static Label OnVisibleChanged(this Label control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static Label OnClick(this Label control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static Label OnControlAdded(this Label control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static Label OnControlRemoved(this Label control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static Label OnDataContextChanged(this Label control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static Label OnDragDrop(this Label control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static Label OnDragEnter(this Label control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static Label OnDragOver(this Label control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static Label OnDragLeave(this Label control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static Label OnGiveFeedback(this Label control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static Label OnHandleCreated(this Label control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static Label OnHandleDestroyed(this Label control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static Label OnHelpRequested(this Label control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static Label OnInvalidated(this Label control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static Label OnPaddingChanged(this Label control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static Label OnPaint(this Label control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static Label OnQueryContinueDrag(this Label control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static Label OnQueryAccessibilityHelp(this Label control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static Label OnDoubleClick(this Label control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static Label OnEnter(this Label control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static Label OnGotFocus(this Label control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static Label OnLayout(this Label control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static Label OnLeave(this Label control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static Label OnLostFocus(this Label control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static Label OnMouseClick(this Label control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static Label OnMouseDoubleClick(this Label control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static Label OnMouseCaptureChanged(this Label control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static Label OnMouseDown(this Label control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static Label OnMouseEnter(this Label control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static Label OnMouseLeave(this Label control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static Label OnDpiChangedBeforeParent(this Label control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static Label OnDpiChangedAfterParent(this Label control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static Label OnMouseHover(this Label control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static Label OnMouseMove(this Label control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static Label OnMouseUp(this Label control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static Label OnMouseWheel(this Label control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static Label OnMove(this Label control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static Label OnPreviewKeyDown(this Label control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static Label OnResize(this Label control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static Label OnChangeUICues(this Label control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static Label OnStyleChanged(this Label control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static Label OnSystemColorsChanged(this Label control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static Label OnValidating(this Label control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static Label OnValidated(this Label control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static Label OnParentChanged(this Label control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static Label OnDisposed(this Label control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static Label AddTo(this Label control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

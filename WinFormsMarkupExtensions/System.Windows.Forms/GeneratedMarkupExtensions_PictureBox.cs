using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class PictureBoxExtensions
    {
        public static PictureBox AllowDrop(this PictureBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static PictureBox BorderStyle(this PictureBox control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static PictureBox CausesValidation(this PictureBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static PictureBox ErrorImage(this PictureBox control, Image value)
        {
            control.ErrorImage = value;
            return control;
        }

        public static PictureBox ForeColor(this PictureBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PictureBox Font(this PictureBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static PictureBox Image(this PictureBox control, Image value)
        {
            control.Image = value;
            return control;
        }

        public static PictureBox ImageLocation(this PictureBox control, String value)
        {
            control.ImageLocation = value;
            return control;
        }

        public static PictureBox InitialImage(this PictureBox control, Image value)
        {
            control.InitialImage = value;
            return control;
        }

        public static PictureBox ImeMode(this PictureBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static PictureBox RightToLeft(this PictureBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static PictureBox SizeMode(this PictureBox control, PictureBoxSizeMode value)
        {
            control.SizeMode = value;
            return control;
        }

        public static PictureBox TabStop(this PictureBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static PictureBox TabIndex(this PictureBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static PictureBox Text(this PictureBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static PictureBox WaitOnLoad(this PictureBox control, Boolean value)
        {
            control.WaitOnLoad = value;
            return control;
        }

        public static PictureBox AccessibleDefaultActionDescription(this PictureBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static PictureBox AccessibleDescription(this PictureBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static PictureBox AccessibleName(this PictureBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static PictureBox AccessibleRole(this PictureBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static PictureBox Anchor(this PictureBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static PictureBox AutoSize(this PictureBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static PictureBox AutoScrollOffset(this PictureBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static PictureBox DataContext(this PictureBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static PictureBox BackColor(this PictureBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PictureBox BackgroundImage(this PictureBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static PictureBox BackgroundImageLayout(this PictureBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static PictureBox BindingContext(this PictureBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static PictureBox Bounds(this PictureBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static PictureBox Capture(this PictureBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static PictureBox ClientSize(this PictureBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static PictureBox ContextMenuStrip(this PictureBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static PictureBox Cursor(this PictureBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static PictureBox Dock(this PictureBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static PictureBox Enabled(this PictureBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static PictureBox Height(this PictureBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static PictureBox IsAccessible(this PictureBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static PictureBox Left(this PictureBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static PictureBox Location(this PictureBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static PictureBox Margin(this PictureBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static PictureBox MaximumSize(this PictureBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static PictureBox MinimumSize(this PictureBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static PictureBox Name(this PictureBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static PictureBox Parent(this PictureBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static PictureBox Region(this PictureBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static PictureBox Size(this PictureBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static PictureBox Tag(this PictureBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static PictureBox Top(this PictureBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static PictureBox UseWaitCursor(this PictureBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static PictureBox Visible(this PictureBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static PictureBox Width(this PictureBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static PictureBox WindowTarget(this PictureBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static PictureBox Padding(this PictureBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static PictureBox OnCausesValidationChanged(this PictureBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static PictureBox OnForeColorChanged(this PictureBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static PictureBox OnFontChanged(this PictureBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static PictureBox OnImeModeChanged(this PictureBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static PictureBox OnLoadCompleted(this PictureBox control, AsyncCompletedEventHandler handler)
        {
            control.LoadCompleted += handler;
            return control;
        }

        public static PictureBox OnLoadProgressChanged(this PictureBox control, ProgressChangedEventHandler handler)
        {
            control.LoadProgressChanged += handler;
            return control;
        }

        public static PictureBox OnRightToLeftChanged(this PictureBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static PictureBox OnSizeModeChanged(this PictureBox control, EventHandler handler)
        {
            control.SizeModeChanged += handler;
            return control;
        }

        public static PictureBox OnTabStopChanged(this PictureBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static PictureBox OnTabIndexChanged(this PictureBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static PictureBox OnTextChanged(this PictureBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static PictureBox OnEnter(this PictureBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static PictureBox OnKeyUp(this PictureBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static PictureBox OnKeyDown(this PictureBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static PictureBox OnKeyPress(this PictureBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static PictureBox OnLeave(this PictureBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static PictureBox OnAutoSizeChanged(this PictureBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static PictureBox OnBackColorChanged(this PictureBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static PictureBox OnBackgroundImageChanged(this PictureBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static PictureBox OnBackgroundImageLayoutChanged(this PictureBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static PictureBox OnBindingContextChanged(this PictureBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static PictureBox OnClientSizeChanged(this PictureBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static PictureBox OnContextMenuStripChanged(this PictureBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static PictureBox OnCursorChanged(this PictureBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static PictureBox OnDockChanged(this PictureBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static PictureBox OnEnabledChanged(this PictureBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static PictureBox OnLocationChanged(this PictureBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static PictureBox OnMarginChanged(this PictureBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static PictureBox OnRegionChanged(this PictureBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static PictureBox OnSizeChanged(this PictureBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static PictureBox OnVisibleChanged(this PictureBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static PictureBox OnClick(this PictureBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static PictureBox OnControlAdded(this PictureBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static PictureBox OnControlRemoved(this PictureBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static PictureBox OnDataContextChanged(this PictureBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static PictureBox OnDragDrop(this PictureBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static PictureBox OnDragEnter(this PictureBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static PictureBox OnDragOver(this PictureBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static PictureBox OnDragLeave(this PictureBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static PictureBox OnGiveFeedback(this PictureBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static PictureBox OnHandleCreated(this PictureBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static PictureBox OnHandleDestroyed(this PictureBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static PictureBox OnHelpRequested(this PictureBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static PictureBox OnInvalidated(this PictureBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static PictureBox OnPaddingChanged(this PictureBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static PictureBox OnPaint(this PictureBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static PictureBox OnQueryContinueDrag(this PictureBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static PictureBox OnQueryAccessibilityHelp(this PictureBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static PictureBox OnDoubleClick(this PictureBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static PictureBox OnGotFocus(this PictureBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static PictureBox OnLayout(this PictureBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static PictureBox OnLostFocus(this PictureBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static PictureBox OnMouseClick(this PictureBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static PictureBox OnMouseDoubleClick(this PictureBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static PictureBox OnMouseCaptureChanged(this PictureBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static PictureBox OnMouseDown(this PictureBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static PictureBox OnMouseEnter(this PictureBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static PictureBox OnMouseLeave(this PictureBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static PictureBox OnDpiChangedBeforeParent(this PictureBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static PictureBox OnDpiChangedAfterParent(this PictureBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static PictureBox OnMouseHover(this PictureBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static PictureBox OnMouseMove(this PictureBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static PictureBox OnMouseUp(this PictureBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static PictureBox OnMouseWheel(this PictureBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static PictureBox OnMove(this PictureBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static PictureBox OnPreviewKeyDown(this PictureBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static PictureBox OnResize(this PictureBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static PictureBox OnChangeUICues(this PictureBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static PictureBox OnStyleChanged(this PictureBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static PictureBox OnSystemColorsChanged(this PictureBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static PictureBox OnValidating(this PictureBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static PictureBox OnValidated(this PictureBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static PictureBox OnParentChanged(this PictureBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static PictureBox OnDisposed(this PictureBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static PictureBox AddTo(this PictureBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

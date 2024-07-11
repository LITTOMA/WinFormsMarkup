using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class UserControlExtensions
    {
        public static UserControl AutoSize(this UserControl control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static UserControl AutoSizeMode(this UserControl control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static UserControl AutoValidate(this UserControl control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static UserControl BorderStyle(this UserControl control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static UserControl Text(this UserControl control, String value)
        {
            control.Text = value;
            return control;
        }

        public static UserControl AutoScaleDimensions(this UserControl control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static UserControl AutoScaleMode(this UserControl control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static UserControl BindingContext(this UserControl control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static UserControl ActiveControl(this UserControl control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static UserControl AutoScroll(this UserControl control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static UserControl AutoScrollMargin(this UserControl control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static UserControl AutoScrollPosition(this UserControl control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static UserControl AutoScrollMinSize(this UserControl control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static UserControl AccessibleDefaultActionDescription(this UserControl control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static UserControl AccessibleDescription(this UserControl control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static UserControl AccessibleName(this UserControl control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static UserControl AccessibleRole(this UserControl control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static UserControl AllowDrop(this UserControl control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static UserControl Anchor(this UserControl control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static UserControl AutoScrollOffset(this UserControl control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static UserControl DataContext(this UserControl control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static UserControl BackColor(this UserControl control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static UserControl BackgroundImage(this UserControl control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static UserControl BackgroundImageLayout(this UserControl control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static UserControl Bounds(this UserControl control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static UserControl Capture(this UserControl control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static UserControl CausesValidation(this UserControl control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static UserControl ClientSize(this UserControl control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static UserControl ContextMenuStrip(this UserControl control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static UserControl Cursor(this UserControl control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static UserControl Dock(this UserControl control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static UserControl Enabled(this UserControl control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static UserControl Font(this UserControl control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static UserControl ForeColor(this UserControl control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static UserControl Height(this UserControl control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static UserControl IsAccessible(this UserControl control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static UserControl Left(this UserControl control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static UserControl Location(this UserControl control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static UserControl Margin(this UserControl control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static UserControl MaximumSize(this UserControl control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static UserControl MinimumSize(this UserControl control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static UserControl Name(this UserControl control, String value)
        {
            control.Name = value;
            return control;
        }

        public static UserControl Parent(this UserControl control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static UserControl Region(this UserControl control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static UserControl RightToLeft(this UserControl control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static UserControl Size(this UserControl control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static UserControl TabIndex(this UserControl control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static UserControl TabStop(this UserControl control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static UserControl Tag(this UserControl control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static UserControl Top(this UserControl control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static UserControl UseWaitCursor(this UserControl control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static UserControl Visible(this UserControl control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static UserControl Width(this UserControl control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static UserControl WindowTarget(this UserControl control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static UserControl Padding(this UserControl control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static UserControl ImeMode(this UserControl control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static UserControl OnAutoSizeChanged(this UserControl control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static UserControl OnAutoValidateChanged(this UserControl control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static UserControl OnLoad(this UserControl control, EventHandler handler)
        {
            control.Load += handler;
            return control;
        }

        public static UserControl OnTextChanged(this UserControl control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static UserControl OnScroll(this UserControl control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static UserControl OnBackColorChanged(this UserControl control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static UserControl OnBackgroundImageChanged(this UserControl control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static UserControl OnBackgroundImageLayoutChanged(this UserControl control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static UserControl OnBindingContextChanged(this UserControl control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static UserControl OnCausesValidationChanged(this UserControl control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static UserControl OnClientSizeChanged(this UserControl control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static UserControl OnContextMenuStripChanged(this UserControl control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static UserControl OnCursorChanged(this UserControl control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static UserControl OnDockChanged(this UserControl control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static UserControl OnEnabledChanged(this UserControl control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static UserControl OnFontChanged(this UserControl control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static UserControl OnForeColorChanged(this UserControl control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static UserControl OnLocationChanged(this UserControl control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static UserControl OnMarginChanged(this UserControl control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static UserControl OnRegionChanged(this UserControl control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static UserControl OnRightToLeftChanged(this UserControl control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static UserControl OnSizeChanged(this UserControl control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static UserControl OnTabIndexChanged(this UserControl control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static UserControl OnTabStopChanged(this UserControl control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static UserControl OnVisibleChanged(this UserControl control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static UserControl OnClick(this UserControl control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static UserControl OnControlAdded(this UserControl control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static UserControl OnControlRemoved(this UserControl control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static UserControl OnDataContextChanged(this UserControl control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static UserControl OnDragDrop(this UserControl control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static UserControl OnDragEnter(this UserControl control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static UserControl OnDragOver(this UserControl control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static UserControl OnDragLeave(this UserControl control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static UserControl OnGiveFeedback(this UserControl control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static UserControl OnHandleCreated(this UserControl control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static UserControl OnHandleDestroyed(this UserControl control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static UserControl OnHelpRequested(this UserControl control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static UserControl OnInvalidated(this UserControl control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static UserControl OnPaddingChanged(this UserControl control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static UserControl OnPaint(this UserControl control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static UserControl OnQueryContinueDrag(this UserControl control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static UserControl OnQueryAccessibilityHelp(this UserControl control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static UserControl OnDoubleClick(this UserControl control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static UserControl OnEnter(this UserControl control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static UserControl OnGotFocus(this UserControl control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static UserControl OnKeyDown(this UserControl control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static UserControl OnKeyPress(this UserControl control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static UserControl OnKeyUp(this UserControl control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static UserControl OnLayout(this UserControl control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static UserControl OnLeave(this UserControl control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static UserControl OnLostFocus(this UserControl control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static UserControl OnMouseClick(this UserControl control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static UserControl OnMouseDoubleClick(this UserControl control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static UserControl OnMouseCaptureChanged(this UserControl control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static UserControl OnMouseDown(this UserControl control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static UserControl OnMouseEnter(this UserControl control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static UserControl OnMouseLeave(this UserControl control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static UserControl OnDpiChangedBeforeParent(this UserControl control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static UserControl OnDpiChangedAfterParent(this UserControl control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static UserControl OnMouseHover(this UserControl control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static UserControl OnMouseMove(this UserControl control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static UserControl OnMouseUp(this UserControl control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static UserControl OnMouseWheel(this UserControl control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static UserControl OnMove(this UserControl control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static UserControl OnPreviewKeyDown(this UserControl control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static UserControl OnResize(this UserControl control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static UserControl OnChangeUICues(this UserControl control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static UserControl OnStyleChanged(this UserControl control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static UserControl OnSystemColorsChanged(this UserControl control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static UserControl OnValidating(this UserControl control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static UserControl OnValidated(this UserControl control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static UserControl OnParentChanged(this UserControl control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static UserControl OnImeModeChanged(this UserControl control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static UserControl OnDisposed(this UserControl control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static UserControl AddTo(this UserControl control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static UserControl AddControls(this UserControl control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

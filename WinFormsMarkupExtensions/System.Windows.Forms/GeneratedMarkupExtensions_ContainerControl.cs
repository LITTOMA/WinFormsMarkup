using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ContainerControlExtensions
    {
        public static ContainerControl AutoScaleDimensions(this ContainerControl control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static ContainerControl AutoScaleMode(this ContainerControl control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static ContainerControl AutoValidate(this ContainerControl control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static ContainerControl BindingContext(this ContainerControl control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ContainerControl ActiveControl(this ContainerControl control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static ContainerControl AutoScroll(this ContainerControl control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ContainerControl AutoScrollMargin(this ContainerControl control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ContainerControl AutoScrollPosition(this ContainerControl control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ContainerControl AutoScrollMinSize(this ContainerControl control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ContainerControl AccessibleDefaultActionDescription(this ContainerControl control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ContainerControl AccessibleDescription(this ContainerControl control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ContainerControl AccessibleName(this ContainerControl control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ContainerControl AccessibleRole(this ContainerControl control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ContainerControl AllowDrop(this ContainerControl control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ContainerControl Anchor(this ContainerControl control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ContainerControl AutoSize(this ContainerControl control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ContainerControl AutoScrollOffset(this ContainerControl control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ContainerControl DataContext(this ContainerControl control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ContainerControl BackColor(this ContainerControl control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ContainerControl BackgroundImage(this ContainerControl control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ContainerControl BackgroundImageLayout(this ContainerControl control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ContainerControl Bounds(this ContainerControl control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ContainerControl Capture(this ContainerControl control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ContainerControl CausesValidation(this ContainerControl control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ContainerControl ClientSize(this ContainerControl control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ContainerControl ContextMenuStrip(this ContainerControl control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ContainerControl Cursor(this ContainerControl control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ContainerControl Dock(this ContainerControl control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ContainerControl Enabled(this ContainerControl control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ContainerControl Font(this ContainerControl control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ContainerControl ForeColor(this ContainerControl control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ContainerControl Height(this ContainerControl control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ContainerControl IsAccessible(this ContainerControl control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ContainerControl Left(this ContainerControl control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ContainerControl Location(this ContainerControl control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ContainerControl Margin(this ContainerControl control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ContainerControl MaximumSize(this ContainerControl control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ContainerControl MinimumSize(this ContainerControl control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ContainerControl Name(this ContainerControl control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ContainerControl Parent(this ContainerControl control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ContainerControl Region(this ContainerControl control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ContainerControl RightToLeft(this ContainerControl control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ContainerControl Size(this ContainerControl control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ContainerControl TabIndex(this ContainerControl control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ContainerControl TabStop(this ContainerControl control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ContainerControl Tag(this ContainerControl control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ContainerControl Text(this ContainerControl control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ContainerControl Top(this ContainerControl control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ContainerControl UseWaitCursor(this ContainerControl control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ContainerControl Visible(this ContainerControl control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ContainerControl Width(this ContainerControl control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ContainerControl WindowTarget(this ContainerControl control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ContainerControl Padding(this ContainerControl control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ContainerControl ImeMode(this ContainerControl control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ContainerControl OnAutoValidateChanged(this ContainerControl control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static ContainerControl OnScroll(this ContainerControl control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ContainerControl OnAutoSizeChanged(this ContainerControl control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ContainerControl OnBackColorChanged(this ContainerControl control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ContainerControl OnBackgroundImageChanged(this ContainerControl control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ContainerControl OnBackgroundImageLayoutChanged(this ContainerControl control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ContainerControl OnBindingContextChanged(this ContainerControl control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ContainerControl OnCausesValidationChanged(this ContainerControl control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ContainerControl OnClientSizeChanged(this ContainerControl control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ContainerControl OnContextMenuStripChanged(this ContainerControl control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ContainerControl OnCursorChanged(this ContainerControl control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ContainerControl OnDockChanged(this ContainerControl control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ContainerControl OnEnabledChanged(this ContainerControl control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ContainerControl OnFontChanged(this ContainerControl control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ContainerControl OnForeColorChanged(this ContainerControl control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ContainerControl OnLocationChanged(this ContainerControl control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ContainerControl OnMarginChanged(this ContainerControl control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ContainerControl OnRegionChanged(this ContainerControl control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ContainerControl OnRightToLeftChanged(this ContainerControl control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ContainerControl OnSizeChanged(this ContainerControl control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ContainerControl OnTabIndexChanged(this ContainerControl control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ContainerControl OnTabStopChanged(this ContainerControl control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ContainerControl OnTextChanged(this ContainerControl control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ContainerControl OnVisibleChanged(this ContainerControl control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ContainerControl OnClick(this ContainerControl control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ContainerControl OnControlAdded(this ContainerControl control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ContainerControl OnControlRemoved(this ContainerControl control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ContainerControl OnDataContextChanged(this ContainerControl control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ContainerControl OnDragDrop(this ContainerControl control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ContainerControl OnDragEnter(this ContainerControl control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ContainerControl OnDragOver(this ContainerControl control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ContainerControl OnDragLeave(this ContainerControl control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ContainerControl OnGiveFeedback(this ContainerControl control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ContainerControl OnHandleCreated(this ContainerControl control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ContainerControl OnHandleDestroyed(this ContainerControl control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ContainerControl OnHelpRequested(this ContainerControl control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ContainerControl OnInvalidated(this ContainerControl control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ContainerControl OnPaddingChanged(this ContainerControl control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ContainerControl OnPaint(this ContainerControl control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ContainerControl OnQueryContinueDrag(this ContainerControl control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ContainerControl OnQueryAccessibilityHelp(this ContainerControl control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ContainerControl OnDoubleClick(this ContainerControl control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ContainerControl OnEnter(this ContainerControl control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ContainerControl OnGotFocus(this ContainerControl control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ContainerControl OnKeyDown(this ContainerControl control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ContainerControl OnKeyPress(this ContainerControl control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ContainerControl OnKeyUp(this ContainerControl control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ContainerControl OnLayout(this ContainerControl control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ContainerControl OnLeave(this ContainerControl control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ContainerControl OnLostFocus(this ContainerControl control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ContainerControl OnMouseClick(this ContainerControl control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ContainerControl OnMouseDoubleClick(this ContainerControl control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ContainerControl OnMouseCaptureChanged(this ContainerControl control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ContainerControl OnMouseDown(this ContainerControl control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ContainerControl OnMouseEnter(this ContainerControl control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ContainerControl OnMouseLeave(this ContainerControl control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ContainerControl OnDpiChangedBeforeParent(this ContainerControl control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ContainerControl OnDpiChangedAfterParent(this ContainerControl control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ContainerControl OnMouseHover(this ContainerControl control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ContainerControl OnMouseMove(this ContainerControl control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ContainerControl OnMouseUp(this ContainerControl control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ContainerControl OnMouseWheel(this ContainerControl control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ContainerControl OnMove(this ContainerControl control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ContainerControl OnPreviewKeyDown(this ContainerControl control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ContainerControl OnResize(this ContainerControl control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ContainerControl OnChangeUICues(this ContainerControl control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ContainerControl OnStyleChanged(this ContainerControl control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ContainerControl OnSystemColorsChanged(this ContainerControl control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ContainerControl OnValidating(this ContainerControl control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ContainerControl OnValidated(this ContainerControl control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ContainerControl OnParentChanged(this ContainerControl control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ContainerControl OnImeModeChanged(this ContainerControl control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ContainerControl OnDisposed(this ContainerControl control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ContainerControl AddTo(this ContainerControl control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ContainerControl AddControls(this ContainerControl control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

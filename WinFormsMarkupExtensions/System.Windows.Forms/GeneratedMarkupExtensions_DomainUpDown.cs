using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class DomainUpDownExtensions
    {
        public static DomainUpDown Padding(this DomainUpDown control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static DomainUpDown SelectedIndex(this DomainUpDown control, Int32 value)
        {
            control.SelectedIndex = value;
            return control;
        }

        public static DomainUpDown SelectedItem(this DomainUpDown control, Object value)
        {
            control.SelectedItem = value;
            return control;
        }

        public static DomainUpDown Sorted(this DomainUpDown control, Boolean value)
        {
            control.Sorted = value;
            return control;
        }

        public static DomainUpDown Wrap(this DomainUpDown control, Boolean value)
        {
            control.Wrap = value;
            return control;
        }

        public static DomainUpDown AutoScroll(this DomainUpDown control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static DomainUpDown AutoScrollMargin(this DomainUpDown control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static DomainUpDown AutoScrollMinSize(this DomainUpDown control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static DomainUpDown AutoSize(this DomainUpDown control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static DomainUpDown BackColor(this DomainUpDown control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DomainUpDown BackgroundImage(this DomainUpDown control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static DomainUpDown BackgroundImageLayout(this DomainUpDown control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static DomainUpDown BorderStyle(this DomainUpDown control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static DomainUpDown ContextMenuStrip(this DomainUpDown control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static DomainUpDown ForeColor(this DomainUpDown control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DomainUpDown InterceptArrowKeys(this DomainUpDown control, Boolean value)
        {
            control.InterceptArrowKeys = value;
            return control;
        }

        public static DomainUpDown MaximumSize(this DomainUpDown control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static DomainUpDown MinimumSize(this DomainUpDown control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static DomainUpDown ReadOnly(this DomainUpDown control, Boolean value)
        {
            control.ReadOnly = value;
            return control;
        }

        public static DomainUpDown Text(this DomainUpDown control, String value)
        {
            control.Text = value;
            return control;
        }

        public static DomainUpDown TextAlign(this DomainUpDown control, HorizontalAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static DomainUpDown UpDownAlign(this DomainUpDown control, LeftRightAlignment value)
        {
            control.UpDownAlign = value;
            return control;
        }

        public static DomainUpDown AutoScaleDimensions(this DomainUpDown control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static DomainUpDown AutoScaleMode(this DomainUpDown control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static DomainUpDown AutoValidate(this DomainUpDown control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static DomainUpDown BindingContext(this DomainUpDown control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static DomainUpDown ActiveControl(this DomainUpDown control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static DomainUpDown AutoScrollPosition(this DomainUpDown control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static DomainUpDown AccessibleDefaultActionDescription(this DomainUpDown control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static DomainUpDown AccessibleDescription(this DomainUpDown control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static DomainUpDown AccessibleName(this DomainUpDown control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static DomainUpDown AccessibleRole(this DomainUpDown control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static DomainUpDown AllowDrop(this DomainUpDown control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static DomainUpDown Anchor(this DomainUpDown control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static DomainUpDown AutoScrollOffset(this DomainUpDown control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static DomainUpDown DataContext(this DomainUpDown control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static DomainUpDown Bounds(this DomainUpDown control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static DomainUpDown Capture(this DomainUpDown control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static DomainUpDown CausesValidation(this DomainUpDown control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static DomainUpDown ClientSize(this DomainUpDown control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static DomainUpDown Cursor(this DomainUpDown control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static DomainUpDown Dock(this DomainUpDown control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static DomainUpDown Enabled(this DomainUpDown control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static DomainUpDown Font(this DomainUpDown control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static DomainUpDown Height(this DomainUpDown control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static DomainUpDown IsAccessible(this DomainUpDown control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static DomainUpDown Left(this DomainUpDown control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static DomainUpDown Location(this DomainUpDown control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static DomainUpDown Margin(this DomainUpDown control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static DomainUpDown Name(this DomainUpDown control, String value)
        {
            control.Name = value;
            return control;
        }

        public static DomainUpDown Parent(this DomainUpDown control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static DomainUpDown Region(this DomainUpDown control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static DomainUpDown RightToLeft(this DomainUpDown control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static DomainUpDown Size(this DomainUpDown control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static DomainUpDown TabIndex(this DomainUpDown control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static DomainUpDown TabStop(this DomainUpDown control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static DomainUpDown Tag(this DomainUpDown control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static DomainUpDown Top(this DomainUpDown control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static DomainUpDown UseWaitCursor(this DomainUpDown control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static DomainUpDown Visible(this DomainUpDown control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static DomainUpDown Width(this DomainUpDown control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static DomainUpDown WindowTarget(this DomainUpDown control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static DomainUpDown ImeMode(this DomainUpDown control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static DomainUpDown OnPaddingChanged(this DomainUpDown control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static DomainUpDown OnSelectedItemChanged(this DomainUpDown control, EventHandler handler)
        {
            control.SelectedItemChanged += handler;
            return control;
        }

        public static DomainUpDown OnAutoSizeChanged(this DomainUpDown control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static DomainUpDown OnBackgroundImageChanged(this DomainUpDown control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static DomainUpDown OnBackgroundImageLayoutChanged(this DomainUpDown control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static DomainUpDown OnMouseEnter(this DomainUpDown control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static DomainUpDown OnMouseLeave(this DomainUpDown control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static DomainUpDown OnMouseHover(this DomainUpDown control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static DomainUpDown OnMouseMove(this DomainUpDown control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static DomainUpDown OnAutoValidateChanged(this DomainUpDown control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static DomainUpDown OnScroll(this DomainUpDown control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static DomainUpDown OnBackColorChanged(this DomainUpDown control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static DomainUpDown OnBindingContextChanged(this DomainUpDown control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static DomainUpDown OnCausesValidationChanged(this DomainUpDown control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static DomainUpDown OnClientSizeChanged(this DomainUpDown control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static DomainUpDown OnContextMenuStripChanged(this DomainUpDown control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static DomainUpDown OnCursorChanged(this DomainUpDown control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static DomainUpDown OnDockChanged(this DomainUpDown control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static DomainUpDown OnEnabledChanged(this DomainUpDown control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static DomainUpDown OnFontChanged(this DomainUpDown control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static DomainUpDown OnForeColorChanged(this DomainUpDown control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static DomainUpDown OnLocationChanged(this DomainUpDown control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static DomainUpDown OnMarginChanged(this DomainUpDown control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static DomainUpDown OnRegionChanged(this DomainUpDown control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static DomainUpDown OnRightToLeftChanged(this DomainUpDown control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static DomainUpDown OnSizeChanged(this DomainUpDown control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static DomainUpDown OnTabIndexChanged(this DomainUpDown control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static DomainUpDown OnTabStopChanged(this DomainUpDown control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static DomainUpDown OnTextChanged(this DomainUpDown control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static DomainUpDown OnVisibleChanged(this DomainUpDown control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static DomainUpDown OnClick(this DomainUpDown control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static DomainUpDown OnControlAdded(this DomainUpDown control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static DomainUpDown OnControlRemoved(this DomainUpDown control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static DomainUpDown OnDataContextChanged(this DomainUpDown control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static DomainUpDown OnDragDrop(this DomainUpDown control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static DomainUpDown OnDragEnter(this DomainUpDown control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static DomainUpDown OnDragOver(this DomainUpDown control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static DomainUpDown OnDragLeave(this DomainUpDown control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static DomainUpDown OnGiveFeedback(this DomainUpDown control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static DomainUpDown OnHandleCreated(this DomainUpDown control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static DomainUpDown OnHandleDestroyed(this DomainUpDown control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static DomainUpDown OnHelpRequested(this DomainUpDown control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static DomainUpDown OnInvalidated(this DomainUpDown control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static DomainUpDown OnPaint(this DomainUpDown control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static DomainUpDown OnQueryContinueDrag(this DomainUpDown control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static DomainUpDown OnQueryAccessibilityHelp(this DomainUpDown control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static DomainUpDown OnDoubleClick(this DomainUpDown control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static DomainUpDown OnEnter(this DomainUpDown control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static DomainUpDown OnGotFocus(this DomainUpDown control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static DomainUpDown OnKeyDown(this DomainUpDown control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static DomainUpDown OnKeyPress(this DomainUpDown control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static DomainUpDown OnKeyUp(this DomainUpDown control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static DomainUpDown OnLayout(this DomainUpDown control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static DomainUpDown OnLeave(this DomainUpDown control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static DomainUpDown OnLostFocus(this DomainUpDown control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static DomainUpDown OnMouseClick(this DomainUpDown control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static DomainUpDown OnMouseDoubleClick(this DomainUpDown control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static DomainUpDown OnMouseCaptureChanged(this DomainUpDown control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static DomainUpDown OnMouseDown(this DomainUpDown control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static DomainUpDown OnDpiChangedBeforeParent(this DomainUpDown control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static DomainUpDown OnDpiChangedAfterParent(this DomainUpDown control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static DomainUpDown OnMouseUp(this DomainUpDown control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static DomainUpDown OnMouseWheel(this DomainUpDown control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static DomainUpDown OnMove(this DomainUpDown control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static DomainUpDown OnPreviewKeyDown(this DomainUpDown control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static DomainUpDown OnResize(this DomainUpDown control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static DomainUpDown OnChangeUICues(this DomainUpDown control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static DomainUpDown OnStyleChanged(this DomainUpDown control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static DomainUpDown OnSystemColorsChanged(this DomainUpDown control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static DomainUpDown OnValidating(this DomainUpDown control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static DomainUpDown OnValidated(this DomainUpDown control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static DomainUpDown OnParentChanged(this DomainUpDown control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static DomainUpDown OnImeModeChanged(this DomainUpDown control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static DomainUpDown OnDisposed(this DomainUpDown control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static DomainUpDown AddTo(this DomainUpDown control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static DomainUpDown AddControls(this DomainUpDown control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class NumericUpDownExtensions
    {
        public static NumericUpDown DecimalPlaces(this NumericUpDown control, Int32 value)
        {
            control.DecimalPlaces = value;
            return control;
        }

        public static NumericUpDown Hexadecimal(this NumericUpDown control, Boolean value)
        {
            control.Hexadecimal = value;
            return control;
        }

        public static NumericUpDown Increment(this NumericUpDown control, Decimal value)
        {
            control.Increment = value;
            return control;
        }

        public static NumericUpDown Maximum(this NumericUpDown control, Decimal value)
        {
            control.Maximum = value;
            return control;
        }

        public static NumericUpDown Minimum(this NumericUpDown control, Decimal value)
        {
            control.Minimum = value;
            return control;
        }

        public static NumericUpDown Padding(this NumericUpDown control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static NumericUpDown Text(this NumericUpDown control, String value)
        {
            control.Text = value;
            return control;
        }

        public static NumericUpDown ThousandsSeparator(this NumericUpDown control, Boolean value)
        {
            control.ThousandsSeparator = value;
            return control;
        }

        public static NumericUpDown Value(this NumericUpDown control, Decimal value)
        {
            control.Value = value;
            return control;
        }

        public static NumericUpDown AutoScroll(this NumericUpDown control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static NumericUpDown AutoScrollMargin(this NumericUpDown control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static NumericUpDown AutoScrollMargin(this NumericUpDown control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static NumericUpDown AutoScrollMinSize(this NumericUpDown control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static NumericUpDown AutoScrollMinSize(this NumericUpDown control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static NumericUpDown AutoSize(this NumericUpDown control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static NumericUpDown BackColor(this NumericUpDown control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static NumericUpDown BackColor(this NumericUpDown control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static NumericUpDown BackColor(this NumericUpDown control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static NumericUpDown BackgroundImage(this NumericUpDown control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static NumericUpDown BackgroundImageLayout(this NumericUpDown control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static NumericUpDown BorderStyle(this NumericUpDown control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static NumericUpDown ContextMenuStrip(this NumericUpDown control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static NumericUpDown ForeColor(this NumericUpDown control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static NumericUpDown ForeColor(this NumericUpDown control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static NumericUpDown ForeColor(this NumericUpDown control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static NumericUpDown InterceptArrowKeys(this NumericUpDown control, Boolean value)
        {
            control.InterceptArrowKeys = value;
            return control;
        }

        public static NumericUpDown MaximumSize(this NumericUpDown control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static NumericUpDown MaximumSize(this NumericUpDown control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static NumericUpDown MinimumSize(this NumericUpDown control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static NumericUpDown MinimumSize(this NumericUpDown control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static NumericUpDown ReadOnly(this NumericUpDown control, Boolean value)
        {
            control.ReadOnly = value;
            return control;
        }

        public static NumericUpDown TextAlign(this NumericUpDown control, HorizontalAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static NumericUpDown UpDownAlign(this NumericUpDown control, LeftRightAlignment value)
        {
            control.UpDownAlign = value;
            return control;
        }

        public static NumericUpDown AutoScaleDimensions(this NumericUpDown control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static NumericUpDown AutoScaleMode(this NumericUpDown control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static NumericUpDown AutoValidate(this NumericUpDown control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static NumericUpDown BindingContext(this NumericUpDown control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static NumericUpDown ActiveControl(this NumericUpDown control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static NumericUpDown AutoScrollPosition(this NumericUpDown control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static NumericUpDown AutoScrollPosition(this NumericUpDown control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static NumericUpDown AccessibleDefaultActionDescription(this NumericUpDown control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static NumericUpDown AccessibleDescription(this NumericUpDown control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static NumericUpDown AccessibleName(this NumericUpDown control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static NumericUpDown AccessibleRole(this NumericUpDown control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static NumericUpDown AllowDrop(this NumericUpDown control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static NumericUpDown Anchor(this NumericUpDown control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static NumericUpDown AutoScrollOffset(this NumericUpDown control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static NumericUpDown AutoScrollOffset(this NumericUpDown control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static NumericUpDown DataContext(this NumericUpDown control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static NumericUpDown Bounds(this NumericUpDown control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static NumericUpDown Bounds(this NumericUpDown control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static NumericUpDown Bounds(this NumericUpDown control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static NumericUpDown Capture(this NumericUpDown control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static NumericUpDown CausesValidation(this NumericUpDown control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static NumericUpDown ClientSize(this NumericUpDown control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static NumericUpDown ClientSize(this NumericUpDown control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static NumericUpDown Cursor(this NumericUpDown control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static NumericUpDown Dock(this NumericUpDown control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static NumericUpDown Enabled(this NumericUpDown control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static NumericUpDown Font(this NumericUpDown control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static NumericUpDown Font(this NumericUpDown control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static NumericUpDown Height(this NumericUpDown control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static NumericUpDown IsAccessible(this NumericUpDown control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static NumericUpDown Left(this NumericUpDown control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static NumericUpDown Location(this NumericUpDown control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static NumericUpDown Location(this NumericUpDown control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static NumericUpDown Margin(this NumericUpDown control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static NumericUpDown Name(this NumericUpDown control, String value)
        {
            control.Name = value;
            return control;
        }

        public static NumericUpDown Parent(this NumericUpDown control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static NumericUpDown Region(this NumericUpDown control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static NumericUpDown RightToLeft(this NumericUpDown control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static NumericUpDown Size(this NumericUpDown control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static NumericUpDown Size(this NumericUpDown control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static NumericUpDown TabIndex(this NumericUpDown control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static NumericUpDown TabStop(this NumericUpDown control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static NumericUpDown Tag(this NumericUpDown control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static NumericUpDown Top(this NumericUpDown control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static NumericUpDown UseWaitCursor(this NumericUpDown control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static NumericUpDown Visible(this NumericUpDown control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static NumericUpDown Width(this NumericUpDown control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static NumericUpDown WindowTarget(this NumericUpDown control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static NumericUpDown ImeMode(this NumericUpDown control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static NumericUpDown OnPaddingChanged(this NumericUpDown control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static NumericUpDown OnTextChanged(this NumericUpDown control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static NumericUpDown OnValueChanged(this NumericUpDown control, EventHandler handler)
        {
            control.ValueChanged += handler;
            return control;
        }

        public static NumericUpDown OnAutoSizeChanged(this NumericUpDown control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static NumericUpDown OnBackgroundImageChanged(this NumericUpDown control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static NumericUpDown OnBackgroundImageLayoutChanged(this NumericUpDown control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static NumericUpDown OnMouseEnter(this NumericUpDown control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static NumericUpDown OnMouseLeave(this NumericUpDown control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static NumericUpDown OnMouseHover(this NumericUpDown control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static NumericUpDown OnMouseMove(this NumericUpDown control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static NumericUpDown OnAutoValidateChanged(this NumericUpDown control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static NumericUpDown OnScroll(this NumericUpDown control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static NumericUpDown OnBackColorChanged(this NumericUpDown control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static NumericUpDown OnBindingContextChanged(this NumericUpDown control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static NumericUpDown OnCausesValidationChanged(this NumericUpDown control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static NumericUpDown OnClientSizeChanged(this NumericUpDown control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static NumericUpDown OnContextMenuStripChanged(this NumericUpDown control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static NumericUpDown OnCursorChanged(this NumericUpDown control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static NumericUpDown OnDockChanged(this NumericUpDown control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static NumericUpDown OnEnabledChanged(this NumericUpDown control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static NumericUpDown OnFontChanged(this NumericUpDown control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static NumericUpDown OnForeColorChanged(this NumericUpDown control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static NumericUpDown OnLocationChanged(this NumericUpDown control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static NumericUpDown OnMarginChanged(this NumericUpDown control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static NumericUpDown OnRegionChanged(this NumericUpDown control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static NumericUpDown OnRightToLeftChanged(this NumericUpDown control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static NumericUpDown OnSizeChanged(this NumericUpDown control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static NumericUpDown OnTabIndexChanged(this NumericUpDown control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static NumericUpDown OnTabStopChanged(this NumericUpDown control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static NumericUpDown OnVisibleChanged(this NumericUpDown control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static NumericUpDown OnClick(this NumericUpDown control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static NumericUpDown OnControlAdded(this NumericUpDown control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static NumericUpDown OnControlRemoved(this NumericUpDown control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static NumericUpDown OnDataContextChanged(this NumericUpDown control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static NumericUpDown OnDragDrop(this NumericUpDown control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static NumericUpDown OnDragEnter(this NumericUpDown control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static NumericUpDown OnDragOver(this NumericUpDown control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static NumericUpDown OnDragLeave(this NumericUpDown control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static NumericUpDown OnGiveFeedback(this NumericUpDown control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static NumericUpDown OnHandleCreated(this NumericUpDown control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static NumericUpDown OnHandleDestroyed(this NumericUpDown control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static NumericUpDown OnHelpRequested(this NumericUpDown control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static NumericUpDown OnInvalidated(this NumericUpDown control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static NumericUpDown OnPaint(this NumericUpDown control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static NumericUpDown OnQueryContinueDrag(this NumericUpDown control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static NumericUpDown OnQueryAccessibilityHelp(this NumericUpDown control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static NumericUpDown OnDoubleClick(this NumericUpDown control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static NumericUpDown OnEnter(this NumericUpDown control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static NumericUpDown OnGotFocus(this NumericUpDown control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static NumericUpDown OnKeyDown(this NumericUpDown control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static NumericUpDown OnKeyPress(this NumericUpDown control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static NumericUpDown OnKeyUp(this NumericUpDown control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static NumericUpDown OnLayout(this NumericUpDown control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static NumericUpDown OnLeave(this NumericUpDown control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static NumericUpDown OnLostFocus(this NumericUpDown control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static NumericUpDown OnMouseClick(this NumericUpDown control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static NumericUpDown OnMouseDoubleClick(this NumericUpDown control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static NumericUpDown OnMouseCaptureChanged(this NumericUpDown control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static NumericUpDown OnMouseDown(this NumericUpDown control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static NumericUpDown OnDpiChangedBeforeParent(this NumericUpDown control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static NumericUpDown OnDpiChangedAfterParent(this NumericUpDown control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static NumericUpDown OnMouseUp(this NumericUpDown control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static NumericUpDown OnMouseWheel(this NumericUpDown control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static NumericUpDown OnMove(this NumericUpDown control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static NumericUpDown OnPreviewKeyDown(this NumericUpDown control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static NumericUpDown OnResize(this NumericUpDown control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static NumericUpDown OnChangeUICues(this NumericUpDown control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static NumericUpDown OnStyleChanged(this NumericUpDown control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static NumericUpDown OnSystemColorsChanged(this NumericUpDown control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static NumericUpDown OnValidating(this NumericUpDown control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static NumericUpDown OnValidated(this NumericUpDown control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static NumericUpDown OnParentChanged(this NumericUpDown control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static NumericUpDown OnImeModeChanged(this NumericUpDown control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static NumericUpDown OnDisposed(this NumericUpDown control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static NumericUpDown AddTo(this NumericUpDown control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static NumericUpDown AddControls(this NumericUpDown control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

        public static NumericUpDown Assign(this NumericUpDown control, out NumericUpDown variable)
        {
            variable = control;
            return control;
        }

    }
}

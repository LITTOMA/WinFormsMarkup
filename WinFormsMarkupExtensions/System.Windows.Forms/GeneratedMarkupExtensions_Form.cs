using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class FormExtensions
    {
        public static Form AcceptButton(this Form control, IButtonControl value)
        {
            control.AcceptButton = value;
            return control;
        }

        public static Form AllowTransparency(this Form control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static Form AutoScale(this Form control, Boolean value)
        {
            control.AutoScale = value;
            return control;
        }

        public static Form AutoScaleBaseSize(this Form control, int width, int height)
        {
            control.AutoScaleBaseSize = new Size(width, height);
            return control;
        }

        public static Form AutoScaleBaseSize(this Form control, Size size)
        {
            control.AutoScaleBaseSize = size;
            return control;
        }

        public static Form AutoScroll(this Form control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static Form AutoSize(this Form control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static Form AutoSizeMode(this Form control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static Form AutoValidate(this Form control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static Form BackColor(this Form control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Form BackColor(this Form control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Form BackColor(this Form control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static Form FormBorderStyle(this Form control, FormBorderStyle value)
        {
            control.FormBorderStyle = value;
            return control;
        }

        public static Form CancelButton(this Form control, IButtonControl value)
        {
            control.CancelButton = value;
            return control;
        }

        public static Form ClientSize(this Form control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static Form ClientSize(this Form control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static Form ControlBox(this Form control, Boolean value)
        {
            control.ControlBox = value;
            return control;
        }

        public static Form DesktopBounds(this Form control, int x, int y, int width, int height)
        {
            control.DesktopBounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static Form DesktopBounds(this Form control, Point location, Size size)
        {
            control.DesktopBounds = new Rectangle(location, size);
            return control;
        }

        public static Form DesktopBounds(this Form control, Rectangle rectangle)
        {
            control.DesktopBounds = rectangle;
            return control;
        }

        public static Form DesktopLocation(this Form control, int x, int y)
        {
            control.DesktopLocation = new Point(x, y);
            return control;
        }

        public static Form DesktopLocation(this Form control, Point point)
        {
            control.DesktopLocation = point;
            return control;
        }

        public static Form DialogResult(this Form control, DialogResult value)
        {
            control.DialogResult = value;
            return control;
        }

        public static Form HelpButton(this Form control, Boolean value)
        {
            control.HelpButton = value;
            return control;
        }

        public static Form Icon(this Form control, Icon value)
        {
            control.Icon = value;
            return control;
        }

        public static Form IsMdiContainer(this Form control, Boolean value)
        {
            control.IsMdiContainer = value;
            return control;
        }

        public static Form KeyPreview(this Form control, Boolean value)
        {
            control.KeyPreview = value;
            return control;
        }

        public static Form Location(this Form control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static Form Location(this Form control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static Form MaximumSize(this Form control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static Form MaximumSize(this Form control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static Form MainMenuStrip(this Form control, MenuStrip value)
        {
            control.MainMenuStrip = value;
            return control;
        }

        public static Form Margin(this Form control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static Form MinimumSize(this Form control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static Form MinimumSize(this Form control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static Form MaximizeBox(this Form control, Boolean value)
        {
            control.MaximizeBox = value;
            return control;
        }

        public static Form MdiChildrenMinimizedAnchorBottom(this Form control, Boolean value)
        {
            control.MdiChildrenMinimizedAnchorBottom = value;
            return control;
        }

        public static Form MdiParent(this Form control, Form value)
        {
            control.MdiParent = value;
            return control;
        }

        public static Form MinimizeBox(this Form control, Boolean value)
        {
            control.MinimizeBox = value;
            return control;
        }

        public static Form Opacity(this Form control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static Form Owner(this Form control, Form value)
        {
            control.Owner = value;
            return control;
        }

        public static Form RightToLeftLayout(this Form control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static Form ShowInTaskbar(this Form control, Boolean value)
        {
            control.ShowInTaskbar = value;
            return control;
        }

        public static Form ShowIcon(this Form control, Boolean value)
        {
            control.ShowIcon = value;
            return control;
        }

        public static Form Size(this Form control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static Form Size(this Form control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static Form SizeGripStyle(this Form control, SizeGripStyle value)
        {
            control.SizeGripStyle = value;
            return control;
        }

        public static Form StartPosition(this Form control, FormStartPosition value)
        {
            control.StartPosition = value;
            return control;
        }

        public static Form TabIndex(this Form control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static Form TabStop(this Form control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static Form Text(this Form control, String value)
        {
            control.Text = value;
            return control;
        }

        public static Form TopLevel(this Form control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static Form TopMost(this Form control, Boolean value)
        {
            control.TopMost = value;
            return control;
        }

        public static Form TransparencyKey(this Form control, int red, int green, int blue)
        {
            control.TransparencyKey = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Form TransparencyKey(this Form control, int red, int green, int blue, int alpha)
        {
            control.TransparencyKey = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Form TransparencyKey(this Form control, Color color)
        {
            control.TransparencyKey = color;
            return control;
        }

        public static Form WindowState(this Form control, FormWindowState value)
        {
            control.WindowState = value;
            return control;
        }

        public static Form AutoScaleDimensions(this Form control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static Form AutoScaleMode(this Form control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static Form BindingContext(this Form control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static Form ActiveControl(this Form control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static Form AutoScrollMargin(this Form control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static Form AutoScrollMargin(this Form control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static Form AutoScrollPosition(this Form control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static Form AutoScrollPosition(this Form control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static Form AutoScrollMinSize(this Form control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static Form AutoScrollMinSize(this Form control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static Form AccessibleDefaultActionDescription(this Form control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static Form AccessibleDescription(this Form control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static Form AccessibleName(this Form control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static Form AccessibleRole(this Form control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static Form AllowDrop(this Form control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static Form Anchor(this Form control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static Form AutoScrollOffset(this Form control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static Form AutoScrollOffset(this Form control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static Form DataContext(this Form control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static Form BackgroundImage(this Form control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static Form BackgroundImageLayout(this Form control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static Form Bounds(this Form control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static Form Bounds(this Form control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static Form Bounds(this Form control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static Form Capture(this Form control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static Form CausesValidation(this Form control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static Form ContextMenuStrip(this Form control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static Form Cursor(this Form control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static Form Dock(this Form control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static Form Enabled(this Form control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static Form Font(this Form control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static Form Font(this Form control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static Form ForeColor(this Form control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static Form ForeColor(this Form control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static Form ForeColor(this Form control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static Form Height(this Form control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static Form IsAccessible(this Form control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static Form Left(this Form control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static Form Name(this Form control, String value)
        {
            control.Name = value;
            return control;
        }

        public static Form Parent(this Form control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static Form Region(this Form control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static Form RightToLeft(this Form control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static Form Tag(this Form control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static Form Top(this Form control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static Form UseWaitCursor(this Form control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static Form Visible(this Form control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static Form Width(this Form control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static Form WindowTarget(this Form control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static Form Padding(this Form control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static Form ImeMode(this Form control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static Form OnAutoSizeChanged(this Form control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static Form OnAutoValidateChanged(this Form control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static Form OnHelpButtonClicked(this Form control, CancelEventHandler handler)
        {
            control.HelpButtonClicked += handler;
            return control;
        }

        public static Form OnMaximizedBoundsChanged(this Form control, EventHandler handler)
        {
            control.MaximizedBoundsChanged += handler;
            return control;
        }

        public static Form OnMaximumSizeChanged(this Form control, EventHandler handler)
        {
            control.MaximumSizeChanged += handler;
            return control;
        }

        public static Form OnMarginChanged(this Form control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static Form OnMinimumSizeChanged(this Form control, EventHandler handler)
        {
            control.MinimumSizeChanged += handler;
            return control;
        }

        public static Form OnTabIndexChanged(this Form control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static Form OnTabStopChanged(this Form control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static Form OnActivated(this Form control, EventHandler handler)
        {
            control.Activated += handler;
            return control;
        }

        public static Form OnClosing(this Form control, CancelEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static Form OnClosed(this Form control, EventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static Form OnDeactivate(this Form control, EventHandler handler)
        {
            control.Deactivate += handler;
            return control;
        }

        public static Form OnFormClosing(this Form control, FormClosingEventHandler handler)
        {
            control.FormClosing += handler;
            return control;
        }

        public static Form OnFormClosed(this Form control, FormClosedEventHandler handler)
        {
            control.FormClosed += handler;
            return control;
        }

        public static Form OnLoad(this Form control, EventHandler handler)
        {
            control.Load += handler;
            return control;
        }

        public static Form OnMdiChildActivate(this Form control, EventHandler handler)
        {
            control.MdiChildActivate += handler;
            return control;
        }

        public static Form OnMenuComplete(this Form control, EventHandler handler)
        {
            control.MenuComplete += handler;
            return control;
        }

        public static Form OnMenuStart(this Form control, EventHandler handler)
        {
            control.MenuStart += handler;
            return control;
        }

        public static Form OnInputLanguageChanged(this Form control, InputLanguageChangedEventHandler handler)
        {
            control.InputLanguageChanged += handler;
            return control;
        }

        public static Form OnInputLanguageChanging(this Form control, InputLanguageChangingEventHandler handler)
        {
            control.InputLanguageChanging += handler;
            return control;
        }

        public static Form OnRightToLeftLayoutChanged(this Form control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static Form OnShown(this Form control, EventHandler handler)
        {
            control.Shown += handler;
            return control;
        }

        public static Form OnDpiChanged(this Form control, DpiChangedEventHandler handler)
        {
            control.DpiChanged += handler;
            return control;
        }

        public static Form OnResizeBegin(this Form control, EventHandler handler)
        {
            control.ResizeBegin += handler;
            return control;
        }

        public static Form OnResizeEnd(this Form control, EventHandler handler)
        {
            control.ResizeEnd += handler;
            return control;
        }

        public static Form OnScroll(this Form control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static Form OnBackColorChanged(this Form control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static Form OnBackgroundImageChanged(this Form control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static Form OnBackgroundImageLayoutChanged(this Form control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static Form OnBindingContextChanged(this Form control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static Form OnCausesValidationChanged(this Form control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static Form OnClientSizeChanged(this Form control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static Form OnContextMenuStripChanged(this Form control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static Form OnCursorChanged(this Form control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static Form OnDockChanged(this Form control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static Form OnEnabledChanged(this Form control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static Form OnFontChanged(this Form control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static Form OnForeColorChanged(this Form control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static Form OnLocationChanged(this Form control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static Form OnRegionChanged(this Form control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static Form OnRightToLeftChanged(this Form control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static Form OnSizeChanged(this Form control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static Form OnTextChanged(this Form control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static Form OnVisibleChanged(this Form control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static Form OnClick(this Form control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static Form OnControlAdded(this Form control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static Form OnControlRemoved(this Form control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static Form OnDataContextChanged(this Form control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static Form OnDragDrop(this Form control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static Form OnDragEnter(this Form control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static Form OnDragOver(this Form control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static Form OnDragLeave(this Form control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static Form OnGiveFeedback(this Form control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static Form OnHandleCreated(this Form control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static Form OnHandleDestroyed(this Form control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static Form OnHelpRequested(this Form control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static Form OnInvalidated(this Form control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static Form OnPaddingChanged(this Form control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static Form OnPaint(this Form control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static Form OnQueryContinueDrag(this Form control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static Form OnQueryAccessibilityHelp(this Form control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static Form OnDoubleClick(this Form control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static Form OnEnter(this Form control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static Form OnGotFocus(this Form control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static Form OnKeyDown(this Form control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static Form OnKeyPress(this Form control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static Form OnKeyUp(this Form control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static Form OnLayout(this Form control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static Form OnLeave(this Form control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static Form OnLostFocus(this Form control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static Form OnMouseClick(this Form control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static Form OnMouseDoubleClick(this Form control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static Form OnMouseCaptureChanged(this Form control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static Form OnMouseDown(this Form control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static Form OnMouseEnter(this Form control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static Form OnMouseLeave(this Form control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static Form OnDpiChangedBeforeParent(this Form control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static Form OnDpiChangedAfterParent(this Form control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static Form OnMouseHover(this Form control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static Form OnMouseMove(this Form control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static Form OnMouseUp(this Form control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static Form OnMouseWheel(this Form control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static Form OnMove(this Form control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static Form OnPreviewKeyDown(this Form control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static Form OnResize(this Form control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static Form OnChangeUICues(this Form control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static Form OnStyleChanged(this Form control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static Form OnSystemColorsChanged(this Form control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static Form OnValidating(this Form control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static Form OnValidated(this Form control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static Form OnParentChanged(this Form control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static Form OnImeModeChanged(this Form control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static Form OnDisposed(this Form control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static Form AddTo(this Form control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static Form AddControls(this Form control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

        public static Form Assign(this Form control, out Form variable)
        {
            variable = control;
            return control;
        }

    }
}

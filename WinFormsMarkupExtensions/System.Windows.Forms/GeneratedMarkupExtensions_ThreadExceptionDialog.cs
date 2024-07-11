using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ThreadExceptionDialogExtensions
    {
        public static ThreadExceptionDialog AutoSize(this ThreadExceptionDialog control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ThreadExceptionDialog AcceptButton(this ThreadExceptionDialog control, IButtonControl value)
        {
            control.AcceptButton = value;
            return control;
        }

        public static ThreadExceptionDialog AllowTransparency(this ThreadExceptionDialog control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static ThreadExceptionDialog AutoScale(this ThreadExceptionDialog control, Boolean value)
        {
            control.AutoScale = value;
            return control;
        }

        public static ThreadExceptionDialog AutoScaleBaseSize(this ThreadExceptionDialog control, int width, int height)
        {
            control.AutoScaleBaseSize = new Size(width, height);
            return control;
        }

        public static ThreadExceptionDialog AutoScroll(this ThreadExceptionDialog control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ThreadExceptionDialog AutoSizeMode(this ThreadExceptionDialog control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static ThreadExceptionDialog AutoValidate(this ThreadExceptionDialog control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static ThreadExceptionDialog BackColor(this ThreadExceptionDialog control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ThreadExceptionDialog FormBorderStyle(this ThreadExceptionDialog control, FormBorderStyle value)
        {
            control.FormBorderStyle = value;
            return control;
        }

        public static ThreadExceptionDialog CancelButton(this ThreadExceptionDialog control, IButtonControl value)
        {
            control.CancelButton = value;
            return control;
        }

        public static ThreadExceptionDialog ClientSize(this ThreadExceptionDialog control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ThreadExceptionDialog ControlBox(this ThreadExceptionDialog control, Boolean value)
        {
            control.ControlBox = value;
            return control;
        }

        public static ThreadExceptionDialog DesktopBounds(this ThreadExceptionDialog control, int x, int y, int width, int height)
        {
            control.DesktopBounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ThreadExceptionDialog DesktopLocation(this ThreadExceptionDialog control, int x, int y)
        {
            control.DesktopLocation = new Point(x, y);
            return control;
        }

        public static ThreadExceptionDialog DialogResult(this ThreadExceptionDialog control, DialogResult value)
        {
            control.DialogResult = value;
            return control;
        }

        public static ThreadExceptionDialog HelpButton(this ThreadExceptionDialog control, Boolean value)
        {
            control.HelpButton = value;
            return control;
        }

        public static ThreadExceptionDialog Icon(this ThreadExceptionDialog control, Icon value)
        {
            control.Icon = value;
            return control;
        }

        public static ThreadExceptionDialog IsMdiContainer(this ThreadExceptionDialog control, Boolean value)
        {
            control.IsMdiContainer = value;
            return control;
        }

        public static ThreadExceptionDialog KeyPreview(this ThreadExceptionDialog control, Boolean value)
        {
            control.KeyPreview = value;
            return control;
        }

        public static ThreadExceptionDialog Location(this ThreadExceptionDialog control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ThreadExceptionDialog MaximumSize(this ThreadExceptionDialog control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ThreadExceptionDialog MainMenuStrip(this ThreadExceptionDialog control, MenuStrip value)
        {
            control.MainMenuStrip = value;
            return control;
        }

        public static ThreadExceptionDialog Margin(this ThreadExceptionDialog control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ThreadExceptionDialog MinimumSize(this ThreadExceptionDialog control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ThreadExceptionDialog MaximizeBox(this ThreadExceptionDialog control, Boolean value)
        {
            control.MaximizeBox = value;
            return control;
        }

        public static ThreadExceptionDialog MdiChildrenMinimizedAnchorBottom(this ThreadExceptionDialog control, Boolean value)
        {
            control.MdiChildrenMinimizedAnchorBottom = value;
            return control;
        }

        public static ThreadExceptionDialog MdiParent(this ThreadExceptionDialog control, Form value)
        {
            control.MdiParent = value;
            return control;
        }

        public static ThreadExceptionDialog MinimizeBox(this ThreadExceptionDialog control, Boolean value)
        {
            control.MinimizeBox = value;
            return control;
        }

        public static ThreadExceptionDialog Opacity(this ThreadExceptionDialog control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static ThreadExceptionDialog Owner(this ThreadExceptionDialog control, Form value)
        {
            control.Owner = value;
            return control;
        }

        public static ThreadExceptionDialog RightToLeftLayout(this ThreadExceptionDialog control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static ThreadExceptionDialog ShowInTaskbar(this ThreadExceptionDialog control, Boolean value)
        {
            control.ShowInTaskbar = value;
            return control;
        }

        public static ThreadExceptionDialog ShowIcon(this ThreadExceptionDialog control, Boolean value)
        {
            control.ShowIcon = value;
            return control;
        }

        public static ThreadExceptionDialog Size(this ThreadExceptionDialog control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ThreadExceptionDialog SizeGripStyle(this ThreadExceptionDialog control, SizeGripStyle value)
        {
            control.SizeGripStyle = value;
            return control;
        }

        public static ThreadExceptionDialog StartPosition(this ThreadExceptionDialog control, FormStartPosition value)
        {
            control.StartPosition = value;
            return control;
        }

        public static ThreadExceptionDialog TabIndex(this ThreadExceptionDialog control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ThreadExceptionDialog TabStop(this ThreadExceptionDialog control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ThreadExceptionDialog Text(this ThreadExceptionDialog control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ThreadExceptionDialog TopLevel(this ThreadExceptionDialog control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static ThreadExceptionDialog TopMost(this ThreadExceptionDialog control, Boolean value)
        {
            control.TopMost = value;
            return control;
        }

        public static ThreadExceptionDialog TransparencyKey(this ThreadExceptionDialog control, int red, int green, int blue)
        {
            control.TransparencyKey = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ThreadExceptionDialog WindowState(this ThreadExceptionDialog control, FormWindowState value)
        {
            control.WindowState = value;
            return control;
        }

        public static ThreadExceptionDialog AutoScaleDimensions(this ThreadExceptionDialog control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static ThreadExceptionDialog AutoScaleMode(this ThreadExceptionDialog control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static ThreadExceptionDialog BindingContext(this ThreadExceptionDialog control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ThreadExceptionDialog ActiveControl(this ThreadExceptionDialog control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static ThreadExceptionDialog AutoScrollMargin(this ThreadExceptionDialog control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ThreadExceptionDialog AutoScrollPosition(this ThreadExceptionDialog control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ThreadExceptionDialog AutoScrollMinSize(this ThreadExceptionDialog control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ThreadExceptionDialog AccessibleDefaultActionDescription(this ThreadExceptionDialog control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ThreadExceptionDialog AccessibleDescription(this ThreadExceptionDialog control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ThreadExceptionDialog AccessibleName(this ThreadExceptionDialog control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ThreadExceptionDialog AccessibleRole(this ThreadExceptionDialog control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ThreadExceptionDialog AllowDrop(this ThreadExceptionDialog control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ThreadExceptionDialog Anchor(this ThreadExceptionDialog control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ThreadExceptionDialog AutoScrollOffset(this ThreadExceptionDialog control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ThreadExceptionDialog DataContext(this ThreadExceptionDialog control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ThreadExceptionDialog BackgroundImage(this ThreadExceptionDialog control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ThreadExceptionDialog BackgroundImageLayout(this ThreadExceptionDialog control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ThreadExceptionDialog Bounds(this ThreadExceptionDialog control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ThreadExceptionDialog Capture(this ThreadExceptionDialog control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ThreadExceptionDialog CausesValidation(this ThreadExceptionDialog control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ThreadExceptionDialog ContextMenuStrip(this ThreadExceptionDialog control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ThreadExceptionDialog Cursor(this ThreadExceptionDialog control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ThreadExceptionDialog Dock(this ThreadExceptionDialog control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ThreadExceptionDialog Enabled(this ThreadExceptionDialog control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ThreadExceptionDialog Font(this ThreadExceptionDialog control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ThreadExceptionDialog ForeColor(this ThreadExceptionDialog control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ThreadExceptionDialog Height(this ThreadExceptionDialog control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ThreadExceptionDialog IsAccessible(this ThreadExceptionDialog control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ThreadExceptionDialog Left(this ThreadExceptionDialog control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ThreadExceptionDialog Name(this ThreadExceptionDialog control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ThreadExceptionDialog Parent(this ThreadExceptionDialog control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ThreadExceptionDialog Region(this ThreadExceptionDialog control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ThreadExceptionDialog RightToLeft(this ThreadExceptionDialog control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ThreadExceptionDialog Tag(this ThreadExceptionDialog control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ThreadExceptionDialog Top(this ThreadExceptionDialog control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ThreadExceptionDialog UseWaitCursor(this ThreadExceptionDialog control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ThreadExceptionDialog Visible(this ThreadExceptionDialog control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ThreadExceptionDialog Width(this ThreadExceptionDialog control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ThreadExceptionDialog WindowTarget(this ThreadExceptionDialog control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ThreadExceptionDialog Padding(this ThreadExceptionDialog control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ThreadExceptionDialog ImeMode(this ThreadExceptionDialog control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ThreadExceptionDialog OnAutoSizeChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnAutoValidateChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnHelpButtonClicked(this ThreadExceptionDialog control, CancelEventHandler handler)
        {
            control.HelpButtonClicked += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMaximizedBoundsChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MaximizedBoundsChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMaximumSizeChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MaximumSizeChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMarginChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMinimumSizeChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MinimumSizeChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnTabIndexChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnTabStopChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnActivated(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Activated += handler;
            return control;
        }

        public static ThreadExceptionDialog OnClosing(this ThreadExceptionDialog control, CancelEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static ThreadExceptionDialog OnClosed(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDeactivate(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Deactivate += handler;
            return control;
        }

        public static ThreadExceptionDialog OnFormClosing(this ThreadExceptionDialog control, FormClosingEventHandler handler)
        {
            control.FormClosing += handler;
            return control;
        }

        public static ThreadExceptionDialog OnFormClosed(this ThreadExceptionDialog control, FormClosedEventHandler handler)
        {
            control.FormClosed += handler;
            return control;
        }

        public static ThreadExceptionDialog OnLoad(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Load += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMdiChildActivate(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MdiChildActivate += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMenuComplete(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MenuComplete += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMenuStart(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MenuStart += handler;
            return control;
        }

        public static ThreadExceptionDialog OnInputLanguageChanged(this ThreadExceptionDialog control, InputLanguageChangedEventHandler handler)
        {
            control.InputLanguageChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnInputLanguageChanging(this ThreadExceptionDialog control, InputLanguageChangingEventHandler handler)
        {
            control.InputLanguageChanging += handler;
            return control;
        }

        public static ThreadExceptionDialog OnRightToLeftLayoutChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnShown(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Shown += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDpiChanged(this ThreadExceptionDialog control, DpiChangedEventHandler handler)
        {
            control.DpiChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnResizeBegin(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.ResizeBegin += handler;
            return control;
        }

        public static ThreadExceptionDialog OnResizeEnd(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.ResizeEnd += handler;
            return control;
        }

        public static ThreadExceptionDialog OnScroll(this ThreadExceptionDialog control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ThreadExceptionDialog OnBackColorChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnBackgroundImageChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnBackgroundImageLayoutChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnBindingContextChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnCausesValidationChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnClientSizeChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnContextMenuStripChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnCursorChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDockChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnEnabledChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnFontChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnForeColorChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnLocationChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnRegionChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnRightToLeftChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnSizeChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnTextChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnVisibleChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnClick(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ThreadExceptionDialog OnControlAdded(this ThreadExceptionDialog control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ThreadExceptionDialog OnControlRemoved(this ThreadExceptionDialog control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDataContextChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDragDrop(this ThreadExceptionDialog control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDragEnter(this ThreadExceptionDialog control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDragOver(this ThreadExceptionDialog control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDragLeave(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ThreadExceptionDialog OnGiveFeedback(this ThreadExceptionDialog control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ThreadExceptionDialog OnHandleCreated(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ThreadExceptionDialog OnHandleDestroyed(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ThreadExceptionDialog OnHelpRequested(this ThreadExceptionDialog control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ThreadExceptionDialog OnInvalidated(this ThreadExceptionDialog control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ThreadExceptionDialog OnPaddingChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnPaint(this ThreadExceptionDialog control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ThreadExceptionDialog OnQueryContinueDrag(this ThreadExceptionDialog control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ThreadExceptionDialog OnQueryAccessibilityHelp(this ThreadExceptionDialog control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDoubleClick(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ThreadExceptionDialog OnEnter(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ThreadExceptionDialog OnGotFocus(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ThreadExceptionDialog OnKeyDown(this ThreadExceptionDialog control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ThreadExceptionDialog OnKeyPress(this ThreadExceptionDialog control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ThreadExceptionDialog OnKeyUp(this ThreadExceptionDialog control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ThreadExceptionDialog OnLayout(this ThreadExceptionDialog control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ThreadExceptionDialog OnLeave(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ThreadExceptionDialog OnLostFocus(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseClick(this ThreadExceptionDialog control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseDoubleClick(this ThreadExceptionDialog control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseCaptureChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseDown(this ThreadExceptionDialog control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseEnter(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseLeave(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDpiChangedBeforeParent(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDpiChangedAfterParent(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseHover(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseMove(this ThreadExceptionDialog control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseUp(this ThreadExceptionDialog control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMouseWheel(this ThreadExceptionDialog control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ThreadExceptionDialog OnMove(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ThreadExceptionDialog OnPreviewKeyDown(this ThreadExceptionDialog control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ThreadExceptionDialog OnResize(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ThreadExceptionDialog OnChangeUICues(this ThreadExceptionDialog control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ThreadExceptionDialog OnStyleChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnSystemColorsChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnValidating(this ThreadExceptionDialog control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ThreadExceptionDialog OnValidated(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ThreadExceptionDialog OnParentChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnImeModeChanged(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ThreadExceptionDialog OnDisposed(this ThreadExceptionDialog control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ThreadExceptionDialog AddTo(this ThreadExceptionDialog control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ThreadExceptionDialog AddControls(this ThreadExceptionDialog control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

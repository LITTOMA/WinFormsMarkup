using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Printing;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class PrintPreviewDialogExtensions
    {
        public static PrintPreviewDialog AcceptButton(this PrintPreviewDialog control, IButtonControl value)
        {
            control.AcceptButton = value;
            return control;
        }

        public static PrintPreviewDialog AutoScale(this PrintPreviewDialog control, Boolean value)
        {
            control.AutoScale = value;
            return control;
        }

        public static PrintPreviewDialog AutoScroll(this PrintPreviewDialog control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static PrintPreviewDialog AutoSize(this PrintPreviewDialog control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static PrintPreviewDialog AutoValidate(this PrintPreviewDialog control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static PrintPreviewDialog BackColor(this PrintPreviewDialog control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PrintPreviewDialog CancelButton(this PrintPreviewDialog control, IButtonControl value)
        {
            control.CancelButton = value;
            return control;
        }

        public static PrintPreviewDialog ControlBox(this PrintPreviewDialog control, Boolean value)
        {
            control.ControlBox = value;
            return control;
        }

        public static PrintPreviewDialog ContextMenuStrip(this PrintPreviewDialog control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static PrintPreviewDialog FormBorderStyle(this PrintPreviewDialog control, FormBorderStyle value)
        {
            control.FormBorderStyle = value;
            return control;
        }

        public static PrintPreviewDialog HelpButton(this PrintPreviewDialog control, Boolean value)
        {
            control.HelpButton = value;
            return control;
        }

        public static PrintPreviewDialog Icon(this PrintPreviewDialog control, Icon value)
        {
            control.Icon = value;
            return control;
        }

        public static PrintPreviewDialog IsMdiContainer(this PrintPreviewDialog control, Boolean value)
        {
            control.IsMdiContainer = value;
            return control;
        }

        public static PrintPreviewDialog KeyPreview(this PrintPreviewDialog control, Boolean value)
        {
            control.KeyPreview = value;
            return control;
        }

        public static PrintPreviewDialog MaximumSize(this PrintPreviewDialog control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewDialog MaximizeBox(this PrintPreviewDialog control, Boolean value)
        {
            control.MaximizeBox = value;
            return control;
        }

        public static PrintPreviewDialog Margin(this PrintPreviewDialog control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static PrintPreviewDialog MinimumSize(this PrintPreviewDialog control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewDialog Padding(this PrintPreviewDialog control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static PrintPreviewDialog Size(this PrintPreviewDialog control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static PrintPreviewDialog StartPosition(this PrintPreviewDialog control, FormStartPosition value)
        {
            control.StartPosition = value;
            return control;
        }

        public static PrintPreviewDialog TopMost(this PrintPreviewDialog control, Boolean value)
        {
            control.TopMost = value;
            return control;
        }

        public static PrintPreviewDialog TransparencyKey(this PrintPreviewDialog control, int red, int green, int blue)
        {
            control.TransparencyKey = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PrintPreviewDialog UseWaitCursor(this PrintPreviewDialog control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static PrintPreviewDialog WindowState(this PrintPreviewDialog control, FormWindowState value)
        {
            control.WindowState = value;
            return control;
        }

        public static PrintPreviewDialog AccessibleRole(this PrintPreviewDialog control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static PrintPreviewDialog AccessibleDescription(this PrintPreviewDialog control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static PrintPreviewDialog AccessibleName(this PrintPreviewDialog control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static PrintPreviewDialog CausesValidation(this PrintPreviewDialog control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static PrintPreviewDialog Enabled(this PrintPreviewDialog control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static PrintPreviewDialog Location(this PrintPreviewDialog control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static PrintPreviewDialog Tag(this PrintPreviewDialog control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static PrintPreviewDialog AllowDrop(this PrintPreviewDialog control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static PrintPreviewDialog Cursor(this PrintPreviewDialog control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static PrintPreviewDialog BackgroundImage(this PrintPreviewDialog control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static PrintPreviewDialog BackgroundImageLayout(this PrintPreviewDialog control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static PrintPreviewDialog ImeMode(this PrintPreviewDialog control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static PrintPreviewDialog AutoScrollMargin(this PrintPreviewDialog control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static PrintPreviewDialog AutoScrollMinSize(this PrintPreviewDialog control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewDialog Anchor(this PrintPreviewDialog control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static PrintPreviewDialog Visible(this PrintPreviewDialog control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static PrintPreviewDialog ForeColor(this PrintPreviewDialog control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PrintPreviewDialog RightToLeft(this PrintPreviewDialog control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static PrintPreviewDialog RightToLeftLayout(this PrintPreviewDialog control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static PrintPreviewDialog TabStop(this PrintPreviewDialog control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static PrintPreviewDialog Text(this PrintPreviewDialog control, String value)
        {
            control.Text = value;
            return control;
        }

        public static PrintPreviewDialog Dock(this PrintPreviewDialog control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static PrintPreviewDialog Font(this PrintPreviewDialog control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static PrintPreviewDialog UseAntiAlias(this PrintPreviewDialog control, Boolean value)
        {
            control.UseAntiAlias = value;
            return control;
        }

        public static PrintPreviewDialog AutoScaleBaseSize(this PrintPreviewDialog control, int width, int height)
        {
            control.AutoScaleBaseSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewDialog Document(this PrintPreviewDialog control, PrintDocument value)
        {
            control.Document = value;
            return control;
        }

        public static PrintPreviewDialog MinimizeBox(this PrintPreviewDialog control, Boolean value)
        {
            control.MinimizeBox = value;
            return control;
        }

        public static PrintPreviewDialog Opacity(this PrintPreviewDialog control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static PrintPreviewDialog ShowInTaskbar(this PrintPreviewDialog control, Boolean value)
        {
            control.ShowInTaskbar = value;
            return control;
        }

        public static PrintPreviewDialog SizeGripStyle(this PrintPreviewDialog control, SizeGripStyle value)
        {
            control.SizeGripStyle = value;
            return control;
        }

        public static PrintPreviewDialog AllowTransparency(this PrintPreviewDialog control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static PrintPreviewDialog AutoSizeMode(this PrintPreviewDialog control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static PrintPreviewDialog ClientSize(this PrintPreviewDialog control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static PrintPreviewDialog DesktopBounds(this PrintPreviewDialog control, int x, int y, int width, int height)
        {
            control.DesktopBounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static PrintPreviewDialog DesktopLocation(this PrintPreviewDialog control, int x, int y)
        {
            control.DesktopLocation = new Point(x, y);
            return control;
        }

        public static PrintPreviewDialog DialogResult(this PrintPreviewDialog control, DialogResult value)
        {
            control.DialogResult = value;
            return control;
        }

        public static PrintPreviewDialog MainMenuStrip(this PrintPreviewDialog control, MenuStrip value)
        {
            control.MainMenuStrip = value;
            return control;
        }

        public static PrintPreviewDialog MdiChildrenMinimizedAnchorBottom(this PrintPreviewDialog control, Boolean value)
        {
            control.MdiChildrenMinimizedAnchorBottom = value;
            return control;
        }

        public static PrintPreviewDialog MdiParent(this PrintPreviewDialog control, Form value)
        {
            control.MdiParent = value;
            return control;
        }

        public static PrintPreviewDialog Owner(this PrintPreviewDialog control, Form value)
        {
            control.Owner = value;
            return control;
        }

        public static PrintPreviewDialog ShowIcon(this PrintPreviewDialog control, Boolean value)
        {
            control.ShowIcon = value;
            return control;
        }

        public static PrintPreviewDialog TabIndex(this PrintPreviewDialog control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static PrintPreviewDialog TopLevel(this PrintPreviewDialog control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static PrintPreviewDialog AutoScaleDimensions(this PrintPreviewDialog control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static PrintPreviewDialog AutoScaleMode(this PrintPreviewDialog control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static PrintPreviewDialog BindingContext(this PrintPreviewDialog control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static PrintPreviewDialog ActiveControl(this PrintPreviewDialog control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static PrintPreviewDialog AutoScrollPosition(this PrintPreviewDialog control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static PrintPreviewDialog AccessibleDefaultActionDescription(this PrintPreviewDialog control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static PrintPreviewDialog AutoScrollOffset(this PrintPreviewDialog control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static PrintPreviewDialog DataContext(this PrintPreviewDialog control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static PrintPreviewDialog Bounds(this PrintPreviewDialog control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static PrintPreviewDialog Capture(this PrintPreviewDialog control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static PrintPreviewDialog Height(this PrintPreviewDialog control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static PrintPreviewDialog IsAccessible(this PrintPreviewDialog control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static PrintPreviewDialog Left(this PrintPreviewDialog control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static PrintPreviewDialog Name(this PrintPreviewDialog control, String value)
        {
            control.Name = value;
            return control;
        }

        public static PrintPreviewDialog Parent(this PrintPreviewDialog control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static PrintPreviewDialog Region(this PrintPreviewDialog control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static PrintPreviewDialog Top(this PrintPreviewDialog control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static PrintPreviewDialog Width(this PrintPreviewDialog control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static PrintPreviewDialog WindowTarget(this PrintPreviewDialog control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static PrintPreviewDialog OnAutoSizeChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnAutoValidateChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnBackColorChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnContextMenuStripChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnMaximumSizeChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MaximumSizeChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnMarginChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnMinimumSizeChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MinimumSizeChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnPaddingChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnSizeChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnCausesValidationChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnEnabledChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnLocationChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnCursorChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnBackgroundImageChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnBackgroundImageLayoutChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnImeModeChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnVisibleChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnForeColorChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnRightToLeftChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnRightToLeftLayoutChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnTabStopChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnTextChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnDockChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnFontChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnHelpButtonClicked(this PrintPreviewDialog control, CancelEventHandler handler)
        {
            control.HelpButtonClicked += handler;
            return control;
        }

        public static PrintPreviewDialog OnMaximizedBoundsChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MaximizedBoundsChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnTabIndexChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnActivated(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Activated += handler;
            return control;
        }

        public static PrintPreviewDialog OnClosing(this PrintPreviewDialog control, CancelEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static PrintPreviewDialog OnClosed(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static PrintPreviewDialog OnDeactivate(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Deactivate += handler;
            return control;
        }

        public static PrintPreviewDialog OnFormClosing(this PrintPreviewDialog control, FormClosingEventHandler handler)
        {
            control.FormClosing += handler;
            return control;
        }

        public static PrintPreviewDialog OnFormClosed(this PrintPreviewDialog control, FormClosedEventHandler handler)
        {
            control.FormClosed += handler;
            return control;
        }

        public static PrintPreviewDialog OnLoad(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Load += handler;
            return control;
        }

        public static PrintPreviewDialog OnMdiChildActivate(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MdiChildActivate += handler;
            return control;
        }

        public static PrintPreviewDialog OnMenuComplete(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MenuComplete += handler;
            return control;
        }

        public static PrintPreviewDialog OnMenuStart(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MenuStart += handler;
            return control;
        }

        public static PrintPreviewDialog OnInputLanguageChanged(this PrintPreviewDialog control, InputLanguageChangedEventHandler handler)
        {
            control.InputLanguageChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnInputLanguageChanging(this PrintPreviewDialog control, InputLanguageChangingEventHandler handler)
        {
            control.InputLanguageChanging += handler;
            return control;
        }

        public static PrintPreviewDialog OnShown(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Shown += handler;
            return control;
        }

        public static PrintPreviewDialog OnDpiChanged(this PrintPreviewDialog control, DpiChangedEventHandler handler)
        {
            control.DpiChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnResizeBegin(this PrintPreviewDialog control, EventHandler handler)
        {
            control.ResizeBegin += handler;
            return control;
        }

        public static PrintPreviewDialog OnResizeEnd(this PrintPreviewDialog control, EventHandler handler)
        {
            control.ResizeEnd += handler;
            return control;
        }

        public static PrintPreviewDialog OnScroll(this PrintPreviewDialog control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static PrintPreviewDialog OnBindingContextChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnClientSizeChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnRegionChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnClick(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static PrintPreviewDialog OnControlAdded(this PrintPreviewDialog control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static PrintPreviewDialog OnControlRemoved(this PrintPreviewDialog control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static PrintPreviewDialog OnDataContextChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnDragDrop(this PrintPreviewDialog control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static PrintPreviewDialog OnDragEnter(this PrintPreviewDialog control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static PrintPreviewDialog OnDragOver(this PrintPreviewDialog control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static PrintPreviewDialog OnDragLeave(this PrintPreviewDialog control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static PrintPreviewDialog OnGiveFeedback(this PrintPreviewDialog control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static PrintPreviewDialog OnHandleCreated(this PrintPreviewDialog control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static PrintPreviewDialog OnHandleDestroyed(this PrintPreviewDialog control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static PrintPreviewDialog OnHelpRequested(this PrintPreviewDialog control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static PrintPreviewDialog OnInvalidated(this PrintPreviewDialog control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static PrintPreviewDialog OnPaint(this PrintPreviewDialog control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static PrintPreviewDialog OnQueryContinueDrag(this PrintPreviewDialog control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static PrintPreviewDialog OnQueryAccessibilityHelp(this PrintPreviewDialog control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static PrintPreviewDialog OnDoubleClick(this PrintPreviewDialog control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static PrintPreviewDialog OnEnter(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static PrintPreviewDialog OnGotFocus(this PrintPreviewDialog control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static PrintPreviewDialog OnKeyDown(this PrintPreviewDialog control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static PrintPreviewDialog OnKeyPress(this PrintPreviewDialog control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static PrintPreviewDialog OnKeyUp(this PrintPreviewDialog control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static PrintPreviewDialog OnLayout(this PrintPreviewDialog control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static PrintPreviewDialog OnLeave(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static PrintPreviewDialog OnLostFocus(this PrintPreviewDialog control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseClick(this PrintPreviewDialog control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseDoubleClick(this PrintPreviewDialog control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseCaptureChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseDown(this PrintPreviewDialog control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseEnter(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseLeave(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static PrintPreviewDialog OnDpiChangedBeforeParent(this PrintPreviewDialog control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static PrintPreviewDialog OnDpiChangedAfterParent(this PrintPreviewDialog control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseHover(this PrintPreviewDialog control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseMove(this PrintPreviewDialog control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseUp(this PrintPreviewDialog control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static PrintPreviewDialog OnMouseWheel(this PrintPreviewDialog control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static PrintPreviewDialog OnMove(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static PrintPreviewDialog OnPreviewKeyDown(this PrintPreviewDialog control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static PrintPreviewDialog OnResize(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static PrintPreviewDialog OnChangeUICues(this PrintPreviewDialog control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static PrintPreviewDialog OnStyleChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnSystemColorsChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnValidating(this PrintPreviewDialog control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static PrintPreviewDialog OnValidated(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static PrintPreviewDialog OnParentChanged(this PrintPreviewDialog control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static PrintPreviewDialog OnDisposed(this PrintPreviewDialog control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static PrintPreviewDialog AddTo(this PrintPreviewDialog control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static PrintPreviewDialog AddControls(this PrintPreviewDialog control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

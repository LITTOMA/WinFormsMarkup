using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ComponentEditorFormExtensions
    {
        public static ComponentEditorForm AutoSize(this ComponentEditorForm control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ComponentEditorForm AcceptButton(this ComponentEditorForm control, IButtonControl value)
        {
            control.AcceptButton = value;
            return control;
        }

        public static ComponentEditorForm AllowTransparency(this ComponentEditorForm control, Boolean value)
        {
            control.AllowTransparency = value;
            return control;
        }

        public static ComponentEditorForm AutoScale(this ComponentEditorForm control, Boolean value)
        {
            control.AutoScale = value;
            return control;
        }

        public static ComponentEditorForm AutoScaleBaseSize(this ComponentEditorForm control, int width, int height)
        {
            control.AutoScaleBaseSize = new Size(width, height);
            return control;
        }

        public static ComponentEditorForm AutoScaleBaseSize(this ComponentEditorForm control, Size size)
        {
            control.AutoScaleBaseSize = size;
            return control;
        }

        public static ComponentEditorForm AutoScroll(this ComponentEditorForm control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static ComponentEditorForm AutoSizeMode(this ComponentEditorForm control, AutoSizeMode value)
        {
            control.AutoSizeMode = value;
            return control;
        }

        public static ComponentEditorForm AutoValidate(this ComponentEditorForm control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static ComponentEditorForm BackColor(this ComponentEditorForm control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ComponentEditorForm BackColor(this ComponentEditorForm control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ComponentEditorForm BackColor(this ComponentEditorForm control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ComponentEditorForm FormBorderStyle(this ComponentEditorForm control, FormBorderStyle value)
        {
            control.FormBorderStyle = value;
            return control;
        }

        public static ComponentEditorForm CancelButton(this ComponentEditorForm control, IButtonControl value)
        {
            control.CancelButton = value;
            return control;
        }

        public static ComponentEditorForm ClientSize(this ComponentEditorForm control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ComponentEditorForm ClientSize(this ComponentEditorForm control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ComponentEditorForm ControlBox(this ComponentEditorForm control, Boolean value)
        {
            control.ControlBox = value;
            return control;
        }

        public static ComponentEditorForm DesktopBounds(this ComponentEditorForm control, int x, int y, int width, int height)
        {
            control.DesktopBounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ComponentEditorForm DesktopBounds(this ComponentEditorForm control, Point location, Size size)
        {
            control.DesktopBounds = new Rectangle(location, size);
            return control;
        }

        public static ComponentEditorForm DesktopBounds(this ComponentEditorForm control, Rectangle rectangle)
        {
            control.DesktopBounds = rectangle;
            return control;
        }

        public static ComponentEditorForm DesktopLocation(this ComponentEditorForm control, int x, int y)
        {
            control.DesktopLocation = new Point(x, y);
            return control;
        }

        public static ComponentEditorForm DesktopLocation(this ComponentEditorForm control, Point point)
        {
            control.DesktopLocation = point;
            return control;
        }

        public static ComponentEditorForm DialogResult(this ComponentEditorForm control, DialogResult value)
        {
            control.DialogResult = value;
            return control;
        }

        public static ComponentEditorForm HelpButton(this ComponentEditorForm control, Boolean value)
        {
            control.HelpButton = value;
            return control;
        }

        public static ComponentEditorForm Icon(this ComponentEditorForm control, Icon value)
        {
            control.Icon = value;
            return control;
        }

        public static ComponentEditorForm IsMdiContainer(this ComponentEditorForm control, Boolean value)
        {
            control.IsMdiContainer = value;
            return control;
        }

        public static ComponentEditorForm KeyPreview(this ComponentEditorForm control, Boolean value)
        {
            control.KeyPreview = value;
            return control;
        }

        public static ComponentEditorForm Location(this ComponentEditorForm control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ComponentEditorForm Location(this ComponentEditorForm control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ComponentEditorForm MaximumSize(this ComponentEditorForm control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ComponentEditorForm MaximumSize(this ComponentEditorForm control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ComponentEditorForm MainMenuStrip(this ComponentEditorForm control, MenuStrip value)
        {
            control.MainMenuStrip = value;
            return control;
        }

        public static ComponentEditorForm Margin(this ComponentEditorForm control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ComponentEditorForm MinimumSize(this ComponentEditorForm control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ComponentEditorForm MinimumSize(this ComponentEditorForm control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ComponentEditorForm MaximizeBox(this ComponentEditorForm control, Boolean value)
        {
            control.MaximizeBox = value;
            return control;
        }

        public static ComponentEditorForm MdiChildrenMinimizedAnchorBottom(this ComponentEditorForm control, Boolean value)
        {
            control.MdiChildrenMinimizedAnchorBottom = value;
            return control;
        }

        public static ComponentEditorForm MdiParent(this ComponentEditorForm control, Form value)
        {
            control.MdiParent = value;
            return control;
        }

        public static ComponentEditorForm MinimizeBox(this ComponentEditorForm control, Boolean value)
        {
            control.MinimizeBox = value;
            return control;
        }

        public static ComponentEditorForm Opacity(this ComponentEditorForm control, Double value)
        {
            control.Opacity = value;
            return control;
        }

        public static ComponentEditorForm Owner(this ComponentEditorForm control, Form value)
        {
            control.Owner = value;
            return control;
        }

        public static ComponentEditorForm RightToLeftLayout(this ComponentEditorForm control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static ComponentEditorForm ShowInTaskbar(this ComponentEditorForm control, Boolean value)
        {
            control.ShowInTaskbar = value;
            return control;
        }

        public static ComponentEditorForm ShowIcon(this ComponentEditorForm control, Boolean value)
        {
            control.ShowIcon = value;
            return control;
        }

        public static ComponentEditorForm Size(this ComponentEditorForm control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ComponentEditorForm Size(this ComponentEditorForm control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ComponentEditorForm SizeGripStyle(this ComponentEditorForm control, SizeGripStyle value)
        {
            control.SizeGripStyle = value;
            return control;
        }

        public static ComponentEditorForm StartPosition(this ComponentEditorForm control, FormStartPosition value)
        {
            control.StartPosition = value;
            return control;
        }

        public static ComponentEditorForm TabIndex(this ComponentEditorForm control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ComponentEditorForm TabStop(this ComponentEditorForm control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ComponentEditorForm Text(this ComponentEditorForm control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ComponentEditorForm TopLevel(this ComponentEditorForm control, Boolean value)
        {
            control.TopLevel = value;
            return control;
        }

        public static ComponentEditorForm TopMost(this ComponentEditorForm control, Boolean value)
        {
            control.TopMost = value;
            return control;
        }

        public static ComponentEditorForm TransparencyKey(this ComponentEditorForm control, int red, int green, int blue)
        {
            control.TransparencyKey = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ComponentEditorForm TransparencyKey(this ComponentEditorForm control, int red, int green, int blue, int alpha)
        {
            control.TransparencyKey = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ComponentEditorForm TransparencyKey(this ComponentEditorForm control, Color color)
        {
            control.TransparencyKey = color;
            return control;
        }

        public static ComponentEditorForm WindowState(this ComponentEditorForm control, FormWindowState value)
        {
            control.WindowState = value;
            return control;
        }

        public static ComponentEditorForm AutoScaleDimensions(this ComponentEditorForm control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static ComponentEditorForm AutoScaleMode(this ComponentEditorForm control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static ComponentEditorForm BindingContext(this ComponentEditorForm control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ComponentEditorForm ActiveControl(this ComponentEditorForm control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static ComponentEditorForm AutoScrollMargin(this ComponentEditorForm control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static ComponentEditorForm AutoScrollMargin(this ComponentEditorForm control, Size size)
        {
            control.AutoScrollMargin = size;
            return control;
        }

        public static ComponentEditorForm AutoScrollPosition(this ComponentEditorForm control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static ComponentEditorForm AutoScrollPosition(this ComponentEditorForm control, Point point)
        {
            control.AutoScrollPosition = point;
            return control;
        }

        public static ComponentEditorForm AutoScrollMinSize(this ComponentEditorForm control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static ComponentEditorForm AutoScrollMinSize(this ComponentEditorForm control, Size size)
        {
            control.AutoScrollMinSize = size;
            return control;
        }

        public static ComponentEditorForm AccessibleDefaultActionDescription(this ComponentEditorForm control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ComponentEditorForm AccessibleDescription(this ComponentEditorForm control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ComponentEditorForm AccessibleName(this ComponentEditorForm control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ComponentEditorForm AccessibleRole(this ComponentEditorForm control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ComponentEditorForm AllowDrop(this ComponentEditorForm control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ComponentEditorForm Anchor(this ComponentEditorForm control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ComponentEditorForm AutoScrollOffset(this ComponentEditorForm control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ComponentEditorForm AutoScrollOffset(this ComponentEditorForm control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ComponentEditorForm DataContext(this ComponentEditorForm control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ComponentEditorForm BackgroundImage(this ComponentEditorForm control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ComponentEditorForm BackgroundImageLayout(this ComponentEditorForm control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ComponentEditorForm Bounds(this ComponentEditorForm control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ComponentEditorForm Bounds(this ComponentEditorForm control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ComponentEditorForm Bounds(this ComponentEditorForm control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ComponentEditorForm Capture(this ComponentEditorForm control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ComponentEditorForm CausesValidation(this ComponentEditorForm control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ComponentEditorForm ContextMenuStrip(this ComponentEditorForm control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ComponentEditorForm Cursor(this ComponentEditorForm control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ComponentEditorForm Dock(this ComponentEditorForm control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ComponentEditorForm Enabled(this ComponentEditorForm control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ComponentEditorForm Font(this ComponentEditorForm control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ComponentEditorForm Font(this ComponentEditorForm control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ComponentEditorForm ForeColor(this ComponentEditorForm control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ComponentEditorForm ForeColor(this ComponentEditorForm control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ComponentEditorForm ForeColor(this ComponentEditorForm control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ComponentEditorForm Height(this ComponentEditorForm control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ComponentEditorForm IsAccessible(this ComponentEditorForm control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ComponentEditorForm Left(this ComponentEditorForm control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ComponentEditorForm Name(this ComponentEditorForm control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ComponentEditorForm Parent(this ComponentEditorForm control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ComponentEditorForm Region(this ComponentEditorForm control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ComponentEditorForm RightToLeft(this ComponentEditorForm control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ComponentEditorForm Tag(this ComponentEditorForm control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ComponentEditorForm Top(this ComponentEditorForm control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ComponentEditorForm UseWaitCursor(this ComponentEditorForm control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ComponentEditorForm Visible(this ComponentEditorForm control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ComponentEditorForm Width(this ComponentEditorForm control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ComponentEditorForm WindowTarget(this ComponentEditorForm control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ComponentEditorForm Padding(this ComponentEditorForm control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ComponentEditorForm ImeMode(this ComponentEditorForm control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ComponentEditorForm OnAutoSizeChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnAutoValidateChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnHelpButtonClicked(this ComponentEditorForm control, CancelEventHandler handler)
        {
            control.HelpButtonClicked += handler;
            return control;
        }

        public static ComponentEditorForm OnMaximizedBoundsChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.MaximizedBoundsChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnMaximumSizeChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.MaximumSizeChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnMarginChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnMinimumSizeChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.MinimumSizeChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnTabIndexChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnTabStopChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnActivated(this ComponentEditorForm control, EventHandler handler)
        {
            control.Activated += handler;
            return control;
        }

        public static ComponentEditorForm OnClosing(this ComponentEditorForm control, CancelEventHandler handler)
        {
            control.Closing += handler;
            return control;
        }

        public static ComponentEditorForm OnClosed(this ComponentEditorForm control, EventHandler handler)
        {
            control.Closed += handler;
            return control;
        }

        public static ComponentEditorForm OnDeactivate(this ComponentEditorForm control, EventHandler handler)
        {
            control.Deactivate += handler;
            return control;
        }

        public static ComponentEditorForm OnFormClosing(this ComponentEditorForm control, FormClosingEventHandler handler)
        {
            control.FormClosing += handler;
            return control;
        }

        public static ComponentEditorForm OnFormClosed(this ComponentEditorForm control, FormClosedEventHandler handler)
        {
            control.FormClosed += handler;
            return control;
        }

        public static ComponentEditorForm OnLoad(this ComponentEditorForm control, EventHandler handler)
        {
            control.Load += handler;
            return control;
        }

        public static ComponentEditorForm OnMdiChildActivate(this ComponentEditorForm control, EventHandler handler)
        {
            control.MdiChildActivate += handler;
            return control;
        }

        public static ComponentEditorForm OnMenuComplete(this ComponentEditorForm control, EventHandler handler)
        {
            control.MenuComplete += handler;
            return control;
        }

        public static ComponentEditorForm OnMenuStart(this ComponentEditorForm control, EventHandler handler)
        {
            control.MenuStart += handler;
            return control;
        }

        public static ComponentEditorForm OnInputLanguageChanged(this ComponentEditorForm control, InputLanguageChangedEventHandler handler)
        {
            control.InputLanguageChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnInputLanguageChanging(this ComponentEditorForm control, InputLanguageChangingEventHandler handler)
        {
            control.InputLanguageChanging += handler;
            return control;
        }

        public static ComponentEditorForm OnRightToLeftLayoutChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnShown(this ComponentEditorForm control, EventHandler handler)
        {
            control.Shown += handler;
            return control;
        }

        public static ComponentEditorForm OnDpiChanged(this ComponentEditorForm control, DpiChangedEventHandler handler)
        {
            control.DpiChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnResizeBegin(this ComponentEditorForm control, EventHandler handler)
        {
            control.ResizeBegin += handler;
            return control;
        }

        public static ComponentEditorForm OnResizeEnd(this ComponentEditorForm control, EventHandler handler)
        {
            control.ResizeEnd += handler;
            return control;
        }

        public static ComponentEditorForm OnScroll(this ComponentEditorForm control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static ComponentEditorForm OnBackColorChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnBackgroundImageChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnBackgroundImageLayoutChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnBindingContextChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnCausesValidationChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnClientSizeChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnContextMenuStripChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnCursorChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnDockChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnEnabledChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnFontChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnForeColorChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnLocationChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnRegionChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnRightToLeftChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnSizeChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnTextChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnVisibleChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnClick(this ComponentEditorForm control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ComponentEditorForm OnControlAdded(this ComponentEditorForm control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ComponentEditorForm OnControlRemoved(this ComponentEditorForm control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ComponentEditorForm OnDataContextChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnDragDrop(this ComponentEditorForm control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ComponentEditorForm OnDragEnter(this ComponentEditorForm control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ComponentEditorForm OnDragOver(this ComponentEditorForm control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ComponentEditorForm OnDragLeave(this ComponentEditorForm control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ComponentEditorForm OnGiveFeedback(this ComponentEditorForm control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ComponentEditorForm OnHandleCreated(this ComponentEditorForm control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ComponentEditorForm OnHandleDestroyed(this ComponentEditorForm control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ComponentEditorForm OnHelpRequested(this ComponentEditorForm control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ComponentEditorForm OnInvalidated(this ComponentEditorForm control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ComponentEditorForm OnPaddingChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnPaint(this ComponentEditorForm control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ComponentEditorForm OnQueryContinueDrag(this ComponentEditorForm control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ComponentEditorForm OnQueryAccessibilityHelp(this ComponentEditorForm control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ComponentEditorForm OnDoubleClick(this ComponentEditorForm control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ComponentEditorForm OnEnter(this ComponentEditorForm control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ComponentEditorForm OnGotFocus(this ComponentEditorForm control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ComponentEditorForm OnKeyDown(this ComponentEditorForm control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ComponentEditorForm OnKeyPress(this ComponentEditorForm control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ComponentEditorForm OnKeyUp(this ComponentEditorForm control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ComponentEditorForm OnLayout(this ComponentEditorForm control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ComponentEditorForm OnLeave(this ComponentEditorForm control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ComponentEditorForm OnLostFocus(this ComponentEditorForm control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseClick(this ComponentEditorForm control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseDoubleClick(this ComponentEditorForm control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseCaptureChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseDown(this ComponentEditorForm control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseEnter(this ComponentEditorForm control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseLeave(this ComponentEditorForm control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ComponentEditorForm OnDpiChangedBeforeParent(this ComponentEditorForm control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ComponentEditorForm OnDpiChangedAfterParent(this ComponentEditorForm control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseHover(this ComponentEditorForm control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseMove(this ComponentEditorForm control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseUp(this ComponentEditorForm control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ComponentEditorForm OnMouseWheel(this ComponentEditorForm control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ComponentEditorForm OnMove(this ComponentEditorForm control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ComponentEditorForm OnPreviewKeyDown(this ComponentEditorForm control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ComponentEditorForm OnResize(this ComponentEditorForm control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ComponentEditorForm OnChangeUICues(this ComponentEditorForm control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ComponentEditorForm OnStyleChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnSystemColorsChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnValidating(this ComponentEditorForm control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ComponentEditorForm OnValidated(this ComponentEditorForm control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ComponentEditorForm OnParentChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnImeModeChanged(this ComponentEditorForm control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ComponentEditorForm OnDisposed(this ComponentEditorForm control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ComponentEditorForm AddTo(this ComponentEditorForm control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ComponentEditorForm AddControls(this ComponentEditorForm control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

        public static ComponentEditorForm Assign(this ComponentEditorForm control, out ComponentEditorForm variable)
        {
            variable = control;
            return control;
        }

    }
}

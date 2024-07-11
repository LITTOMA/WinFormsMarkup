using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class RichTextBoxExtensions
    {
        public static RichTextBox AllowDrop(this RichTextBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static RichTextBox AutoSize(this RichTextBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static RichTextBox AutoWordSelection(this RichTextBox control, Boolean value)
        {
            control.AutoWordSelection = value;
            return control;
        }

        public static RichTextBox BackgroundImage(this RichTextBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static RichTextBox BackgroundImageLayout(this RichTextBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static RichTextBox BulletIndent(this RichTextBox control, Int32 value)
        {
            control.BulletIndent = value;
            return control;
        }

        public static RichTextBox DetectUrls(this RichTextBox control, Boolean value)
        {
            control.DetectUrls = value;
            return control;
        }

        public static RichTextBox EnableAutoDragDrop(this RichTextBox control, Boolean value)
        {
            control.EnableAutoDragDrop = value;
            return control;
        }

        public static RichTextBox ForeColor(this RichTextBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static RichTextBox ForeColor(this RichTextBox control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static RichTextBox ForeColor(this RichTextBox control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static RichTextBox Font(this RichTextBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static RichTextBox Font(this RichTextBox control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static RichTextBox LanguageOption(this RichTextBox control, RichTextBoxLanguageOptions value)
        {
            control.LanguageOption = value;
            return control;
        }

        public static RichTextBox MaxLength(this RichTextBox control, Int32 value)
        {
            control.MaxLength = value;
            return control;
        }

        public static RichTextBox Multiline(this RichTextBox control, Boolean value)
        {
            control.Multiline = value;
            return control;
        }

        public static RichTextBox RichTextShortcutsEnabled(this RichTextBox control, Boolean value)
        {
            control.RichTextShortcutsEnabled = value;
            return control;
        }

        public static RichTextBox RightMargin(this RichTextBox control, Int32 value)
        {
            control.RightMargin = value;
            return control;
        }

        public static RichTextBox Rtf(this RichTextBox control, String value)
        {
            control.Rtf = value;
            return control;
        }

        public static RichTextBox ScrollBars(this RichTextBox control, RichTextBoxScrollBars value)
        {
            control.ScrollBars = value;
            return control;
        }

        public static RichTextBox SelectionAlignment(this RichTextBox control, HorizontalAlignment value)
        {
            control.SelectionAlignment = value;
            return control;
        }

        public static RichTextBox SelectionBullet(this RichTextBox control, Boolean value)
        {
            control.SelectionBullet = value;
            return control;
        }

        public static RichTextBox SelectionCharOffset(this RichTextBox control, Int32 value)
        {
            control.SelectionCharOffset = value;
            return control;
        }

        public static RichTextBox SelectionColor(this RichTextBox control, int red, int green, int blue)
        {
            control.SelectionColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static RichTextBox SelectionColor(this RichTextBox control, int red, int green, int blue, int alpha)
        {
            control.SelectionColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static RichTextBox SelectionColor(this RichTextBox control, Color color)
        {
            control.SelectionColor = color;
            return control;
        }

        public static RichTextBox SelectionBackColor(this RichTextBox control, int red, int green, int blue)
        {
            control.SelectionBackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static RichTextBox SelectionBackColor(this RichTextBox control, int red, int green, int blue, int alpha)
        {
            control.SelectionBackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static RichTextBox SelectionBackColor(this RichTextBox control, Color color)
        {
            control.SelectionBackColor = color;
            return control;
        }

        public static RichTextBox SelectionFont(this RichTextBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.SelectionFont = new Font(familyName, emSize, style);
            return control;
        }

        public static RichTextBox SelectionFont(this RichTextBox control, Font font)
        {
            control.SelectionFont = font;
            return control;
        }

        public static RichTextBox SelectionHangingIndent(this RichTextBox control, Int32 value)
        {
            control.SelectionHangingIndent = value;
            return control;
        }

        public static RichTextBox SelectionIndent(this RichTextBox control, Int32 value)
        {
            control.SelectionIndent = value;
            return control;
        }

        public static RichTextBox SelectionLength(this RichTextBox control, Int32 value)
        {
            control.SelectionLength = value;
            return control;
        }

        public static RichTextBox SelectionProtected(this RichTextBox control, Boolean value)
        {
            control.SelectionProtected = value;
            return control;
        }

        public static RichTextBox SelectedRtf(this RichTextBox control, String value)
        {
            control.SelectedRtf = value;
            return control;
        }

        public static RichTextBox SelectionRightIndent(this RichTextBox control, Int32 value)
        {
            control.SelectionRightIndent = value;
            return control;
        }

        public static RichTextBox SelectionTabs(this RichTextBox control, Int32[] value)
        {
            control.SelectionTabs = value;
            return control;
        }

        public static RichTextBox SelectedText(this RichTextBox control, String value)
        {
            control.SelectedText = value;
            return control;
        }

        public static RichTextBox ShowSelectionMargin(this RichTextBox control, Boolean value)
        {
            control.ShowSelectionMargin = value;
            return control;
        }

        public static RichTextBox Text(this RichTextBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static RichTextBox ZoomFactor(this RichTextBox control, Single value)
        {
            control.ZoomFactor = value;
            return control;
        }

        public static RichTextBox AcceptsTab(this RichTextBox control, Boolean value)
        {
            control.AcceptsTab = value;
            return control;
        }

        public static RichTextBox ShortcutsEnabled(this RichTextBox control, Boolean value)
        {
            control.ShortcutsEnabled = value;
            return control;
        }

        public static RichTextBox BackColor(this RichTextBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static RichTextBox BackColor(this RichTextBox control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static RichTextBox BackColor(this RichTextBox control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static RichTextBox BorderStyle(this RichTextBox control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static RichTextBox HideSelection(this RichTextBox control, Boolean value)
        {
            control.HideSelection = value;
            return control;
        }

        public static RichTextBox Lines(this RichTextBox control, String[] value)
        {
            control.Lines = value;
            return control;
        }

        public static RichTextBox Modified(this RichTextBox control, Boolean value)
        {
            control.Modified = value;
            return control;
        }

        public static RichTextBox Padding(this RichTextBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static RichTextBox ReadOnly(this RichTextBox control, Boolean value)
        {
            control.ReadOnly = value;
            return control;
        }

        public static RichTextBox SelectionStart(this RichTextBox control, Int32 value)
        {
            control.SelectionStart = value;
            return control;
        }

        public static RichTextBox WordWrap(this RichTextBox control, Boolean value)
        {
            control.WordWrap = value;
            return control;
        }

        public static RichTextBox AccessibleDefaultActionDescription(this RichTextBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static RichTextBox AccessibleDescription(this RichTextBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static RichTextBox AccessibleName(this RichTextBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static RichTextBox AccessibleRole(this RichTextBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static RichTextBox Anchor(this RichTextBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static RichTextBox AutoScrollOffset(this RichTextBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static RichTextBox AutoScrollOffset(this RichTextBox control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static RichTextBox DataContext(this RichTextBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static RichTextBox BindingContext(this RichTextBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static RichTextBox Bounds(this RichTextBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static RichTextBox Bounds(this RichTextBox control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static RichTextBox Bounds(this RichTextBox control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static RichTextBox Capture(this RichTextBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static RichTextBox CausesValidation(this RichTextBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static RichTextBox ClientSize(this RichTextBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static RichTextBox ClientSize(this RichTextBox control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static RichTextBox ContextMenuStrip(this RichTextBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static RichTextBox Cursor(this RichTextBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static RichTextBox Dock(this RichTextBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static RichTextBox Enabled(this RichTextBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static RichTextBox Height(this RichTextBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static RichTextBox IsAccessible(this RichTextBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static RichTextBox Left(this RichTextBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static RichTextBox Location(this RichTextBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static RichTextBox Location(this RichTextBox control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static RichTextBox Margin(this RichTextBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static RichTextBox MaximumSize(this RichTextBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static RichTextBox MaximumSize(this RichTextBox control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static RichTextBox MinimumSize(this RichTextBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static RichTextBox MinimumSize(this RichTextBox control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static RichTextBox Name(this RichTextBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static RichTextBox Parent(this RichTextBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static RichTextBox Region(this RichTextBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static RichTextBox RightToLeft(this RichTextBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static RichTextBox Size(this RichTextBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static RichTextBox Size(this RichTextBox control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static RichTextBox TabIndex(this RichTextBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static RichTextBox TabStop(this RichTextBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static RichTextBox Tag(this RichTextBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static RichTextBox Top(this RichTextBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static RichTextBox UseWaitCursor(this RichTextBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static RichTextBox Visible(this RichTextBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static RichTextBox Width(this RichTextBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static RichTextBox WindowTarget(this RichTextBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static RichTextBox ImeMode(this RichTextBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static RichTextBox OnBackgroundImageChanged(this RichTextBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static RichTextBox OnBackgroundImageLayoutChanged(this RichTextBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static RichTextBox OnContentsResized(this RichTextBox control, ContentsResizedEventHandler handler)
        {
            control.ContentsResized += handler;
            return control;
        }

        public static RichTextBox OnDragDrop(this RichTextBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static RichTextBox OnDragEnter(this RichTextBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static RichTextBox OnDragLeave(this RichTextBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static RichTextBox OnDragOver(this RichTextBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static RichTextBox OnGiveFeedback(this RichTextBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static RichTextBox OnQueryContinueDrag(this RichTextBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static RichTextBox OnHScroll(this RichTextBox control, EventHandler handler)
        {
            control.HScroll += handler;
            return control;
        }

        public static RichTextBox OnLinkClicked(this RichTextBox control, LinkClickedEventHandler handler)
        {
            control.LinkClicked += handler;
            return control;
        }

        public static RichTextBox OnImeChange(this RichTextBox control, EventHandler handler)
        {
            control.ImeChange += handler;
            return control;
        }

        public static RichTextBox OnProtected(this RichTextBox control, EventHandler handler)
        {
            control.Protected += handler;
            return control;
        }

        public static RichTextBox OnSelectionChanged(this RichTextBox control, EventHandler handler)
        {
            control.SelectionChanged += handler;
            return control;
        }

        public static RichTextBox OnVScroll(this RichTextBox control, EventHandler handler)
        {
            control.VScroll += handler;
            return control;
        }

        public static RichTextBox OnAcceptsTabChanged(this RichTextBox control, EventHandler handler)
        {
            control.AcceptsTabChanged += handler;
            return control;
        }

        public static RichTextBox OnAutoSizeChanged(this RichTextBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static RichTextBox OnBorderStyleChanged(this RichTextBox control, EventHandler handler)
        {
            control.BorderStyleChanged += handler;
            return control;
        }

        public static RichTextBox OnClick(this RichTextBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static RichTextBox OnMouseClick(this RichTextBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static RichTextBox OnHideSelectionChanged(this RichTextBox control, EventHandler handler)
        {
            control.HideSelectionChanged += handler;
            return control;
        }

        public static RichTextBox OnModifiedChanged(this RichTextBox control, EventHandler handler)
        {
            control.ModifiedChanged += handler;
            return control;
        }

        public static RichTextBox OnMultilineChanged(this RichTextBox control, EventHandler handler)
        {
            control.MultilineChanged += handler;
            return control;
        }

        public static RichTextBox OnPaddingChanged(this RichTextBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static RichTextBox OnReadOnlyChanged(this RichTextBox control, EventHandler handler)
        {
            control.ReadOnlyChanged += handler;
            return control;
        }

        public static RichTextBox OnPaint(this RichTextBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static RichTextBox OnBackColorChanged(this RichTextBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static RichTextBox OnBindingContextChanged(this RichTextBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static RichTextBox OnCausesValidationChanged(this RichTextBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static RichTextBox OnClientSizeChanged(this RichTextBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static RichTextBox OnContextMenuStripChanged(this RichTextBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static RichTextBox OnCursorChanged(this RichTextBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static RichTextBox OnDockChanged(this RichTextBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static RichTextBox OnEnabledChanged(this RichTextBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static RichTextBox OnFontChanged(this RichTextBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static RichTextBox OnForeColorChanged(this RichTextBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static RichTextBox OnLocationChanged(this RichTextBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static RichTextBox OnMarginChanged(this RichTextBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static RichTextBox OnRegionChanged(this RichTextBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static RichTextBox OnRightToLeftChanged(this RichTextBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static RichTextBox OnSizeChanged(this RichTextBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static RichTextBox OnTabIndexChanged(this RichTextBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static RichTextBox OnTabStopChanged(this RichTextBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static RichTextBox OnTextChanged(this RichTextBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static RichTextBox OnVisibleChanged(this RichTextBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static RichTextBox OnControlAdded(this RichTextBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static RichTextBox OnControlRemoved(this RichTextBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static RichTextBox OnDataContextChanged(this RichTextBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static RichTextBox OnHandleCreated(this RichTextBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static RichTextBox OnHandleDestroyed(this RichTextBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static RichTextBox OnHelpRequested(this RichTextBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static RichTextBox OnInvalidated(this RichTextBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static RichTextBox OnQueryAccessibilityHelp(this RichTextBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static RichTextBox OnDoubleClick(this RichTextBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static RichTextBox OnEnter(this RichTextBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static RichTextBox OnGotFocus(this RichTextBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static RichTextBox OnKeyDown(this RichTextBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static RichTextBox OnKeyPress(this RichTextBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static RichTextBox OnKeyUp(this RichTextBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static RichTextBox OnLayout(this RichTextBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static RichTextBox OnLeave(this RichTextBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static RichTextBox OnLostFocus(this RichTextBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static RichTextBox OnMouseDoubleClick(this RichTextBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static RichTextBox OnMouseCaptureChanged(this RichTextBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static RichTextBox OnMouseDown(this RichTextBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static RichTextBox OnMouseEnter(this RichTextBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static RichTextBox OnMouseLeave(this RichTextBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static RichTextBox OnDpiChangedBeforeParent(this RichTextBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static RichTextBox OnDpiChangedAfterParent(this RichTextBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static RichTextBox OnMouseHover(this RichTextBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static RichTextBox OnMouseMove(this RichTextBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static RichTextBox OnMouseUp(this RichTextBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static RichTextBox OnMouseWheel(this RichTextBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static RichTextBox OnMove(this RichTextBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static RichTextBox OnPreviewKeyDown(this RichTextBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static RichTextBox OnResize(this RichTextBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static RichTextBox OnChangeUICues(this RichTextBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static RichTextBox OnStyleChanged(this RichTextBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static RichTextBox OnSystemColorsChanged(this RichTextBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static RichTextBox OnValidating(this RichTextBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static RichTextBox OnValidated(this RichTextBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static RichTextBox OnParentChanged(this RichTextBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static RichTextBox OnImeModeChanged(this RichTextBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static RichTextBox OnDisposed(this RichTextBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static RichTextBox AddTo(this RichTextBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static RichTextBox Assign(this RichTextBox control, out RichTextBox variable)
        {
            variable = control;
            return control;
        }

    }
}

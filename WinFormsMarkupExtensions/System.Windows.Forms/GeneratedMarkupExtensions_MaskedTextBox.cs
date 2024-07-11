using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Globalization;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class MaskedTextBoxExtensions
    {
        public static MaskedTextBox AcceptsTab(this MaskedTextBox control, Boolean value)
        {
            control.AcceptsTab = value;
            return control;
        }

        public static MaskedTextBox AllowPromptAsInput(this MaskedTextBox control, Boolean value)
        {
            control.AllowPromptAsInput = value;
            return control;
        }

        public static MaskedTextBox AsciiOnly(this MaskedTextBox control, Boolean value)
        {
            control.AsciiOnly = value;
            return control;
        }

        public static MaskedTextBox BeepOnError(this MaskedTextBox control, Boolean value)
        {
            control.BeepOnError = value;
            return control;
        }

        public static MaskedTextBox Culture(this MaskedTextBox control, CultureInfo value)
        {
            control.Culture = value;
            return control;
        }

        public static MaskedTextBox CutCopyMaskFormat(this MaskedTextBox control, MaskFormat value)
        {
            control.CutCopyMaskFormat = value;
            return control;
        }

        public static MaskedTextBox FormatProvider(this MaskedTextBox control, IFormatProvider value)
        {
            control.FormatProvider = value;
            return control;
        }

        public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, Boolean value)
        {
            control.HidePromptOnLeave = value;
            return control;
        }

        public static MaskedTextBox InsertKeyMode(this MaskedTextBox control, InsertKeyMode value)
        {
            control.InsertKeyMode = value;
            return control;
        }

        public static MaskedTextBox Lines(this MaskedTextBox control, String[] value)
        {
            control.Lines = value;
            return control;
        }

        public static MaskedTextBox Mask(this MaskedTextBox control, String value)
        {
            control.Mask = value;
            return control;
        }

        public static MaskedTextBox MaxLength(this MaskedTextBox control, Int32 value)
        {
            control.MaxLength = value;
            return control;
        }

        public static MaskedTextBox Multiline(this MaskedTextBox control, Boolean value)
        {
            control.Multiline = value;
            return control;
        }

        public static MaskedTextBox PasswordChar(this MaskedTextBox control, Char value)
        {
            control.PasswordChar = value;
            return control;
        }

        public static MaskedTextBox PromptChar(this MaskedTextBox control, Char value)
        {
            control.PromptChar = value;
            return control;
        }

        public static MaskedTextBox ReadOnly(this MaskedTextBox control, Boolean value)
        {
            control.ReadOnly = value;
            return control;
        }

        public static MaskedTextBox RejectInputOnFirstFailure(this MaskedTextBox control, Boolean value)
        {
            control.RejectInputOnFirstFailure = value;
            return control;
        }

        public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, Boolean value)
        {
            control.ResetOnPrompt = value;
            return control;
        }

        public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, Boolean value)
        {
            control.ResetOnSpace = value;
            return control;
        }

        public static MaskedTextBox SkipLiterals(this MaskedTextBox control, Boolean value)
        {
            control.SkipLiterals = value;
            return control;
        }

        public static MaskedTextBox SelectedText(this MaskedTextBox control, String value)
        {
            control.SelectedText = value;
            return control;
        }

        public static MaskedTextBox Text(this MaskedTextBox control, String value)
        {
            control.Text = value;
            return control;
        }

        public static MaskedTextBox TextAlign(this MaskedTextBox control, HorizontalAlignment value)
        {
            control.TextAlign = value;
            return control;
        }

        public static MaskedTextBox TextMaskFormat(this MaskedTextBox control, MaskFormat value)
        {
            control.TextMaskFormat = value;
            return control;
        }

        public static MaskedTextBox UseSystemPasswordChar(this MaskedTextBox control, Boolean value)
        {
            control.UseSystemPasswordChar = value;
            return control;
        }

        public static MaskedTextBox ValidatingType(this MaskedTextBox control, Type value)
        {
            control.ValidatingType = value;
            return control;
        }

        public static MaskedTextBox WordWrap(this MaskedTextBox control, Boolean value)
        {
            control.WordWrap = value;
            return control;
        }

        public static MaskedTextBox ShortcutsEnabled(this MaskedTextBox control, Boolean value)
        {
            control.ShortcutsEnabled = value;
            return control;
        }

        public static MaskedTextBox AutoSize(this MaskedTextBox control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static MaskedTextBox BackColor(this MaskedTextBox control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MaskedTextBox BackgroundImage(this MaskedTextBox control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static MaskedTextBox BackgroundImageLayout(this MaskedTextBox control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static MaskedTextBox BorderStyle(this MaskedTextBox control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static MaskedTextBox ForeColor(this MaskedTextBox control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static MaskedTextBox HideSelection(this MaskedTextBox control, Boolean value)
        {
            control.HideSelection = value;
            return control;
        }

        public static MaskedTextBox Modified(this MaskedTextBox control, Boolean value)
        {
            control.Modified = value;
            return control;
        }

        public static MaskedTextBox Padding(this MaskedTextBox control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static MaskedTextBox SelectionLength(this MaskedTextBox control, Int32 value)
        {
            control.SelectionLength = value;
            return control;
        }

        public static MaskedTextBox SelectionStart(this MaskedTextBox control, Int32 value)
        {
            control.SelectionStart = value;
            return control;
        }

        public static MaskedTextBox AccessibleDefaultActionDescription(this MaskedTextBox control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static MaskedTextBox AccessibleDescription(this MaskedTextBox control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static MaskedTextBox AccessibleName(this MaskedTextBox control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static MaskedTextBox AccessibleRole(this MaskedTextBox control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static MaskedTextBox AllowDrop(this MaskedTextBox control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static MaskedTextBox Anchor(this MaskedTextBox control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static MaskedTextBox AutoScrollOffset(this MaskedTextBox control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static MaskedTextBox DataContext(this MaskedTextBox control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static MaskedTextBox BindingContext(this MaskedTextBox control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static MaskedTextBox Bounds(this MaskedTextBox control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static MaskedTextBox Capture(this MaskedTextBox control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static MaskedTextBox CausesValidation(this MaskedTextBox control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static MaskedTextBox ClientSize(this MaskedTextBox control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static MaskedTextBox ContextMenuStrip(this MaskedTextBox control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static MaskedTextBox Cursor(this MaskedTextBox control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static MaskedTextBox Dock(this MaskedTextBox control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static MaskedTextBox Enabled(this MaskedTextBox control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static MaskedTextBox Font(this MaskedTextBox control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static MaskedTextBox Height(this MaskedTextBox control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static MaskedTextBox IsAccessible(this MaskedTextBox control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static MaskedTextBox Left(this MaskedTextBox control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static MaskedTextBox Location(this MaskedTextBox control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static MaskedTextBox Margin(this MaskedTextBox control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static MaskedTextBox MaximumSize(this MaskedTextBox control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static MaskedTextBox MinimumSize(this MaskedTextBox control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static MaskedTextBox Name(this MaskedTextBox control, String value)
        {
            control.Name = value;
            return control;
        }

        public static MaskedTextBox Parent(this MaskedTextBox control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static MaskedTextBox Region(this MaskedTextBox control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static MaskedTextBox RightToLeft(this MaskedTextBox control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static MaskedTextBox Size(this MaskedTextBox control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static MaskedTextBox TabIndex(this MaskedTextBox control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static MaskedTextBox TabStop(this MaskedTextBox control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static MaskedTextBox Tag(this MaskedTextBox control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static MaskedTextBox Top(this MaskedTextBox control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static MaskedTextBox UseWaitCursor(this MaskedTextBox control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static MaskedTextBox Visible(this MaskedTextBox control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static MaskedTextBox Width(this MaskedTextBox control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static MaskedTextBox WindowTarget(this MaskedTextBox control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static MaskedTextBox ImeMode(this MaskedTextBox control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static MaskedTextBox OnAcceptsTabChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.AcceptsTabChanged += handler;
            return control;
        }

        public static MaskedTextBox OnIsOverwriteModeChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.IsOverwriteModeChanged += handler;
            return control;
        }

        public static MaskedTextBox OnMaskChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.MaskChanged += handler;
            return control;
        }

        public static MaskedTextBox OnMaskInputRejected(this MaskedTextBox control, MaskInputRejectedEventHandler handler)
        {
            control.MaskInputRejected += handler;
            return control;
        }

        public static MaskedTextBox OnMultilineChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.MultilineChanged += handler;
            return control;
        }

        public static MaskedTextBox OnTextAlignChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.TextAlignChanged += handler;
            return control;
        }

        public static MaskedTextBox OnTypeValidationCompleted(this MaskedTextBox control, TypeValidationEventHandler handler)
        {
            control.TypeValidationCompleted += handler;
            return control;
        }

        public static MaskedTextBox OnAutoSizeChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static MaskedTextBox OnBackgroundImageChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static MaskedTextBox OnBackgroundImageLayoutChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static MaskedTextBox OnBorderStyleChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.BorderStyleChanged += handler;
            return control;
        }

        public static MaskedTextBox OnClick(this MaskedTextBox control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static MaskedTextBox OnMouseClick(this MaskedTextBox control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static MaskedTextBox OnHideSelectionChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.HideSelectionChanged += handler;
            return control;
        }

        public static MaskedTextBox OnModifiedChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.ModifiedChanged += handler;
            return control;
        }

        public static MaskedTextBox OnPaddingChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static MaskedTextBox OnReadOnlyChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.ReadOnlyChanged += handler;
            return control;
        }

        public static MaskedTextBox OnPaint(this MaskedTextBox control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static MaskedTextBox OnBackColorChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static MaskedTextBox OnBindingContextChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static MaskedTextBox OnCausesValidationChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static MaskedTextBox OnClientSizeChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static MaskedTextBox OnContextMenuStripChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static MaskedTextBox OnCursorChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static MaskedTextBox OnDockChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static MaskedTextBox OnEnabledChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static MaskedTextBox OnFontChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static MaskedTextBox OnForeColorChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static MaskedTextBox OnLocationChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static MaskedTextBox OnMarginChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static MaskedTextBox OnRegionChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static MaskedTextBox OnRightToLeftChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static MaskedTextBox OnSizeChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static MaskedTextBox OnTabIndexChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static MaskedTextBox OnTabStopChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static MaskedTextBox OnTextChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static MaskedTextBox OnVisibleChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static MaskedTextBox OnControlAdded(this MaskedTextBox control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static MaskedTextBox OnControlRemoved(this MaskedTextBox control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static MaskedTextBox OnDataContextChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static MaskedTextBox OnDragDrop(this MaskedTextBox control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static MaskedTextBox OnDragEnter(this MaskedTextBox control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static MaskedTextBox OnDragOver(this MaskedTextBox control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static MaskedTextBox OnDragLeave(this MaskedTextBox control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static MaskedTextBox OnGiveFeedback(this MaskedTextBox control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static MaskedTextBox OnHandleCreated(this MaskedTextBox control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static MaskedTextBox OnHandleDestroyed(this MaskedTextBox control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static MaskedTextBox OnHelpRequested(this MaskedTextBox control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static MaskedTextBox OnInvalidated(this MaskedTextBox control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static MaskedTextBox OnQueryContinueDrag(this MaskedTextBox control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static MaskedTextBox OnQueryAccessibilityHelp(this MaskedTextBox control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static MaskedTextBox OnDoubleClick(this MaskedTextBox control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static MaskedTextBox OnEnter(this MaskedTextBox control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static MaskedTextBox OnGotFocus(this MaskedTextBox control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static MaskedTextBox OnKeyDown(this MaskedTextBox control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static MaskedTextBox OnKeyPress(this MaskedTextBox control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static MaskedTextBox OnKeyUp(this MaskedTextBox control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static MaskedTextBox OnLayout(this MaskedTextBox control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static MaskedTextBox OnLeave(this MaskedTextBox control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static MaskedTextBox OnLostFocus(this MaskedTextBox control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static MaskedTextBox OnMouseDoubleClick(this MaskedTextBox control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static MaskedTextBox OnMouseCaptureChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static MaskedTextBox OnMouseDown(this MaskedTextBox control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static MaskedTextBox OnMouseEnter(this MaskedTextBox control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static MaskedTextBox OnMouseLeave(this MaskedTextBox control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static MaskedTextBox OnDpiChangedBeforeParent(this MaskedTextBox control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static MaskedTextBox OnDpiChangedAfterParent(this MaskedTextBox control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static MaskedTextBox OnMouseHover(this MaskedTextBox control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static MaskedTextBox OnMouseMove(this MaskedTextBox control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static MaskedTextBox OnMouseUp(this MaskedTextBox control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static MaskedTextBox OnMouseWheel(this MaskedTextBox control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static MaskedTextBox OnMove(this MaskedTextBox control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static MaskedTextBox OnPreviewKeyDown(this MaskedTextBox control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static MaskedTextBox OnResize(this MaskedTextBox control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static MaskedTextBox OnChangeUICues(this MaskedTextBox control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static MaskedTextBox OnStyleChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static MaskedTextBox OnSystemColorsChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static MaskedTextBox OnValidating(this MaskedTextBox control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static MaskedTextBox OnValidated(this MaskedTextBox control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static MaskedTextBox OnParentChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static MaskedTextBox OnImeModeChanged(this MaskedTextBox control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static MaskedTextBox OnDisposed(this MaskedTextBox control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static MaskedTextBox AddTo(this MaskedTextBox control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class PropertyGridExtensions
    {
        public static PropertyGrid AutoScroll(this PropertyGrid control, Boolean value)
        {
            control.AutoScroll = value;
            return control;
        }

        public static PropertyGrid BackColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid BackgroundImage(this PropertyGrid control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static PropertyGrid BackgroundImageLayout(this PropertyGrid control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static PropertyGrid BrowsableAttributes(this PropertyGrid control, AttributeCollection value)
        {
            control.BrowsableAttributes = value;
            return control;
        }

        public static PropertyGrid CategoryForeColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CategoryForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CommandsBackColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CommandsBackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CommandsForeColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CommandsForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CommandsLinkColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CommandsLinkColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CommandsActiveLinkColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CommandsActiveLinkColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CommandsDisabledLinkColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CommandsDisabledLinkColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CommandsBorderColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CommandsBorderColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CommandsVisibleIfAvailable(this PropertyGrid control, Boolean value)
        {
            control.CommandsVisibleIfAvailable = value;
            return control;
        }

        public static PropertyGrid ForeColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid HelpBackColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.HelpBackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid HelpForeColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.HelpForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid HelpBorderColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.HelpBorderColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid HelpVisible(this PropertyGrid control, Boolean value)
        {
            control.HelpVisible = value;
            return control;
        }

        public static PropertyGrid SelectedItemWithFocusBackColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.SelectedItemWithFocusBackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid SelectedItemWithFocusForeColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.SelectedItemWithFocusForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid DisabledItemForeColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.DisabledItemForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CategorySplitterColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.CategorySplitterColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid CanShowVisualStyleGlyphs(this PropertyGrid control, Boolean value)
        {
            control.CanShowVisualStyleGlyphs = value;
            return control;
        }

        public static PropertyGrid LineColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.LineColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid Padding(this PropertyGrid control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static PropertyGrid PropertySort(this PropertyGrid control, PropertySort value)
        {
            control.PropertySort = value;
            return control;
        }

        public static PropertyGrid SelectedObject(this PropertyGrid control, Object value)
        {
            control.SelectedObject = value;
            return control;
        }

        public static PropertyGrid SelectedObjects(this PropertyGrid control, Object[] value)
        {
            control.SelectedObjects = value;
            return control;
        }

        public static PropertyGrid SelectedGridItem(this PropertyGrid control, GridItem value)
        {
            control.SelectedGridItem = value;
            return control;
        }

        public static PropertyGrid Text(this PropertyGrid control, String value)
        {
            control.Text = value;
            return control;
        }

        public static PropertyGrid LargeButtons(this PropertyGrid control, Boolean value)
        {
            control.LargeButtons = value;
            return control;
        }

        public static PropertyGrid ToolbarVisible(this PropertyGrid control, Boolean value)
        {
            control.ToolbarVisible = value;
            return control;
        }

        public static PropertyGrid ViewBackColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.ViewBackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid ViewForeColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.ViewForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid ViewBorderColor(this PropertyGrid control, int red, int green, int blue)
        {
            control.ViewBorderColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static PropertyGrid UseCompatibleTextRendering(this PropertyGrid control, Boolean value)
        {
            control.UseCompatibleTextRendering = value;
            return control;
        }

        public static PropertyGrid AutoScaleDimensions(this PropertyGrid control, SizeF value)
        {
            control.AutoScaleDimensions = value;
            return control;
        }

        public static PropertyGrid AutoScaleMode(this PropertyGrid control, AutoScaleMode value)
        {
            control.AutoScaleMode = value;
            return control;
        }

        public static PropertyGrid AutoValidate(this PropertyGrid control, AutoValidate value)
        {
            control.AutoValidate = value;
            return control;
        }

        public static PropertyGrid BindingContext(this PropertyGrid control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static PropertyGrid ActiveControl(this PropertyGrid control, Control value)
        {
            control.ActiveControl = value;
            return control;
        }

        public static PropertyGrid AutoScrollMargin(this PropertyGrid control, int width, int height)
        {
            control.AutoScrollMargin = new Size(width, height);
            return control;
        }

        public static PropertyGrid AutoScrollPosition(this PropertyGrid control, int x, int y)
        {
            control.AutoScrollPosition = new Point(x, y);
            return control;
        }

        public static PropertyGrid AutoScrollMinSize(this PropertyGrid control, int width, int height)
        {
            control.AutoScrollMinSize = new Size(width, height);
            return control;
        }

        public static PropertyGrid AccessibleDefaultActionDescription(this PropertyGrid control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static PropertyGrid AccessibleDescription(this PropertyGrid control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static PropertyGrid AccessibleName(this PropertyGrid control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static PropertyGrid AccessibleRole(this PropertyGrid control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static PropertyGrid AllowDrop(this PropertyGrid control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static PropertyGrid Anchor(this PropertyGrid control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static PropertyGrid AutoSize(this PropertyGrid control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static PropertyGrid AutoScrollOffset(this PropertyGrid control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static PropertyGrid DataContext(this PropertyGrid control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static PropertyGrid Bounds(this PropertyGrid control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static PropertyGrid Capture(this PropertyGrid control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static PropertyGrid CausesValidation(this PropertyGrid control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static PropertyGrid ClientSize(this PropertyGrid control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static PropertyGrid ContextMenuStrip(this PropertyGrid control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static PropertyGrid Cursor(this PropertyGrid control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static PropertyGrid Dock(this PropertyGrid control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static PropertyGrid Enabled(this PropertyGrid control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static PropertyGrid Font(this PropertyGrid control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static PropertyGrid Height(this PropertyGrid control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static PropertyGrid IsAccessible(this PropertyGrid control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static PropertyGrid Left(this PropertyGrid control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static PropertyGrid Location(this PropertyGrid control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static PropertyGrid Margin(this PropertyGrid control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static PropertyGrid MaximumSize(this PropertyGrid control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static PropertyGrid MinimumSize(this PropertyGrid control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static PropertyGrid Name(this PropertyGrid control, String value)
        {
            control.Name = value;
            return control;
        }

        public static PropertyGrid Parent(this PropertyGrid control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static PropertyGrid Region(this PropertyGrid control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static PropertyGrid RightToLeft(this PropertyGrid control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static PropertyGrid Size(this PropertyGrid control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static PropertyGrid TabIndex(this PropertyGrid control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static PropertyGrid TabStop(this PropertyGrid control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static PropertyGrid Tag(this PropertyGrid control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static PropertyGrid Top(this PropertyGrid control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static PropertyGrid UseWaitCursor(this PropertyGrid control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static PropertyGrid Visible(this PropertyGrid control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static PropertyGrid Width(this PropertyGrid control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static PropertyGrid WindowTarget(this PropertyGrid control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static PropertyGrid ImeMode(this PropertyGrid control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static PropertyGrid OnBackgroundImageChanged(this PropertyGrid control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static PropertyGrid OnBackgroundImageLayoutChanged(this PropertyGrid control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static PropertyGrid OnForeColorChanged(this PropertyGrid control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static PropertyGrid OnPaddingChanged(this PropertyGrid control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static PropertyGrid OnTextChanged(this PropertyGrid control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static PropertyGrid OnKeyDown(this PropertyGrid control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static PropertyGrid OnKeyPress(this PropertyGrid control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static PropertyGrid OnKeyUp(this PropertyGrid control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static PropertyGrid OnMouseDown(this PropertyGrid control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static PropertyGrid OnMouseUp(this PropertyGrid control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static PropertyGrid OnMouseMove(this PropertyGrid control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static PropertyGrid OnMouseEnter(this PropertyGrid control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static PropertyGrid OnMouseLeave(this PropertyGrid control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static PropertyGrid OnPropertyValueChanged(this PropertyGrid control, PropertyValueChangedEventHandler handler)
        {
            control.PropertyValueChanged += handler;
            return control;
        }

        public static PropertyGrid OnPropertyTabChanged(this PropertyGrid control, PropertyTabChangedEventHandler handler)
        {
            control.PropertyTabChanged += handler;
            return control;
        }

        public static PropertyGrid OnPropertySortChanged(this PropertyGrid control, EventHandler handler)
        {
            control.PropertySortChanged += handler;
            return control;
        }

        public static PropertyGrid OnSelectedGridItemChanged(this PropertyGrid control, SelectedGridItemChangedEventHandler handler)
        {
            control.SelectedGridItemChanged += handler;
            return control;
        }

        public static PropertyGrid OnSelectedObjectsChanged(this PropertyGrid control, EventHandler handler)
        {
            control.SelectedObjectsChanged += handler;
            return control;
        }

        public static PropertyGrid OnAutoValidateChanged(this PropertyGrid control, EventHandler handler)
        {
            control.AutoValidateChanged += handler;
            return control;
        }

        public static PropertyGrid OnScroll(this PropertyGrid control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static PropertyGrid OnAutoSizeChanged(this PropertyGrid control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static PropertyGrid OnBackColorChanged(this PropertyGrid control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static PropertyGrid OnBindingContextChanged(this PropertyGrid control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static PropertyGrid OnCausesValidationChanged(this PropertyGrid control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static PropertyGrid OnClientSizeChanged(this PropertyGrid control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static PropertyGrid OnContextMenuStripChanged(this PropertyGrid control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static PropertyGrid OnCursorChanged(this PropertyGrid control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static PropertyGrid OnDockChanged(this PropertyGrid control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static PropertyGrid OnEnabledChanged(this PropertyGrid control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static PropertyGrid OnFontChanged(this PropertyGrid control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static PropertyGrid OnLocationChanged(this PropertyGrid control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static PropertyGrid OnMarginChanged(this PropertyGrid control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static PropertyGrid OnRegionChanged(this PropertyGrid control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static PropertyGrid OnRightToLeftChanged(this PropertyGrid control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static PropertyGrid OnSizeChanged(this PropertyGrid control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static PropertyGrid OnTabIndexChanged(this PropertyGrid control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static PropertyGrid OnTabStopChanged(this PropertyGrid control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static PropertyGrid OnVisibleChanged(this PropertyGrid control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static PropertyGrid OnClick(this PropertyGrid control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static PropertyGrid OnControlAdded(this PropertyGrid control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static PropertyGrid OnControlRemoved(this PropertyGrid control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static PropertyGrid OnDataContextChanged(this PropertyGrid control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static PropertyGrid OnDragDrop(this PropertyGrid control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static PropertyGrid OnDragEnter(this PropertyGrid control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static PropertyGrid OnDragOver(this PropertyGrid control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static PropertyGrid OnDragLeave(this PropertyGrid control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static PropertyGrid OnGiveFeedback(this PropertyGrid control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static PropertyGrid OnHandleCreated(this PropertyGrid control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static PropertyGrid OnHandleDestroyed(this PropertyGrid control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static PropertyGrid OnHelpRequested(this PropertyGrid control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static PropertyGrid OnInvalidated(this PropertyGrid control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static PropertyGrid OnPaint(this PropertyGrid control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static PropertyGrid OnQueryContinueDrag(this PropertyGrid control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static PropertyGrid OnQueryAccessibilityHelp(this PropertyGrid control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static PropertyGrid OnDoubleClick(this PropertyGrid control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static PropertyGrid OnEnter(this PropertyGrid control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static PropertyGrid OnGotFocus(this PropertyGrid control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static PropertyGrid OnLayout(this PropertyGrid control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static PropertyGrid OnLeave(this PropertyGrid control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static PropertyGrid OnLostFocus(this PropertyGrid control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static PropertyGrid OnMouseClick(this PropertyGrid control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static PropertyGrid OnMouseDoubleClick(this PropertyGrid control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static PropertyGrid OnMouseCaptureChanged(this PropertyGrid control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static PropertyGrid OnDpiChangedBeforeParent(this PropertyGrid control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static PropertyGrid OnDpiChangedAfterParent(this PropertyGrid control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static PropertyGrid OnMouseHover(this PropertyGrid control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static PropertyGrid OnMouseWheel(this PropertyGrid control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static PropertyGrid OnMove(this PropertyGrid control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static PropertyGrid OnPreviewKeyDown(this PropertyGrid control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static PropertyGrid OnResize(this PropertyGrid control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static PropertyGrid OnChangeUICues(this PropertyGrid control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static PropertyGrid OnStyleChanged(this PropertyGrid control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static PropertyGrid OnSystemColorsChanged(this PropertyGrid control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static PropertyGrid OnValidating(this PropertyGrid control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static PropertyGrid OnValidated(this PropertyGrid control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static PropertyGrid OnParentChanged(this PropertyGrid control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static PropertyGrid OnImeModeChanged(this PropertyGrid control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static PropertyGrid OnDisposed(this PropertyGrid control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static PropertyGrid AddTo(this PropertyGrid control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static PropertyGrid AddControls(this PropertyGrid control, params Control[] controls)
        {
            control.Controls.AddRange(controls);
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Collections;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class ListViewExtensions
    {
        public static ListView Activation(this ListView control, ItemActivation value)
        {
            control.Activation = value;
            return control;
        }

        public static ListView Alignment(this ListView control, ListViewAlignment value)
        {
            control.Alignment = value;
            return control;
        }

        public static ListView AllowColumnReorder(this ListView control, Boolean value)
        {
            control.AllowColumnReorder = value;
            return control;
        }

        public static ListView AutoArrange(this ListView control, Boolean value)
        {
            control.AutoArrange = value;
            return control;
        }

        public static ListView BackColor(this ListView control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ListView BackColor(this ListView control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ListView BackColor(this ListView control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static ListView BackgroundImageLayout(this ListView control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static ListView BackgroundImageTiled(this ListView control, Boolean value)
        {
            control.BackgroundImageTiled = value;
            return control;
        }

        public static ListView BorderStyle(this ListView control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static ListView CheckBoxes(this ListView control, Boolean value)
        {
            control.CheckBoxes = value;
            return control;
        }

        public static ListView FocusedItem(this ListView control, ListViewItem value)
        {
            control.FocusedItem = value;
            return control;
        }

        public static ListView ForeColor(this ListView control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static ListView ForeColor(this ListView control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static ListView ForeColor(this ListView control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static ListView FullRowSelect(this ListView control, Boolean value)
        {
            control.FullRowSelect = value;
            return control;
        }

        public static ListView GridLines(this ListView control, Boolean value)
        {
            control.GridLines = value;
            return control;
        }

        public static ListView GroupImageList(this ListView control, ImageList value)
        {
            control.GroupImageList = value;
            return control;
        }

        public static ListView HeaderStyle(this ListView control, ColumnHeaderStyle value)
        {
            control.HeaderStyle = value;
            return control;
        }

        public static ListView HideSelection(this ListView control, Boolean value)
        {
            control.HideSelection = value;
            return control;
        }

        public static ListView HotTracking(this ListView control, Boolean value)
        {
            control.HotTracking = value;
            return control;
        }

        public static ListView HoverSelection(this ListView control, Boolean value)
        {
            control.HoverSelection = value;
            return control;
        }

        public static ListView LabelEdit(this ListView control, Boolean value)
        {
            control.LabelEdit = value;
            return control;
        }

        public static ListView LabelWrap(this ListView control, Boolean value)
        {
            control.LabelWrap = value;
            return control;
        }

        public static ListView LargeImageList(this ListView control, ImageList value)
        {
            control.LargeImageList = value;
            return control;
        }

        public static ListView ListViewItemSorter(this ListView control, IComparer value)
        {
            control.ListViewItemSorter = value;
            return control;
        }

        public static ListView MultiSelect(this ListView control, Boolean value)
        {
            control.MultiSelect = value;
            return control;
        }

        public static ListView OwnerDraw(this ListView control, Boolean value)
        {
            control.OwnerDraw = value;
            return control;
        }

        public static ListView RightToLeftLayout(this ListView control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static ListView Scrollable(this ListView control, Boolean value)
        {
            control.Scrollable = value;
            return control;
        }

        public static ListView ShowGroups(this ListView control, Boolean value)
        {
            control.ShowGroups = value;
            return control;
        }

        public static ListView SmallImageList(this ListView control, ImageList value)
        {
            control.SmallImageList = value;
            return control;
        }

        public static ListView ShowItemToolTips(this ListView control, Boolean value)
        {
            control.ShowItemToolTips = value;
            return control;
        }

        public static ListView Sorting(this ListView control, SortOrder value)
        {
            control.Sorting = value;
            return control;
        }

        public static ListView StateImageList(this ListView control, ImageList value)
        {
            control.StateImageList = value;
            return control;
        }

        public static ListView Text(this ListView control, String value)
        {
            control.Text = value;
            return control;
        }

        public static ListView TileSize(this ListView control, int width, int height)
        {
            control.TileSize = new Size(width, height);
            return control;
        }

        public static ListView TileSize(this ListView control, Size size)
        {
            control.TileSize = size;
            return control;
        }

        public static ListView TopItem(this ListView control, ListViewItem value)
        {
            control.TopItem = value;
            return control;
        }

        public static ListView UseCompatibleStateImageBehavior(this ListView control, Boolean value)
        {
            control.UseCompatibleStateImageBehavior = value;
            return control;
        }

        public static ListView View(this ListView control, View value)
        {
            control.View = value;
            return control;
        }

        public static ListView VirtualListSize(this ListView control, Int32 value)
        {
            control.VirtualListSize = value;
            return control;
        }

        public static ListView VirtualMode(this ListView control, Boolean value)
        {
            control.VirtualMode = value;
            return control;
        }

        public static ListView Padding(this ListView control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static ListView AccessibleDefaultActionDescription(this ListView control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static ListView AccessibleDescription(this ListView control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static ListView AccessibleName(this ListView control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static ListView AccessibleRole(this ListView control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static ListView AllowDrop(this ListView control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static ListView Anchor(this ListView control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static ListView AutoSize(this ListView control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static ListView AutoScrollOffset(this ListView control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static ListView AutoScrollOffset(this ListView control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static ListView DataContext(this ListView control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static ListView BackgroundImage(this ListView control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static ListView BindingContext(this ListView control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static ListView Bounds(this ListView control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static ListView Bounds(this ListView control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static ListView Bounds(this ListView control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static ListView Capture(this ListView control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static ListView CausesValidation(this ListView control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static ListView ClientSize(this ListView control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static ListView ClientSize(this ListView control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static ListView ContextMenuStrip(this ListView control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static ListView Cursor(this ListView control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static ListView Dock(this ListView control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static ListView Enabled(this ListView control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static ListView Font(this ListView control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static ListView Font(this ListView control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static ListView Height(this ListView control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static ListView IsAccessible(this ListView control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static ListView Left(this ListView control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static ListView Location(this ListView control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static ListView Location(this ListView control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static ListView Margin(this ListView control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static ListView MaximumSize(this ListView control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static ListView MaximumSize(this ListView control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static ListView MinimumSize(this ListView control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static ListView MinimumSize(this ListView control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static ListView Name(this ListView control, String value)
        {
            control.Name = value;
            return control;
        }

        public static ListView Parent(this ListView control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static ListView Region(this ListView control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static ListView RightToLeft(this ListView control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static ListView Size(this ListView control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static ListView Size(this ListView control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static ListView TabIndex(this ListView control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static ListView TabStop(this ListView control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static ListView Tag(this ListView control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static ListView Top(this ListView control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static ListView UseWaitCursor(this ListView control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static ListView Visible(this ListView control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static ListView Width(this ListView control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static ListView WindowTarget(this ListView control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static ListView ImeMode(this ListView control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static ListView OnBackgroundImageLayoutChanged(this ListView control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static ListView OnRightToLeftLayoutChanged(this ListView control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static ListView OnTextChanged(this ListView control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static ListView OnAfterLabelEdit(this ListView control, LabelEditEventHandler handler)
        {
            control.AfterLabelEdit += handler;
            return control;
        }

        public static ListView OnBeforeLabelEdit(this ListView control, LabelEditEventHandler handler)
        {
            control.BeforeLabelEdit += handler;
            return control;
        }

        public static ListView OnCacheVirtualItems(this ListView control, CacheVirtualItemsEventHandler handler)
        {
            control.CacheVirtualItems += handler;
            return control;
        }

        public static ListView OnColumnClick(this ListView control, ColumnClickEventHandler handler)
        {
            control.ColumnClick += handler;
            return control;
        }

        public static ListView OnGroupTaskLinkClick(this ListView control, EventHandler<ListViewGroupEventArgs> handler)
        {
            control.GroupTaskLinkClick += handler;
            return control;
        }

        public static ListView OnColumnReordered(this ListView control, ColumnReorderedEventHandler handler)
        {
            control.ColumnReordered += handler;
            return control;
        }

        public static ListView OnColumnWidthChanged(this ListView control, ColumnWidthChangedEventHandler handler)
        {
            control.ColumnWidthChanged += handler;
            return control;
        }

        public static ListView OnColumnWidthChanging(this ListView control, ColumnWidthChangingEventHandler handler)
        {
            control.ColumnWidthChanging += handler;
            return control;
        }

        public static ListView OnDrawColumnHeader(this ListView control, DrawListViewColumnHeaderEventHandler handler)
        {
            control.DrawColumnHeader += handler;
            return control;
        }

        public static ListView OnDrawItem(this ListView control, DrawListViewItemEventHandler handler)
        {
            control.DrawItem += handler;
            return control;
        }

        public static ListView OnDrawSubItem(this ListView control, DrawListViewSubItemEventHandler handler)
        {
            control.DrawSubItem += handler;
            return control;
        }

        public static ListView OnItemActivate(this ListView control, EventHandler handler)
        {
            control.ItemActivate += handler;
            return control;
        }

        public static ListView OnItemCheck(this ListView control, ItemCheckEventHandler handler)
        {
            control.ItemCheck += handler;
            return control;
        }

        public static ListView OnItemChecked(this ListView control, ItemCheckedEventHandler handler)
        {
            control.ItemChecked += handler;
            return control;
        }

        public static ListView OnItemDrag(this ListView control, ItemDragEventHandler handler)
        {
            control.ItemDrag += handler;
            return control;
        }

        public static ListView OnItemMouseHover(this ListView control, ListViewItemMouseHoverEventHandler handler)
        {
            control.ItemMouseHover += handler;
            return control;
        }

        public static ListView OnItemSelectionChanged(this ListView control, ListViewItemSelectionChangedEventHandler handler)
        {
            control.ItemSelectionChanged += handler;
            return control;
        }

        public static ListView OnGroupCollapsedStateChanged(this ListView control, EventHandler<ListViewGroupEventArgs> handler)
        {
            control.GroupCollapsedStateChanged += handler;
            return control;
        }

        public static ListView OnPaddingChanged(this ListView control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static ListView OnPaint(this ListView control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static ListView OnRetrieveVirtualItem(this ListView control, RetrieveVirtualItemEventHandler handler)
        {
            control.RetrieveVirtualItem += handler;
            return control;
        }

        public static ListView OnSearchForVirtualItem(this ListView control, SearchForVirtualItemEventHandler handler)
        {
            control.SearchForVirtualItem += handler;
            return control;
        }

        public static ListView OnSelectedIndexChanged(this ListView control, EventHandler handler)
        {
            control.SelectedIndexChanged += handler;
            return control;
        }

        public static ListView OnVirtualItemsSelectionRangeChanged(this ListView control, ListViewVirtualItemsSelectionRangeChangedEventHandler handler)
        {
            control.VirtualItemsSelectionRangeChanged += handler;
            return control;
        }

        public static ListView OnAutoSizeChanged(this ListView control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static ListView OnBackColorChanged(this ListView control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static ListView OnBackgroundImageChanged(this ListView control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static ListView OnBindingContextChanged(this ListView control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static ListView OnCausesValidationChanged(this ListView control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static ListView OnClientSizeChanged(this ListView control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static ListView OnContextMenuStripChanged(this ListView control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static ListView OnCursorChanged(this ListView control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static ListView OnDockChanged(this ListView control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static ListView OnEnabledChanged(this ListView control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static ListView OnFontChanged(this ListView control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static ListView OnForeColorChanged(this ListView control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static ListView OnLocationChanged(this ListView control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static ListView OnMarginChanged(this ListView control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static ListView OnRegionChanged(this ListView control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static ListView OnRightToLeftChanged(this ListView control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static ListView OnSizeChanged(this ListView control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static ListView OnTabIndexChanged(this ListView control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static ListView OnTabStopChanged(this ListView control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static ListView OnVisibleChanged(this ListView control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static ListView OnClick(this ListView control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static ListView OnControlAdded(this ListView control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static ListView OnControlRemoved(this ListView control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static ListView OnDataContextChanged(this ListView control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static ListView OnDragDrop(this ListView control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static ListView OnDragEnter(this ListView control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static ListView OnDragOver(this ListView control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static ListView OnDragLeave(this ListView control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static ListView OnGiveFeedback(this ListView control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static ListView OnHandleCreated(this ListView control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static ListView OnHandleDestroyed(this ListView control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static ListView OnHelpRequested(this ListView control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static ListView OnInvalidated(this ListView control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static ListView OnQueryContinueDrag(this ListView control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static ListView OnQueryAccessibilityHelp(this ListView control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static ListView OnDoubleClick(this ListView control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static ListView OnEnter(this ListView control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static ListView OnGotFocus(this ListView control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static ListView OnKeyDown(this ListView control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static ListView OnKeyPress(this ListView control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static ListView OnKeyUp(this ListView control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static ListView OnLayout(this ListView control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static ListView OnLeave(this ListView control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static ListView OnLostFocus(this ListView control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static ListView OnMouseClick(this ListView control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static ListView OnMouseDoubleClick(this ListView control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static ListView OnMouseCaptureChanged(this ListView control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static ListView OnMouseDown(this ListView control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static ListView OnMouseEnter(this ListView control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static ListView OnMouseLeave(this ListView control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static ListView OnDpiChangedBeforeParent(this ListView control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static ListView OnDpiChangedAfterParent(this ListView control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static ListView OnMouseHover(this ListView control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static ListView OnMouseMove(this ListView control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static ListView OnMouseUp(this ListView control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static ListView OnMouseWheel(this ListView control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static ListView OnMove(this ListView control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static ListView OnPreviewKeyDown(this ListView control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static ListView OnResize(this ListView control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static ListView OnChangeUICues(this ListView control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static ListView OnStyleChanged(this ListView control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static ListView OnSystemColorsChanged(this ListView control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static ListView OnValidating(this ListView control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static ListView OnValidated(this ListView control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static ListView OnParentChanged(this ListView control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static ListView OnImeModeChanged(this ListView control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static ListView OnDisposed(this ListView control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static ListView AddTo(this ListView control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static ListView Assign(this ListView control, out ListView variable)
        {
            variable = control;
            return control;
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Collections;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class TreeViewExtensions
    {
        public static TreeView BackColor(this TreeView control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TreeView BackgroundImage(this TreeView control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static TreeView BackgroundImageLayout(this TreeView control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static TreeView BorderStyle(this TreeView control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static TreeView CheckBoxes(this TreeView control, Boolean value)
        {
            control.CheckBoxes = value;
            return control;
        }

        public static TreeView ForeColor(this TreeView control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TreeView FullRowSelect(this TreeView control, Boolean value)
        {
            control.FullRowSelect = value;
            return control;
        }

        public static TreeView HideSelection(this TreeView control, Boolean value)
        {
            control.HideSelection = value;
            return control;
        }

        public static TreeView HotTracking(this TreeView control, Boolean value)
        {
            control.HotTracking = value;
            return control;
        }

        public static TreeView ImageIndex(this TreeView control, Int32 value)
        {
            control.ImageIndex = value;
            return control;
        }

        public static TreeView ImageKey(this TreeView control, String value)
        {
            control.ImageKey = value;
            return control;
        }

        public static TreeView ImageList(this TreeView control, ImageList value)
        {
            control.ImageList = value;
            return control;
        }

        public static TreeView StateImageList(this TreeView control, ImageList value)
        {
            control.StateImageList = value;
            return control;
        }

        public static TreeView Indent(this TreeView control, Int32 value)
        {
            control.Indent = value;
            return control;
        }

        public static TreeView ItemHeight(this TreeView control, Int32 value)
        {
            control.ItemHeight = value;
            return control;
        }

        public static TreeView LabelEdit(this TreeView control, Boolean value)
        {
            control.LabelEdit = value;
            return control;
        }

        public static TreeView LineColor(this TreeView control, int red, int green, int blue)
        {
            control.LineColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static TreeView DrawMode(this TreeView control, TreeViewDrawMode value)
        {
            control.DrawMode = value;
            return control;
        }

        public static TreeView PathSeparator(this TreeView control, String value)
        {
            control.PathSeparator = value;
            return control;
        }

        public static TreeView Padding(this TreeView control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static TreeView RightToLeftLayout(this TreeView control, Boolean value)
        {
            control.RightToLeftLayout = value;
            return control;
        }

        public static TreeView Scrollable(this TreeView control, Boolean value)
        {
            control.Scrollable = value;
            return control;
        }

        public static TreeView SelectedImageIndex(this TreeView control, Int32 value)
        {
            control.SelectedImageIndex = value;
            return control;
        }

        public static TreeView SelectedImageKey(this TreeView control, String value)
        {
            control.SelectedImageKey = value;
            return control;
        }

        public static TreeView SelectedNode(this TreeView control, TreeNode value)
        {
            control.SelectedNode = value;
            return control;
        }

        public static TreeView ShowLines(this TreeView control, Boolean value)
        {
            control.ShowLines = value;
            return control;
        }

        public static TreeView ShowNodeToolTips(this TreeView control, Boolean value)
        {
            control.ShowNodeToolTips = value;
            return control;
        }

        public static TreeView ShowPlusMinus(this TreeView control, Boolean value)
        {
            control.ShowPlusMinus = value;
            return control;
        }

        public static TreeView ShowRootLines(this TreeView control, Boolean value)
        {
            control.ShowRootLines = value;
            return control;
        }

        public static TreeView Sorted(this TreeView control, Boolean value)
        {
            control.Sorted = value;
            return control;
        }

        public static TreeView TreeViewNodeSorter(this TreeView control, IComparer value)
        {
            control.TreeViewNodeSorter = value;
            return control;
        }

        public static TreeView Text(this TreeView control, String value)
        {
            control.Text = value;
            return control;
        }

        public static TreeView TopNode(this TreeView control, TreeNode value)
        {
            control.TopNode = value;
            return control;
        }

        public static TreeView AccessibleDefaultActionDescription(this TreeView control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static TreeView AccessibleDescription(this TreeView control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static TreeView AccessibleName(this TreeView control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static TreeView AccessibleRole(this TreeView control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static TreeView AllowDrop(this TreeView control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static TreeView Anchor(this TreeView control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static TreeView AutoSize(this TreeView control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static TreeView AutoScrollOffset(this TreeView control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static TreeView DataContext(this TreeView control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static TreeView BindingContext(this TreeView control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static TreeView Bounds(this TreeView control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static TreeView Capture(this TreeView control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static TreeView CausesValidation(this TreeView control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static TreeView ClientSize(this TreeView control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static TreeView ContextMenuStrip(this TreeView control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static TreeView Cursor(this TreeView control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static TreeView Dock(this TreeView control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static TreeView Enabled(this TreeView control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static TreeView Font(this TreeView control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static TreeView Height(this TreeView control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static TreeView IsAccessible(this TreeView control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static TreeView Left(this TreeView control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static TreeView Location(this TreeView control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static TreeView Margin(this TreeView control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static TreeView MaximumSize(this TreeView control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static TreeView MinimumSize(this TreeView control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static TreeView Name(this TreeView control, String value)
        {
            control.Name = value;
            return control;
        }

        public static TreeView Parent(this TreeView control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static TreeView Region(this TreeView control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static TreeView RightToLeft(this TreeView control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static TreeView Size(this TreeView control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static TreeView TabIndex(this TreeView control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static TreeView TabStop(this TreeView control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static TreeView Tag(this TreeView control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static TreeView Top(this TreeView control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static TreeView UseWaitCursor(this TreeView control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static TreeView Visible(this TreeView control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static TreeView Width(this TreeView control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static TreeView WindowTarget(this TreeView control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static TreeView ImeMode(this TreeView control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static TreeView OnBackgroundImageChanged(this TreeView control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static TreeView OnBackgroundImageLayoutChanged(this TreeView control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static TreeView OnPaddingChanged(this TreeView control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static TreeView OnTextChanged(this TreeView control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static TreeView OnBeforeLabelEdit(this TreeView control, NodeLabelEditEventHandler handler)
        {
            control.BeforeLabelEdit += handler;
            return control;
        }

        public static TreeView OnAfterLabelEdit(this TreeView control, NodeLabelEditEventHandler handler)
        {
            control.AfterLabelEdit += handler;
            return control;
        }

        public static TreeView OnBeforeCheck(this TreeView control, TreeViewCancelEventHandler handler)
        {
            control.BeforeCheck += handler;
            return control;
        }

        public static TreeView OnAfterCheck(this TreeView control, TreeViewEventHandler handler)
        {
            control.AfterCheck += handler;
            return control;
        }

        public static TreeView OnBeforeCollapse(this TreeView control, TreeViewCancelEventHandler handler)
        {
            control.BeforeCollapse += handler;
            return control;
        }

        public static TreeView OnAfterCollapse(this TreeView control, TreeViewEventHandler handler)
        {
            control.AfterCollapse += handler;
            return control;
        }

        public static TreeView OnBeforeExpand(this TreeView control, TreeViewCancelEventHandler handler)
        {
            control.BeforeExpand += handler;
            return control;
        }

        public static TreeView OnAfterExpand(this TreeView control, TreeViewEventHandler handler)
        {
            control.AfterExpand += handler;
            return control;
        }

        public static TreeView OnDrawNode(this TreeView control, DrawTreeNodeEventHandler handler)
        {
            control.DrawNode += handler;
            return control;
        }

        public static TreeView OnItemDrag(this TreeView control, ItemDragEventHandler handler)
        {
            control.ItemDrag += handler;
            return control;
        }

        public static TreeView OnNodeMouseHover(this TreeView control, TreeNodeMouseHoverEventHandler handler)
        {
            control.NodeMouseHover += handler;
            return control;
        }

        public static TreeView OnBeforeSelect(this TreeView control, TreeViewCancelEventHandler handler)
        {
            control.BeforeSelect += handler;
            return control;
        }

        public static TreeView OnAfterSelect(this TreeView control, TreeViewEventHandler handler)
        {
            control.AfterSelect += handler;
            return control;
        }

        public static TreeView OnPaint(this TreeView control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static TreeView OnNodeMouseClick(this TreeView control, TreeNodeMouseClickEventHandler handler)
        {
            control.NodeMouseClick += handler;
            return control;
        }

        public static TreeView OnNodeMouseDoubleClick(this TreeView control, TreeNodeMouseClickEventHandler handler)
        {
            control.NodeMouseDoubleClick += handler;
            return control;
        }

        public static TreeView OnRightToLeftLayoutChanged(this TreeView control, EventHandler handler)
        {
            control.RightToLeftLayoutChanged += handler;
            return control;
        }

        public static TreeView OnAutoSizeChanged(this TreeView control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static TreeView OnBackColorChanged(this TreeView control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static TreeView OnBindingContextChanged(this TreeView control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static TreeView OnCausesValidationChanged(this TreeView control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static TreeView OnClientSizeChanged(this TreeView control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static TreeView OnContextMenuStripChanged(this TreeView control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static TreeView OnCursorChanged(this TreeView control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static TreeView OnDockChanged(this TreeView control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static TreeView OnEnabledChanged(this TreeView control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static TreeView OnFontChanged(this TreeView control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static TreeView OnForeColorChanged(this TreeView control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static TreeView OnLocationChanged(this TreeView control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static TreeView OnMarginChanged(this TreeView control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static TreeView OnRegionChanged(this TreeView control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static TreeView OnRightToLeftChanged(this TreeView control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static TreeView OnSizeChanged(this TreeView control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static TreeView OnTabIndexChanged(this TreeView control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static TreeView OnTabStopChanged(this TreeView control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static TreeView OnVisibleChanged(this TreeView control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static TreeView OnClick(this TreeView control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static TreeView OnControlAdded(this TreeView control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static TreeView OnControlRemoved(this TreeView control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static TreeView OnDataContextChanged(this TreeView control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static TreeView OnDragDrop(this TreeView control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static TreeView OnDragEnter(this TreeView control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static TreeView OnDragOver(this TreeView control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static TreeView OnDragLeave(this TreeView control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static TreeView OnGiveFeedback(this TreeView control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static TreeView OnHandleCreated(this TreeView control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static TreeView OnHandleDestroyed(this TreeView control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static TreeView OnHelpRequested(this TreeView control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static TreeView OnInvalidated(this TreeView control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static TreeView OnQueryContinueDrag(this TreeView control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static TreeView OnQueryAccessibilityHelp(this TreeView control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static TreeView OnDoubleClick(this TreeView control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static TreeView OnEnter(this TreeView control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static TreeView OnGotFocus(this TreeView control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static TreeView OnKeyDown(this TreeView control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static TreeView OnKeyPress(this TreeView control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static TreeView OnKeyUp(this TreeView control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static TreeView OnLayout(this TreeView control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static TreeView OnLeave(this TreeView control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static TreeView OnLostFocus(this TreeView control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static TreeView OnMouseClick(this TreeView control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static TreeView OnMouseDoubleClick(this TreeView control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static TreeView OnMouseCaptureChanged(this TreeView control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static TreeView OnMouseDown(this TreeView control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static TreeView OnMouseEnter(this TreeView control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static TreeView OnMouseLeave(this TreeView control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static TreeView OnDpiChangedBeforeParent(this TreeView control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static TreeView OnDpiChangedAfterParent(this TreeView control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static TreeView OnMouseHover(this TreeView control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static TreeView OnMouseMove(this TreeView control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static TreeView OnMouseUp(this TreeView control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static TreeView OnMouseWheel(this TreeView control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static TreeView OnMove(this TreeView control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static TreeView OnPreviewKeyDown(this TreeView control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static TreeView OnResize(this TreeView control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static TreeView OnChangeUICues(this TreeView control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static TreeView OnStyleChanged(this TreeView control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static TreeView OnSystemColorsChanged(this TreeView control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static TreeView OnValidating(this TreeView control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static TreeView OnValidated(this TreeView control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static TreeView OnParentChanged(this TreeView control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static TreeView OnImeModeChanged(this TreeView control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static TreeView OnDisposed(this TreeView control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static TreeView AddTo(this TreeView control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

    }
}

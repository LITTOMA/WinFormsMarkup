using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
namespace WinFormsMarkup
{
    public static class DataGridViewExtensions
    {
        public static DataGridView AllowUserToAddRows(this DataGridView control, Boolean value)
        {
            control.AllowUserToAddRows = value;
            return control;
        }

        public static DataGridView AllowUserToDeleteRows(this DataGridView control, Boolean value)
        {
            control.AllowUserToDeleteRows = value;
            return control;
        }

        public static DataGridView AllowUserToOrderColumns(this DataGridView control, Boolean value)
        {
            control.AllowUserToOrderColumns = value;
            return control;
        }

        public static DataGridView AllowUserToResizeColumns(this DataGridView control, Boolean value)
        {
            control.AllowUserToResizeColumns = value;
            return control;
        }

        public static DataGridView AllowUserToResizeRows(this DataGridView control, Boolean value)
        {
            control.AllowUserToResizeRows = value;
            return control;
        }

        public static DataGridView AlternatingRowsDefaultCellStyle(this DataGridView control, DataGridViewCellStyle value)
        {
            control.AlternatingRowsDefaultCellStyle = value;
            return control;
        }

        public static DataGridView AutoGenerateColumns(this DataGridView control, Boolean value)
        {
            control.AutoGenerateColumns = value;
            return control;
        }

        public static DataGridView AutoSize(this DataGridView control, Boolean value)
        {
            control.AutoSize = value;
            return control;
        }

        public static DataGridView AutoSizeColumnsMode(this DataGridView control, DataGridViewAutoSizeColumnsMode value)
        {
            control.AutoSizeColumnsMode = value;
            return control;
        }

        public static DataGridView AutoSizeRowsMode(this DataGridView control, DataGridViewAutoSizeRowsMode value)
        {
            control.AutoSizeRowsMode = value;
            return control;
        }

        public static DataGridView BackColor(this DataGridView control, int red, int green, int blue)
        {
            control.BackColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridView BackColor(this DataGridView control, int red, int green, int blue, int alpha)
        {
            control.BackColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static DataGridView BackColor(this DataGridView control, Color color)
        {
            control.BackColor = color;
            return control;
        }

        public static DataGridView BackgroundColor(this DataGridView control, int red, int green, int blue)
        {
            control.BackgroundColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridView BackgroundColor(this DataGridView control, int red, int green, int blue, int alpha)
        {
            control.BackgroundColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static DataGridView BackgroundColor(this DataGridView control, Color color)
        {
            control.BackgroundColor = color;
            return control;
        }

        public static DataGridView BackgroundImage(this DataGridView control, Image value)
        {
            control.BackgroundImage = value;
            return control;
        }

        public static DataGridView BackgroundImageLayout(this DataGridView control, ImageLayout value)
        {
            control.BackgroundImageLayout = value;
            return control;
        }

        public static DataGridView BorderStyle(this DataGridView control, BorderStyle value)
        {
            control.BorderStyle = value;
            return control;
        }

        public static DataGridView CellBorderStyle(this DataGridView control, DataGridViewCellBorderStyle value)
        {
            control.CellBorderStyle = value;
            return control;
        }

        public static DataGridView ClipboardCopyMode(this DataGridView control, DataGridViewClipboardCopyMode value)
        {
            control.ClipboardCopyMode = value;
            return control;
        }

        public static DataGridView ColumnCount(this DataGridView control, Int32 value)
        {
            control.ColumnCount = value;
            return control;
        }

        public static DataGridView ColumnHeadersBorderStyle(this DataGridView control, DataGridViewHeaderBorderStyle value)
        {
            control.ColumnHeadersBorderStyle = value;
            return control;
        }

        public static DataGridView ColumnHeadersDefaultCellStyle(this DataGridView control, DataGridViewCellStyle value)
        {
            control.ColumnHeadersDefaultCellStyle = value;
            return control;
        }

        public static DataGridView ColumnHeadersHeight(this DataGridView control, Int32 value)
        {
            control.ColumnHeadersHeight = value;
            return control;
        }

        public static DataGridView ColumnHeadersHeightSizeMode(this DataGridView control, DataGridViewColumnHeadersHeightSizeMode value)
        {
            control.ColumnHeadersHeightSizeMode = value;
            return control;
        }

        public static DataGridView ColumnHeadersVisible(this DataGridView control, Boolean value)
        {
            control.ColumnHeadersVisible = value;
            return control;
        }

        public static DataGridView CurrentCell(this DataGridView control, DataGridViewCell value)
        {
            control.CurrentCell = value;
            return control;
        }

        public static DataGridView DataMember(this DataGridView control, String value)
        {
            control.DataMember = value;
            return control;
        }

        public static DataGridView DataSource(this DataGridView control, Object value)
        {
            control.DataSource = value;
            return control;
        }

        public static DataGridView DefaultCellStyle(this DataGridView control, DataGridViewCellStyle value)
        {
            control.DefaultCellStyle = value;
            return control;
        }

        public static DataGridView EditMode(this DataGridView control, DataGridViewEditMode value)
        {
            control.EditMode = value;
            return control;
        }

        public static DataGridView EnableHeadersVisualStyles(this DataGridView control, Boolean value)
        {
            control.EnableHeadersVisualStyles = value;
            return control;
        }

        public static DataGridView FirstDisplayedCell(this DataGridView control, DataGridViewCell value)
        {
            control.FirstDisplayedCell = value;
            return control;
        }

        public static DataGridView FirstDisplayedScrollingColumnIndex(this DataGridView control, Int32 value)
        {
            control.FirstDisplayedScrollingColumnIndex = value;
            return control;
        }

        public static DataGridView FirstDisplayedScrollingRowIndex(this DataGridView control, Int32 value)
        {
            control.FirstDisplayedScrollingRowIndex = value;
            return control;
        }

        public static DataGridView ForeColor(this DataGridView control, int red, int green, int blue)
        {
            control.ForeColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridView ForeColor(this DataGridView control, int red, int green, int blue, int alpha)
        {
            control.ForeColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static DataGridView ForeColor(this DataGridView control, Color color)
        {
            control.ForeColor = color;
            return control;
        }

        public static DataGridView Font(this DataGridView control, string familyName, float emSize, FontStyle style = FontStyle.Regular)
        {
            control.Font = new Font(familyName, emSize, style);
            return control;
        }

        public static DataGridView Font(this DataGridView control, Font font)
        {
            control.Font = font;
            return control;
        }

        public static DataGridView GridColor(this DataGridView control, int red, int green, int blue)
        {
            control.GridColor = Color.FromArgb(red, green, blue);
            return control;
        }

        public static DataGridView GridColor(this DataGridView control, int red, int green, int blue, int alpha)
        {
            control.GridColor = Color.FromArgb(alpha, red, green, blue);
            return control;
        }

        public static DataGridView GridColor(this DataGridView control, Color color)
        {
            control.GridColor = color;
            return control;
        }

        public static DataGridView HorizontalScrollingOffset(this DataGridView control, Int32 value)
        {
            control.HorizontalScrollingOffset = value;
            return control;
        }

        public static DataGridView MultiSelect(this DataGridView control, Boolean value)
        {
            control.MultiSelect = value;
            return control;
        }

        public static DataGridView Padding(this DataGridView control, Padding value)
        {
            control.Padding = value;
            return control;
        }

        public static DataGridView ReadOnly(this DataGridView control, Boolean value)
        {
            control.ReadOnly = value;
            return control;
        }

        public static DataGridView RowCount(this DataGridView control, Int32 value)
        {
            control.RowCount = value;
            return control;
        }

        public static DataGridView RowHeadersBorderStyle(this DataGridView control, DataGridViewHeaderBorderStyle value)
        {
            control.RowHeadersBorderStyle = value;
            return control;
        }

        public static DataGridView RowHeadersDefaultCellStyle(this DataGridView control, DataGridViewCellStyle value)
        {
            control.RowHeadersDefaultCellStyle = value;
            return control;
        }

        public static DataGridView RowHeadersVisible(this DataGridView control, Boolean value)
        {
            control.RowHeadersVisible = value;
            return control;
        }

        public static DataGridView RowHeadersWidth(this DataGridView control, Int32 value)
        {
            control.RowHeadersWidth = value;
            return control;
        }

        public static DataGridView RowHeadersWidthSizeMode(this DataGridView control, DataGridViewRowHeadersWidthSizeMode value)
        {
            control.RowHeadersWidthSizeMode = value;
            return control;
        }

        public static DataGridView RowsDefaultCellStyle(this DataGridView control, DataGridViewCellStyle value)
        {
            control.RowsDefaultCellStyle = value;
            return control;
        }

        public static DataGridView RowTemplate(this DataGridView control, DataGridViewRow value)
        {
            control.RowTemplate = value;
            return control;
        }

        public static DataGridView ScrollBars(this DataGridView control, ScrollBars value)
        {
            control.ScrollBars = value;
            return control;
        }

        public static DataGridView SelectionMode(this DataGridView control, DataGridViewSelectionMode value)
        {
            control.SelectionMode = value;
            return control;
        }

        public static DataGridView ShowCellErrors(this DataGridView control, Boolean value)
        {
            control.ShowCellErrors = value;
            return control;
        }

        public static DataGridView ShowCellToolTips(this DataGridView control, Boolean value)
        {
            control.ShowCellToolTips = value;
            return control;
        }

        public static DataGridView ShowEditingIcon(this DataGridView control, Boolean value)
        {
            control.ShowEditingIcon = value;
            return control;
        }

        public static DataGridView ShowRowErrors(this DataGridView control, Boolean value)
        {
            control.ShowRowErrors = value;
            return control;
        }

        public static DataGridView StandardTab(this DataGridView control, Boolean value)
        {
            control.StandardTab = value;
            return control;
        }

        public static DataGridView Text(this DataGridView control, String value)
        {
            control.Text = value;
            return control;
        }

        public static DataGridView TopLeftHeaderCell(this DataGridView control, DataGridViewHeaderCell value)
        {
            control.TopLeftHeaderCell = value;
            return control;
        }

        public static DataGridView VirtualMode(this DataGridView control, Boolean value)
        {
            control.VirtualMode = value;
            return control;
        }

        public static DataGridView AccessibleDefaultActionDescription(this DataGridView control, String value)
        {
            control.AccessibleDefaultActionDescription = value;
            return control;
        }

        public static DataGridView AccessibleDescription(this DataGridView control, String value)
        {
            control.AccessibleDescription = value;
            return control;
        }

        public static DataGridView AccessibleName(this DataGridView control, String value)
        {
            control.AccessibleName = value;
            return control;
        }

        public static DataGridView AccessibleRole(this DataGridView control, AccessibleRole value)
        {
            control.AccessibleRole = value;
            return control;
        }

        public static DataGridView AllowDrop(this DataGridView control, Boolean value)
        {
            control.AllowDrop = value;
            return control;
        }

        public static DataGridView Anchor(this DataGridView control, AnchorStyles value)
        {
            control.Anchor = value;
            return control;
        }

        public static DataGridView AutoScrollOffset(this DataGridView control, int x, int y)
        {
            control.AutoScrollOffset = new Point(x, y);
            return control;
        }

        public static DataGridView AutoScrollOffset(this DataGridView control, Point point)
        {
            control.AutoScrollOffset = point;
            return control;
        }

        public static DataGridView DataContext(this DataGridView control, Object value)
        {
            control.DataContext = value;
            return control;
        }

        public static DataGridView BindingContext(this DataGridView control, BindingContext value)
        {
            control.BindingContext = value;
            return control;
        }

        public static DataGridView Bounds(this DataGridView control, int x, int y, int width, int height)
        {
            control.Bounds = new Rectangle(x, y, width, height);
            return control;
        }

        public static DataGridView Bounds(this DataGridView control, Point location, Size size)
        {
            control.Bounds = new Rectangle(location, size);
            return control;
        }

        public static DataGridView Bounds(this DataGridView control, Rectangle rectangle)
        {
            control.Bounds = rectangle;
            return control;
        }

        public static DataGridView Capture(this DataGridView control, Boolean value)
        {
            control.Capture = value;
            return control;
        }

        public static DataGridView CausesValidation(this DataGridView control, Boolean value)
        {
            control.CausesValidation = value;
            return control;
        }

        public static DataGridView ClientSize(this DataGridView control, int width, int height)
        {
            control.ClientSize = new Size(width, height);
            return control;
        }

        public static DataGridView ClientSize(this DataGridView control, Size size)
        {
            control.ClientSize = size;
            return control;
        }

        public static DataGridView ContextMenuStrip(this DataGridView control, ContextMenuStrip value)
        {
            control.ContextMenuStrip = value;
            return control;
        }

        public static DataGridView Cursor(this DataGridView control, Cursor value)
        {
            control.Cursor = value;
            return control;
        }

        public static DataGridView Dock(this DataGridView control, DockStyle value)
        {
            control.Dock = value;
            return control;
        }

        public static DataGridView Enabled(this DataGridView control, Boolean value)
        {
            control.Enabled = value;
            return control;
        }

        public static DataGridView Height(this DataGridView control, Int32 value)
        {
            control.Height = value;
            return control;
        }

        public static DataGridView IsAccessible(this DataGridView control, Boolean value)
        {
            control.IsAccessible = value;
            return control;
        }

        public static DataGridView Left(this DataGridView control, Int32 value)
        {
            control.Left = value;
            return control;
        }

        public static DataGridView Location(this DataGridView control, int x, int y)
        {
            control.Location = new Point(x, y);
            return control;
        }

        public static DataGridView Location(this DataGridView control, Point point)
        {
            control.Location = point;
            return control;
        }

        public static DataGridView Margin(this DataGridView control, Padding value)
        {
            control.Margin = value;
            return control;
        }

        public static DataGridView MaximumSize(this DataGridView control, int width, int height)
        {
            control.MaximumSize = new Size(width, height);
            return control;
        }

        public static DataGridView MaximumSize(this DataGridView control, Size size)
        {
            control.MaximumSize = size;
            return control;
        }

        public static DataGridView MinimumSize(this DataGridView control, int width, int height)
        {
            control.MinimumSize = new Size(width, height);
            return control;
        }

        public static DataGridView MinimumSize(this DataGridView control, Size size)
        {
            control.MinimumSize = size;
            return control;
        }

        public static DataGridView Name(this DataGridView control, String value)
        {
            control.Name = value;
            return control;
        }

        public static DataGridView Parent(this DataGridView control, Control value)
        {
            control.Parent = value;
            return control;
        }

        public static DataGridView Region(this DataGridView control, Region value)
        {
            control.Region = value;
            return control;
        }

        public static DataGridView RightToLeft(this DataGridView control, RightToLeft value)
        {
            control.RightToLeft = value;
            return control;
        }

        public static DataGridView Size(this DataGridView control, int width, int height)
        {
            control.Size = new Size(width, height);
            return control;
        }

        public static DataGridView Size(this DataGridView control, Size size)
        {
            control.Size = size;
            return control;
        }

        public static DataGridView TabIndex(this DataGridView control, Int32 value)
        {
            control.TabIndex = value;
            return control;
        }

        public static DataGridView TabStop(this DataGridView control, Boolean value)
        {
            control.TabStop = value;
            return control;
        }

        public static DataGridView Tag(this DataGridView control, Object value)
        {
            control.Tag = value;
            return control;
        }

        public static DataGridView Top(this DataGridView control, Int32 value)
        {
            control.Top = value;
            return control;
        }

        public static DataGridView UseWaitCursor(this DataGridView control, Boolean value)
        {
            control.UseWaitCursor = value;
            return control;
        }

        public static DataGridView Visible(this DataGridView control, Boolean value)
        {
            control.Visible = value;
            return control;
        }

        public static DataGridView Width(this DataGridView control, Int32 value)
        {
            control.Width = value;
            return control;
        }

        public static DataGridView WindowTarget(this DataGridView control, IWindowTarget value)
        {
            control.WindowTarget = value;
            return control;
        }

        public static DataGridView ImeMode(this DataGridView control, ImeMode value)
        {
            control.ImeMode = value;
            return control;
        }

        public static DataGridView OnAllowUserToAddRowsChanged(this DataGridView control, EventHandler handler)
        {
            control.AllowUserToAddRowsChanged += handler;
            return control;
        }

        public static DataGridView OnAllowUserToDeleteRowsChanged(this DataGridView control, EventHandler handler)
        {
            control.AllowUserToDeleteRowsChanged += handler;
            return control;
        }

        public static DataGridView OnAllowUserToOrderColumnsChanged(this DataGridView control, EventHandler handler)
        {
            control.AllowUserToOrderColumnsChanged += handler;
            return control;
        }

        public static DataGridView OnAllowUserToResizeColumnsChanged(this DataGridView control, EventHandler handler)
        {
            control.AllowUserToResizeColumnsChanged += handler;
            return control;
        }

        public static DataGridView OnAllowUserToResizeRowsChanged(this DataGridView control, EventHandler handler)
        {
            control.AllowUserToResizeRowsChanged += handler;
            return control;
        }

        public static DataGridView OnAlternatingRowsDefaultCellStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.AlternatingRowsDefaultCellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnAutoGenerateColumnsChanged(this DataGridView control, EventHandler handler)
        {
            control.AutoGenerateColumnsChanged += handler;
            return control;
        }

        public static DataGridView OnAutoSizeColumnsModeChanged(this DataGridView control, DataGridViewAutoSizeColumnsModeEventHandler handler)
        {
            control.AutoSizeColumnsModeChanged += handler;
            return control;
        }

        public static DataGridView OnAutoSizeRowsModeChanged(this DataGridView control, DataGridViewAutoSizeModeEventHandler handler)
        {
            control.AutoSizeRowsModeChanged += handler;
            return control;
        }

        public static DataGridView OnBackColorChanged(this DataGridView control, EventHandler handler)
        {
            control.BackColorChanged += handler;
            return control;
        }

        public static DataGridView OnBackgroundColorChanged(this DataGridView control, EventHandler handler)
        {
            control.BackgroundColorChanged += handler;
            return control;
        }

        public static DataGridView OnBackgroundImageChanged(this DataGridView control, EventHandler handler)
        {
            control.BackgroundImageChanged += handler;
            return control;
        }

        public static DataGridView OnBackgroundImageLayoutChanged(this DataGridView control, EventHandler handler)
        {
            control.BackgroundImageLayoutChanged += handler;
            return control;
        }

        public static DataGridView OnBorderStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.BorderStyleChanged += handler;
            return control;
        }

        public static DataGridView OnCellBorderStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.CellBorderStyleChanged += handler;
            return control;
        }

        public static DataGridView OnColumnHeadersBorderStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.ColumnHeadersBorderStyleChanged += handler;
            return control;
        }

        public static DataGridView OnColumnHeadersDefaultCellStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.ColumnHeadersDefaultCellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnColumnHeadersHeightChanged(this DataGridView control, EventHandler handler)
        {
            control.ColumnHeadersHeightChanged += handler;
            return control;
        }

        public static DataGridView OnColumnHeadersHeightSizeModeChanged(this DataGridView control, DataGridViewAutoSizeModeEventHandler handler)
        {
            control.ColumnHeadersHeightSizeModeChanged += handler;
            return control;
        }

        public static DataGridView OnDataMemberChanged(this DataGridView control, EventHandler handler)
        {
            control.DataMemberChanged += handler;
            return control;
        }

        public static DataGridView OnDataSourceChanged(this DataGridView control, EventHandler handler)
        {
            control.DataSourceChanged += handler;
            return control;
        }

        public static DataGridView OnDefaultCellStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.DefaultCellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnEditModeChanged(this DataGridView control, EventHandler handler)
        {
            control.EditModeChanged += handler;
            return control;
        }

        public static DataGridView OnForeColorChanged(this DataGridView control, EventHandler handler)
        {
            control.ForeColorChanged += handler;
            return control;
        }

        public static DataGridView OnFontChanged(this DataGridView control, EventHandler handler)
        {
            control.FontChanged += handler;
            return control;
        }

        public static DataGridView OnGridColorChanged(this DataGridView control, EventHandler handler)
        {
            control.GridColorChanged += handler;
            return control;
        }

        public static DataGridView OnMultiSelectChanged(this DataGridView control, EventHandler handler)
        {
            control.MultiSelectChanged += handler;
            return control;
        }

        public static DataGridView OnPaddingChanged(this DataGridView control, EventHandler handler)
        {
            control.PaddingChanged += handler;
            return control;
        }

        public static DataGridView OnReadOnlyChanged(this DataGridView control, EventHandler handler)
        {
            control.ReadOnlyChanged += handler;
            return control;
        }

        public static DataGridView OnRowHeadersBorderStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.RowHeadersBorderStyleChanged += handler;
            return control;
        }

        public static DataGridView OnRowHeadersDefaultCellStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.RowHeadersDefaultCellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnRowHeadersWidthChanged(this DataGridView control, EventHandler handler)
        {
            control.RowHeadersWidthChanged += handler;
            return control;
        }

        public static DataGridView OnRowHeadersWidthSizeModeChanged(this DataGridView control, DataGridViewAutoSizeModeEventHandler handler)
        {
            control.RowHeadersWidthSizeModeChanged += handler;
            return control;
        }

        public static DataGridView OnRowsDefaultCellStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.RowsDefaultCellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnTextChanged(this DataGridView control, EventHandler handler)
        {
            control.TextChanged += handler;
            return control;
        }

        public static DataGridView OnAutoSizeColumnModeChanged(this DataGridView control, DataGridViewAutoSizeColumnModeEventHandler handler)
        {
            control.AutoSizeColumnModeChanged += handler;
            return control;
        }

        public static DataGridView OnCancelRowEdit(this DataGridView control, QuestionEventHandler handler)
        {
            control.CancelRowEdit += handler;
            return control;
        }

        public static DataGridView OnCellBeginEdit(this DataGridView control, DataGridViewCellCancelEventHandler handler)
        {
            control.CellBeginEdit += handler;
            return control;
        }

        public static DataGridView OnCellClick(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellClick += handler;
            return control;
        }

        public static DataGridView OnCellContentClick(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellContentClick += handler;
            return control;
        }

        public static DataGridView OnCellContentDoubleClick(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellContentDoubleClick += handler;
            return control;
        }

        public static DataGridView OnCellContextMenuStripChanged(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellContextMenuStripChanged += handler;
            return control;
        }

        public static DataGridView OnCellContextMenuStripNeeded(this DataGridView control, DataGridViewCellContextMenuStripNeededEventHandler handler)
        {
            control.CellContextMenuStripNeeded += handler;
            return control;
        }

        public static DataGridView OnCellDoubleClick(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellDoubleClick += handler;
            return control;
        }

        public static DataGridView OnCellEndEdit(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellEndEdit += handler;
            return control;
        }

        public static DataGridView OnCellEnter(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellEnter += handler;
            return control;
        }

        public static DataGridView OnCellErrorTextChanged(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellErrorTextChanged += handler;
            return control;
        }

        public static DataGridView OnCellErrorTextNeeded(this DataGridView control, DataGridViewCellErrorTextNeededEventHandler handler)
        {
            control.CellErrorTextNeeded += handler;
            return control;
        }

        public static DataGridView OnCellFormatting(this DataGridView control, DataGridViewCellFormattingEventHandler handler)
        {
            control.CellFormatting += handler;
            return control;
        }

        public static DataGridView OnCellLeave(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellLeave += handler;
            return control;
        }

        public static DataGridView OnCellMouseClick(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.CellMouseClick += handler;
            return control;
        }

        public static DataGridView OnCellMouseDoubleClick(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.CellMouseDoubleClick += handler;
            return control;
        }

        public static DataGridView OnCellMouseDown(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.CellMouseDown += handler;
            return control;
        }

        public static DataGridView OnCellMouseEnter(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellMouseEnter += handler;
            return control;
        }

        public static DataGridView OnCellMouseLeave(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellMouseLeave += handler;
            return control;
        }

        public static DataGridView OnCellMouseMove(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.CellMouseMove += handler;
            return control;
        }

        public static DataGridView OnCellMouseUp(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.CellMouseUp += handler;
            return control;
        }

        public static DataGridView OnCellPainting(this DataGridView control, DataGridViewCellPaintingEventHandler handler)
        {
            control.CellPainting += handler;
            return control;
        }

        public static DataGridView OnCellParsing(this DataGridView control, DataGridViewCellParsingEventHandler handler)
        {
            control.CellParsing += handler;
            return control;
        }

        public static DataGridView OnCellStateChanged(this DataGridView control, DataGridViewCellStateChangedEventHandler handler)
        {
            control.CellStateChanged += handler;
            return control;
        }

        public static DataGridView OnCellStyleChanged(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnCellStyleContentChanged(this DataGridView control, DataGridViewCellStyleContentChangedEventHandler handler)
        {
            control.CellStyleContentChanged += handler;
            return control;
        }

        public static DataGridView OnCellToolTipTextChanged(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellToolTipTextChanged += handler;
            return control;
        }

        public static DataGridView OnCellToolTipTextNeeded(this DataGridView control, DataGridViewCellToolTipTextNeededEventHandler handler)
        {
            control.CellToolTipTextNeeded += handler;
            return control;
        }

        public static DataGridView OnCellValidated(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellValidated += handler;
            return control;
        }

        public static DataGridView OnCellValidating(this DataGridView control, DataGridViewCellValidatingEventHandler handler)
        {
            control.CellValidating += handler;
            return control;
        }

        public static DataGridView OnCellValueChanged(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.CellValueChanged += handler;
            return control;
        }

        public static DataGridView OnCellValueNeeded(this DataGridView control, DataGridViewCellValueEventHandler handler)
        {
            control.CellValueNeeded += handler;
            return control;
        }

        public static DataGridView OnCellValuePushed(this DataGridView control, DataGridViewCellValueEventHandler handler)
        {
            control.CellValuePushed += handler;
            return control;
        }

        public static DataGridView OnColumnAdded(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnAdded += handler;
            return control;
        }

        public static DataGridView OnColumnContextMenuStripChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnContextMenuStripChanged += handler;
            return control;
        }

        public static DataGridView OnColumnDataPropertyNameChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnDataPropertyNameChanged += handler;
            return control;
        }

        public static DataGridView OnColumnDefaultCellStyleChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnDefaultCellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnColumnDisplayIndexChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnDisplayIndexChanged += handler;
            return control;
        }

        public static DataGridView OnColumnDividerDoubleClick(this DataGridView control, DataGridViewColumnDividerDoubleClickEventHandler handler)
        {
            control.ColumnDividerDoubleClick += handler;
            return control;
        }

        public static DataGridView OnColumnDividerWidthChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnDividerWidthChanged += handler;
            return control;
        }

        public static DataGridView OnColumnHeaderMouseClick(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.ColumnHeaderMouseClick += handler;
            return control;
        }

        public static DataGridView OnColumnHeaderMouseDoubleClick(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.ColumnHeaderMouseDoubleClick += handler;
            return control;
        }

        public static DataGridView OnColumnHeaderCellChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnHeaderCellChanged += handler;
            return control;
        }

        public static DataGridView OnColumnMinimumWidthChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnMinimumWidthChanged += handler;
            return control;
        }

        public static DataGridView OnColumnNameChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnNameChanged += handler;
            return control;
        }

        public static DataGridView OnColumnRemoved(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnRemoved += handler;
            return control;
        }

        public static DataGridView OnColumnSortModeChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnSortModeChanged += handler;
            return control;
        }

        public static DataGridView OnColumnStateChanged(this DataGridView control, DataGridViewColumnStateChangedEventHandler handler)
        {
            control.ColumnStateChanged += handler;
            return control;
        }

        public static DataGridView OnColumnToolTipTextChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnToolTipTextChanged += handler;
            return control;
        }

        public static DataGridView OnColumnWidthChanged(this DataGridView control, DataGridViewColumnEventHandler handler)
        {
            control.ColumnWidthChanged += handler;
            return control;
        }

        public static DataGridView OnCurrentCellChanged(this DataGridView control, EventHandler handler)
        {
            control.CurrentCellChanged += handler;
            return control;
        }

        public static DataGridView OnCurrentCellDirtyStateChanged(this DataGridView control, EventHandler handler)
        {
            control.CurrentCellDirtyStateChanged += handler;
            return control;
        }

        public static DataGridView OnDataBindingComplete(this DataGridView control, DataGridViewBindingCompleteEventHandler handler)
        {
            control.DataBindingComplete += handler;
            return control;
        }

        public static DataGridView OnDataError(this DataGridView control, DataGridViewDataErrorEventHandler handler)
        {
            control.DataError += handler;
            return control;
        }

        public static DataGridView OnDefaultValuesNeeded(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.DefaultValuesNeeded += handler;
            return control;
        }

        public static DataGridView OnEditingControlShowing(this DataGridView control, DataGridViewEditingControlShowingEventHandler handler)
        {
            control.EditingControlShowing += handler;
            return control;
        }

        public static DataGridView OnNewRowNeeded(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.NewRowNeeded += handler;
            return control;
        }

        public static DataGridView OnRowContextMenuStripChanged(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowContextMenuStripChanged += handler;
            return control;
        }

        public static DataGridView OnRowContextMenuStripNeeded(this DataGridView control, DataGridViewRowContextMenuStripNeededEventHandler handler)
        {
            control.RowContextMenuStripNeeded += handler;
            return control;
        }

        public static DataGridView OnRowDefaultCellStyleChanged(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowDefaultCellStyleChanged += handler;
            return control;
        }

        public static DataGridView OnRowDirtyStateNeeded(this DataGridView control, QuestionEventHandler handler)
        {
            control.RowDirtyStateNeeded += handler;
            return control;
        }

        public static DataGridView OnRowDividerDoubleClick(this DataGridView control, DataGridViewRowDividerDoubleClickEventHandler handler)
        {
            control.RowDividerDoubleClick += handler;
            return control;
        }

        public static DataGridView OnRowDividerHeightChanged(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowDividerHeightChanged += handler;
            return control;
        }

        public static DataGridView OnRowEnter(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.RowEnter += handler;
            return control;
        }

        public static DataGridView OnRowErrorTextChanged(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowErrorTextChanged += handler;
            return control;
        }

        public static DataGridView OnRowErrorTextNeeded(this DataGridView control, DataGridViewRowErrorTextNeededEventHandler handler)
        {
            control.RowErrorTextNeeded += handler;
            return control;
        }

        public static DataGridView OnRowHeaderMouseClick(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.RowHeaderMouseClick += handler;
            return control;
        }

        public static DataGridView OnRowHeaderMouseDoubleClick(this DataGridView control, DataGridViewCellMouseEventHandler handler)
        {
            control.RowHeaderMouseDoubleClick += handler;
            return control;
        }

        public static DataGridView OnRowHeaderCellChanged(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowHeaderCellChanged += handler;
            return control;
        }

        public static DataGridView OnRowHeightChanged(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowHeightChanged += handler;
            return control;
        }

        public static DataGridView OnRowHeightInfoNeeded(this DataGridView control, DataGridViewRowHeightInfoNeededEventHandler handler)
        {
            control.RowHeightInfoNeeded += handler;
            return control;
        }

        public static DataGridView OnRowHeightInfoPushed(this DataGridView control, DataGridViewRowHeightInfoPushedEventHandler handler)
        {
            control.RowHeightInfoPushed += handler;
            return control;
        }

        public static DataGridView OnRowLeave(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.RowLeave += handler;
            return control;
        }

        public static DataGridView OnRowMinimumHeightChanged(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowMinimumHeightChanged += handler;
            return control;
        }

        public static DataGridView OnRowPostPaint(this DataGridView control, DataGridViewRowPostPaintEventHandler handler)
        {
            control.RowPostPaint += handler;
            return control;
        }

        public static DataGridView OnRowPrePaint(this DataGridView control, DataGridViewRowPrePaintEventHandler handler)
        {
            control.RowPrePaint += handler;
            return control;
        }

        public static DataGridView OnRowsAdded(this DataGridView control, DataGridViewRowsAddedEventHandler handler)
        {
            control.RowsAdded += handler;
            return control;
        }

        public static DataGridView OnRowsRemoved(this DataGridView control, DataGridViewRowsRemovedEventHandler handler)
        {
            control.RowsRemoved += handler;
            return control;
        }

        public static DataGridView OnRowStateChanged(this DataGridView control, DataGridViewRowStateChangedEventHandler handler)
        {
            control.RowStateChanged += handler;
            return control;
        }

        public static DataGridView OnRowUnshared(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.RowUnshared += handler;
            return control;
        }

        public static DataGridView OnRowValidated(this DataGridView control, DataGridViewCellEventHandler handler)
        {
            control.RowValidated += handler;
            return control;
        }

        public static DataGridView OnRowValidating(this DataGridView control, DataGridViewCellCancelEventHandler handler)
        {
            control.RowValidating += handler;
            return control;
        }

        public static DataGridView OnScroll(this DataGridView control, ScrollEventHandler handler)
        {
            control.Scroll += handler;
            return control;
        }

        public static DataGridView OnSelectionChanged(this DataGridView control, EventHandler handler)
        {
            control.SelectionChanged += handler;
            return control;
        }

        public static DataGridView OnSortCompare(this DataGridView control, DataGridViewSortCompareEventHandler handler)
        {
            control.SortCompare += handler;
            return control;
        }

        public static DataGridView OnSorted(this DataGridView control, EventHandler handler)
        {
            control.Sorted += handler;
            return control;
        }

        public static DataGridView OnStyleChanged(this DataGridView control, EventHandler handler)
        {
            control.StyleChanged += handler;
            return control;
        }

        public static DataGridView OnUserAddedRow(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.UserAddedRow += handler;
            return control;
        }

        public static DataGridView OnUserDeletedRow(this DataGridView control, DataGridViewRowEventHandler handler)
        {
            control.UserDeletedRow += handler;
            return control;
        }

        public static DataGridView OnUserDeletingRow(this DataGridView control, DataGridViewRowCancelEventHandler handler)
        {
            control.UserDeletingRow += handler;
            return control;
        }

        public static DataGridView OnAutoSizeChanged(this DataGridView control, EventHandler handler)
        {
            control.AutoSizeChanged += handler;
            return control;
        }

        public static DataGridView OnBindingContextChanged(this DataGridView control, EventHandler handler)
        {
            control.BindingContextChanged += handler;
            return control;
        }

        public static DataGridView OnCausesValidationChanged(this DataGridView control, EventHandler handler)
        {
            control.CausesValidationChanged += handler;
            return control;
        }

        public static DataGridView OnClientSizeChanged(this DataGridView control, EventHandler handler)
        {
            control.ClientSizeChanged += handler;
            return control;
        }

        public static DataGridView OnContextMenuStripChanged(this DataGridView control, EventHandler handler)
        {
            control.ContextMenuStripChanged += handler;
            return control;
        }

        public static DataGridView OnCursorChanged(this DataGridView control, EventHandler handler)
        {
            control.CursorChanged += handler;
            return control;
        }

        public static DataGridView OnDockChanged(this DataGridView control, EventHandler handler)
        {
            control.DockChanged += handler;
            return control;
        }

        public static DataGridView OnEnabledChanged(this DataGridView control, EventHandler handler)
        {
            control.EnabledChanged += handler;
            return control;
        }

        public static DataGridView OnLocationChanged(this DataGridView control, EventHandler handler)
        {
            control.LocationChanged += handler;
            return control;
        }

        public static DataGridView OnMarginChanged(this DataGridView control, EventHandler handler)
        {
            control.MarginChanged += handler;
            return control;
        }

        public static DataGridView OnRegionChanged(this DataGridView control, EventHandler handler)
        {
            control.RegionChanged += handler;
            return control;
        }

        public static DataGridView OnRightToLeftChanged(this DataGridView control, EventHandler handler)
        {
            control.RightToLeftChanged += handler;
            return control;
        }

        public static DataGridView OnSizeChanged(this DataGridView control, EventHandler handler)
        {
            control.SizeChanged += handler;
            return control;
        }

        public static DataGridView OnTabIndexChanged(this DataGridView control, EventHandler handler)
        {
            control.TabIndexChanged += handler;
            return control;
        }

        public static DataGridView OnTabStopChanged(this DataGridView control, EventHandler handler)
        {
            control.TabStopChanged += handler;
            return control;
        }

        public static DataGridView OnVisibleChanged(this DataGridView control, EventHandler handler)
        {
            control.VisibleChanged += handler;
            return control;
        }

        public static DataGridView OnClick(this DataGridView control, EventHandler handler)
        {
            control.Click += handler;
            return control;
        }

        public static DataGridView OnControlAdded(this DataGridView control, ControlEventHandler handler)
        {
            control.ControlAdded += handler;
            return control;
        }

        public static DataGridView OnControlRemoved(this DataGridView control, ControlEventHandler handler)
        {
            control.ControlRemoved += handler;
            return control;
        }

        public static DataGridView OnDataContextChanged(this DataGridView control, EventHandler handler)
        {
            control.DataContextChanged += handler;
            return control;
        }

        public static DataGridView OnDragDrop(this DataGridView control, DragEventHandler handler)
        {
            control.DragDrop += handler;
            return control;
        }

        public static DataGridView OnDragEnter(this DataGridView control, DragEventHandler handler)
        {
            control.DragEnter += handler;
            return control;
        }

        public static DataGridView OnDragOver(this DataGridView control, DragEventHandler handler)
        {
            control.DragOver += handler;
            return control;
        }

        public static DataGridView OnDragLeave(this DataGridView control, EventHandler handler)
        {
            control.DragLeave += handler;
            return control;
        }

        public static DataGridView OnGiveFeedback(this DataGridView control, GiveFeedbackEventHandler handler)
        {
            control.GiveFeedback += handler;
            return control;
        }

        public static DataGridView OnHandleCreated(this DataGridView control, EventHandler handler)
        {
            control.HandleCreated += handler;
            return control;
        }

        public static DataGridView OnHandleDestroyed(this DataGridView control, EventHandler handler)
        {
            control.HandleDestroyed += handler;
            return control;
        }

        public static DataGridView OnHelpRequested(this DataGridView control, HelpEventHandler handler)
        {
            control.HelpRequested += handler;
            return control;
        }

        public static DataGridView OnInvalidated(this DataGridView control, InvalidateEventHandler handler)
        {
            control.Invalidated += handler;
            return control;
        }

        public static DataGridView OnPaint(this DataGridView control, PaintEventHandler handler)
        {
            control.Paint += handler;
            return control;
        }

        public static DataGridView OnQueryContinueDrag(this DataGridView control, QueryContinueDragEventHandler handler)
        {
            control.QueryContinueDrag += handler;
            return control;
        }

        public static DataGridView OnQueryAccessibilityHelp(this DataGridView control, QueryAccessibilityHelpEventHandler handler)
        {
            control.QueryAccessibilityHelp += handler;
            return control;
        }

        public static DataGridView OnDoubleClick(this DataGridView control, EventHandler handler)
        {
            control.DoubleClick += handler;
            return control;
        }

        public static DataGridView OnEnter(this DataGridView control, EventHandler handler)
        {
            control.Enter += handler;
            return control;
        }

        public static DataGridView OnGotFocus(this DataGridView control, EventHandler handler)
        {
            control.GotFocus += handler;
            return control;
        }

        public static DataGridView OnKeyDown(this DataGridView control, KeyEventHandler handler)
        {
            control.KeyDown += handler;
            return control;
        }

        public static DataGridView OnKeyPress(this DataGridView control, KeyPressEventHandler handler)
        {
            control.KeyPress += handler;
            return control;
        }

        public static DataGridView OnKeyUp(this DataGridView control, KeyEventHandler handler)
        {
            control.KeyUp += handler;
            return control;
        }

        public static DataGridView OnLayout(this DataGridView control, LayoutEventHandler handler)
        {
            control.Layout += handler;
            return control;
        }

        public static DataGridView OnLeave(this DataGridView control, EventHandler handler)
        {
            control.Leave += handler;
            return control;
        }

        public static DataGridView OnLostFocus(this DataGridView control, EventHandler handler)
        {
            control.LostFocus += handler;
            return control;
        }

        public static DataGridView OnMouseClick(this DataGridView control, MouseEventHandler handler)
        {
            control.MouseClick += handler;
            return control;
        }

        public static DataGridView OnMouseDoubleClick(this DataGridView control, MouseEventHandler handler)
        {
            control.MouseDoubleClick += handler;
            return control;
        }

        public static DataGridView OnMouseCaptureChanged(this DataGridView control, EventHandler handler)
        {
            control.MouseCaptureChanged += handler;
            return control;
        }

        public static DataGridView OnMouseDown(this DataGridView control, MouseEventHandler handler)
        {
            control.MouseDown += handler;
            return control;
        }

        public static DataGridView OnMouseEnter(this DataGridView control, EventHandler handler)
        {
            control.MouseEnter += handler;
            return control;
        }

        public static DataGridView OnMouseLeave(this DataGridView control, EventHandler handler)
        {
            control.MouseLeave += handler;
            return control;
        }

        public static DataGridView OnDpiChangedBeforeParent(this DataGridView control, EventHandler handler)
        {
            control.DpiChangedBeforeParent += handler;
            return control;
        }

        public static DataGridView OnDpiChangedAfterParent(this DataGridView control, EventHandler handler)
        {
            control.DpiChangedAfterParent += handler;
            return control;
        }

        public static DataGridView OnMouseHover(this DataGridView control, EventHandler handler)
        {
            control.MouseHover += handler;
            return control;
        }

        public static DataGridView OnMouseMove(this DataGridView control, MouseEventHandler handler)
        {
            control.MouseMove += handler;
            return control;
        }

        public static DataGridView OnMouseUp(this DataGridView control, MouseEventHandler handler)
        {
            control.MouseUp += handler;
            return control;
        }

        public static DataGridView OnMouseWheel(this DataGridView control, MouseEventHandler handler)
        {
            control.MouseWheel += handler;
            return control;
        }

        public static DataGridView OnMove(this DataGridView control, EventHandler handler)
        {
            control.Move += handler;
            return control;
        }

        public static DataGridView OnPreviewKeyDown(this DataGridView control, PreviewKeyDownEventHandler handler)
        {
            control.PreviewKeyDown += handler;
            return control;
        }

        public static DataGridView OnResize(this DataGridView control, EventHandler handler)
        {
            control.Resize += handler;
            return control;
        }

        public static DataGridView OnChangeUICues(this DataGridView control, UICuesEventHandler handler)
        {
            control.ChangeUICues += handler;
            return control;
        }

        public static DataGridView OnSystemColorsChanged(this DataGridView control, EventHandler handler)
        {
            control.SystemColorsChanged += handler;
            return control;
        }

        public static DataGridView OnValidating(this DataGridView control, CancelEventHandler handler)
        {
            control.Validating += handler;
            return control;
        }

        public static DataGridView OnValidated(this DataGridView control, EventHandler handler)
        {
            control.Validated += handler;
            return control;
        }

        public static DataGridView OnParentChanged(this DataGridView control, EventHandler handler)
        {
            control.ParentChanged += handler;
            return control;
        }

        public static DataGridView OnImeModeChanged(this DataGridView control, EventHandler handler)
        {
            control.ImeModeChanged += handler;
            return control;
        }

        public static DataGridView OnDisposed(this DataGridView control, EventHandler handler)
        {
            control.Disposed += handler;
            return control;
        }

        public static DataGridView AddTo(this DataGridView control, Control parent)
        {
            parent.Controls.Add(control);
            return control;
        }

        public static DataGridView Assign(this DataGridView control, out DataGridView variable)
        {
            variable = control;
            return control;
        }

    }
}

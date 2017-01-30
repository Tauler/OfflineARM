﻿namespace OfflineARM.Gui.Forms.Orders
{
    partial class OrderSpecificControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpSpecific = new System.Windows.Forms.TableLayoutPanel();
            this.tpSpecificDevideTree = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTableDevided = new System.Windows.Forms.TableLayoutPanel();
            this.gcNomenclatureSelected = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNomenclature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCharacteristic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSelectedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDiscountSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPriceDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbChoiseCharacteristics = new DevExpress.XtraTab.XtraTabControl();
            this.tpOrderCharacteristics = new DevExpress.XtraTab.XtraTabPage();
            this.gcNomenclatureCharactristics = new OfflineARM.Gui.Controls.GridControlWrapper();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpExpositionCharacteristics = new DevExpress.XtraTab.XtraTabPage();
            this.lcOrderHeader = new DevExpress.XtraEditors.LabelControl();
            this.treeList = new OfflineARM.Gui.Controls.TreeListWrapper();
            this.spNext = new DevExpress.XtraEditors.SimpleButton();
            this.gcExposition = new OfflineARM.Gui.Controls.GridControlWrapper();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tlpSpecific.SuspendLayout();
            this.tpSpecificDevideTree.SuspendLayout();
            this.tlpTableDevided.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomenclatureSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChoiseCharacteristics)).BeginInit();
            this.tbChoiseCharacteristics.SuspendLayout();
            this.tpOrderCharacteristics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomenclatureCharactristics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tpExpositionCharacteristics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcExposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSpecific
            // 
            this.tlpSpecific.ColumnCount = 3;
            this.tlpSpecific.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSpecific.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.Controls.Add(this.tpSpecificDevideTree, 1, 1);
            this.tlpSpecific.Controls.Add(this.spNext, 1, 2);
            this.tlpSpecific.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpecific.Location = new System.Drawing.Point(0, 0);
            this.tlpSpecific.Name = "tlpSpecific";
            this.tlpSpecific.RowCount = 4;
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpSpecific.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpecific.Size = new System.Drawing.Size(721, 505);
            this.tlpSpecific.TabIndex = 2;
            // 
            // tpSpecificDevideTree
            // 
            this.tpSpecificDevideTree.ColumnCount = 2;
            this.tpSpecificDevideTree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tpSpecificDevideTree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tpSpecificDevideTree.Controls.Add(this.tlpTableDevided, 1, 0);
            this.tpSpecificDevideTree.Controls.Add(this.treeList, 0, 0);
            this.tpSpecificDevideTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpSpecificDevideTree.Location = new System.Drawing.Point(23, 23);
            this.tpSpecificDevideTree.Name = "tpSpecificDevideTree";
            this.tpSpecificDevideTree.RowCount = 1;
            this.tpSpecificDevideTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpSpecificDevideTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tpSpecificDevideTree.Size = new System.Drawing.Size(675, 409);
            this.tpSpecificDevideTree.TabIndex = 0;
            // 
            // tlpTableDevided
            // 
            this.tlpTableDevided.ColumnCount = 1;
            this.tlpTableDevided.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTableDevided.Controls.Add(this.gcNomenclatureSelected, 0, 2);
            this.tlpTableDevided.Controls.Add(this.tbChoiseCharacteristics, 0, 0);
            this.tlpTableDevided.Controls.Add(this.lcOrderHeader, 0, 1);
            this.tlpTableDevided.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTableDevided.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlpTableDevided.Location = new System.Drawing.Point(180, 3);
            this.tlpTableDevided.Name = "tlpTableDevided";
            this.tlpTableDevided.RowCount = 3;
            this.tlpTableDevided.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTableDevided.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTableDevided.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTableDevided.Size = new System.Drawing.Size(492, 403);
            this.tlpTableDevided.TabIndex = 1;
            // 
            // gcNomenclatureSelected
            // 
            this.gcNomenclatureSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNomenclatureSelected.Location = new System.Drawing.Point(3, 229);
            this.gcNomenclatureSelected.MainView = this.gridView2;
            this.gcNomenclatureSelected.Name = "gcNomenclatureSelected";
            this.gcNomenclatureSelected.Size = new System.Drawing.Size(486, 171);
            this.gcNomenclatureSelected.TabIndex = 1;
            this.gcNomenclatureSelected.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNomenclature,
            this.gcCharacteristic,
            this.gcSelectedPrice,
            this.gcDiscount,
            this.gcDiscountSum,
            this.gcPriceDiscount,
            this.gcCount,
            this.gcSum});
            this.gridView2.GridControl = this.gcNomenclatureSelected;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gcNomenclature
            // 
            this.gcNomenclature.Caption = "Номенклатура";
            this.gcNomenclature.FieldName = "Nomenclature";
            this.gcNomenclature.Name = "gcNomenclature";
            this.gcNomenclature.Visible = true;
            this.gcNomenclature.VisibleIndex = 0;
            // 
            // gcCharacteristic
            // 
            this.gcCharacteristic.Caption = "Характеристика";
            this.gcCharacteristic.FieldName = "Characteristic";
            this.gcCharacteristic.Name = "gcCharacteristic";
            this.gcCharacteristic.Visible = true;
            this.gcCharacteristic.VisibleIndex = 1;
            // 
            // gcSelectedPrice
            // 
            this.gcSelectedPrice.Caption = "Цена";
            this.gcSelectedPrice.FieldName = "Price";
            this.gcSelectedPrice.Name = "gcSelectedPrice";
            this.gcSelectedPrice.Visible = true;
            this.gcSelectedPrice.VisibleIndex = 2;
            // 
            // gcDiscount
            // 
            this.gcDiscount.Caption = "Скидка";
            this.gcDiscount.FieldName = "Discount";
            this.gcDiscount.Name = "gcDiscount";
            this.gcDiscount.Visible = true;
            this.gcDiscount.VisibleIndex = 3;
            // 
            // gcDiscountSum
            // 
            this.gcDiscountSum.Caption = "Сумма скидки";
            this.gcDiscountSum.FieldName = "DiscountSum";
            this.gcDiscountSum.Name = "gcDiscountSum";
            this.gcDiscountSum.Visible = true;
            this.gcDiscountSum.VisibleIndex = 4;
            // 
            // gcPriceDiscount
            // 
            this.gcPriceDiscount.Caption = "Цена со скидкой";
            this.gcPriceDiscount.FieldName = "PriceDiscount";
            this.gcPriceDiscount.Name = "gcPriceDiscount";
            this.gcPriceDiscount.Visible = true;
            this.gcPriceDiscount.VisibleIndex = 5;
            // 
            // gcCount
            // 
            this.gcCount.Caption = "Количество";
            this.gcCount.FieldName = "Count";
            this.gcCount.Name = "gcCount";
            this.gcCount.Visible = true;
            this.gcCount.VisibleIndex = 6;
            // 
            // gcSum
            // 
            this.gcSum.Caption = "Сумма";
            this.gcSum.FieldName = "Sum";
            this.gcSum.Name = "gcSum";
            this.gcSum.Visible = true;
            this.gcSum.VisibleIndex = 7;
            // 
            // tbChoiseCharacteristics
            // 
            this.tbChoiseCharacteristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChoiseCharacteristics.Location = new System.Drawing.Point(3, 3);
            this.tbChoiseCharacteristics.Name = "tbChoiseCharacteristics";
            this.tbChoiseCharacteristics.SelectedTabPage = this.tpOrderCharacteristics;
            this.tbChoiseCharacteristics.Size = new System.Drawing.Size(486, 170);
            this.tbChoiseCharacteristics.TabIndex = 2;
            this.tbChoiseCharacteristics.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpOrderCharacteristics,
            this.tpExpositionCharacteristics});
            // 
            // tpOrderCharacteristics
            // 
            this.tpOrderCharacteristics.Controls.Add(this.gcNomenclatureCharactristics);
            this.tpOrderCharacteristics.Name = "tpOrderCharacteristics";
            this.tpOrderCharacteristics.Size = new System.Drawing.Size(480, 142);
            this.tpOrderCharacteristics.Text = "Характеристики";
            // 
            // gcNomenclatureCharactristics
            // 
            this.gcNomenclatureCharactristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNomenclatureCharactristics.Location = new System.Drawing.Point(0, 0);
            this.gcNomenclatureCharactristics.MainView = this.gridView1;
            this.gcNomenclatureCharactristics.Name = "gcNomenclatureCharactristics";
            this.gcNomenclatureCharactristics.Size = new System.Drawing.Size(480, 142);
            this.gcNomenclatureCharactristics.TabIndex = 0;
            this.gcNomenclatureCharactristics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcNomenclatureCharactristics;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tpExpositionCharacteristics
            // 
            this.tpExpositionCharacteristics.Controls.Add(this.gcExposition);
            this.tpExpositionCharacteristics.Name = "tpExpositionCharacteristics";
            this.tpExpositionCharacteristics.Size = new System.Drawing.Size(480, 142);
            this.tpExpositionCharacteristics.Text = "Экспозиция";
            // 
            // lcOrderHeader
            // 
            this.lcOrderHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcOrderHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lcOrderHeader.Location = new System.Drawing.Point(3, 200);
            this.lcOrderHeader.Name = "lcOrderHeader";
            this.lcOrderHeader.Size = new System.Drawing.Size(217, 23);
            this.lcOrderHeader.TabIndex = 3;
            this.lcOrderHeader.Text = "Спецификация заказа";
            // 
            // treeList
            // 
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(3, 3);
            this.treeList.Name = "treeList";
            this.treeList.Size = new System.Drawing.Size(171, 403);
            this.treeList.TabIndex = 2;
            // 
            // spNext
            // 
            this.spNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spNext.Image = global::OfflineARM.Gui.CommandResources.forward_16x16;
            this.spNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.spNext.Location = new System.Drawing.Point(606, 447);
            this.spNext.Margin = new System.Windows.Forms.Padding(3, 3, 20, 15);
            this.spNext.Name = "spNext";
            this.spNext.Size = new System.Drawing.Size(75, 23);
            this.spNext.TabIndex = 1;
            this.spNext.Text = "spNext";
            // 
            // gcExposition
            // 
            this.gcExposition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExposition.Location = new System.Drawing.Point(0, 0);
            this.gcExposition.MainView = this.gridView3;
            this.gcExposition.Name = "gcExposition";
            this.gcExposition.Size = new System.Drawing.Size(480, 142);
            this.gcExposition.TabIndex = 0;
            this.gcExposition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcExposition;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // OrderSpecificControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSpecific);
            this.Name = "OrderSpecificControl";
            this.Size = new System.Drawing.Size(721, 505);
            this.tlpSpecific.ResumeLayout(false);
            this.tpSpecificDevideTree.ResumeLayout(false);
            this.tlpTableDevided.ResumeLayout(false);
            this.tlpTableDevided.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomenclatureSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChoiseCharacteristics)).EndInit();
            this.tbChoiseCharacteristics.ResumeLayout(false);
            this.tpOrderCharacteristics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNomenclatureCharactristics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tpExpositionCharacteristics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcExposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSpecific;
        private System.Windows.Forms.TableLayoutPanel tpSpecificDevideTree;
        private System.Windows.Forms.TableLayoutPanel tlpTableDevided;
        private DevExpress.XtraGrid.GridControl gcNomenclatureSelected;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabControl tbChoiseCharacteristics;
        private DevExpress.XtraTab.XtraTabPage tpExpositionCharacteristics;
        private DevExpress.XtraTab.XtraTabPage tpOrderCharacteristics;
        private DevExpress.XtraEditors.LabelControl lcOrderHeader;
        private DevExpress.XtraEditors.SimpleButton spNext;
        private DevExpress.XtraGrid.Columns.GridColumn gcNomenclature;
        private DevExpress.XtraGrid.Columns.GridColumn gcCharacteristic;
        private DevExpress.XtraGrid.Columns.GridColumn gcSelectedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gcDiscountSum;
        private DevExpress.XtraGrid.Columns.GridColumn gcPriceDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gcCount;
        private DevExpress.XtraGrid.Columns.GridColumn gcSum;
        private Controls.TreeListWrapper treeList;
        private Controls.GridControlWrapper gcNomenclatureCharactristics;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Controls.GridControlWrapper gcExposition;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}

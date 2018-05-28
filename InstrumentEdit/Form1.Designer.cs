namespace InstrumentEdit
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webFeedRepositoryDataSet = new InstrumentEdit.WebFeedRepositoryDataSet();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentsTableAdapter = new InstrumentEdit.WebFeedRepositoryDataSetTableAdapters.InstrumentsTableAdapter();
            this.idInstrumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInstrumentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarketSegmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysCloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maturityDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspendedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webFeedRepositoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInstrumentDataGridViewTextBoxColumn,
            this.iSINDataGridViewTextBoxColumn,
            this.idInstrumentTypeDataGridViewTextBoxColumn,
            this.idSectorDataGridViewTextBoxColumn,
            this.idMarketSegmentDataGridViewTextBoxColumn,
            this.instrumentTypeIdDataGridViewTextBoxColumn,
            this.daysCloseDataGridViewTextBoxColumn,
            this.sectorIdDataGridViewTextBoxColumn,
            this.marketIdDataGridViewTextBoxColumn,
            this.webAddressDataGridViewTextBoxColumn,
            this.instrumentCodeDataGridViewTextBoxColumn,
            this.instrumentNameDataGridViewTextBoxColumn,
            this.interestRateDataGridViewTextBoxColumn,
            this.maturityDateDataGridViewTextBoxColumn,
            this.modifiedOnDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.suspendedDataGridViewTextBoxColumn,
            this.tradeableDataGridViewTextBoxColumn,
            this.currencyCodeDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.dateDeletedDataGridViewTextBoxColumn,
            this.instrumentShortNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instrumentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // webFeedRepositoryDataSet
            // 
            this.webFeedRepositoryDataSet.DataSetName = "WebFeedRepositoryDataSet";
            this.webFeedRepositoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this.webFeedRepositoryDataSet;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // idInstrumentDataGridViewTextBoxColumn
            // 
            this.idInstrumentDataGridViewTextBoxColumn.DataPropertyName = "IdInstrument";
            this.idInstrumentDataGridViewTextBoxColumn.HeaderText = "IdInstrument";
            this.idInstrumentDataGridViewTextBoxColumn.Name = "idInstrumentDataGridViewTextBoxColumn";
            // 
            // iSINDataGridViewTextBoxColumn
            // 
            this.iSINDataGridViewTextBoxColumn.DataPropertyName = "ISIN";
            this.iSINDataGridViewTextBoxColumn.HeaderText = "ISIN";
            this.iSINDataGridViewTextBoxColumn.Name = "iSINDataGridViewTextBoxColumn";
            // 
            // idInstrumentTypeDataGridViewTextBoxColumn
            // 
            this.idInstrumentTypeDataGridViewTextBoxColumn.DataPropertyName = "IdInstrumentType";
            this.idInstrumentTypeDataGridViewTextBoxColumn.HeaderText = "IdInstrumentType";
            this.idInstrumentTypeDataGridViewTextBoxColumn.Name = "idInstrumentTypeDataGridViewTextBoxColumn";
            // 
            // idSectorDataGridViewTextBoxColumn
            // 
            this.idSectorDataGridViewTextBoxColumn.DataPropertyName = "IdSector";
            this.idSectorDataGridViewTextBoxColumn.HeaderText = "IdSector";
            this.idSectorDataGridViewTextBoxColumn.Name = "idSectorDataGridViewTextBoxColumn";
            // 
            // idMarketSegmentDataGridViewTextBoxColumn
            // 
            this.idMarketSegmentDataGridViewTextBoxColumn.DataPropertyName = "IdMarketSegment";
            this.idMarketSegmentDataGridViewTextBoxColumn.HeaderText = "IdMarketSegment";
            this.idMarketSegmentDataGridViewTextBoxColumn.Name = "idMarketSegmentDataGridViewTextBoxColumn";
            // 
            // instrumentTypeIdDataGridViewTextBoxColumn
            // 
            this.instrumentTypeIdDataGridViewTextBoxColumn.DataPropertyName = "InstrumentTypeId";
            this.instrumentTypeIdDataGridViewTextBoxColumn.HeaderText = "InstrumentTypeId";
            this.instrumentTypeIdDataGridViewTextBoxColumn.Name = "instrumentTypeIdDataGridViewTextBoxColumn";
            // 
            // daysCloseDataGridViewTextBoxColumn
            // 
            this.daysCloseDataGridViewTextBoxColumn.DataPropertyName = "DaysClose";
            this.daysCloseDataGridViewTextBoxColumn.HeaderText = "DaysClose";
            this.daysCloseDataGridViewTextBoxColumn.Name = "daysCloseDataGridViewTextBoxColumn";
            // 
            // sectorIdDataGridViewTextBoxColumn
            // 
            this.sectorIdDataGridViewTextBoxColumn.DataPropertyName = "SectorId";
            this.sectorIdDataGridViewTextBoxColumn.HeaderText = "SectorId";
            this.sectorIdDataGridViewTextBoxColumn.Name = "sectorIdDataGridViewTextBoxColumn";
            // 
            // marketIdDataGridViewTextBoxColumn
            // 
            this.marketIdDataGridViewTextBoxColumn.DataPropertyName = "MarketId";
            this.marketIdDataGridViewTextBoxColumn.HeaderText = "MarketId";
            this.marketIdDataGridViewTextBoxColumn.Name = "marketIdDataGridViewTextBoxColumn";
            // 
            // webAddressDataGridViewTextBoxColumn
            // 
            this.webAddressDataGridViewTextBoxColumn.DataPropertyName = "WebAddress";
            this.webAddressDataGridViewTextBoxColumn.HeaderText = "WebAddress";
            this.webAddressDataGridViewTextBoxColumn.Name = "webAddressDataGridViewTextBoxColumn";
            // 
            // instrumentCodeDataGridViewTextBoxColumn
            // 
            this.instrumentCodeDataGridViewTextBoxColumn.DataPropertyName = "InstrumentCode";
            this.instrumentCodeDataGridViewTextBoxColumn.HeaderText = "InstrumentCode";
            this.instrumentCodeDataGridViewTextBoxColumn.Name = "instrumentCodeDataGridViewTextBoxColumn";
            // 
            // instrumentNameDataGridViewTextBoxColumn
            // 
            this.instrumentNameDataGridViewTextBoxColumn.DataPropertyName = "InstrumentName";
            this.instrumentNameDataGridViewTextBoxColumn.HeaderText = "InstrumentName";
            this.instrumentNameDataGridViewTextBoxColumn.Name = "instrumentNameDataGridViewTextBoxColumn";
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn.HeaderText = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            // 
            // maturityDateDataGridViewTextBoxColumn
            // 
            this.maturityDateDataGridViewTextBoxColumn.DataPropertyName = "MaturityDate";
            this.maturityDateDataGridViewTextBoxColumn.HeaderText = "MaturityDate";
            this.maturityDateDataGridViewTextBoxColumn.Name = "maturityDateDataGridViewTextBoxColumn";
            // 
            // modifiedOnDataGridViewTextBoxColumn
            // 
            this.modifiedOnDataGridViewTextBoxColumn.DataPropertyName = "ModifiedOn";
            this.modifiedOnDataGridViewTextBoxColumn.HeaderText = "ModifiedOn";
            this.modifiedOnDataGridViewTextBoxColumn.Name = "modifiedOnDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // suspendedDataGridViewTextBoxColumn
            // 
            this.suspendedDataGridViewTextBoxColumn.DataPropertyName = "Suspended";
            this.suspendedDataGridViewTextBoxColumn.HeaderText = "Suspended";
            this.suspendedDataGridViewTextBoxColumn.Name = "suspendedDataGridViewTextBoxColumn";
            // 
            // tradeableDataGridViewTextBoxColumn
            // 
            this.tradeableDataGridViewTextBoxColumn.DataPropertyName = "Tradeable";
            this.tradeableDataGridViewTextBoxColumn.HeaderText = "Tradeable";
            this.tradeableDataGridViewTextBoxColumn.Name = "tradeableDataGridViewTextBoxColumn";
            // 
            // currencyCodeDataGridViewTextBoxColumn
            // 
            this.currencyCodeDataGridViewTextBoxColumn.DataPropertyName = "CurrencyCode";
            this.currencyCodeDataGridViewTextBoxColumn.HeaderText = "CurrencyCode";
            this.currencyCodeDataGridViewTextBoxColumn.Name = "currencyCodeDataGridViewTextBoxColumn";
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            // 
            // dateDeletedDataGridViewTextBoxColumn
            // 
            this.dateDeletedDataGridViewTextBoxColumn.DataPropertyName = "DateDeleted";
            this.dateDeletedDataGridViewTextBoxColumn.HeaderText = "DateDeleted";
            this.dateDeletedDataGridViewTextBoxColumn.Name = "dateDeletedDataGridViewTextBoxColumn";
            // 
            // instrumentShortNameDataGridViewTextBoxColumn
            // 
            this.instrumentShortNameDataGridViewTextBoxColumn.DataPropertyName = "InstrumentShortName";
            this.instrumentShortNameDataGridViewTextBoxColumn.HeaderText = "InstrumentShortName";
            this.instrumentShortNameDataGridViewTextBoxColumn.Name = "instrumentShortNameDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webFeedRepositoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WebFeedRepositoryDataSet webFeedRepositoryDataSet;
        private System.Windows.Forms.BindingSource instrumentsBindingSource;
        private WebFeedRepositoryDataSetTableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstrumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstrumentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarketSegmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysCloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maturityDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspendedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}


namespace ADO.NET.UI
{
    public interface ITools
    {
        /// <summary>
        /// Menu strip opens or closes.
        /// </summary>
        void EditMode();
        /// <summary>
        /// After database operation, gives a feedback positive or negative.
        /// </summary>
        void TransactionStatus(bool statement);
        /// <summary>
        /// Refreshes the data in DataGridView
        /// </summary>
        void RefreshDataSource();
        /// <summary>
        /// For Delete,Save..
        /// </summary>
        void KeyDown_HotKeys(System.Windows.Forms.KeyEventArgs e);
    }
}

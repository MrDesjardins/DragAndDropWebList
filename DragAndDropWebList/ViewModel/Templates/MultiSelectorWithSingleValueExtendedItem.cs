namespace DragAndDropWebList.ViewModel.Templates
{
    public class MultiSelectorWithSingleValueExtendedItem<TUniqueIdentifierType, TExtendedValueType> : ISelectorAvailableItemViewModel<TUniqueIdentifierType, TExtendedValueType>
    {

        #region Implementation of ISelectorAvailableItemViewModel<T>

        public TUniqueIdentifierType ID { get; set; }
        public string Description { get; set; }
        public TExtendedValueType ExtendedProperty { get; set; }

        #endregion

    }
}
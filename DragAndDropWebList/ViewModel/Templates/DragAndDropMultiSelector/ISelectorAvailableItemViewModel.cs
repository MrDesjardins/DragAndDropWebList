namespace DragAndDropWebList.ViewModel.Templates.DragAndDropMultiSelector
{
    public interface ISelectorAvailableItemViewModel<TUniqueIdentifierType, TExtendedValueType>
    {
      TUniqueIdentifierType ID { get; set; }
      string Description { get; set; }
      TExtendedValueType ExtendedProperty { get; set; }
    }
}
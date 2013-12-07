using System.Collections.Generic;

namespace DragAndDropWebList.ViewModel.Templates
{
    public class MultiSelectorWithSingleValueExtended<TSelectorType, TExtendedPropertyType> 
    {
        public MultiSelectorWithSingleValueExtended()
        {
            SelectedItems = new List<MultiSelectorWithSingleValueExtendedItem<TSelectorType, TExtendedPropertyType>>();
            AvailableItems = new List<MultiSelectorWithSingleValueExtendedItem<TSelectorType, TExtendedPropertyType>>();
        }

        public List<MultiSelectorWithSingleValueExtendedItem<TSelectorType, TExtendedPropertyType>> SelectedItems { get; set; }
        public List<MultiSelectorWithSingleValueExtendedItem<TSelectorType, TExtendedPropertyType>> AvailableItems { get; set; }


    }
}
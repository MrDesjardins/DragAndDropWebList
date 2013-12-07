using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragAndDropWebList.ViewModel.Templates
{
    public interface ISelectorAvailableItemViewModel<TUniqueIdentifierType, TExtendedValueType>
    {
      TUniqueIdentifierType ID { get; set; }
      string Description { get; set; }
      TExtendedValueType ExtendedProperty { get; set; }
    }
}
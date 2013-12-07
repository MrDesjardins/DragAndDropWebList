using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DragAndDropWebList.ViewModel.Templates;

namespace DragAndDropWebList.Models
{
    public class Person
    {
        public Person()
        {
            this.Attitudes = new MultiSelectorWithSingleValueExtended<Guid, string>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        [UIHint("GuidMultiSelectorExtended")]
        public MultiSelectorWithSingleValueExtended<Guid, string> Attitudes { get; set; } 
    }
}
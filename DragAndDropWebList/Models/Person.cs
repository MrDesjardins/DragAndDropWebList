using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DragAndDropWebList.ViewModel.Templates;
using DragAndDropWebList.ViewModel.Templates.DragAndDropMultiSelector;

namespace DragAndDropWebList.Models
{
    public class Person
    {
        public Person()
        {
            this.Attitudes = new MultiSelectorWithSingleValueExtended();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        [UIHint("MultiSelectorExtended")]
        public MultiSelectorWithSingleValueExtended Attitudes { get; set; } 
    }
}
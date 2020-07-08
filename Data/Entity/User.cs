using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Text;

namespace Data.Entity
{
   public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
    }
}

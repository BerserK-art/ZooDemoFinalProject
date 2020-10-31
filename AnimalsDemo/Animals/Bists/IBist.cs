using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
   public interface IBist : IAnimal
    {
        string Area { get; }
        DateTime FoundingTime { get; }
    }
}

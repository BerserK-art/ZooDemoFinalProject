using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creators
{
   public abstract class BaseCreator : ICreator
    {
        
        public BaseCreator()
        {
        }

        public abstract string Create();
    }
}

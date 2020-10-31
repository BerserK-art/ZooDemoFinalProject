using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface IReaderService
    {
        List<IAnimal> Read();
    }
}

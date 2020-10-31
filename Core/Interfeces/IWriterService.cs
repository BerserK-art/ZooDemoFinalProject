using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface IWriterService
    {
        void Write(List<IAnimal> animals);
    }
}

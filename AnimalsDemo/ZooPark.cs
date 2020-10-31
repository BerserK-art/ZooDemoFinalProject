using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class ZooPark
    {
        private List<IAnimal> _animals;
        public ZooPark()
        {
            _animals = new List<IAnimal>();
        }
        public void Add(IAnimal animal)
        {
            _animals.Add(animal);
        }
        public void Delete(int i)
        {
            if (i < 0 || i > _animals.Count)
                throw new IndexOutOfRangeException("Введённое значение было за пределами массива");
            _animals.RemoveAt(i);
        }
        public string InfoAbout(int i)
        {
            if (i < 0 || i > _animals.Count)
                throw new IndexOutOfRangeException("Введённое значение было за пределами массива");
            return _animals[i].PrintInfo();
        }
        public string MakeSound(int i)
        {
            if (i < 0 || i > _animals.Count)
                throw new IndexOutOfRangeException("Введённое значение было за пределами массива");
            return _animals[i].MakeSound();
        }
        public string PrintAll()
        {
            string all = "";
            int i = 0;
            foreach (var el in _animals)
            {
                all += $"{i})" + el.PrintInfo() + "\n\n";
                i++;
            }
            return all;
        }
        public string AllSounds()
        {
            string all = "";
            for (int i = 0; i < _animals.Count; i++)
                all += $"{i})" + _animals[i].MakeSound() + "\n";
            return all;
        }
        public void ReadFromFile(IReaderService readerService)
        {
            _animals = readerService.Read();
        }
        public void SaveToFile(IWriterService writerService)
        {
            writerService.Write(_animals);
        }
        
    }
}

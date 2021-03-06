﻿using AnimalsDemo;
using Commands.Commands;
using Commands.Coomands;
using Core.Interfeces;
using Services.Fabrics;
using Services.Parsers;
using Services.Services;
using System;
using System.Collections.Generic;
using Zoo.NotifyServices;
 

namespace Zoo
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("Выбирете действие:");
            Console.WriteLine("1 добавить животное");
            Console.WriteLine("2 удалить животное");
            Console.WriteLine("3 Информация о животном");
            Console.WriteLine("4 Информация о всех животных");
            Console.WriteLine("5 Заставить животное издать звук");
            Console.WriteLine("6 заставить всех животных издать звук");
            Console.WriteLine("7 Оменить несохранённые изменения");
            Console.WriteLine("8 Сохранить изменения");
            Console.WriteLine("stop Остановить программу");
        }
        static void Main(string[] args)
        {
            try
            {
                string url = @"ZooInfo.txt";
                ZooPark zoo = new ZooPark();
                IGetService getService = new GetConsole();
                INotifyService notifyService = new NotifyConsole();

                Dictionary<string, IParser> dict = new Dictionary<string, IParser>();
                dict.Add("Chiken", new ToChikenParser());
                dict.Add("Stork", new ToStorkParser());
                dict.Add("Wolf", new ToWolfParser());
                dict.Add("Tiger", new ToTigerParser());
                dict.Add("Cat", new ToCatParser());
                dict.Add("Dog", new ToDogParser());
                ToAnimalParser toAnimalParser = new ToAnimalParser(dict);                      


                Dictionary<string, IFabric> fabrics = new Dictionary<string, IFabric>();
                fabrics.Add("1", new GetChiken(getService, notifyService));
                fabrics.Add("2", new GetStork(getService, notifyService));
                fabrics.Add("3", new GetWolf(getService, notifyService));
                fabrics.Add("4", new GetTiger(getService, notifyService));
                fabrics.Add("5", new GetCat());
                fabrics.Add("6", new GetDog(getService, notifyService));

                Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
                commands.Add("stop", new StopCommand());
                commands.Add("1", new AddAnimalCommand(zoo, new AnimalFabric(fabrics,getService,notifyService)));
                commands.Add("2", new DeleteCommand(zoo,notifyService,getService));
                commands.Add("3", new InfoCommand(zoo, notifyService, getService));
                commands.Add("4", new InfoAllComand(zoo));
                commands.Add("5", new SoundCommand(zoo,notifyService,getService));
                commands.Add("6", new SoundAllCommand(zoo));
                commands.Add("7", new GetZooCommand(zoo,new FileReaderService(url, toAnimalParser)));
                commands.Add("8", new SaveCommand(zoo,new FileWriterService(url)));
                Menu menu = new Menu(commands);

                string variant = "";
                menu.Choose("7");
                do
                {
                    PrintMenu();
                    variant = Console.ReadLine();
                    Console.Clear();
                    if (menu.IsThere(variant))
                        Console.WriteLine(menu.Choose(variant));
                    else Console.WriteLine("Неверный ввод");

                } while (variant != "stop");
            }
           catch(Exception a)
            {
                Console.WriteLine(a.Message);
            }


        }
    }
}

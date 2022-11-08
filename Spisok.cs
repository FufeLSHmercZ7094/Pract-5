using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_5
{
    internal class Spisok
    {
        private bool Change_item = true;
        private bool Start = true;
        private int vert = 1;
        private int gor = 0;
        private int Tseni;
        private int SupportElement;
        private List<Spisok> Menu = new List<Spisok>
        {

        };

        public string Name;
        public string Text;
        public int Tsena;
        public List<Spisok> Item_list = new List<Spisok>
        {
        };

        private void Draw_Strelka(List<Spisok> list)
        {
            Console.SetCursorPosition(gor, vert); ;
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            if (Change_item == true)
            {
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Start = false;
                }
            }
            else
            {
                if (key.Key == ConsoleKey.Backspace)
                {
                    Start = false;
                    Change_item = true;
                    Console.Clear();
                    Console.WriteLine("->");
                    gor = 0;
                    vert = 1;
                }
            }

            if (key.Key == ConsoleKey.Enter)
            {
                if (Change_item == true && vert != list.Count() + 2)
                {
                    Console.Clear();
                    Change_item = false;
                    Drew_Element_List(list);
                }
                else if (Change_item == false && vert == list.Count() + 1)
                {
                    CreateNewItemMenu(list);
                    Console.Clear();

                }
                else if (Change_item == false)
                {
                    Tseni += list[vert - 1].Tsena;
                    Start = false;
                    Change_item = true;
                    Menu.Add(list[vert - 1]);
                }
                else
                {
                    Zakaz();
                }
            }

            if (key.Key == ConsoleKey.UpArrow)
            {
                vert--;
                gor = 0;
                if (vert < 1)
                {
                    if (Change_item == true)
                    {
                        vert = list.Count() + 2;
                        Console.WriteLine("<-");
                        gor = 15;
                    }
                    else
                    {
                        vert = list.Count() + 1;
                        Console.WriteLine("<-");
                        gor = 20;
                    }
                }
                else if (vert == list.Count + 1)
                {
                    vert = list.Count;
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                vert++;
                Console.WriteLine("->");
                gor = 0;
                if (vert > list.Count)
                {
                    if (Change_item == true)
                    {
                        if (vert > list.Count() + 2)
                        {
                            vert = 1;
                        }
                        else
                        {
                            vert = list.Count() + 2;
                            Console.WriteLine("<-");
                            gor = 15;
                        }
                    }
                    else
                    {
                        if (vert == list.Count() + 1)
                        {
                            Console.WriteLine("<-");
                            gor = 20;
                        }
                        else if (vert > list.Count() + 1)
                        {
                            vert = 1;
                        }
                    }
                }
            }
        }

        public void Drew_Menu(List<Spisok> list)
        {
            Console.CursorVisible = false;
            while (Start)
            {
                Console.Clear();
                Console.WriteLine("Заказ тортов : ");
                foreach (var element_list in list)
                {
                    Console.WriteLine(element_list.Name);
                }
                Console.WriteLine("Стоимоть заказа - " + Tseni + " Р");
                Console.WriteLine("Сделать заказ ");
                Console.Write("Ваш заказ : ");
                foreach (var element in Menu)
                {
                    Console.Write(element.Text);
                }
                Console.WriteLine();
                Draw_Strelka(list);
            }
        }

        private void Drew_Element_List(List<Spisok> list)
        {
            var element_list = list[vert - 1];
            vert = 1;
            while (Start)
            {
                Console.Clear();
                Console.WriteLine("Меню:" + element_list.Name);
                foreach (var element_list_list in element_list.Item_list)
                {
                    Console.WriteLine(element_list_list.Text + " - " + element_list_list.Tsena);
                }
                Console.WriteLine("Добавить пункт ");
                Draw_Strelka(element_list.Item_list);
            }
            Start = true;
        }

        private void Zakaz() { 
            string zakaz = "C:\\Пользователи\\Vinog\\Desktop\\.txt";
            if (File.Exists(zakaz))
            {
                File.ReadAllText(zakaz);
            }
            string txt = Tseni.ToString();
            File.AppendAllText(zakaz, DateTime.Now + "\n" + "Цена = " + txt + "\n" + "Состав заказа : \n");
            if (Menu.Count() == 0)
            {
                txt = "  заказ пустой";
                File.AppendAllText(zakaz, txt + "\n");
            }
            else
            {
                foreach (var element in Menu)
                {
                    txt = element.Text;
                    File.AppendAllText(zakaz, txt + "\n");
                }
            }
            Menu.Clear();
            Tsena = 0;
        }

        private void CreateNewItemMenu(List<Spisok> list)
        {
            var Spisok = new Spisok()
            {
                Text = "",
                Tsena = 0
            };
            Console.Clear();
            Console.Write("Введите название : ");
            Spisok.Text = "  " + Console.ReadLine();
            Console.Write("Введите цену : ");
            Spisok.Tsena = Convert.ToInt32(Console.ReadLine());
            list.Add(Spisok);
            vert = 1;
            gor = 0;
            Console.WriteLine("->");
        }
    }
}

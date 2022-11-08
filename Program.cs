namespace Pract_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Spisok> Spisok = new List<Spisok>
            {
                new Spisok
                {
                    Name = "  Бургер",
                    Item_list = new List<Spisok>
                    {
                        new Spisok
                        {
                            Text = "  Чикенбургер",
                            Tsena = 500
                        },
                        new Spisok
                        {
                            Text = "  Роял де Люкс",
                            Tsena = 700
                        },
                        new Spisok
                        {
                            Text = "  Биг мак",
                            Tsena = 800
                        },
                        new Spisok
                        {
                            Text = "  Биг спешиал(Биг тейсти)",
                            Tsena = 1000
                        },
                        new Spisok
                        {
                            Text = "  Цезарь ролл",
                            Tsena = 600
                        },
                        new Spisok
                        {
                            Text = "  Шримп ролл",
                            Tsena = 950
                        }
                    }
                },
                new Spisok
                {
                    Name = "  Картофель",
                    Item_list = new List<Spisok>{
                        new Spisok
                        {
                            Text = "  Картофель фри(мал.)",
                            Tsena = 200
                        },
                        new Spisok
                        {
                            Text = "  Картофель фри(ср.)",
                            Tsena = 350
                        },
                        new Spisok
                        {
                            Text = "  Картофель фри(бол.)",
                            Tsena = 400
                        },
                        new Spisok
                        {
                            Text = "  Картофель по-деревенски (мал.)",
                            Tsena = 300
                        },
                        new Spisok
                        {
                            Text = "  Картофель по-деревенски (ср.)",
                            Tsena = 500
                        },
                        new Spisok
                        {
                            Text = "  Картофель по-деревенски (бол.)",
                            Tsena = 600
                        }
                    }
                },
                new Spisok
                {
                    Name = "  Стартеры",
                    Item_list = new List<Spisok>{
                        new Spisok
                        {
                            Text = "  Нагетсы 6шт",
                            Tsena = 700
                        },
                        new Spisok
                        {
                            Text = "  Стрипсы 2 шт",
                            Tsena = 350
                        },
                        new Spisok
                        {
                            Text = "  Крылья куриные 4 шт",
                            Tsena = 500
                        },
                        new Spisok
                        {
                            Text = "  Креветки 6 шт",
                            Tsena = 900
                        },
                        new Spisok
                        {
                            Text = "  Морковные палочки",
                            Tsena = 450
                        }
                    }
                },
                new Spisok
                {
                    Name = "  Напитки",
                    Item_list = new List<Spisok>{
                        new Spisok
                        {
                            Text = "  Добрый кола",
                            Tsena = 600
                        },
                        new Spisok
                        {
                            Text = "  Добрый лайм мята",
                            Tsena = 600
                        },
                        new Spisok
                        {
                            Text = "  Добрый апельсин",
                            Tsena = 600
                        },
                        new Spisok
                        {
                            Text = "  Яблочный сок",
                            Tsena = 500
                        },

                    }
                },
                new Spisok
                {
                    Name = "  Соусы",
                    Item_list = new List<Spisok>{
                        new Spisok
                        {
                            Text = "  Сырный",
                            Tsena = 100
                        },
                        new Spisok
                        {
                            Text = "  Кетчуп",
                            Tsena = 100
                        },
                        new Spisok
                        {
                            Text = "  Барбек.",
                            Tsena = 100
                        },
                        new Spisok
                        {
                            Text = "  Трияки",
                            Tsena = 100
                        },
                        new Spisok
                        {
                            Text = "  Кисло-сладкий",
                            Tsena = 100
                        },
                        new Spisok
                        {
                            Text = "  Горчичный",
                            Tsena = 100
                        }
                    }
                },
                new Spisok
                {
                    Name = "  Десерты",
                    Item_list = new List<Spisok>{
                        new Spisok
                        {
                            Text = "  Вишнёвый пирожок",
                            Tsena = 500
                        },
                        new Spisok
                        {
                            Text = "  Макфлкри",
                            Tsena = 750
                        },
                        new Spisok
                        {
                            Text = "  Яблочное пюре",
                            Tsena = 500
                    }
                },
            }; 
            Spisok menu = new Spisok();
            menu.Drew_Menu(Spisok);
        }
    }
}
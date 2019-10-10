using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_scissiors_paper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("Привет! Добро пожаловать в игру Камень-Ножницы-Бумага");
            Console.WriteLine("Объясню правила: " +
                "\n1. Ты играешь против компьтера." +
                "\n2. Тебе нужно будет выбирать предмет каждый ход (камень/ножницы/бумага." +
                "\n3. Игра длится 3 раунда. По завершении всех раундов ты сможешь выбрать: Сыграть еще раз или выйти. ");
            while (true)
            {
                Console.WriteLine("\nНажми:" +
                    "\n1 - Что бы начать" +
                    "\n2 - Что бы выйти");
                try
                {
                    int start = int.Parse(Console.ReadLine());
                    if (start == 1)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (start == 2)
                    {
                        Environment.Exit(1);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Вы ввели не существующие действие.");
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Введите корректное действие");

                }
            }

            int score = 0;
            int computerScore = 0;
            Random rnd = new Random();
            while (true)
            {
                try
                {
                    for (int rounds = 0; rounds < 3; rounds++)
                    {

                        int item = rnd.Next(1, 4);
                        //1-камень. 2-ножницы. 3-бумага//
                        Console.WriteLine("Компьютер уже загадал свою фигуру, теперь загадай ты:");
                        Console.WriteLine("1 - Камень \n2 - Ножницы \n3 - Бумага\n");
                        int playerItem = int.Parse(Console.ReadLine());

                        if (playerItem == 1 & item == 2)
                        {
                            Console.Clear();

                            score++;
                            Console.WriteLine("Вы победили! \nКомпьютер: Ножницы\tВы: Камень");
                            Console.WriteLine("Камень бьет ножницы.\nКоличесво ваших очков:" + score + "\tКоличество очков компьютера: " + computerScore);

                        }
                        else if (playerItem == 1 & item == 3)
                        {
                            Console.Clear();

                            computerScore++;
                            Console.WriteLine("К сожалению, вы проиграли. \nКомпьютер: Бумага\tВы: Камень");
                            Console.WriteLine("Бумага кроет камень.\nКоличесво ваших очков: " + score + "\tКоличество очков компьютера: " + computerScore);

                        }
                        else if (playerItem == 1 & item == 1)
                        {
                            Console.Clear();

                            Console.WriteLine("Ничья. \nКомпьютер: Камень\tВы: Камень");
                            Console.WriteLine("Количество ваших очков: " + score + "Количество очков компьютера: " + computerScore);

                        }
                        else if (playerItem == 2 & item == 3)
                        {
                            Console.Clear();

                            score++;
                            Console.WriteLine("Вы победили! \nКомпьютер: Бумага\tВы: Ножницы");
                            Console.WriteLine("Ножницы режут бумагу!\nКоличесво ваших очков:" + score + "\tКоличество очков компьютера: " + computerScore);

                        }
                        else if (playerItem == 2 & item == 1)
                        {
                            Console.Clear();

                            computerScore++;
                            Console.WriteLine("К сожалению, вы проиграли. \nКомпьютер: Камень\tВы: Ножницы");
                            Console.WriteLine("Камень бьет ножницы!\nКоличесво ваших очков: " + score + "\tКоличество очков компьютера: " + computerScore);

                        }
                        else if (playerItem == 2 & item == 2)
                        {
                            Console.Clear();

                            Console.WriteLine("Ничья. \nКомпьютер: Ножницы\tВы: Ножницы");
                            Console.WriteLine("Количесво ваших очков: " + score + "\tКоличество очков компьютера: " + computerScore);

                        }
                        else if (playerItem == 3 & item == 1)
                        {
                            Console.Clear();

                            score++;
                            Console.WriteLine("Вы победили! \nКомпьютер: Камень\tВы: Бумага");
                            Console.WriteLine("Бумага кроет камень!\nКоличесво ваших очков:" + score + "\tКоличество очков компьютера: " + computerScore);

                        }
                        else if (playerItem == 3 & item == 2)
                        {
                            Console.Clear();

                            computerScore++;
                            Console.WriteLine("К сожалению, вы проиграли. \nКомпьютер: Ножницы\tВы: Бумага");
                            Console.WriteLine("Ножницы режут бумагу!\nКоличесво ваших очков: " + score + "\tКоличество очков компьютера: " + computerScore);
                        }
                        else if (playerItem == 3 & item == 3)
                        {
                            Console.Clear();

                            Console.WriteLine("Ничья. \nКомпьютер: Бумага\tВы: Бумага");
                            Console.WriteLine("Количесво ваших очков: " + score + "\tКоличество очков компьютера: " + computerScore);

                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Вы выбрали не существующую фигуру");

                        }

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите корректное действие");
                }
                break;
            }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Сыграть еще раз?\n1 - Да!\n2 - Нет!");
                        int game = int.Parse(Console.ReadLine());
                        if (game == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Поехали!");
                            break;
                        }
                        else if (game == 2)
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввелди не то число. Попробуйте еще раз");

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введите коректное действие");
                    }
                }
            }
        }
    }
}

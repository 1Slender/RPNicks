﻿using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace RPNicks
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public List<string> names { get; set; } = new List<string>() { "Андрей", "Борис", "Иван", "Илья", "Кирилл", "Алексей", "Воболей", "Александр", "Олег", "Максим", "Петр", "Ян", "Сергей", "Виктор", "Уильямм", "Райан", "Макc", "Никита", "Дмитрий", "Михаил", "Сэмми", "Генри", "Вячеслав", "Владимир", "Антон", "Джоуи", "Арсений", "Фёдор", "Николай", "Денис", "Жорж", "Джорно", "Егор", "Матвей", "Денис", "Джон", "Джейсон", "Всеслав", "Джэк", "Джэрри", "Чарли", "Вилли", "Георгий", "Григорий", "Оскар", "Джеймс", "Том" };
        public List<string> surnames { get; set; } = new List<string>() { "Мельник", "Афтон", "Гослинг", "Михайлов", "Андреев ", "Иванов", "Степанов", "Кузнецов", "Попов", "Васильев", "Соколов", "Брекоткин", "Пушкин", "Лермонтов", "Мендель", "Ли", "Чан", "Хун", "Смит", "Джонсон", "Джоунс", "Браун", "Дэвис", "Уилсон", "Лоуренс", "Дрю", "Штейн", "Йорк", "Питерс", "Мартин", "Джэксон", "Петров", "Пташкин", "Пальчак", "Петрашкевич", "Сучков", "Арсеньев", "Тэйлор", "Авдеев", "Аксёнов", "Егоров", "Семченко", "Горохов", "Борщ", "Бабин", "Голобородько", "Хватаймуха", "Ткаченко", "Дмитриев", "Бирюков", "Жуков", "Пущин", "Некурящев", "Адидас", "Мухин", "Блинской", "Шпакян", "Васюков", "Федотов", "Рыжов", "Чарский", "Маслов", "Лобанов", "Цой", "Хой", "Литвинов", "Джованна", "Погребной", "Голосов", };
    }
}

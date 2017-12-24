﻿using System;
using System.Collections.Generic;
using Analysis7.Model.Entities;

namespace Analysis7.Model
{
    [Serializable]
    public class ModelStarter
    {
        public List<Group> Groups=new List<Group>();

        public List<Event> Events=new List<Event>();

        public List<Activity> Activities = new List<Activity>();

        public ModelStarter()
        {

            var techSources = new List<Source>
            {
                new Source("S1",
                    "Функціональні характеристики ПЗ"),
                new Source("S2",
                    "Характеристики якості ПЗ"),
                new Source("S3",
                    "Характеристики надійності ПЗ"),
                new Source("S4",
                    "Застосовність ПЗ"),
                new Source("S5",
                    "Часова продуктивність ПЗ"),
                new Source("S6",
                    "Супроводжуваність ПЗ"),
                  new Source("S7",
                    "Повторне використання компонент ПЗ")
            };
            var techEvents = new List<Event>()
            {
                new Event("t1",
                    "Затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ"),
                new Event("t2",
                    "Затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ"),
                new Event("t3",
                    "Небажання команди виконавців використовувати інструментальні засоби для підтримки процесу розроблення ПЗ"),
                new Event("t4",
                    "Формування запитів на більш потужні інструментальні засоби розроблення ПЗ"),
                new Event("t5", "Відмова команди виконавців від CASE-засобів розроблення ПЗ"),
                new Event("t6", "Неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ"),
                new Event("t7",
                    "Неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ"),
                new Event("t8", "Недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ"),
                new Event("t9",
                    "Програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості"),
                new Event("t10", " швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів"),
                new Event("t11",
                    " поява дефектних системних компонент, які використовують для розроблення ПЗ")
            };

            Group techGroup = new Group(
                "t",
                "Множина настання технічних ризикових подій",
                techEvents, techSources
            );

            var costSources = new List<Source>
            {
                new Source("S1",
                    "Обмеження сумарного бюджету на програмний проект"),
                new Source("S2",
                    "Недоступна вартість реалізації програмного проекту"),
                new Source("S3",
                    "Низька ступінь реалізму при оцінюванні витрат на програмний проект")
            };
            var costEvents = new List<Event>
            {
                new Event("c1", "Недооцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)"),
                new Event("c2", "Переоцінювання витрат на реалізацію програмного проекту (надмірно висока вартість)"),
                new Event("c3", "Фінансові ускладнення у компанії-замовника"),
                new Event("c4", "Фінансові ускладнення у компанії-розробника ПЗ"),
                new Event("c5", "Зменшення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації"),
                new Event("c6", "Збільшення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації"),
                new Event("c7", "Висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ"),
                new Event("c8", "Реорганізація структурних підрозділів у компанії-замовника ПЗ"),
                new Event("c9", "Реорганізація команди виконавців у компанії-розробника ПЗ")
            };
            var costGroup =new Group("c", "Множина настання вартісних ризикових подій",costEvents, costSources);


            var planSources = new List<Source>
            {
                new Source("S1",
                    "Властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ"),
                new Source("S2",
                    "Можливості порушення встановлених термінів реалізації етапів життєвого циклу розроблення ПЗ"),
                new Source("S3",
                    "Низька ступінь реалізму при встановленні планів і етапів життєвого циклу розроблення ПЗ")
            };
            var planEvents = new List<Event>()
            {
                new Event("p1",
                    "Зміни графіка виконання робіт з боку замовника чи розробника ПЗ"),
                new Event("p2",
                    "Порушення графіка виконання робіт з боку компанії-розробника ПЗ"),
                new Event("p3",
                    "Потреба зміни користувацьких вимог до ПЗ з боку компанії-замовника ПЗ"),
                new Event("p4",
                    "Потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ"),
                new Event("p5", "Потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ"),
                new Event("p6", "Недооцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ"),
                new Event("p7",
                    "Переоцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ"),
                new Event("p8", "Остаточний розмір ПЗ значно перевищує заплановані його характеристики;"),
                new Event("p9",
                    "Остаточний розмір ПЗ значно менший від запланованих його характеристики;"),
                new Event("t10", "Поява на ринку аналогічного ПЗ до виходу замовленого"),
                new Event("t11",
                    "Поява на ринку більш конкурентоздатного ПЗ")
            };

            Group planGroup = new Group(
                "p",
                "Множина настання планових ризикових подій",
                planEvents, planSources
            );


            var managmentSources = new List<Source>
            {
                new Source("S1",
                    "Хибна стратегія реалізації програмного проекту"),
                new Source("S2",
                    "Неефективне планування проекту розроблення ПЗ"),
                new Source("S3",
                    "Неякісне оцінювання програмного проекту"),
                new Source("S4",
                    "Прогалини в документуванні етапів реалізації програмного проекту"),
                new Source("S5",
                    "Промахи в прогнозуванні результатів реалізації програмного проекту.")
            };
            var managmentEvents = new List<Event>()
            {
                new Event("m1",
                    "Низький моральний стан персоналу команди виконавців ПЗ"),
                new Event("m2",
                    "Низька взаємодія між членами команди виконавців ПЗ"),
                new Event("m3",
                    "Пасивність керівника (менеджера) програмного проекту"),
                new Event("m4",
                    "Недостатня компетентність керівника (менеджера) програмного проекту"),
                new Event("m5", "Незадоволеність замовника результатами етапів реалізації програмного проекту"),
                new Event("m6", "Недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем"),
                new Event("m7", "Хвороба провідного виконавця в найкритичніший момент розроблення ПЗ"),
                new Event("m8", "Одночасна хвороба декількох виконавців підчас розроблення ПЗ"),
                new Event("m9", "Неможливість організації необхідного навчання персоналу команди виконавців ПЗ"),
                new Event("m10", "Зміна пріоритетів у процесі управління програмним проектом"),
                new Event("m11",
                    "Недооцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ"),
                new Event("m12", "Переоцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ"),
                new Event("m13", "Недостатнє документування результатів на етапах реалізації програмного проекту;"),
                new Event("m14", "Надмірне документування результатів на етапах реалізації програмного проекту"),
                new Event("m15", "Нереалістичне прогнозування результатів на етапах реалізації програмного проекту"),
                new Event("m16", "Недостатній професійний рівень представників від компанії-замовника ПЗ"),
            };

            Group managmentGroup = new Group(
                "m",
                "Множина настання ризикових подій реалізації процесу управління програмним проектом",
                managmentEvents, managmentSources

            );


            var activities=new List<Activity>
            {
                new Activity("Попереднє навчання членів проектного колективу"),
                new Activity("Узгодження детального переліку вимог до ПЗ із замовником"),
                new Activity("Внесення узгодженого переліку вимог до ПЗ замовника в договір"),
                new Activity("Точне слідування вимогам замовника з узгодженого переліку вимог до ПЗ"),
                new Activity("Експертна оцінка програмного проекту досвідченим стороннім консультантом"),
                new Activity("Консультації досвідченого стороннього консультанта"),
                new Activity("Тренінг з вивчення необхідних інструментів розроблення ПЗ"),
                new Activity("Укладання договору страхування"),
                new Activity("Використання шаблонних рішень з вдалих попередніх проектів при управлінні програмним проектом"),
                new Activity("Підготовка документів, які показують важливість даного проекту для досягнення фінансових цілей компанії-розробника"),
                new Activity("Реорганізація роботи проектного колективу так, щоб обов'язки та робота членів колективу перекривали один одного"),
                new Activity("Придбання (замовлення) частини компонент розроблюваного ПЗ;"),
                new Activity("Заміна потенційно дефектних компонент розроблюваного ПЗ придбаними компонентами, які гарантують якість виконання роботи"),
                new Activity("Придбання більш продуктивної бази даних"),
                new Activity("Аикористання генератора програмного коду"),
                new Activity("Реорганізація роботи проектного колективу залежно від рівня труднощів виконання завдань та професійних рівнів розробників;"),
                new Activity("Повторне використання придатних компонент ПЗ, які були розроблені для інших програмних проектів"),
                new Activity("Аналіз доцільності розроблення даного ПЗ")
            };

            Events.AddRange(techEvents);
            Groups.Add(techGroup);
            Events.AddRange(costEvents);
            Groups.Add(costGroup);
            Events.AddRange(planEvents);
            Groups.Add(planGroup);
            Events.AddRange(managmentEvents);
            Groups.Add(managmentGroup);

            Activities.AddRange(activities);
        }
       
       
    }
};

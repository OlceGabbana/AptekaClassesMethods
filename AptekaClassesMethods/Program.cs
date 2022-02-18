using System;

namespace AptekaClassesMethods
{
    class Chemist
    {
        // Название аптеки
        public string name;
        // Названия лекарств
        public string name_med;
        // стоимость лекарств
        public int money;

        public void Initialization(string name, string name_med, int money)
        {
            Chemist chemist1 = new Chemist();
            chemist1.name = name;
            chemist1.name_med = name_med;
            chemist1.money = money;

        }
    }
    
}

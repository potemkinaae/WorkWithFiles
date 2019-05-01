using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFiles
{
    public enum EnumAcs : byte { None, Videocard, OperativeMemory, HDD, SSD, Motherboard, Case, Cooler, PowerSupply, OpticalDrive, Soundcard, Cable }
    [Serializable]
    public struct SAcs
    {
        public static EnumAcs Acs;
        static string[] AcsString = new string[12]
        { "Не определено","Видеокарта", "Оперативная память", "HDD", "SSD", "Материнская плата", "Корпус",
                  "Кулер", "Блок питания", "Дисковой привод", "Звуковая карта", "Кабель" };

        public SAcs(EnumAcs acs = EnumAcs.None) 
        {
            Acs = acs;
        }

        public bool TryStringToAcs(string Str)
        {
            Str = Str.ToLower();
            bool OK = false;
            for (int i = 1; i < AcsString.Length - 1 && !OK; i++)
            {
                if (Str == AcsString[i].ToLower())
                {
                    Acs = (EnumAcs)i;
                    OK = true;
                }
            }
            if (!OK)
            {
                Acs = EnumAcs.None;
            }
            return OK;
        }
        public override string ToString()
        {
            return AcsString[(int)Acs];
        }
    }
}

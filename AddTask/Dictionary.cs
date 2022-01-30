using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    internal class Dictionary
    {
        private string[] wordsRussian = new string[5];
        private string[] wordsEnglish = new string[5];
        private string[] wordsUkrainian = new string[5];

        public Dictionary()
        {
            wordsRussian[0] = "книга"; wordsEnglish[0] = "book"; wordsUkrainian[0] = "книга";
            wordsRussian[1] = "ручка"; wordsEnglish[1] = "pen"; wordsUkrainian[1] = "ручка";
            wordsRussian[2] = "солнце"; wordsEnglish[2] = "sun"; wordsUkrainian[2] = "сонце";
            wordsRussian[3] = "яблоко"; wordsEnglish[3] = "apple"; wordsUkrainian[3] = "яблуко";
            wordsRussian[4] = "стол"; wordsEnglish[4] = "table"; wordsUkrainian[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                if (wordsRussian.Contains(index))
                {
                    int indexOfElem = IndexOfElement(wordsRussian, index);
                    return $"Слово {wordsRussian[indexOfElem]} по-английски будет {wordsEnglish[indexOfElem]}, а по-украински {wordsUkrainian[indexOfElem]}";
                }
                else if (wordsEnglish.Contains(index))
                {
                    int indexOfElem = IndexOfElement(wordsEnglish, index);
                    return $"Слово {wordsEnglish[indexOfElem]} по-русски будет {wordsRussian[indexOfElem]}, а по-украински {wordsUkrainian[indexOfElem]}";
                }
                else if (wordsUkrainian.Contains(index))
                {
                    int indexOfElem = IndexOfElement(wordsUkrainian, index);
                    return $"Слово {wordsUkrainian[indexOfElem]} по-русски будет {wordsRussian[indexOfElem]}, а по-английски {wordsEnglish[indexOfElem]}";
                }

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < wordsRussian.Length)
                    return wordsRussian[index] + " - " + wordsEnglish[index] + " - " + wordsUkrainian[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

        int IndexOfElement(string[] array, string text)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == text)
                    return i;
            return -1;
        }
    }
}

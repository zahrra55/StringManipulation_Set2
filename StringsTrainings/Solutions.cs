using System;


namespace StringsTrainings
{
    class Solutions
    {
        //دالة تحسب عدد تكرار كلمة معينة
        //نوزع الكلمات بمصفوفة وباستخدام اللوب نفحص الكلمات الي تشبه الكلمة المراد معرفة تكرارها
        public static int WordApearingCounts(String word)
        {
            String sentence = "apple banana apple orange apple";
            String[] wordsAfterSplit;
            wordsAfterSplit = sentence.Split(' ');
            int count=0;
            foreach (String str in wordsAfterSplit)
            {
                if (str == word)
                    count++;
            }
            return count;
        }

        //دالة تحول كل حروف الكلمة الى حروف كبيرة
        public static String ConvertToUpperCase(String word)
        {
            return word.ToUpper();
        }

        //دالة تحول كل حروف الكلمة الى حروف صغيرة
        public static String ConvertToLowerCase(String word)
        {
            return word.ToLower();
        }

        //دالة لفحص اذا كانت الكلمة او الجملة تبدأ بحرف او كلمة معينة
        public static bool IsStartsWith(String word)
        {
            String sentance = "welcome";
            return sentance.StartsWith(word) ? true : false;
        }

        //دالة لفحص اذا كانت الكلمة او الجملة تنتهي بحرف او كلمة معينة
        public static bool IsEndsWith(String word)
        {
            String sentance = "file.txt";
            return sentance.EndsWith(word) ? true : false;
        }

        // تمرين 6 و 7

        //دالة لتحويل الحرف الاول من الكلمة الى حرف كبير
        public static String CapitalizeFirstLetter (String word)
        {
            char[] newWord;
            foreach(char i in word)
            {
                if (i == 0)
                    newWord[i] = word[i];

            }

        }
    }

}

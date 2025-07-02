using System;


namespace StringsTrainings
{
   public class Solutions
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

        //دالة للتحقق مما إذا كانت السلسلة تحتوي فقط على أرقام
        public static bool IsContainOnlyDigits(String word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                    count++;
            }
            if (count == word.Length)
                return true;
            else return false;
        }

        //دالة للتحقق مما إذا كانت السلسلة تحتوي فقط على حروف
        public static bool IsContainOnlyLetters(String word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                    count++;
            }
            if (count == word.Length)
                return true;
            else return false;
        }


        //دالة لتحويل الحرف الاول من الكلمة الى حرف كبير
        public static String CapitalizeFirstLetter (String word)
        {
            //لمنع حدوث خطأ
            if (word == " ")
            {
                return "You should type a word!";
            }
            else
            return word.ToUpper()[0] + word.Substring(1);

        }

        //دالة لتبديل حالة كل حرف, الكبير الى صغير وبالعكس
        public static void ChangeLetterCase (String word)
        {
            char[] word2 = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                //فحص اذا كان الحرف كبير يتم تحويله الى حرف صغير وبالعكس
                word2[i] = char.IsUpper(word[i]) ? char.ToLower(word[i]) : char.ToUpper(word[i]);
            }
            Console.WriteLine( word2 );
        }

        //دالة لتقسيم السترنك الى كلمات منفصلة
        public static void SplitString (String sentance)
        {

           String[] wordsAfterSplit = sentance.Split(' ');
            
            foreach (String str in wordsAfterSplit)
            {
                Console.WriteLine(str);
            }
        }  

        //دالة لتحويل الكلمات الى سلسلة واحدة
        public static void JoinString(String[] words)
        {
            Console.WriteLine(String.Join(" ", words));

        }

        //دالة لازالة الفراغات من بداية ونهاية الكلمة
        public static String RemoveWhiteSpaces (String word)
        {
            return word.Trim();
        }

        //دالة لمعرفة عدد الفراغات الموجودة بالجملة
        public static int NumberOfSpaces (String sentance)
        {
            int count = 0;
            for (int i = 0; i < sentance.Length; i++)
            {
                //فحص كل حرف اذا كان يساوي فراغ يتم زيادة العداد
                if (sentance[i] == ' ')
                    count++;
            }
            return count;
        }

        //دالة لطباعة اول خمسة حروف
        public static String GetFirst5Char(String word) => word.Length <= 5 ? word : word.Substring(0, 5);
        
        //دالة لطباعة اول خمسة حروف
        public static String GetLast3Char(String word) => word.Length <= 3 ? word : word.Substring(word.Length - 3);

        //دالة لاتستبدالفاصلة بالفاصلة المنقوطة
        public static String ReplaceCommasWithSemicolons(String word) => word.Replace(",", ";");

        public static bool AreAnagrams(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            char[] ConvertedWord1 = word1.ToLower().ToCharArray();
            char[] ConvertedWord2 = word2.ToLower().ToCharArray();

            Array.Sort(ConvertedWord1);
            Array.Sort(ConvertedWord2);

            for (int i = 0; i < ConvertedWord1.Length; i++)
                if (ConvertedWord1[i] != ConvertedWord2[i]) return false;

            return true;
        }


    }

}

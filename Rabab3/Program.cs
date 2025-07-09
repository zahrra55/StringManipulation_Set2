﻿using System;
using System.Globalization;
using System.Linq;
using System.Text;
public class Program
{
/*
Exercise 1   :
English: Create a function that counts how many times a word appears in a sentence.
*/
  static string CountsHowManyWord(string str, string w)
  {
      string[] words= str.Split(' ');
      int contr=0;
      foreach(string word in words)
      {
          if(w.ToLower()==word.ToLower()){
              contr++;
          }
      }
      if(contr>0){
          return contr.ToString();
      }
      else
      {
          return "not fonds";
      }
  }
/*
Exercise 2   :
English: Write a program to reverse a string.
*/
  static string ReverseString(string str)
  {
      string nstr=""; 
      for(int i=str.Length-1;i>=0;i--)
      {
          nstr += str[i];
      }
      return nstr;
  }
/*
Exercise 3   :
English: Replace all spaces in a string with dashes.
*/
  static string ReplaceSpaces(string str)
  {
      StringBuilder nstr= new StringBuilder(str);
      for(int i=0;i<str.Length;i++)
      {
          if(str[i]==' ')
          {
              nstr[i] ='-';
          }
      }
      return nstr.ToString();
  }
/*
Exercise 4   :
English: Find the number of vowels in a string.
*/
  static int NumberOfVowels(string str)
  { 
    char[] vowels={'A','E','I','O','U'};
     int contr=0;
     for(int i=0;i<str.Length;i++)
      {
          if(vowels.Contains(str[i])||vowels.Contains(char.ToUpper(str[i]) ))
          {
              contr++;
          }
      }
      return contr;
  }
/*
Exercise 5:
English: Check if a string ends with a given suffix.
*/
  static string CheckEndsString(string str)
    {
      if(str.EndsWith(".txt"))
          {
             return "true";
          }
      else
          {
               return "false";
          }
    }
/*
Exercise 6  :
English: Check if a string contains only digits.
استخدمت دالة "isdigit"لاختبر اذا كانت السلسة تحتوي على ارقام ثم حسبت عدد الارقام اذا كان عدد الارقام يساوي طول السترنك فان السترينك تحتوي على ارقام فقط
*/
    static string CheckDigits(string str)
    {
      int Contr=0;
      for(int i=0;i<str.Length;i++)
      {
          if(char.IsDigit(str[i]))
          {
              Contr++;
          }
      }
       if(Contr==str.Length)
          {
              return "true";
          }
          else{
              return "false";
          }
    }
/*
Exercise 7  :
English: Check if a string contains only letters.
*/
    static string CheckLetter(string str)
    {
      int Contr=0;
      for(int i=0;i<str.Length;i++)
      {
          if(char.IsLetter(str[i]))
          {
              Contr++;//حساب عدد الاحرف في الكلمة
          }
      }
       if(Contr==str.Length)// اذا عدد الاحرف يساوي طول السلسلة اذن السلسلة تحتوي فقط احرف 
          {
              return "true";
          }
          else{
              return "false";
          }
    }
/*
Exercise 8  :
English: Capitalize the first character of a string.
حولت السلسلة الى كلمات ثم حولت اول حرف من الكلمة الى حرف كبير
*/
static string CapitalizeFirstCharacter(string str)
{
    string[] words=str.Split(' ');
    string newwords="";
    foreach(string w in words)
    {
        newwords+= char.ToUpper(w[0])+ w.Substring(1);
        newwords+=" ";
    }  
    return newwords;
}
/*
Exercise 9  :
English: Swap the case of each character in a string.
*/
	static string SwapCase(string str)
	{
		string newwords="";
		for(int i=0; i<str.Length; i++)
		{
			if(char.IsUpper(str[i]))//اذا الحرف كبير يحوله الى صغير
			{
				newwords +=char.ToLower(str[i]);
			}
			else
			{
              newwords += char.ToUpper(str[i]);
			}
		}
		return newwords;
	}
/*
Exercise 10 :
English: Split a string into words.
*/
	static string SplitString(string str)
	{
	    	string[] words=str.Split(' ');
	    	string nstr="";
    		foreach(string w in words)
		{
		    nstr +=$"[{w}]";
    	}
    	return nstr;
}
/*
Exercise 11  :
English: Join a list of words into a string.
سويت مصفوفة من الكلمات ثم جمعتها في string
*/
static string WordsToString(string[] words)
{    
    	string nstr="";
    		foreach(string w in words)
		{
		    nstr +=w;
		    nstr+=" ";
    	}
    	return nstr;
}
/*
Exercise 12  :
English: Remove leading and trailing whitespace from a string.
*/
	static string RemoveLeading(string str)
{    
    	string nstr=str.Trim();
    	return nstr;
}
/*
Exercise 13  :
English: Count the number of spaces in a string.
*/
static int Count(string str)
{
int counter=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]==' ')
            {
               counter++;// Count the number of spaces
            }           
        }
    	return counter;
	}
/*
Exercise 14:
English: Check if a string is an email address format.
*/
static string CheckEmail(string str){
string email="gmail.com";
string valid="";
int atIndex = str.IndexOf('@'); 
if(!string.IsNullOrEmpty(str))  //safety checks ,if email null or empty.
{
    if(str.Substring(atIndex + 1)==email)
    {
       valid="true";
    }
    else{
        valid="false";
    } return valid;
}
else
{
    return "You didn't enter your Email.";
}
}
/*
Exercise 15  :
English: Get the first 5 characters of a string.
*/
static string FirstCharacters(string input)
{
   
    string newstr="";
if(input.Length>=5)
{
   
     newstr += input.Substring(0,5);
     return (newstr);
}
else 
  {
    return "string Less than 5";
  }
} 
/*
Exercise 16  :
English: Get the last 3 characters of a string.
*/
static string Last3Characters(string input)
{
    string newstr="";
if(input.Length>=3)
  {
     newstr += input.Substring(input.Length-3);
     return (newstr);
  }
else 
  {
    return "string Less than 3";
  }
}
/*
Exercise 17  :
English: Replace commas with semicolons in a string.
*/
  static string ReplaceCommas(string str)
  {
      StringBuilder nstr= new StringBuilder(str);
      for(int i=0;i<str.Length;i++)
      {
          if(str[i]==',')
          {
              nstr[i] =';';
          }
      }
      return nstr.ToString();
  }
  /*
  Exercise 18  :
English: Check if two strings are anagrams.
  */
    static string Anagrams(string str1,string str2)
    {
        int counter=0;
    if(str1.Length==str2.Length) //اذا طول الكلمتين غير متساوي يعني يوجد حرف غير موجود او مكرر اكثر من المطلوب
        {
            for(int i=0;i<str1.Length;i++)
            {
              if(str2.Contains(str1[i]))
            {
                counter++;  //يحسب كل حرف اذا موجود في الكلمة الثانية 
            }
            else
            {
                return "false";//اذا ماموجود الحرف
            }
            }
        if(counter==str1.Length) //اذا عدد الاحرف المتشابهة يساوي طول الكلمة اذن جميع الاحرف موجودة في الكلمتين
        {
           return "true";
        }
        else
        {
            return "false"; 
        }
        }
    else  
        {
            return "false";
        }
    }
/*
Exercise 19  :
English: Find all the digits in a string.
*/
    static string FindDigits(string str1)
    {
     string n="";
     bool containsDigit = str1.Any(char.IsDigit);//؟الكلمة تحتوي على ارقام
     if(containsDigit && !string.IsNullOrEmpty(str1)){  
           for(int i=0;i<str1.Length;i++)
            {
                if(char.IsDigit(str1[i]))
                {
                    n+= $"[{str1[i]}]";//يحفظ الارقام التي يجدها
                }
            }
            return n;
     }
     else{
         return "Not Digits"; //اذا لم يجد ارقام
     }
    }
/*
Exercise 20  :
English: Find all the letters in a string.
*/
    static string FindLetters(string str1)
    {
     string n="";
     bool containsDigit = str1.Any(char.IsLetter);//؟الكلمة تحتوي على احرف
     if(containsDigit && !string.IsNullOrEmpty(str1)){  
           for(int i=0;i<str1.Length;i++)
            {
                if(char.IsDigit(str1[i]))
                {
                    n+= $"[{str1[i]}]";//يحفظ الاحرف التي يجدها
                }
            }
            return n;
     }
     else{
         return "Not Digits"; //اذا لم يجد احرف
     }
    }
/*
Exercise 21  :
English: Mask an email address 
*/
  static string MaskEmail(string str){
   try{
       char[] chars=str.ToCharArray();
         int atIndex = str.IndexOf('@'); 
         if (atIndex == -1)
            throw new IndexOutOfRangeException();//اذا علامة @لاتوجد
         for(int i=1;i<atIndex;i++)
    {
          chars[i]='*';
    }
    str = new string(chars);
    return str;
   }
   catch(IndexOutOfRangeException){
       return "not index";
   }
}
/*
Exercise 22  :
English: Convert a sentence into a list of ASCII codes.
*/
    static string ConvertToASCII(string str){

      string ASCII="";
        for(int i=0;i<str.Length;i++)
         {
           ASCII += $"[{(int)str[i]}] ";
          
         } return ASCII;
}/*
Exercise 24  :
English: Extract the file extension from a filename.
*/
  static string Extension(string str){
      try{
      int atindex=str.IndexOf('.');
      if(atindex==-1){
          throw new IndexOutOfRangeException();
      }
      string extension="";
      extension=str.Substring(atindex +1);
      return extension;  
      }
      catch(IndexOutOfRangeException){
          return"not index";
      }
  }
  /*
Exercise 25  :
English: Replace newlines with spaces in a string.
  */
  static string ReplaceNewlines(string str){
      try{
      int atindex=str.IndexOf("\n");
      if(atindex==-1){
          throw new IndexOutOfRangeException();
      }
      string wordsend="";
      string words1="";
      string nstr="";
      extension=str.Substring(atindex +1);//يحفظ الكلمات القبل السطر
      extension2=str.Substring(0,atindex);//يحفظ الكلمات بعد السطر
      nstr=extenswords1ion2 + " " +wordsend;//يدمج الكلمات في جملة واحدة ويضع مسافة بينهن
      return nstr;  
      }
      catch(IndexOutOfRangeException){
          return"not index";
      }
  }
  /*
  Exercise 26  :
English: Convert a string date from 'YYYY-MM-DD' to 'DD/MM/YYYY'.
  */
static string ConvertDate(string date){
        DateTime newdate = DateTime.Parse(date);//convert string to date
        return newdate.ToString("dd/MM/yyyy"); 
    }
    /*
Exercise 27  :
English: Find how many times a specific character appears in a string.
    */
    static int CounterSpecificCharacter(string str , char c){
        int Counter=0;
        for(int i=0;i<str.Length;i++){
            if(str[i]==c||char.ToLower(str[i])==c){
                Counter++;
            }
        }return Counter;
    }
    /*
    Exercise 28  :
English: Check if a string contains any special characters.
    */
    static bool CheckSpecificCharacter(string str){
        char[] symbols={'!','@','#','$','%','^','&','*','_','-','+','='};
        bool iscontains=false;
            foreach(char c in symbols){
                if(str.Contains(c)){//يتحقق اذا يوجد رمز خاص
                iscontains= true;
            }
        }return iscontains;
}
/*
Exercise 29  :
English: Convert snake_case to camelCase.
*/
 static string ConvertSnake_case(string str)
  { 
	 string camelCase="";
      for(int i=0;i<str.Length;i++)
      {
          if(str[i]=='_')
          {
               continue;
          }camelCase+=str[i];
      }
      return camelCase;
  }
/*
Exercise 30  :
English: Convert camelCase to snake_case.
*/
 static string ConvertcamelCase(string str,int index)
  {
     StringBuilder snakecase= new StringBuilder(str);
      for(int i=0;i<str.Length;i++)
      {
          if(i==index)
          {
			  snakecase.Insert(index,'_');
          }
      }
      return snakecase.ToString();
  }
/*
Exercise 31  :
English: Replace all numeric values in a string with #.
*/
 static string ReplaceNumeric(string str)
  {
     StringBuilder nstr= new StringBuilder(str);
if(!string.IsNullOrEmpty(str)){ 
      for(int i=0;i<str.Length;i++)
      {
          if(char.IsDigit(str[i]))
          {
			  nstr[i] ='#' ;
          }
      }
      return nstr.ToString();
	 }
		else{
			return "Threr is no string";
		}
  }
  /*
  Exercise 32  :
  English: Count how many words are capitalized.
  */
   static int Countcapitalizedwords(string str)
  {
	 string[] words=str.Split(' ');
	 int count=0;
	 foreach(string w in words){
			  if(char.IsUpper(w[0])){
			 count++;
		  }
	 }
		 return count;
  } 
/*
Exercise 33  :
English: Remove all vowels from a string.
*/
static string RemoveOfVowels(string str)
  { 
    char[] vowels={'A','E','I','O','U'};
	string nstr="";
     for(int i=0;i<str.Length;i++)
      {
          if(vowels.Contains(str[i])||vowels.Contains(char.ToUpper(str[i]) ))
          {
              continue;
          }nstr+=str[i];
      }
      return nstr;
  }
/*
Exercise 34  :
English: Check if a string contains only whitespace.
*/
static string CheckOnlyWhitespace(string str)
  { 
	int count=0;
     for(int i=0;i<str.Length;i++)
      {
          if(str[i]==' ')
          {
            count++;//يحسب الفراغات
          }
      }
	if(count==str.Length){//اذا عدد الفراغات يساوي طول الكلمة اذن تحتوي فقط فراغات
		return "true";
	}
	else{
      return "false";
	}
  }
  /*Exercise 35  :
English: Replace emojis with [EMOJI] tag.
  */
  static string ReplaceEmojis(string str)
  { 
	string nstr="";
	int atindex=str.IndexOf("😊");
	nstr=str.Substring(0,atindex)+"[EMOJI]";
	return nstr;
  }

// static void Main(string[] args)
// {  
// string str1="lisien";
// string str2="sileni";
// Console.WriteLine (Anagrams(str1,str2));//Exercise 18
// Console.Write("Enter a string: ");
// string input = Console.ReadLine();
// Console.Write(FirstCharacters(input));//Exercise 15
// Console.Write(Last3Characters(input));//Exercise 16
// string[] words={"rabab","zahraa"};
// Console.Write(WordsToString(words));
//  Console.Write(ASCII("abc"));//Exercise 22
// Console.WriteLine(CountsHowManyWord("Hello World Hello","hello"));
// Console.WriteLine(ReverseString("Hello World Hello"));
// Console.WriteLine(ReplaceSpaces("Hello World Hello"));
// Console.WriteLine(NumberOfVowels("education"));
// Console.WriteLine(CheckDigits("12345"));
// Console.WriteLine(FindDigits("12rab345"));//Exercise 19
// Console.WriteLine(FindLetters("12rab345"));//Exercise 20
// Console.WriteLine(CapitalizeFirstCharacter("Hello World Hello"));
// Console.WriteLine(SwapCase("eduCation"));
// Console.WriteLine(SplitString("Hello World Hello"));
// Console.WriteLine(RemoveLeading(" eduCation "));
// Console.WriteLine(Count("Hello World Hello"));
// Console.Write(CheckEmail("rabab@gmail.com"));
// Console.Write(MaskEmail("rabab@gmail.com"));
// Console.WriteLine(ReplaceCommas("Hello,World,Hello"));//Exercise 17
// Console.WriteLine(Extension("rabab.word"));//Exercise 24
// Console.WriteLine(ReplaceNewlines("hello\nworld")); 
// Console.WriteLine(ConvertDate("2022-03-02"));// Exercise 26
//  Console.WriteLine(CounterSpecificCharacter("banana",'a')); 
//  Console.WriteLine(CheckSpecificCharacter("bana$na")); 
// Console.WriteLine(ConvertSnake_case("My_name"));
// Console.WriteLine(ConvertcamelCase("Myname",2));
// Console.WriteLine(ReplaceNumeric("My2name4"));
// Console.WriteLine(Countcapitalizedwords("Hello World"));
// Console.WriteLine(RemoveOfVowels("education"));
// Console.WriteLine(CheckOnlyWhitespace("  "));
// Console.WriteLine(ReplaceEmojis("Hello 😊"));
//     }
}
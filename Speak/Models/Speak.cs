namespace Speak
{
    public class LeetspeakTranslator
    {
        public string Input;

        public LeetspeakTranslator(string input)
        {
            Input = input;
        }
      public string Translate()
      {
       char[] array  = Input.ToCharArray();
       for (int i = 0; i < array.Length; i++)
       {
           switch(array[i])
           {
               case 'e':
                array[i] = '3';
                break;

                case 'o':
                array[i] = '0';
                break;

                case 'I':
                array[i] = '1';
                break;

                case 't':
                array[i] = '7';
                break;
                
                case 's':
                if(i == 0) 
                {
                    break;
                }
                if (!(array[i - 1] == ' '))
                {
                    array[i] = 'z';
                }
                break;
           }
       } 
       string result = string.Join("", array);
       return result;
      } 
    }
}
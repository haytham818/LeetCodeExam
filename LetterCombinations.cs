/*namespace LeetCodeExam;

public static class LetterCombinationsS1 {
    public static IList<string> LetterCombinations(string digits)
    {
        var list = new List<char>();
        foreach (var item in digits)
        {
            switch (item)
            {
                case '1':
                    break;
                case '2':
                    list.Add('a');
                    list.Add('b');
                    list.Add('c');
                    break;
                case '3':
                    list.Add('d');
                    list.Add('e');
                    list.Add('f');
                    break;
                case '4':
                    list.Add('g');
                    list.Add('h');
                    list.Add('i');
                    break;
                case '5':
                    list.Add('j');
                    list.Add('k');
                    list.Add('l');
                    break;
                case '6':
                    list.Add('m');
                    list.Add('n');
                    list.Add('o');
                    break;
                case '7':
                    list.Add('p');
                    list.Add('q');
                    list.Add('r');
                    list.Add('s');
                    break;
                case '8':
                    list.Add('t');
                    list.Add('u');
                    list.Add('v');
                    break;
                case '9':
                    list.Add('w');
                    list.Add('x');
                    list.Add('y');
                    list.Add('z');
                    break;
            }
        }
        var str = string.Join("", list.ToArray());
        var array = str.Split('.');
        array = array.Where(s => !string.IsNullOrEmpty(s)).ToArray();
        return 
    }
}*/
using System;

public class Solution
{
    public string solution(string code)
    {
        string answer = "";

        string mode = "0";
        for (int i = 0; i < code.Length; i++)
        {
            if (code[i] == '1' || code[i] == '0')
            {
                mode = mode == "1" ? "0" : "1";
                continue;
            }
            if (mode == "0" && i % 2 == 0)
                answer += code[i].ToString();
            else if (mode == "1" && i % 2 == 1)
                answer += code[i].ToString();
        }
        if (string.IsNullOrEmpty(answer))
            answer = "EMPTY";
        return answer;
    }
}
#include <bits/stdc++.h>

using namespace  std;

string reverseWords(string s)
{
    int l=0;
    for(int i=0; i<s.size();i++)
    {
        if(s[i] == ' ')
        {
            reverse(s.begin()+l, s.begin()+i);
            l=i+1;
        }
    }
    reverse(s.begin()+l, s.end());
    return s;
}

int main()
{
     string s = "Let's take LeetCode contest";
     cout << reverseWords(s);
}
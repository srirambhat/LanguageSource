int romanToInt(char * s)
{
    int length = sizeof(s);
    int i;
    int value;

    for (i=0; i < lenghth; i++)
    {
        switch (s[i])
        {
            case 'I':
                lastvalue =  s[i];
                value += 1;
                break;
            case 'V':
                lastvalue =  s[i];
                value += 5;
                if (lastvalue == 'I') 
                    value--;
                break;
            case 'X':
                lastvalue =  s[i];
                value += 10;
                if (lastvalue == 'I') 
                    value--;
                break;
            case 'L':
                lastvalue =  s[i];
                value += 5;
                if (lastvalue == 'X') 
                    value -= 10;
                break;
            case 'C':
                lastvalue =  s[i];
                value += 100;
                if (lastvalue == 'X') 
                    value -= 10;
                break;
            case 'D':
                lastvalue =  s[i];
                value += 500;
                if (lastvalue == 'C') 
                    value -= 100;
                break;
            case 'M':
                lastvalue =  s[i];
                value += 1000;
                if (lastvalue == 'C') 
                    value -= 100;
                break;
        }   
    }
    return value;
}

int main(int argc, char **argv)
{
    char input = "III";
    printf("Integer Value of %d is %d",input, romanToInt(input));
}
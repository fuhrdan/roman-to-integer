int romanToInt(char* s) {
    // This works, but it 'aint fancy'
    int len = strlen(s);
    int retNum = 0;
    int convert = 0;
    int convertMinus = 0;
    int less = 0;
    while(len >= 0)
    {
        if(less == 0)
        {
            convertMinus = s[len+1];
        }
        if(len+1 < strlen(s))
            convertMinus = s[len+1];
        else
            convertMinus = 0;
        convert = s[len];
        printf("current number %d = %c  AND number + 1 = %d\n",convert,s[len], convertMinus);
        if(convert == 73)
        {
            if((convertMinus==86)||(convertMinus==88))
            {
                retNum = retNum - 1;
                less = 1;
            }
            else
            {
                retNum = retNum + 1;
                less = 0;
            }
        }
        if(convert == 86)
        {
            if(convertMinus==67)
            {
                retNum = retNum - 5;
                less = 1;
            }
            else
            {
                retNum = retNum + 5;
                less = 0;
            }
        }
        if(convert == 67)
        {
            if((convertMinus==77)||(convertMinus == 68))
            {
                retNum = retNum - 100;
                less = 1;
            }
            else
            {
                retNum = retNum + 100;
                less = 0;
            }
        }
        if(convert == 68)
        {
            retNum = retNum + 500;
            less = 0;
        }
        if(convert == 76)
        {
//            if(convertMinus==88)
//            {
//                retNum = retNum - 50;
//            }
 //           else
 //           {
                retNum = retNum + 50;
                less = 0;
 //           }
        }
        if(convert == 88)
        {
            if((convertMinus == 67)||(convertMinus == 76))
            {
                retNum = retNum - 10;
                less = 1;
            }
            else
            {
                retNum = retNum + 10;
                less = 0;
            }
        }
        if(convert == 77)
        {
            retNum = retNum + 1000;
            less = 0;
        }
        len--;
        printf("Current Return = %d\n",retNum);
    }
    return retNum;
}
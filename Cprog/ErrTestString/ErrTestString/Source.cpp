#include<stdio.h>
#include<string.h>
int strlen2(const char* arr); //return the length of string;
char* strcpy2(char* destination, char* const source);
char* strcat2(char* destination, const char* source);
//strlen2 
int main()
{
    char a[] = { 'p','r','o','g','r','a','m',' ' ,' ' ,' ' ,' ' ,' ' ,' ' ,' ' ,' ' ,' ' ,' ' ,'\0' };
    char b[] = "programs";
    char c[] = "programmer";
    char d[] = "PROGRAMMERRR";
    printf("a=%d b=%d", strlen2(a), strlen2(b));
    char* j;
    j = strcpy2(a, c);
    printf("a is now =%s", j);
    char* g;
    g = strcat(a, c);
    printf("%s" , g);
  
}
int strlen2(const char* arr)//return the length of string
{
    int count = 0;
    while (arr[count] != '\0' && arr[count] != -52)
    {

        count++;
    }
    printf("\n\n");
    return count;
}
//strcpy2
char* strcpy2(char* destination, char* const source) {//copy string from source and paste it into destination
    int count = 0;
    while (source[count] != '\0' && source[count] != -52)
    {
        destination[count] = source[count];//assign
        count++;
    }

    destination[count] = '\0';
    printf("\n");
    return destination;
}
//strcat

char* strcat2(char* destination,const char* source)
{
    int len1 = strlen2(source);
    int len2 = strlen2(destination);    
    char result[1000]; //need to fix
    strcpy2(result, destination);
    for (int i = 0; i < len1; i++)
    {
        result[len2 + i] = source[i];
    }
    result[len1+len2]= '\0';
    return result;
   
}

//strcmp
/*int strcmp2(const char* str1, const char* str2)
{
    int count = 0;
    int str1_len = strlen2(str1);
    int str2_len = strlen2(str2);
    if (str1_len > str2_len)
    {
        return 1;
    }
    if (str1_len < str2_len)
    {
        return -1;
    }
    if (str1_len == str2_len)
    {
        while (str2[count] != '\0' && str2[count] != -52)
        {
            if (str1[count] == str2[count])
            {
                count++;
            }
            else
            {
                return str1[count] - str2[count];
            }
        }
    }
    return str1[count] - str2[count];
}*/
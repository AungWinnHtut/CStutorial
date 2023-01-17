#include<stdio.h>
void funa();
int i = 0;
int main()
{
    int result;

    result = _setmaxstdio(6400);
    if (result == 0)
    {
        printf("Unable to increase stack size.\n");
    }
    else
    {
        printf("Stack size increased.\n");
    }
	funa();
	return 0;
}
void funa()
{
	char ca[200000];

	printf("%d", i++);
	funa();

}
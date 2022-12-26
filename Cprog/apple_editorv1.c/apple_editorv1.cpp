#include<stdio.h>
#include "ghlib.h"
#include "ghlib.c"
int main()
{
	printf("\t\t\tApple ][\n\n");
	char buffer[100] = { "\0" };
	char t_arr[100] = { "\0" };
	char line[100] = { "\0" };
	char command[100] = { "\0" };
	while (1)
	{
		printf("] ");
		gets_k(buffer, 100);
		left_trim_k(t_arr, buffer, strlen_k(buffer));
		split_k(line, command, t_arr, strlen_k(t_arr));
		puts(line);
		puts(command);
		printf("%d\n", s2i_k(line,strlen_k(line)));
		clear_str_k(line, strlen_k(line));
		clear_str_k(command, strlen_k(command));

	}
	return 0;
}
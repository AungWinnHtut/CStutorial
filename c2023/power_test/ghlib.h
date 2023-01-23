#pragma once
int strlen_k(const char *str);
void strcpy_k(char *destination, const char *source);
int strcmp_k(const char *str1, const char *str2);
void strcat_k(char *destination, const char *source);
char *gets_k(char *str, int buffer_size);
void left_trim_k(char *t_arr, const char *str, int count);
void split_k(char *line, char *command, const char *str, const char ch, int count);
int c2i_k(char c);
int s2i_k(const char *line, int count);
int pow_k(int base, int exp);
void clear_str_k(char *str, int count);
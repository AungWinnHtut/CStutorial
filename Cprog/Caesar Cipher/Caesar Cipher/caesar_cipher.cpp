#include<stdio.h>
int funCaesarCipher()
{
	char plain_text[5]={'a','b','c','d','e'};
	char cipher_text[5];
	char decipher_text[5];
	printf("Plain Text...\n");
	for (int i = 0; i < 5; i++) {
		printf("%d \t %c \t %d\n", i,plain_text[i], plain_text[i]);
	}	

	for (int i = 0; i < 5; i++) {
		cipher_text[i] = plain_text[i] + 3;
	}

	printf("Cipher Text...\n");
	for (int i = 0; i < 5; i++) {
		printf("%d \t %c \t %d\n", i, cipher_text[i], cipher_text[i]);
	}

	for (int i = 0; i < 5; i++) {
		decipher_text[i] = cipher_text[i] - 3;
	}
	printf("DECipher Text...\n");
	for (int i = 0; i < 5; i++) {
		printf("%d \t %c \t %d\n", i, decipher_text[i], decipher_text[i]);
	}

	return 0;
}
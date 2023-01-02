#include <stdio.h>

void displayBits(unsigned int value); // prototype

int main(void) {
	 unsigned int x = 0; // variable to hold user input
	
	printf("%s", "Enter a nonnegative int: ");
	 scanf_s("%u", &x);	 
	 displayBits(x);
	
}

 // display bits of an unsigned int value
 void displayBits(unsigned int value) {
	 // define displayMask and left shift 31 bits
		 unsigned int displayMask = 1 << 31;
		 printf("mask = %10u  \n", displayMask);
		 printf("%10u = ", value);

		 // loop through bits 
		 for (unsigned int c = 1; c <= 32; ++c) {
		 putchar(value & displayMask ? '1' : '0');
		 value <<= 1; // shift value left by 1 
		
		 if (c % 8 == 0) { // output space after 8 bits
			 putchar(' ');
			
		}
		
	}
	
	putchar('\n');
	
}
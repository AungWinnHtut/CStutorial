#include <stdio.h>
#include <stdlib.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define READ 10
#define WRITE 11
#define LOAD 20
#define STORE 21
#define ADD 30
#define SUBTRACT 31
#define DIVIDE 32
#define MULTIPLY 33
#define BRANCH 40
#define BRANCHNEG 41
#define BRANCHZERO 42
#define HALT 43

int main(const int argc, const char *argv[]) // char **argv; char argv[][]
{
    int memory[100] = {0};
    int accumulator = 0;
    int instruction_counter = 0; // boot address - 0000
    int instruction_register = 0;
    int operation_code = 0;
    int operand = 0;

    system("cls");
    printf("%d\n", argc);
    for (int i = 0; i < argc; i++)
    {
        printf("Command Line argument %d is %s\n\n", i + 1, argv[i]);
    }
    // argv[0] exe filename
    // argbv[1] machine code or assembly file name
    // argv[2] -m - machine code file /a -assembly file
    // argv[3] -d - debug mode
    // simpletronv3.exe filename [/mode]

    /*

    FILE* fp;
    fopen_s(&fp,"d:\\test.txt", "w");
    if (fp != NULL)
    {
        fprintf_s(fp, "%d\n", 1050);
        fprintf_s(fp, "%d\n", 2050);
        fprintf_s(fp, "%d\n", 1051);
        fprintf_s(fp, "%d\n", 3051);
        fprintf_s(fp, "%d\n", 2152);
        fprintf_s(fp, "%d\n", 1152);
        fprintf_s(fp, "%d\n", 4300);
        fclose(fp);
    }
    */

    int index = 0;
    FILE *fin;
    fopen_s(&fin, argv[1], "r");
    printf("EOF = %d\n\n", EOF);
    if (fin != NULL)
    {
        while (fscanf(fin, "%d", &memory[index++]) > 0)
        {
        }

        fclose(fin);
    }
    else
    {
        printf("no such file exists!\n\n");
        return (1);
    }

    // LOAD PROGRAM INTO MEMORY
    // memory[0] = 1050;
    // memory[1] = 2050;
    // memory[2] = 1051;
    // memory[3] = 3051;
    // memory[4] = 2152;
    // memory[5] = 1152;
    // memory[6] = 4300;

    while (1)
    {

        instruction_register = memory[instruction_counter++];
        operation_code = instruction_register / 100;
        operand = instruction_register % 100;

        if (argv[3] != NULL && (!strncmp(argv[3], "-d", 2)))
        {
            printf("\n\tDebug Mode Stepping -> press any key to continue...\n");
            printf("\tInstructions in Memory\t\tData in Memory\n");
            printf("\tadd\t|\tinst\t\tadd\t|\tdata\n");
            for (int i = 0; i < 15; i++)
            {
                printf("\t%d\t|\t%d\t\t%d\t|\t%d\n", i, memory[i], i + 50, memory[i + 50]);
            }
            printf("\n\tSpecial Registers\n");
            printf("\t*******************\n");
            printf("\tAccumulator         : %d \n", accumulator);
            printf("\tInstruction Counter : %d \n", instruction_counter);
            printf("\tInstruction Register: %d \n", instruction_register);
            printf("\tOperation Code      : %d \n", operation_code);
            printf("\tOperand             : %d \n", operand);
            if (operation_code != READ)
            {
                printf("\npress any key to continue...\n");
                getch();
            }
        }

        switch (operation_code)
        {
        case 10:
            printf("\nPlease Enter Data: ");
            scanf("%d", &memory[operand]);
            break;
        case 11:
            printf("%d\n", memory[operand]);
            break;
        case 20:
            accumulator = memory[operand];
            break;
        case 21:
            memory[operand] = accumulator;
            break;
        case 30:
            accumulator += memory[operand];
            break;
        case 31:
            accumulator -= memory[operand];
            break;
        case 32:
            accumulator /= memory[operand];
            break;
        case 33:
            accumulator *= memory[operand];
            break;
        case 40:
            instruction_counter = operand;
            break;
        case 41:
            if (accumulator < 0)
            {
                instruction_counter = operand;
            }
            break;
        case 42:
            if (accumulator == 0)
            {
                instruction_counter = operand;
            }
            break;
        case 43:
            printf("\nProgram is terminated!\n");
            exit(0);
            break;
        default:
            printf("Err! No such instruction!!!! . Program is terminated!\n");
            exit(0);
            break;
        }
    }

    return 0;
}
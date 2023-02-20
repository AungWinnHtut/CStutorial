//
// Created by bluephoenix on 2/11/2023.
//
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
struct STUDENT {
    char name[20];
    int age;
    int student_id;
};

int propagateDummyData(FILE* fptr, struct STUDENT student_data,const char* name, int age, int count);
int read4Print(FILE* fptr, struct STUDENT student_data);
int bin2TextFile(FILE* fi, const char* oFname, struct STUDENT student_data);
int printRecord(FILE* fptr, struct STUDENT student_data, int index);
int insertData(FILE* fptr, struct STUDENT student_data, int index, const char* name, int age, int overwrite);
int main() {
    int record = 0;
    struct STUDENT student_data = { "",0,0 };
    FILE* fptr = NULL;
    char fname[] = "d:\\data.dat";
    fopen_s(&fptr, fname, "wb+");
    if (fptr == NULL)
    {
        return 1;
    }

    propagateDummyData(fptr, student_data,"",0, 15);
    insertData(fptr, student_data, 2, "first", 45, 1);
    insertData(fptr, student_data,22, " last", 45,1);   
    insertData(fptr, student_data, 2, "overwrite", -1111,1);
    //read4Print(fptr,student_data);
    //printRecord(fptr, student_data, 2);
    bin2TextFile(fptr, "d:\\out.txt", student_data);
    //system("code d:\\out.txt");
    fclose(fptr);
    return 0;
}



int propagateDummyData(FILE* fptr, struct STUDENT student_data,const char * name, int age, int count)
{
    if (fptr == NULL)
    {
        printf("propagate error! no such file \n");
        return 1;
    }
    //writing 100 empty records into file
    rewind(fptr);
    for (int record = 1; record <= count; record++)
    {
        student_data.student_id = record;
        strcpy_s(student_data.name, name);
        student_data.age = age;
        fseek(fptr, (record - 1) * sizeof(struct STUDENT), SEEK_SET);
        fwrite(&student_data, sizeof(struct STUDENT), 1, fptr);
    }
    return 0;
}

int insertData(FILE* fptr, struct STUDENT student_data,int index, const char* name, int age,int overwrite)
{
    if (fptr == NULL)
    {
        printf("propagate error! no such file \n");
        return 1;
    }
    //writing 100 empty records into file

  
        student_data.student_id = index;
        strcpy_s(student_data.name, "");
        student_data.age = 0;
        if (fseek(fptr, (index - 1) * sizeof(struct STUDENT), SEEK_SET) == 0)
        {
            fread(&student_data, sizeof(struct STUDENT), 1, fptr);

            if (student_data.student_id != 0)
            {
               //old data!
                if (overwrite == 1)
                {
                    student_data.student_id = index;
                    strcpy_s(student_data.name, name);
                    student_data.age = age;
                    if (fseek(fptr, (index - 1) * sizeof(struct STUDENT), SEEK_SET) == 0)
                    fwrite(&student_data, sizeof(struct STUDENT), 1, fptr);
                }
                else
                {
                    printf("Error! old data exists! at index=%d\n\n",index);
                    return 1;
                }
            }
            else
            {
                student_data.student_id = index;
                strcpy_s(student_data.name, name);
                student_data.age = age;
                if (fseek(fptr, (index - 1) * sizeof(struct STUDENT), SEEK_SET) == 0)
                fwrite(&student_data, sizeof(struct STUDENT), 1, fptr);
            }
           
       }
        else {
            printf("Cannot insert that index\n");
            return 1;
        }       
  
    return 0;
}


int read4Print(FILE* fptr, struct STUDENT student_data)
{
    if (fptr == NULL)
    {
        printf("read error! no such file \n");
        return 1;
    }
    int record = 1;
    rewind(fptr);
    while (!feof(fptr))
    {
        student_data.student_id = 0;
        strcpy_s(student_data.name, "");
        student_data.age = 0;
        fseek(fptr, (record - 1) * sizeof(struct STUDENT), SEEK_SET);
        fread(&student_data, sizeof(struct STUDENT), 1, fptr);
        if (student_data.student_id != 0)
        {
            printf("id=%-6dname=%-10sage=%6d \n", student_data.student_id, student_data.name, student_data.age);
        }

        record++;
    }
    return 0;
}

int printRecord(FILE* fptr, struct STUDENT student_data,int index)
{
    if (fptr == NULL)
    {
        printf("read error! no such file \n");
        return 1;
    }
   
        student_data.student_id = 0;
        strcpy_s(student_data.name, "");
        student_data.age = 0;
        if (fseek(fptr, (index - 1) * sizeof(struct STUDENT), SEEK_SET) == 0)
        {
            fread(&student_data, sizeof(struct STUDENT), 1, fptr);
            if (student_data.student_id != 0)
            {
                printf("id=%-6dname=%-10sage=%6d \n", student_data.student_id, student_data.name, student_data.age);
            }
            else
            {
                printf("Such index=%d does not exists!\n",index);
                return 1;
            }
       }
        else
        {
            printf("Such index does not exists!\n");
            return 1;
        }
        
      

    
    return 0;
}

int bin2TextFile(FILE* fi, const char* oFname, struct STUDENT student_data)
{
    FILE* fo = NULL;
    fopen_s(&fo, oFname, "w+");    //text file output
    if (fi == NULL)
    {
        printf("read error! no such input file \n");
        return 1;
    }
    if (fo == NULL)
    {
        printf("read error! no such output file \n");
        return 1;
    }

    int record = 1;
    rewind(fi);
    while (!feof(fi))
    {
        student_data.student_id = 0;
        strcpy_s(student_data.name, "");
        student_data.age = 0;
        fseek(fi, (record - 1) * sizeof(struct STUDENT), SEEK_SET);
        fread(&student_data, sizeof(struct STUDENT), 1, fi);
        if (student_data.student_id != 0)
        {
            if (record != 1)
            {
                fprintf(fo, "\n");
            }
            printf("id=%-6dname=%-15sage=%6d \n", student_data.student_id, student_data.name, student_data.age);
            fprintf(fo, "id=%-6dname=%-15sage=%6d", student_data.student_id, student_data.name, student_data.age);
        }

        record++;
    }

    fclose(fo);
    return 0;
}

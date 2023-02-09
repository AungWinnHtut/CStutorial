#include<stdio.h>
struct studentData {
	int ID;
	char name[20];
	int age;
};

int main()
{
	struct studentData agag = { 1,"aung",65 };
	struct studentData koko = { 2,"koko",66 };
	FILE* fout = NULL;
	fopen_s(&fout, "d:\\studentdata.dat", "wb+");
	if (fout == NULL) {
		return 1;
	}
	
	fseek(fout, (0) * sizeof(struct studentData), SEEK_SET);
	fwrite(&agag, sizeof(struct studentData), 1, fout);
	fseek(fout, (1) * sizeof(struct studentData), SEEK_SET);
	fwrite(&agag, sizeof(struct studentData), 1, fout);
	fseek(fout, (2) * sizeof(struct studentData), SEEK_SET);
	fwrite(&agag, sizeof(struct studentData), 1, fout);
	fseek(fout, 0, SEEK_CUR);
	fwrite(&koko, sizeof(struct studentData), 1, fout);
	fseek(fout,0, SEEK_CUR);
	fwrite(&koko, sizeof(struct studentData), 1, fout);
	fseek(fout, 0, SEEK_CUR);
	fwrite(&koko, sizeof(struct studentData), 1, fout);
	fclose(fout);


	return 0;
}
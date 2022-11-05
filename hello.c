
/*
Array and Graph Testing ..1
*/
#include <stdio.h>
void graph(float *h,int titleSize,float maximumPercent);
void star();
float large(float l,float  *A,int size);
int main(){
    float graphArray[100];
    float array[100];//array declaration 
    //user must input array_size to be used
    int array_size;
    printf ("Enter your Titles (maximum 10) =  ");
    //accessig array_size
    scanf("%d\n",&array_size);
    star();
    //assigning array values
    int e=1;
    for(int a=0; a<array_size; a++){
        printf("Title %d = ",e++);
        //accessing array' values
        scanf("%f",& array[a]);
    }
    star();
    //total vaue
    float x=0;
    for(int a=0;a<array_size;a++){
        x+=array[a];
    }
    //calculating %
    int ee=1;
    for(int a=0;a<array_size;a++){
        graphArray[a]=(array[a]*100)/x;
        printf("Percent of Title (%d) value = %f\n",ee++,graphArray[a]);
    }
    star();
//largest value will become high of graph 
float eee=0;
// large(eee, graphArray, array_size); 
graph(graphArray,array_size, large(eee, graphArray, array_size) );
star();   
return 0;
}//main

void graph(float *h,int titleSize,float maximumPercent){ 
    float  column=(50*maximumPercent)/100;
    int row=(5*titleSize)+5;
    for(float a=column;a>=1;a--)
    { 
        printf("\n");
        for(int x=1;x<=row;x++){
            if ( (a<=h[0]*0.5 && (x==5 || x==6)) || 
                    (a<=h[1]*0.5 && (x==10 || x==11)) ||
                    (a<=h[2]*0.5 && (x==15 || x==16)) || 
                    (a<=h[3]*0.5 && (x==20 || x==21)) || 
                    (a<=h[4]*0.5 && (x==25 || x==26)) || 
                    (a<=h[5]*0.5 && (x==30 || x==31)) || 
                    (a<=h[6]*0.5 && (x==35 || x==36)) || 
                    (a<=h[7]*0.5 && (x==40 || x==41)) ||
                    (a<=h[8]*0.5 && (x==45 || x==46)) || 
                    (a<=h[9]*0.5 && (x==50 || x==51)) 
            )
            {  
                printf("M");
            }
            else{
                printf("-");
            } 
        }//for2
    }//for1
}

void star(){
    printf("\n::::::::::::::::::::::::::::::::::::::::::::::::::::\n\n");
}

//largest function
float large(float l,float  *A,int size){
    for(int a=1; a<size; ++a){
        if( l < A[a] ){ 
            l = A[a]; 
        } 
    } 
    printf("\nThe largest percent of all values is %f\n", l);
    star();
    return l;
}
#include <iostream>
using namespace std;
class LEN{
private:
    int feet;
    int inches;
    int total_inches;
public:
    LEN(int ft,int in);
    LEN()
    {
        feet=0;
        inches=0;
        total_inches=0;
    }
    LEN operator + (LEN RL)
    {
        LEN temp;
        temp.feet = feet+RL.feet;
        temp.inches = inches + RL.inches;
        temp.total_inches = total_inches + RL.total_inches;
        return temp;
    }
    int getFeet()
    {
        return feet;
    }
    int getInches()
    {
        return inches;
    }
    int getTotal_Inches()
    {
        return total_inches;
    }

};

LEN::LEN(int ft,int ins)
{
    feet = ft;
    inches = ins;
    total_inches= (feet * 12) + ins;
}



int main() {
    LEN length(2,3);
    LEN width(4,1);
    LEN height(1,5);

    LEN total_length(0,0);
    total_length= length + width + height;
    cout<<length.getFeet()<<"-"<<length.getInches()<<"-"<<length.getTotal_Inches()<<endl;
    cout<<width.getFeet()<<"-"<<width.getInches()<<"-"<<width.getTotal_Inches()<<endl;
    cout<<height.getFeet()<<"-"<<height.getInches()<<"-"<<height.getTotal_Inches()<<endl;
    cout<<total_length.getFeet()<<"-"<<total_length.getInches()<<"-"<<total_length.getTotal_Inches()<<endl;

    //length - feet, inches
    //v = l * w * h
    //box - volume
    return 0;
}

#include <iostream>
using namespace std;
uint32_t changeEndianness(const uint32_t& value);
int main() {
    cout << "Hello, World!" << endl;
    uint32_t little_endian = 0x0A0B0C0D;
    uint32_t big_endian = 0x00000000; //=0;
    big_endian = changeEndianness(little_endian);

    printf("Little Endian = %x => Big Endian = %x",little_endian,big_endian);

    return 0;
}

uint32_t changeEndianness(const uint32_t& value)
{
    uint32_t ans = 0x00000000;
    uint32_t temp = 0x00000000;
    temp = value & 0x000000FF; //0x0000000D
    temp = temp <<24; //0x0D000000
    ans = ans | temp; //0x0D000000

    temp = 0x00000000;
    temp = value & 0x0000FF00; //0x00000C00
    temp = temp <<8; //0x000C0000
    ans = ans | temp; //0x0D0C0000

    temp = 0x00000000;
    temp = value & 0x00FF0000; //0x000B0000
    temp = temp>>8; //0x00000B00
    ans = ans | temp; //0x0D0C0B00

    temp = 0x00000000;
    temp = value & 0xFF000000; //0x0A000000 Masking
    temp = temp>>24; //0x0000000A
    ans = ans | temp; //0x0D0C0B0A
    return ans;
}

// Yêu cầu:
// 1. nhập tên
// 2. nhập tuổi
// 3. in ra màn hình dữ liệu vừa nhập

#include <iostream>
#include <string>
using namespace std;

int main(){
    // nhập tên
    cout << "Nhap ten: ";
    string ten;
    getline(cin, ten, '\n');

    // nhập tuổi
    cout << "Nhap tuoi: ";
    int tuoi;
    cin >> tuoi;

    cout << "\nKet qua:\n";
    cout << "Ten: " << ten << "\n";
    cout << "Ten: " << tuoi << "\n\n";

    return 0;
}
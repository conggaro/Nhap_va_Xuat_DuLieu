// Yêu cầu:
// 1. nhập tên
// 2. nhập tuổi
// 3. in ra màn hình dữ liệu vừa nhập

package code_Java;

import java.util.Scanner;

class Program{
    public static void main(String[] agrs){
        // tạo đối tượng đọc dữ liệu
        Scanner dt = new Scanner(System.in);

        // nhập tên
        System.out.print("Nhap ten: ");
        String ten = dt.nextLine();

        // nhập tuổi
        System.out.print("Nhap tuoi: ");
        int tuoi = dt.nextInt();

        System.out.println("\nKet qua:");
        System.out.println("Ten: " + ten);
        System.out.println("Tuoi:" + tuoi);
    }
}
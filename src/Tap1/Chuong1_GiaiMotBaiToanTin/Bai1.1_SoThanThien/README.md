# 1.1. Số thân thiện

*Tìm tất cả các số tự nhiên hai chữ số mà khi đảo trật tự của hai chữ số đó sẽ thu được một số nguyên tố cùng nhau với số đã cho.*

## Hiểu đầu bài

Ta kí hiệu (a, b) là ước chung lớn nhất (ucln) của hai số tự nhiên a và b. Hai số tự nhiên a và b được gọi là nguyên tố cùng nhau khi và chỉ khi (a, b) = 1.

Ví dụ:

``` c#
(23, 32) = 1 // Vậy 23 và 32 là một số cần tìm

(12, 21) = 3 // 12 và 21 không phải là một số cần tìm
```

**Đặc tả:**
(1) x = ab
(2) a, b = 0..9 (a và b biến thiên trong khoảng 0..9)
(3) a > 0 vì x là số có hai chữ số
(4) (ab, ba) = 1
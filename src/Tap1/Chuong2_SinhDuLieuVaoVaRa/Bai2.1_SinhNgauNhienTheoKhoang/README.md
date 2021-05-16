# Sinh ngẫu nhiên theo khoảng

*Sinh ngẫu nhiên cho mảng nguyên a có n phần tử trong nửa đoạn [-M..M) và M > 0*

## Đặc tả

Ta viết thủ tục tổng quát `Gen(n, c, d)` để sinh ngẫu nhiên n số nguyên 
trong nửa đoạn từ `d` đến `c (d < c)`.

Để ý rằng `random(c - d + 1)` (**ở bài 1.4**) biến thiên trong khoảng từ `0`
đến `c - d`, do đó, `d + random(c - d + 1)` sẽ biến thiên trong nửa đoạn từ `d`
đến `d + c - d = c`.

## Kết quả ví dụ

```
Số nguyên ngẫu nhiên trong nửa đoạn -8..8:
6 4 3 2 -8 5 6 8 4 2 -4 3 8 2 7 2 -6 3 6 2
Số nguyên ngẫu nhiên trong nửa đoạn -8..8:
0 -4 7 1 -6 7 -7 -2 3 7 2 -7 3 -5 -3 7 5 3 -3 0
Số nguyên ngẫu nhiên trong nửa đoạn -8..8:
-3 -5 -3 7 2 -1 -5 4 8 1 1 -8 -1 7 -2 1 6 4 -4 0
Số nguyên ngẫu nhiên trong nửa đoạn -8..8:
1 -6 0 -2 -2 1 2 -3 -2 -5 -7 -6 4 5 -4 -6 -3 7 0 -2
Số nguyên ngẫu nhiên trong nửa đoạn -8..8:
7 2 8 -6 5 5 3 -2 -5 -4 0 8 -7 6 0 6 3 -2 -5 -1
```

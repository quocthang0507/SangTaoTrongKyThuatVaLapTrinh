# Sinh ngẫu nhiên tăng

*Sinh ngẫu nhiên n phần tử được sắp không giảm cho mảng số nguyên a*

## Đặc tả

(1) Sinh ngẫu nhiên phần tử đầu tiên: `a[1] := random(n);`

(2) Từ phần tử thứ hai trở đi, trị được sinh ra bằng trị của phần tử trước nó
cộng với thêm một đại lượng ngẫu nhiên:
```pascal
a[i] := a[i - 1] + random(n)
```

## Kết quả ví dụ

```
20 số nguyên ngẫu nhiên tăng:
2 4 8 11 20 24 29 31 37 43 44 46 55 63 70 71 71 74 81 90
20 số nguyên ngẫu nhiên tăng:
0 4 6 9 10 17 19 20 21 29 35 44 48 55 62 68 72 72 78 80
20 số nguyên ngẫu nhiên tăng:
4 11 12 14 16 21 28 35 41 44 45 50 55 63 66 66 70 77 82 84
20 số nguyên ngẫu nhiên tăng:
1 10 10 17 19 23 25 32 41 42 50 55 60 64 68 76 80 84 88 93
20 số nguyên ngẫu nhiên tăng:
4 9 12 21 30 35 35 38 41 49 57 62 68 77 80 89 92 97 101 110
```

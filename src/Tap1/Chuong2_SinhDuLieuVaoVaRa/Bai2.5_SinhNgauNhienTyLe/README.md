# Sinh ngẫu nhiên tỷ lệ

*Sinh ngẫu nhiên cho mảng nguyên a có n phần tử tạo thành
hai đoạn liên tiếp có tổng các phần tử trong một đoạn gấp
k lần tổng các phần tử của đoạn kia.*

## Đặc tả

1. Sinh ngẫu nhiên tổng `t1 := random(n) + 1`
2. Tính `t2 := k * t1`
3. Gieo đồng xu bằng cách gọi `random(2)` để xác định tổng nào trong số t1 và t2 được chọn trước.
4. Sinh `random(n div 2) + 1` phần tử cho đoạn thứ nhất sao cho
tổng các phần tử của đoạn này bằng `t1`.
5. Sinh nốt các phần tử cho đoạn thứ hai sao cho tổng các bằng tử của đoạn này bằng `t2`.

## Ví dụ kết quả

```
==================================================
n = 18, k = 2

6 1 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1

Doan thu nhat: sum(a[0..0]) = 6

Doan thu hai: sum(a[1..17]) = 3

DUNG

Bam RETURN de tiep tuc:
==================================================
n = 16, k = 2

2 8 3 1 0 0 0 0 0 0 0 0 0 0 0 1

Doan thu nhat: sum(a[0..1]) = 10

Doan thu hai: sum(a[2..15]) = 5

DUNG

Bam RETURN de tiep tuc:
==================================================
n = 24, k = 1

1 3 2 1 0 0 4 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1

Doan thu nhat: sum(a[0..2]) = 6

Doan thu hai: sum(a[3..23]) = 6

DUNG

Bam RETURN de tiep tuc:
```
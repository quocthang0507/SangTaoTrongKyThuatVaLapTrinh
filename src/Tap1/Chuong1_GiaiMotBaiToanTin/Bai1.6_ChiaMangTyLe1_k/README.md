# Chia mảng tỷ lệ 1:k

*Tìm cách chia dãy số nguyên không âm a1, a2,...,an, n > 1 cho trước thành hai đoạn có tổng các phần tử trong một đoạn gấp k lần tổng các phần tử trong đoạn kia, k nguyên dương.*

## Đặc tả

Gọi t là tổng các phần tử của dãy a, `t = sum(a[1..n])`

Muốn chia a thành hai đoạn a[1..i] và a[i+1..n] có tổng gấp nhau k lần, ta phải có:

(1) t chia hết cho (k+1). Đặt `t1 = t div (k+1)` và tk = t - t1

(2) `(#E i: 1 <= i <= n): sum(a[1..i]) = t1` hoặc `sum(a[1..i]) = tk`

Để ý rằng nếu k = 1 thì t1 = tk, nếu k > 1 thì t1 < tk, do đó bài này là trường hợp riêng của bài trước khi k = 1

Trong chương trình dưới đây, hàm `Chia(k)` cho giá trị i nếu mảng a chia được
thành hai đoạn a[1..i] và a[(i + 1)..n] có tổng gấp k lần nhau. Trong trường hợp vô
nghiệm `Chia = -1`. Ta gọi i là điểm chia và dùng biến tr (tổng riêng) để tích luỹ
tổng các phần tử của đoạn đang xét a[1..i]. Khi tr = t1 bài toán có nghiệm I, ngược lại,
khi tr > t1 ta chưa thể kết luận là bài toán vô nghiệm. Trường hợp này ta phải tiếp tục
tích luỹ tr để hi vọng đạt được tổng tr = tk. Nếu sau khi tích luỹ ta thu được tr = tk thì
bài toán có nghiệm i, ngược lại, khi tr > tk ta kết luận là bài toán vô nghiệm.

Ta gọi thủ tục Gen để sinh dữ liệu kiểm thử. Cũng giống như bài trước, ta sẽ sinh
ngẫu nhiên dữ liệu kiểm thử cho hai trường hợp: chắc chắn có nghiệm và có thể vô
nghiệm. Với trường hợp có thể vô nghiệm ta sinh ngẫu nhiên như bình thường:

```c#
for i := 1 to n do a[i] := random(n);
```

Với trường hợp có nghiệm, ta sinh ngẫu nhiên mảng a gồm hai đoạn:
Đoạn thứ nhất a[1..d] và đoạn thứ hai a[d + 1..n] trong đó d là một điểm chia được sinh ngẫu nhiên
```c#
d := random(n div 2)+1; {diem chia}
```

Ta lại chọn ngẫu nhiên một trong hai trường hợp:
* Trường hợp thứ nhất: đoạn thứ nhất gấp k lần đoạn thứ hai.
* Trường hợp thứ hai: đoạn thứ hai gấp k lần đoạn thứ nhất.

## Kết quả

```
==================================================
0    0    0    0    0    0    0    0    0    0


Test, k = 3, diem chia = 1
Sum1 = 0, sum2 = 0
```

```
==================================================
6    7    5    36    8    6    2    1    0    1


Test, k = 3, diem chia = 3
Sum1 = 18, sum2 = 54
```

```
==================================================
2    10    0    1    0    0    0    0    0    1

Vo nghiem
```

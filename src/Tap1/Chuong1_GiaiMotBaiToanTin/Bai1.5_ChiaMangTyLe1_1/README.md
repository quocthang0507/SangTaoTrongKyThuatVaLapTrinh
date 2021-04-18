# Chia mảng tỷ lệ 1:1

*Tìm cách chia dãy số nguyên không âm a1, a2,...,an, n > 1 cho trước thành hai đoạn có tổng các phần tử trong mỗi đoạn bằng nhau.*

## Đặc tả

Ta quy ước viết #E là "tồn tại" và #V là "với mọi". Kí hiệu `sum(a[d..c])` là tổng các phần tử liên tiếp nhau từ a[d] đến a[c] của dãy a.

```c#
sum(a[d..c]) = a[d] + a[d+1] + ... + a[c]
```

Gọi t là tổng của các phần tử của mảng: `t = sum(a[1..n])`

Muốn chia a thành hai đoạn a[1..i] và a[i+1..n] có tổng bằng nhau, ta phả có:

(1) t là số chẵn (t chia hết cho 2). Đặt t2 = t div 2

(2) (#E i: 1 <= i <= n): sum(a[1..i]) = t2

## Chương trình

Hàm `chia` cho giá trị i nếu mảng a được chia thành a[1..i] và a[i+1..n]. Trong trường hợp vô nghiệm `chia = -1`.
Ta gọi i là điểm chia và dùng biến tr (tổng riêng) để tích lũy tổng các phần tử của đoạn đang xét a[1..i]. Khi tr = t2 thì bài toán có nghiệm i. Ngược lại, khi tr > t2 thì bài toán vô nghiệm.

Ta khởi trị ngẫu nhiên cho mảng a. Tuy nhiên ta muốn số lần có nghiệm (mảng a chia được thành hai phần có tổng bằng nhau) xấp xỉ bằng số lần vô nghiệm. 
Ta sẽ thực hiện mục tiêu đề ra như sau:

Mỗi lần khởi trị ta tung đồng xu hai mặt. Nếu gặp mặt sấp (random(2)=0), ta sẽ khởi trị tùy ý cho mảng a, ngược lại, nếu gặp mặt ngửa (random(2)=1) ta khởi trị a là mảng có nghiệm.
Để khởi trị sao cho mảng a có nghiệm ta lại chọn ngẫu nhiên một điểm cắt d trong khoảng 1..(n/2). Sau đó ta khởi trị ngẫu nhiên cho các phần tử a[1..d]. 
Với các phần tử còn lại ta cũng khởi trị ngẫu nhiên trong khoảng hợp lí sao cho tổng các giá trị của chúng đúng bằng tổng t của đoạn a[1..d]. Bạn đọc xem chi tiết thủ tục Gen trong chương trình.

## Kết quả

```c#
8       3       0       1       0       1       1       1       0       1

Doan thu nhat: 1..1
Doan thu hai: 2..10
```

```c#
2       7       0       3       5       0       0       0       0       1

Doan thu nhat: 1..2
Doan thu hai: 3..10
```

```c#
5       4       7       9       3       2       7       9       5       8

Khong chia duoc
```
# Sinh ngẫu nhiên đều

*Sinh ngẫu nhiên n phần tử cho mảng nguyên a thỏa điều kiện
n phần tử tạo thành k đoạn liên tiếp có tổng các phần tử
trong mỗi đoạn bằng nhau và bằng giá trị t cho trước.*

## Đặc tả

  1. Chọn số lượng các phần tử trong mỗi đoạn là `random(n div k) + 1`,khi đó số lượng các phần tử được phát sinh ngẫu nhiên sẽ không vượt quá:
```
k * (n div k) <= n
```
Sau đó ta sẽ chỉnh sao cho số lượng các phần tử đúng bằng n.

  2. Giả sử a[d..c] là đoạn thứ j cần được sinh ngẫu nhiên sao cho
```
a[d] + a[d+1] + ... + a[c] = t
``` 
Ta sinh đoạn này như sau:
* Gán `tr := t;` (tr là giá trị còn lại của tổng)
* Gán giá trị ngẫu nhiên 0..tr-1 cho các phần tử `a[d..(c-1)]`
```
(i = d..c) : a[i] := random(tr)
```
* Đồng thời chỉnh giá trị còn lại của tr:
```
tr := tr - a[i]
```
Ta có:
```
a[d] < t
a[d+1] < t - a[d]
a[d+2] < t - a[d+1] - a[d]
...
a[c-1] < t - a[d] - a[d+1] - ... - a[c-2]
```
Chuyển vế các phần tử a[*] trong biểu thức cuối cùng, ta thu được:
```
a[d] + a[d+1] + ... a[c-1] < t
```
* Ta đặt giá trị còn lại của tổng riêng vào phần tử cuối đoạn: `a[c] := tr` sẽ thu được:
```
a[d] + a[d+1] + ... + a[c] = t
``` 

## Ví dụ kết quả

```

 n = 7, k = 7, t = 8
8       8       8       8       8       8       8
Bam return de tiep tuc...

 n = 18, k = 3, t = 28
9       12      7       15      0       5       1       7       16      3       9       0       0       0       0      00       0
Bam return de tiep tuc...

 n = 26, k = 3, t = 7
3       1       0       0       3       6       0       1       6       0       1       0       0       0       0      00       0       0       0       0       0       0       0       0       0
Bam return de tiep tuc...

 n = 10, k = 1, t = 2
0       1       0       0       0       0       0       0       1       0
Bam return de tiep tuc...
```
# Sinh ngẫu nhiên mảng đối xứng

*Sinh ngẫu nhiên các giá trị để ghi vào một mảng hai chiều a[1..n, 1..n] sao cho
các phần tử đối cứng với nhau qua đường chéo chính, tức là:*
```
a[i,j] = a[j,i] với 1<=i, j<=N
```

## Đặc tả

1. Sinh ngẫu nhiên các phần tử trên đường chéo chính `a[i,i], i=1..n`
2. Sinh ngẫu nhiên các phần tử nằm phía trên đường chéo chính `a[i,j], i=1..n, j=i+1..n`
rồi lấy đối xứng `a[j,i] := a[i,j]`

Độ phức tạp: n^2

## Ví dụ kết quả

```
56      64      92      39      99      2       9       69      93      95
64      46      72      23      49      5       30      64      68      78
92      72      19      61      87      18      71      78      84      86
39      23      61      77      12      80      96      46      66      77
99      49      87      12      30      23      14      16      61      90
2       5       18      80      23      54      39      27      30      71
9       30      71      96      14      39      39      54      29      51
69      64      78      46      16      27      54      50      22      71
93      68      84      66      61      30      29      22      3       36
95      78      86      77      90      71      51      71      36      20
```

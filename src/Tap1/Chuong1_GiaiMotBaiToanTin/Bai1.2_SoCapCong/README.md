# Số cấp cộng

*Tìm các số tự nhiên lẻ có ba chữ số. Ba chữ số này, theo trật tự từ trái qua phải tạo thành một cấp số cộng*

## Đặc tả:

(1) x là số tự nhiên có ba chữ số: x = 100*a + 10*b + c

(2) x là số lẻ nên chữ số hàng đơn vị c là số lẻ: c = 1, 3, 5, 7, 9

(3) Chữ số hàng trăm của x phải khác 0: a = 1..9

(4) Nếu dãy a, b, c lập thành một cấp số cộng thì số đứng giữa b là trung bình cộng của hai số đầu và cuối: b = (a + c)/2 hay 2b = a + c

Từ (4) suy ra (a + c) là số chẵn. Do c lẻ, (a + c) chẵn nên a lẻ.

Nếu biết a và c thì ta tính được:

```c#
x = 100a + 10(a + c)/2 + c
= 100a + 5(a + c) + c
= 105a + 6c
```

Vì có 5 chữ số lẻ nên tổ hợp của a và c sẽ cho ta 25 số.
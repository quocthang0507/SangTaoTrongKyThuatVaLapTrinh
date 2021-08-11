# Số độ cao h

*Độ cao của một số tự nhiên là tổng các chữ số của số đó.
Sinh toàn bộ các số tự nhiên có tối đa ba chữ số và có độ cao h cho trước.
Ghi kết quả vào một tập tin văn bản có tên cho trước.*

## Đặc tả

Với n là số lượng các chữ số của một số, h là tổng của các chữ số đó.
Xét *n = 3* và *h = 0..27*:

1. Các số cần tìm là *y* có dạng *y = abc*, *a + b + c = h* và *a* biến thiên từ *min* a đến *max* a.
Nếu *h <= 18* thì *min* a = 0, ngược lại *min* a = h - 19;
Nếu *h >= 9* thì *max* a = 9, ngược lại *max* a = h;
2. Với mỗi a = *min* a .. *max* a, ta tính:
* *bc = h - a* (biến *bc* chứa tổng các chữ số *b* và *c*)
* Giải bài toán nhỏ với *n = 2*

Nếu *bc <= 9* thì *min* b = 0, ngược lại *min* b = bc; - 9
Nếu *bc >= 9* thì *max* b = 0, ngược lại *max* b = bc;
* Với mỗi b = *min* b .. *max* b, ta tính:
```
y = 100 * a + 10 * b + (bc - b)
```

## Kết quả

```
File result.txt
h = 10

Tong cong 63 so
19 28 37 46 55 64 73 82 91 109
118 127 136 145 154 163 172 181 190 208
217 226 235 244 253 262 271 280 307 316
325 334 343 352 361 370 406 415 424 433
442 451 460 505 514 523 532 541 550 604
613 622 631 640 703 712 721 730 802 811
820 901 910
```

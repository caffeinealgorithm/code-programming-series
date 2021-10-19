# from calendar import *
from time import *

# print(calendar(2021))
# print(month(2021, 8))
print(time()) # 1628197388.7380881
print(localtime(time())) # time.struct_time(tm_year=2021, tm_mon=8, tm_mday=5, tm_hour=22, tm_min=3, tm_sec=8, tm_wday=3, tm_yday=217, tm_isdst=1)
print(asctime(localtime(time()))) # Thu Aug 5 22:03:08 2021

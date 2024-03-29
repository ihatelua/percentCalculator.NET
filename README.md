# Percent Calculator

## Introduction

C# .Net 으로 만든 퍼센트 계산기입니다.

총 4가지의 퍼센트 계산기능이 들어가 있습니다.

- 전체값에서 일정 비율에 해당하는 값 계산
- 전체값의 일정 값에 해당하는 비율을 계산
- 기준값이 변경값으로 변화시 얼만큼 증가/감소 했는지 계산
- 기준값에서 일정 비율로 증가/감소한 결과를 계산

<br>

기타 기능으로는 2가지의 기능이 들어가 있습니다.
- 초기화 기능
- 항상 위로 표시 기능
- 숫자 포맷 기능


<br>

## ToDo
- [x] 숫자 콤마 기능
- [ ] 다국어 기능

<br>

## Known issues
__`v1.1.0 fixed`__
- 초기화버튼 클릭시 증가/감소 라벨이 바뀌지 않는다.
- 증가/감소 라벨이 한번 바뀌고 나면 값이 없어도 없어지지 않는다. 

__`v1.1.1 fixed`__
- 기준값 -> 변경값 변경시 계산 항목에서 값을 '0'으로 넣었을 때 증가/감소 라벨이 보이는 이슈

__`v1.1.2 fixed`__
- 기준값 -> 일정비율 계산 항목에서 증가/감소 콤보박스를 변경했을때 결과값이 0.00 으로 적용되는 이슈
- 값이 없을때 결과값이 없어져야 하는데 '0.00' 으로 적용되는 이슈
- 결과값 길이가 길어질경우 글자가 잘리는 이슈
- 기준값 -> 일정비율 계산 항목 증가/감소 콤보박스를 변경했을때 초기화버튼을 2번클릭해야 초기화가 되는 이슈
- 숫자포맷 체크를 설정했을때 % 부분도 숫자포맷이 적용되는 이슈
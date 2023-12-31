[Список задач](/src/problems/readme.md)

# Сумма двух чисел

Дан массив целых чисел nums и целое число target, верните индексы двух чисел таким образом, чтобы их сумма была равна target.<br/>
Можно предположить, что каждый ввод имеет ровно одно решение, и вы не можете использовать один и тот же элемент дважды.<br/>
Ответ можно вернуть в любом порядке.<br/>

**Пример 1:**
```console
Вход: nums = [2,7,11,15], target = 9
Выход: [0,1]
```
Объяснение: поскольку nums[0] + nums[1] == 9, мы возвращаем [0, 1].

**Пример 2:**
```console
Вход: nums = [3,2,4], target = 6
Выход: [1,2]
```

**Пример 3:**
```console
Вход: nums = [3,3], target = 6
Выход: [0,1]
```

**Ограничения:**

- 2 <= nums.length <= 104
- -109 <= nums[i] <= 109
- -109 <= target <= 109
- **Существует только один действительный ответ.**

Дополнительный вопрос: Можете ли вы придумать алгоритм, временная сложность которого меньше O(n2)?
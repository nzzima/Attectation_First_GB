## Промежуточная аттестация
**Задача:** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно вести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

**Описание решения задачи:** будем полагать что длину массивов и элементы-строки исходного массива задает пользователь. Сперва объявляем переменную len (пользователь вводит желаемое значение) и массивы строк start_array (исходный) и final_array (конечный). Для удобства добавляем функции Fill_array (пользователь задает строки как элементы массива) и Print_array (вывод массива на экран). В главной функции modify_final_arr будет производится выборка элементов массива start_array, длина которых меньше или равна 3 символам. В случае, если такие элементы есть, они будут записываться в конечный массив final_array. Другие элементы будут пропускаться. 

Графическое представление задачи в папке Schema. Решение задачи в task/Program.cs
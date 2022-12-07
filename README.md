# Final Project - Introductory_course

**For the full performance of verification work, it is necessary:**
- Create a repository on GitHub.
- Draw a block diagram of the algorithm.
- Provide a formalized text description of the solution to the repository (file README.md).
- Write a program that solves the task.*
- Use version control on this small project.

**Task:**

Write a program that from the existing array of strings forms a new array of strings whose length is less than or equal to 3 characters.
The initial array can be entered from the keyboard, or set at the start of the algorithm execution.

\* **Описание решения задачи (пункт 4 - написание программы):**

1. Ввод массива пользователем. Рандомный выбор размерности массива от 1 до 5, ввод пользователем с клавиатуры поэлементно. Ввод массива реализуется с помощью метода.
2. Расчет размерности нового массива, который будет содержать элементы массива, введенного пользователем, состоящие не более чем из 3-х символов. Расчет путем перебора всех элементов стартового массива с условием установленного количества символов. Расчет реализуется с помощью метода.
3. Формирование нового массива с размерностью, соответствующей расчитанной в предыдущем пункте, и заполнение его соответствующими элементами стартового массива содержащими не более 3-х символов. Формирование и наполнение массива реализуется с помощью метода.
4. Вывод массивов в консоль - реализуется с помощью метода.
5. Формирование основной программы: ввод стартового массива (п. 1), вывод стартового массива в консоль (п. 4), расчет размерности нового массива (п. 2), создание и заполнение нового массива (п. 3), вывод нового массива в консоль (п. 4).

*Нюансы задачи:*
- *проверка введенных пользователем значений (если значение не введено - повтор ввода). Включить в метод по п. 1;*
- *отформатированный вывод массивов в консоль. Включить в метод по п. 4.*
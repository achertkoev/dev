[Clean Code](/docs//SoftwareDesign&Architecture//CleanCode/CleanCode.md)

# Держите код фреймворка на расстоянии (Keep Framework Code Distant)

Сохранение кода фреймворка на расстоянии означает отделение кода приложения от кода фреймворка. 
Благодаря этому становится проще поддерживать, тестировать и обновлять кодовую базу приложения 
и фреймворка независимо друг от друга.

Вот несколько способов сохранить отдаленность кода фреймворка в системной архитектуре:

 1. Используйте уровень абстракции, чтобы отделить код приложения от кода фреймворка.
 Это позволяет писать код приложения без необходимости знать особенности фреймворка.

 2. Используйте внедрение зависимостей, чтобы отделить код приложения от кода фреймворка.
 Это позволяет коду приложения использовать функциональные возможности фреймворка, без 
 необходимости напрямую создавать экземпляры объектов фреймворка.

 3. Избегайте использование специфичных для фреймворка библиотек или классов в коде приложения.
 Это упрощает переключение на другую структуру в будущем, если это необходимо.

4. Используйте стандартный интерфейс кода приложения для взаимодействия с фреймворком.
Это позволяет писать код приложения без необходимости знать особенности фреймворка.

5. Храните приложения и код фреймворка в отдельных проектах и/или репозиториях.

Если следовать этим передовым практикам, архитектура системы станет более удобной в обслуживании,
тестируемой и менее подверженной ошибкам, а при необходимости будет проще обновить
или переключить фреймворк.
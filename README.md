# 🔢 Консольный калькулятор на C#

Проект: базовая версия калькулятора на языке C#.  
Реализованы основные операции: сложение, вычитание, умножение, деление.  
Идея: создать фундамент для будущей версии с приоритетами, скобками и интерфейсом.

---

## ⚙ Возможности:
- Поддержка операций `+`, `-`, `*`, `/`
- Защита от деления на ноль
- Обработка неверного ввода
- Расширяемость через `Dictionary<string, Func<...>>`

---

## 💻 Пример ввода:
5 * 8


## 📦 План на будущее:
- ✅ Поддержка приоритетов (`2 + 3 * 4`)
- ✅ Скобки (`(2 + 3) * 4`)
- 🔜 Парсинг сложных выражений
- 🔜 Объектно-ориентированная структура
- 🔜 Возможность интеграции GUI или веб-интерфейса

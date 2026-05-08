# [RU] PosikRusskogoWinXP

**Простая прога для .Net Framework 2.0** (подходит для Windows XP), которая:
- открывает текстовый файл,
- ищет и показывает в нём кириллические символы,
- при нажатии кнопки **«Авто-коррекция»** сохраняет новый файл (аналогичный исходнику, но без кириллицы).

> Прога написана для поиска кириллических символов в текстовых файлах.  
> Такие символы могут **нарушать** работу программы `.dmi` для координатно-измерительных машин  
> на DMIS и Camyo (как говорит мой босс).  
> **И потому мы собираемся их уничтожить...**

---

## Working build (Рабочий билд)

Находится здесь:  
`PosikRusskogoWinXP\PoiskRusskogoXP\bin\Release\PoiskRusskogoXP.exe`

---

## Как использовать

1. **Скачай** программу;  
2. **Запусти** программу;  
3. **Выбери** файл для анализа;  
4. Идёт автопроверка.  
   - Вылезет окно консоли, в котором будут выводиться строки исходного файла  
     с отмеченными русскими символами (или тарабарщина, если кодировка файла не та).  
   - **⚠️ КОНСОЛЬ НЕ ЗАКРЫВАТЬ!!!**  
5. Если нужен файл, в котором все русские символы будут **тупо снесены**, то **жмакай «АВТО-КОРРЕКЦИЯ»** –  
   новый файл с приставкой `_NoRussian` появится в папке с оригиналом.  
6. **Конец.**

---

---

# [EN] PosikRusskogoWinXP

A **simple app for .NET Framework 2.0** (works on Windows XP) that:
- opens a text file,
- finds and displays Cyrillic characters in it,
- when you click the **"Auto-correction"** button, saves a new file (similar to the original, but without Cyrillic).

> The app was made to find Cyrillic characters in text files.  
> Such characters can **break** `.dmi` programs for coordinate measuring machines  
> running DMIS and Camyo (according to my boss).  
> **So we're going to destroy them...**

---

## Working build

Located here:  
`PosikRusskogoWinXP\PoiskRusskogoXP\bin\Release\PoiskRusskogoXP.exe`

---

## How to use

1. **Download** the program;  
2. **Run** the program;  
3. **Select** the file to analyze;  
4. Auto‑check runs.  
   - A console window will pop up, showing lines from the original file  
     with Russian characters highlighted (or gibberish if the file encoding is wrong).  
   - **⚠️ DO NOT CLOSE THE CONSOLE!!!**  
5. If you want a file where all Russian characters are **simply removed**, press **"AUTO‑CORRECTION"** –  
   a new file with a `_NoRussian` suffix will be created in the original file's folder.  
6. **Done.**
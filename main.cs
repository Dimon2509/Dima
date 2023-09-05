/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World"); //Привет мир выводит
    
    string name = "Maximka";  // определяем переменную и инициализируем ее
  
    Console.WriteLine(name);    // Maximka
    
    const string NAME = "Серега";  // определяем константу
    
     Console.WriteLine(NAME); //Серега
     
    //Целочисленные литералы
    Console.WriteLine(-11);
    Console.WriteLine(5);
    Console.WriteLine(505);
    
    //Для записи числа в шестнадцатеричной форме применяются символы 0x, после которых идет набор символов от 0 до 9 и от A до F
    Console.WriteLine(0x0A);    // 10
    Console.WriteLine(0xFF);    // 255
    Console.WriteLine(0xA1);    // 161

    //Строковые литералы
    Console.WriteLine("hello");
    Console.WriteLine("фыва");
    Console.WriteLine("hello word");
    
    // '\n' - перевод строки

    // '\t' - табуляция

    // '\\' - слеш
    
    Console.WriteLine("Привет \nмир");
    
    // bool: хранит значение true или false
    
    bool alive = true;
    bool isDead = false;
    
    //byte: хранит целое число от 0 до 255 и занимает 1 байт.
    byte bit1 = 1;
    byte bit2 = 102;
    
    //sbyte: хранит целое число от -128 до 127 и занимает 1 байт.
    sbyte bit1 = -101;
    sbyte bit2 = 102;
    
    //short: хранит целое число от -32768 до 32767 и занимает 2 байта.
    short n1 = 1;
    short n2 = 102;
    
    //ushort: хранит целое число от 0 до 65535 и занимает 2 байта.
    ushort n1 = 1;
    ushort n2 = 102;
    
    //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
    int a = 10;
    int b = 0b101;  // бинарная форма b =5
    int c = 0xFF;   // шестнадцатеричная форма c = 255
    
    //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. 
    uint a = 10;
    uint b = 0b101;
    uint c = 0xFF;
    
    //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
    long a = -10;
    long b = 0b101;
    long c = 0xFF;
    
    //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
    ulong a = 10;
    ulong b = 0b101;
    ulong c = 0xFF;
    
    //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.
    char a = 'A';
    char b = '\x5A';
    char c = '\u0420';

    //string: хранит набор символов Unicode. Представлен системным типом System
    string hello = "Hello";
    string word = "world";
    
    //object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
    object a = 22;
    object b = 3.14;
    object c = "hello code";
    
    string name = "Tom";
    int age = 33;
    bool isEmployed = false;
    double weight = 78.65;
 
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Weight: {weight}");
    Console.WriteLine($"Employed: {isEmployed}");
    
    /* 
    Имя: Tom
    Возраст: 33
    Вес: 78,65
    Работает: False */
    
    //Использование суффиксов
    float a = 3.14F;
    float b = 30.6f;
 
    decimal c = 1005.8M;
    decimal d = 334.8m;
    
    
    uint a = 10U;
    long b = 20L;
    ulong c = 30UL;
    
    //Использование системных типов
    int a = 4;
    System.Int32 b = 4;
    
    //Неявная типизация
    var hello = "Hell to World";
    var c = 20;
    
    // этот код работает
    int a;
    a = 20;
 
    // этот код не работает
    var c;
    c= 20;
    
    // этот код не работает
    var c=null;
    
    //Консольный вывод
    string hello = "Привет мир";
    Console.WriteLine(hello);
    Console.WriteLine("Добро пожаловать в C#!");
    Console.WriteLine("Пока мир...");
    Console.WriteLine(24.5);
    
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);
    
    "Имя: {0}  Возраст: {2}  Рост: {1}м"
    "Имя: Tom  Возраст: 34  Рост: 1,7м"
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    //Консольный ввод
    Console.Write("Введите свое имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет {name}");
    
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
 
    Console.Write("Введите возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Введите рост: ");
    double height = Convert.ToDouble(Console.ReadLine());
 
    Console.Write("Введите размер зарплаты: ");
    decimal salary = Convert.ToDecimal(Console.ReadLine());
 
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");
    
    //Арифметические операции языка C#
    //Операция сложения двух чисел:
    int x = 10;
    int z = x + 12; // 22
    
    //Операция вычитания двух чисел:
    int x = 10;
    int z = x - 6; // 4
    
    //Операция умножения двух чисел:
    /******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World"); //Привет мир выводит
    
    string name = "Maximka";  // определяем переменную и инициализируем ее
  
    Console.WriteLine(name);    // Maximka
    
    const string NAME = "Серега";  // определяем константу
    
     Console.WriteLine(NAME); //Серега
     
    //Целочисленные литералы
    Console.WriteLine(-11);
    Console.WriteLine(5);
    Console.WriteLine(505);
    
    //Для записи числа в шестнадцатеричной форме применяются символы 0x, после которых идет набор символов от 0 до 9 и от A до F
    Console.WriteLine(0x0A);    // 10
    Console.WriteLine(0xFF);    // 255
    Console.WriteLine(0xA1);    // 161

    //Строковые литералы
    Console.WriteLine("hello");
    Console.WriteLine("фыва");
    Console.WriteLine("hello word");
    
    // '\n' - перевод строки

    // '\t' - табуляция

    // '\\' - слеш
    
    Console.WriteLine("Привет \nмир");
    
    // bool: хранит значение true или false
    
    bool alive = true;
    bool isDead = false;
    
    //byte: хранит целое число от 0 до 255 и занимает 1 байт.
    byte bit1 = 1;
    byte bit2 = 102;
    
    //sbyte: хранит целое число от -128 до 127 и занимает 1 байт.
    sbyte bit1 = -101;
    sbyte bit2 = 102;
    
    //short: хранит целое число от -32768 до 32767 и занимает 2 байта.
    short n1 = 1;
    short n2 = 102;
    
    //ushort: хранит целое число от 0 до 65535 и занимает 2 байта.
    ushort n1 = 1;
    ushort n2 = 102;
    
    //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
    int a = 10;
    int b = 0b101;  // бинарная форма b =5
    int c = 0xFF;   // шестнадцатеричная форма c = 255
    
    //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. 
    uint a = 10;
    uint b = 0b101;
    uint c = 0xFF;
    
    //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
    long a = -10;
    long b = 0b101;
    long c = 0xFF;
    
    //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
    ulong a = 10;
    ulong b = 0b101;
    ulong c = 0xFF;
    
    //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.
    char a = 'A';
    char b = '\x5A';
    char c = '\u0420';

    //string: хранит набор символов Unicode. Представлен системным типом System
    string hello = "Hello";
    string word = "world";
    
    //object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
    object a = 22;
    object b = 3.14;
    object c = "hello code";
    
    string name = "Tom";
    int age = 33;
    bool isEmployed = false;
    double weight = 78.65;
 
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Weight: {weight}");
    Console.WriteLine($"Employed: {isEmployed}");
    
    /* 
    Имя: Tom
    Возраст: 33
    Вес: 78,65
    Работает: False */
    
    //Использование суффиксов
    float a = 3.14F;
    float b = 30.6f;
 
    decimal c = 1005.8M;
    decimal d = 334.8m;
    
    
    uint a = 10U;
    long b = 20L;
    ulong c = 30UL;
    
    //Использование системных типов
    int a = 4;
    System.Int32 b = 4;
    
    //Неявная типизация
    var hello = "Hell to World";
    var c = 20;
    
    // этот код работает
    int a;
    a = 20;
 
    // этот код не работает
    var c;
    c= 20;
    
    // этот код не работает
    var c=null;
    
    //Консольный вывод
    string hello = "Привет мир";
    Console.WriteLine(hello);
    Console.WriteLine("Добро пожаловать в C#!");
    Console.WriteLine("Пока мир...");
    Console.WriteLine(24.5);
    
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);
    
    "Имя: {0}  Возраст: {2}  Рост: {1}м"
    "Имя: Tom  Возраст: 34  Рост: 1,7м"
    
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
    
    //Консольный ввод
    Console.Write("Введите свое имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет {name}");
    
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
 
    Console.Write("Введите возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Введите рост: ");
    double height = Convert.ToDouble(Console.ReadLine());
 
    Console.Write("Введите размер зарплаты: ");
    decimal salary = Convert.ToDecimal(Console.ReadLine());
 
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");
    
    //Арифметические операции языка C#
    //Операция сложения двух чисел:
    int x = 10;
    int z = x + 12; // 22
    
    //Операция вычитания двух чисел:
    int x = 10;
    int z = x - 6; // 4
    
    //Операция умножения двух чисел:
    int x = 10;
    int z = x * 5; // 50
    
    //Операция деления двух чисел:
    int x = 10;
    int z = x / 5; // 2
 
    double a = 10;
    double b = 3;
    double c = a / b; // 3.33333333

    double z = 10 /  4; //результат равен 2

    double z = 10.0 /  4.0; //результат равен 2.5

    double x = 10.0;
    double z = x % 4.0; //результат равен 2
    
    //Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение возвращается в качестве результата операции.
    
    // ++
    int x1 = 5;
    int z1 = ++x1; // z1=6; x1=6
    Console.WriteLine($"{x1} - {z1}");
 
    int x2 = 5;
    int z2 = x2++; // z2=5; x2=6
    Console.WriteLine($"{x2} - {z2}");
    
    //Операция декремента или уменьшения значения на единицу. Также существует префиксная форма декремента (--x) и постфиксная (x--).
    int x1 = 5;
    int z1 = --x1; // z1=4; x1=4
    Console.WriteLine($"{x1} - {z1}");
     
    int x2 = 5;
    int z2 = x2--; // z2=5; x2=4
    Console.WriteLine($"{x2} - {z2}");
    
    //Здесь мы имеем дело с тремя операциями: декремент, вычитание и умножение. Сначала выполняется декремент переменной c, затем умножение b*a, и в конце вычитание. 
    int a = 3;
    int b = 5;
    int c = 40;
    int d = c---b*a;    // a=3  b=5  c=39  d=25
    Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");
    
    //Все арифметические операторы являются левоассоциативными
    int x = 10 / 5 * 2;
    
    //В первом случае у нас два числа 2 и 5. 2 в двоичном виде представляет число 010, а 5 - 101. Поразрядно умножим числа (0*1, 1*0, 0*1) и в итоге получим 000.
    int x1 = 2; //010
     int y1 = 5;//101
     Console.WriteLine(x1&y1); // выведет 0
     
    //Во втором случае у нас вместо двойки число 4, у которого в первом разряде 1, так же как и у числа 5, поэтому в итоге получим (1*1, 0*0, 0 *1) = 100, то есть число 4 в десятичном формате.
    int x2 = 4; //100
    int y2 = 5; //101
    Console.WriteLine(x2 & y2); // выведет 4
    
    
    //Похоже на логическое умножение, операция также производится по двоичным разрядам, но теперь возвращается единица, если хотя бы у одного числа в данном разряде имеется единица.
    int x1 = 2; //010
    int y1 = 5;//101
    Console.WriteLine(x1|y1); // выведет 7 - 111
    int x2 = 4; //100
    int y2 = 5;//101
    Console.WriteLine(x2 | y2); // выведет 5 - 101
    
    //Также эту операцию называют XOR, нередко ее применяют для простого шифрования
    int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
    int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
     
    int encrypt = x ^ key; //Результатом будет число 1001011 или 75
    Console.WriteLine($"Зашифрованное число: {encrypt}") ;
     
    int decrypt = encrypt ^ key; // Результатом будет исходное число 45
    Console.WriteLine($"Расшифрованное число: {decrypt}");
    
    //Операции сдвига
    int a = 16; // в двоичной форме 10000
    int b = 2; // в двоичной форме
    int c = a << b; // Сдвиг числа 10000 влево на 2 разряда, равно 1000000 или 64 в десятичной системе
     
    Console.WriteLine($"Зашифрованное число: {c}") ;    // 64
     
    int d = a >> b; // Сдвиг числа 10000 вправо на 2 разряда, равно 100 или 4 в десятичной системе
    Console.WriteLine($"Зашифрованное число: {d}");     // 4
    
    //Один из примеров. У нас есть три числа, которые находятся в диапазоне от 0 до 3
    int value1 = 3;  // 0b0000_0011
    int value2 = 2;  // 0b0000_0010
    int value3 = 1;  // 0b0000_0001
    int result = 0b0000_0000;
    // сохраняем в result значения из value1
    result = result | value1; // 0b0000_0011
    // сдвигаем разряды в result на 2 разряда влево
    result = result << 2;   // 0b0000_1100
    // сохраняем в result значения из value2
    result = result | value2;  // 0b0000_1110
    // сдвигаем разряды в result на 2 разряда влево
    result = result << 2;   // 0b0011_1000
    // сохраняем в result значения из value3
    result = result | value3;  // 0b0011_1001
     
    Console.WriteLine(result);  // 57
    
    //Как и во многих других языках программирования, в C# имеется базовая операция присваивания =, которая присвоивает значение правого операнда левому операнду
    int number = 23;
    
    //Также можно выполнять множественно присвоение сразу нескольких переменным одновременно
    int a, b, c;
    a = b = c = 34;
    
    //Применение операций присвоения
    int a = 10;
    a += 10;        // 20
    a -= 4;         // 16
    a *= 2;         // 32
    a /= 8;         // 4
    a <<= 4;      // 64
    a >>= 2;      // 16
    
    //Операции присвоения являются правоассоциативными, то есть выполняются справа налево
    int a = 8;
    int b = 6;
    int c = a += b -= 5;    // 9
    
    //Сравнивает два операнда на равенство. Если они равны, то операция возвращает true, если не равны, то возвращается false
    int a = 10;
    int b = 4;
    bool c = a == b; // false
    
    
    //В прошлой теме были расмотрены арифметические операции. Теперь применим операцию сложения к данным разных типов
    byte a = 4;
    int b = a + 70;
    
    //Но теперь попробуем применить сложение к двум объектам типа byte:
    byte a = 4;
    byte b = a + 70;  // ошибка не хватка местаа
    
    //Сравнивает два операнда на равенство. Если они равны, то операция возвращает true, если не равны, то возвращается false
    int a = 10;
    int b = 4;
    bool c = a == b; // false
    
    //Сравнивает два операнда и возвращает true, если операнды не равны, и false, если они равны.
    int a = 10;
    int b = 4;
    bool c = a != b;    // true
    bool d = a!=10;     // false
    
    //Операция "меньше чем". Возвращает true, если первый операнд меньше второго, и false, если первый операнд больше второго:
    int a = 10;
    int b = 4;
    bool c = a < b; // false
    
    //Операция "больше чем". Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false
    int a = 10;
    int b = 4;
    bool c = a > b;     // true
    bool d = a > 25;    // false
    
    //Также в C# определены логические операторы, которые также возвращают значение типа bool. В качестве операндов они принимают значения типа bool. Как правило, применяются к отношениям и объединяют несколько операций сравнения
    
    bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
    bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
    
    bool x1 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
    bool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
    
    //Ее простейшая форма состоит из блока if
    /* if(условие)
{
    выполняемые инструкции
} */

    int num1 = 8;
    int num2 = 6;
    if(num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
    
    int num1 = 8;
    int num2 = 6;
    if (num1 > num2)
        Console.WriteLine($"Число {num1} больше числа {num2}");
     
    // или так
    if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
    
    int num1 = 8;
    int num2 = 6;
    if(num1 > num2 && num1==8)
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
    
    //Выражение else
        int num1 = 8;
    int num2 = 6;
    if(num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} меньше числа {num2}");
    }
        
    //else if
    int num1 = 8;
    int num2 = 6;
    if(num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
    else if (num1 < num2)
    {
        Console.WriteLine($"Число {num1} меньше числа {num2}");
    }
    else
    {
        Console.WriteLine("Число num1 равно числу num2");
    }
    
    //Цикл for
    for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
    {
        // действия
    }
     
    //Рассмотрим стандартный цикл for:
     for (int i = 1; i < 4; i++)
    {
        Console.WriteLine(i);
    }
 
    //Если блок цикла for содержит одну инструкцию, то мы можем его сократить, убрав фигурные свобки:
    for (int i = 1; i < 4; i++) Console.WriteLine(i);
    
    //Нам необязательно указывать все условия при объявлении цикла. Например, мы можем написать так:
    int i = 1;
    for (; ;)
    {
    Console.WriteLine($"i = {i}");
    i++;
    }
    
    //Мы также можем опустить ряд блоков:
        int i = 1;
    for (; i<4;)
    {
        Console.WriteLine($"i = {i}");
        i++;
    }
    
    //Также стоит отметить, что можно определять несколько переменных в объявлении цикла:
    for (int i = 1, j = 1; i < 10; i++, j++)
        Console.WriteLine($"{i * j}");
    
    
    //Цикл do..while
        do
    {
        действия цикла
    }
    while (условие)
    
    //Например:
        int i = 6;
    do
    {
        Console.WriteLine(i);
        i--;
    }
    while (i > 0);
    
    
        //Цикл while
        while (условие)
    {
        действия цикла
    }
        
    
    //Например:
        int i = 6;
    while (i > 0)
    {
        Console.WriteLine(i);
        i--;
    }

    
    //Цикл foreach
        foreach(тип_данных переменная in коллекция)
    {
        // действия цикла
    }
    
    //Например
        foreach(char c in "Tom")
    {
        Console.WriteLine(c);
    }
    
    //Операторы continue и break
    //break
        for (int i = 0; i < 9; i++)
    {
        if (i == 5)
            break;
        Console.WriteLine(i);
    }
    
    //Continue
        for (int i = 0; i < 9; i++)
    {
        if (i == 5)
            continue;
        Console.WriteLine(i);
    }
    
    //Вложенные циклы
        for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            Console.Write($"{i * j} \t");
        }
        Console.WriteLine();
    }
    
    //Массивы
    int[] numbers;
    
    int[] nums = new int[4];
    
    
    
  }
}


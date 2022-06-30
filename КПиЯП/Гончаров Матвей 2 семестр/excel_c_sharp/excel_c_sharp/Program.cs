using System;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

if (xlApp == null)
{
    Console.WriteLine("Excel is not properly installed!!");
    return;
}


Excel.Workbook xlWorkBook;
Excel.Worksheet xlWorkSheet;
object misValue = System.Reflection.Missing.Value;

xlWorkBook = xlApp.Workbooks.Add(misValue);
xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

//************************************************************************

/*
 1. Оказывается тут счет с 1
 2. Это подгон под разные чтобы например если это надо с формы стянуть
 3. C# Полная зал*па он даже не может права на доступ к файлам нормально получить
 4. Чтобы по новой запустить надо файлик удалить или кодом бахнуть удаление
 */

int col = 10, row = 10, inc = 0;
for (int i = 1; i <= col; i++)
{
    for (int j = 1; j <= row; j++)
    {

        if (j == 1) // Тут первый столбец (например нумерация)
        {
            xlWorkSheet.Cells[i, j] = ++inc;
        }
        else if (i == 1) // Шапка
        {
            xlWorkSheet.Cells[i, j] = "Name";
        }
        else
        {
            xlWorkSheet.Cells[i, j] = "test"; // Столбец
        }
    }
}

xlWorkBook.SaveAs("C:\\Users\\shindows10\\Desktop\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
xlWorkBook.Close(true, misValue, misValue);
xlApp.Quit();

Marshal.ReleaseComObject(xlWorkSheet);
Marshal.ReleaseComObject(xlWorkBook);
Marshal.ReleaseComObject(xlApp);
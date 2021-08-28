using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker docWorker;
            System.Console.WriteLine("Введите ключ продукта для использования версий pro или exp\n(Если ввода небудет или пользователь введет неправильный ключ то будет использоваться бесплатная верся)\nВвод:");
            string key = Console.ReadLine();
            if (key == "1133")
            {
                System.Console.WriteLine("Вы используете верси Pro");
                docWorker = new ProDocumentWorker();
            }
            else if (key == "2266")
            {
                System.Console.WriteLine("Вы используете верси Expert");
                docWorker = new ExpertDocumentWord();
            }
            else
            {
                System.Console.WriteLine("Так как ключ не был введен(или был введен неправильный ключ) вы будете использовать бесплатную версию");
                docWorker = new DocumentWorker();
            }
            System.Console.WriteLine();
            docWorker.OpenDocument();
            docWorker.EditDocument();
            docWorker.SaveDocument();
        }
    }
    class DocumentWorker
    {
        public void OpenDocument() => System.Console.WriteLine("Документ открыт");
        public virtual void EditDocument() => System.Console.WriteLine("Редактирование документа доступно в версии Про");
        public virtual void SaveDocument() => System.Console.WriteLine("Сохранение документа доступно в версии Про");
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() => System.Console.WriteLine("Документ отредактирован");
        public override void SaveDocument() => System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
    }
    class ExpertDocumentWord : ProDocumentWorker
    {
        public override void SaveDocument() => System.Console.WriteLine("Документ сохранен в новом формате");
    }
}

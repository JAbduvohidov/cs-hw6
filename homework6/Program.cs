using System;

namespace homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.Write("Введите ключ: ");
            var documentKey = Console.ReadLine();
            
            var documentWorker = documentKey switch
            {
                "pro" => new ProDocumentWorker(),
                "exp" => new ExpertDocumentWorker(),
                _ => new DocumentWorker()
            };
            
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
            
            Console.WriteLine(new String('-', 20));

            // 2
            IPlayable player = new Player();
            
            player.Play();
            player.Pause();
            player.Stop();
            
            Console.WriteLine();
            
            IRecordable recorder = new Player();
            recorder.Record();
            recorder.Pause();
            recorder.Stop();
        }
    }
}
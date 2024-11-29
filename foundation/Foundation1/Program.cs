using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        
        List<Comment> commentsVideo1 = new List<Comment>();
        Comment commentVideo1_1 = new Comment("Juan Pablo", "No me gusto mucho");
        Comment commentVideo1_2 = new Comment("Maria Pérez", "Fabuloso, excelente trabajo");
        Comment commentVideo1_3 = new Comment("Thiago Quesada", "Estuvo como que fuerte la cosa");
        commentsVideo1.Add(commentVideo1_1);
        commentsVideo1.Add(commentVideo1_2);
        commentsVideo1.Add(commentVideo1_3);
        Video video1 = new Video("Broma a mi abuelo", "Randy Muñoz", 240, commentsVideo1);
        Console.WriteLine(video1.ShowInformation());

        List<Comment> commentsVideo2 = new List<Comment>();
        Comment commentVideo2_1 = new Comment("Petra Ramirez", "Aleluya!");
        Comment commentVideo2_2 = new Comment("Juana de Arco", "Hermosisimo me encant!");
        Comment commentVideo2_3 = new Comment("Alfonso Pochero", "Eso si es arte, Saludos!");
        commentsVideo2.Add(commentVideo2_1);
        commentsVideo2.Add(commentVideo2_2);
        commentsVideo2.Add(commentVideo2_3);
        Video video2 = new Video("El arte del sonido", "Juan Pérez", 758, commentsVideo2);
        Console.WriteLine(video2.ShowInformation());

        List<Comment> commentsVideo3 = new List<Comment>();
        Comment commentVideo3_1 = new Comment("Alexander Gonzales", "Muy buen tutorial");
        Comment commentVideo3_2 = new Comment("Luisa Anton", "Me costó un poco pero al final hice el ejercicio");
        Comment commentVideo3_3 = new Comment("Matías Muñoz", "Gracias por compartir este material");
        Comment commentVideo3_4 = new Comment("Santiago Tafur", "Eres un crack!");
        commentsVideo3.Add(commentVideo3_1);
        commentsVideo3.Add(commentVideo3_2);
        commentsVideo3.Add(commentVideo3_3);
        commentsVideo3.Add(commentVideo3_4);
        Video video3 = new Video("Cómo centrar un div", "Alberto Fernandez", 985, commentsVideo3);
        Console.WriteLine(video3.ShowInformation());

    }
}
//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Ucu.Poo.Discord;
using Ucu.Poo.Cognitive;
using System.Reflection.Metadata;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            string botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
            string channelText = Environment.GetEnvironmentVariable("CHANNEL_ID");
            if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(channelText))
            {
                Console.WriteLine("Faltan las variables de entorno 'DISCORD_BOT_TOKEN' y 'CHANNEL_ID'.");
                return;
            }

            ulong channelId = ulong.Parse(channelText);

            DiscordClient discord = new DiscordClient();

            /*
            Mira a continuación cómo enviar mensajes y archivos a Discord;
            deberás hacer lo mismo en las clases y métodos adecuados de tu
            solución. Luego puedes comentar o eliminar este código.
            */

            Console.WriteLine("Conectando con Discord...");
            discord.Login(botToken);


                        /*
            En este método deberás mostrar un ejemplo de funcionamiento de tu
            solución. A continuación te planteamos un ejemplo de como hacerlo.
            Esto no significa que te limites a hacer solamente esto, ¡debes
            pensar en grande!
            */
           Passenger pasajero1 = new Passenger("Martin", "Perez", 53126432, 8, "src/Program/bill.jpg");
           //Passenger pasajero2 = new Passenger("Jose", "Pereira", 41298636, 8, "src/Program/rick.jpg");

           Driver conductor1 = new Driver("Roberto", "Diaz", 35412675, 10, "src/Program/dan.jpg", "toyota corolla", "me gusta conducir", false);
           //Pool conductor2 = new Pool("Manuel", "Gomez", 46712984, 9, "src/Program/rick.jpg", "susuki dzire", "manejo hace 8 años", true, 4);

           UcuRideShare ucuRide = new UcuRideShare(discord);
           ucuRide.AddPassenger(pasajero1, channelId);
           //ucuRide.AddPassenger(pasajero2, channelId);

           ucuRide.AddDriver(conductor1, channelId);
           //ucuRide.AddDriver(conductor2, channelId);

            /*
            Mira a continuación cómo validar caras y caras con lentes para el
            desafío 3; deberás hacer lo mismo en las clases y métodos adecuados
            de tu solución. Luego puedes comentar o eliminar este código.
            */

/*
            string subscriptionKey = Environment.GetEnvironmentVariable("AZURE_FACE_SUBSCRIPTION_KEY");
            if (string.IsNullOrWhiteSpace(subscriptionKey))
            {
                Console.WriteLine("Falta la variables de entorno 'AZURE_FACE_SUBSCRIPTION_KEY'.");
                return;
            }

            CognitiveFace face = new CognitiveFace();
            CognitiveFace.RecognitionResult result = face.Recognize("bill.jpg");
            if (result.Success && result.FaceFound)
            {
                Console.WriteLine("Hay una cara 😀");
            }
            result = face.Recognize("rick.jpg");
            if (result.Success && result.GlassesFound)
            {
                Console.WriteLine("Hay una cara con lentes 🤓");
            }
*/
        }
    }
}

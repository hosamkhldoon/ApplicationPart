using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NPoco.fastJSON;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FileWorxObjects;
namespace WorkerServiceContact
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            var factory = new RabbitMQ.Client.ConnectionFactory() { HostName = "localhost" };
            string queueName = "hello";
            var rabbitMqConnection = factory.CreateConnection();
            var rabbitMqChannel = rabbitMqConnection.CreateModel();

            rabbitMqChannel.QueueDeclare(queue: queueName,
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            rabbitMqChannel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
            IFTPRemotingService ftp = new FTPRemotingService();
            int messageCount = Convert.ToInt16(rabbitMqChannel.MessageCount(queueName));
            Console.WriteLine(" Listening to the queue. This channels has {0} messages on the queue", messageCount);

         
                var consumer = new EventingBasicConsumer(rabbitMqChannel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    List<FileOperation> ListNews = JsonConvert.DeserializeObject<List<FileOperation>>(message);

                    ftp.UploadFileInFtpServer(ListNews);
                    rabbitMqChannel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                    Thread.Sleep(1000);
                };
                rabbitMqChannel.BasicConsume(queue: queueName,
                                     autoAck: false,
                                     consumer: consumer);
            

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseWindowsService()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });
    }
}

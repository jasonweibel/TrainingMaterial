﻿// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.

namespace Starbucks.Customer
{
    using System;
    using System.Windows.Forms;
    using MassTransit;
    using MassTransit.Log4NetIntegration.Logging;
    using Microsoft.Practices.Unity;
    using Starbucks.Messages;
    using MassTransit.Saga;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log4NetLogger.Use("customer.log4net.xml");

            //IContainer c = BootstrapContainer();

            var container = new UnityContainer();

            // register types directly
            container.RegisterType<OrderDrinkForm>(new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(ISagaRepository<>), typeof(InMemorySagaRepository<>), new ContainerControlledLifetimeManager());

            // Register the ServiceBus.
            container.RegisterInstance<IServiceBus>(ServiceBusFactory.New(sbc =>
            {
                // Configure exchanges.
                sbc.ReceiveFrom("msmq://localhost/starbucks_customer");
                sbc.UseMsmq();
                sbc.UseMulticastSubscriptionClient();
                sbc.UseControlBus();

                sbc.Subscribe(subs => { subs.LoadFrom(container); });
            }));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrderDrinkForm(container.Resolve<IServiceBus>()));
            //Application.Run(new OrderDrinkForm(container.GetInstance<IServiceBus>()));
        }

        //static IContainer BootstrapContainer()
        //{
        //    var container = new Container(x => { x.AddType(typeof (OrderDrinkForm)); });

        //    container.Configure(cfg =>
        //        {
        //            cfg.For<IServiceBus>().Use(context => ServiceBusFactory.New(sbc =>
        //                {
        //                    sbc.ReceiveFrom("msmq://localhost/starbucks_customer");
        //                    sbc.UseMsmq();
        //                    sbc.UseMulticastSubscriptionClient();

        //                    sbc.UseControlBus();

        //                    sbc.Subscribe(subs => { subs.LoadFrom(container); });
        //                }));
        //        });

        //    return container;
        //}
    }
}
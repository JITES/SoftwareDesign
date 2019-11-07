using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class DependencyInjection
    {
    }

    public interface IProcessor
    {
        int Speed { get; set; }
        string Type { get; set; }
        string Core { get; set; }
    }

    class Processor : IProcessor
    {
        public Processor(int Speed)
        {

        }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Core { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Computer
    {
        private IProcessor _processor;
        public Computer(IProcessor processor)
        {
            this._processor = processor;
        }

        public void BuildComputer()
        {
            Console.WriteLine("Build Computer");
        }
    }
    class Implementation
    {
        void BuildComputer()
        {
            Processor p = new Processor(5);
            Computer computer = new Computer(p);
            computer.BuildComputer();

            IContainer container = IoCBuilder.Build();
            var app = container.Resolve<Computer>();

        }
    }

    public class IoCBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Computer>();
            builder.RegisterType<Processor>().As<IProcessor>();
            return builder.Build();
        }
    }
}

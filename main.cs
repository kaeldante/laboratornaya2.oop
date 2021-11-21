using System;

class Program {
  public static void Main (string[] args) {
     Console.WriteLine("Лабораторная работа 2. Вариант 1");
     Console.WriteLine("=================================");
     Generator SW = new Generator("Стартвольт",2,1);
    Car VAZ = new Car("ВАЗ", "2107","2010","к 21067","инжекторный",75, 1.6,SW.GeneratorName,SW.MaxCap,SW.Cap);
    if (SW.GetCap()>0){
    Console.WriteLine(VAZ.GetInfo());
    VAZ.Start();
    Console.WriteLine(VAZ.GetInfo());
    VAZ.Stop();
    Console.WriteLine(VAZ.GetInfo()); }
    else Console.WriteLine("Двигатель разряжен!");
    
    
  
  }
  ////////////Машина
  class Car
{
  public string Mark;
  public string Model;
  public string Year;
  private Engine Engine;
  private Generator Generator;

  public Car(string Mark, string Model, string Year, string EngineName, string Type,int Power,double Volume, string GeneratorName,int MaxCap,int Cap)
  {
    this.Mark = Mark;
    this.Model = Model;
    this.Year = Year;
    this.Engine = new Engine(EngineName,Type,Power,Volume);
    this.Generator = new Generator(GeneratorName,MaxCap,Cap);
  }

  public void Start()
  {
    this.Engine.Start();
  }

  public void Stop()
  {
    this.Engine.Stop();
  }
  

  public string GetInfo()
  {
    return $"{this.Mark} {this.Model} Двигатель: {this.Engine.GetEngineStatus()}";
  }
}
////////////Двигатель
class Engine
{
  public string EngineName;
  public string Type;
  public int Power;
  public double Volume;
  
  
  private string EngineStatus;

  public Engine(string EngineName,string Type,int Power,double Volume  )
  {
    this.EngineName = EngineName;
    this.Type = Type;
    this.Power = Power;
    this.Volume = Volume;
    
    
    this.EngineStatus = "Отключен";
  }

  public void Start()
  {
    this.EngineStatus = "Запущен";
  }

  public void Stop()
  {
    this.EngineStatus = "Отключен";
  }

  public string GetEngineStatus()
  {
    return this.EngineStatus;
  }
}
//////////Генератор
class Generator
{
  public string GeneratorName;
  public int MaxCap;
  public int Cap;
  
  
  

  public Generator(string GeneratorName,int MaxCap, int Cap)
  {
    this.GeneratorName = GeneratorName;
    this.MaxCap = MaxCap;
    this.Cap = Cap;
  }
  public int GetCap(){
return this.Cap;
  }
}

}


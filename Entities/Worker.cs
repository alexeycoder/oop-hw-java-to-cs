using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oop.WorkerDocument.Entities
{
	/// <summary>
	/// Работник -- тип сущности с которым работаем (будем "как бы"-сохранять
	/// в разных форматах).
	/// </summary>
	public class Worker
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public int Salary { get; set; }

		public Worker(string name, int age, int salary)
		{
			Name = name;
			Age = age;
			Salary = salary;
		}

		public override string ToString()
		{
			return $"Имя: {Name}, Возраст: {Age}, З/п: {Salary}";
		}

	}
}
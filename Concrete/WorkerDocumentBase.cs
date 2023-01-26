using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oop.WorkerDocument.Entities;

namespace Oop.WorkerDocument.Concrete
{
	public abstract class WorkerDocumentBase
	{
		protected Worker worker;

		public WorkerDocumentBase(Worker worker)
		{
			this.worker = worker ?? throw new NullReferenceException(nameof(worker));
		}
	}
}

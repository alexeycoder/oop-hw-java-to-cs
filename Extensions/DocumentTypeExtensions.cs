using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oop.WorkerDocument.Enums;

namespace Oop.WorkerDocument.Extensions
{
	public static class DocumentTypeExtensions
	{
		public static bool IsEligibleString(this DocumentType documentType, string str)
		{
			return false;
		}
	}
}
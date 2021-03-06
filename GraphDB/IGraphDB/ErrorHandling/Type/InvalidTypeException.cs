/*
* sones GraphDB - Community Edition - http://www.sones.com
* Copyright (C) 2007-2011 sones GmbH
*
* This file is part of sones GraphDB Community Edition.
*
* sones GraphDB is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB. If not, see <http://www.gnu.org/licenses/>.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sones.GraphDB.ErrorHandling
{
    public class InvalidTypeException: AGraphDBTypeException
    {
        private string p;
        private string p_2;

		/// <summary>
		/// Initializes a new instance of the InvalidTypeException class.
		/// </summary>
		/// <param name="myUnexpectedType"></param>
		/// <param name="myExpectedType"></param>
		/// <param name="innerException">The exception that is the cause of the current exception, this parameter can be NULL.</param>
        public InvalidTypeException(string myUnexpectedType, string myExpectedType, Exception innerException = null) : base(innerException)
        {
            this.p = myUnexpectedType;
            this.p_2 = myExpectedType;

            _msg = "The given type " + myUnexpectedType + " is invalid, expected " + myExpectedType + ".";
        }
    }
}

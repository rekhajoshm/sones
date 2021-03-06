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

using sones.GraphDB.TypeSystem;

namespace sones.GraphDB.TypeManagement
{
    internal class OutgoingEdgeDefinition: IOutgoingEdgeDefinition
    {
        #region IOutgoingEdgeDefinition

        public IEdgeType EdgeType { get; internal set; }

        public IEdgeType InnerEdgeType { get; internal set; }

        public EdgeMultiplicity Multiplicity { get; internal set; }

        public IVertexType SourceVertexType { get; internal set; }

        public IVertexType TargetVertexType { get; internal set; }

        #endregion

        #region IAttributeDefinition Members

        public string Name { get; internal set; }

        public long ID { get; internal set; }

        public AttributeType Kind { get { return AttributeType.OutgoingEdge; } }

        public IBaseType RelatedType { get; internal set; }

        public bool IsUserDefined { get; internal set; }

        #endregion

        #region IEquatable<IAttributeDefinition> Members

        public bool Equals(IAttributeDefinition myOther)
        {
            return myOther != null && myOther.ID == ID;
        }

        #endregion

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IAttributeDefinition);
        }


    }
}

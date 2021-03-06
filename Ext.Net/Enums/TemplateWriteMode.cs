/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.1.1 - Ext.NET Community License (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;

namespace Ext.Net
{
    ///<summary>
    /// The Ext.XTemplate method to use when updating the content area of the AbstractComponent
    ///</summary>
    public enum TemplateWriteMode
    {
        ///<summary>
        /// Applies the supplied values to the template and appends the new node(s) to the specified el.
        ///</summary>
        Append,

        ///<summary>
        /// Applies the supplied values to the template and inserts the new node(s) after el.
        ///</summary>
        InsertAfter,

        ///<summary>
        /// Applies the supplied values to the template and inserts the new node(s) before el.
        ///</summary>
        InsertBefore,

        ///<summary>
        /// Applies the supplied values to the template and inserts the new node(s) as the first child of el.
        ///</summary>
        InsertFirst,

        ///<summary>
        /// Applies the supplied values to the template and overwrites the content of el with the new node(s).
        ///</summary>
        Overwrite
    }
}

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
 * @version   : 2.0.0.beta - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-03-07
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DateMenu
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DateMenu(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DateMenu.Config Conversion to DateMenu
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DateMenu(DateMenu.Config config)
        {
            return new DateMenu(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : MenuBase.Config 
        { 
			/*  Implicit DateMenu.Config Conversion to DateMenu.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DateMenu.Builder(DateMenu.Config config)
			{
				return new DateMenu.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool hideOnClick = true;

			/// <summary>
			/// False to continue showing the menu after a date is selected, defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool HideOnClick 
			{ 
				get
				{
					return this.hideOnClick;
				}
				set
				{
					this.hideOnClick = value;
				}
			}
        
			private DatePicker picker = null;

			/// <summary>
			/// The Ext.DatePicker object
			/// </summary>
			public DatePicker Picker
			{
				get
				{
					if (this.picker == null)
					{
						this.picker = new DatePicker();
					}
			
					return this.picker;
				}
			}
			        
			private DateMenuListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public DateMenuListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new DateMenuListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private DateMenuDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public DateMenuDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new DateMenuDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}
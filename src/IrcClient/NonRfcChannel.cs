/*
 * $Id$
 * $URL$
 * $Rev$
 * $Author$
 * $Date$
 *
 * SmartIrc4net - the IRC library for .NET/C# <http://smartirc4net.sf.net>
 *
 * Copyright (c) 2003-2005 Mirco Bauer <meebey@meebey.net> <http://www.meebey.net>
 *
 * Full LGPL License: <http://www.gnu.org/licenses/lgpl.txt>
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Meebey.SmartIrc4net
{
    public class NonRfcChannel : Channel
    {
        internal NonRfcChannel(string name) : base(name)
        {
        }

#if LOG4NET
        ~NonRfcChannel()
        {
            Logger.ChannelSyncing.Debug("NonRfcChannel ("+Name+") destroyed");
        }
#endif

        public Dictionary<string, NonRfcChannelUser> Owners => UnsafeOwners.ToDictionary(item => item.Key, item => item.Value);
        internal ConcurrentDictionary<string, NonRfcChannelUser> UnsafeOwners { get; } = new ConcurrentDictionary<string, NonRfcChannelUser>(StringComparer.OrdinalIgnoreCase);

        public Dictionary<string, NonRfcChannelUser> ChannelAdmins => UnsafeChannelAdmins.ToDictionary(item => item.Key, item => item.Value);
        internal ConcurrentDictionary<string, NonRfcChannelUser> UnsafeChannelAdmins { get; } = new ConcurrentDictionary<string, NonRfcChannelUser>(StringComparer.OrdinalIgnoreCase);

        public Dictionary<string, NonRfcChannelUser> Halfops => UnsafeHalfops.ToDictionary(item => item.Key, item => item.Value);
        internal ConcurrentDictionary<string, NonRfcChannelUser> UnsafeHalfops { get; } = new ConcurrentDictionary<string, NonRfcChannelUser>(StringComparer.OrdinalIgnoreCase);
    }
}

/**
 * $Id$
 * $URL$
 * $Rev$
 * $Author$
 * $Date$
 *
 * Copyright (c) 2003-2004 Mirco 'meebey' Bauer <mail@meebey.net> <http://www.meebey.net>
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

namespace Meebey.SmartIrc4net
{
    public delegate void IrcEventHandler(object sender, IrcEventArgs e);
    public delegate void ActionEventHandler(object sender, ActionEventArgs e);
    public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);
    public delegate void PingEventHandler(object sender, PingEventArgs e);
    public delegate void KickEventHandler(object sender, KickEventArgs e);
    public delegate void JoinEventHandler(object sender, JoinEventArgs e);
    public delegate void NamesEventHandler(object sender, NamesEventArgs e);
    public delegate void PartEventHandler(object sender, PartEventArgs e);
    public delegate void InviteEventHandler(object sender, InviteEventArgs e);
    public delegate void OpEventHandler(object sender, OpEventArgs e);
    public delegate void DeopEventHandler(object sender, DeopEventArgs e);
    public delegate void VoiceEventHandler(object sender, VoiceEventArgs e);
    public delegate void DevoiceEventHandler(object sender, DevoiceEventArgs e);
    public delegate void BanEventHandler(object sender, BanEventArgs e);
    public delegate void UnbanEventHandler(object sender, UnbanEventArgs e);
    public delegate void TopicEventHandler(object sender, TopicEventArgs e);
    public delegate void TopicChangeEventHandler(object sender, TopicChangeEventArgs e);
    public delegate void NickChangeEventHandler(object sender, NickChangeEventArgs e);
    public delegate void QuitEventHandler(object sender, QuitEventArgs e);
    public delegate void WhoEventHandler(object sender, WhoEventArgs e);
}
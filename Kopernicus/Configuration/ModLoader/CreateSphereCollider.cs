﻿/**
 * Kopernicus Planetary System Modifier
 * Copyright (C) 2014 Bryce C Schroeder (bryce.schroeder@gmail.com), Nathaniel R. Lewis (linux.robotdude@gmail.com)
 * 
 * http://www.ferazelhosting.net/~bryce/contact.html
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2014 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;
using UnityEngine;

namespace Kopernicus
{
	namespace Configuration
	{
		namespace ModLoader
		{
			[RequireConfigType(ConfigType.Node)]
			public class CreateSphereCollider : ModLoader, IParserEventSubscriber
			{
				// Actual PQS mod we are loading
				private PQSMod_CreateSphereCollider _mod;

                // radiusOffset
                [ParserTarget("radiusOffset", optional = false)]
                private NumericParser<float> radiusOffset
                {
                    set { _mod.radiusOffset = value.value; }
                }

				void IParserEventSubscriber.Apply(ConfigNode node)
				{
                   
				}

				void IParserEventSubscriber.PostApply(ConfigNode node)
				{

				}

                public CreateSphereCollider()
				{
					// Create the base mod
                    GameObject modObject = new GameObject("CreateSphereCollider");
					modObject.transform.parent = Utility.Deactivator;
                    _mod = modObject.AddComponent<PQSMod_CreateSphereCollider>();
					base.mod = _mod;
				}
			}
		}
	}
}


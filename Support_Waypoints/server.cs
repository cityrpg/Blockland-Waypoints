function servercmdcom_pong(%c,%x)
{
	if(%x == %c.confirmationNum)
	{
		echo("   " @ %c SPC %c.getPlayerName() SPC "- This player has the power! Giving them the guidance...");
		%c.compassEnabled = 1;
		for(%i=0;%i<$ServerWaypoints;%i++)
		{
			commandtoclient(%c,'com_addwaypoint',$ServerWaypoint[%i]);
		}
	}
}
package CompassServer
{
	function GameConnection::loadMission(%c,%a,%b,%d,%e,%f)
	{
		Parent::loadMission(%c,%a,%b,%d,%e,%f);
		%c.confirmationNum = getRandom(0,100);
		commandtoclient(%c,'com_ping',%c.confirmationNum);
	}
};
ActivatePackage(CompassServer);
function servercmdcom_addserverwaypoint(%c,%name)
{
	if(%c.isAdmin)
	{
		if(isObject(%c.player))
		{
			%pos = %c.player.getTransform();
			%pos = getword(%pos,0) SPC getword(%pos,1);
			%f = -1;
			for(%i=0;%i<$ServerWaypoints;%i++)
			{
				if(getword($ServerWaypoint[%i],0) $= %name)
				{
					$ServerWaypoint[%i] = %name SPC %pos;
					%index = %i;
					%f = 1;
					break;
				}
			}
			if(%f < 0)
			{
				$ServerWaypoint[$ServerWaypoints] = %name SPC %pos;
				%index = $ServerWaypoints;
				$ServerWaypoints++;
			}
			for(%i=0;%i<ClientGroup.getCount();%i++)
			{
				%cl = ClientGroup.getObject(%i);
				if(%cl.compassEnabled)
				{
					commandtoclient(%cl,'com_addwaypoint',$ServerWaypoint[%index]);
				}
			}
		}
	}
}
function servercmdcom_remserverwaypoint(%c,%name)
{
	if(%c.isAdmin)
	{
		for(%i=0;%i<$ServerWaypoints;%i++)
		{
			%check = getword($ServerWaypoint[%i],0);
			if(%check $= %name)
			{
				for(%x=0;%x<ClientGroup.getCount();%x++)
				{
					%cl = ClientGroup.getObject(%x);
					if(%cl.compassEnabled)
					{
						commandtoclient(%cl,'com_remwaypoint',%name);
					}
				}
				%f = 1;
			}
			if(%f)
			{
				$ServerWaypoint[%i] = $ServerWaypoint[%i+1];
			}
		}
	}
}
function servercmdcom_clearwaypoints(%c)
{
	if(%c.isAdmin)
	{
		for(%i=0;%i<$ServerWaypoints;%i++)
		{
			%name = getword($ServerWaypoint[%i],0);
			servercmdcom_remserverwaypoint(%c,%name);
		}
	}
}
function servercmdcom_loadwaypoint(%c,%str)
{
	if(%c.isAdmin)
	{
		$ServerWaypoint[$ServerWaypoints] = %str;
		$ServerWaypoints++;
	}
}
//Events
function fxDTSbrick::setWaypoint(%brick,%name,%bool,%client)
{
	if(%client.compassEnabled)
	{
		if(!%bool)
		{
			%name = strreplace(%name," ","-");
			for(%i=0;%i<$ServerWaypoints;%i++)
			{
				if(getword($ServerWaypoint[%i],0) $= %name)
				{
					return;
				}
			}
			%pos = %brick.getTransform();
			%x = getword(%pos,0);
			%y = getword(%pos,1);
			commandtoclient(%client,'com_addwaypoint',%name SPC %x SPC %y,1);
			commandtoclient(%client,'centerprint',"\c6A brick attempted to add or update a waypoint on your compass:\n\c3" @ strreplace(%name,"-"," "),3);
		} else {
			%name = strreplace(%name," ","-");
			for(%i=0;%i<$ServerWaypoints;%i++)
			{
				if(getword($ServerWaypoint[%i],0) $= %name)
				{
					return;
				}
			}
			commandtoclient(%client,'com_remwaypoint',%name,1);
			commandtoclient(%client,'centerprint',"\c6A brick attempted to remove a waypoint from your compass:\n\c3" @ strreplace(%name,"-"," "),3);
		}
	} else {
		commandtoclient(%client,'centerprint',"\c6A brick attempted to edit waypoints on your compass:\n\c0You do not seem to have the compass enabled.",3);
	}
}
registerOutputEvent(fxDTSBrick,"setWaypoint","string 32 200\tbool",1);

if(!$CompassInitiated)
{
	$TrackWaypoints = 1;
	new GUISwatchCtrl(CompassH) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "bottom";
		position = "32 32";
		extent = "120 120";
		minExtent = "8 2";
		visible = "0";
		color = "0 0 0 0";

		new GuiBitmapCtrl(CompassH_IMG) {
			profile = "GuiDefaultProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "19 19";
			extent = "64 64";
			minExtent = "8 2";
			visible = "1";
			bitmap = "./Compass";
			wrap = "0";
			lockAspectRatio = "0";
			alignLeft = "0";
			overflowImage = "0";
			keepCached = "0";
		};
		new GuiTextCtrl(CompassH_N) {
			profile = "BlockChatTextSize3Profile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "320 240";
			extent = "16 22";
			minExtent = "8 2";
			visible = "1";
			text = "\c6N";
			maxLength = "255";
		};
	};
	new GuiControl(CompassWaypointGUI) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "bottom";
		position = "0 0";
		extent = "640 480";
		minExtent = "8 2";
		visible = "1";

		new GuiWindowCtrl(CompassWaypointGUI_Frame) {
			profile = "GuiWindowProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "140 100";
			extent = "249 350";
			minExtent = "8 2";
			visible = "1";
			text = "Waypoints";
			maxLength = "255";
			resizeWidth = "0";
			resizeHeight = "0";
			canMove = "0";
			canClose = "1";
			canMinimize = "0";
			canMaximize = "0";
			minSize = "50 50";
			closeCommand = "canvas.popDialog(CompassWaypointGUI);";

			new GuiSwatchCtrl() {
				profile = "GuiDefaultProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "7 29";
				extent = "234 305";
				minExtent = "8 2";
				visible = "1";
				color = "0 21 23 64";
			};
			new GuiScrollCtrl(CompassWaypointGUI_Scroll) {
				profile = "ColorScrollProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "6 29";
				extent = "235 305";
				minExtent = "8 2";
				visible = "1";
				willFirstRespond = "1";
				hScrollBar = "alwaysOff";
				vScrollBar = "alwaysOn";
				constantThumbHeight = "0";
				childMargin = "0 0";
				rowHeight = "40";
				columnWidth = "30";

				new GuiTextListCtrl(CompassWaypointGUI_List) {
					profile = "GuiTextListProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "0 0";
					extent = "223 2";
					minExtent = "8 2";
					visible = "1";
					altcommand = "compassWaypointGUI.setTracked();";
					enumerate = "0";
					resizeCell = "1";
					columns = "0";
					fitParentWidth = "1";
					clipColumnText = "0";
				};
			};
			new GuiBitmapButtonCtrl(CompassWaypointGUI_BTN_Update) {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "151 323";
				extent = "54 21";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.updateWaypoint();";
				text = "Update";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button2";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
			new GuiBitmapButtonCtrl(CompassWaypointGUI_BTN_Remove) {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "87 323";
				extent = "62 21";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.removeWaypoint();";
				text = "Remove";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button2";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
			new GuiBitmapButtonCtrl(CompassWaypointGUI_BTN_Add) {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "31 323";
				extent = "54 21";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.addWaypoint();";
				text = "<< Add";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button2";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
			new GuiCheckBoxCtrl(CompassWaypointGUI_Compass) {
				profile = "GuiCheckBoxProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "228 326";
				extent = "15 30";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.setCompass();";
				groupNum = "-1";
				buttonType = "ToggleButton";
			};
			new GuiBitmapButtonCtrl() {
				profile = "GuiDefaultProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "216 336";
				extent = "10 10";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.saveLoad();";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "./file";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
		};
	};
	new GuiControl(CompassWaypointGUI_Add) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "bottom";
		position = "0 0";
		extent = "640 480";
		minExtent = "8 2";
		visible = "1";

		new GuiWindowCtrl(CompassWaypointGUI_Add_Frame) {
			profile = "GuiWindowProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "150 122";
			extent = "200 85";
			minExtent = "8 2";
			visible = "1";
			text = "Add Waypoint...";
			maxLength = "255";
			resizeWidth = "0";
			resizeHeight = "0";
			canMove = "0";
			canClose = "1";
			canMinimize = "0";
			canMaximize = "0";
			minSize = "50 50";
			closeCommand = "canvas.popDialog(CompassWaypointGUI_Add);";

			new GuiTextCtrl() {
				profile = "GuiTextProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "11 33";
				extent = "27 18";
				minExtent = "8 2";
				visible = "1";
				text = "Name";
				maxLength = "255";
			};
			new GuiTextEditCtrl(CompassWaypointGUI_Add_Name) {
				profile = "GuiTextEditProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "43 33";
				extent = "146 18";
				minExtent = "8 2";
				visible = "1";
				altCommand = "CompassWaypointGUI.addWaypointF(CompassWaypointGUI_Add_Name.getValue(),CompassWaypointGUI_Add_Server.getValue());";
				maxLength = "255";
				historySize = "0";
				password = "0";
				tabComplete = "0";
				sinkAllKeyEvents = "0";
			};
			new GuiBitmapButtonCtrl() {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "97 55";
				extent = "80 19";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.addWaypointF(CompassWaypointGUI_Add_Name.getValue(),CompassWaypointGUI_Add_Server.getValue());";
				text = "Add";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button1";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
			new GuiBitmapButtonCtrl() {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "9 55";
				extent = "80 19";
				minExtent = "8 2";
				visible = "1";
				command = "canvas.pushDialog(CompassWaypointGUI); canvas.popDialog(CompassWaypointGUI_Add);";
				text = "Cancel";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button1";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
			new GuiCheckBoxCtrl(CompassWaypointGUI_Add_Server) {
				profile = "GuiCheckBoxProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "180 50";
				extent = "13 30";
				minExtent = "8 2";
				visible = "1";
				groupNum = "-1";
				buttonType = "ToggleButton";
			};
		};
	};
	new GuiControl(CompassWaypointGUI_File) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "bottom";
		position = "0 0";
		extent = "640 480";
		minExtent = "8 2";
		visible = "1";

		new GuiWindowCtrl(CompassWaypointGUI_File_Frame) {
			profile = "GuiWindowProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "264 135";
			extent = "200 85";
			minExtent = "8 2";
			visible = "1";
			text = "Files...";
			maxLength = "255";
			resizeWidth = "0";
			resizeHeight = "0";
			canMove = "0";
			canClose = "1";
			canMinimize = "0";
			canMaximize = "0";
			minSize = "50 50";
			closeCommand = "canvas.popDialog(CompassWaypointGUI_File);";

			new GuiTextEditCtrl(CompassWaypointGUI_File_Filename) {
				profile = "GuiTextEditProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "11 32";
				extent = "177 18";
				minExtent = "8 2";
				visible = "1";
				altcommand = "CompassWaypointGUI.saveWaypoints(CompassWaypointGUI_File_Filename.getValue());";
				maxLength = "255";
				historySize = "0";
				password = "0";
				tabComplete = "0";
				sinkAllKeyEvents = "0";
			};
			new GuiBitmapButtonCtrl() {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "129 55";
				extent = "60 19";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.saveWaypoints(CompassWaypointGUI_File_Filename.getValue());";
				text = "Save";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button2";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
			new GuiBitmapButtonCtrl() {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "11 55";
				extent = "60 19";
				minExtent = "8 2";
				visible = "1";
				command = "CompassWaypointGUI.loadWaypoints(CompassWaypointGUI_File_Filename.getValue());";
				text = "Load";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button2";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
			new GuiBitmapButtonCtrl() {
				profile = "BlockButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "75 55";
				extent = "50 19";
				minExtent = "8 2";
				visible = "1";
				command = "canvas.pushDialog(CompassWaypointGUI); canvas.popDialog(CompassWaypointGUI_File);";
				text = "Back";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button2";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "255 255 255 255";
			};
		};
	};
	playGui.add(CompassH);
	$remapDivision[$remapCount] = "Compass";
	$remapName[$remapCount] = "Toggle Compass";
	$remapCmd[$remapCount] = "Compass_Toggle";
	$remapCount++;
	$remapName[$remapCount] = "Waypoint GUI";
	$remapCmd[$remapCount] = "Compass_WaypointGUI";
	$remapCount++;
	$CompassInitiated = 1;
	Compass_ExteriorInit();
}

function Compass_ExteriorInit()
{
	//This function is for other mods that want to do stuff with this.
}

package CompassClient
{
	function disconnect(%a)
	{
		Parent::disconnect(%a);
		for(%i=0;%i<$TrackWaypoints;%i++)
		{
			$TrackWaypointDot[%i].delete();
			$TrackWaypoint[%i] = "";
			$TrackWaypointDot[%i] = "";
		}
		$TrackWaypoints = 1;
		$CompassServer = 0;
	}

	function clientcmdchatmessage(%client,%a,%b,%taggedString,%pretag,%name,%posttag,%message,%i)
	{
		Parent::clientcmdchatmessage(%client,%a,%b,%taggedString,%pretag,%name,%posttag,%message,%i);
		if(getWord(%message,0) $= "+WPSHARE")
		{
			%point = getwords(%message,1);
			%pos = getwords(%point,1);
			%name = getword(%point,0);
			for(%i=0;%i<$TrackWaypoints;%i++)
			{
				if(getwords($TrackWaypoint[%i],1) $= %pos || getword($TrackWaypoint[%i],0) $= %name)
				{
					return;
				}
			}
			$ClientAddPoint = 1;
			clientcmdcom_addwaypoint(%point);
			$ClientAddPoint = 0;
		}
	}

	function NMH_Type::send(%this)
	{
		%txt = %this.getValue();
		if(getword(%txt,0) $= "+WPSHARE")
		{
			%name = getwords(%txt,1);
			for(%i=0;%i<getwordcount(%name);%i++)
			{

				if(getword(%name,%i) $= "+")
				{
					%newname = getwords(%name,%i+1);
					%name = getwords(%name,0,%i-1);
					break;
				}
			}
			%name = strreplace(%name," ","-");
			if(%newname !$= "")
			{
				%newname = strreplace(%newname," ","-");
			}
			for(%i=0;%i<$TrackWaypoints;%i++)
			{
				if(getword($TrackWaypoint[%i],0) $= %name)
				{
					%name = getword($TrackWaypoint[%i],0);
					if(!$TrackWaypointClient[%i])
					{
						NewChatSO.addLine("\c0The waypoint \c2" @ strreplace(%name,"-"," ") SPC "\c0is a serverside waypoint, and cannot be shared.");
						canvas.popDialog(NewMessageHud);
						return;
					}
					%f = 1;
					%pos = getwords($TrackWaypoint[%i],1);
				}
			}
			if(%f)
			{
				if(%newname !$= "")
				{
					%txt = "+WPShare" SPC %newname SPC %pos;
				} else {
					%txt = "+WPShare" SPC %name SPC %pos;
				}
				%this.setValue(%txt);
			} else {
				NewChatSO.addLine("\c0No waypoint was found using the name\c2" SPC strreplace(%name,"-"," ") @ "\c0.");
				canvas.popDialog(NewMessageHud);
				return;
			}
		}
		Parent::send(%this);
	}
};

ActivatePackage(CompassClient);
$pi = 3.14159;

function Compass_Update()
{
	if(!isObject(serverconnection))
	{
		return;
	}

	if(!isobject(serverconnection.getcontrolobject()) || !$Compass::Show)
	{
		CompassH.setVisible(0);
		return;
	}

	%r=serverconnection.getcontrolobject().gettransform();
	%rx = getword(%r, 0);
	%ry = getword(%r, 1);
	%r= 2 * $pi - (getword(%r,5) * getword(%r,6));
	%rootcos=mcos(%r);
	%rootsin=msin(%r);
	%compassposx = getword(CompassH_IMG.position, 0) + (getword(CompassH_IMG.extent, 0) / 2);
	%compassposy = getword(CompassH_IMG.position, 1) + (getword(CompassH_IMG.extent, 1) / 2);
	%compassNtxtsizex=16/2;
	%compassNtxtsizey=36/2;
	CompassH_N.resize((45 * mcos(%r + $pi * 1.5) + %compassposx ) - %compassNtxtsizex, (45 * msin(%r + $pi * 1.5) + %compassposy) - %compassNtxtsizey, 25, 36);

	for(%i=1;%i<$TrackWaypoints;%i++)
	{
		%px = %rx - getword($TrackWaypoint[%i],1);
		%py = %ry - getword($TrackWaypoint[%i],2);
		%pdist = msqrt((%py * %py) + (%px * %px));

		if(!isObject($TrackWaypointDot[%i]))
		{
			$TrackWaypointDot[%i] = new GuiTextCtrl() {
				profile = "BlockChatTextSize10Profile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "320 240";
				extent = "8 36";
				minExtent = "8 2";
				visible = "1";
				text = "\c2.";
				maxLength = "255";
			};
			CompassH.add($TrackWaypointDot[%i]);
		}
		$TrackWaypointDot[%i].resize((25 * mcos(matan(%py, %px) - %r + $pi) * (-1 * mpow(1.07, (%pdist * -0.2)) + 1) + %compassposx) - 4, (25 * msin(matan(%py, %px) - %r) * (-1 * mpow(1.07, (%pdist * -0.2)) + 1) + %compassposy) - 26, 25, 36);
	}
	$CompassUpdate = schedule(50,0,Compass_Update);
}

function Compass_Toggle(%x)
{
	if(%x)
	{
		$Compass::Show = !$Compass::Show;
		if($Compass::Show)
		{
			CompassH.position = (getword(playgui.extent,0)-128) SPC (getword(playgui.extent,1)-256);
			CompassH.setVisible(1);
			Compass_Update();
		} else {
			cancel($CompassUpdate);
			CompassH.setVisible(0);
		}
	}
}

function Compass_WaypointGui(%x)
{
	if(%x)
	{
		if(CompassWaypointGUI.isAwake())
		{
			canvas.popDialog(CompassWaypointGUI);
		} else {
			canvas.pushDialog(CompassWaypointGUI);
		}
	}
}

function clientcmdcom_addwaypoint(%str,%evented)
{
	%name = getword(%str,0);

	if(strpos(%name,"+") != -1)
	{
		return;
	}

	%pos = getwords(%str,1);

	for(%i=1;%i<$TrackWaypoints;%i++)
	{
		if(getword($TrackWaypoint[%i],0) $= %name)
		{
			if(%evented && $TrackWaypointClient[%i])
			{
				return;
			}
			$TrackWaypoint[%i] = %name SPC %pos;
			%found = 1;
		}
	}

	if(!%found)
	{
		$TrackWaypointClient[$TrackWaypoints] = $ClientAddPoint;
		$TrackWaypointEvent[$TrackWaypoints] = %evented;
		$TrackWaypoint[$TrackWaypoints] = %name SPC %pos;
		$TrackWaypointDot[$TrackWaypoints] = new GuiTextCtrl() {
			profile = "BlockChatTextSize10Profile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "320 240";
			extent = "8 36";
			minExtent = "8 2";
			visible = "1";
			text = "\c2.";
			maxLength = "255";
		};
		CompassH.add($TrackWaypointDot[$TrackWaypoints]);
		$TrackWaypoints++;
	}

	if(CompassWaypointGUI.isAwake())
	{
		CompassWaypointGUI.refreshList();
	}
}
function clientcmdcom_remwaypoint(%name,%evented)
{
	for(%i=1;%i<$TrackWaypoints;%i++)
	{
		if(getword($TrackWaypoint[%i],0) $= %name)
		{
			if(%evented && $TrackWaypointClient[%i])
			{
				return;
			}
			%found = 1;
			CompassH.remove($TrackWaypointDot[%i]);
			$TrackWaypointDot[%i].delete();
		}

		if(%found)
		{
			$TrackWaypoint[%i] = $TrackWaypoint[%i+1];
			$TrackWaypointDot[%i] = $TrackWaypointDot[%i+1];
			$TrackWaypointClient[%i] = $TrackWaypointClient[%i+1];
		}
	}

	if(%found)
	{
		$TrackWaypoints--;
	}

	if(CompassWaypointGUI.isAwake())
	{
		CompassWaypointGUI.refreshList();
	}
}

function CompassWaypointGUI::onWake(%gui)
{
	CompassWaypointGUI_Frame.position = getword(PlayGUI.extent,0) - (getword(CompassWaypointGUI_Frame.extent,0) + 72) SPC 12;
	CompassWaypointGUI_Compass.setValue($Compass::Show);
	CompassWaypointGUI.refreshList();
}

function CompassWaypointGUI_Add::onWake(%gui)
{
	%pos = CompassWaypointGUI_Frame.position;
	CompassWaypointGUI_Add_Name.setValue("");
	CompassWaypointGUI_Add_Frame.position = getWord(%pos,0) + 25 SPC getword(%pos,1) + 16;
}

function CompassWaypointGUI_File::onWake(%gui)
{
	%pos = CompassWaypointGUI_Frame.position;
	CompassWaypointGUI_File_Filename.setValue("");
	CompassWaypointGUI_File_Frame.position = getword(%pos,0) + 25 SPC getword(%pos,1) + 16;
}

function CompassWaypointGUI::refreshList(%gui)
{
	CompassWaypointGUI_List.clear();
	CompassWaypointGUI_List.addRow(1,"None");
	for(%i=1;%i<$TrackWaypoints;%i++)
	{
		if($TrackWaypointClient[%i])
		{
			%ss = "";
		} else {
			%ss = "*";
		}
		if($TrackWaypointEvent[%i])
		{
			%ss = "**";
		}
		CompassWaypointGUI_List.addRow(%i+1,strreplace(getword($TrackWaypoint[%i],0),"-"," ") SPC %ss);
	}
	CompassWaypointGUI_BTN_Add.setActive(1);
	CompassWaypointGUI_BTN_Remove.setActive(1);
	CompassWaypointGUI_BTN_Update.setActive(1);
}

function CompassWaypointGUI::onSleep(%gui)
{
	%gui.setCompass();
}

function CompassWaypointGUI::setCompass(%gui)
{
	$Compass::Show = CompassWaypointGUI_Compass.getValue();
	if($Compass::Show)
	{
		CompassH.position = (getword(playgui.extent,0)-128) SPC (getword(playgui.extent,1)-256);
		CompassH.setVisible(1);
		Compass_Update();
	} else {
		cancel($CompassUpdate);
		CompassH.setVisible(0);
	}
}

function CompassWaypointGUI::setTracked(%gui)
{
	%id = CompassWaypointGUI_List.getSelectedID();

	if(isObject($TrackWaypointDot[$TrackedPoint]))
	{
		$TrackWaypointDot[$TrackedPoint].setText("\c2.");
	}

	if(%id == 1)
	{
		return;
	}

	$TrackedPoint = %id - 1;
	$TrackWaypointDot[%id - 1].setText("\c0.");
}

function CompassWaypointGUI::addWaypoint(%gui)
{
	canvas.pushDialog(CompassWaypointGUI_Add);
	canvas.popDialog(CompassWaypointGUI);
}

function CompassWaypointGUI::updateWaypoint(%gui)
{
	%id = CompassWaypointGUI_List.getSelectedID() - 1;
	if($TrackWaypointClient[%id])
	{
		%pos = ServerConnection.getControlObject().getTransform();
		%x = getword(%pos,0);
		%y = getword(%pos,1);
		$TrackWaypoint[%id] = getword($TrackWaypoint[%id],0) SPC %x SPC %y;
	} else {
		if($CompassServer)
		{
			commandtoserver('com_addserverwaypoint',getword($TrackWaypoint[%id],0));
		}
	}
	CompassWaypointGUI.refreshList();
}

function CompassWaypointGUI::removeWaypoint(%gui)
{
	%id = CompassWaypointGUI_List.getSelectedID() - 1;

	if($TrackWaypointClient[%id])
	{
		clientcmdcom_remwaypoint(getword($TrackWaypoint[%id],0));
	} else {
		commandtoserver('com_remserverwaypoint',getword($TrackWaypoint[%id],0));
	}

	CompassWaypointGUI.refreshList();
}

function CompassWaypointGUI::addWaypointF(%gui,%name,%server)
{
	canvas.popDialog(CompassWaypointGUI_Add);
	%name = strreplace(%name," ","-");

	if(%server)
	{
		if($CompassServer)
		{
			commandtoserver('com_addserverwaypoint',%name);
		}
		canvas.pushDialog(CompassWaypointGUI);
	} else {
		for(%i=1;%i<$TrackWaypoints;%i++)
		{
			if(getword($TrackWaypoint[%i],0) $= %name)
			{
				if(!$TrackWaypointClient[%i])
				{
					commandtoserver('com_addserverwaypoint',%name);
					canvas.pushDialog(CompassWaypointGUI);
					return;
				}
			}
		}

		$ClientAddPoint = 1;
		%pos = ServerConnection.getControlObject().getTransform();
		%x = getword(%pos,0);
		%y = getword(%pos,1);
		clientcmdcom_addwaypoint(%name SPC %x SPC %y);
		$ClientAddPoint = 0;
		canvas.pushDialog(CompassWaypointGUI);
	}
}

function CompassWaypointGUI::saveLoad(%gui)
{
	canvas.popDialog(CompassWaypointGUI);
	canvas.pushDialog(CompassWaypointGUI_File);
}

function CompassWaypointGUI::saveWaypoints(%gui,%filename)
{
	%filename = "config/client/WP/" @ filebase(%filename) @ ".txt";
	%FO = new FileObject();
	if(%FO.openForWrite(%filename))
	{
		for(%i=1;%i<$TrackWaypoints;%i++)
		{
			if($TrackWaypointEvent[%i])
			{
				continue;
			}
			%FO.writeline($TrackWaypointClient[%i] SPC $TrackWaypoint[%i]);
		}
		%FO.close();
	}
	%FO.delete();
	canvas.popDialog(CompassWaypointGUI_File);
	canvas.pushDialog(CompassWaypointGUI);
}

function CompassWaypointGUI::loadWaypoints(%gui,%filename)
{
	%filename = "config/client/WP/" @ filebase(%filename) @ ".txt";
	%FO = new FileObject();

	if(%FO.openForRead(%filename))
	{
		for(%i=1;%i<$TrackWaypoints;%i++)
		{
			$TrackWaypointDot[%i].delete();
			$TrackWaypointDot[%i] = "";
			$TrackWaypoint[%i] = "";
		}

		$TrackWaypoints = 1;

		if($CompassServer)
		{
			commandtoserver('com_clearwaypoints');
		}

		while(!%FO.isEOF())
		{
			%line = %FO.readline();
			%server = getword(%line,0);
			%waypoint = getwords(%line,1);

			if(!%server)
			{
				if($CompassServer)
				{
					commandtoserver('com_loadwaypoint',%waypoint);
				}
			} else {
				$ClientAddPoint = 1;
				clientcmdcom_addwaypoint(%waypoint);
				$ClientAddPoint = 0;
			}
		}

		%FO.close();
	}

	%FO.delete();
	
	canvas.popDialog(CompassWaypointGUI_File);
	canvas.pushDialog(CompassWaypointGUI);
}

function clientcmdcom_ping(%x)
{
	echo("   " @ %x SPC "Compass - You have the power! Telling the server you have the power...");
	commandtoserver('com_pong',%x);
	$CompassServer = 1;
}

<?xml version="1.0" encoding="UTF-8" ?>
<Package name="PepperCustomBasicChannel" format_version="4">
    <Manifest src="manifest.xml" />
    <BehaviorDescriptions>
        <BehaviorDescription name="behavior" src="CustomBasicChanel" xar="behavior.xar" />
        <BehaviorDescription name="behavior" src="RaiseLeftArm" xar="behavior.xar" />
    </BehaviorDescriptions>
    <Dialogs>
        <Dialog name="ExampleDialog" src="CustomBasicChanel/ExampleDialog/ExampleDialog.dlg" />
    </Dialogs>
    <Resources>
        <File name="Acceture" src="html/Acceture.jpg" />
        <File name="icon" src="icon.png" />
    </Resources>
    <Topics>
        <Topic name="ExampleDialog_enu" src="CustomBasicChanel/ExampleDialog/ExampleDialog_enu.top" topicName="" language="C" />
    </Topics>
    <IgnoredPaths>
        <Path src=".metadata" />
    </IgnoredPaths>
</Package>

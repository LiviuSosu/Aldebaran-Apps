<?xml version="1.0" encoding="UTF-8" ?>
<Package name="Interaction" format_version="4">
    <Manifest src="manifest.xml" />
    <BehaviorDescriptions>
        <BehaviorDescription name="behavior" src="handshake" xar="behavior.xar" />
        <BehaviorDescription name="behavior" src="GrabObject" xar="behavior.xar" />
    </BehaviorDescriptions>
    <Dialogs />
    <Resources>
        <File name="RandomSentences" src="handshake/lib/RandomSentences.py" />
    </Resources>
    <Topics />
    <IgnoredPaths>
        <Path src=".metadata" />
    </IgnoredPaths>
</Package>

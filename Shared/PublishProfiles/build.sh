#!/bin/sh

# This script needs to be run from its own directory!

# Build all the programs on all the publish profiles if ran without arguments.
# Or build only the publish profile supplied as argument (e.g: build.sh SelfContained__win_x64)
# The built programs are placed in <solution root>\Release.

output() {
	echo "$(tput setaf "$1")$2$(tput sgr0)"
}

publish() {
	mkdir -p ../../M80/Properties/PublishProfiles && cp $1.pubxml ../../M80/Properties/PublishProfiles/
	mkdir -p ../../L80/Properties/PublishProfiles && cp $1.pubxml ../../L80/Properties/PublishProfiles/
	mkdir -p ../../LIB80/Properties/PublishProfiles && cp $1.pubxml ../../LIB80/Properties/PublishProfiles/
	dotnet publish ../../M80dotNet.sln /p:PublishProfile=$1 /p:DebugType=None -c Release
}

banner() {
	echo
	output 6 "----- $1 -----"
	echo
}

set -e

if [ -z "$(which dotnet > /dev/null && dotnet --list-sdks | grep ^3.1.)" ]; then
	output 1 "*** .NET SDK 3.1 is not installed! See https://docs.microsoft.com/dotnet/core/install/linux"
	exit 1
fi

if [ -z "$1" ]; then
		for PROFILE in $(find . -type f -name "*.pubxml" -exec basename {} .pubxml ';')
		do
			banner $PROFILE
			publish $PROFILE
		done
	else
		if [ -f "$1.pubxml" ]; then
			banner $1
			publish $1
		else
			output 1 "*** $1: profile not found!"
			exit 1
		fi
fi

rm -f ../../Release/Portable/*.exe rm -rf ../../Release/Portable/?80 rm -rf ../../Release/Portable/LIB80

echo
output 3 "Build succeeded!"

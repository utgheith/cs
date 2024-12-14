#!/bin/bash  -e

function on_exit {
   echo "done"
}

trap on_exit EXIT

mkdir -p ~/.biso

CS_BIN=~/.biso/cs

URL="https://github.com/coursier/launchers/raw/master/cs-x86_64-pc-linux.gz"

test -f $CS_BIN || (curl -fL $URL | gzip -d > $CS_BIN)
test -x $CS_BIN || chmod +x $CS_BIN

exec $CS_BIN "$@"



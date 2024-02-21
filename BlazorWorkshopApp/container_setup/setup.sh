#!/bin/sh
echo "Running Setup Script...."
exec nginx -g 'daemon off;' &
echo "Finished running script"
tail -F anything
echo "Finished running script"
tail -F anything
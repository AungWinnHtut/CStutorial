#!/usr/bin/env bash

cd $( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

mkdir -p build
cd build
cmake ..
make
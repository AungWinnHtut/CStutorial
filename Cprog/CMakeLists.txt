cmake_minimum_required(VERSION 3.22)
project(Cprog)

set(CMAKE_CXX_STANDARD 14)

include_directories(AdventureGame/src)
include_directories(HelloWorld/HelloWorld)

add_executable(Cprog
        2022020801PhotoAlbum/2022020801PhotoAlbum/2022020801PhotoAlbum.cpp
        AdvantureGold/AdvantureGold/game1.cpp
        AdventureGame/src/game.hpp
        AdventureGame/src/game_external.cpp
        AdventureGame/src/game_main.cpp
        AdventureGame/src/game_mapgen.cpp
        AdventureGame/src/game_menu.cpp
        AdventureGame/src/game_view.cpp
        AdventureGame/src/main.cpp
        AdventureGame/src/texts.hpp
        AdventureGame/src/utils.hpp
        AdventureGame/src/utils_general.cpp
        AdventureGame/src/utils_menu.cpp
        AdventureGame/src/utils_rng.cpp
        AdventureGame/src/utils_terminal.cpp
        AofCircles/AofCircles/functions.cpp
        AofCircles/AofCircles/Source.cpp
        BoxStructure/BoxStructure/Source.cpp
        Data1/Data1/Data1.cpp
        Data1/Data1/oldversion1.cpp
        ERRtest/ERRtest/Source.cpp
        FileIO/FileIO/FileIO.cpp
        FileIOw/FileIOw/Source.cpp
        "Hello World/Hello World/Source.cpp"
        HelloWorld/HelloWorld/Area.cpp
        HelloWorld/HelloWorld/Area.h
        HelloWorld/HelloWorld/Source.cpp
        Project1/Project1/Source.cpp
        recursion/recursion/Source.cpp
        Structure.cpp/Structure.cpp/Source.cpp
        arduino.c)

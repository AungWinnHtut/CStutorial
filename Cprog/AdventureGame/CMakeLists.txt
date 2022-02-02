cmake_minimum_required(VERSION 3.22.1)

project(AdventureGame)
file(GLOB SOURCE_FILES "src/*.cpp" "src/*.hpp")
add_executable(${PROJECT_NAME} ${SOURCE_FILES})

#set_property(TARGET ${PROJECT_NAME} PROPERTY CMAKE_BUILD_TYPE Debug) # For debugging
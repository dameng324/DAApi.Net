# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.25

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Disable VCS-based implicit rules.
% : %,v

# Disable VCS-based implicit rules.
% : RCS/%

# Disable VCS-based implicit rules.
% : RCS/%,v

# Disable VCS-based implicit rules.
% : SCCS/s.%

# Disable VCS-based implicit rules.
% : s.%

.SUFFIXES: .hpux_make_needs_suffix_list

# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/bin/cmake

# The command to remove a file.
RM = /usr/bin/cmake -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/linux-build

# Include any dependencies generated for this target.
include CMakeFiles/DAApiWrapper.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include CMakeFiles/DAApiWrapper.dir/compiler_depend.make

# Include the progress variables for this target.
include CMakeFiles/DAApiWrapper.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/DAApiWrapper.dir/flags.make

CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o: CMakeFiles/DAApiWrapper.dir/flags.make
CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o: /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/swig_wrap.cxx
CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o: CMakeFiles/DAApiWrapper.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/linux-build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o -MF CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o.d -o CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o -c /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/swig_wrap.cxx

CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/swig_wrap.cxx > CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.i

CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/swig_wrap.cxx -o CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.s

# Object files for target DAApiWrapper
DAApiWrapper_OBJECTS = \
"CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o"

# External object files for target DAApiWrapper
DAApiWrapper_EXTERNAL_OBJECTS =

/mnt/c/Workspace/gitlab/DAApi.Net/src/DAApi.Net/runtimes/linux-x64/native/libDAApiWrapper.so: CMakeFiles/DAApiWrapper.dir/swig_wrap.cxx.o
/mnt/c/Workspace/gitlab/DAApi.Net/src/DAApi.Net/runtimes/linux-x64/native/libDAApiWrapper.so: CMakeFiles/DAApiWrapper.dir/build.make
/mnt/c/Workspace/gitlab/DAApi.Net/src/DAApi.Net/runtimes/linux-x64/native/libDAApiWrapper.so: CMakeFiles/DAApiWrapper.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/linux-build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX shared library /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApi.Net/runtimes/linux-x64/native/libDAApiWrapper.so"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/DAApiWrapper.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/DAApiWrapper.dir/build: /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApi.Net/runtimes/linux-x64/native/libDAApiWrapper.so
.PHONY : CMakeFiles/DAApiWrapper.dir/build

CMakeFiles/DAApiWrapper.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/DAApiWrapper.dir/cmake_clean.cmake
.PHONY : CMakeFiles/DAApiWrapper.dir/clean

CMakeFiles/DAApiWrapper.dir/depend:
	cd /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/linux-build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/linux-build /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/linux-build /mnt/c/Workspace/gitlab/DAApi.Net/src/DAApiWrapper/linux-build/CMakeFiles/DAApiWrapper.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/DAApiWrapper.dir/depend


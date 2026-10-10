#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"
EXPECTED_SWIG_VERSION="$(tr -d '\r\n' < "$SCRIPT_DIR/../../.swig-version")"
ACTUAL_SWIG_VERSION="$(swig -version | awk '/SWIG Version/ {print $3; exit}')"
if [[ "$ACTUAL_SWIG_VERSION" != "$EXPECTED_SWIG_VERSION" ]]; then
    echo "Error: Expected SWIG $EXPECTED_SWIG_VERSION but found $ACTUAL_SWIG_VERSION." >&2
    exit 1
fi

mkdir -p ../DAApi.Net/Swig/
swig -c++ -csharp -namespace DAApi.Net -outdir ../DAApi.Net/Swig/ swig.i
dotnet StripSwigDerivedChecks.cs -- --no-backup \
  "../DAApi.Net/Swig/IMarketEvent.cs" \
  "../DAApi.Net/Swig/IFutureEvent.cs" \
  "../DAApi.Net/Swig/IStockEvent.cs"
dotnet tool run csharpier format ../DAApi.Net/Swig

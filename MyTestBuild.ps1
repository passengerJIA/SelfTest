function Pack(){
    nuget restore .\SelfTestWebMVCKendo\SelfTestWebMVCKendo.csproj -PackagesDirectory .\packages
    $msbuild = "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\bin\MSBuild.exe"
    $colletionOfArgs = @(".\SelfTestWebMVCKendo\SelfTestWebMVCKendo.csproj","-p:configuration=release")
    & $msbuild $colletionOfArgs
}
Pack
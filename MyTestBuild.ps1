function Pack(){
    nuget restore .\SelfTest.sln
    nuget pack "SelfTestWebMVCKendo\SelfTestWebMVCKendo.csproj" -Build -Symbols -Properties Configuration=Release
}
Pack
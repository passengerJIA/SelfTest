function Pack(){
    nuget pack "SelfTestWebMVCKendo\SelfTestWebMVCKendo.csproj" -Build -Symbols -Properties Configuration=Release
}
Pack
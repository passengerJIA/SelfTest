function Pack(){
    $root = "."
    nuget pack "$root\SelfTestWebMVCKendo\SelfTestWebMVCKendo.csproj" -Build -Symbols -Properties Configuration=Release
}
Pack
using Linearstar.Windows.RawInput.Native;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KeySharp
{

  public class Devices
  {
    [JsonProperty("devices")]
    public List<Device> Items { get; set; }
  }


  public class Device
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("mappings")]
    public List<Mapping> Mappings { get; set; }
  }

  public class Mapping
  {
    [JsonProperty("key_code")]
    public int KeyCode { get; set; }

    [JsonProperty("map")]
    public string Map { get; set; }

    [JsonProperty("flag")]
    public RawKeyboardFlags Flag { get; set; }
  }

}

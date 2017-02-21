using Microsoft.Azure.Mobile.Server;

namespace ABCLeagueMSService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}
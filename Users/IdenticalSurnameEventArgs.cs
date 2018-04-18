using System;

namespace Users
{
  /// <summary>
  /// Args for the identical surname event.
  /// </summary>
  class IdenticalSurnameEventArgs : EventArgs
  {
    public Person User { get; set; }
    public string Message { get; set; }
  }
}
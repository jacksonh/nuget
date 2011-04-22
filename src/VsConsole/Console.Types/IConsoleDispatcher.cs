using System;

namespace NuGetConsole {
    /// <summary>
    /// IConsoleDispatcher dispatches and executes console command line inputs on the host.
    /// </summary>
    public interface IConsoleDispatcher {

        /// <summary>
        /// Start dispatching console command line inputs. This method can execute asynchronouly.
        /// </summary>
        void Start();

        /// <summary>
        /// Raised when the Start method completes asynchronously.
        /// </summary>
        event EventHandler StartCompleted;

        /// <summary>
        /// Indicates whether the StartCompleted event has raised.
        /// </summary>
        /// <returns></returns>
        bool IsStartCompleted { get; }

        /// <summary>
        /// Indicates whether the console is busy executing an earlier command;
        /// </summary>
        bool IsExecutingCommand { get; }

        /// <summary>
        /// Clear existing console content. This must be used if you want to clear the console
        /// content externally (not inside a host command execution). The console dispatcher manages
        /// console state, displays prompt, etc. Call this method to avoid interfere with user
        /// input dispatching.
        /// 
        /// On the other hand, if you need to clear the console content inside host command execution,
        /// use IConsole.Clear() instead.
        /// </summary>
        void ClearConsole();
    }
}
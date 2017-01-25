namespace Dregway.Interfaces.Input {
    interface InputInterface {
        /*
         * Intended usage of this class:   
         * (potentially asynchronously) maintain a queue of all incoming inputs,
         * each of which will either be rejected (usually no response),
         * or proceed to advance the game state. It may be worthwhile to put
         * a hard cap on the amount of inputs we can have in a queue at once,
         * and if we ever find that we actually end up with this happening a lot,
         * create convenience functions to deal with those issues.
         * 
         * The use of flush should probably be used upon entering things like menus, or yes/no dialogs,
         * where we (probably) wouldn't want to bleed random keystrokes inwards
         */

        /// <summary>
        /// will trigger any time a key is held down (not necessarily a keypress event) - alternatively, will use cached result from waitForInput if the buffer hasn't been cleared
        /// </summary>
        /// <returns>Integer keycode</returns>
        int getKey ();

        /// <summary>
        /// Should block until we recieve a keypressevent - alternatively, will use cached result from waitForInput if the buffer hasn't been cleared
        /// </summary>
        /// <returns>Keycode of key pressed</returns>
        int getKeyPressed ();

        /// <summary>
        /// Get or listen for a mouseclick, and report the location
        /// </summary>
        /// <param name="x">returns the x co-ordinate (in terms of tile space) of the mouse cursor - this is not gauranteed to be in bounds</param>
        /// <param name="y">returns the y co-ordinate (in terms of tile space) of the mouse cursor - this is not gauranteed to be in bounds</param>
        void getMouseClick (out int x, out int y);
        
        /// <summary>
        /// Delete any existing stack of input events not yet dealt with (if any exist)
        /// </summary>
        void clearBuffer ();

        /// <summary>
        /// Block until we recieve some form of input, give as result what type of input it was (we can get the specific type of input later using the cached version).
        /// If there already exists a cache of input, then we just grab the type of the top value from that cache.
        /// </summary>
        /// <returns>InputType -  the type of input to expect/check for</returns>
        InputType waitForInput ();
    }
}

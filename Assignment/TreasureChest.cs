using System;

namespace Assignment
{
    /// <summary>
    /// Represents a treasure chest.
    /// </summary>
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        // Default Constructor
        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        // Document these methods with XML documentation

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasureChest"/> class with the specified state.
        /// </summary>
        /// <param name="state">The initial state of the treasure chest.</param>
        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasureChest"/> class with the specified properties.
        /// </summary>
        /// <param name="material">The material of the treasure chest.</param>
        /// <param name="lockType">The lock type of the treasure chest.</param>
        /// <param name="lootQuality">The loot quality of the treasure chest.</param>
        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        // This is called a getter
        /// <summary>
        /// Gets the current state of the treasure chest.
        /// </summary>
        /// <returns>The state of the treasure chest.</returns>
        public State GetState()
        {
            return _state;
        }

        /// <summary>
        /// Manipulates the treasure chest based on the specified action.
        /// </summary>
        /// <param name="action">The action to perform on the treasure chest.</param>
        /// <returns>The updated state of the treasure chest.</returns>
        public State Manipulate(Action action)
        {
            switch (action)
            {
                case Action.Open:
                    Open();
                    break;
                case Action.Close:
                    Close();
                    break;
                case Action.Lock:
                    Lock();
                    break;
                case Action.Unlock:
                    Unlock();
                    break;
                default:
                    Console.WriteLine("Invalid input, please enter a valid selection");
                    break;
            }

            return _state; // Return the updated state of the chest
        }

        /// <summary>
        /// Unlocks the treasure chest.
        /// </summary>
        public void Unlock()
        {
            if (_state == State.Locked)
            {
                _state = State.Closed;
                Console.WriteLine("The chest is now unlocked.");
            }
            else
            {
                Console.WriteLine("The chest is already unlocked.");
            }
        }

        /// <summary>
        /// Locks the treasure chest.
        /// </summary>
        public void Lock()
        {
            if (_state == State.Closed)
            {
                _state = State.Locked;
                Console.WriteLine("The chest is now locked.");
            }
            else
            {
                Console.WriteLine("The chest must be closed before it can be locked.");
            }
        }

        /// <summary>
        /// Opens the treasure chest.
        /// </summary>
        public void Open()
        {
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        /// <summary>
        /// Closes the treasure chest.
        /// </summary>
        public void Close()
        {
            if (_state == State.Open)
            {
                _state = State.Closed;
                Console.WriteLine("The chest is now closed.");
            }
            else
            {
                Console.WriteLine("The chest is already closed.");
            }
        }

        /// <summary>
        /// Returns a string representation of the treasure chest.
        /// </summary>
        /// <returns>A string representation of the treasure chest.</returns>
        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}

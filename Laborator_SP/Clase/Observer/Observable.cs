﻿namespace Laborator_SP.Clase
{
    public interface Observable
    {
        public void addObserver(Observer obs);
        public void removeObserver(Observer obs);
        public void notifyObservers();
    }
}

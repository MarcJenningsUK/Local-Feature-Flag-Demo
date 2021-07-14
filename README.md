# Local-Feature-Flag-Demo
A lightweight, locally controlled demo for feature flag management.

Initialization of the feature flags is handled locally, in code at the time of first publishing.  It may easily be extended to load from an external source.

The control library is intended to be reusable across framework 4.7.2 projects, in particular WPF apps, and contains a basic implementation of an IValueConverter that is largely ready to use.

The code is extensible, in that it can be modified easily to call out to a third-party solution such as Azure App Configuration if required.

﻿// Copyright © 2020 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Threading;
using System.Threading.Tasks;
using Android.Content.Res;
using Android.Views;
using SilentNotes.Services;

namespace SilentNotes.Android.Services
{
    /// <summary>
    /// Implementation of the <see cref="IEnvironmentService"/> for the Android platform.
    /// </summary>
    internal class EnvironmentService : IEnvironmentService, IKeepScreenOn, IScreenshots
    {
        private readonly IAppContextService _appContext;
        private CancellationTokenSource _cancellationTokenSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentService"/> class.
        /// </summary>
        /// <param name="os">Sets the <see cref="Os"/> property.</param>
        /// <param name="appContextService">A service which knows about the current main activity.</param>
        public EnvironmentService(OperatingSystem os, IAppContextService appContextService)
        {
            Os = os;
            _appContext = appContextService;
        }

        /// <inheritdoc/>
        public OperatingSystem Os { get; private set; }

        /// <inheritdoc/>
        public bool InDarkMode
        {
            get
            {
                UiMode nightModeFlags = _appContext.RootActivity.Resources.Configuration.UiMode & UiMode.NightMask;
                return nightModeFlags == UiMode.NightYes;
            }
        }

        /// <inheritdoc/>
        public IKeepScreenOn KeepScreenOn
        {
            get { return this; }
        }

        /// <inheritdoc/>
        void IKeepScreenOn.Start()
        {
            _appContext.RootActivity.RunOnUiThread(() =>
            {
                _appContext.RootActivity.Window.AddFlags(WindowManagerFlags.KeepScreenOn);
                OnStateChanged(true);
            });
        }

        /// <inheritdoc/>
        void IKeepScreenOn.Stop()
        {
            var cancellationTokenSource = _cancellationTokenSource;
            _cancellationTokenSource = null;

            // If a timer is active, deactivate it.
            cancellationTokenSource?.Cancel();

            _appContext.RootActivity.RunOnUiThread(() =>
            {
                _appContext.RootActivity.Window.ClearFlags(WindowManagerFlags.KeepScreenOn);
                OnStateChanged(false);
            });
        }

        /// <inheritdoc/>
        void IKeepScreenOn.StopAfter(System.TimeSpan duration)
        {
            var cancellationTokenSource = _cancellationTokenSource;
            _cancellationTokenSource = null;

            // If a timer is already active, deactivate it.
            cancellationTokenSource?.Cancel();

            // Start or renew the timer
            _cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = _cancellationTokenSource.Token;
            Task.Delay(duration, token).ContinueWith(_ => { StopAfterTimeout(token); });
        }

        private void StopAfterTimeout(CancellationToken token)
        {
            _cancellationTokenSource = null;
            if (token.IsCancellationRequested)
                return;

            // Timer was not cancelled, so the KeepScreenOn should be stopped.
            _appContext.RootActivity.RunOnUiThread(() =>
            {
                _appContext.RootActivity.Window.ClearFlags(WindowManagerFlags.KeepScreenOn); // must be called on UI thread
                OnStateChanged(false);
            });
        }

        /// <inheritdoc/>
        public event System.EventHandler<bool> StateChanged;

        private void OnStateChanged(bool isStarted)
        {
            StateChanged?.Invoke(this, isStarted);
        }

        /// <inheritdoc/>
        public IScreenshots Screenshots
        {
            get { return this; }
        }

        /// <inheritdoc/>
        bool IScreenshots.PreventScreenshots
        {
            set
            {
                if (value)
                    _appContext.RootActivity.Window.AddFlags(WindowManagerFlags.Secure);
                else
                    _appContext.RootActivity.Window.ClearFlags(WindowManagerFlags.Secure);
            }
        }
    }
}
﻿// Copyright © 2018 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Threading.Tasks;
using SilentNotes.Models;
using SilentNotes.Services;

namespace SilentNotes.StoryBoards.SynchronizationStory
{
    /// <summary>
    /// This step is a possible entry point of the <see cref="SynchronizationStoryBoard"/>. It
    /// checks whether the cloud service is already defined in the settings.
    /// </summary>
    public class IsCloudServiceSetStep : SynchronizationStoryBoardStepBase
    {
        private readonly ISettingsService _settingsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="IsCloudServiceSetStep"/> class.
        /// </summary>
        public IsCloudServiceSetStep(Enum stepId, IStoryBoard storyBoard, ISettingsService settingsService)
            : base(stepId, storyBoard)
        {
            _settingsService = settingsService;
        }

        /// <inheritdoc/>
        public override async Task Run()
        {
            SettingsModel settings = _settingsService.LoadSettingsOrDefault();
            
            if (settings.HasCloudStorageClient)
            {
                StoryBoard.Session.Store(SynchronizationStorySessionKey.CloudStorageCredentials, settings.Credentials);
                await StoryBoard.ContinueWith(SynchronizationStoryStepId.ExistsCloudRepository);
            }
            else
            {
                await StoryBoard.ContinueWith(SynchronizationStoryStepId.ShowFirstTimeDialog);
            }
        }
    }
}

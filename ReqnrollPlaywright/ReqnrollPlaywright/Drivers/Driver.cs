using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqnrollPlaywright.Drivers

    // Makes Playwright a reusable object 
{
    public class Driver : IDisposable
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;
        private bool disposedValue;

        public Driver()
        {
            _page = InitializePlaywright();
        }

        public IPage Page => _page.Result;


        //initializes playwright object
        public async Task<IPage> InitializePlaywright()
        {
            var playwright = await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            return await _browser.NewPageAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Driver()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
